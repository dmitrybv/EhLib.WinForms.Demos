namespace MainDemo
{
  partial class FramePivotGrid
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.pivotGridToolBoxEh1 = new EhLib.WinForms.PivotGridToolBoxEh();
      this.pivotDataSourceEh1 = new EhLib.WinForms.PivotDataSourceEh();
      this.northwindDataSet1 = new MainDemo.NorthwindDataSet();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.pivotGridEh1 = new EhLib.WinForms.PivotGridEh();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.dataGridSourceTable = new EhLib.WinForms.DataGridEh();
      this.ordersTableAdapter1 = new MainDemo.NorthwindDataSetTableAdapters.OrdersTableAdapter();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pivotGridToolBoxEh1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).BeginInit();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pivotGridEh1)).BeginInit();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridSourceTable)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(676, 36);
      this.panel1.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(32, 6);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(120, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "PivotGridEh";
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.button1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 36);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(676, 56);
      this.panel2.TabIndex = 2;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(7, 8);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(171, 38);
      this.button1.TabIndex = 0;
      this.button1.Text = "Build Pivot Data";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.splitContainer1.Location = new System.Drawing.Point(0, 92);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.pivotGridToolBoxEh1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
      this.splitContainer1.Size = new System.Drawing.Size(676, 386);
      this.splitContainer1.SplitterDistance = 225;
      this.splitContainer1.SplitterWidth = 10;
      this.splitContainer1.TabIndex = 3;
      // 
      // pivotGridToolBoxEh1
      // 
      this.pivotGridToolBoxEh1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pivotGridToolBoxEh1.Location = new System.Drawing.Point(0, 0);
      this.pivotGridToolBoxEh1.Name = "pivotGridToolBoxEh1";
      this.pivotGridToolBoxEh1.PivotDataSource = this.pivotDataSourceEh1;
      this.pivotGridToolBoxEh1.Size = new System.Drawing.Size(225, 386);
      this.pivotGridToolBoxEh1.TabIndex = 0;
      // 
      // pivotDataSourceEh1
      // 
      this.pivotDataSourceEh1.DataMember = "Orders";
      this.pivotDataSourceEh1.DataSource = this.northwindDataSet1;
      // 
      // northwindDataSet1
      // 
      this.northwindDataSet1.DataSetName = "NorthwindDataSet";
      this.northwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(441, 386);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.pivotGridEh1);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(433, 360);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Pivot Grid";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // pivotGridEh1
      // 
      this.pivotGridEh1.AllowDrop = true;
      this.pivotGridEh1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pivotGridEh1.Location = new System.Drawing.Point(3, 3);
      this.pivotGridEh1.Name = "pivotGridEh1";
      this.pivotGridEh1.PivotDataSource = this.pivotDataSourceEh1;
      this.pivotGridEh1.Size = new System.Drawing.Size(427, 354);
      this.pivotGridEh1.TabIndex = 0;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.dataGridSourceTable);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(433, 360);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Source Data";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // dataGridSourceTable
      // 
      this.dataGridSourceTable.DataMember = "Orders";
      this.dataGridSourceTable.DataSource = this.northwindDataSet1;
      this.dataGridSourceTable.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // dataGridSourceTable.HorzScrollBar
      // 
      this.dataGridSourceTable.HorzScrollBar.ExtraBar.Visible = true;
      this.dataGridSourceTable.Location = new System.Drawing.Point(3, 3);
      this.dataGridSourceTable.Name = "dataGridSourceTable";
      this.dataGridSourceTable.Size = new System.Drawing.Size(427, 354);
      this.dataGridSourceTable.TabIndex = 1;
      // 
      // ordersTableAdapter1
      // 
      this.ordersTableAdapter1.ClearBeforeFill = true;
      // 
      // FramePivotGrid
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "FramePivotGrid";
      this.Size = new System.Drawing.Size(676, 478);
      this.Load += new System.EventHandler(this.FramePivotGrid_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pivotGridToolBoxEh1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pivotGridEh1)).EndInit();
      this.tabPage2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridSourceTable)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private EhLib.WinForms.PivotGridToolBoxEh pivotGridToolBoxEh1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private EhLib.WinForms.PivotGridEh pivotGridEh1;
    private EhLib.WinForms.DataGridEh dataGridSourceTable;
    private EhLib.WinForms.PivotDataSourceEh pivotDataSourceEh1;
    private NorthwindDataSet northwindDataSet1;
    private NorthwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
  }
}
