namespace MainDemo
{
  partial class FrameSolDataGridMergeDuplicates
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrameSolDataGridMergeDuplicates));
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.dataGrid1 = new EhLib.WinForms.DataGridEh();
      this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.northwindDataSet = new MainDemo.NorthwindDataSet();
      this.dataGrid1OrderIDCol = new EhLib.WinForms.DataGridTextColumn();
      this.dataGrid1CustomerIDCol = new EhLib.WinForms.DataGridTextColumn();
      this.CustomerNameComboCol = new EhLib.WinForms.DataGridComboBoxColumn();
      this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dataGrid1EmployeeIDCol = new EhLib.WinForms.DataGridTextColumn();
      this.EmployeeNameComboCol = new EhLib.WinForms.DataGridComboBoxColumn();
      this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dataGrid1OrderDateCol = new EhLib.WinForms.DataGridDateTimeColumn();
      this.dataGrid1RequiredDateCol = new EhLib.WinForms.DataGridDateTimeColumn();
      this.dataGrid1ShippedDateCol = new EhLib.WinForms.DataGridDateTimeColumn();
      this.dataGrid1ShipViaCol = new EhLib.WinForms.DataGridTextColumn();
      this.dataGrid1FreightCol = new EhLib.WinForms.DataGridTextColumn();
      this.dataGrid1ShipNameCol = new EhLib.WinForms.DataGridTextColumn();
      this.dataGrid1ShipAddressCol = new EhLib.WinForms.DataGridTextColumn();
      this.dataGrid1ShipCityCol = new EhLib.WinForms.DataGridTextColumn();
      this.dataGrid1ShipRegionCol = new EhLib.WinForms.DataGridTextColumn();
      this.dataGrid1ShipPostalCodeCol = new EhLib.WinForms.DataGridTextColumn();
      this.dataGrid1ShipCountryCol = new EhLib.WinForms.DataGridTextColumn();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.ordersTableAdapter = new MainDemo.NorthwindDataSetTableAdapters.OrdersTableAdapter();
      this.tableAdapterManager = new MainDemo.NorthwindDataSetTableAdapters.TableAdapterManager();
      this.customersTableAdapter = new MainDemo.NorthwindDataSetTableAdapters.CustomersTableAdapter();
      this.employeesTableAdapter = new MainDemo.NorthwindDataSetTableAdapters.EmployeesTableAdapter();
      this.richTextBoxEh1 = new EhLib.WinForms.RichTextBoxEh();
      this.panel1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
      this.tabPage2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(958, 39);
      this.panel1.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(6, 5);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(285, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "DataGridEh Merge Duplicates";
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 39);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(958, 391);
      this.tabControl1.TabIndex = 7;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.dataGrid1);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(950, 365);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Demo";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // dataGrid1
      // 
      this.dataGrid1.DataMember = "";
      this.dataGrid1.DataSource = this.ordersBindingSource;
      this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // 
      // 
      this.dataGrid1.EmptyDataInfo.Text = null;
      // 
      // dataGrid1.HorzScrollBar
      // 
      this.dataGrid1.HorzScrollBar.ExtraBar.Visible = true;
      this.dataGrid1.HorzScrollBar.Height = 24;
      this.dataGrid1.Location = new System.Drawing.Point(3, 3);
      this.dataGrid1.Name = "dataGrid1";
      this.dataGrid1.RowOptions.HorzLine.Style = System.Drawing.Drawing2D.DashStyle.Dot;
      this.dataGrid1.Size = new System.Drawing.Size(944, 359);
      this.dataGrid1.StaticColumns.AddRange(new EhLib.WinForms.PropertyAxisBar[] {
            this.dataGrid1OrderIDCol,
            this.dataGrid1CustomerIDCol,
            this.CustomerNameComboCol,
            this.dataGrid1EmployeeIDCol,
            this.EmployeeNameComboCol,
            this.dataGrid1OrderDateCol,
            this.dataGrid1RequiredDateCol,
            this.dataGrid1ShippedDateCol,
            this.dataGrid1ShipViaCol,
            this.dataGrid1FreightCol,
            this.dataGrid1ShipNameCol,
            this.dataGrid1ShipAddressCol,
            this.dataGrid1ShipCityCol,
            this.dataGrid1ShipRegionCol,
            this.dataGrid1ShipPostalCodeCol,
            this.dataGrid1ShipCountryCol});
      this.dataGrid1.TabIndex = 7;
      // 
      // dataGrid1.Title
      // 
      this.dataGrid1.Title.Filter.Active = true;
      this.dataGrid1.Title.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
      this.dataGrid1.Title.SortMarking.SortMarkable = true;
      this.dataGrid1.Title.SortMarking.SortSide = EhLib.WinForms.DataGridSortSide.DataGrid;
      this.dataGrid1.Title.InteractiveSortMarkingChanged += new System.EventHandler<EhLib.WinForms.SortMarkingChangedEventArgs>(this.DataGrid1_Title_InteractiveSortMarkingChanged);
      this.dataGrid1.HorzLineParamsNeeded += new System.EventHandler<EhLib.WinForms.DataGridHorzLineParamsNeededEventArgs>(this.DataGrid1_HorzLineParamsNeeded);
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
      // dataGrid1OrderIDCol
      // 
      this.dataGrid1OrderIDCol.DataPropertyName = "OrderID";
      this.dataGrid1OrderIDCol.Name = "dataGrid1OrderIDCol";
      // 
      // dataGrid1OrderIDCol.Title
      // 
      this.dataGrid1OrderIDCol.Title.Text = "OrderID";
      // 
      // dataGrid1CustomerIDCol
      // 
      this.dataGrid1CustomerIDCol.DataPropertyName = "CustomerID";
      this.dataGrid1CustomerIDCol.Name = "dataGrid1CustomerIDCol";
      // 
      // dataGrid1CustomerIDCol.Title
      // 
      this.dataGrid1CustomerIDCol.Title.Text = "CustomerID";
      // 
      // CustomerNameComboCol
      // 
      this.CustomerNameComboCol.DataPropertyName = "CustomerID";
      this.CustomerNameComboCol.DataSource = this.customersBindingSource;
      this.CustomerNameComboCol.DisplayMember = "CompanyName";
      // 
      // CustomerNameComboCol.EditButton
      // 
      this.CustomerNameComboCol.EditButton.Visible = false;
      this.CustomerNameComboCol.Name = "CustomerNameComboCol";
      // 
      // CustomerNameComboCol.Title
      // 
      this.CustomerNameComboCol.Title.Text = "Customer Name";
      this.CustomerNameComboCol.ValueMember = "CustomerID";
      this.CustomerNameComboCol.Width = 175;
      // 
      // customersBindingSource
      // 
      this.customersBindingSource.DataMember = "Customers";
      this.customersBindingSource.DataSource = this.northwindDataSet;
      // 
      // dataGrid1EmployeeIDCol
      // 
      this.dataGrid1EmployeeIDCol.DataPropertyName = "EmployeeID";
      this.dataGrid1EmployeeIDCol.Name = "dataGrid1EmployeeIDCol";
      // 
      // dataGrid1EmployeeIDCol.Title
      // 
      this.dataGrid1EmployeeIDCol.Title.Text = "EmployeeID";
      // 
      // EmployeeNameComboCol
      // 
      this.EmployeeNameComboCol.DataPropertyName = "EmployeeID";
      this.EmployeeNameComboCol.DataSource = this.employeesBindingSource;
      this.EmployeeNameComboCol.DisplayMember = "Name";
      // 
      // EmployeeNameComboCol.EditButton
      // 
      this.EmployeeNameComboCol.EditButton.Visible = false;
      this.EmployeeNameComboCol.Name = "EmployeeNameComboCol";
      // 
      // EmployeeNameComboCol.Title
      // 
      this.EmployeeNameComboCol.Title.Text = "Employee Name";
      this.EmployeeNameComboCol.ValueMember = "EmployeeID";
      this.EmployeeNameComboCol.Width = 133;
      // 
      // employeesBindingSource
      // 
      this.employeesBindingSource.DataMember = "Employees";
      this.employeesBindingSource.DataSource = this.northwindDataSet;
      // 
      // dataGrid1OrderDateCol
      // 
      this.dataGrid1OrderDateCol.DataPropertyName = "OrderDate";
      // 
      // dataGrid1OrderDateCol.EditButton
      // 
      this.dataGrid1OrderDateCol.EditButton.Visible = false;
      this.dataGrid1OrderDateCol.Name = "dataGrid1OrderDateCol";
      // 
      // dataGrid1OrderDateCol.Title
      // 
      this.dataGrid1OrderDateCol.Title.Text = "OrderDate";
      this.dataGrid1OrderDateCol.Width = 76;
      // 
      // dataGrid1RequiredDateCol
      // 
      this.dataGrid1RequiredDateCol.DataPropertyName = "RequiredDate";
      // 
      // dataGrid1RequiredDateCol.EditButton
      // 
      this.dataGrid1RequiredDateCol.EditButton.Visible = false;
      this.dataGrid1RequiredDateCol.Name = "dataGrid1RequiredDateCol";
      // 
      // dataGrid1RequiredDateCol.Title
      // 
      this.dataGrid1RequiredDateCol.Title.Text = "RequiredDate";
      this.dataGrid1RequiredDateCol.Width = 100;
      // 
      // dataGrid1ShippedDateCol
      // 
      this.dataGrid1ShippedDateCol.DataPropertyName = "ShippedDate";
      // 
      // dataGrid1ShippedDateCol.EditButton
      // 
      this.dataGrid1ShippedDateCol.EditButton.Visible = false;
      this.dataGrid1ShippedDateCol.Name = "dataGrid1ShippedDateCol";
      // 
      // dataGrid1ShippedDateCol.Title
      // 
      this.dataGrid1ShippedDateCol.Title.Text = "ShippedDate";
      this.dataGrid1ShippedDateCol.Width = 103;
      // 
      // dataGrid1ShipViaCol
      // 
      this.dataGrid1ShipViaCol.DataPropertyName = "ShipVia";
      this.dataGrid1ShipViaCol.Name = "dataGrid1ShipViaCol";
      // 
      // dataGrid1ShipViaCol.Title
      // 
      this.dataGrid1ShipViaCol.Title.Text = "ShipVia";
      // 
      // dataGrid1FreightCol
      // 
      this.dataGrid1FreightCol.DataPropertyName = "Freight";
      this.dataGrid1FreightCol.Name = "dataGrid1FreightCol";
      // 
      // dataGrid1FreightCol.Title
      // 
      this.dataGrid1FreightCol.Title.Text = "Freight";
      // 
      // dataGrid1ShipNameCol
      // 
      this.dataGrid1ShipNameCol.DataPropertyName = "ShipName";
      this.dataGrid1ShipNameCol.Name = "dataGrid1ShipNameCol";
      // 
      // dataGrid1ShipNameCol.Title
      // 
      this.dataGrid1ShipNameCol.Title.Text = "ShipName";
      // 
      // dataGrid1ShipAddressCol
      // 
      this.dataGrid1ShipAddressCol.DataPropertyName = "ShipAddress";
      this.dataGrid1ShipAddressCol.Name = "dataGrid1ShipAddressCol";
      // 
      // dataGrid1ShipAddressCol.Title
      // 
      this.dataGrid1ShipAddressCol.Title.Text = "ShipAddress";
      // 
      // dataGrid1ShipCityCol
      // 
      this.dataGrid1ShipCityCol.DataPropertyName = "ShipCity";
      this.dataGrid1ShipCityCol.Name = "dataGrid1ShipCityCol";
      // 
      // dataGrid1ShipCityCol.Title
      // 
      this.dataGrid1ShipCityCol.Title.Text = "ShipCity";
      // 
      // dataGrid1ShipRegionCol
      // 
      this.dataGrid1ShipRegionCol.DataPropertyName = "ShipRegion";
      this.dataGrid1ShipRegionCol.Name = "dataGrid1ShipRegionCol";
      // 
      // dataGrid1ShipRegionCol.Title
      // 
      this.dataGrid1ShipRegionCol.Title.Text = "ShipRegion";
      // 
      // dataGrid1ShipPostalCodeCol
      // 
      this.dataGrid1ShipPostalCodeCol.DataPropertyName = "ShipPostalCode";
      this.dataGrid1ShipPostalCodeCol.Name = "dataGrid1ShipPostalCodeCol";
      // 
      // dataGrid1ShipPostalCodeCol.Title
      // 
      this.dataGrid1ShipPostalCodeCol.Title.Text = "ShipPostalCode";
      // 
      // dataGrid1ShipCountryCol
      // 
      this.dataGrid1ShipCountryCol.DataPropertyName = "ShipCountry";
      this.dataGrid1ShipCountryCol.Name = "dataGrid1ShipCountryCol";
      // 
      // dataGrid1ShipCountryCol.Title
      // 
      this.dataGrid1ShipCountryCol.Title.Text = "ShipCountry";
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.richTextBoxEh1);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(950, 365);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Description";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // ordersTableAdapter
      // 
      this.ordersTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.CategoriesTableAdapter = null;
      this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
      this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
      this.tableAdapterManager.Order_DetailsTableAdapter = null;
      this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
      this.tableAdapterManager.ProductsTableAdapter = null;
      this.tableAdapterManager.ShippersTableAdapter = null;
      this.tableAdapterManager.UpdateOrder = MainDemo.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // customersTableAdapter
      // 
      this.customersTableAdapter.ClearBeforeFill = true;
      // 
      // employeesTableAdapter
      // 
      this.employeesTableAdapter.ClearBeforeFill = true;
      // 
      // richTextBoxEh1
      // 
      this.richTextBoxEh1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.richTextBoxEh1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.richTextBoxEh1.Location = new System.Drawing.Point(3, 3);
      this.richTextBoxEh1.Name = "richTextBoxEh1";
      this.richTextBoxEh1.Rtf = resources.GetString("richTextBoxEh1.Rtf");
      this.richTextBoxEh1.Size = new System.Drawing.Size(944, 359);
      this.richTextBoxEh1.TabIndex = 2;
      // 
      // FrameSolDataGridMergeDuplicates
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.panel1);
      this.Name = "FrameSolDataGridMergeDuplicates";
      this.Size = new System.Drawing.Size(958, 430);
      this.Load += new System.EventHandler(this.FrameSolDataGridMergeDuplicates_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
      this.tabPage2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private EhLib.WinForms.DataGridEh dataGrid1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.BindingSource ordersBindingSource;
    private NorthwindDataSet northwindDataSet;
    private EhLib.WinForms.DataGridTextColumn dataGrid1OrderIDCol;
    private EhLib.WinForms.DataGridTextColumn dataGrid1CustomerIDCol;
    private EhLib.WinForms.DataGridTextColumn dataGrid1EmployeeIDCol;
    private EhLib.WinForms.DataGridDateTimeColumn dataGrid1OrderDateCol;
    private EhLib.WinForms.DataGridDateTimeColumn dataGrid1RequiredDateCol;
    private EhLib.WinForms.DataGridDateTimeColumn dataGrid1ShippedDateCol;
    private EhLib.WinForms.DataGridTextColumn dataGrid1ShipViaCol;
    private EhLib.WinForms.DataGridTextColumn dataGrid1FreightCol;
    private EhLib.WinForms.DataGridTextColumn dataGrid1ShipNameCol;
    private EhLib.WinForms.DataGridTextColumn dataGrid1ShipAddressCol;
    private EhLib.WinForms.DataGridTextColumn dataGrid1ShipCityCol;
    private EhLib.WinForms.DataGridTextColumn dataGrid1ShipRegionCol;
    private EhLib.WinForms.DataGridTextColumn dataGrid1ShipPostalCodeCol;
    private EhLib.WinForms.DataGridTextColumn dataGrid1ShipCountryCol;
    private EhLib.WinForms.DataGridComboBoxColumn CustomerNameComboCol;
    private System.Windows.Forms.BindingSource customersBindingSource;
    private EhLib.WinForms.DataGridComboBoxColumn EmployeeNameComboCol;
    private NorthwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
    private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
    private NorthwindDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
    private System.Windows.Forms.BindingSource employeesBindingSource;
    private EhLib.WinForms.RichTextBoxEh richTextBoxEh1;
  }
}
