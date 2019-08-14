namespace MainDemo
{
  partial class TmpFrameMainGridWithGridView
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
      this.northwindDataSet = new MainDemo.NorthwindDataSet();
      this.bsEmployees = new System.Windows.Forms.BindingSource(this.components);
      this.bsMain = new System.Windows.Forms.BindingSource(this.components);
      this.ordersTableAdapter = new MainDemo.NorthwindDataSetTableAdapters.OrdersTableAdapter();
      this.employeesTableAdapter = new MainDemo.NorthwindDataSetTableAdapters.EmployeesTableAdapter();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnComboBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.orderIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.requiredDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shippedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shipViaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.freightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shipNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shipAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shipCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shipRegionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shipPostalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.shipCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(734, 36);
      this.panel1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(32, 6);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(208, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "Main GridView (Tmp)";
      // 
      // northwindDataSet
      // 
      this.northwindDataSet.DataSetName = "NorthwindDataSet";
      this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // bsEmployees
      // 
      this.bsEmployees.DataMember = "Employees";
      this.bsEmployees.DataSource = this.northwindDataSet;
      this.bsEmployees.Sort = "Name";
      // 
      // bsMain
      // 
      this.bsMain.DataMember = "Orders";
      this.bsMain.DataSource = this.northwindDataSet;
      // 
      // ordersTableAdapter
      // 
      this.ordersTableAdapter.ClearBeforeFill = true;
      // 
      // employeesTableAdapter
      // 
      this.employeesTableAdapter.ClearBeforeFill = true;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnComboBox,
            this.orderIDDataGridViewTextBoxColumn1,
            this.customerIDDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.requiredDateDataGridViewTextBoxColumn,
            this.shippedDateDataGridViewTextBoxColumn,
            this.shipViaDataGridViewTextBoxColumn,
            this.freightDataGridViewTextBoxColumn,
            this.shipNameDataGridViewTextBoxColumn,
            this.shipAddressDataGridViewTextBoxColumn,
            this.shipCityDataGridViewTextBoxColumn,
            this.shipRegionDataGridViewTextBoxColumn,
            this.shipPostalCodeDataGridViewTextBoxColumn,
            this.shipCountryDataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.bsMain;
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(0, 36);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(734, 443);
      this.dataGridView1.TabIndex = 2;
      this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
      // 
      // orderIDDataGridViewTextBoxColumn
      // 
      this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "Order ID";
      this.orderIDDataGridViewTextBoxColumn.HeaderText = "Order ID";
      this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
      // 
      // ColumnComboBox
      // 
      this.ColumnComboBox.DataPropertyName = "EmployeeID";
      this.ColumnComboBox.DataSource = this.bsEmployees;
      this.ColumnComboBox.DisplayMember = "Name";
      this.ColumnComboBox.DividerWidth = 1;
      this.ColumnComboBox.HeaderText = "Column1";
      this.ColumnComboBox.Name = "ColumnComboBox";
      this.ColumnComboBox.ValueMember = "EmployeeID";
      // 
      // orderIDDataGridViewTextBoxColumn1
      // 
      this.orderIDDataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
      this.orderIDDataGridViewTextBoxColumn1.DividerWidth = 2;
      this.orderIDDataGridViewTextBoxColumn1.HeaderText = "OrderID";
      this.orderIDDataGridViewTextBoxColumn1.Name = "orderIDDataGridViewTextBoxColumn1";
      // 
      // customerIDDataGridViewTextBoxColumn
      // 
      this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
      this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
      this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
      // 
      // employeeIDDataGridViewTextBoxColumn
      // 
      this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
      this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
      this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
      // 
      // orderDateDataGridViewTextBoxColumn
      // 
      this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
      this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
      this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
      // 
      // requiredDateDataGridViewTextBoxColumn
      // 
      this.requiredDateDataGridViewTextBoxColumn.DataPropertyName = "RequiredDate";
      this.requiredDateDataGridViewTextBoxColumn.HeaderText = "RequiredDate";
      this.requiredDateDataGridViewTextBoxColumn.Name = "requiredDateDataGridViewTextBoxColumn";
      // 
      // shippedDateDataGridViewTextBoxColumn
      // 
      this.shippedDateDataGridViewTextBoxColumn.DataPropertyName = "ShippedDate";
      this.shippedDateDataGridViewTextBoxColumn.HeaderText = "ShippedDate";
      this.shippedDateDataGridViewTextBoxColumn.Name = "shippedDateDataGridViewTextBoxColumn";
      // 
      // shipViaDataGridViewTextBoxColumn
      // 
      this.shipViaDataGridViewTextBoxColumn.DataPropertyName = "ShipVia";
      this.shipViaDataGridViewTextBoxColumn.HeaderText = "ShipVia";
      this.shipViaDataGridViewTextBoxColumn.Name = "shipViaDataGridViewTextBoxColumn";
      // 
      // freightDataGridViewTextBoxColumn
      // 
      this.freightDataGridViewTextBoxColumn.DataPropertyName = "Freight";
      this.freightDataGridViewTextBoxColumn.HeaderText = "Freight";
      this.freightDataGridViewTextBoxColumn.Name = "freightDataGridViewTextBoxColumn";
      // 
      // shipNameDataGridViewTextBoxColumn
      // 
      this.shipNameDataGridViewTextBoxColumn.DataPropertyName = "ShipName";
      this.shipNameDataGridViewTextBoxColumn.HeaderText = "ShipName";
      this.shipNameDataGridViewTextBoxColumn.Name = "shipNameDataGridViewTextBoxColumn";
      // 
      // shipAddressDataGridViewTextBoxColumn
      // 
      this.shipAddressDataGridViewTextBoxColumn.DataPropertyName = "ShipAddress";
      this.shipAddressDataGridViewTextBoxColumn.HeaderText = "ShipAddress";
      this.shipAddressDataGridViewTextBoxColumn.Name = "shipAddressDataGridViewTextBoxColumn";
      // 
      // shipCityDataGridViewTextBoxColumn
      // 
      this.shipCityDataGridViewTextBoxColumn.DataPropertyName = "ShipCity";
      this.shipCityDataGridViewTextBoxColumn.HeaderText = "ShipCity";
      this.shipCityDataGridViewTextBoxColumn.Name = "shipCityDataGridViewTextBoxColumn";
      // 
      // shipRegionDataGridViewTextBoxColumn
      // 
      this.shipRegionDataGridViewTextBoxColumn.DataPropertyName = "ShipRegion";
      this.shipRegionDataGridViewTextBoxColumn.HeaderText = "ShipRegion";
      this.shipRegionDataGridViewTextBoxColumn.Name = "shipRegionDataGridViewTextBoxColumn";
      // 
      // shipPostalCodeDataGridViewTextBoxColumn
      // 
      this.shipPostalCodeDataGridViewTextBoxColumn.DataPropertyName = "ShipPostalCode";
      this.shipPostalCodeDataGridViewTextBoxColumn.HeaderText = "ShipPostalCode";
      this.shipPostalCodeDataGridViewTextBoxColumn.Name = "shipPostalCodeDataGridViewTextBoxColumn";
      // 
      // shipCountryDataGridViewTextBoxColumn
      // 
      this.shipCountryDataGridViewTextBoxColumn.DataPropertyName = "ShipCountry";
      this.shipCountryDataGridViewTextBoxColumn.HeaderText = "ShipCountry";
      this.shipCountryDataGridViewTextBoxColumn.Name = "shipCountryDataGridViewTextBoxColumn";
      // 
      // TmpFrameMainGridWithGridView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.panel1);
      this.Name = "TmpFrameMainGridWithGridView";
      this.Size = new System.Drawing.Size(734, 479);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.BindingSource bsMain;
    private NorthwindDataSet northwindDataSet;
    private NorthwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
    private System.Windows.Forms.BindingSource bsEmployees;
    private NorthwindDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewComboBoxColumn ColumnComboBox;
    private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn requiredDateDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn shippedDateDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn shipViaDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn freightDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn shipNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn shipAddressDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn shipCityDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn shipRegionDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn shipPostalCodeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn shipCountryDataGridViewTextBoxColumn;
  }
}
