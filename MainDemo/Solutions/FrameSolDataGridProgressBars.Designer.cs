namespace MainDemo
{
  partial class FrameSolDataGridProgressBars
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrameSolDataGridProgressBars));
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.dataGrid1 = new EhLib.WinForms.DataGridEh();
      this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.northwindDataSet = new MainDemo.NorthwindDataSet();
      this.dataGrid1UnitPriceColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridProgressBarColumn1 = new EhLib.WinForms.DataGridProgressBarColumn();
      this.dataGridProgressBarColumn2 = new EhLib.WinForms.DataGridProgressBarColumn();
      this.dataGridProgressBarColumn3 = new EhLib.WinForms.DataGridProgressBarColumn();
      this.dataGridProgressBarColumn4 = new EhLib.WinForms.DataGridProgressBarColumn();
      this.dataGrid1ProductIDColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGrid1ProductNameColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGrid1SupplierIDColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGrid1CategoryIDColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGrid1QuantityPerUnitColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGrid1UnitsInStockColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGrid1UnitsOnOrderColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGrid1ReorderLevelColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGrid1DiscontinuedColumn = new EhLib.WinForms.DataGridCheckBoxColumn();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.richTextBoxEh1 = new EhLib.WinForms.RichTextBoxEh();
      this.richTextBoxEh2 = new EhLib.WinForms.RichTextBoxEh();
      this.productsTableAdapter = new MainDemo.NorthwindDataSetTableAdapters.ProductsTableAdapter();
      this.tableAdapterManager = new MainDemo.NorthwindDataSetTableAdapters.TableAdapterManager();
      this.panel1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(908, 36);
      this.panel1.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(6, 5);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(246, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "DataGridEh ProgressBars";
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 36);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(908, 502);
      this.tabControl1.TabIndex = 7;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.dataGrid1);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(900, 476);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Demo";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // dataGrid1
      // 
      this.dataGrid1.DataMember = "";
      this.dataGrid1.DataSource = this.productsBindingSource;
      this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // 
      // 
      this.dataGrid1.EmptyDataInfo.Text = null;
      this.dataGrid1.Location = new System.Drawing.Point(3, 3);
      this.dataGrid1.Name = "dataGrid1";
      this.dataGrid1.Size = new System.Drawing.Size(894, 470);
      this.dataGrid1.StaticColumns.AddRange(new EhLib.WinForms.PropertyAxisBar[] {
            this.dataGrid1UnitPriceColumn,
            this.dataGridProgressBarColumn1,
            this.dataGridProgressBarColumn2,
            this.dataGridProgressBarColumn3,
            this.dataGridProgressBarColumn4,
            this.dataGrid1ProductIDColumn,
            this.dataGrid1ProductNameColumn,
            this.dataGrid1SupplierIDColumn,
            this.dataGrid1CategoryIDColumn,
            this.dataGrid1QuantityPerUnitColumn,
            this.dataGrid1UnitsInStockColumn,
            this.dataGrid1UnitsOnOrderColumn,
            this.dataGrid1ReorderLevelColumn,
            this.dataGrid1DiscontinuedColumn});
      this.dataGrid1.TabIndex = 7;
      // 
      // dataGrid1.Title
      // 
      this.dataGrid1.Title.Filter.Active = true;
      this.dataGrid1.Title.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
      this.dataGrid1.Title.SortMarking.SortMarkable = true;
      // 
      // productsBindingSource
      // 
      this.productsBindingSource.DataMember = "Products";
      this.productsBindingSource.DataSource = this.northwindDataSet;
      // 
      // northwindDataSet
      // 
      this.northwindDataSet.DataSetName = "NorthwindDataSet";
      this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // dataGrid1UnitPriceColumn
      // 
      this.dataGrid1UnitPriceColumn.DataPropertyName = "UnitPrice";
      this.dataGrid1UnitPriceColumn.FormatString = null;
      this.dataGrid1UnitPriceColumn.Name = "dataGrid1UnitPriceColumn";
      // 
      // dataGrid1UnitPriceColumn.Title
      // 
      this.dataGrid1UnitPriceColumn.Title.Text = "UnitPrice";
      this.dataGrid1UnitPriceColumn.Width = 93;
      // 
      // dataGridProgressBarColumn1
      // 
      this.dataGridProgressBarColumn1.DataPropertyName = "UnitPrice";
      this.dataGridProgressBarColumn1.MaxValue = 100D;
      this.dataGridProgressBarColumn1.MinValue = 0D;
      this.dataGridProgressBarColumn1.Name = "dataGridProgressBarColumn1";
      // 
      // dataGridProgressBarColumn1.Title
      // 
      this.dataGridProgressBarColumn1.Title.Text = "ProgressBar 1";
      this.dataGridProgressBarColumn1.Width = 100;
      // 
      // dataGridProgressBarColumn2
      // 
      this.dataGridProgressBarColumn2.BarFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(240)))), ((int)(((byte)(193)))));
      this.dataGridProgressBarColumn2.BarFrameColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.dataGridProgressBarColumn2.DataPropertyName = "UnitPrice";
      this.dataGridProgressBarColumn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataGridProgressBarColumn2.MaxValue = 100D;
      this.dataGridProgressBarColumn2.MinValue = 0D;
      this.dataGridProgressBarColumn2.Name = "dataGridProgressBarColumn2";
      // 
      // dataGridProgressBarColumn2.Title
      // 
      this.dataGridProgressBarColumn2.Title.Text = "ProgressBar 2";
      this.dataGridProgressBarColumn2.Width = 100;
      this.dataGridProgressBarColumn2.DataCellFormatParamsNeeded += new System.EventHandler<EhLib.WinForms.DataGridProgressBarDataCellFormatParamsNeededEventArgs>(this.DataGridProgressBarColumn2_DataCellFormatParamsNeeded);
      // 
      // dataGridProgressBarColumn3
      // 
      this.dataGridProgressBarColumn3.DataPropertyName = "UnitPrice";
      this.dataGridProgressBarColumn3.MaxValue = 100D;
      this.dataGridProgressBarColumn3.MinValue = 0D;
      this.dataGridProgressBarColumn3.Name = "dataGridProgressBarColumn3";
      // 
      // dataGridProgressBarColumn3.Title
      // 
      this.dataGridProgressBarColumn3.Title.Text = "ProgressBar 3";
      this.dataGridProgressBarColumn3.Width = 100;
      // 
      // dataGridProgressBarColumn4
      // 
      this.dataGridProgressBarColumn4.DataPropertyName = "UnitPrice";
      this.dataGridProgressBarColumn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataGridProgressBarColumn4.MaxValue = 100D;
      this.dataGridProgressBarColumn4.MinValue = 0D;
      this.dataGridProgressBarColumn4.Name = "dataGridProgressBarColumn4";
      // 
      // dataGridProgressBarColumn4.Title
      // 
      this.dataGridProgressBarColumn4.Title.Text = "ProgressBar 4";
      this.dataGridProgressBarColumn4.Width = 100;
      this.dataGridProgressBarColumn4.DataCellFormatParamsNeeded += new System.EventHandler<EhLib.WinForms.DataGridProgressBarDataCellFormatParamsNeededEventArgs>(this.dataGridProgressBarColumn1_DataCellFormatParamsNeeded);
      this.dataGridProgressBarColumn4.DataCellDisplayValueNeeded += new System.EventHandler<EhLib.WinForms.DataGridDataCellDisplayValueNeededEventArgs>(this.dataGridProgressBarColumn1_DataCellDisplayValueNeeded);
      // 
      // dataGrid1ProductIDColumn
      // 
      this.dataGrid1ProductIDColumn.DataPropertyName = "ProductID";
      this.dataGrid1ProductIDColumn.FormatString = null;
      this.dataGrid1ProductIDColumn.Name = "dataGrid1ProductIDColumn";
      // 
      // dataGrid1ProductIDColumn.Title
      // 
      this.dataGrid1ProductIDColumn.Title.Text = "ProductID";
      // 
      // dataGrid1ProductNameColumn
      // 
      this.dataGrid1ProductNameColumn.DataPropertyName = "ProductName";
      this.dataGrid1ProductNameColumn.FormatString = null;
      this.dataGrid1ProductNameColumn.Name = "dataGrid1ProductNameColumn";
      // 
      // dataGrid1ProductNameColumn.Title
      // 
      this.dataGrid1ProductNameColumn.Title.Text = "ProductName";
      // 
      // dataGrid1SupplierIDColumn
      // 
      this.dataGrid1SupplierIDColumn.DataPropertyName = "SupplierID";
      this.dataGrid1SupplierIDColumn.FormatString = null;
      this.dataGrid1SupplierIDColumn.Name = "dataGrid1SupplierIDColumn";
      // 
      // dataGrid1SupplierIDColumn.Title
      // 
      this.dataGrid1SupplierIDColumn.Title.Text = "SupplierID";
      // 
      // dataGrid1CategoryIDColumn
      // 
      this.dataGrid1CategoryIDColumn.DataPropertyName = "CategoryID";
      this.dataGrid1CategoryIDColumn.FormatString = null;
      this.dataGrid1CategoryIDColumn.Name = "dataGrid1CategoryIDColumn";
      // 
      // dataGrid1CategoryIDColumn.Title
      // 
      this.dataGrid1CategoryIDColumn.Title.Text = "CategoryID";
      // 
      // dataGrid1QuantityPerUnitColumn
      // 
      this.dataGrid1QuantityPerUnitColumn.DataPropertyName = "QuantityPerUnit";
      this.dataGrid1QuantityPerUnitColumn.FormatString = null;
      this.dataGrid1QuantityPerUnitColumn.Name = "dataGrid1QuantityPerUnitColumn";
      // 
      // dataGrid1QuantityPerUnitColumn.Title
      // 
      this.dataGrid1QuantityPerUnitColumn.Title.Text = "QuantityPerUnit";
      // 
      // dataGrid1UnitsInStockColumn
      // 
      this.dataGrid1UnitsInStockColumn.DataPropertyName = "UnitsInStock";
      this.dataGrid1UnitsInStockColumn.FormatString = null;
      this.dataGrid1UnitsInStockColumn.Name = "dataGrid1UnitsInStockColumn";
      // 
      // dataGrid1UnitsInStockColumn.Title
      // 
      this.dataGrid1UnitsInStockColumn.Title.Text = "UnitsInStock";
      // 
      // dataGrid1UnitsOnOrderColumn
      // 
      this.dataGrid1UnitsOnOrderColumn.DataPropertyName = "UnitsOnOrder";
      this.dataGrid1UnitsOnOrderColumn.FormatString = null;
      this.dataGrid1UnitsOnOrderColumn.Name = "dataGrid1UnitsOnOrderColumn";
      // 
      // dataGrid1UnitsOnOrderColumn.Title
      // 
      this.dataGrid1UnitsOnOrderColumn.Title.Text = "UnitsOnOrder";
      // 
      // dataGrid1ReorderLevelColumn
      // 
      this.dataGrid1ReorderLevelColumn.DataPropertyName = "ReorderLevel";
      this.dataGrid1ReorderLevelColumn.FormatString = null;
      this.dataGrid1ReorderLevelColumn.Name = "dataGrid1ReorderLevelColumn";
      // 
      // dataGrid1ReorderLevelColumn.Title
      // 
      this.dataGrid1ReorderLevelColumn.Title.Text = "ReorderLevel";
      // 
      // dataGrid1DiscontinuedColumn
      // 
      this.dataGrid1DiscontinuedColumn.DataPropertyName = "Discontinued";
      this.dataGrid1DiscontinuedColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.dataGrid1DiscontinuedColumn.Name = "dataGrid1DiscontinuedColumn";
      // 
      // dataGrid1DiscontinuedColumn.Title
      // 
      this.dataGrid1DiscontinuedColumn.Title.Text = "Discontinued";
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.splitContainer1);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(900, 476);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Description";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // splitContainer1
      // 
      this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(3, 3);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.richTextBoxEh1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.richTextBoxEh2);
      this.splitContainer1.Size = new System.Drawing.Size(894, 470);
      this.splitContainer1.SplitterDistance = 317;
      this.splitContainer1.SplitterWidth = 10;
      this.splitContainer1.TabIndex = 2;
      // 
      // richTextBoxEh1
      // 
      this.richTextBoxEh1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.richTextBoxEh1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.richTextBoxEh1.Location = new System.Drawing.Point(0, 0);
      this.richTextBoxEh1.Name = "richTextBoxEh1";
      this.richTextBoxEh1.Rtf = resources.GetString("richTextBoxEh1.Rtf");
      this.richTextBoxEh1.Size = new System.Drawing.Size(892, 315);
      this.richTextBoxEh1.TabIndex = 1;
      // 
      // richTextBoxEh2
      // 
      this.richTextBoxEh2.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.richTextBoxEh2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.richTextBoxEh2.Location = new System.Drawing.Point(0, 0);
      this.richTextBoxEh2.Name = "richTextBoxEh2";
      this.richTextBoxEh2.Rtf = resources.GetString("richTextBoxEh2.Rtf");
      this.richTextBoxEh2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
      this.richTextBoxEh2.Size = new System.Drawing.Size(892, 141);
      this.richTextBoxEh2.TabIndex = 2;
      this.richTextBoxEh2.WordWrap = false;
      // 
      // productsTableAdapter
      // 
      this.productsTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.CategoriesTableAdapter = null;
      this.tableAdapterManager.CustomersTableAdapter = null;
      this.tableAdapterManager.EmployeesTableAdapter = null;
      this.tableAdapterManager.Order_DetailsTableAdapter = null;
      this.tableAdapterManager.OrdersTableAdapter = null;
      this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
      this.tableAdapterManager.ShippersTableAdapter = null;
      this.tableAdapterManager.UpdateOrder = MainDemo.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // FrameSolDataGridProgressBars
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.panel1);
      this.Name = "FrameSolDataGridProgressBars";
      this.Size = new System.Drawing.Size(908, 538);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
      this.tabPage2.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private EhLib.WinForms.DataGridEh dataGrid1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.BindingSource productsBindingSource;
    private NorthwindDataSet northwindDataSet;
    private EhLib.WinForms.DataGridTextColumn dataGrid1ProductIDColumn;
    private EhLib.WinForms.DataGridTextColumn dataGrid1ProductNameColumn;
    private EhLib.WinForms.DataGridTextColumn dataGrid1SupplierIDColumn;
    private EhLib.WinForms.DataGridTextColumn dataGrid1CategoryIDColumn;
    private EhLib.WinForms.DataGridTextColumn dataGrid1QuantityPerUnitColumn;
    private EhLib.WinForms.DataGridTextColumn dataGrid1UnitPriceColumn;
    private EhLib.WinForms.DataGridTextColumn dataGrid1UnitsInStockColumn;
    private EhLib.WinForms.DataGridTextColumn dataGrid1UnitsOnOrderColumn;
    private EhLib.WinForms.DataGridTextColumn dataGrid1ReorderLevelColumn;
    private EhLib.WinForms.DataGridCheckBoxColumn dataGrid1DiscontinuedColumn;
    private NorthwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
    private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private EhLib.WinForms.DataGridProgressBarColumn dataGridProgressBarColumn1;
    private EhLib.WinForms.DataGridProgressBarColumn dataGridProgressBarColumn2;
    private EhLib.WinForms.DataGridProgressBarColumn dataGridProgressBarColumn3;
    private EhLib.WinForms.DataGridProgressBarColumn dataGridProgressBarColumn4;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private EhLib.WinForms.RichTextBoxEh richTextBoxEh1;
    private EhLib.WinForms.RichTextBoxEh richTextBoxEh2;
  }
}
