namespace MainDemo
{
  partial class FrameSolDataGridCustomDataCellPaint
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrameSolDataGridCustomDataCellPaint));
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.biolifeDataSet = new MainDemo.BiolifeDataSet();
      this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.countryTableAdapter = new MainDemo.BiolifeDataSetTableAdapters.countryTableAdapter();
      this.tableAdapterManager = new MainDemo.BiolifeDataSetTableAdapters.TableAdapterManager();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.dataGrid1 = new EhLib.WinForms.DataGridEh();
      this.dataGridTextColumn1 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn2 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn3 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn4 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn5 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridCheckBoxColumn1 = new EhLib.WinForms.DataGridCheckBoxColumn();
      this.dataGridCheckBoxColumn2 = new EhLib.WinForms.DataGridCheckBoxColumn();
      this.dataGridCheckBoxColumn3 = new EhLib.WinForms.DataGridCheckBoxColumn();
      this.dataGridCheckBoxColumn4 = new EhLib.WinForms.DataGridCheckBoxColumn();
      this.dataGridSuperTitle1 = new EhLib.WinForms.DataGridSuperTitle();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.dataGridTextColumn6 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn7 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn8 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn9 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn10 = new EhLib.WinForms.DataGridTextColumn();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.biolifeDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
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
      this.label1.Size = new System.Drawing.Size(327, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "DataGridEh Custom DataCell Paint";
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
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 36);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(711, 316);
      this.tabControl1.TabIndex = 7;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.dataGrid1);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(703, 290);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Demo";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // dataGrid1
      // 
      this.dataGrid1.Cursor = System.Windows.Forms.Cursors.Default;
      this.dataGrid1.DataSource = this.countryBindingSource;
      this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // 
      // 
      this.dataGrid1.EmptyDataInfo.Text = null;
      this.dataGrid1.Location = new System.Drawing.Point(3, 3);
      this.dataGrid1.Name = "dataGrid1";
      this.dataGrid1.Size = new System.Drawing.Size(697, 284);
      this.dataGrid1.StaticColumns.AddRange(new EhLib.WinForms.PropertyAxisBar[] {
            this.dataGridTextColumn1,
            this.dataGridTextColumn2,
            this.dataGridTextColumn3,
            this.dataGridTextColumn4,
            this.dataGridTextColumn5,
            this.dataGridCheckBoxColumn1,
            this.dataGridCheckBoxColumn2,
            this.dataGridCheckBoxColumn3,
            this.dataGridCheckBoxColumn4});
      this.dataGrid1.TabIndex = 7;
      // 
      // 
      // 
      this.dataGrid1.Title.HorzAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // 
      // 
      this.dataGrid1.Title.MultiTitle.Active = true;
      this.dataGrid1.Title.MultiTitle.Subtitles.Add(this.dataGridTextColumn1);
      this.dataGrid1.Title.MultiTitle.Subtitles.Add(this.dataGridTextColumn2);
      this.dataGrid1.Title.MultiTitle.Subtitles.Add(this.dataGridTextColumn3);
      this.dataGrid1.Title.MultiTitle.Subtitles.Add(this.dataGridTextColumn4);
      this.dataGrid1.Title.MultiTitle.Subtitles.Add(this.dataGridTextColumn5);
      this.dataGrid1.Title.MultiTitle.Subtitles.Add(this.dataGridSuperTitle1);
      // 
      // dataGridTextColumn1
      // 
      this.dataGridTextColumn1.DataPropertyName = "Name";
      this.dataGridTextColumn1.Name = "dataGridTextColumn1";
      // 
      // 
      // 
      this.dataGridTextColumn1.Title.Text = "Name";
      this.dataGridTextColumn1.Width = 199;
      this.dataGridTextColumn1.DataCellCustomAreaPaint += new System.EventHandler<EhLib.WinForms.DataGridDataCellPaintEventArgs>(this.dataGridTextColumn1_DataCellCustomAreaPaint);
      this.dataGridTextColumn1.DataCellMouseDown += new System.EventHandler<EhLib.WinForms.DataGridDataCellMouseEventArgs>(this.dataGridTextColumn1_DataCellMouseDown);
      this.dataGridTextColumn1.DataCellMouseMove += new System.EventHandler<EhLib.WinForms.DataGridDataCellMouseEventArgs>(this.dataGridTextColumn1_DataCellMouseMove);
      this.dataGridTextColumn1.DataCellMouseLeave += new System.EventHandler<EhLib.WinForms.DataGridDataCellMouseLeaveEventArgs>(this.dataGridTextColumn1_DataCellMouseLeave);
      this.dataGridTextColumn1.DataCellMouseHover += new System.EventHandler<EhLib.WinForms.DataGridDataCellMouseEventArgs>(this.dataGridTextColumn1_DataCellMouseHover);
      this.dataGridTextColumn1.DataCellClientAreaNeeded += new System.EventHandler<EhLib.WinForms.DataGridDataCellClientAreaNeededEventArgs>(this.dataGridTextColumn1_DataCellClientAreaNeeded);
      // 
      // dataGridTextColumn2
      // 
      this.dataGridTextColumn2.DataPropertyName = "Capital";
      this.dataGridTextColumn2.Name = "dataGridTextColumn2";
      // 
      // 
      // 
      this.dataGridTextColumn2.Title.Text = "Capital";
      this.dataGridTextColumn2.Width = 179;
      // 
      // dataGridTextColumn3
      // 
      this.dataGridTextColumn3.DataPropertyName = "Continent";
      this.dataGridTextColumn3.Name = "dataGridTextColumn3";
      // 
      // 
      // 
      this.dataGridTextColumn3.Title.Text = "Continent";
      this.dataGridTextColumn3.Width = 119;
      // 
      // dataGridTextColumn4
      // 
      this.dataGridTextColumn4.DataPropertyName = "Area";
      this.dataGridTextColumn4.Name = "dataGridTextColumn4";
      // 
      // 
      // 
      this.dataGridTextColumn4.Title.Text = "Area";
      // 
      // dataGridTextColumn5
      // 
      this.dataGridTextColumn5.DataPropertyName = "Population";
      this.dataGridTextColumn5.Name = "dataGridTextColumn5";
      // 
      // 
      // 
      this.dataGridTextColumn5.Title.Text = "Population";
      // 
      // dataGridCheckBoxColumn1
      // 
      this.dataGridCheckBoxColumn1.DataPropertyName = "transport1";
      this.dataGridCheckBoxColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.dataGridCheckBoxColumn1.Name = "dataGridCheckBoxColumn1";
      // 
      // 
      // 
      this.dataGridCheckBoxColumn1.Title.Text = "bus";
      this.dataGridCheckBoxColumn1.Width = 50;
      // 
      // dataGridCheckBoxColumn2
      // 
      this.dataGridCheckBoxColumn2.DataPropertyName = "transport2";
      this.dataGridCheckBoxColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.dataGridCheckBoxColumn2.Name = "dataGridCheckBoxColumn2";
      // 
      // 
      // 
      this.dataGridCheckBoxColumn2.Title.Text = "car";
      this.dataGridCheckBoxColumn2.Width = 50;
      // 
      // dataGridCheckBoxColumn3
      // 
      this.dataGridCheckBoxColumn3.DataPropertyName = "transport3";
      this.dataGridCheckBoxColumn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.dataGridCheckBoxColumn3.Name = "dataGridCheckBoxColumn3";
      // 
      // 
      // 
      this.dataGridCheckBoxColumn3.Title.Text = "chopper";
      this.dataGridCheckBoxColumn3.Width = 50;
      // 
      // dataGridCheckBoxColumn4
      // 
      this.dataGridCheckBoxColumn4.DataPropertyName = "transport4";
      this.dataGridCheckBoxColumn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.dataGridCheckBoxColumn4.Name = "dataGridCheckBoxColumn4";
      // 
      // 
      // 
      this.dataGridCheckBoxColumn4.Title.Text = "rocket";
      this.dataGridCheckBoxColumn4.Width = 50;
      // 
      // dataGridSuperTitle1
      // 
      this.dataGridSuperTitle1.HorzAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.dataGridSuperTitle1.Name = "dataGridSuperTitle1";
      this.dataGridSuperTitle1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.dataGridSuperTitle1.Subtitles.Add(this.dataGridCheckBoxColumn1);
      this.dataGridSuperTitle1.Subtitles.Add(this.dataGridCheckBoxColumn2);
      this.dataGridSuperTitle1.Subtitles.Add(this.dataGridCheckBoxColumn3);
      this.dataGridSuperTitle1.Subtitles.Add(this.dataGridCheckBoxColumn4);
      this.dataGridSuperTitle1.Text = "Transport type";
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.textBox1);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(703, 290);
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
      this.textBox1.Size = new System.Drawing.Size(697, 284);
      this.textBox1.TabIndex = 0;
      this.textBox1.Text = "Use \r\n  DataGridEh.DataCellQueryFillFormatParams event \r\nto change cell format li" +
    "ke BackColor, ForeColor, Font for every cell in the row.";
      // 
      // dataGridTextColumn6
      // 
      this.dataGridTextColumn6.DataPropertyName = "Name";
      this.dataGridTextColumn6.Name = "dataGridTextColumn6";
      // 
      // 
      // 
      this.dataGridTextColumn6.Title.Text = "Name";
      this.dataGridTextColumn6.Width = 203;
      // 
      // dataGridTextColumn7
      // 
      this.dataGridTextColumn7.DataPropertyName = "Capital";
      this.dataGridTextColumn7.Name = "dataGridTextColumn7";
      // 
      // 
      // 
      this.dataGridTextColumn7.Title.Text = "Capital";
      this.dataGridTextColumn7.Width = 179;
      // 
      // dataGridTextColumn8
      // 
      this.dataGridTextColumn8.DataPropertyName = "Continent";
      this.dataGridTextColumn8.Name = "dataGridTextColumn8";
      // 
      // 
      // 
      this.dataGridTextColumn8.Title.Text = "Continent";
      this.dataGridTextColumn8.Width = 119;
      // 
      // dataGridTextColumn9
      // 
      this.dataGridTextColumn9.DataPropertyName = "Area";
      this.dataGridTextColumn9.Name = "dataGridTextColumn9";
      // 
      // 
      // 
      this.dataGridTextColumn9.Title.Text = "Area";
      // 
      // dataGridTextColumn10
      // 
      this.dataGridTextColumn10.DataPropertyName = "Population";
      this.dataGridTextColumn10.Name = "dataGridTextColumn10";
      // 
      // 
      // 
      this.dataGridTextColumn10.Title.Text = "Population";
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "bus-16x16.png");
      this.imageList1.Images.SetKeyName(1, "car-16x16.png");
      this.imageList1.Images.SetKeyName(2, "helicopter-16x16.png");
      this.imageList1.Images.SetKeyName(3, "rocket-16x16.png");
      this.imageList1.Images.SetKeyName(4, "bike-16x16.png");
      this.imageList1.Images.SetKeyName(5, "balloon-16x16.png");
      this.imageList1.Images.SetKeyName(6, "boat-16x16.png");
      // 
      // FrameSolDataGridCustomDataCellPaint
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.panel1);
      this.Name = "FrameSolDataGridCustomDataCellPaint";
      this.Size = new System.Drawing.Size(711, 352);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.biolifeDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private BiolifeDataSet biolifeDataSet;
    private System.Windows.Forms.BindingSource countryBindingSource;
    private BiolifeDataSetTableAdapters.countryTableAdapter countryTableAdapter;
    private BiolifeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn6;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn7;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn8;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn9;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn10;
    private EhLib.WinForms.DataGridEh dataGrid1;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn1;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn2;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn3;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn4;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn5;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.ImageList imageList1;
    private EhLib.WinForms.DataGridCheckBoxColumn dataGridCheckBoxColumn1;
    private EhLib.WinForms.DataGridCheckBoxColumn dataGridCheckBoxColumn2;
    private EhLib.WinForms.DataGridCheckBoxColumn dataGridCheckBoxColumn3;
    private EhLib.WinForms.DataGridCheckBoxColumn dataGridCheckBoxColumn4;
    private EhLib.WinForms.DataGridSuperTitle dataGridSuperTitle1;
    private System.Windows.Forms.ToolTip toolTip1;
  }
}
