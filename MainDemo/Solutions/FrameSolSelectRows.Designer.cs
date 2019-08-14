namespace MainDemo
{
  partial class FrameSolSelectRows
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrameSolSelectRows));
      this.biolifeDataSet = new MainDemo.BiolifeDataSet();
      this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.countryTableAdapter = new MainDemo.BiolifeDataSetTableAdapters.countryTableAdapter();
      this.tableAdapterManager = new MainDemo.BiolifeDataSetTableAdapters.TableAdapterManager();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.dataGridEh1 = new EhLib.WinForms.DataGridEh();
      this.dataGridEh1NameColumn = new EhLib.WinForms.DataGridTextColumn();
      this.labelSelInfo = new System.Windows.Forms.Label();
      this.gridSelectedRows = new EhLib.WinForms.DataGridEh();
      this.dataGridTextColumn1 = new EhLib.WinForms.DataGridTextColumn();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.textBox1 = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.biolifeDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridEh1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridSelectedRows)).BeginInit();
      this.panel1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.SuspendLayout();
      // 
      // biolifeDataSet
      // 
      this.biolifeDataSet.DataSetName = "BiolifeDataSet";
      this.biolifeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // countryBindingSource
      // 
      this.countryBindingSource.DataMember = "country";
      this.countryBindingSource.DataSource = this.biolifeDataSet;
      // 
      // countryTableAdapter
      // 
      this.countryTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.BiolifeTableAdapter = null;
      this.tableAdapterManager.countryTableAdapter = this.countryTableAdapter;
      this.tableAdapterManager.UpdateOrder = MainDemo.BiolifeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(24, 10);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(96, 17);
      this.checkBox1.TabIndex = 3;
      this.checkBox1.Text = "Keep selection";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // dataGridEh1
      // 
      this.dataGridEh1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridEh1.AutoSizeColumnOptions.FitToClient = true;
      this.dataGridEh1.ColumnOptions.AllowMoveColumns = false;
      this.dataGridEh1.ColumnOptions.AllowResizeColumns = false;
      this.dataGridEh1.ColumnOptions.AllowShowEditor = false;
      this.dataGridEh1.ColumnOptions.SidePadding = new System.Windows.Forms.Padding(3, 1, 3, 1);
      this.dataGridEh1.DataSource = this.countryBindingSource;
      this.dataGridEh1.FixedBackFiller.Color = System.Drawing.SystemColors.Window;
      this.dataGridEh1.FixedBackFiller.FillStyle = EhLib.WinForms.CellFillStyle.Solid;
      this.dataGridEh1.FixedBackFiller.InnerBorder = EhLib.WinForms.CellInnerBorderStyle.None;
      // 
      // 
      // 
      this.dataGridEh1.IndicatorColumn.ShowRecNo = false;
      this.dataGridEh1.IndicatorColumn.ShowRowIndicator = false;
      this.dataGridEh1.IndicatorColumn.ShowRowselCheckboxes = true;
      this.dataGridEh1.LineOptions.HorzLines = false;
      this.dataGridEh1.LineOptions.VertLines = false;
      this.dataGridEh1.Location = new System.Drawing.Point(6, 41);
      this.dataGridEh1.Name = "dataGridEh1";
      this.dataGridEh1.ReadOnly = true;
      this.dataGridEh1.Selection.RowSelect = true;
      this.dataGridEh1.Size = new System.Drawing.Size(421, 457);
      this.dataGridEh1.StaticColumns.AddRange(new EhLib.WinForms.PropertyAxisBar[] {
            this.dataGridEh1NameColumn});
      this.dataGridEh1.TabIndex = 0;
      // 
      // 
      // 
      this.dataGridEh1.Title.HorzLine.Visible = true;
      this.dataGridEh1.Title.CellMouseDown += new System.EventHandler<EhLib.WinForms.DataGridTitleCellMouseEventArgs>(this.dataGridEh1_Title_CellMouseDown);
      this.dataGridEh1.SelectionChanged += new System.EventHandler<EhLib.WinForms.DataGridSelectionChangeOperationEventArgs>(this.dataGridEh1_SelectionChanged);
      this.dataGridEh1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridEh1_KeyPress);
      // 
      // dataGridEh1NameColumn
      // 
      this.dataGridEh1NameColumn.DataPropertyName = "Name";
      this.dataGridEh1NameColumn.FillWeight = 402F;
      this.dataGridEh1NameColumn.Name = "dataGridEh1NameColumn";
      // 
      // 
      // 
      this.dataGridEh1NameColumn.Title.Text = "Name";
      this.dataGridEh1NameColumn.Title.ToolTipText = null;
      this.dataGridEh1NameColumn.Width = 402;
      // 
      // labelSelInfo
      // 
      this.labelSelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.labelSelInfo.AutoSize = true;
      this.labelSelInfo.Location = new System.Drawing.Point(341, 11);
      this.labelSelInfo.Name = "labelSelInfo";
      this.labelSelInfo.Size = new System.Drawing.Size(86, 13);
      this.labelSelInfo.TabIndex = 4;
      this.labelSelInfo.Text = "5 Rows selected";
      this.labelSelInfo.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // gridSelectedRows
      // 
      this.gridSelectedRows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.gridSelectedRows.AutoSizeColumnOptions.FitToClient = true;
      this.gridSelectedRows.Location = new System.Drawing.Point(450, 41);
      this.gridSelectedRows.Name = "gridSelectedRows";
      this.gridSelectedRows.ReadOnly = true;
      this.gridSelectedRows.Selection.RowSelect = true;
      this.gridSelectedRows.Size = new System.Drawing.Size(268, 457);
      this.gridSelectedRows.StaticColumns.AddRange(new EhLib.WinForms.PropertyAxisBar[] {
            this.dataGridTextColumn1});
      this.gridSelectedRows.TabIndex = 5;
      // 
      // dataGridTextColumn1
      // 
      this.dataGridTextColumn1.FillWeight = 235F;
      this.dataGridTextColumn1.Name = "dataGridTextColumn1";
      // 
      // 
      // 
      this.dataGridTextColumn1.Title.Text = "Selected Rows";
      this.dataGridTextColumn1.Title.ToolTipText = null;
      this.dataGridTextColumn1.Width = 235;
      this.dataGridTextColumn1.DataCellPullValue += new System.EventHandler<EhLib.WinForms.DataGridDataCellPullValueEventArgs>(this.dataGridTextColumn1_DataCellPullValue);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(745, 36);
      this.panel1.TabIndex = 6;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(6, 5);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(293, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "Rows selected by checkboxes";
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 36);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(745, 543);
      this.tabControl1.TabIndex = 8;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.checkBox1);
      this.tabPage1.Controls.Add(this.labelSelInfo);
      this.tabPage1.Controls.Add(this.gridSelectedRows);
      this.tabPage1.Controls.Add(this.dataGridEh1);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(737, 517);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Demo";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.textBox1);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(737, 517);
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
      this.textBox1.Size = new System.Drawing.Size(731, 511);
      this.textBox1.TabIndex = 0;
      this.textBox1.Text = resources.GetString("textBox1.Text");
      // 
      // FrameSolSelectRows
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.panel1);
      this.Name = "FrameSolSelectRows";
      this.Size = new System.Drawing.Size(745, 579);
      ((System.ComponentModel.ISupportInitialize)(this.biolifeDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridEh1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridSelectedRows)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private BiolifeDataSet biolifeDataSet;
    private System.Windows.Forms.BindingSource countryBindingSource;
    private BiolifeDataSetTableAdapters.countryTableAdapter countryTableAdapter;
    private BiolifeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private EhLib.WinForms.DataGridEh dataGridEh1;
    private EhLib.WinForms.DataGridTextColumn dataGridEh1NameColumn;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.Label labelSelInfo;
    private EhLib.WinForms.DataGridEh gridSelectedRows;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TextBox textBox1;
  }
}
