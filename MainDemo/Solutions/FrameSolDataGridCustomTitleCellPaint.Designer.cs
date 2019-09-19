namespace MainDemo
{
  partial class FrameSolDataGridCustomTitleCellPaint
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrameSolDataGridCustomTitleCellPaint));
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.dataGrid1 = new EhLib.WinForms.DataGridEh();
      this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.northwindDataSet = new MainDemo.NorthwindDataSet();
      this.dataGridTextColumn1 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn2 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn3 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn4 = new EhLib.WinForms.DataGridTextColumn();
      this.colPostalCode = new EhLib.WinForms.DataGridTextColumn();
      this.colCountry = new EhLib.WinForms.DataGridTextColumn();
      this.colRegion = new EhLib.WinForms.DataGridTextColumn();
      this.colCity = new EhLib.WinForms.DataGridTextColumn();
      this.colAddress = new EhLib.WinForms.DataGridTextColumn();
      this.colAddressFull = new EhLib.WinForms.DataGridTextColumn();
      this.superTitleAddress = new EhLib.WinForms.DataGridSuperTitle();
      this.dataGridSuperTitle2 = new EhLib.WinForms.DataGridSuperTitle();
      this.dataGridSuperTitle1 = new EhLib.WinForms.DataGridSuperTitle();
      this.dataGridTextColumn10 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn9 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn8 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn7 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn6 = new EhLib.WinForms.DataGridTextColumn();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.customersTableAdapter = new MainDemo.NorthwindDataSetTableAdapters.CustomersTableAdapter();
      this.tableAdapterManager = new MainDemo.NorthwindDataSetTableAdapters.TableAdapterManager();
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
      this.tabPage1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBox1.Location = new System.Drawing.Point(3, 3);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(965, 412);
      this.textBox1.TabIndex = 0;
      this.textBox1.Text = resources.GetString("textBox1.Text");
      // 
      // dataGrid1
      // 
      this.dataGrid1.AllowedOperations.AddRecord = false;
      this.dataGrid1.AllowedOperations.ChangeRecord = false;
      this.dataGrid1.AllowedOperations.DeleteRecord = false;
      this.dataGrid1.DataMember = "";
      this.dataGrid1.DataSource = this.customersBindingSource;
      this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // 
      // 
      this.dataGrid1.HorzScrollBar.ExtraBar.Visible = true;
      this.dataGrid1.Location = new System.Drawing.Point(3, 3);
      this.dataGrid1.Name = "dataGrid1";
      this.dataGrid1.Size = new System.Drawing.Size(965, 412);
      this.dataGrid1.StaticColumns.AddRange(new EhLib.WinForms.PropertyAxisBar[] {
            this.dataGridTextColumn1,
            this.dataGridTextColumn2,
            this.dataGridTextColumn3,
            this.dataGridTextColumn4,
            this.colPostalCode,
            this.colCountry,
            this.colRegion,
            this.colCity,
            this.colAddress,
            this.colAddressFull});
      this.dataGrid1.TabIndex = 7;
      // 
      // 
      // 
      this.dataGrid1.Title.HeightOptions.AutoExpand = true;
      this.dataGrid1.Title.HorzAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // 
      // 
      this.dataGrid1.Title.MultiTitle.Active = true;
      this.dataGrid1.Title.MultiTitle.Subtitles.Add(this.dataGridTextColumn1);
      this.dataGrid1.Title.MultiTitle.Subtitles.Add(this.dataGridTextColumn2);
      this.dataGrid1.Title.MultiTitle.Subtitles.Add(this.dataGridTextColumn3);
      this.dataGrid1.Title.MultiTitle.Subtitles.Add(this.dataGridTextColumn4);
      this.dataGrid1.Title.MultiTitle.Subtitles.Add(this.superTitleAddress);
      this.dataGrid1.Title.MultiTitle.Subtitles.Add(this.colAddressFull);
      this.dataGrid1.Title.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.dataGrid1.Title.CellMouseDown += new System.EventHandler<EhLib.WinForms.DataGridTitleCellMouseEventArgs>(this.dataGrid1_Title_CellMouseDown);
      // 
      // customersBindingSource
      // 
      this.customersBindingSource.DataMember = "Customers";
      this.customersBindingSource.DataSource = this.northwindDataSet;
      // 
      // northwindDataSet
      // 
      this.northwindDataSet.DataSetName = "NorthwindDataSet";
      this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // dataGridTextColumn1
      // 
      this.dataGridTextColumn1.DataPropertyName = "CustomerID";
      this.dataGridTextColumn1.Name = "dataGridTextColumn1";
      // 
      // 
      // 
      this.dataGridTextColumn1.Title.Text = "Customer ID";
      // 
      // dataGridTextColumn2
      // 
      this.dataGridTextColumn2.DataPropertyName = "CompanyName";
      this.dataGridTextColumn2.Name = "dataGridTextColumn2";
      // 
      // 
      // 
      this.dataGridTextColumn2.Title.Text = "Company Name";
      // 
      // dataGridTextColumn3
      // 
      this.dataGridTextColumn3.DataPropertyName = "ContactName";
      this.dataGridTextColumn3.Name = "dataGridTextColumn3";
      // 
      // 
      // 
      this.dataGridTextColumn3.Title.Text = "Contact Name";
      this.dataGridTextColumn3.Width = 62;
      // 
      // dataGridTextColumn4
      // 
      this.dataGridTextColumn4.DataPropertyName = "ContactTitle";
      this.dataGridTextColumn4.Name = "dataGridTextColumn4";
      // 
      // 
      // 
      this.dataGridTextColumn4.Title.Text = "Contact Title";
      this.dataGridTextColumn4.Width = 44;
      // 
      // colPostalCode
      // 
      this.colPostalCode.DataPropertyName = "PostalCode";
      this.colPostalCode.Name = "colPostalCode";
      // 
      // 
      // 
      this.colPostalCode.Title.Text = "Postal Code";
      this.colPostalCode.Width = 73;
      // 
      // colCountry
      // 
      this.colCountry.DataPropertyName = "Country";
      this.colCountry.Name = "colCountry";
      // 
      // 
      // 
      this.colCountry.Title.Text = "Country";
      this.colCountry.Width = 70;
      // 
      // colRegion
      // 
      this.colRegion.DataPropertyName = "Region";
      this.colRegion.Name = "colRegion";
      // 
      // 
      // 
      this.colRegion.Title.Text = "Region";
      // 
      // colCity
      // 
      this.colCity.DataPropertyName = "City";
      this.colCity.Name = "colCity";
      // 
      // 
      // 
      this.colCity.Title.Text = "City";
      this.colCity.Width = 70;
      // 
      // colAddress
      // 
      this.colAddress.DataPropertyName = "Address";
      this.colAddress.Name = "colAddress";
      // 
      // 
      // 
      this.colAddress.Title.Text = "Address";
      this.colAddress.Width = 182;
      // 
      // colAddressFull
      // 
      this.colAddressFull.DataPropertyName = "AddressFull";
      this.colAddressFull.Name = "colAddressFull";
      this.colAddressFull.ReadOnly = true;
      // 
      // 
      // 
      // 
      // 
      // 
      this.colAddressFull.Title.ImageBox.HorzAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.colAddressFull.Title.ImageBox.Image = global::MainDemo.Properties.Resources.home_house_16x16;
      this.colAddressFull.Title.ImageBox.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
      this.colAddressFull.Title.Text = "Address";
      this.colAddressFull.Title.CellCustomAreaPaint += new System.EventHandler<EhLib.WinForms.DataGridTitleCellPaintEventArgs>(this.colAddressFull_Title_CellCustomAreaPaint);
      this.colAddressFull.Title.CellQueryCursor += new System.EventHandler<EhLib.WinForms.BaseGridCellQueryCursorEventArgs>(this.colAddressFull_Title_CellQueryCursor);
      this.colAddressFull.Title.CellClientRectNeeded += new System.EventHandler<EhLib.WinForms.DataGridTitleCellClientAreaNeededEventArgs>(this.colAddressFull_Title_CellClientRectNeeded);
      this.colAddressFull.Title.CellMouseDown += new System.EventHandler<EhLib.WinForms.DataGridTitleCellMouseEventArgs>(this.colAddressFull_Title_CellMouseDown);
      this.colAddressFull.Title.CellMouseMove += new System.EventHandler<EhLib.WinForms.DataGridTitleCellMouseEventArgs>(this.colAddressFull_Title_MouseMove);
      this.colAddressFull.Title.CellMouseLeave += new System.EventHandler<EhLib.WinForms.DataGridTitleCellEventArgs>(this.colAddressFull_Title_MouseLeave);
      this.colAddressFull.Visible = false;
      this.colAddressFull.Width = 320;
      // 
      // superTitleAddress
      // 
      // 
      // 
      // 
      this.superTitleAddress.ImageBox.HorzAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.superTitleAddress.ImageBox.Image = global::MainDemo.Properties.Resources.home_house_16x16;
      this.superTitleAddress.ImageBox.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
      this.superTitleAddress.Name = "superTitleAddress";
      this.superTitleAddress.Subtitles.Add(this.colPostalCode);
      this.superTitleAddress.Subtitles.Add(this.colCountry);
      this.superTitleAddress.Subtitles.Add(this.colRegion);
      this.superTitleAddress.Subtitles.Add(this.colCity);
      this.superTitleAddress.Subtitles.Add(this.colAddress);
      this.superTitleAddress.Text = "Address";
      this.superTitleAddress.CustomAreaPaint += new System.EventHandler<EhLib.WinForms.SuperTitlePaintEventArgs>(this.superTitleAddress_CustomAreaPaint);
      this.superTitleAddress.MouseDown += new System.EventHandler<EhLib.WinForms.DataGridSuperTitleCellMouseEventArgs>(this.superTitleAddress_MouseDown);
      this.superTitleAddress.MouseMove += new System.EventHandler<EhLib.WinForms.DataGridSuperTitleCellMouseEventArgs>(this.superTitleAddress_MouseMove);
      this.superTitleAddress.MouseLeave += new System.EventHandler<EhLib.WinForms.DataGridSuperTitleCellEventArgs>(this.superTitleAddress_MouseLeave);
      this.superTitleAddress.ClientRectNeeded += new System.EventHandler<EhLib.WinForms.DataGridSuperTitleCellClientAreaNeededEventArgs>(this.superTitleAddress_ClientRectNeeded);
      // 
      // dataGridSuperTitle2
      // 
      this.dataGridSuperTitle2.Name = "dataGridSuperTitle2";
      this.dataGridSuperTitle2.Text = "Address";
      // 
      // dataGridSuperTitle1
      // 
      this.dataGridSuperTitle1.HorzAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.dataGridSuperTitle1.Name = "dataGridSuperTitle1";
      this.dataGridSuperTitle1.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
      this.dataGridSuperTitle1.Text = "Address";
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
      // dataGridTextColumn9
      // 
      this.dataGridTextColumn9.DataPropertyName = "Area";
      this.dataGridTextColumn9.Name = "dataGridTextColumn9";
      // 
      // 
      // 
      this.dataGridTextColumn9.Title.Text = "Area";
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
      // tabPage1
      // 
      this.tabPage1.AutoScroll = true;
      this.tabPage1.Controls.Add(this.dataGrid1);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(971, 418);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Demo";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 36);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(979, 444);
      this.tabControl1.TabIndex = 9;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.textBox1);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(971, 418);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Description";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(6, 5);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(493, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "DataGridEh Title Cell Custom Paint and Mouse Click";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(979, 36);
      this.panel1.TabIndex = 8;
      // 
      // customersTableAdapter
      // 
      this.customersTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.CategoriesTableAdapter = null;
      this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
      this.tableAdapterManager.EmployeesTableAdapter = null;
      this.tableAdapterManager.Order_DetailsTableAdapter = null;
      this.tableAdapterManager.OrdersTableAdapter = null;
      this.tableAdapterManager.ProductsTableAdapter = null;
      this.tableAdapterManager.ShippersTableAdapter = null;
      this.tableAdapterManager.UpdateOrder = MainDemo.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // FrameSolDataGridCustomTitleCellPaint
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.panel1);
      this.Name = "FrameSolDataGridCustomTitleCellPaint";
      this.Size = new System.Drawing.Size(979, 480);
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
      this.tabPage1.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private EhLib.WinForms.DataGridEh dataGrid1;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn10;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn9;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn8;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn7;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn6;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.BindingSource customersBindingSource;
    private NorthwindDataSet northwindDataSet;
    private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
    private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn1;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn2;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn3;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn4;
    private EhLib.WinForms.DataGridTextColumn colPostalCode;
    private EhLib.WinForms.DataGridTextColumn colCountry;
    private EhLib.WinForms.DataGridTextColumn colRegion;
    private EhLib.WinForms.DataGridTextColumn colCity;
    private EhLib.WinForms.DataGridTextColumn colAddress;
    private EhLib.WinForms.DataGridSuperTitle dataGridSuperTitle1;
    private EhLib.WinForms.DataGridTextColumn colAddressFull;
    private EhLib.WinForms.DataGridSuperTitle dataGridSuperTitle2;
    private EhLib.WinForms.DataGridSuperTitle superTitleAddress;
  }
}
