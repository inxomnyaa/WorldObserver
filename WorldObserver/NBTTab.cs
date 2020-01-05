using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fNbt;
using System.IO;
using WorldObserver.Windows;
using JetBrains.Annotations;
using System.Diagnostics;

namespace WorldObserver
{
    public partial class NBTTab : UserControl
    {

        public static NbtFile _nbtFile { get; set; }

        private List<TreeNode> Clipboard { get; set; } = new List<TreeNode>();

        private bool Changed = false;

        public TreeView _treeView
        {
            get
            {
                return treeViewNBT;
            }
            set
            {
                treeViewNBT = value;//TODO only nodes?
            }
        }

        public NbtFile _NBTFile
        {
            get
            {
                return _nbtFile;
            }
            set
            {
                _nbtFile = value;
            }
        }

        public NBTTab(NbtFile nbtFile)
        {
            InitializeComponent();
            _nbtFile = nbtFile;
            _treeView = treeViewNBT;
        }

        private void UpdateTree()
        {
            _treeView.Nodes.Clear();
            _treeView.Nodes.AddRange(new TreeNode[] { MainClass.LoadNBTTree(_nbtFile.RootTag) });
        }

        public TabPage GetPage()
        {
            TabPage tabPageNBT = new TabPage
            {
                Name = Path.GetFileName(_nbtFile.FileName),
                Padding = new Padding(3),
                Text = Path.GetFileName(_nbtFile.FileName),
                ToolTipText = Path.GetFullPath(_nbtFile.FileName),
                UseVisualStyleBackColor = true
            };
            UpdateTree();
            tabPageNBT.Controls.Add(_treeView);
            return tabPageNBT;
        }

        private void treeViewNBT_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeView view = sender as TreeView;
            if (e.Node.Nodes.Count > 0) return;
            KeyValuePair<List<int>, NbtTag> value = GetTagByNode(e.Node);
            NbtTag tag = value.Value;
            Debug.WriteLine(tag);
            List<int> indexes = value.Key;
            NbtTag newTag = EditTag(tag, e.Node);
            Debug.WriteLine(newTag);
            ///////////
            SetTag(indexes, tag, newTag);
            UpdateTree();
        }

        public static KeyValuePair<List<int>, NbtTag> GetTagByNode(TreeNode node)
        {
            List<int> indexes = GetIndexes(node);
            NbtTag tag = _nbtFile.RootTag;
            foreach (int index in indexes)
            {
                if (tag is NbtCompound)
                {
                    tag = ((NbtCompound)tag).ToArray()[index];
                }
                else if (tag is NbtList)
                {
                    tag = ((NbtList)tag).ToArray()[index];//TODO DOES NOT SAVE/CHANGE!!!!
                }
                else if (tag is NbtByteArray)//TODO cleanup/remove
                {
                    Debug.WriteLine("USING");
                    tag = new NbtByte(((NbtByteArray)tag).ByteArrayValue[index]);
                }
                else if (tag is NbtIntArray)//TODO cleanup/remove
                {
                    Debug.WriteLine("USING");
                    tag = new NbtInt(((NbtIntArray)tag).IntArrayValue[index]);
                }
                else
                {
                    (new AlertForm($"The index {index.ToString()} in Tag {tag.ToString()} could not be found due to the tag probably not having any subnodes!")
                    {
                        Text = "Finding NbtTag from tree error",
                        Icon = SystemIcons.Error
                    }).ShowDialog();
                    return new KeyValuePair<List<int>, NbtTag>(indexes, tag);//OR NULL?
                }
            }
            return new KeyValuePair<List<int>, NbtTag>(indexes, tag);
        }

        private static List<int> GetIndexes(TreeNode node)
        {
            List<int> indexes = new List<int>();
            while (node is TreeNode)
            {
                if (node.Parent is TreeNode)
                    indexes.Add(node.Index);
                node = node.Parent;
            }
            indexes.Reverse();
            return indexes;
        }

        private void SetTag(List<int> indexes, NbtTag oldTag, NbtTag newTag)
        {
            NbtCompound _copyTag = new NbtCompound(_nbtFile.RootTag);
            NbtTag current = oldTag;
            try
            {
            while (current != null)
            {
                Debug.WriteLine("Current");
                Debug.WriteLine(current.TagType);
                NbtTag parent = current.Parent;
                
                if (parent != null)
                {
                    ///////////////
                    if (current.Equals(oldTag) || parent is NbtByteArray || parent is NbtIntArray)
                    {
                        Debug.WriteLine("Equals");
                        switch (parent.TagType)
                        {
                            case NbtTagType.Compound:
                                {
                                    ((NbtCompound)parent).Remove(oldTag);
                                    ((NbtCompound)parent).Add(newTag);
                                    break;
                                }
                            case NbtTagType.List://TODO NOT GETTING CHANGED/SAVED!!!!!!
                                {
                                    ((NbtList)parent).Remove(oldTag);//? unnamed?
                                    ((NbtList)parent).Add(newTag);
                                    break;
                                }
                            case NbtTagType.ByteArray:
                                {
                                    //((NbtByteArray)current).Remove(oldTag);
                                    //((NbtByteArray)current).Add(newTag);
                                    byte[] val = ((NbtByteArray)current).ByteArrayValue;
                                    Debug.WriteLine(((NbtByte)current).Name);
                                    break;
                                }
                            case NbtTagType.IntArray:
                                {
                                    //((NbtIntArray)current).Remove(oldTag);
                                    //((NbtIntArray)current).Add(newTag);
                                    break;
                                }
                        }
                    }
                    ///////////////
                    Debug.WriteLine("Parent?");
                    Debug.WriteLine(parent.TagType);
                }
                else if (current is NbtCompound)
                {
                    _copyTag = new NbtCompound((NbtCompound)current);
                }
                current = parent;
            }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                Debug.WriteLine(current);
            }
            _nbtFile.RootTag = new NbtCompound(_copyTag);
        }

        public static NbtTag EditTag(NbtTag tag, TreeNode node)
        {
            try
            {
                if (tag is NbtByteArray)
                {
                    InputByteArrayTagForm inputForm = new InputByteArrayTagForm
                    {
                        NBTTag = (NbtByteArray)tag
                    };
                    DialogResult res = inputForm.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        tag = inputForm.NBTTag;
                        //Changed = true;
                        //UpdateTree();
                    }
                }
                else if (tag is NbtIntArray)
                {
                    InputIntArrayTagForm inputForm = new InputIntArrayTagForm
                    {
                        NBTTag = (NbtIntArray)tag
                    };
                    DialogResult res = inputForm.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        tag = inputForm.NBTTag;
                        //Changed = true;
                        //UpdateTree();
                    }
                }
                else
                {
                    InputTagForm inputForm = new InputTagForm
                    {
                        NBTTag = tag
                    };
                    DialogResult res = inputForm.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        tag = inputForm.NBTTag;
                        //Changed = true;
                        //UpdateTree();
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
            return tag;
        }

        public static NbtTag RenameTag(NbtTag tag, TreeNode node)
        {
            try
            {
                if (!(node.Parent is TreeNode))
                {
                    throw new WarningException("The node may not be renamed!");
                }
                RenameForm form = new RenameForm(tag);

                DialogResult res = form.ShowDialog();
                if (res == DialogResult.OK)
                {
                    tag = form.NBTTag;
                    //Changed = true;
                    //UpdateTree();
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
            return tag;
        }
    }
}
