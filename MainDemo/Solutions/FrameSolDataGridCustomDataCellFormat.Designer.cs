namespace MainDemo
{
  partial class FrameSolDataGridCustomDataCellFormat
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
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.textBox1 = new System.Windows.Forms.TextBox();
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
      this.label1.Size = new System.Drawing.Size(346, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "DataGridEh Custom DataCell Format";
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
      this.tabControl1.Size = new System.Drawing.Size(711, 623);
      this.tabControl1.TabIndex = 7;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.dataGrid1);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(703, 597);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Demo";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // dataGrid1
      // 
      this.dataGrid1.DataSource = this.countryBindingSource;
      this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // 
      // 
      this.dataGrid1.EmptyDataInfo.Text = null;
      this.dataGrid1.Location = new System.Drawing.Point(3, 3);
      this.dataGrid1.Name = "dataGrid1";
      this.dataGrid1.Size = new System.Drawing.Size(697, 591);
      this.dataGrid1.StaticColumns.AddRange(new EhLib.WinForms.PropertyAxisBar[] {
            this.dataGridTextColumn1,
            this.dataGridTextColumn2,
            this.dataGridTextColumn3,
            this.dataGridTextColumn4,
            this.dataGridTextColumn5});
      this.dataGrid1.TabIndex = 7;
      this.dataGrid1.DataCellFormatParamsNeeded += new System.EventHandler<EhLib.WinForms.DataGridDataCellFormatParamsNeededEventArgs>(this.dataGrid1_DataCellFormatParamsNeeded);
      // 
      // dataGridTextColumn1
      // 
      this.dataGridTextColumn1.DataPropertyName = "Name";
      this.dataGridTextColumn1.Name = "dataGridTextColumn1";
      // 
      // dataGridTextColumn1.Title
      // 
      this.dataGridTextColumn1.Title.Text = "Name";
      this.dataGridTextColumn1.Width = 203;
      // 
      // dataGridTextColumn2
      // 
      this.dataGridTextColumn2.DataPropertyName = "Capital";
      this.dataGridTextColumn2.Name = "dataGridTextColumn2";
      // 
      // dataGridTextColumn2.Title
      // 
      this.dataGridTextColumn2.Title.Text = "Capital";
      this.dataGridTextColumn2.Width = 179;
      // 
      // dataGridTextColumn3
      // 
      this.dataGridTextColumn3.DataPropertyName = "Continent";
      this.dataGridTextColumn3.Name = "dataGridTextColumn3";
      // 
      // dataGridTextColumn3.Title
      // 
      this.dataGridTextColumn3.Title.Text = "Continent";
      this.dataGridTextColumn3.Width = 119;
      this.dataGridTextColumn3.DataCellFormatParamsNeeded += new System.EventHandler<EhLib.WinForms.DataGridDataCellFormatParamsNeededEventArgs>(this.dataGridTextColumn3_DataCellFormatParamsNeeded);
      // 
      // dataGridTextColumn4
      // 
      this.dataGridTextColumn4.DataPropertyName = "Area";
      this.dataGridTextColumn4.Name = "dataGridTextColumn4";
      // 
      // dataGridTextColumn4.Title
      // 
      this.dataGridTextColumn4.Title.Text = "Area";
      // 
      // dataGridTextColumn5
      // 
      this.dataGridTextColumn5.DataPropertyName = "Population";
      this.dataGridTextColumn5.Name = "dataGridTextColumn5";
      // 
      // dataGridTextColumn5.Title
      // 
      this.dataGridTextColumn5.Title.Text = "Population";
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
      this.textBox1.Text = "Use \r\n  DataGridEh.DataCellQueryFillFormatParams event \r\nto change cell format li" +
    "ke BackColor, ForeColor, Font for every cell in the row.";
      // 
      // FrameSolDataGridCustomDataCellFormat
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.panel1);
      this.Name = "FrameSolDataGridCustomDataCellFormat";
      this.Size = new System.Drawing.Size(711, 659);
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
    private EhLib.WinForms.DataGridEh dataGrid1;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn1;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn2;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn3;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn4;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn5;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TextBox textBox1;
  }
}
