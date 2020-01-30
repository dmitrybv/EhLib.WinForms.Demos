namespace MainDemo
{
  partial class FrameRowDetailPanel
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
      this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.northwindDataSet = new MainDemo.NorthwindDataSet();
      this.label1 = new System.Windows.Forms.Label();
      this.ordersTableAdapter = new MainDemo.NorthwindDataSetTableAdapters.OrdersTableAdapter();
      this.tableAdapterManager = new MainDemo.NorthwindDataSetTableAdapters.TableAdapterManager();
      this.order_DetailsTableAdapter = new MainDemo.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter();
      this.order_DetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dataGrid1 = new EhLib.WinForms.DataGridEh();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.dataGridEh1 = new EhLib.WinForms.DataGridEh();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.dataPropertyGridEh1 = new EhLib.WinForms.DataPropertyGridEh();
      this.dataGrid1OrderIDColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGrid1CustomerIDColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGrid1EmployeeIDColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGrid1OrderDateColumn = new EhLib.WinForms.DataGridDateTimeColumn();
      this.dataGrid1RequiredDateColumn = new EhLib.WinForms.DataGridDateTimeColumn();
      this.dataGrid1ShippedDateColumn = new EhLib.WinForms.DataGridDateTimeColumn();
      this.dataGrid1ShipViaColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGrid1FreightColumn = new EhLib.WinForms.DataGridTextColumn();
      this.dataGrid1ShipNameColumn = new EhLib.WinForms.DataGridTextColumn();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.order_DetailsBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
      this.dataGrid1.RowDetailPanelContent.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridEh1)).BeginInit();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataPropertyGridEh1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(861, 36);
      this.panel1.TabIndex = 1;
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
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(32, 6);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(168, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "Row Detail Panel";
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
      // order_DetailsTableAdapter
      // 
      this.order_DetailsTableAdapter.ClearBeforeFill = true;
      // 
      // order_DetailsBindingSource
      // 
      this.order_DetailsBindingSource.DataMember = "OrdersOrder Details";
      this.order_DetailsBindingSource.DataSource = this.ordersBindingSource;
      // 
      // dataGrid1
      // 
      this.dataGrid1.AutoGenerateColumns = false;
      // 
      // 
      // 
      this.dataGrid1.Background.GridOpacityOptions.CellsOpacity = 128;
      this.dataGrid1.Background.GridOpacityOptions.LinesOpacity = 128;
      this.dataGrid1.Background.ImageOptions.Opacity = 200;
      this.dataGrid1.Background.ImageOptions.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
      this.dataGrid1.Background.ImageOptions.Scale = 0.8D;
      this.dataGrid1.Background.Visible = true;
      this.dataGrid1.DataSource = this.ordersBindingSource;
      this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // 
      // 
      this.dataGrid1.EmptyDataInfo.Text = null;
      this.dataGrid1.LineOptions.BrightColor = System.Drawing.Color.Gainsboro;
      this.dataGrid1.Location = new System.Drawing.Point(0, 36);
      this.dataGrid1.Name = "dataGrid1";
      // 
      // 
      // 
      this.dataGrid1.RowDetailPanel.Active = true;
      this.dataGrid1.RowDetailPanel.Height = 240;
      this.dataGrid1.RowDetailPanel.VertSizing = true;
      // 
      // dataGrid1.RowDetailPanelContent
      // 
      this.dataGrid1.RowDetailPanelContent.Controls.Add(this.tabControl1);
      this.dataGrid1.RowOptions.EvenColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
      this.dataGrid1.RowOptions.OddColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
      this.dataGrid1.Size = new System.Drawing.Size(861, 494);
      this.dataGrid1.StaticColumns.AddRange(new EhLib.WinForms.PropertyAxisBar[] {
            this.dataGrid1OrderIDColumn,
            this.dataGrid1CustomerIDColumn,
            this.dataGrid1EmployeeIDColumn,
            this.dataGrid1OrderDateColumn,
            this.dataGrid1RequiredDateColumn,
            this.dataGrid1ShippedDateColumn,
            this.dataGrid1ShipViaColumn,
            this.dataGrid1FreightColumn,
            this.dataGrid1ShipNameColumn});
      this.dataGrid1.TabIndex = 0;
      this.dataGrid1.Text = "dataGrid1";
      // 
      // dataGrid1.Title
      // 
      this.dataGrid1.Title.Filter.Active = true;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(462, 230);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.dataGridEh1);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(454, 204);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Positions";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // dataGridEh1
      // 
      this.dataGridEh1.DataSource = this.order_DetailsBindingSource;
      this.dataGridEh1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridEh1.Location = new System.Drawing.Point(3, 3);
      this.dataGridEh1.Name = "dataGridEh1";
      this.dataGridEh1.Size = new System.Drawing.Size(448, 198);
      this.dataGridEh1.TabIndex = 0;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.dataPropertyGridEh1);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(454, 204);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Details";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // dataPropertyGridEh1
      // 
      this.dataPropertyGridEh1.DataSource = this.ordersBindingSource;
      this.dataPropertyGridEh1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataPropertyGridEh1.Location = new System.Drawing.Point(3, 3);
      this.dataPropertyGridEh1.Name = "dataPropertyGridEh1";
      this.dataPropertyGridEh1.Size = new System.Drawing.Size(448, 198);
      this.dataPropertyGridEh1.TabIndex = 0;
      // 
      // 
      // 
      this.dataPropertyGridEh1.TitleColumn.Width = 223;
      // 
      // dataGrid1OrderIDColumn
      // 
      this.dataGrid1OrderIDColumn.DataPropertyName = "OrderID";
      this.dataGrid1OrderIDColumn.Name = "dataGrid1OrderIDColumn";
      // 
      // dataGrid1OrderIDColumn.Title
      // 
      this.dataGrid1OrderIDColumn.Title.Text = "OrderID";
      // 
      // dataGrid1CustomerIDColumn
      // 
      this.dataGrid1CustomerIDColumn.DataPropertyName = "CustomerID";
      this.dataGrid1CustomerIDColumn.Name = "dataGrid1CustomerIDColumn";
      // 
      // dataGrid1CustomerIDColumn.Title
      // 
      this.dataGrid1CustomerIDColumn.Title.Text = "CustomerID";
      this.dataGrid1CustomerIDColumn.Width = 46;
      // 
      // dataGrid1EmployeeIDColumn
      // 
      this.dataGrid1EmployeeIDColumn.DataPropertyName = "EmployeeID";
      this.dataGrid1EmployeeIDColumn.Name = "dataGrid1EmployeeIDColumn";
      // 
      // dataGrid1EmployeeIDColumn.Title
      // 
      this.dataGrid1EmployeeIDColumn.Title.Text = "EmployeeID";
      this.dataGrid1EmployeeIDColumn.Width = 47;
      // 
      // dataGrid1OrderDateColumn
      // 
      this.dataGrid1OrderDateColumn.DataPropertyName = "OrderDate";
      this.dataGrid1OrderDateColumn.Name = "dataGrid1OrderDateColumn";
      // 
      // dataGrid1OrderDateColumn.Title
      // 
      this.dataGrid1OrderDateColumn.Title.Text = "OrderDate";
      // 
      // dataGrid1RequiredDateColumn
      // 
      this.dataGrid1RequiredDateColumn.DataPropertyName = "RequiredDate";
      this.dataGrid1RequiredDateColumn.Name = "dataGrid1RequiredDateColumn";
      // 
      // dataGrid1RequiredDateColumn.Title
      // 
      this.dataGrid1RequiredDateColumn.Title.Text = "RequiredDate";
      this.dataGrid1RequiredDateColumn.Width = 87;
      // 
      // dataGrid1ShippedDateColumn
      // 
      this.dataGrid1ShippedDateColumn.DataPropertyName = "ShippedDate";
      this.dataGrid1ShippedDateColumn.Name = "dataGrid1ShippedDateColumn";
      // 
      // dataGrid1ShippedDateColumn.Title
      // 
      this.dataGrid1ShippedDateColumn.Title.Text = "ShippedDate";
      this.dataGrid1ShippedDateColumn.Width = 85;
      // 
      // dataGrid1ShipViaColumn
      // 
      this.dataGrid1ShipViaColumn.DataPropertyName = "ShipVia";
      this.dataGrid1ShipViaColumn.Name = "dataGrid1ShipViaColumn";
      // 
      // dataGrid1ShipViaColumn.Title
      // 
      this.dataGrid1ShipViaColumn.Title.Text = "ShipVia";
      // 
      // dataGrid1FreightColumn
      // 
      this.dataGrid1FreightColumn.DataPropertyName = "Freight";
      this.dataGrid1FreightColumn.Name = "dataGrid1FreightColumn";
      // 
      // dataGrid1FreightColumn.Title
      // 
      this.dataGrid1FreightColumn.Title.Text = "Freight";
      // 
      // dataGrid1ShipNameColumn
      // 
      this.dataGrid1ShipNameColumn.DataPropertyName = "ShipName";
      this.dataGrid1ShipNameColumn.Name = "dataGrid1ShipNameColumn";
      // 
      // dataGrid1ShipNameColumn.Title
      // 
      this.dataGrid1ShipNameColumn.Title.Text = "ShipName";
      this.dataGrid1ShipNameColumn.Width = 192;
      // 
      // FrameRowDetailPanel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.dataGrid1);
      this.Controls.Add(this.panel1);
      this.Name = "FrameRowDetailPanel";
      this.Size = new System.Drawing.Size(861, 530);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.order_DetailsBindingSource)).EndInit();
      this.dataGrid1.RowDetailPanelContent.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridEh1)).EndInit();
      this.tabPage2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataPropertyGridEh1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private NorthwindDataSet northwindDataSet;
    private System.Windows.Forms.BindingSource ordersBindingSource;
    private NorthwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
    private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.BindingSource order_DetailsBindingSource;
    private NorthwindDataSetTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter;
    private EhLib.WinForms.DataGridEh dataGrid1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private EhLib.WinForms.DataGridEh dataGridEh1;
    private EhLib.WinForms.DataGridTextColumn dataGrid1OrderIDColumn;
    private EhLib.WinForms.DataGridTextColumn dataGrid1CustomerIDColumn;
    private EhLib.WinForms.DataGridTextColumn dataGrid1EmployeeIDColumn;
    private EhLib.WinForms.DataGridDateTimeColumn dataGrid1OrderDateColumn;
    private EhLib.WinForms.DataGridDateTimeColumn dataGrid1RequiredDateColumn;
    private EhLib.WinForms.DataGridDateTimeColumn dataGrid1ShippedDateColumn;
    private EhLib.WinForms.DataGridTextColumn dataGrid1ShipViaColumn;
    private EhLib.WinForms.DataGridTextColumn dataGrid1FreightColumn;
    private EhLib.WinForms.DataGridTextColumn dataGrid1ShipNameColumn;
    private EhLib.WinForms.DataPropertyGridEh dataPropertyGridEh1;
  }
}
