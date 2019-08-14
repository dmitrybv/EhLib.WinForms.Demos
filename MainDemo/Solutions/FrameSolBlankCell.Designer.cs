namespace MainDemo
{
  partial class FrameSolBlankCell
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrameSolBlankCell));
      this.dataGridEh1 = new EhLib.WinForms.DataGridEh();
      this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.northwindDataSet = new MainDemo.NorthwindDataSet();
      this.blankCell = new EhLib.WinForms.BlankDataCellManager();
      this.dataGridEh1EmployeeIDColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridEh1LastNameColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridEh1FirstNameColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridEh1PostalCodeColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridEh1CountryColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridEh1RegionColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridEh1CityColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridEh1AddressColumn = new EhLib.WinForms.DataGridTextColumn();
      this.employeesTableAdapter = new MainDemo.NorthwindDataSetTableAdapters.EmployeesTableAdapter();
      this.tableAdapterManager = new MainDemo.NorthwindDataSetTableAdapters.TableAdapterManager();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.textBox1 = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridEh1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
      this.panel1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.SuspendLayout();
      // 
      // dataGridEh1
      // 
      this.dataGridEh1.DataMember = "";
      this.dataGridEh1.DataSource = this.employeesBindingSource;
      this.dataGridEh1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridEh1.ExtraCellManagers.Add(this.blankCell);
      this.dataGridEh1.Location = new System.Drawing.Point(3, 3);
      this.dataGridEh1.Name = "dataGridEh1";
      this.dataGridEh1.Size = new System.Drawing.Size(911, 399);
      this.dataGridEh1.StaticColumns.AddRange(new EhLib.WinForms.PropertyAxisBar[] {
            this.dataGridEh1EmployeeIDColumn,
            this.dataGridEh1LastNameColumn,
            this.dataGridEh1FirstNameColumn,
            this.dataGridEh1PostalCodeColumn,
            this.dataGridEh1CountryColumn,
            this.dataGridEh1RegionColumn,
            this.dataGridEh1CityColumn,
            this.dataGridEh1AddressColumn});
      this.dataGridEh1.TabIndex = 3;
      // 
      // employeesBindingSource
      // 
      this.employeesBindingSource.DataMember = "Employees";
      this.employeesBindingSource.DataSource = this.northwindDataSet;
      // 
      // northwindDataSet
      // 
      this.northwindDataSet.DataSetName = "NorthwindDataSet";
      this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // blankCell
      // 
      this.blankCell.BackFiller.FillStyle = EhLib.WinForms.CellFillStyle.Solid;
      // 
      // dataGridEh1EmployeeIDColumn
      // 
      this.dataGridEh1EmployeeIDColumn.DataPropertyName = "EmployeeID";
      this.dataGridEh1EmployeeIDColumn.Name = "dataGridEh1EmployeeIDColumn";
      // 
      // 
      // 
      this.dataGridEh1EmployeeIDColumn.Title.Text = "EmployeeID";
      this.dataGridEh1EmployeeIDColumn.Title.ToolTipText = null;
      // 
      // dataGridEh1LastNameColumn
      // 
      this.dataGridEh1LastNameColumn.DataPropertyName = "LastName";
      this.dataGridEh1LastNameColumn.Name = "dataGridEh1LastNameColumn";
      // 
      // 
      // 
      this.dataGridEh1LastNameColumn.Title.Text = "LastName";
      this.dataGridEh1LastNameColumn.Title.ToolTipText = null;
      // 
      // dataGridEh1FirstNameColumn
      // 
      this.dataGridEh1FirstNameColumn.DataPropertyName = "FirstName";
      this.dataGridEh1FirstNameColumn.Name = "dataGridEh1FirstNameColumn";
      // 
      // 
      // 
      this.dataGridEh1FirstNameColumn.Title.Text = "FirstName";
      this.dataGridEh1FirstNameColumn.Title.ToolTipText = null;
      // 
      // dataGridEh1PostalCodeColumn
      // 
      this.dataGridEh1PostalCodeColumn.DataPropertyName = "PostalCode";
      this.dataGridEh1PostalCodeColumn.Name = "dataGridEh1PostalCodeColumn";
      // 
      // 
      // 
      this.dataGridEh1PostalCodeColumn.Title.Text = "PostalCode";
      this.dataGridEh1PostalCodeColumn.Title.ToolTipText = null;
      // 
      // dataGridEh1CountryColumn
      // 
      this.dataGridEh1CountryColumn.DataPropertyName = "Country";
      this.dataGridEh1CountryColumn.Name = "dataGridEh1CountryColumn";
      // 
      // 
      // 
      this.dataGridEh1CountryColumn.Title.Text = "Country";
      this.dataGridEh1CountryColumn.Title.ToolTipText = null;
      // 
      // dataGridEh1RegionColumn
      // 
      this.dataGridEh1RegionColumn.DataPropertyName = "Region";
      this.dataGridEh1RegionColumn.Name = "dataGridEh1RegionColumn";
      // 
      // 
      // 
      this.dataGridEh1RegionColumn.Title.Text = "Region";
      this.dataGridEh1RegionColumn.Title.ToolTipText = null;
      this.dataGridEh1RegionColumn.DataCellManagerNeeded += new System.EventHandler<EhLib.WinForms.DataGridDataCellManagerNeededEventArgs>(this.dataGridEh1RegionColumn_DataCellManagerNeeded);
      // 
      // dataGridEh1CityColumn
      // 
      this.dataGridEh1CityColumn.DataPropertyName = "City";
      this.dataGridEh1CityColumn.Name = "dataGridEh1CityColumn";
      // 
      // 
      // 
      this.dataGridEh1CityColumn.Title.Text = "City";
      this.dataGridEh1CityColumn.Title.ToolTipText = null;
      // 
      // dataGridEh1AddressColumn
      // 
      this.dataGridEh1AddressColumn.DataPropertyName = "Address";
      this.dataGridEh1AddressColumn.Name = "dataGridEh1AddressColumn";
      // 
      // 
      // 
      this.dataGridEh1AddressColumn.Title.Text = "Address";
      this.dataGridEh1AddressColumn.Title.ToolTipText = null;
      // 
      // employeesTableAdapter
      // 
      this.employeesTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.CategoriesTableAdapter = null;
      this.tableAdapterManager.CustomersTableAdapter = null;
      this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
      this.tableAdapterManager.Order_DetailsTableAdapter = null;
      this.tableAdapterManager.OrdersTableAdapter = null;
      this.tableAdapterManager.ProductsTableAdapter = null;
      this.tableAdapterManager.ShippersTableAdapter = null;
      this.tableAdapterManager.UpdateOrder = MainDemo.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(925, 36);
      this.panel1.TabIndex = 7;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(6, 5);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(243, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "Blank cells in the column";
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 36);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(925, 431);
      this.tabControl1.TabIndex = 8;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.dataGridEh1);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(917, 405);
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
      this.tabPage2.Size = new System.Drawing.Size(917, 405);
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
      this.textBox1.Size = new System.Drawing.Size(911, 399);
      this.textBox1.TabIndex = 0;
      this.textBox1.Text = resources.GetString("textBox1.Text");
      // 
      // FrameSolBlankCell
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.panel1);
      this.Name = "FrameSolBlankCell";
      this.Size = new System.Drawing.Size(925, 467);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridEh1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private EhLib.WinForms.DataGridEh dataGridEh1;
    private System.Windows.Forms.BindingSource employeesBindingSource;
    private NorthwindDataSet northwindDataSet;
    private NorthwindDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
    private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private EhLib.WinForms.DataGridTextColumn dataGridEh1EmployeeIDColumn;
    private EhLib.WinForms.DataGridTextColumn dataGridEh1LastNameColumn;
    private EhLib.WinForms.DataGridTextColumn dataGridEh1FirstNameColumn;
    private EhLib.WinForms.DataGridTextColumn dataGridEh1AddressColumn;
    private EhLib.WinForms.DataGridTextColumn dataGridEh1CityColumn;
    private EhLib.WinForms.DataGridTextColumn dataGridEh1RegionColumn;
    private EhLib.WinForms.DataGridTextColumn dataGridEh1PostalCodeColumn;
    private EhLib.WinForms.DataGridTextColumn dataGridEh1CountryColumn;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TextBox textBox1;
    private EhLib.WinForms.BlankDataCellManager blankCell;
  }
}
