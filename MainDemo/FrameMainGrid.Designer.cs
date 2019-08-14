namespace MainDemo
{
  partial class FrameMainGrid
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
      EhLib.WinForms.SumCalculator sumCalculator1 = new EhLib.WinForms.SumCalculator();
      this.dataGridFooterRow1 = new EhLib.WinForms.DataGridFooterRow();
      this.panel1 = new System.Windows.Forms.Panel();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.colOrdedId = new EhLib.WinForms.DataGridTextColumn();
      this.colEmpId = new EhLib.WinForms.DataGridTextColumn();
      this.colComboBoxEmpName = new EhLib.WinForms.DataGridComboBoxColumn();
      this.bsEmployees = new System.Windows.Forms.BindingSource(this.components);
      this.northwindDataSet = new MainDemo.NorthwindDataSet();
      this.colCustId = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridComboBoxColumn1 = new EhLib.WinForms.DataGridComboBoxColumn();
      this.bsCustomer = new System.Windows.Forms.BindingSource(this.components);
      this.colShipFee = new EhLib.WinForms.DataGridTextColumn();
      this.colOrdDate = new EhLib.WinForms.DataGridDateTimeColumn();
      this.colShipDate = new EhLib.WinForms.DataGridDateTimeColumn();
      this.colShipperId = new EhLib.WinForms.DataGridTextColumn();
      this.colShipName = new EhLib.WinForms.DataGridTextColumn();
      this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGrid1 = new EhLib.WinForms.DataGridEh();
      this.superTitleEmployee = new EhLib.WinForms.DataGridSuperTitle();
      this.dataGridSuperTitle1 = new EhLib.WinForms.DataGridSuperTitle();
      this.dataGridSuperTitle2 = new EhLib.WinForms.DataGridSuperTitle();
      this.bsMain = new System.Windows.Forms.BindingSource(this.components);
      this.ordersTableAdapter = new MainDemo.NorthwindDataSetTableAdapters.OrdersTableAdapter();
      this.employeesTableAdapter = new MainDemo.NorthwindDataSetTableAdapters.EmployeesTableAdapter();
      this.customersTableAdapter1 = new MainDemo.NorthwindDataSetTableAdapters.CustomersTableAdapter();
      this.dataGridColumnFooterItem6 = new EhLib.WinForms.DataGridColumnFooterItem();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridFooterRow1
      // 
      this.dataGridFooterRow1.BoundItems.Add(this.dataGridColumnFooterItem6);
      // 
      // dataGridColumnFooterItem6
      // 
      this.dataGridColumnFooterItem6.CalcValueFunction = sumCalculator1;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.pictureBox1);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(941, 36);
      this.panel1.TabIndex = 0;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(197, 0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(100, 50);
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(32, 6);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "Main Grid";
      // 
      // colOrdedId
      // 
      this.colOrdedId.DataPropertyName = "OrderID";
      this.colOrdedId.FillWeight = 57F;
      this.colOrdedId.Name = "colOrdedId";
      // 
      // colOrdedId.Title
      // 
      this.colOrdedId.Title.Text = "Order ID";
      this.colOrdedId.Width = 52;
      // 
      // colEmpId
      // 
      this.colEmpId.DataPropertyName = "EmployeeID";
      this.colEmpId.FillWeight = 55F;
      this.colEmpId.Name = "colEmpId";
      // 
      // colEmpId.Title
      // 
      this.colEmpId.Title.Text = "ID";
      this.colEmpId.Width = 50;
      // 
      // colComboBoxEmpName
      // 
      this.colComboBoxEmpName.DataPropertyName = "EmployeeID";
      this.colComboBoxEmpName.DataSource = this.bsEmployees;
      this.colComboBoxEmpName.DisplayMember = "Name";
      this.colComboBoxEmpName.FillWeight = 103F;
      this.colComboBoxEmpName.Name = "colComboBoxEmpName";
      // 
      // colComboBoxEmpName.Title
      // 
      this.colComboBoxEmpName.Title.Text = "Name";
      this.colComboBoxEmpName.ValueMember = "EmployeeID";
      this.colComboBoxEmpName.Width = 94;
      // 
      // bsEmployees
      // 
      this.bsEmployees.DataMember = "Employees";
      this.bsEmployees.DataSource = this.northwindDataSet;
      this.bsEmployees.Sort = "Name";
      // 
      // northwindDataSet
      // 
      this.northwindDataSet.DataSetName = "NorthwindDataSet";
      this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // colCustId
      // 
      this.colCustId.DataPropertyName = "CustomerID";
      this.colCustId.FillWeight = 55F;
      this.colCustId.Name = "colCustId";
      // 
      // colCustId.Title
      // 
      this.colCustId.Title.Text = "ID";
      this.colCustId.Width = 50;
      // 
      // dataGridComboBoxColumn1
      // 
      this.dataGridComboBoxColumn1.DataPropertyName = "CustomerID";
      this.dataGridComboBoxColumn1.DataSource = this.bsCustomer;
      this.dataGridComboBoxColumn1.DisplayMember = "CompanyName";
      // 
      // dataGridComboBoxColumn1.EditButton
      // 
      this.dataGridComboBoxColumn1.EditButton.StyleKind = EhLib.WinForms.InEditButtonStyleKind.AltDropDown;
      this.dataGridComboBoxColumn1.FillWeight = 81F;
      this.dataGridComboBoxColumn1.Name = "dataGridComboBoxColumn1";
      // 
      // dataGridComboBoxColumn1.Title
      // 
      this.dataGridComboBoxColumn1.Title.Text = "Name";
      this.dataGridComboBoxColumn1.ValueMember = "CustomerID";
      this.dataGridComboBoxColumn1.Width = 117;
      // 
      // bsCustomer
      // 
      this.bsCustomer.DataMember = "Customers";
      this.bsCustomer.DataSource = this.northwindDataSet;
      // 
      // colShipFee
      // 
      this.colShipFee.DataPropertyName = "Freight";
      this.colShipFee.FillWeight = 108F;
      // 
      // 
      // 
      this.colShipFee.Footer.BoundItems.Add(this.dataGridColumnFooterItem6);
      this.colShipFee.Name = "colShipFee";
      // 
      // colShipFee.Title
      // 
      this.colShipFee.Title.Text = "Freight";
      this.colShipFee.Width = 99;
      // 
      // colOrdDate
      // 
      this.colOrdDate.DataPropertyName = "RequiredDate";
      this.colOrdDate.FillWeight = 60F;
      this.colOrdDate.Name = "colOrdDate";
      // 
      // colOrdDate.Title
      // 
      this.colOrdDate.Title.Text = "Required";
      this.colOrdDate.Width = 124;
      // 
      // colShipDate
      // 
      this.colShipDate.DataPropertyName = "ShippedDate";
      this.colShipDate.FillWeight = 56F;
      this.colShipDate.Name = "colShipDate";
      // 
      // colShipDate.Title
      // 
      this.colShipDate.Title.Text = "Shipped";
      this.colShipDate.Width = 114;
      // 
      // colShipperId
      // 
      this.colShipperId.DataPropertyName = "ShipVia";
      this.colShipperId.FillWeight = 56F;
      this.colShipperId.Name = "colShipperId";
      // 
      // colShipperId.Title
      // 
      this.colShipperId.Title.Text = "Shipper ID";
      this.colShipperId.Width = 51;
      // 
      // colShipName
      // 
      this.colShipName.DataPropertyName = "ShipName";
      this.colShipName.FillWeight = 56F;
      this.colShipName.Name = "colShipName";
      // 
      // colShipName.Title
      // 
      this.colShipName.Title.Text = "Ship Name";
      this.colShipName.Width = 150;
      // 
      // orderIDDataGridViewTextBoxColumn
      // 
      this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "Order ID";
      this.orderIDDataGridViewTextBoxColumn.HeaderText = "Order ID";
      this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
      // 
      // dataGrid1
      // 
      this.dataGrid1.DataMember = "Orders";
      this.dataGrid1.DataSource = this.northwindDataSet;
      this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // dataGrid1.Footer
      // 
      this.dataGrid1.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataGrid1.Footer.Rows.AddRange(new EhLib.WinForms.DataGridFooterRow[] {
            this.dataGridFooterRow1});
      // 
      // dataGrid1.HorzScrollBar
      // 
      this.dataGrid1.HorzScrollBar.ExtraBar.Visible = true;
      this.dataGrid1.HorzScrollBar.Height = 24;
      this.dataGrid1.Location = new System.Drawing.Point(0, 36);
      this.dataGrid1.Name = "dataGrid1";
      this.dataGrid1.Size = new System.Drawing.Size(941, 302);
      this.dataGrid1.StaticColumns.AddRange(new EhLib.WinForms.PropertyAxisBar[] {
            this.colOrdedId,
            this.colEmpId,
            this.colComboBoxEmpName,
            this.colCustId,
            this.dataGridComboBoxColumn1,
            this.colShipFee,
            this.colOrdDate,
            this.colShipDate,
            this.colShipperId,
            this.colShipName});
      this.dataGrid1.TabIndex = 1;
      this.dataGrid1.Text = "dataGrid1";
      // 
      // dataGrid1.Title
      // 
      this.dataGrid1.Title.Filter.Active = true;
      this.dataGrid1.Title.HeightOptions.AutoExpand = true;
      this.dataGrid1.Title.HorzAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // 
      // 
      this.dataGrid1.Title.MultiTitle.Active = true;
      this.dataGrid1.Title.MultiTitle.Subtitles.Add(this.colOrdedId);
      this.dataGrid1.Title.MultiTitle.Subtitles.Add(this.superTitleEmployee);
      this.dataGrid1.Title.MultiTitle.Subtitles.Add(this.dataGridSuperTitle1);
      this.dataGrid1.Title.MultiTitle.Subtitles.Add(this.colShipFee);
      this.dataGrid1.Title.MultiTitle.Subtitles.Add(this.dataGridSuperTitle2);
      this.dataGrid1.Title.MultiTitle.Subtitles.Add(this.colShipperId);
      this.dataGrid1.Title.MultiTitle.Subtitles.Add(this.colShipName);
      this.dataGrid1.Title.SortMarking.MultiSortMarkable = true;
      this.dataGrid1.Title.SortMarking.SortMarkable = true;
      this.dataGrid1.Click += new System.EventHandler(this.dataGrid1_Click);
      // 
      // superTitleEmployee
      // 
      // 
      // 
      // 
      this.superTitleEmployee.ImageBox.HorzAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.superTitleEmployee.ImageBox.Image = global::MainDemo.Properties.Resources.man_with_tai;
      this.superTitleEmployee.ImageBox.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.superTitleEmployee.Name = "superTitleEmployee";
      this.superTitleEmployee.Subtitles.Add(this.colEmpId);
      this.superTitleEmployee.Subtitles.Add(this.colComboBoxEmpName);
      this.superTitleEmployee.Text = "Employee";
      // 
      // dataGridSuperTitle1
      // 
      // 
      // 
      // 
      this.dataGridSuperTitle1.ImageBox.HorzAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.dataGridSuperTitle1.ImageBox.Image = global::MainDemo.Properties.Resources.icons_user_16x16;
      this.dataGridSuperTitle1.ImageBox.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.dataGridSuperTitle1.Name = "dataGridSuperTitle1";
      this.dataGridSuperTitle1.Subtitles.Add(this.colCustId);
      this.dataGridSuperTitle1.Subtitles.Add(this.dataGridComboBoxColumn1);
      this.dataGridSuperTitle1.Text = "Customer";
      // 
      // dataGridSuperTitle2
      // 
      // 
      // 
      // 
      this.dataGridSuperTitle2.ImageBox.HorzAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.dataGridSuperTitle2.ImageBox.Image = global::MainDemo.Properties.Resources.Calendar_16x16;
      this.dataGridSuperTitle2.ImageBox.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.dataGridSuperTitle2.Name = "dataGridSuperTitle2";
      this.dataGridSuperTitle2.Subtitles.Add(this.colOrdDate);
      this.dataGridSuperTitle2.Subtitles.Add(this.colShipDate);
      this.dataGridSuperTitle2.Text = "Dates";
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
      // customersTableAdapter1
      // 
      this.customersTableAdapter1.ClearBeforeFill = true;
      // 
      // FrameMainGrid
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.dataGrid1);
      this.Controls.Add(this.panel1);
      this.Name = "FrameMainGrid";
      this.Size = new System.Drawing.Size(941, 338);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private EhLib.WinForms.DataGridEh dataGrid1;
    private System.Windows.Forms.BindingSource bsMain;
    private NorthwindDataSet northwindDataSet;
    private NorthwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
    private EhLib.WinForms.DataGridTextColumn colOrdedId;
    private EhLib.WinForms.DataGridTextColumn colEmpId;
    private EhLib.WinForms.DataGridTextColumn colCustId;
    private EhLib.WinForms.DataGridDateTimeColumn colOrdDate;
    private EhLib.WinForms.DataGridDateTimeColumn colShipDate;
    private EhLib.WinForms.DataGridTextColumn colShipperId;
    private EhLib.WinForms.DataGridTextColumn colShipName;
    private EhLib.WinForms.DataGridTextColumn colShipFee;
    private EhLib.WinForms.DataGridComboBoxColumn colComboBoxEmpName;
    private System.Windows.Forms.BindingSource bsEmployees;
    private NorthwindDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
    private EhLib.WinForms.DataGridComboBoxColumn dataGridComboBoxColumn1;
    private System.Windows.Forms.BindingSource bsCustomer;
    private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
    private EhLib.WinForms.DataGridSuperTitle superTitleEmployee;
    private EhLib.WinForms.DataGridSuperTitle dataGridSuperTitle1;
    private EhLib.WinForms.DataGridSuperTitle dataGridSuperTitle2;
    private System.Windows.Forms.PictureBox pictureBox1;
    private EhLib.WinForms.DataGridFooterRow dataGridFooterRow1;
    private EhLib.WinForms.DataGridColumnFooterItem dataGridColumnFooterItem6;
  }
}
