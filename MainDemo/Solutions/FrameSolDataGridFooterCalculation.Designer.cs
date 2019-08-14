namespace MainDemo
{
  partial class FrameSolDataGridFooterCalculation
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
      EhLib.WinForms.CountCalculator countCalculator1 = new EhLib.WinForms.CountCalculator();
      EhLib.WinForms.SumCalculator sumCalculator1 = new EhLib.WinForms.SumCalculator();
      EhLib.WinForms.SumCalculator sumCalculator2 = new EhLib.WinForms.SumCalculator();
      EhLib.WinForms.CountCalculator countCalculator2 = new EhLib.WinForms.CountCalculator();
      this.dataGridFooterRow7 = new EhLib.WinForms.DataGridFooterRow();
      this.dataGridColumnFooterItem1 = new EhLib.WinForms.DataGridColumnFooterItem();
      this.dataGridColumnFooterItem3 = new EhLib.WinForms.DataGridColumnFooterItem();
      this.dataGridColumnFooterItem5 = new EhLib.WinForms.DataGridColumnFooterItem();
      this.dataGridColumnFooterItem7 = new EhLib.WinForms.DataGridColumnFooterItem();
      this.dataGridColumnFooterItem9 = new EhLib.WinForms.DataGridColumnFooterItem();
      this.dataGridFooterRow8 = new EhLib.WinForms.DataGridFooterRow();
      this.dataGridColumnFooterItem2 = new EhLib.WinForms.DataGridColumnFooterItem();
      this.dataGridColumnFooterItem4 = new EhLib.WinForms.DataGridColumnFooterItem();
      this.dataGridColumnFooterItem6 = new EhLib.WinForms.DataGridColumnFooterItem();
      this.dataGridColumnFooterItem8 = new EhLib.WinForms.DataGridColumnFooterItem();
      this.dataGridColumnFooterItem10 = new EhLib.WinForms.DataGridColumnFooterItem();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.dataGridEh1 = new EhLib.WinForms.DataGridEh();
      this.order_DetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.northwindDataSet = new MainDemo.NorthwindDataSet();
      this.dataGridTextColumn1 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn2 = new EhLib.WinForms.DataGridTextColumn();
      this.columnUnitPrice = new EhLib.WinForms.DataGridTextColumn();
      this.columnQuantity = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn5 = new EhLib.WinForms.DataGridTextColumn();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.order_DetailsTableAdapter = new MainDemo.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter();
      this.tableAdapterManager = new MainDemo.NorthwindDataSetTableAdapters.TableAdapterManager();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridEh1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.order_DetailsBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
      this.tabControl1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // dataGridFooterRow7
      // 
      this.dataGridFooterRow7.BoundItems.Add(this.dataGridColumnFooterItem1);
      this.dataGridFooterRow7.BoundItems.Add(this.dataGridColumnFooterItem3);
      this.dataGridFooterRow7.BoundItems.Add(this.dataGridColumnFooterItem5);
      this.dataGridFooterRow7.BoundItems.Add(this.dataGridColumnFooterItem7);
      this.dataGridFooterRow7.BoundItems.Add(this.dataGridColumnFooterItem9);
      // 
      // dataGridColumnFooterItem1
      // 
      this.dataGridColumnFooterItem1.CalcValueFunction = countCalculator1;
      // 
      // dataGridColumnFooterItem5
      // 
      this.dataGridColumnFooterItem5.CalcValueFunction = sumCalculator1;
      // 
      // dataGridColumnFooterItem7
      // 
      this.dataGridColumnFooterItem7.CalcValueFunction = sumCalculator2;
      // 
      // dataGridColumnFooterItem9
      // 
      this.dataGridColumnFooterItem9.CalcValueFunction = countCalculator2;
      // 
      // dataGridFooterRow8
      // 
      this.dataGridFooterRow8.BoundItems.Add(this.dataGridColumnFooterItem2);
      this.dataGridFooterRow8.BoundItems.Add(this.dataGridColumnFooterItem4);
      this.dataGridFooterRow8.BoundItems.Add(this.dataGridColumnFooterItem6);
      this.dataGridFooterRow8.BoundItems.Add(this.dataGridColumnFooterItem8);
      this.dataGridFooterRow8.BoundItems.Add(this.dataGridColumnFooterItem10);
      // 
      // dataGridColumnFooterItem6
      // 
      this.dataGridColumnFooterItem6.FormatString = "##,#.00";
      this.dataGridColumnFooterItem6.HorzAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.dataGridColumnFooterItem6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 6);
      // 
      // tabPage1
      // 
      this.tabPage1.AutoScroll = true;
      this.tabPage1.Controls.Add(this.dataGridEh1);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(822, 323);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Demo";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // dataGridEh1
      // 
      this.dataGridEh1.DataSource = this.order_DetailsBindingSource;
      this.dataGridEh1.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // 
      // 
      this.dataGridEh1.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataGridEh1.Footer.Rows.AddRange(new EhLib.WinForms.DataGridFooterRow[] {
            this.dataGridFooterRow7,
            this.dataGridFooterRow8});
      this.dataGridEh1.Footer.RowStepCalculation += new System.EventHandler<EhLib.WinForms.DataGridFooterCalculationEventArgs>(this.dataGridEh1_Footer_RowStepCalculation);
      // 
      // 
      // 
      this.dataGridEh1.HorzScrollBar.ExtraBar.Visible = true;
      this.dataGridEh1.Location = new System.Drawing.Point(3, 3);
      this.dataGridEh1.Name = "dataGridEh1";
      this.dataGridEh1.Size = new System.Drawing.Size(816, 317);
      this.dataGridEh1.StaticColumns.AddRange(new EhLib.WinForms.PropertyAxisBar[] {
            this.dataGridTextColumn1,
            this.dataGridTextColumn2,
            this.columnUnitPrice,
            this.columnQuantity,
            this.dataGridTextColumn5});
      this.dataGridEh1.TabIndex = 0;
      // 
      // 
      // 
      this.dataGridEh1.Title.Filter.Active = true;
      this.dataGridEh1.SelectionChanged += new System.EventHandler<EhLib.WinForms.DataGridSelectionChangeOperationEventArgs>(this.dataGridEh1_SelectionChanged);
      this.dataGridEh1.Paint += new System.EventHandler<EhLib.WinForms.ControlPaintEventArgs>(this.dataGridEh1_Paint);
      // 
      // order_DetailsBindingSource
      // 
      this.order_DetailsBindingSource.DataMember = "Order Details";
      this.order_DetailsBindingSource.DataSource = this.northwindDataSet;
      // 
      // northwindDataSet
      // 
      this.northwindDataSet.DataSetName = "NorthwindDataSet";
      this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // dataGridTextColumn1
      // 
      this.dataGridTextColumn1.DataPropertyName = "OrderID";
      // 
      // 
      // 
      this.dataGridTextColumn1.Footer.BoundItems.Add(this.dataGridColumnFooterItem1);
      this.dataGridTextColumn1.Footer.BoundItems.Add(this.dataGridColumnFooterItem2);
      this.dataGridTextColumn1.Name = "dataGridTextColumn1";
      // 
      // 
      // 
      this.dataGridTextColumn1.Title.Text = "OrderID";
      // 
      // dataGridTextColumn2
      // 
      this.dataGridTextColumn2.DataPropertyName = "ProductID";
      // 
      // 
      // 
      this.dataGridTextColumn2.Footer.BoundItems.Add(this.dataGridColumnFooterItem3);
      this.dataGridTextColumn2.Footer.BoundItems.Add(this.dataGridColumnFooterItem4);
      this.dataGridTextColumn2.Name = "dataGridTextColumn2";
      // 
      // 
      // 
      this.dataGridTextColumn2.Title.Text = "ProductID";
      // 
      // columnUnitPrice
      // 
      this.columnUnitPrice.DataPropertyName = "UnitPrice";
      // 
      // 
      // 
      this.columnUnitPrice.Footer.BoundItems.Add(this.dataGridColumnFooterItem5);
      this.columnUnitPrice.Footer.BoundItems.Add(this.dataGridColumnFooterItem6);
      this.columnUnitPrice.Footer.CellPaint += new System.EventHandler<EhLib.WinForms.DataGridFooterCellPaintEventArgs>(this.columnUnitPrice_Footer_CellPaint);
      this.columnUnitPrice.Footer.InitCalculation += new System.EventHandler<EhLib.WinForms.DataGridFooterCalculationEventArgs>(this.columnUnitPrice_Footer_InitCalculation);
      this.columnUnitPrice.Footer.RowStepCalculation += new System.EventHandler<EhLib.WinForms.DataGridFooterCalculationEventArgs>(this.columnUnitPrice_Footer_RowStepCalculation);
      this.columnUnitPrice.Footer.FinalizeCalculation += new System.EventHandler<EhLib.WinForms.DataGridFooterCalculationEventArgs>(this.columnUnitPrice_Footer_FinalizeCalculation);
      this.columnUnitPrice.Name = "columnUnitPrice";
      // 
      // 
      // 
      this.columnUnitPrice.Title.Text = "UnitPrice";
      // 
      // columnQuantity
      // 
      this.columnQuantity.DataPropertyName = "Quantity";
      // 
      // 
      // 
      this.columnQuantity.Footer.BoundItems.Add(this.dataGridColumnFooterItem7);
      this.columnQuantity.Footer.BoundItems.Add(this.dataGridColumnFooterItem8);
      this.columnQuantity.Footer.CellPaint += new System.EventHandler<EhLib.WinForms.DataGridFooterCellPaintEventArgs>(this.columnQuantity_Footer_CellPaint);
      this.columnQuantity.Name = "columnQuantity";
      // 
      // 
      // 
      this.columnQuantity.Title.Text = "Quantity";
      this.columnQuantity.Width = 60;
      // 
      // dataGridTextColumn5
      // 
      this.dataGridTextColumn5.DataPropertyName = "Discount";
      // 
      // 
      // 
      this.dataGridTextColumn5.Footer.BoundItems.Add(this.dataGridColumnFooterItem9);
      this.dataGridTextColumn5.Footer.BoundItems.Add(this.dataGridColumnFooterItem10);
      this.dataGridTextColumn5.Footer.RowStepCalculation += new System.EventHandler<EhLib.WinForms.DataGridFooterCalculationEventArgs>(this.dataGridTextColumn5_Footer_RowStepCalculation);
      this.dataGridTextColumn5.Footer.CellFormatValue += new System.EventHandler<EhLib.WinForms.DataGridFooterCellFormatValueEventArgs>(this.dataGridTextColumn5_Footer_CellFormatValue);
      this.dataGridTextColumn5.Name = "dataGridTextColumn5";
      // 
      // 
      // 
      this.dataGridTextColumn5.Title.Text = "Discount";
      this.dataGridTextColumn5.Width = 188;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 36);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(830, 349);
      this.tabControl1.TabIndex = 9;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.richTextBox1);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(822, 323);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Description";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // richTextBox1
      // 
      this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.richTextBox1.Location = new System.Drawing.Point(3, 3);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(816, 317);
      this.richTextBox1.TabIndex = 1;
      this.richTextBox1.Text = "";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(6, 5);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(368, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "DataGridEh Custom Footer Calculation";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(830, 36);
      this.panel1.TabIndex = 8;
      // 
      // order_DetailsTableAdapter
      // 
      this.order_DetailsTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.CategoriesTableAdapter = null;
      this.tableAdapterManager.CustomersTableAdapter = null;
      this.tableAdapterManager.EmployeesTableAdapter = null;
      this.tableAdapterManager.Order_DetailsTableAdapter = this.order_DetailsTableAdapter;
      this.tableAdapterManager.OrdersTableAdapter = null;
      this.tableAdapterManager.ProductsTableAdapter = null;
      this.tableAdapterManager.ShippersTableAdapter = null;
      this.tableAdapterManager.UpdateOrder = MainDemo.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // FrameSolDataGridFooterCalculation
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.panel1);
      this.Name = "FrameSolDataGridFooterCalculation";
      this.Size = new System.Drawing.Size(830, 385);
      this.tabPage1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridEh1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.order_DetailsBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel1;
    private NorthwindDataSet northwindDataSet;
    private System.Windows.Forms.BindingSource order_DetailsBindingSource;
    private NorthwindDataSetTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter;
    private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private EhLib.WinForms.DataGridEh dataGridEh1;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn1;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn2;
    private EhLib.WinForms.DataGridTextColumn columnUnitPrice;
    private EhLib.WinForms.DataGridTextColumn columnQuantity;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn5;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private EhLib.WinForms.DataGridFooterRow dataGridFooterRow7;
    private EhLib.WinForms.DataGridFooterRow dataGridFooterRow8;
    private EhLib.WinForms.DataGridColumnFooterItem dataGridColumnFooterItem1;
    private EhLib.WinForms.DataGridColumnFooterItem dataGridColumnFooterItem2;
    private EhLib.WinForms.DataGridColumnFooterItem dataGridColumnFooterItem3;
    private EhLib.WinForms.DataGridColumnFooterItem dataGridColumnFooterItem4;
    private EhLib.WinForms.DataGridColumnFooterItem dataGridColumnFooterItem5;
    private EhLib.WinForms.DataGridColumnFooterItem dataGridColumnFooterItem6;
    private EhLib.WinForms.DataGridColumnFooterItem dataGridColumnFooterItem7;
    private EhLib.WinForms.DataGridColumnFooterItem dataGridColumnFooterItem8;
    private EhLib.WinForms.DataGridColumnFooterItem dataGridColumnFooterItem9;
    private EhLib.WinForms.DataGridColumnFooterItem dataGridColumnFooterItem10;
  }
}
