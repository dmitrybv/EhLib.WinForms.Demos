namespace MainDemo
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPageDemos = new System.Windows.Forms.TabPage();
      this.gridVertMenuDemos = new EhLib.WinForms.DataGridEh();
      this.bsVertMenuDemos = new System.Windows.Forms.BindingSource(this.components);
      this.vertGridMenuNameCol = new EhLib.WinForms.DataGridTextColumn();
      this.tabPageSolutions = new System.Windows.Forms.TabPage();
      this.gridVertMenuSolutions = new EhLib.WinForms.DataGridEh();
      this.bsVertMenuSolutions = new System.Windows.Forms.BindingSource(this.components);
      this.dataGridTextColumn1 = new EhLib.WinForms.DataGridTextColumn();
      this.mainMenu = new System.Windows.Forms.MenuStrip();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.miLanguages = new System.Windows.Forms.ToolStripMenuItem();
      this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.tsbExit = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbPreview = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbEditCut = new System.Windows.Forms.ToolStripButton();
      this.tsbEditCopy = new System.Windows.Forms.ToolStripButton();
      this.tsbEditPaste = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbObjectInspector = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbAbout = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.tsbBiDi = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbUseVisualStyles = new System.Windows.Forms.ToolStripButton();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPageDemos.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridVertMenuDemos)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsVertMenuDemos)).BeginInit();
      this.tabPageSolutions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridVertMenuSolutions)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsVertMenuSolutions)).BeginInit();
      this.mainMenu.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      resources.ApplyResources(this.splitContainer1, "splitContainer1");
      this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPageDemos);
      this.tabControl1.Controls.Add(this.tabPageSolutions);
      resources.ApplyResources(this.tabControl1, "tabControl1");
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
      // 
      // tabPageDemos
      // 
      this.tabPageDemos.Controls.Add(this.gridVertMenuDemos);
      resources.ApplyResources(this.tabPageDemos, "tabPageDemos");
      this.tabPageDemos.Name = "tabPageDemos";
      this.tabPageDemos.UseVisualStyleBackColor = true;
      // 
      // gridVertMenuDemos
      // 
      this.gridVertMenuDemos.AutoSizeColumnOptions.FitToClient = true;
      this.gridVertMenuDemos.BackColor = System.Drawing.SystemColors.Control;
      this.gridVertMenuDemos.ColumnOptions.AllowShowEditor = false;
      this.gridVertMenuDemos.DataSource = this.bsVertMenuDemos;
      resources.ApplyResources(this.gridVertMenuDemos, "gridVertMenuDemos");
      // 
      // 
      // 
      this.gridVertMenuDemos.EmptyDataInfo.Text = null;
      // 
      // 
      // 
      this.gridVertMenuDemos.IndicatorColumn.Visible = false;
      this.gridVertMenuDemos.Name = "gridVertMenuDemos";
      this.gridVertMenuDemos.ReadOnly = true;
      this.gridVertMenuDemos.RowOptions.HeightOptions.ContentHeight = 2;
      this.gridVertMenuDemos.RowOptions.HeightOptions.MaxContentHeight = 0;
      this.gridVertMenuDemos.StaticColumns.AddRange(new EhLib.WinForms.PropertyAxisBar[] {
            this.vertGridMenuNameCol});
      // 
      // bsVertMenuDemos
      // 
      this.bsVertMenuDemos.PositionChanged += new System.EventHandler(this.bsVertMenu_PositionChanged);
      // 
      // vertGridMenuNameCol
      // 
      this.vertGridMenuNameCol.BackColor = System.Drawing.SystemColors.Control;
      this.vertGridMenuNameCol.DataPropertyName = "MenuName";
      this.vertGridMenuNameCol.FillWeight = 215F;
      this.vertGridMenuNameCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.vertGridMenuNameCol.ForeColor = System.Drawing.SystemColors.ControlText;
      this.vertGridMenuNameCol.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.vertGridMenuNameCol.Name = "vertGridMenuNameCol";
      this.vertGridMenuNameCol.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
      // 
      // 
      // 
      this.vertGridMenuNameCol.Title.Text = "Demo section";
      this.vertGridMenuNameCol.VertAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
      this.vertGridMenuNameCol.Width = 215;
      // 
      // tabPageSolutions
      // 
      this.tabPageSolutions.Controls.Add(this.gridVertMenuSolutions);
      resources.ApplyResources(this.tabPageSolutions, "tabPageSolutions");
      this.tabPageSolutions.Name = "tabPageSolutions";
      this.tabPageSolutions.UseVisualStyleBackColor = true;
      // 
      // gridVertMenuSolutions
      // 
      this.gridVertMenuSolutions.AutoSizeColumnOptions.FitToClient = true;
      this.gridVertMenuSolutions.BackColor = System.Drawing.SystemColors.Control;
      this.gridVertMenuSolutions.ColumnOptions.AllowShowEditor = false;
      this.gridVertMenuSolutions.DataSource = this.bsVertMenuSolutions;
      resources.ApplyResources(this.gridVertMenuSolutions, "gridVertMenuSolutions");
      // 
      // 
      // 
      this.gridVertMenuSolutions.EmptyDataInfo.Text = null;
      // 
      // 
      // 
      this.gridVertMenuSolutions.IndicatorColumn.Visible = false;
      this.gridVertMenuSolutions.Name = "gridVertMenuSolutions";
      this.gridVertMenuSolutions.ReadOnly = true;
      this.gridVertMenuSolutions.RowOptions.HeightOptions.ContentHeight = 2;
      this.gridVertMenuSolutions.RowOptions.HeightOptions.MaxContentHeight = 0;
      this.gridVertMenuSolutions.StaticColumns.AddRange(new EhLib.WinForms.PropertyAxisBar[] {
            this.dataGridTextColumn1});
      // 
      // bsVertMenuSolutions
      // 
      this.bsVertMenuSolutions.PositionChanged += new System.EventHandler(this.bsVertMenuSolutions_PositionChanged);
      // 
      // dataGridTextColumn1
      // 
      this.dataGridTextColumn1.BackColor = System.Drawing.SystemColors.Control;
      this.dataGridTextColumn1.DataPropertyName = "MenuName";
      this.dataGridTextColumn1.FillWeight = 215F;
      this.dataGridTextColumn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataGridTextColumn1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataGridTextColumn1.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.dataGridTextColumn1.Name = "dataGridTextColumn1";
      this.dataGridTextColumn1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
      // 
      // 
      // 
      this.dataGridTextColumn1.Title.Text = "Demo section";
      this.dataGridTextColumn1.VertAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
      this.dataGridTextColumn1.Width = 215;
      // 
      // mainMenu
      // 
      this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.miLanguages,
            this.miAbout});
      resources.ApplyResources(this.mainMenu, "mainMenu");
      this.mainMenu.Name = "mainMenu";
      this.mainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mainMenu_ItemClicked);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // miLanguages
      // 
      this.miLanguages.Name = "miLanguages";
      resources.ApplyResources(this.miLanguages, "miLanguages");
      // 
      // miAbout
      // 
      this.miAbout.Name = "miAbout";
      resources.ApplyResources(this.miAbout, "miAbout");
      this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExit,
            this.toolStripSeparator1,
            this.tsbPreview,
            this.toolStripSeparator2,
            this.tsbEditCut,
            this.tsbEditCopy,
            this.tsbEditPaste,
            this.toolStripSeparator3,
            this.tsbObjectInspector,
            this.toolStripSeparator4,
            this.tsbAbout,
            this.toolStripSeparator,
            this.tsbBiDi,
            this.toolStripSeparator5,
            this.tsbUseVisualStyles});
      resources.ApplyResources(this.toolStrip1, "toolStrip1");
      this.toolStrip1.Name = "toolStrip1";
      // 
      // tsbExit
      // 
      this.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.tsbExit, "tsbExit");
      this.tsbExit.Name = "tsbExit";
      this.tsbExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
      // 
      // tsbPreview
      // 
      this.tsbPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.tsbPreview, "tsbPreview");
      this.tsbPreview.Name = "tsbPreview";
      this.tsbPreview.Click += new System.EventHandler(this.tsbPreview_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
      // 
      // tsbEditCut
      // 
      this.tsbEditCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.tsbEditCut, "tsbEditCut");
      this.tsbEditCut.Name = "tsbEditCut";
      // 
      // tsbEditCopy
      // 
      this.tsbEditCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.tsbEditCopy, "tsbEditCopy");
      this.tsbEditCopy.Name = "tsbEditCopy";
      // 
      // tsbEditPaste
      // 
      this.tsbEditPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.tsbEditPaste, "tsbEditPaste");
      this.tsbEditPaste.Name = "tsbEditPaste";
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
      // 
      // tsbObjectInspector
      // 
      this.tsbObjectInspector.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.tsbObjectInspector, "tsbObjectInspector");
      this.tsbObjectInspector.Name = "tsbObjectInspector";
      this.tsbObjectInspector.Click += new System.EventHandler(this.tsbObjectInspector_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
      // 
      // tsbAbout
      // 
      this.tsbAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      resources.ApplyResources(this.tsbAbout, "tsbAbout");
      this.tsbAbout.Name = "tsbAbout";
      this.tsbAbout.Click += new System.EventHandler(this.tsbAbout_Click);
      // 
      // toolStripSeparator
      // 
      this.toolStripSeparator.Name = "toolStripSeparator";
      resources.ApplyResources(this.toolStripSeparator, "toolStripSeparator");
      // 
      // tsbBiDi
      // 
      this.tsbBiDi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbBiDi.Image = global::MainDemo.Properties.Resources.DoubleArrowLeftRight_16x16;
      resources.ApplyResources(this.tsbBiDi, "tsbBiDi");
      this.tsbBiDi.Name = "tsbBiDi";
      this.tsbBiDi.Click += new System.EventHandler(this.TsbBiDi_Click);
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
      // 
      // tsbUseVisualStyles
      // 
      this.tsbUseVisualStyles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbUseVisualStyles.Image = global::MainDemo.Properties.Resources.themes;
      resources.ApplyResources(this.tsbUseVisualStyles, "tsbUseVisualStyles");
      this.tsbUseVisualStyles.Name = "tsbUseVisualStyles";
      this.tsbUseVisualStyles.Click += new System.EventHandler(this.toolStripButton1_Click);
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "exit.png");
      this.imageList1.Images.SetKeyName(1, "Preview.png");
      this.imageList1.Images.SetKeyName(2, "clipboard_copy_lined_16.png");
      this.imageList1.Images.SetKeyName(3, "clipboard_paste_lined_16.png");
      this.imageList1.Images.SetKeyName(4, "clipboard_select_all_16.bmp");
      this.imageList1.Images.SetKeyName(5, "gtk-about-1.png");
      // 
      // statusStrip1
      // 
      resources.ApplyResources(this.statusStrip1, "statusStrip1");
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Stretch = false;
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
      // 
      // MainForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.mainMenu);
      this.KeyPreview = true;
      this.MainMenuStrip = this.mainMenu;
      this.Name = "MainForm";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.RightToLeftChanged += new System.EventHandler(this.MainForm_RightToLeftChanged);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
      this.splitContainer1.Panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPageDemos.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridVertMenuDemos)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsVertMenuDemos)).EndInit();
      this.tabPageSolutions.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridVertMenuSolutions)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsVertMenuSolutions)).EndInit();
      this.mainMenu.ResumeLayout(false);
      this.mainMenu.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip mainMenu;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem miAbout;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton tsbExit;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton tsbPreview;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton tsbEditCut;
    private System.Windows.Forms.ToolStripButton tsbEditCopy;
    private System.Windows.Forms.ToolStripButton tsbEditPaste;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripButton tsbObjectInspector;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripButton tsbAbout;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.BindingSource bsVertMenuDemos;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.ToolStripButton tsbBiDi;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripButton tsbUseVisualStyles;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPageDemos;
    private EhLib.WinForms.DataGridEh gridVertMenuDemos;
    private EhLib.WinForms.DataGridTextColumn vertGridMenuNameCol;
    private System.Windows.Forms.TabPage tabPageSolutions;
    private EhLib.WinForms.DataGridEh gridVertMenuSolutions;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn1;
    private System.Windows.Forms.BindingSource bsVertMenuSolutions;
    private System.Windows.Forms.ToolStripMenuItem miLanguages;
  }
}

