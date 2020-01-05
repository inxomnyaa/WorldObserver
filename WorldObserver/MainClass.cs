using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fNbt;
using log4net;
using WorldObserver.Windows;

namespace WorldObserver
{
    class MainClass
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(MainClass));

        public static NbtFile LoadFile(string FilePath)
        {
            FilePath = FilePath.Trim();

            NbtFile file = new NbtFile();
            if (File.Exists(FilePath))
            {
                try
                {
                    file.LoadFromFile(FilePath);
                    /*Log.Info*/
                    Debug.WriteLine($"NBTFile: {file}");
                    return file;
                }
                catch (Exception e)//TODO leveldb format level.dat loading (mcpe)
                {
                    if (e is InvalidDataException)
                    {
                        Debug.WriteLine($"No valid data found at {FilePath}");
                        (new AlertForm($"Could not load file {Path.GetFileName(FilePath)} ({Path.GetFullPath(FilePath)}): Probably corrupted file\n\n{e}")
                        {
                            Icon = SystemIcons.Error,
                            Text = "Loading error"
                        }).ShowDialog();
                    }
                    else
                    {
                        (new AlertForm($"Error of type {e.GetType()} occurred, please report this error to GitHub!\n\n{e}")
                        {
                            Text = "Error!",
                            Icon = System.Drawing.SystemIcons.Error
                        }).ShowDialog();
                    }
                }
            }
            else
            {
                /*Log.Warn*/
                Debug.WriteLine($"File not found at {FilePath}");
                return null;
            }
            return null;
        }

        public static World LoadWorld(string FilePath)
        {
            NbtFile file = LoadFile(FilePath);
            //var levelFileName = Path.Combine(FilePath, "level.dat");
            if (file is NbtFile)
            {
                NbtTag dataTag = file.RootTag["Data"];
                if (dataTag == null || !(dataTag is NbtCompound))
                {
                    /*Log.Info*/
                    Debug.WriteLine($"Invalid root tag!");
                    return null;
                }
                World world = new World((NbtCompound)dataTag)
                {
                    BasePath = Path.GetFullPath(FilePath)
                };
                /*Log.Info*/
                Debug.WriteLine($"Found valid data file at {FilePath}, loading");
                /*Log.Info*/
                Debug.WriteLine($"World: {world}");
                return world;
            }
            else
            {
                /*Log.Warn*/
                Debug.WriteLine($"No valid data found at {FilePath}");
                return null;
            }
        }

        public static DatFile LoadNBT(string FilePath)
        {
            try
            {
                NbtFile file = LoadFile(FilePath);
                if (file is NbtFile)
                {
                    NbtTag dataTag = file.RootTag;
                    if (dataTag == null || !(dataTag is NbtCompound))
                    {
                        /*Log.Info*/
                        Debug.WriteLine($"Invalid root tag!");
                        return null;
                    }
                    DatFile datFile = new DatFile((NbtCompound)dataTag)
                    {
                        BasePath = Path.GetFullPath(FilePath)
                    };
                    /*Log.Info*/
                    Debug.WriteLine($"Found valid data file at {FilePath}, loading");
                    /*Log.Info*/
                    Debug.WriteLine($"DatFile: {datFile}");
                    return datFile;
                }
            }
            catch (Exception e)
            {
                if (e is InvalidDataException)
                {
                    Debug.WriteLine($"No valid data found at {FilePath}");
                }
            }
            return null;
        }

        public static TreeNode LoadNBTTree(NbtTag nbtTag)
        {
            TreeNode tree = new TreeNode();
            if (nbtTag != null)
            {
                foreach (NbtTag tag in ((nbtTag is NbtCompound) ? ((NbtCompound)nbtTag).Tags : ((nbtTag is NbtList) ? ((NbtList)nbtTag).ToArray() : null)))
                {

                    switch (tag.TagType)
                    {
                        case NbtTagType.Unknown:
                            break;
                        case NbtTagType.End:
                            break;
                        case NbtTagType.Byte:
                            Debug.WriteLine($"Tag: {tag.TagType}, Name: {tag.Name}, Value: {tag.ByteValue.ToString()}");
                            tree.Nodes.Add(tag.Name, tag.Name + ": " + tag.ByteValue.ToString(), "buttonbyte.png", "buttonbyte.png");
                            break;
                        case NbtTagType.Short:
                            Debug.WriteLine($"Tag: {tag.TagType}, Name: {tag.Name}, Value: {tag.ShortValue.ToString()}");
                            tree.Nodes.Add(tag.Name, tag.Name + ": " + tag.ShortValue.ToString(), "buttonshort.png", "buttonshort.png");
                            break;
                        case NbtTagType.Int:
                            Debug.WriteLine($"Tag: {tag.TagType}, Name: {tag.Name}, Value: {tag.IntValue.ToString()}");
                            tree.Nodes.Add(tag.Name, tag.Name + ": " + tag.IntValue.ToString(), "buttonint.png", "buttonint.png");
                            break;
                        case NbtTagType.Long:
                            Debug.WriteLine($"Tag: {tag.TagType}, Name: {tag.Name}, Value: {tag.LongValue.ToString()}");
                            tree.Nodes.Add(tag.Name, tag.Name + ": " + tag.LongValue.ToString(), "buttonlong.png", "buttonlong.png");
                            break;
                        case NbtTagType.Float:
                            Debug.WriteLine($"Tag: {tag.TagType}, Name: {tag.Name}, Value: {tag.FloatValue.ToString()}");
                            tree.Nodes.Add(tag.Name, tag.Name + ": " + tag.FloatValue.ToString(), "buttonfloat.png", "buttonfloat.png");
                            break;
                        case NbtTagType.Double:
                            Debug.WriteLine($"Tag: {tag.TagType}, Name: {tag.Name}, Value: {tag.DoubleValue.ToString()}");
                            tree.Nodes.Add(tag.Name, tag.Name + ": " + tag.DoubleValue.ToString(), "buttondouble.png", "buttondouble.png");
                            break;
                        case NbtTagType.String:
                            Debug.WriteLine($"Tag: {tag.TagType}, Name: {tag.Name}, Value: {tag.StringValue.ToString()}");
                            tree.Nodes.Add(tag.Name, tag.Name + ": " + tag.StringValue.ToString(), "buttonstring.png", "buttonstring.png");
                            break;
                        case NbtTagType.List:
                            Debug.WriteLine($"Tag: {tag.TagType}, Name: {tag.Name}");
                            //TODO
                            TreeNode listNode = new TreeNode()
                            {
                                ImageKey = "buttonlist.png",
                                SelectedImageKey = "buttonlist.png"
                            };
                            foreach (TreeNode subNode in LoadNBTTree((NbtList)tag)?.Nodes)
                            {
                                listNode.Nodes.Add(subNode);
                            }
                            listNode.Name = listNode.Text = tag.Name + $": {listNode.Nodes.Count} entries";
                            Debug.WriteLine($"Tag: {tag.TagType}, Name: {tag.Name}, tag ToString: {tag}, listNode ToString: {listNode}");
                            tree.Nodes.Add(listNode);
                            break;
                        case NbtTagType.Compound:
                            TreeNode compoundNode = new TreeNode()
                            {
                                ImageKey = "buttoncompound.png",
                                SelectedImageKey = "buttoncompound.png"
                            };
                            foreach (TreeNode subNode in LoadNBTTree((NbtCompound)tag)?.Nodes)
                            {
                                compoundNode.Nodes.Add(subNode);
                            }
                            compoundNode.Name = compoundNode.Text = $"{tag.Name}: {compoundNode.Nodes.Count} entries";
                            Debug.WriteLine($"Tag: {tag.TagType}, Name: {tag.Name}, tag ToString: {tag}, compoundNode Name: {compoundNode.Name}");
                            tree.Nodes.Add(compoundNode);
                            break;
                        case NbtTagType.ByteArray:
                            Debug.WriteLine($"Tag: {tag.TagType}, Name: {tag.Name}, Length: {tag.ByteArrayValue.Length}");
                            TreeNode tnb = tree.Nodes.Add(tag.Name, tag.Name + ": " + tag.ByteArrayValue.Length + " bytes", "buttonbytearray.png", "buttonbytearray.png");
                            /*foreach (string s in ByteArrayToStringArray(tag.ByteArrayValue))
                            {
                                tnb.Nodes.Add(tag.Name, s, "buttonbyte.png", "buttonbyte.png");
                            }*/
                            break;
                        case NbtTagType.IntArray:
                            Debug.WriteLine($"Tag: {tag.TagType}, Name: {tag.Name}, Length: {tag.IntArrayValue.Length}");
                            TreeNode tni = tree.Nodes.Add(tag.Name, tag.Name + ": " + tag.IntArrayValue.Length + " integers", "buttonintarray.png", "buttonintarray.png");
                            /*foreach (string s in IntArrayToStringArray(tag.IntArrayValue))
                            {
                                tni.Nodes.Add(tag.Name, s, "buttonint.png", "buttonint.png");
                            }*/
                            break;
                        default:
                            Debug.WriteLine($"Tag: {tag.TagType}, Name: {tag.Name}, ToString: {tag.ToString()}");
                            throw new ArgumentOutOfRangeException();
                    }
                }
            }
            return tree;
        }

        public static NbtTag TreeToNBT(TreeNodeCollection tree)
        {
            NbtTag NBTTag = null;
            if (tree != null)
            {
                foreach (TreeNode node in tree)
                {
                    string value = node.Text.Replace($"{node.Name}: ", string.Empty).Replace(".", ",");//TODO , or . by language
                    try
                    {
                        switch (node.ImageKey)
                        {
                            case "buttonstring.png":
                                {
                                    NBTTag = new NbtString(node.Name, value);
                                    break;
                                }
                            case "buttonint.png":
                                {
                                    NBTTag = new NbtInt(node.Name, int.Parse(value));
                                    break;
                                }
                            case "buttonbyte.png":
                                {
                                    NBTTag = new NbtByte(node.Name, byte.Parse(value));
                                    break;
                                }
                            case "buttonlong.png":
                                {
                                    NBTTag = new NbtLong(node.Name, long.Parse(value));
                                    break;
                                }
                            case "buttonshort.png":
                                {
                                    NBTTag = new NbtShort(node.Name, short.Parse(value));
                                    break;
                                }
                            case "buttonfloat.png":
                                {
                                    NBTTag = new NbtFloat(node.Name, float.Parse(value));
                                    break;
                                }
                            case "buttondouble.png":
                                {
                                    NBTTag = new NbtDouble(node.Name, double.Parse(value));
                                    break;
                                }
                            case "buttoncompound.png":
                                {
                                    NBTTag = new NbtCompound(node.Name);
                                    foreach (object c in node.Nodes)
                                    {
                                        (new AlertForm(c.ToString())).ShowDialog();
                                        if (c is TreeNode && ((TreeNode)c).Nodes.Count > 0)
                                            ((NbtCompound)NBTTag).Add(TreeToNBT(((TreeNode)c).Nodes));
                                        else
                                            (new AlertForm(c.GetType().ToString())).ShowDialog();
                                    }
                                    break;
                                }
                            case "buttonlist.png":
                                {
                                    NBTTag = new NbtList(node.Name);
                                    foreach (object c in node.Nodes)
                                    {
                                        (new AlertForm(c.ToString())).ShowDialog();
                                        if (c is TreeNode && ((TreeNode)c).Nodes.Count > 0)
                                            ((NbtList)NBTTag).Add(TreeToNBT(((TreeNode)c).Nodes));
                                        else
                                            (new AlertForm(c.GetType().ToString())).ShowDialog();
                                    }
                                    break;
                                }
                            case "buttonbytearray.png":
                                {
                                    NBTTag = new NbtByteArray(node.Name, NodesToByteArray(node.Nodes));
                                            (new AlertForm(NBTTag.ToString())).ShowDialog();
                                    break;
                                }
                            case "buttonintarray.png":
                                {
                                    NBTTag = new NbtIntArray(node.Name, NodesToIntArray(node.Nodes));
                                    (new AlertForm(NBTTag.ToString())).ShowDialog();
                                    break;
                                }
                            default:
                                {
                                    throw new WarningException($"Warning: unhandeled node {node.ImageKey} can not be edited");
                                }
                        }
                    }
                    catch (Exception exception)
                    {
                        if (exception is InvalidOperationException || exception is WarningException)
                        {
                            new AlertForm(exception.ToString())
                            {
                                Text = "Warning!",
                                Icon = System.Drawing.SystemIcons.Warning
                            }.ShowDialog();
                        }
                        else
                        {
                            new AlertForm(exception.ToString())
                            {
                                Text = exception.GetType().ToString(),
                                Icon = System.Drawing.SystemIcons.Error
                            }.ShowDialog();
                        }
                    }
                }
            }
            return NBTTag;
        }

        public static byte[] CharToByteArray(char[] source)
        {
            byte[] val = new byte[source.Length];
            int i = 0;
            foreach (char c in source)
            {
                val[i] = byte.Parse(c.ToString());
                i++;
            }
            return val;
        }

        public static byte[] StringToByteArray(string[] source)
        {
            byte[] val = new byte[source.Length];
            int i = 0;
            foreach (string c in source)
            {
                val[i] = byte.Parse(c);
                i++;
            }
            return val;
        }

        public static int[] CharToIntArray(char[] source)
        {
            int[] val = new int[source.Length];
            int i = 0;
            foreach (char c in source)
            {
                val[i] = int.Parse(c.ToString());
                i++;
            }
            return val;
        }

        public static int[] StringToIntArray(string[] source)
        {
            int[] val = new int[source.Length];
            int i = 0;
            foreach (string c in source)
            {
                val[i] = int.Parse(c);
                i++;
            }
            return val;
        }

        public static byte[] NodesToByteArray(TreeNodeCollection source)
        {
            byte[] val = new byte[source.Count];
            int i = 0;
            foreach (TreeNode node in source)
            {
                val[i] = byte.Parse(node.Text);
                i++;
            }
            return val;
        }

        public static int[] NodesToIntArray(TreeNodeCollection source)
        {
            int[] val = new int[source.Count];
            int i = 0;
            foreach (TreeNode node in source)
            {
                val[i] = int.Parse(node.Text);
                i++;
            }
            return val;
        }

        public static string[] ByteArrayToStringArray(byte[] source)
        {
            string[] val = new string[source.Length];
            int i = 0;
            foreach (byte c in source)
            {
                val[i] = c.ToString();
                i++;
            }
            return val;
        }

        public static string[] IntArrayToStringArray(int[] source)
        {
            string[] val = new string[source.Length];
            int i = 0;
            foreach (int c in source)
            {
                val[i] = c.ToString();
                i++;
            }
            return val;
        }

        //NAMESPACE END
    }

    public interface INBTFile
    {

        string BasePath { get; set; }
        NbtCompound _nbtTag { get; set; }
        TreeNode _tree { get; set; }
    }

    public class DatFile : INBTFile
    {

        public string BasePath { get; set; }
        public NbtCompound _nbtTag { get; set; }
        public TreeNode _tree { get; set; }

        public DatFile(NbtCompound nbtTag)
        {
            _nbtTag = nbtTag;
            _tree = MainClass.LoadNBTTree(_nbtTag);
        }
    }

    public class World : INBTFile
    {

        public string BasePath { get; set; }
        public NbtCompound _nbtTag { get; set; }
        public TreeNode _tree { get; set; }
        //TODO automatically load player data

        public World(NbtCompound nbtTag)
        {
            _nbtTag = nbtTag;
            _tree = MainClass.LoadNBTTree(_nbtTag);
        }
    }
}