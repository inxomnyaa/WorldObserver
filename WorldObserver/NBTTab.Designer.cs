namespace WorldObserver
{
    partial class NBTTab
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("SubKnoten0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Knoten0", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NBTTab));
            this.treeViewNBT = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeViewNBT
            // 
            this.treeViewNBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewNBT.ImageIndex = 18;
            this.treeViewNBT.ImageList = this.imageList1;
            this.treeViewNBT.LabelEdit = true;
            this.treeViewNBT.Location = new System.Drawing.Point(0, 0);
            this.treeViewNBT.Name = "treeViewNBT";
            treeNode1.ImageKey = "buttonint.png";
            treeNode1.Name = "SubKnoten0";
            treeNode1.SelectedImageKey = "buttonint.png";
            treeNode1.Text = "SubKnoten0";
            treeNode2.ImageKey = "buttonintarray.png";
            treeNode2.Name = "Knoten0";
            treeNode2.SelectedImageKey = "buttonintarray.png";
            treeNode2.Text = "Knoten0";
            this.treeViewNBT.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeViewNBT.SelectedImageIndex = 18;
            this.treeViewNBT.Size = new System.Drawing.Size(567, 368);
            this.treeViewNBT.TabIndex = 0;
            this.treeViewNBT.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewNBT_NodeMouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "buttonbyte.png");
            this.imageList1.Images.SetKeyName(1, "buttonbytearray.png");
            this.imageList1.Images.SetKeyName(2, "buttoncompound.png");
            this.imageList1.Images.SetKeyName(3, "buttoncopy.png");
            this.imageList1.Images.SetKeyName(4, "buttoncopyadd.png");
            this.imageList1.Images.SetKeyName(5, "buttoncut.png");
            this.imageList1.Images.SetKeyName(6, "buttoncutadd.png");
            this.imageList1.Images.SetKeyName(7, "buttondouble.png");
            this.imageList1.Images.SetKeyName(8, "buttonedit.png");
            this.imageList1.Images.SetKeyName(9, "buttonfloat.png");
            this.imageList1.Images.SetKeyName(10, "buttonint.png");
            this.imageList1.Images.SetKeyName(11, "buttonintarray.png");
            this.imageList1.Images.SetKeyName(12, "buttonlist.png");
            this.imageList1.Images.SetKeyName(13, "buttonlong.png");
            this.imageList1.Images.SetKeyName(14, "buttonpaste.png");
            this.imageList1.Images.SetKeyName(15, "buttonrename.png");
            this.imageList1.Images.SetKeyName(16, "buttonshort.png");
            this.imageList1.Images.SetKeyName(17, "buttonstring.png");
            this.imageList1.Images.SetKeyName(18, "buttonunknown.png");
            this.imageList1.Images.SetKeyName(19, "buttonx.png");
            // 
            // NBTTab
            // 
            this.Controls.Add(this.treeViewNBT);
            this.Name = "NBTTab";
            this.Size = new System.Drawing.Size(567, 368);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewNBT;
        private System.Windows.Forms.ImageList imageList1;
    }
}
