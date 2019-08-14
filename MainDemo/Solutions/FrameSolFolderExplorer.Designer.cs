namespace MainDemo
{
  partial class FrameSolFolderExplorer
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      EhLib.WinForms.ExplorerStyleTreeNodeStateRenderer explorerStyleTreeNodeStateRenderer1 = new EhLib.WinForms.ExplorerStyleTreeNodeStateRenderer();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrameSolFolderExplorer));
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.dataGridEh1 = new EhLib.WinForms.DataGridEh();
      this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.dataGridTextColumn3 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn4 = new EhLib.WinForms.DataGridTextColumn();
      this.panel2 = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
      this.textBoxEh1 = new EhLib.WinForms.TextBoxEh();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.panel1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridEh1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.textBoxEh1)).BeginInit();
      this.tabPage2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(711, 36);
      this.panel1.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(6, 5);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(312, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "Disk Folder Explorer (TreeView)";
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 36);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(711, 623);
      this.tabControl1.TabIndex = 7;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.dataGridEh1);
      this.tabPage1.Controls.Add(this.panel2);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(703, 597);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Demo";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // dataGridEh1
      // 
      this.dataGridEh1.AutoSizeColumnOptions.FitToClient = true;
      this.dataGridEh1.ColumnOptions.AllowShowEditor = false;
      this.dataGridEh1.DataSource = this.bindingSource1;
      this.dataGridEh1.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // 
      // 
      this.dataGridEh1.IndicatorColumn.Visible = false;
      this.dataGridEh1.Location = new System.Drawing.Point(3, 47);
      this.dataGridEh1.Name = "dataGridEh1";
      this.dataGridEh1.ReadOnly = true;
      this.dataGridEh1.RowOptions.HorzLine.Visible = false;
      // 
      // 
      // 
      this.dataGridEh1.SearchBox.Enabled = true;
      this.dataGridEh1.Selection.RowHighlight = false;
      this.dataGridEh1.Size = new System.Drawing.Size(697, 547);
      this.dataGridEh1.StaticColumns.AddRange(new EhLib.WinForms.PropertyAxisBar[] {
            this.dataGridTextColumn3,
            this.dataGridTextColumn4});
      this.dataGridEh1.TabIndex = 4;
      // 
      // 
      // 
      this.dataGridEh1.TreeViewArea.NodeStateRenderer = explorerStyleTreeNodeStateRenderer1;
      this.dataGridEh1.TreeViewArea.Visible = true;
      this.dataGridEh1.TreeViewArea.ExpandedStateSet += new System.EventHandler<EhLib.WinForms.DataGridTreeViewNodeExpandedStateSetEventArgs>(this.dataGridEh1_TreeViewArea_ExpandedStateSet);
      this.dataGridEh1.TreeViewArea.NodeStateNeeded += new System.EventHandler<EhLib.WinForms.DataGridTreeViewNodeStateNeededEventArgs>(this.dataGridEh1_TreeViewArea_NodeStateNeeded);
      // 
      // dataGridTextColumn3
      // 
      this.dataGridTextColumn3.DataPropertyName = "Name";
      this.dataGridTextColumn3.FillWeight = 556F;
      this.dataGridTextColumn3.FormatString = null;
      this.dataGridTextColumn3.Name = "dataGridTextColumn3";
      // 
      // 
      // 
      this.dataGridTextColumn3.Title.Text = "Path";
      this.dataGridTextColumn3.Width = 556;
      this.dataGridTextColumn3.DataCellCustomAreaPaint += new System.EventHandler<EhLib.WinForms.DataGridDataCellPaintEventArgs>(this.dataGridTextColumn3_DataCellCustomAreaPaint);
      this.dataGridTextColumn3.DataCellClientAreaNeeded += new System.EventHandler<EhLib.WinForms.DataGridDataCellClientAreaNeededEventArgs>(this.dataGridTextColumn3_DataCellClientAreaNeeded);
      // 
      // dataGridTextColumn4
      // 
      this.dataGridTextColumn4.DataPropertyName = "Size";
      this.dataGridTextColumn4.FillWeight = 137F;
      this.dataGridTextColumn4.FormatString = null;
      this.dataGridTextColumn4.Name = "dataGridTextColumn4";
      this.dataGridTextColumn4.Padding = new System.Windows.Forms.Padding(3, 2, 4, 2);
      // 
      // 
      // 
      this.dataGridTextColumn4.Title.Text = "Size";
      this.dataGridTextColumn4.Width = 137;
      this.dataGridTextColumn4.DataCellMouseClick += new System.EventHandler<EhLib.WinForms.DataGridDataCellMouseEventArgs>(this.dataGridTextColumn4_DataCellMouseClick);
      this.dataGridTextColumn4.DataCellFormatParamsNeeded += new System.EventHandler<EhLib.WinForms.DataGridDataCellFormatParamsNeededEventArgs>(this.dataGridTextColumn4_DataCellFormatParamsNeeded);
      this.dataGridTextColumn4.DataCellToolTipInfoNeeded += new System.EventHandler<EhLib.WinForms.DataGridDataCellToolTipInfoEventArgs>(this.dataGridTextColumn4_DataCellToolTipInfoNeeded);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.button1);
      this.panel2.Controls.Add(this.textBoxEh1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(3, 3);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(697, 44);
      this.panel2.TabIndex = 5;
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.Location = new System.Drawing.Point(582, 8);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(107, 28);
      this.button1.TabIndex = 2;
      this.button1.Text = "Load Data";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // textBoxEh1
      // 
      this.textBoxEh1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxEh1.BoundLabel = null;
      // 
      // 
      // 
      this.textBoxEh1.EditButton.DefaultAction = false;
      this.textBoxEh1.EditButton.StyleKind = EhLib.WinForms.InEditButtonStyleKind.EndEllipsis;
      this.textBoxEh1.EditButton.Visible = true;
      this.textBoxEh1.EditButton.Click += new System.EventHandler<EhLib.WinForms.InEditControlClickEventArgs>(this.textBoxEh1_EditButton_Click);
      this.textBoxEh1.Location = new System.Drawing.Point(16, 12);
      this.textBoxEh1.Name = "textBoxEh1";
      this.textBoxEh1.Size = new System.Drawing.Size(558, 20);
      this.textBoxEh1.TabIndex = 1;
      this.textBoxEh1.TabStop = false;
      this.textBoxEh1.Text = "C:\\";
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.textBox1);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(703, 597);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Description";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // textBox1
      // 
      this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBox1.Location = new System.Drawing.Point(3, 3);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(697, 591);
      this.textBox1.TabIndex = 0;
      this.textBox1.Text = resources.GetString("textBox1.Text");
      // 
      // FrameSolFolderExplorer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.panel1);
      this.Name = "FrameSolFolderExplorer";
      this.Size = new System.Drawing.Size(711, 659);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridEh1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.textBoxEh1)).EndInit();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.BindingSource bindingSource1;
    private EhLib.WinForms.DataGridEh dataGridEh1;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn3;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn4;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button button1;
    private EhLib.WinForms.TextBoxEh textBoxEh1;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
  }
}
