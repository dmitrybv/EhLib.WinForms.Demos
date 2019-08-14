namespace DisplayLayoutStorableApp
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.miCountries = new System.Windows.Forms.ToolStripMenuItem();
      this.miCustomers = new System.Windows.Forms.ToolStripMenuItem();
      this.miEmployees = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.windowCascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.windowTileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.windowTileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.MdiWindowListItem = this.windowToolStripMenuItem;
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCountries,
            this.miCustomers,
            this.miEmployees,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // miCountries
      // 
      this.miCountries.Name = "miCountries";
      this.miCountries.Size = new System.Drawing.Size(131, 22);
      this.miCountries.Text = "Countries";
      this.miCountries.Click += new System.EventHandler(this.NewChildFormToolStripMenuItem_Click);
      // 
      // miCustomers
      // 
      this.miCustomers.Name = "miCustomers";
      this.miCustomers.Size = new System.Drawing.Size(131, 22);
      this.miCustomers.Text = "Customers";
      this.miCustomers.Click += new System.EventHandler(this.MiCustomers_Click);
      // 
      // miEmployees
      // 
      this.miEmployees.Name = "miEmployees";
      this.miEmployees.Size = new System.Drawing.Size(131, 22);
      this.miEmployees.Text = "Employees";
      this.miEmployees.Click += new System.EventHandler(this.MiEmployees_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(128, 6);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
      // 
      // windowToolStripMenuItem
      // 
      this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowCascadeToolStripMenuItem,
            this.windowTileVerticalToolStripMenuItem,
            this.windowTileHorizontalToolStripMenuItem});
      this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
      this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
      this.windowToolStripMenuItem.Text = "Window";
      // 
      // windowCascadeToolStripMenuItem
      // 
      this.windowCascadeToolStripMenuItem.Name = "windowCascadeToolStripMenuItem";
      this.windowCascadeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
      this.windowCascadeToolStripMenuItem.Text = "Cascade";
      this.windowCascadeToolStripMenuItem.Click += new System.EventHandler(this.WindowCascadeToolStripMenuItem_Click);
      // 
      // windowTileVerticalToolStripMenuItem
      // 
      this.windowTileVerticalToolStripMenuItem.Name = "windowTileVerticalToolStripMenuItem";
      this.windowTileVerticalToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
      this.windowTileVerticalToolStripMenuItem.Text = "Tile Vertical";
      this.windowTileVerticalToolStripMenuItem.Click += new System.EventHandler(this.WindowTileVerticalToolStripMenuItem_Click);
      // 
      // windowTileHorizontalToolStripMenuItem
      // 
      this.windowTileHorizontalToolStripMenuItem.Name = "windowTileHorizontalToolStripMenuItem";
      this.windowTileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
      this.windowTileHorizontalToolStripMenuItem.Text = "Tile Horizontal";
      this.windowTileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.WindowTileHorizontalToolStripMenuItem_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.menuStrip1);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.Text = "MainForm";
      this.Activated += new System.EventHandler(this.MainForm_Activated);
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem miCountries;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem windowCascadeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem windowTileVerticalToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem windowTileHorizontalToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem miCustomers;
    private System.Windows.Forms.ToolStripMenuItem miEmployees;
  }
}

