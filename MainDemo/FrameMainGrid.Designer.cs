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
      components = new System.ComponentModel.Container();
      EhLib.WinForms.SumCalculator sumCalculator1 = new EhLib.WinForms.SumCalculator();
      dataGridFooterRow1 = new EhLib.WinForms.DataGridFooterRow();
      dataGridColumnFooterItem6 = new EhLib.WinForms.DataGridColumnFooterItem();
      panel1 = new Panel();
      pictureBox1 = new PictureBox();
      label1 = new Label();
      colOrdedId = new EhLib.WinForms.DataGridTextColumn();
      colEmpId = new EhLib.WinForms.DataGridTextColumn();
      colComboBoxEmpName = new EhLib.WinForms.DataGridComboBoxColumn();
      bsEmployees = new BindingSource(components);
      northwindDataSet = new NorthwindDataSet();
      colCustId = new EhLib.WinForms.DataGridTextColumn();
      dataGridComboBoxColumn1 = new EhLib.WinForms.DataGridComboBoxColumn();
      bsCustomer = new BindingSource(components);
      colShipFee = new EhLib.WinForms.DataGridTextColumn();
      colOrdDate = new EhLib.WinForms.DataGridDateTimeColumn();
      colShipDate = new EhLib.WinForms.DataGridDateTimeColumn();
      colShipperId = new EhLib.WinForms.DataGridTextColumn();
      colShipName = new EhLib.WinForms.DataGridTextColumn();
      orderIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
      dataGrid1 = new EhLib.WinForms.DataGridEh();
      superTitleEmployee = new EhLib.WinForms.DataGridSuperTitle();
      dataGridSuperTitle1 = new EhLib.WinForms.DataGridSuperTitle();
      dataGridSuperTitle2 = new EhLib.WinForms.DataGridSuperTitle();
      bsMain = new BindingSource(components);
      panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
      ((System.ComponentModel.ISupportInitialize)bsEmployees).BeginInit();
      ((System.ComponentModel.ISupportInitialize)northwindDataSet).BeginInit();
      ((System.ComponentModel.ISupportInitialize)bsCustomer).BeginInit();
      ((System.ComponentModel.ISupportInitialize)dataGrid1).BeginInit();
      ((System.ComponentModel.ISupportInitialize)bsMain).BeginInit();
      SuspendLayout();
      // 
      // dataGridFooterRow1
      // 
      dataGridFooterRow1.BoundItems.Add(dataGridColumnFooterItem6);
      // 
      // dataGridColumnFooterItem6
      // 
      dataGridColumnFooterItem6.CalcValueFunction = sumCalculator1;
      // 
      // panel1
      // 
      panel1.Controls.Add(pictureBox1);
      panel1.Controls.Add(label1);
      panel1.Dock = DockStyle.Top;
      panel1.Location = new Point(0, 0);
      panel1.Margin = new Padding(4, 3, 4, 3);
      panel1.Name = "panel1";
      panel1.Size = new Size(700, 42);
      panel1.TabIndex = 0;
      // 
      // pictureBox1
      // 
      pictureBox1.Location = new Point(230, 0);
      pictureBox1.Margin = new Padding(4, 3, 4, 3);
      pictureBox1.Name = "pictureBox1";
      pictureBox1.Size = new Size(117, 58);
      pictureBox1.TabIndex = 1;
      pictureBox1.TabStop = false;
      pictureBox1.Paint += pictureBox1_Paint;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
      label1.Location = new Point(37, 7);
      label1.Margin = new Padding(4, 0, 4, 0);
      label1.Name = "label1";
      label1.Size = new Size(100, 24);
      label1.TabIndex = 0;
      label1.Text = "Main Grid";
      // 
      // colOrdedId
      // 
      colOrdedId.DataPropertyName = "OrderID";
      colOrdedId.FillWeight = 57F;
      colOrdedId.Name = "colOrdedId";
      // 
      // colOrdedId.Title
      // 
      colOrdedId.Title.Text = "Order ID";
      colOrdedId.Width = 58;
      // 
      // colEmpId
      // 
      colEmpId.DataPropertyName = "EmployeeID";
      colEmpId.FillWeight = 55F;
      colEmpId.Name = "colEmpId";
      // 
      // colEmpId.Title
      // 
      colEmpId.Title.Text = "ID";
      colEmpId.Width = 50;
      // 
      // colComboBoxEmpName
      // 
      colComboBoxEmpName.DataPropertyName = "EmployeeID";
      colComboBoxEmpName.DataSource = bsEmployees;
      colComboBoxEmpName.DisplayMember = "Name";
      // 
      // colComboBoxEmpName.EditButton
      // 
      colComboBoxEmpName.EditButton.StyleKind = EhLib.WinForms.InEditButtonStyleKind.AltDropDown;
      colComboBoxEmpName.FillWeight = 103F;
      colComboBoxEmpName.Name = "colComboBoxEmpName";
      // 
      // colComboBoxEmpName.Title
      // 
      colComboBoxEmpName.Title.Text = "Name";
      colComboBoxEmpName.ValueMember = "EmployeeID";
      colComboBoxEmpName.Width = 94;
      // 
      // bsEmployees
      // 
      bsEmployees.DataMember = "Employees";
      bsEmployees.DataSource = northwindDataSet;
      bsEmployees.Sort = "Name";
      // 
      // northwindDataSet
      // 
      northwindDataSet.DataSetName = "NorthwindDataSet";
      northwindDataSet.Namespace = "http://tempuri.org/NorthwindDataSet.xsd";
      northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // colCustId
      // 
      colCustId.DataPropertyName = "CustomerID";
      colCustId.FillWeight = 55F;
      colCustId.Name = "colCustId";
      // 
      // colCustId.Title
      // 
      colCustId.Title.Text = "ID";
      colCustId.Width = 50;
      // 
      // dataGridComboBoxColumn1
      // 
      dataGridComboBoxColumn1.DataPropertyName = "CustomerID";
      dataGridComboBoxColumn1.DataSource = bsCustomer;
      dataGridComboBoxColumn1.DisplayMember = "CompanyName";
      // 
      // dataGridComboBoxColumn1.EditButton
      // 
      dataGridComboBoxColumn1.EditButton.StyleKind = EhLib.WinForms.InEditButtonStyleKind.AltDropDown;
      dataGridComboBoxColumn1.FillWeight = 81F;
      dataGridComboBoxColumn1.Name = "dataGridComboBoxColumn1";
      // 
      // dataGridComboBoxColumn1.Title
      // 
      dataGridComboBoxColumn1.Title.Text = "Name";
      dataGridComboBoxColumn1.ValueMember = "CustomerID";
      dataGridComboBoxColumn1.Width = 117;
      // 
      // bsCustomer
      // 
      bsCustomer.DataMember = "Customers";
      bsCustomer.DataSource = northwindDataSet;
      // 
      // colShipFee
      // 
      colShipFee.DataPropertyName = "Freight";
      colShipFee.FillWeight = 108F;
      // 
      // 
      // 
      colShipFee.Footer.BoundItems.Add(dataGridColumnFooterItem6);
      colShipFee.Name = "colShipFee";
      // 
      // colShipFee.Title
      // 
      colShipFee.Title.Text = "Freight";
      colShipFee.Width = 99;
      // 
      // colOrdDate
      // 
      colOrdDate.DataPropertyName = "RequiredDate";
      colOrdDate.FillWeight = 60F;
      colOrdDate.Name = "colOrdDate";
      // 
      // colOrdDate.Title
      // 
      colOrdDate.Title.Text = "Required";
      colOrdDate.Width = 124;
      // 
      // colShipDate
      // 
      colShipDate.DataPropertyName = "ShippedDate";
      colShipDate.FillWeight = 56F;
      colShipDate.Name = "colShipDate";
      // 
      // colShipDate.Title
      // 
      colShipDate.Title.Text = "Shipped";
      colShipDate.Width = 114;
      // 
      // colShipperId
      // 
      colShipperId.DataPropertyName = "ShipVia";
      colShipperId.FillWeight = 56F;
      colShipperId.Name = "colShipperId";
      // 
      // colShipperId.Title
      // 
      colShipperId.Title.Text = "Shipper ID";
      colShipperId.Width = 51;
      // 
      // colShipName
      // 
      colShipName.DataPropertyName = "ShipName";
      colShipName.FillWeight = 56F;
      colShipName.Name = "colShipName";
      // 
      // colShipName.Title
      // 
      colShipName.Title.Text = "Ship Name";
      colShipName.Width = 150;
      // 
      // orderIDDataGridViewTextBoxColumn
      // 
      orderIDDataGridViewTextBoxColumn.DataPropertyName = "Order ID";
      orderIDDataGridViewTextBoxColumn.HeaderText = "Order ID";
      orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
      // 
      // dataGrid1
      // 
      dataGrid1.DataMember = "Orders";
      dataGrid1.DataSource = northwindDataSet;
      dataGrid1.Dock = DockStyle.Fill;
      // 
      // dataGrid1.Footer
      // 
      dataGrid1.Footer.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
      dataGrid1.Footer.Rows.AddRange(new EhLib.WinForms.DataGridFooterRow[] { dataGridFooterRow1 });
      // 
      // dataGrid1.HorzScrollBar
      // 
      dataGrid1.HorzScrollBar.ExtraBar.Visible = true;
      dataGrid1.HorzScrollBar.Height = 24;
      dataGrid1.Location = new Point(0, 42);
      dataGrid1.Margin = new Padding(4, 3, 4, 3);
      dataGrid1.Name = "dataGrid1";
      dataGrid1.Size = new Size(700, 544);
      dataGrid1.StaticColumns.AddRange(new EhLib.WinForms.PropertyAxisBar[] { colOrdedId, colEmpId, colComboBoxEmpName, colCustId, dataGridComboBoxColumn1, colShipFee, colOrdDate, colShipDate, colShipperId, colShipName });
      dataGrid1.TabIndex = 1;
      dataGrid1.Text = "dataGrid1";
      // 
      // dataGrid1.Title
      // 
      dataGrid1.Title.Filter.Active = true;
      dataGrid1.Title.HeightOptions.AutoExpand = true;
      dataGrid1.Title.HorzAlign = HorizontalAlignment.Center;
      // 
      // 
      // 
      dataGrid1.Title.MultiTitle.Active = true;
      dataGrid1.Title.MultiTitle.Subtitles.Add(colOrdedId);
      dataGrid1.Title.MultiTitle.Subtitles.Add(superTitleEmployee);
      dataGrid1.Title.MultiTitle.Subtitles.Add(dataGridSuperTitle1);
      dataGrid1.Title.MultiTitle.Subtitles.Add(colShipFee);
      dataGrid1.Title.MultiTitle.Subtitles.Add(dataGridSuperTitle2);
      dataGrid1.Title.MultiTitle.Subtitles.Add(colShipperId);
      dataGrid1.Title.MultiTitle.Subtitles.Add(colShipName);
      dataGrid1.Title.SortMarking.MultiSortMarkable = true;
      dataGrid1.Title.SortMarking.SortMarkable = true;
      dataGrid1.Click += dataGrid1_Click;
      // 
      // superTitleEmployee
      // 
      // 
      // 
      // 
      superTitleEmployee.ImageBox.HorzAlign = HorizontalAlignment.Center;
      superTitleEmployee.ImageBox.Image = Properties.Resources.man_with_tai;
      superTitleEmployee.ImageBox.Padding = new Padding(4, 0, 4, 0);
      superTitleEmployee.Name = "superTitleEmployee";
      superTitleEmployee.Subtitles.Add(colEmpId);
      superTitleEmployee.Subtitles.Add(colComboBoxEmpName);
      superTitleEmployee.Text = "Employee";
      // 
      // dataGridSuperTitle1
      // 
      // 
      // 
      // 
      dataGridSuperTitle1.ImageBox.HorzAlign = HorizontalAlignment.Center;
      dataGridSuperTitle1.ImageBox.Image = Properties.Resources.icons_user_16x16;
      dataGridSuperTitle1.ImageBox.Padding = new Padding(4, 0, 4, 0);
      dataGridSuperTitle1.Name = "dataGridSuperTitle1";
      dataGridSuperTitle1.Subtitles.Add(colCustId);
      dataGridSuperTitle1.Subtitles.Add(dataGridComboBoxColumn1);
      dataGridSuperTitle1.Text = "Customer";
      // 
      // dataGridSuperTitle2
      // 
      // 
      // 
      // 
      dataGridSuperTitle2.ImageBox.HorzAlign = HorizontalAlignment.Center;
      dataGridSuperTitle2.ImageBox.Image = Properties.Resources.Calendar_16x16;
      dataGridSuperTitle2.ImageBox.Padding = new Padding(4, 0, 4, 0);
      dataGridSuperTitle2.Name = "dataGridSuperTitle2";
      dataGridSuperTitle2.Subtitles.Add(colOrdDate);
      dataGridSuperTitle2.Subtitles.Add(colShipDate);
      dataGridSuperTitle2.Text = "Dates";
      // 
      // bsMain
      // 
      bsMain.DataMember = "Orders";
      bsMain.DataSource = northwindDataSet;
      // 
      // FrameMainGrid
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(dataGrid1);
      Controls.Add(panel1);
      Margin = new Padding(4, 3, 4, 3);
      Name = "FrameMainGrid";
      Size = new Size(700, 586);
      panel1.ResumeLayout(false);
      panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
      ((System.ComponentModel.ISupportInitialize)bsEmployees).EndInit();
      ((System.ComponentModel.ISupportInitialize)northwindDataSet).EndInit();
      ((System.ComponentModel.ISupportInitialize)bsCustomer).EndInit();
      ((System.ComponentModel.ISupportInitialize)dataGrid1).EndInit();
      ((System.ComponentModel.ISupportInitialize)bsMain).EndInit();
      ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private EhLib.WinForms.DataGridEh dataGrid1;
    private System.Windows.Forms.BindingSource bsMain;
    private NorthwindDataSet northwindDataSet;
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
    private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
    private EhLib.WinForms.DataGridComboBoxColumn dataGridComboBoxColumn1;
    private System.Windows.Forms.BindingSource bsCustomer;
    private EhLib.WinForms.DataGridSuperTitle superTitleEmployee;
    private EhLib.WinForms.DataGridSuperTitle dataGridSuperTitle1;
    private EhLib.WinForms.DataGridSuperTitle dataGridSuperTitle2;
    private System.Windows.Forms.PictureBox pictureBox1;
    private EhLib.WinForms.DataGridFooterRow dataGridFooterRow1;
    private EhLib.WinForms.DataGridColumnFooterItem dataGridColumnFooterItem6;
  }
}
