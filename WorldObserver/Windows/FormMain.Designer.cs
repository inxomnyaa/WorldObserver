using System;

namespace WorldObserver
{
    partial class FormMain
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.MainTabPageWorldNBT = new System.Windows.Forms.TabPage();
            this.toolStripRight = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonString = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonByte = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonInt = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShort = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDouble = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFloat = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLong = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonByteArray = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonIntArray = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonList = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCompound = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonNBTEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNBTDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNBTRename = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonNBTCut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNBTCutAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNBTCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNBTCopyAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNBTPaste = new System.Windows.Forms.ToolStripButton();
            this.tabControlNBT = new System.Windows.Forms.TabControl();
            this.MainTabPageOverview = new System.Windows.Forms.TabPage();
            this.OverviewTabControl = new System.Windows.Forms.TabControl();
            this.OverviewOverworldTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.OverviewNetherTabPage = new System.Windows.Forms.TabPage();
            this.OverviewEndTabPage = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chunkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heightmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.useMinecraftFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formMainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MainTabControl.SuspendLayout();
            this.MainTabPageWorldNBT.SuspendLayout();
            this.toolStripRight.SuspendLayout();
            this.MainTabPageOverview.SuspendLayout();
            this.OverviewTabControl.SuspendLayout();
            this.OverviewOverworldTabPage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formMainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabControl.Controls.Add(this.MainTabPageWorldNBT);
            this.MainTabControl.Controls.Add(this.MainTabPageOverview);
            this.MainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTabControl.Location = new System.Drawing.Point(10, 28);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(809, 562);
            this.MainTabControl.TabIndex = 0;
            // 
            // MainTabPageWorldNBT
            // 
            this.MainTabPageWorldNBT.Controls.Add(this.toolStripRight);
            this.MainTabPageWorldNBT.Controls.Add(this.tabControlNBT);
            this.MainTabPageWorldNBT.Location = new System.Drawing.Point(4, 22);
            this.MainTabPageWorldNBT.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MainTabPageWorldNBT.Name = "MainTabPageWorldNBT";
            this.MainTabPageWorldNBT.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MainTabPageWorldNBT.Size = new System.Drawing.Size(801, 536);
            this.MainTabPageWorldNBT.TabIndex = 2;
            this.MainTabPageWorldNBT.Text = "NBT Editor";
            this.MainTabPageWorldNBT.UseVisualStyleBackColor = true;
            // 
            // toolStripRight
            // 
            this.toolStripRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStripRight.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripRight.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButtonString,
            this.toolStripButtonByte,
            this.toolStripButtonInt,
            this.toolStripButtonShort,
            this.toolStripButtonDouble,
            this.toolStripButtonFloat,
            this.toolStripButtonLong,
            this.toolStripButtonByteArray,
            this.toolStripButtonIntArray,
            this.toolStripButtonList,
            this.toolStripButtonCompound,
            this.toolStripSeparator3,
            this.toolStripButtonNBTEdit,
            this.toolStripButtonNBTDelete,
            this.toolStripButtonNBTRename,
            this.toolStripSeparator4,
            this.toolStripButtonNBTCut,
            this.toolStripButtonNBTCutAdd,
            this.toolStripButtonNBTCopy,
            this.toolStripButtonNBTCopyAdd,
            this.toolStripButtonNBTPaste});
            this.toolStripRight.Location = new System.Drawing.Point(769, 4);
            this.toolStripRight.Name = "toolStripRight";
            this.toolStripRight.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripRight.Size = new System.Drawing.Size(30, 528);
            this.toolStripRight.TabIndex = 3;
            this.toolStripRight.Text = "toolStripRight";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(27, 15);
            this.toolStripLabel1.Text = "NBT";
            // 
            // toolStripButtonString
            // 
            this.toolStripButtonString.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonString.Image = global::WorldObserver.Properties.Resources.buttonstring;
            this.toolStripButtonString.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonString.Name = "toolStripButtonString";
            this.toolStripButtonString.Size = new System.Drawing.Size(27, 20);
            this.toolStripButtonString.Text = "toolStripButtonString";
            this.toolStripButtonString.ToolTipText = "new String";
            this.toolStripButtonString.Click += new System.EventHandler(this.toolStripButtonString_Click);
            // 
            // toolStripButtonByte
            // 
            this.toolStripButtonByte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonByte.Image = global::WorldObserver.Properties.Resources.buttonbyte;
            this.toolStripButtonByte.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonByte.Name = "toolStripButtonByte";
            this.toolStripButtonByte.Size = new System.Drawing.Size(27, 20);
            this.toolStripButtonByte.Text = "toolStripButtonByte";
            this.toolStripButtonByte.ToolTipText = "new Byte";
            this.toolStripButtonByte.Click += new System.EventHandler(this.toolStripButtonByte_Click);
            // 
            // toolStripButtonInt
            // 
            this.toolStripButtonInt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInt.Image = global::WorldObserver.Properties.Resources.buttonint;
            this.toolStripButtonInt.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonInt.Name = "toolStripButtonInt";
            this.toolStripButtonInt.Size = new System.Drawing.Size(27, 20);
            this.toolStripButtonInt.Text = "toolStripButtonInt";
            this.toolStripButtonInt.ToolTipText = "new Int";
            this.toolStripButtonInt.Click += new System.EventHandler(this.toolStripButtonInt_Click);
            // 
            // toolStripButtonShort
            // 
            this.toolStripButtonShort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonShort.Image = global::WorldObserver.Properties.Resources.buttonshort;
            this.toolStripButtonShort.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonShort.Name = "toolStripButtonShort";
            this.toolStripButtonShort.Size = new System.Drawing.Size(27, 20);
            this.toolStripButtonShort.Text = "toolStripButtonShort";
            this.toolStripButtonShort.ToolTipText = "new Short";
            this.toolStripButtonShort.Click += new System.EventHandler(this.toolStripButtonShort_Click);
            // 
            // toolStripButtonDouble
            // 
            this.toolStripButtonDouble.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDouble.Image = global::WorldObserver.Properties.Resources.buttondouble;
            this.toolStripButtonDouble.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonDouble.Name = "toolStripButtonDouble";
            this.toolStripButtonDouble.Size = new System.Drawing.Size(27, 20);
            this.toolStripButtonDouble.Text = "toolStripButtonDouble";
            this.toolStripButtonDouble.ToolTipText = "new Double";
            this.toolStripButtonDouble.Click += new System.EventHandler(this.toolStripButtonDouble_Click);
            // 
            // toolStripButtonFloat
            // 
            this.toolStripButtonFloat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFloat.Image = global::WorldObserver.Properties.Resources.buttonfloat;
            this.toolStripButtonFloat.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonFloat.Name = "toolStripButtonFloat";
            this.toolStripButtonFloat.Size = new System.Drawing.Size(27, 20);
            this.toolStripButtonFloat.Text = "toolStripButtonFloat";
            this.toolStripButtonFloat.ToolTipText = "new Float";
            this.toolStripButtonFloat.Click += new System.EventHandler(this.toolStripButtonFloat_Click);
            // 
            // toolStripButtonLong
            // 
            this.toolStripButtonLong.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLong.Image = global::WorldObserver.Properties.Resources.buttonlong;
            this.toolStripButtonLong.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonLong.Name = "toolStripButtonLong";
            this.toolStripButtonLong.Size = new System.Drawing.Size(27, 20);
            this.toolStripButtonLong.Text = "toolStripButtonLong";
            this.toolStripButtonLong.ToolTipText = "new Long";
            this.toolStripButtonLong.Click += new System.EventHandler(this.toolStripButtonLong_Click);
            // 
            // toolStripButtonByteArray
            // 
            this.toolStripButtonByteArray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonByteArray.Image = global::WorldObserver.Properties.Resources.buttonbytearray;
            this.toolStripButtonByteArray.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonByteArray.Name = "toolStripButtonByteArray";
            this.toolStripButtonByteArray.Size = new System.Drawing.Size(27, 20);
            this.toolStripButtonByteArray.Text = "toolStripButtonByteArray";
            this.toolStripButtonByteArray.ToolTipText = "new ByteArray";
            this.toolStripButtonByteArray.Click += new System.EventHandler(this.toolStripButtonByteArray_Click);
            // 
            // toolStripButtonIntArray
            // 
            this.toolStripButtonIntArray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonIntArray.Image = global::WorldObserver.Properties.Resources.buttonintarray;
            this.toolStripButtonIntArray.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonIntArray.Name = "toolStripButtonIntArray";
            this.toolStripButtonIntArray.Size = new System.Drawing.Size(27, 20);
            this.toolStripButtonIntArray.Text = "toolStripButtonIntArray";
            this.toolStripButtonIntArray.ToolTipText = "new IntArray";
            this.toolStripButtonIntArray.Click += new System.EventHandler(this.toolStripButtonIntArray_Click);
            // 
            // toolStripButtonList
            // 
            this.toolStripButtonList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonList.Image = global::WorldObserver.Properties.Resources.buttonlist;
            this.toolStripButtonList.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonList.Name = "toolStripButtonList";
            this.toolStripButtonList.Size = new System.Drawing.Size(27, 20);
            this.toolStripButtonList.Text = "toolStripButtonList";
            this.toolStripButtonList.ToolTipText = "new List";
            this.toolStripButtonList.Click += new System.EventHandler(this.toolStripButtonList_Click);
            // 
            // toolStripButtonCompound
            // 
            this.toolStripButtonCompound.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCompound.Image = global::WorldObserver.Properties.Resources.buttoncompound;
            this.toolStripButtonCompound.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonCompound.Name = "toolStripButtonCompound";
            this.toolStripButtonCompound.Size = new System.Drawing.Size(27, 20);
            this.toolStripButtonCompound.Text = "toolStripButtonCompound";
            this.toolStripButtonCompound.ToolTipText = "new Compound";
            this.toolStripButtonCompound.Click += new System.EventHandler(this.toolStripButtonCompound_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(27, 6);
            // 
            // toolStripButtonNBTEdit
            // 
            this.toolStripButtonNBTEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNBTEdit.Image = global::WorldObserver.Properties.Resources.buttonedit;
            this.toolStripButtonNBTEdit.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonNBTEdit.Name = "toolStripButtonNBTEdit";
            this.toolStripButtonNBTEdit.Size = new System.Drawing.Size(27, 20);
            this.toolStripButtonNBTEdit.Text = "toolStripButtonNBTEdit";
            this.toolStripButtonNBTEdit.ToolTipText = "Edit tag";
            this.toolStripButtonNBTEdit.Click += new System.EventHandler(this.toolStripButtonNBTEdit_Click);
            // 
            // toolStripButtonNBTDelete
            // 
            this.toolStripButtonNBTDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNBTDelete.Image = global::WorldObserver.Properties.Resources.buttonx;
            this.toolStripButtonNBTDelete.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonNBTDelete.Name = "toolStripButtonNBTDelete";
            this.toolStripButtonNBTDelete.Size = new System.Drawing.Size(27, 20);
            this.toolStripButtonNBTDelete.Text = "toolStripButtonNBTDelete";
            this.toolStripButtonNBTDelete.ToolTipText = "Delete tag";
            this.toolStripButtonNBTDelete.Click += new System.EventHandler(this.toolStripButtonNBTDelete_Click);
            // 
            // toolStripButtonNBTRename
            // 
            this.toolStripButtonNBTRename.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNBTRename.Image = global::WorldObserver.Properties.Resources.buttonrename;
            this.toolStripButtonNBTRename.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonNBTRename.Name = "toolStripButtonNBTRename";
            this.toolStripButtonNBTRename.Size = new System.Drawing.Size(27, 20);
            this.toolStripButtonNBTRename.Text = "toolStripButtonNBTRename";
            this.toolStripButtonNBTRename.ToolTipText = "Rename tag";
            this.toolStripButtonNBTRename.Click += new System.EventHandler(this.toolStripButtonNBTRename_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(27, 6);
            // 
            // toolStripButtonNBTCut
            // 
            this.toolStripButtonNBTCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNBTCut.Image = global::WorldObserver.Properties.Resources.buttoncut;
            this.toolStripButtonNBTCut.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonNBTCut.Name = "toolStripButtonNBTCut";
            this.toolStripButtonNBTCut.Size = new System.Drawing.Size(27, 20);
            this.toolStripButtonNBTCut.Text = "  toolStripButtonNBTCut";
            this.toolStripButtonNBTCut.ToolTipText = "Cut NBT tags";
            this.toolStripButtonNBTCut.Click += new System.EventHandler(this.toolStripButtonNBTCut_Click);
            // 
            // toolStripButtonNBTCutAdd
            // 
            this.toolStripButtonNBTCutAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNBTCutAdd.Image = global::WorldObserver.Properties.Resources.buttoncutadd;
            this.toolStripButtonNBTCutAdd.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonNBTCutAdd.Name = "toolStripButtonNBTCutAdd";
            this.toolStripButtonNBTCutAdd.Size = new System.Drawing.Size(27, 20);
            this.toolStripButtonNBTCutAdd.Text = "  toolStripButtonNBTCutAdd";
            this.toolStripButtonNBTCutAdd.ToolTipText = "Cut NBT tags + append them to the clipboard";
            this.toolStripButtonNBTCutAdd.Click += new System.EventHandler(this.toolStripButtonNBTCutAdd_Click);
            // 
            // toolStripButtonNBTCopy
            // 
            this.toolStripButtonNBTCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNBTCopy.Image = global::WorldObserver.Properties.Resources.buttoncopy;
            this.toolStripButtonNBTCopy.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonNBTCopy.Name = "toolStripButtonNBTCopy";
            this.toolStripButtonNBTCopy.Size = new System.Drawing.Size(27, 20);
            this.toolStripButtonNBTCopy.Text = "toolStripButtonNBTCopy";
            this.toolStripButtonNBTCopy.ToolTipText = "Copy NBT tags";
            this.toolStripButtonNBTCopy.Click += new System.EventHandler(this.toolStripButtonNBTCopy_Click);
            // 
            // toolStripButtonNBTCopyAdd
            // 
            this.toolStripButtonNBTCopyAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNBTCopyAdd.Image = global::WorldObserver.Properties.Resources.buttoncopyadd;
            this.toolStripButtonNBTCopyAdd.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonNBTCopyAdd.Name = "toolStripButtonNBTCopyAdd";
            this.toolStripButtonNBTCopyAdd.Size = new System.Drawing.Size(27, 20);
            this.toolStripButtonNBTCopyAdd.Text = "toolStripButtonNBTCopyAdd";
            this.toolStripButtonNBTCopyAdd.ToolTipText = "Copy NBT tags + append them to the clipboard";
            this.toolStripButtonNBTCopyAdd.Click += new System.EventHandler(this.toolStripButtonNBTCopyAdd_Click);
            // 
            // toolStripButtonNBTPaste
            // 
            this.toolStripButtonNBTPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNBTPaste.Image = global::WorldObserver.Properties.Resources.buttonpaste;
            this.toolStripButtonNBTPaste.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonNBTPaste.Name = "toolStripButtonNBTPaste";
            this.toolStripButtonNBTPaste.Size = new System.Drawing.Size(27, 20);
            this.toolStripButtonNBTPaste.Text = "toolStripButtonNBTPaste";
            this.toolStripButtonNBTPaste.ToolTipText = "Paste NBT tag";
            this.toolStripButtonNBTPaste.Click += new System.EventHandler(this.toolStripButtonNBTPaste_Click);
            // 
            // tabControlNBT
            // 
            this.tabControlNBT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlNBT.Location = new System.Drawing.Point(2, 4);
            this.tabControlNBT.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabControlNBT.Name = "tabControlNBT";
            this.tabControlNBT.SelectedIndex = 0;
            this.tabControlNBT.Size = new System.Drawing.Size(765, 528);
            this.tabControlNBT.TabIndex = 2;
            // 
            // MainTabPageOverview
            // 
            this.MainTabPageOverview.Controls.Add(this.OverviewTabControl);
            this.MainTabPageOverview.Location = new System.Drawing.Point(4, 22);
            this.MainTabPageOverview.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MainTabPageOverview.Name = "MainTabPageOverview";
            this.MainTabPageOverview.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MainTabPageOverview.Size = new System.Drawing.Size(801, 536);
            this.MainTabPageOverview.TabIndex = 3;
            this.MainTabPageOverview.Text = "Overview";
            this.MainTabPageOverview.UseVisualStyleBackColor = true;
            // 
            // OverviewTabControl
            // 
            this.OverviewTabControl.Controls.Add(this.OverviewOverworldTabPage);
            this.OverviewTabControl.Controls.Add(this.OverviewNetherTabPage);
            this.OverviewTabControl.Controls.Add(this.OverviewEndTabPage);
            this.OverviewTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OverviewTabControl.Location = new System.Drawing.Point(2, 4);
            this.OverviewTabControl.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.OverviewTabControl.Name = "OverviewTabControl";
            this.OverviewTabControl.SelectedIndex = 0;
            this.OverviewTabControl.Size = new System.Drawing.Size(797, 528);
            this.OverviewTabControl.TabIndex = 1;
            // 
            // OverviewOverworldTabPage
            // 
            this.OverviewOverworldTabPage.Controls.Add(this.label1);
            this.OverviewOverworldTabPage.Location = new System.Drawing.Point(4, 22);
            this.OverviewOverworldTabPage.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.OverviewOverworldTabPage.Name = "OverviewOverworldTabPage";
            this.OverviewOverworldTabPage.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.OverviewOverworldTabPage.Size = new System.Drawing.Size(789, 502);
            this.OverviewOverworldTabPage.TabIndex = 0;
            this.OverviewOverworldTabPage.Text = "Overworld";
            this.OverviewOverworldTabPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TODO";
            // 
            // OverviewNetherTabPage
            // 
            this.OverviewNetherTabPage.Location = new System.Drawing.Point(4, 22);
            this.OverviewNetherTabPage.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.OverviewNetherTabPage.Name = "OverviewNetherTabPage";
            this.OverviewNetherTabPage.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.OverviewNetherTabPage.Size = new System.Drawing.Size(789, 502);
            this.OverviewNetherTabPage.TabIndex = 1;
            this.OverviewNetherTabPage.Text = "Nether";
            this.OverviewNetherTabPage.UseVisualStyleBackColor = true;
            // 
            // OverviewEndTabPage
            // 
            this.OverviewEndTabPage.Location = new System.Drawing.Point(4, 22);
            this.OverviewEndTabPage.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.OverviewEndTabPage.Name = "OverviewEndTabPage";
            this.OverviewEndTabPage.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.OverviewEndTabPage.Size = new System.Drawing.Size(789, 502);
            this.OverviewEndTabPage.TabIndex = 2;
            this.OverviewEndTabPage.Text = "End";
            this.OverviewEndTabPage.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "buttonbyte.png");
            this.imageList1.Images.SetKeyName(1, "buttonbytearray.png");
            this.imageList1.Images.SetKeyName(2, "buttoncompound.png");
            this.imageList1.Images.SetKeyName(3, "buttondouble.png");
            this.imageList1.Images.SetKeyName(4, "buttonedit.png");
            this.imageList1.Images.SetKeyName(5, "buttonfloat.png");
            this.imageList1.Images.SetKeyName(6, "buttonint.png");
            this.imageList1.Images.SetKeyName(7, "buttonintarray.png");
            this.imageList1.Images.SetKeyName(8, "buttonlist.png");
            this.imageList1.Images.SetKeyName(9, "buttonlong.png");
            this.imageList1.Images.SetKeyName(10, "buttonshort.png");
            this.imageList1.Images.SetKeyName(11, "buttonstring.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(831, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.reloadToolStripMenuItem,
            this.toolStripSeparator,
            this.backupToolStripMenuItem,
            this.speichernToolStripMenuItem,
            this.toolStripSeparator1,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "&Datei";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.openToolStripMenuItem.Text = "Ö&ffnen";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reloadToolStripMenuItem.Image")));
            this.reloadToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.reloadToolStripMenuItem.Text = "&Reload";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(165, 6);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("backupToolStripMenuItem.Image")));
            this.backupToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.backupToolStripMenuItem.Text = "&Backup";
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("speichernToolStripMenuItem.Image")));
            this.speichernToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.speichernToolStripMenuItem.Text = "&Speichern";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.beendenToolStripMenuItem.Text = "&Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.biomeToolStripMenuItem,
            this.chunkToolStripMenuItem,
            this.heightmapToolStripMenuItem,
            this.toolStripSeparator2,
            this.useMinecraftFontToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.normalToolStripMenuItem.Text = "&Normal";
            // 
            // biomeToolStripMenuItem
            // 
            this.biomeToolStripMenuItem.Name = "biomeToolStripMenuItem";
            this.biomeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.biomeToolStripMenuItem.Text = "&Biome";
            // 
            // chunkToolStripMenuItem
            // 
            this.chunkToolStripMenuItem.Name = "chunkToolStripMenuItem";
            this.chunkToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.chunkToolStripMenuItem.Text = "&Chunk";
            // 
            // heightmapToolStripMenuItem
            // 
            this.heightmapToolStripMenuItem.Name = "heightmapToolStripMenuItem";
            this.heightmapToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.heightmapToolStripMenuItem.Text = "&Heightmap";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(171, 6);
            // 
            // useMinecraftFontToolStripMenuItem
            // 
            this.useMinecraftFontToolStripMenuItem.CheckOnClick = true;
            this.useMinecraftFontToolStripMenuItem.Name = "useMinecraftFontToolStripMenuItem";
            this.useMinecraftFontToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.useMinecraftFontToolStripMenuItem.Text = "Use &Minecraft Font";
            this.useMinecraftFontToolStripMenuItem.CheckedChanged += new System.EventHandler(this.useMinecraftFontToolStripMenuItem_CheckedChanged);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "&Hilfe";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.infoToolStripMenuItem.Text = "Inf&o...";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel2,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 595);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(831, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.DoubleClickEnabled = true;
            this.toolStripStatusLabel3.IsLink = true;
            this.toolStripStatusLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.toolStripStatusLabel3.LinkColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(272, 20);
            this.toolStripStatusLabel3.Text = "https://github.com/thebigsmilexd/WorldObserver";
            this.toolStripStatusLabel3.ToolTipText = "Show project on GitHub (where you can report errors too)";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(229, 20);
            this.toolStripStatusLabel2.Text = "Version: 1.0.0.0, Copyright XenialDan, 2018";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(75, 19);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(26, 20);
            this.toolStripStatusLabel1.Text = "Idle";
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(WorldObserver.Program);
            // 
            // formMainBindingSource
            // 
            this.formMainBindingSource.DataSource = typeof(WorldObserver.FormMain);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(831, 620);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "WorldObserver - observe your Minecraft worlds!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainTabControl.ResumeLayout(false);
            this.MainTabPageWorldNBT.ResumeLayout(false);
            this.MainTabPageWorldNBT.PerformLayout();
            this.toolStripRight.ResumeLayout(false);
            this.toolStripRight.PerformLayout();
            this.MainTabPageOverview.ResumeLayout(false);
            this.OverviewTabControl.ResumeLayout(false);
            this.OverviewOverworldTabPage.ResumeLayout(false);
            this.OverviewOverworldTabPage.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formMainBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.TabPage MainTabPageWorldNBT;
        private System.Windows.Forms.TabPage MainTabPageOverview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.TabControl OverviewTabControl;
        private System.Windows.Forms.TabPage OverviewOverworldTabPage;
        private System.Windows.Forms.TabPage OverviewNetherTabPage;
        private System.Windows.Forms.TabPage OverviewEndTabPage;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chunkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heightmapToolStripMenuItem;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.BindingSource formMainBindingSource;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStrip toolStripRight;
        private System.Windows.Forms.ToolStripButton toolStripButtonString;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButtonByte;
        private System.Windows.Forms.ToolStripButton toolStripButtonInt;
        private System.Windows.Forms.ToolStripButton toolStripButtonShort;
        private System.Windows.Forms.ToolStripButton toolStripButtonDouble;
        private System.Windows.Forms.ToolStripButton toolStripButtonFloat;
        private System.Windows.Forms.ToolStripButton toolStripButtonLong;
        private System.Windows.Forms.ToolStripButton toolStripButtonByteArray;
        private System.Windows.Forms.ToolStripButton toolStripButtonIntArray;
        private System.Windows.Forms.ToolStripButton toolStripButtonList;
        private System.Windows.Forms.ToolStripButton toolStripButtonCompound;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl tabControlNBT;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem useMinecraftFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonNBTEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonNBTDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonNBTRename;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonNBTCut;
        private System.Windows.Forms.ToolStripButton toolStripButtonNBTCopyAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonNBTPaste;
        private System.Windows.Forms.ToolStripButton toolStripButtonNBTCutAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonNBTCopy;
    }
}

