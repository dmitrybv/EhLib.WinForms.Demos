namespace MainDemo
{
  partial class FrameDataGrouping
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
      EhLib.WinForms.SumCalculator sumCalculator1 = new EhLib.WinForms.SumCalculator();
      EhLib.WinForms.StaticTextCalculator staticTextCalculator1 = new EhLib.WinForms.StaticTextCalculator();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.northwindDataSet = new MainDemo.NorthwindDataSet();
      this.ordersTableAdapter = new MainDemo.NorthwindDataSetTableAdapters.OrdersTableAdapter();
      this.tableAdapterManager = new MainDemo.NorthwindDataSetTableAdapters.TableAdapterManager();
      this.dataGridEh1 = new EhLib.WinForms.DataGridEh();
      this.dataGridGroupDescription1 = new EhLib.WinForms.DataGridGroupDescription();
      this.dataGridEh1ShipCountryColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridGroupDescription2 = new EhLib.WinForms.DataGridGroupDescription();
      this.dataGridEh1ShipCityColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridFooterRow1 = new EhLib.WinForms.DataGridFooterRow();
      this.dataGridColumnFooterItem1 = new EhLib.WinForms.DataGridColumnFooterItem();
      this.dataGridColumnFooterItem2 = new EhLib.WinForms.DataGridColumnFooterItem();
      this.dataGridEh1OrderIDColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridEh1CustomerIDColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridEh1EmployeeIDColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridEh1OrderDateColumn = new EhLib.WinForms.DataGridDateTimeColumn();
      this.dataGridEh1ShipViaColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridEh1FreightColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridEh1ShipNameColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridEh1ShipRegionColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridEh1ShipPostalCodeColumn = new EhLib.WinForms.DataGridTextColumn();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridEh1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(753, 36);
      this.panel1.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(32, 6);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(144, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "Data Grouping";
      // 
      // ordersBindingSource
      // 
      this.ordersBindingSource.DataMember = "Orders";
      this.ordersBindingSource.DataSource = this.northwindDataSet;
      // 
      // northwindDataSet
      // 
      this.northwindDataSet.DataSetName = "NorthwindDataSet";
      this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // ordersTableAdapter
      // 
      this.ordersTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.CategoriesTableAdapter = null;
      this.tableAdapterManager.CustomersTableAdapter = null;
      this.tableAdapterManager.EmployeesTableAdapter = null;
      this.tableAdapterManager.Order_DetailsTableAdapter = null;
      this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
      this.tableAdapterManager.ProductsTableAdapter = null;
      this.tableAdapterManager.ShippersTableAdapter = null;
      this.tableAdapterManager.UpdateOrder = MainDemo.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // dataGridEh1
      // 
      // 
      // dataGridEh1.DataGrouping
      // 
      this.dataGridEh1.DataGrouping.BackColor = System.Drawing.Color.NavajoWhite;
      this.dataGridEh1.DataGrouping.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.dataGridEh1.DataGrouping.ForeColor = System.Drawing.Color.MidnightBlue;
      this.dataGridEh1.DataGrouping.GroupDescriptions.Add(this.dataGridGroupDescription1);
      this.dataGridEh1.DataGrouping.GroupDescriptions.Add(this.dataGridGroupDescription2);
      // 
      // 
      // 
      this.dataGridEh1.DataGrouping.GroupPanel.Visible = true;
      this.dataGridEh1.DataGrouping.Padding = new System.Windows.Forms.Padding(6, 4, 0, 10);
      this.dataGridEh1.DataGrouping.GroupDescriprionsChanged += new System.EventHandler(this.dataGridEh1_DataGrouping_GroupDescriprionsChanged);
      this.dataGridEh1.DataMember = "";
      this.dataGridEh1.DataSource = this.ordersBindingSource;
      this.dataGridEh1.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // dataGridEh1.Footer
      // 
      this.dataGridEh1.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataGridEh1.Footer.Rows.AddRange(new EhLib.WinForms.DataGridFooterRow[] {
            this.dataGridFooterRow1});
      this.dataGridEh1.Location = new System.Drawing.Point(0, 36);
      this.dataGridEh1.Name = "dataGridEh1";
      this.dataGridEh1.Size = new System.Drawing.Size(753, 407);
      this.dataGridEh1.StaticColumns.AddRange(new EhLib.WinForms.PropertyAxisBar[] {
            this.dataGridEh1OrderIDColumn,
            this.dataGridEh1ShipCountryColumn,
            this.dataGridEh1ShipCityColumn,
            this.dataGridEh1CustomerIDColumn,
            this.dataGridEh1EmployeeIDColumn,
            this.dataGridEh1OrderDateColumn,
            this.dataGridEh1ShipViaColumn,
            this.dataGridEh1FreightColumn,
            this.dataGridEh1ShipNameColumn,
            this.dataGridEh1ShipRegionColumn,
            this.dataGridEh1ShipPostalCodeColumn});
      this.dataGridEh1.TabIndex = 3;
      // 
      // dataGridEh1.Title
      // 
      this.dataGridEh1.Title.Filter.Active = true;
      this.dataGridEh1.Title.HeightOptions.ContentHeight = 2;
      // 
      // dataGridGroupDescription1
      // 
      this.dataGridGroupDescription1.Column = this.dataGridEh1ShipCountryColumn;
      // 
      // dataGridEh1ShipCountryColumn
      // 
      this.dataGridEh1ShipCountryColumn.DataPropertyName = "ShipCountry";
      this.dataGridEh1ShipCountryColumn.Name = "dataGridEh1ShipCountryColumn";
      // 
      // dataGridEh1ShipCountryColumn.Title
      // 
      this.dataGridEh1ShipCountryColumn.Title.Text = "ShipCountry";
      this.dataGridEh1ShipCountryColumn.Visible = false;
      this.dataGridEh1ShipCountryColumn.Width = 104;
      // 
      // dataGridGroupDescription2
      // 
      this.dataGridGroupDescription2.Column = this.dataGridEh1ShipCityColumn;
      // 
      // dataGridEh1ShipCityColumn
      // 
      this.dataGridEh1ShipCityColumn.DataPropertyName = "ShipCity";
      this.dataGridEh1ShipCityColumn.Name = "dataGridEh1ShipCityColumn";
      // 
      // dataGridEh1ShipCityColumn.Title
      // 
      this.dataGridEh1ShipCityColumn.Title.Text = "ShipCity";
      this.dataGridEh1ShipCityColumn.Visible = false;
      this.dataGridEh1ShipCityColumn.Width = 115;
      // 
      // dataGridFooterRow1
      // 
      this.dataGridFooterRow1.BoundItems.Add(this.dataGridColumnFooterItem1);
      this.dataGridFooterRow1.BoundItems.Add(this.dataGridColumnFooterItem2);
      // 
      // dataGridColumnFooterItem1
      // 
      this.dataGridColumnFooterItem1.CalcValueFunction = sumCalculator1;
      this.dataGridColumnFooterItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataGridColumnFooterItem1.FormatString = "#,##0.00";
      // 
      // dataGridColumnFooterItem2
      // 
      staticTextCalculator1.Text = "Total";
      this.dataGridColumnFooterItem2.CalcValueFunction = staticTextCalculator1;
      this.dataGridColumnFooterItem2.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.dataGridColumnFooterItem2.CellFormatValue += new System.EventHandler<EhLib.WinForms.DataGridFooterCellFormatValueEventArgs>(this.dataGridColumnFooterItem2_CellFormatValue);
      // 
      // dataGridEh1OrderIDColumn
      // 
      this.dataGridEh1OrderIDColumn.DataPropertyName = "OrderID";
      // 
      // 
      // 
      this.dataGridEh1OrderIDColumn.Footer.BoundItems.Add(this.dataGridColumnFooterItem2);
      this.dataGridEh1OrderIDColumn.Name = "dataGridEh1OrderIDColumn";
      // 
      // dataGridEh1OrderIDColumn.Title
      // 
      this.dataGridEh1OrderIDColumn.Title.Text = "OrderID";
      this.dataGridEh1OrderIDColumn.Width = 122;
      // 
      // dataGridEh1CustomerIDColumn
      // 
      this.dataGridEh1CustomerIDColumn.DataPropertyName = "CustomerID";
      this.dataGridEh1CustomerIDColumn.Name = "dataGridEh1CustomerIDColumn";
      // 
      // dataGridEh1CustomerIDColumn.Title
      // 
      this.dataGridEh1CustomerIDColumn.Title.Text = "CustomerID";
      // 
      // dataGridEh1EmployeeIDColumn
      // 
      this.dataGridEh1EmployeeIDColumn.DataPropertyName = "EmployeeID";
      this.dataGridEh1EmployeeIDColumn.Name = "dataGridEh1EmployeeIDColumn";
      // 
      // dataGridEh1EmployeeIDColumn.Title
      // 
      this.dataGridEh1EmployeeIDColumn.Title.Text = "EmployeeID";
      // 
      // dataGridEh1OrderDateColumn
      // 
      this.dataGridEh1OrderDateColumn.DataPropertyName = "OrderDate";
      this.dataGridEh1OrderDateColumn.Name = "dataGridEh1OrderDateColumn";
      // 
      // dataGridEh1OrderDateColumn.Title
      // 
      this.dataGridEh1OrderDateColumn.Title.Text = "OrderDate";
      this.dataGridEh1OrderDateColumn.Width = 100;
      // 
      // dataGridEh1ShipViaColumn
      // 
      this.dataGridEh1ShipViaColumn.DataPropertyName = "ShipVia";
      this.dataGridEh1ShipViaColumn.Name = "dataGridEh1ShipViaColumn";
      // 
      // dataGridEh1ShipViaColumn.Title
      // 
      this.dataGridEh1ShipViaColumn.Title.Text = "ShipVia";
      // 
      // dataGridEh1FreightColumn
      // 
      this.dataGridEh1FreightColumn.DataPropertyName = "Freight";
      // 
      // 
      // 
      this.dataGridEh1FreightColumn.Footer.BoundItems.Add(this.dataGridColumnFooterItem1);
      this.dataGridEh1FreightColumn.FormatString = "#,##0.00";
      this.dataGridEh1FreightColumn.Name = "dataGridEh1FreightColumn";
      // 
      // dataGridEh1FreightColumn.Title
      // 
      this.dataGridEh1FreightColumn.Title.Text = "Freight";
      this.dataGridEh1FreightColumn.Width = 77;
      // 
      // dataGridEh1ShipNameColumn
      // 
      this.dataGridEh1ShipNameColumn.DataPropertyName = "ShipName";
      this.dataGridEh1ShipNameColumn.Name = "dataGridEh1ShipNameColumn";
      // 
      // dataGridEh1ShipNameColumn.Title
      // 
      this.dataGridEh1ShipNameColumn.Title.Text = "ShipName";
      this.dataGridEh1ShipNameColumn.Width = 219;
      // 
      // dataGridEh1ShipRegionColumn
      // 
      this.dataGridEh1ShipRegionColumn.DataPropertyName = "ShipRegion";
      this.dataGridEh1ShipRegionColumn.Name = "dataGridEh1ShipRegionColumn";
      // 
      // dataGridEh1ShipRegionColumn.Title
      // 
      this.dataGridEh1ShipRegionColumn.Title.Text = "ShipRegion";
      // 
      // dataGridEh1ShipPostalCodeColumn
      // 
      this.dataGridEh1ShipPostalCodeColumn.DataPropertyName = "ShipPostalCode";
      this.dataGridEh1ShipPostalCodeColumn.Name = "dataGridEh1ShipPostalCodeColumn";
      // 
      // dataGridEh1ShipPostalCodeColumn.Title
      // 
      this.dataGridEh1ShipPostalCodeColumn.Title.Text = "ShipPostalCode";
      // 
      // FrameDataGrouping
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.Controls.Add(this.dataGridEh1);
      this.Controls.Add(this.panel1);
      this.Name = "FrameDataGrouping";
      this.Size = new System.Drawing.Size(753, 443);
      this.Load += new System.EventHandler(this.FrameDataGrouping_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridEh1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private EhLib.WinForms.DataGridEh dataGridEh1;
    private System.Windows.Forms.BindingSource ordersBindingSource;
    private NorthwindDataSet northwindDataSet;
    private NorthwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
    private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private EhLib.WinForms.DataGridGroupDescription dataGridGroupDescription1;
    private EhLib.WinForms.DataGridTextColumn dataGridEh1ShipCountryColumn;
    private EhLib.WinForms.DataGridGroupDescription dataGridGroupDescription2;
    private EhLib.WinForms.DataGridTextColumn dataGridEh1ShipCityColumn;
    private EhLib.WinForms.DataGridTextColumn dataGridEh1OrderIDColumn;
    private EhLib.WinForms.DataGridTextColumn dataGridEh1CustomerIDColumn;
    private EhLib.WinForms.DataGridTextColumn dataGridEh1EmployeeIDColumn;
    private EhLib.WinForms.DataGridDateTimeColumn dataGridEh1OrderDateColumn;
    private EhLib.WinForms.DataGridTextColumn dataGridEh1ShipViaColumn;
    private EhLib.WinForms.DataGridTextColumn dataGridEh1FreightColumn;
    private EhLib.WinForms.DataGridTextColumn dataGridEh1ShipNameColumn;
    private EhLib.WinForms.DataGridTextColumn dataGridEh1ShipRegionColumn;
    private EhLib.WinForms.DataGridTextColumn dataGridEh1ShipPostalCodeColumn;
    private EhLib.WinForms.DataGridFooterRow dataGridFooterRow1;
    private EhLib.WinForms.DataGridColumnFooterItem dataGridColumnFooterItem1;
    private EhLib.WinForms.DataGridColumnFooterItem dataGridColumnFooterItem2;
  }
}
