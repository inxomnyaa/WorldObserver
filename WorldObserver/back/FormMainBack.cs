/*using fNbt;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WorldObserver.Windows;

namespace WorldObserver
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Loading");
            Status = "Initializing app";
            Progress = 100;
            WorldObserver.Properties.Settings settings = WorldObserver.Properties.Settings.Default;
            if (settings.UseMinecraftFont)//TODO check is installed? actually defaults to MSS :o
            {
                //install font WorldObserver.Properties.Resources.Minecraft_German
                MainTabControl.Font = new Font("Minecraft German", (float)8);
                useMinecraftFontToolStripMenuItem.Checked = true;
            }
            else
            {
                MainTabControl.Font = new Font("Microsoft Sans Serif", (float)8.25);
                useMinecraftFontToolStripMenuItem.Checked = false;//CLEANUP needed?
            }
            Status = "Idle";
            Progress = 0;
        }

        private List<KeyValuePair<string, NbtCompound>> rootTags = new List<KeyValuePair<string, NbtCompound>>();

        private List<TreeNode> Clipboard { get; set; } = new List<TreeNode>();

        private bool Changed = false;

        private bool ContainsPage(TabControl control, TabPage page)
        {
            foreach (TabPage tabPage in control.TabPages)
            {
                if (tabPage.Name == page.Name) return true;
            }
            return false;
        }

        private bool ContainsPage(TabControl control, string pageName)
        {
            foreach (TabPage tabPage in control.TabPages)
            {
                if (tabPage.Name == pageName) return true;
            }
            return false;
        }

        private TabPage GetPage(TabControl control, string name)
        {
            foreach (TabPage tabPage in control.TabPages)
            {
                if (tabPage.Name == name) return tabPage;
            }
            return null;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Multiselect = true,
                Filter = "NBT Files (*.dat, *.schematic, *.nbt)|*.dat;*.nbt;*.schematic|Region Files (*.mca, *.mcr)|*.mca;*.mcr|All Files|*",
                InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft", "saves")
            };

            DialogResult result = dialog.ShowDialog();
            Debug.WriteLine($"Open file dialog result: {result.ToString()}");
            foreach (string fileName in dialog.FileNames)
            {
                Debug.WriteLine($"Opening file: {fileName}");
                foreach (TabPage page in tabControlNBT.TabPages)//TODO optimize
                {
                    if (page.Name == fileName)
                    {
                        (new AlertForm($"The file {Path.GetFileName(fileName)} ({fileName}) is already opened!")
                        {
                            Icon = SystemIcons.Warning,
                            Text = "Opening warning"
                        }).ShowDialog();
                        return;
                    }
                }
                Debug.WriteLine($"Extension: {Path.GetExtension(fileName)}");
                switch (Path.GetExtension(fileName))
                {
                    case ".dat":
                    case ".schematic":
                    case ".nbt":
                        {
                            DatFile datFile = MainClass.LoadNBT(fileName);

                            if (datFile == null)
                            {
                                Debug.WriteLine("DatFile is null");
                                return;
                            }
                            if (datFile._nbtTag == null)
                            {
                                Debug.WriteLine("DatFile _nbtTag is null");
                                return;
                            }
                            datFile._tree = MainClass.LoadNBTTree(datFile._nbtTag);//TODO CLEANUP?
                            if (datFile._tree == null)
                            {
                                Debug.WriteLine("DatFile _tree is null");
                                return;
                            }
                            (new AlertForm(((NbtCompound)datFile._nbtTag).ToString())).ShowDialog();

                            /*ContextMenu contextMenu = new ContextMenu();
                            contextMenu.MenuItems.Add(new MenuItem()
                            {
                                Text = "Close"
                            });//TODO add actions
                            contextMenu.MenuItems.Add(new MenuItem()
                            {
                                Text = "Save && Close"
                            });* /

                            rootTags.Add(new KeyValuePair<string, NbtCompound>(Path.GetFullPath(fileName), datFile._nbtTag));
                            TabPage tabPageNBT = new TabPage
                            {
                                Name = fileName,
                                Padding = new Padding(3),
                                Text = Path.GetFileName(fileName),
                                ToolTipText = Path.GetFullPath(fileName),
                                UseVisualStyleBackColor = true,
                                //ContextMenu = contextMenu
                            };

                            TreeView treeViewNBT = new TreeView
                            {
                                Dock = DockStyle.Fill,
                                ImageList = this.imageList1,
                                Name = "tree" + Path.GetFileNameWithoutExtension(fileName),
                            };
                            treeViewNBT.DoubleClick += new System.EventHandler(this.treeViewNBT_DoubleClick);
                            tabPageNBT.Controls.Add(treeViewNBT);
                            tabControlNBT.TabPages.Add(tabPageNBT);
                            tabControlNBT.SelectedTab = tabPageNBT;

                            treeViewNBT.Nodes.Clear();
                            foreach (TreeNode node in datFile._tree.Nodes)
                            {
                                treeViewNBT.Nodes.Add(node);
                            }
                            if (datFile._tree.Nodes == null)
                            {
                                Debug.WriteLine("DatFile datFile._tree.Nodes is null");
                                return;
                            }
                            if (treeViewNBT.Nodes == null)
                            {
                                Debug.WriteLine("DatFile treeViewNBT.Nodes is null");
                                return;
                            }
                            break;
                        }
                    default:
                        {
                            (new AlertForm($"Could not load file {Path.GetFileNameWithoutExtension(fileName)}: Unknown format")
                            {
                                Icon = SystemIcons.Information,
                                Text = "Loading error"
                            }).ShowDialog();
                            break;
                        }
                }
            }
        }

        private void treeViewNBT_DoubleClick(object sender, EventArgs e)
        {
            if (((MouseEventArgs)e).Button != MouseButtons.Left) return;
            TreeView tree = (TreeView)sender;
            TreeNode node = tree.SelectedNode;
            EditTag(tree, node);
        }

        private void EditTag(TreeView tree, [CanBeNull]TreeNode node)
        {
            if (node == null) return;
            InputTagForm inputForm = new InputTagForm();
            string value = node.Text.Replace($"{node.Name}: ", string.Empty).Replace(".", ",");//TODO , or . by language
            try
            {
                switch (node.ImageKey)
                {
                    case "buttonstring.png":
                        {
                            inputForm.NBTTag = new NbtString(node.Name, value);
                            //TODO set icon
                            break;
                        }
                    case "buttonint.png":
                        {
                            inputForm.NBTTag = new NbtInt(node.Name, int.Parse(value));
                            //TODO set icon
                            break;
                        }
                    case "buttonbyte.png":
                        {
                            inputForm.NBTTag = new NbtByte(node.Name, byte.Parse(value));
                            //TODO set icon
                            break;
                        }
                    case "buttonlong.png":
                        {
                            inputForm.NBTTag = new NbtLong(node.Name, long.Parse(value));
                            //TODO set icon
                            break;
                        }
                    case "buttonshort.png":
                        {
                            inputForm.NBTTag = new NbtShort(node.Name, short.Parse(value));
                            //TODO set icon
                            break;
                        }
                    case "buttonfloat.png":
                        {
                            inputForm.NBTTag = new NbtFloat(node.Name, float.Parse(value));
                            //TODO set icon
                            break;
                        }
                    case "buttondouble.png":
                        {
                            inputForm.NBTTag = new NbtDouble(node.Name, double.Parse(value));
                            //TODO set icon
                            break;
                        }
                    /*case "buttoncompound.png":
                        {
                            inputForm.Type = "Compound";
                            //TODO set icon
                            //TODO custom edit form
                            break;
                        }
                    case "buttonlist.png":
                        {
                            inputForm.Type = "List";
                            //TODO set icon
                            //TODO custom edit form
                            break;
                        }* /
                    case "buttonbytearray.png":
                        {

                            //inputForm.NBTTag = new NbtByteArray(node.Name, byte[].Parse(value));
                            //TODO set icon
                            //TODO custom edit form
                            break;
                        }
                    case "buttonintarray.png":
                        {
                            //inputForm.NBTTag = new NbtIntArray(node.Name, int[].Parse(value));
                            //TODO set icon
                            //TODO custom edit form
                            break;
                        }
                    default:
                        {
                            throw new WarningException($"Warning: unhandeled node {node.ImageKey} can not be edited");
                        }
                }
                DialogResult res = inputForm.ShowDialog();
                if (res == DialogResult.OK)
                {
                    node.Text = $"{node.Name}: " + inputForm.NBTTag.StringValue.ToString().Replace(".", ",");//TODO , or . by language
                    Changed = true;
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

        private void RenameTag(TreeView tree, [CanBeNull]TreeNode node)
        {
            if (node == null) return;
            RenameForm form = new RenameForm();
            string value = node.Name;
            form.Result = value;

            DialogResult res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                node.Text = $"{form.Result}: " + node.Text.Replace($"{node.Name}: ", string.Empty).Replace(".", ",");//TODO , or . by language
                node.Name = form.Result;
                Changed = true;
            }
        }

        public int Progress
        {
            get
            {
                return toolStripProgressBar1.ProgressBar.Value;
            }
            set
            {
                toolStripProgressBar1.ProgressBar.Value = value;

            }
        }

        public string Status
        {
            get
            {
                return (toolStripStatusLabel1.Text == string.Empty ? "Idle" : toolStripStatusLabel1.Text);
            }
            set
            {
                toolStripStatusLabel1.Text = (value == string.Empty ? "Idle" : value);
            }
        }

        private void useMinecraftFontToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            WorldObserver.Properties.Settings settings = WorldObserver.Properties.Settings.Default;
            settings.UseMinecraftFont = ((ToolStripMenuItem)sender).Checked;
            settings.Save();
            if (settings.UseMinecraftFont)
            {
                MainTabControl.Font = new Font("Minecraft German", (float)8);
            }
            else
            {
                MainTabControl.Font = new Font("Microsoft Sans Serif", (float)8.25);
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AboutBox()).ShowDialog();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButtonNBTEdit_Click(object sender, EventArgs e)
        {
            foreach (object o in tabControlNBT.SelectedTab.Controls)
            {
                if (o is TreeView)
                {
                    EditTag((TreeView)o, ((TreeView)o).SelectedNode);
                    break;
                }
            }
        }

        private void toolStripButtonNBTRename_Click(object sender, EventArgs e)
        {
            foreach (object o in tabControlNBT.SelectedTab.Controls)
            {
                if (o is TreeView)
                {
                    RenameTag((TreeView)o, ((TreeView)o).SelectedNode);
                    break;
                }
            }
        }

        private void toolStripButtonNBTDelete_Click(object sender, EventArgs e)
        {
            foreach (object o in tabControlNBT.SelectedTab.Controls)
            {
                if (o is TreeView)
                {
                    DeleteTagForm form = new DeleteTagForm
                    {
                        Result = $"Are you sure you want to delete the tag {((TreeView)o).SelectedNode.Name} (value: {((TreeView)o).SelectedNode.Text.Replace($"{((TreeView)o).SelectedNode.Name}: ", string.Empty)})?"
                    };
                    if ((DialogResult)form.ShowDialog() == DialogResult.OK)
                    {
                        ((TreeView)o).Nodes.Remove(((TreeView)o).SelectedNode);
                        Changed = true;
                    }
                    break;
                }
            }
        }

        private void toolStripButtonNBTCut_Click(object sender, EventArgs e)
        {
            foreach (object o in tabControlNBT.SelectedTab.Controls)
            {
                if (o is TreeView)
                {
                    Clipboard.Clear();
                    Clipboard.Add(((TreeView)o).SelectedNode);
                    ((TreeView)o).Nodes.Remove(((TreeView)o).SelectedNode);
                    Changed = true;
                    break;
                }
            }
        }

        private void toolStripButtonNBTCopy_Click(object sender, EventArgs e)
        {
            foreach (object o in tabControlNBT.SelectedTab.Controls)
            {
                if (o is TreeView)
                {
                    Clipboard.Clear();
                    Clipboard.Add(((TreeView)o).SelectedNode);
                    break;
                }
            }
        }

        private void toolStripButtonNBTPaste_Click(object sender, EventArgs e)
        {
            foreach (object o in tabControlNBT.SelectedTab.Controls)
            {
                if (o is TreeView)
                {
                    foreach (TreeNode node in Clipboard)
                    {
                        if (((TreeView)o).SelectedNode != null)
                        {
                            ((TreeView)o).SelectedNode.Nodes.Add((TreeNode)node.Clone());
                        }
                        else
                        {
                            ((TreeView)o).Nodes.Add((TreeNode)node.Clone());
                        }
                    }
                    Changed = true;
                    break;
                }
            }
        }

        private void toolStripButtonNBTCutAdd_Click(object sender, EventArgs e)
        {
            foreach (object o in tabControlNBT.SelectedTab.Controls)
            {
                if (o is TreeView)
                {
                    Clipboard.Add(((TreeView)o).SelectedNode);
                    ((TreeView)o).Nodes.Remove(((TreeView)o).SelectedNode);
                    Changed = true;
                    break;
                }
            }
        }

        private void toolStripButtonNBTCopyAdd_Click(object sender, EventArgs e)
        {
            foreach (object o in tabControlNBT.SelectedTab.Controls)
            {
                if (o is TreeView)
                {
                    Clipboard.Add(((TreeView)o).SelectedNode);
                    break;
                }
            }
        }


        /*
         * TODO: CLEANUP!!!!
         * /
        private void toolStripButtonString_Click(object sender, EventArgs e)
        {
            foreach (object o in tabControlNBT.SelectedTab.Controls)
            {
                if (o is TreeView)
                {
                    AddTagForm form = new AddTagForm(new NbtString());
                    if ((DialogResult)form.ShowDialog() == DialogResult.OK)
                    {
                        ((TreeView)o).SelectedNode.Nodes.Add(new TreeNode()
                        {
                            Name = form.NBTTag.Name,
                            Text = $"{form.NBTTag.Name}: " + form.NBTTag.StringValue.ToString().Replace(".", ","),//TODO , or . by language
                            ImageKey = "buttonstring.png",
                            SelectedImageKey = "buttonstring.png"
                        });
                        Changed = true;
                    }
                    break;
                }
            }
        }

        private void toolStripButtonByte_Click(object sender, EventArgs e)
        {
            foreach (object o in tabControlNBT.SelectedTab.Controls)
            {
                if (o is TreeView)
                {
                    AddTagForm form = new AddTagForm(new NbtByte());
                    if ((DialogResult)form.ShowDialog() == DialogResult.OK)
                    {
                        ((TreeView)o).SelectedNode.Nodes.Add(new TreeNode()
                        {
                            Name = form.NBTTag.Name,
                            Text = $"{form.NBTTag.Name}: " + form.NBTTag.StringValue.ToString().Replace(".", ","),//TODO , or . by language
                            ImageKey = "buttonbyte.png",
                            SelectedImageKey = "buttonbyte.png"
                        });
                        Changed = true;
                    }
                    break;
                }
            }
        }

        private void toolStripButtonInt_Click(object sender, EventArgs e)
        {
            foreach (object o in tabControlNBT.SelectedTab.Controls)
            {
                if (o is TreeView)
                {
                    AddTagForm form = new AddTagForm(new NbtInt());
                    if ((DialogResult)form.ShowDialog() == DialogResult.OK)
                    {
                        ((TreeView)o).SelectedNode.Nodes.Add(new TreeNode()
                        {
                            Name = form.NBTTag.Name,
                            Text = $"{form.NBTTag.Name}: " + form.NBTTag.StringValue.ToString().Replace(".", ","),//TODO , or . by language
                            ImageKey = "buttonint.png",
                            SelectedImageKey = "buttonint.png"
                        });
                        Changed = true;
                    }
                    break;
                }
            }
        }

        private void toolStripButtonShort_Click(object sender, EventArgs e)
        {
            foreach (object o in tabControlNBT.SelectedTab.Controls)
            {
                if (o is TreeView)
                {
                    AddTagForm form = new AddTagForm(new NbtShort());
                    if ((DialogResult)form.ShowDialog() == DialogResult.OK)
                    {
                        ((TreeView)o).SelectedNode.Nodes.Add(new TreeNode()
                        {
                            Name = form.NBTTag.Name,
                            Text = $"{form.NBTTag.Name}: " + form.NBTTag.StringValue.ToString().Replace(".", ","),//TODO , or . by language
                            ImageKey = "buttonshort.png",
                            SelectedImageKey = "buttonshort.png"
                        });
                        Changed = true;
                    }
                    break;
                }
            }
        }

        private void toolStripButtonDouble_Click(object sender, EventArgs e)
        {
            foreach (object o in tabControlNBT.SelectedTab.Controls)
            {
                if (o is TreeView)
                {
                    AddTagForm form = new AddTagForm(new NbtDouble());
                    if ((DialogResult)form.ShowDialog() == DialogResult.OK)
                    {
                        ((TreeView)o).SelectedNode.Nodes.Add(new TreeNode()
                        {
                            Name = form.NBTTag.Name,
                            Text = $"{form.NBTTag.Name}: " + form.NBTTag.StringValue.ToString().Replace(".", ","),//TODO , or . by language
                            ImageKey = "buttondouble.png",
                            SelectedImageKey = "buttondouble.png"
                        });
                        Changed = true;
                    }
                    break;
                }
            }
        }

        private void toolStripButtonFloat_Click(object sender, EventArgs e)
        {
            foreach (object o in tabControlNBT.SelectedTab.Controls)
            {
                if (o is TreeView)
                {
                    AddTagForm form = new AddTagForm(new NbtFloat());
                    if ((DialogResult)form.ShowDialog() == DialogResult.OK)
                    {
                        ((TreeView)o).SelectedNode.Nodes.Add(new TreeNode()
                        {
                            Name = form.NBTTag.Name,
                            Text = $"{form.NBTTag.Name}: " + form.NBTTag.StringValue.ToString().Replace(".", ","),//TODO , or . by language
                            ImageKey = "buttonfloat.png",
                            SelectedImageKey = "buttonfloat.png"
                        });
                        Changed = true;
                    }
                    break;
                }
            }
        }

        private void toolStripButtonLong_Click(object sender, EventArgs e)
        {
            foreach (object o in tabControlNBT.SelectedTab.Controls)
            {
                if (o is TreeView)
                {
                    AddTagForm form = new AddTagForm(new NbtLong());
                    if ((DialogResult)form.ShowDialog() == DialogResult.OK)
                    {
                        ((TreeView)o).SelectedNode.Nodes.Add(new TreeNode()
                        {
                            Name = form.NBTTag.Name,
                            Text = $"{form.NBTTag.Name}: " + form.NBTTag.StringValue.ToString().Replace(".", ","),//TODO , or . by language
                            ImageKey = "buttonlong.png",
                            SelectedImageKey = "buttonlong.png"
                        });
                        Changed = true;
                    }
                    break;
                }
            }
        }

        private void toolStripButtonByteArray_Click(object sender, EventArgs e)
        {
            foreach (object o in tabControlNBT.SelectedTab.Controls)
            {
                if (o is TreeView)
                {
                    AddTagForm form = new AddTagForm(new NbtByteArray());
                    if ((DialogResult)form.ShowDialog() == DialogResult.OK)
                    {
                        if (form.NBTTag is NbtByteArray)//TODO!
                        {
                            Debug.WriteLine(form.NBTTag.ByteArrayValue);
                            break;
                        }
                        ((TreeView)o).SelectedNode.Nodes.Add(new TreeNode()
                        {
                            Name = form.NBTTag.Name,
                            Text = $"{form.NBTTag.Name}: " + form.NBTTag.StringValue.ToString().Replace(".", ","),//TODO , or . by language
                            ImageKey = "buttonbytearray.png",
                            SelectedImageKey = "buttonbytearray.png"
                        });
                        Changed = true;
                    }
                    break;
                }
            }
        }

        private void toolStripButtonIntArray_Click(object sender, EventArgs e)
        {
            foreach (object o in tabControlNBT.SelectedTab.Controls)
            {
                if (o is TreeView)
                {
                    AddTagForm form = new AddTagForm(new NbtIntArray());
                    if ((DialogResult)form.ShowDialog() == DialogResult.OK)
                    {
                        if (form.NBTTag is NbtIntArray)//TODO!
                        {
                            Debug.WriteLine(form.NBTTag.IntArrayValue);
                            break;
                        }
                        ((TreeView)o).SelectedNode.Nodes.Add(new TreeNode()
                        {
                            Name = form.NBTTag.Name,
                            Text = $"{form.NBTTag.Name}: " + form.NBTTag.StringValue.ToString().Replace(".", ","),//TODO , or . by language
                            ImageKey = "buttonintarray.png",
                            SelectedImageKey = "buttonintarray.png"
                        });
                        Changed = true;
                    }
                    break;
                }
            }
        }

        private void toolStripButtonList_Click(object sender, EventArgs e)
        {
            foreach (object o in tabControlNBT.SelectedTab.Controls)
            {
                if (o is TreeView)
                {
                    AddTagForm form = new AddTagForm(new NbtList());
                    if ((DialogResult)form.ShowDialog() == DialogResult.OK)
                    {
                        ((TreeView)o).SelectedNode.Nodes.Add(new TreeNode()
                        {
                            Name = form.NBTTag.Name,
                            Text = $"{form.NBTTag.Name}: 0 entries",
                            ImageKey = "buttonlist.png",
                            SelectedImageKey = "buttonlist.png"
                        });
                        Changed = true;
                    }
                    break;
                }
            }
        }

        private void toolStripButtonCompound_Click(object sender, EventArgs e)
        {
            foreach (object o in tabControlNBT.SelectedTab.Controls)
            {
                if (o is TreeView)
                {
                    AddTagForm form = new AddTagForm(new NbtCompound());
                    if ((DialogResult)form.ShowDialog() == DialogResult.OK)
                    {
                        ((TreeView)o).SelectedNode.Nodes.Add(new TreeNode()
                        {
                            Name = form.NBTTag.Name,
                            Text = $"{form.NBTTag.Name}: 0 entries",
                            ImageKey = "buttoncompound.png",
                            SelectedImageKey = "buttoncompound.png"
                        });
                        Changed = true;
                    }
                    break;
                }
            }
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (object o in tabControlNBT.SelectedTab.Controls)
            {
                if (o is TreeView)
                {
                    NbtFile file = new NbtFile();
                    NbtTag tree = MainClass.TreeToNBT(((TreeView)o).Nodes);
                    if (tree is NbtCompound)
                        file.RootTag = (NbtCompound)tree;
                    else
                    {
                        file.RootTag = new NbtCompound("");
                        file.RootTag.Add(tree);
                    }
                    NbtFile original = new NbtFile(tabControlNBT.SelectedTab.Name);
                    (new AlertForm(file.RootTag.ToString())
                    {
                        Text = "original file direct root tag"
                    }).ShowDialog();
                    (new AlertForm(file.ToString())).ShowDialog();
                    file.SaveToFile(tabControlNBT.SelectedTab.Name.Replace(Path.GetExtension(tabControlNBT.SelectedTab.Name), "_DEBUG" + Path.GetExtension(tabControlNBT.SelectedTab.Name)), original.FileCompression);//TODO remove _DEBUG
                    break;
                }
            }
        }

        //TODO update entry count in list, compound, bytearray and intarray when nodes/amount changed
    }
}
*/