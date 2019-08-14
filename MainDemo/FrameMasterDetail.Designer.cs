namespace MainDemo
{
  partial class FrameMasterDetail
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrameMasterDetail));
      EhLib.WinForms.DataGridFooterRow dataGridFooterRow1 = new EhLib.WinForms.DataGridFooterRow();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.northwindDataSet = new MainDemo.NorthwindDataSet();
      this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.ordersTableAdapter = new MainDemo.NorthwindDataSetTableAdapters.OrdersTableAdapter();
      this.tableAdapterManager = new MainDemo.NorthwindDataSetTableAdapters.TableAdapterManager();
      this.ordersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.order_DetailsTableAdapter = new MainDemo.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.dataGrid1 = new EhLib.WinForms.DataGridEh();
      this.dataGrid2 = new EhLib.WinForms.DataGridEh();
      this.order_DetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dataGridTextColumn1 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn2 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn3 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn4 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn5 = new EhLib.WinForms.DataGridTextColumn();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).BeginInit();
      this.ordersBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.order_DetailsBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(868, 36);
      this.panel1.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(32, 6);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(130, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "Master Detail";
      // 
      // northwindDataSet
      // 
      this.northwindDataSet.DataSetName = "NorthwindDataSet";
      this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // ordersBindingSource
      // 
      this.ordersBindingSource.DataMember = "Orders";
      this.ordersBindingSource.DataSource = this.northwindDataSet;
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
      // ordersBindingNavigator
      // 
      this.ordersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.ordersBindingNavigator.BindingSource = this.ordersBindingSource;
      this.ordersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.ordersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.ordersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
      this.ordersBindingNavigator.Location = new System.Drawing.Point(0, 36);
      this.ordersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.ordersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.ordersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.ordersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.ordersBindingNavigator.Name = "ordersBindingNavigator";
      this.ordersBindingNavigator.Padding = new System.Windows.Forms.Padding(5, 10, 1, 5);
      this.ordersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.ordersBindingNavigator.Size = new System.Drawing.Size(868, 38);
      this.ordersBindingNavigator.TabIndex = 2;
      this.ordersBindingNavigator.Text = "bindingNavigator1";
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorAddNewItem.Text = "Add new";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 20);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorDeleteItem.Text = "Delete";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorMoveFirstItem.Text = "Move first";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorMovePreviousItem.Text = "Move previous";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 23);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Position";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Current position";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 23);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorMoveNextItem.Text = "Move next";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorMoveLastItem.Text = "Move last";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 23);
      // 
      // order_DetailsTableAdapter
      // 
      this.order_DetailsTableAdapter.ClearBeforeFill = true;
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 74);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.dataGrid1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.dataGrid2);
      this.splitContainer1.Size = new System.Drawing.Size(868, 454);
      this.splitContainer1.SplitterDistance = 171;
      this.splitContainer1.SplitterWidth = 10;
      this.splitContainer1.TabIndex = 4;
      // 
      // dataGrid1
      // 
      this.dataGrid1.AutoGenerateColumns = true;
      this.dataGrid1.Background.GridOpacityOptions.CellsOpacity = 128;
      this.dataGrid1.Background.GridOpacityOptions.LinesOpacity = 128;
      this.dataGrid1.Background.Image = global::MainDemo.Properties.Resources.Master;
      this.dataGrid1.Background.ImageOptions.Opacity = 200;
      this.dataGrid1.Background.ImageOptions.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
      this.dataGrid1.Background.ImageOptions.Scale = 0.8D;
      this.dataGrid1.Background.Visible = true;
      this.dataGrid1.Cursor = System.Windows.Forms.Cursors.Default;
      this.dataGrid1.DataSource = this.ordersBindingSource;
      this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // 
      // 
      this.dataGrid1.EmptyDataInfo.Text = null;
      this.dataGrid1.GridState = EhLib.WinForms.BaseGridState.Normal;
      this.dataGrid1.LineOptions.BrightColor = System.Drawing.Color.Gainsboro;
      this.dataGrid1.Location = new System.Drawing.Point(0, 0);
      this.dataGrid1.Name = "dataGrid1";
      this.dataGrid1.RowOptions.EvenColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
      this.dataGrid1.RowOptions.OddColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
      this.dataGrid1.Size = new System.Drawing.Size(868, 171);
      this.dataGrid1.TabIndex = 0;
      this.dataGrid1.Text = "dataGrid1";
      // 
      // dataGrid2
      // 
      this.dataGrid2.AutoGenerateColumns = true;
      this.dataGrid2.Background.GridOpacityOptions.CellsOpacity = 200;
      this.dataGrid2.Background.GridOpacityOptions.FocusCellOpacity = 220;
      this.dataGrid2.Background.GridOpacityOptions.LinesOpacity = 128;
      this.dataGrid2.Background.Image = global::MainDemo.Properties.Resources.Detail;
      this.dataGrid2.Background.ImageOptions.Opacity = 100;
      this.dataGrid2.Background.ImageOptions.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
      this.dataGrid2.Background.ImageOptions.Scale = 0.7D;
      this.dataGrid2.Background.Visible = true;
      this.dataGrid2.Cursor = System.Windows.Forms.Cursors.Default;
      this.dataGrid2.DataSource = this.order_DetailsBindingSource;
      this.dataGrid2.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // 
      // 
      this.dataGrid2.EmptyDataInfo.Text = null;
      this.dataGrid2.Footer.Rows.AddRange(new EhLib.WinForms.DataGridFooterRow[] {
            dataGridFooterRow1});
      this.dataGrid2.GridState = EhLib.WinForms.BaseGridState.Normal;
      this.dataGrid2.LineOptions.BrightColor = System.Drawing.Color.Gainsboro;
      this.dataGrid2.Location = new System.Drawing.Point(0, 0);
      this.dataGrid2.Name = "dataGrid2";
      this.dataGrid2.Size = new System.Drawing.Size(868, 273);
      this.dataGrid2.StaticColumns.AddRange(new EhLib.WinForms.PropertyAxisBar[] {
            this.dataGridTextColumn1,
            this.dataGridTextColumn2,
            this.dataGridTextColumn3,
            this.dataGridTextColumn4,
            this.dataGridTextColumn5});
      this.dataGrid2.TabIndex = 0;
      this.dataGrid2.Text = "dataGrid2";
      // 
      // order_DetailsBindingSource
      // 
      this.order_DetailsBindingSource.DataMember = "OrdersOrder Details";
      this.order_DetailsBindingSource.DataSource = this.ordersBindingSource;
      // 
      // dataGridTextColumn1
      // 
      this.dataGridTextColumn1.DataPropertyName = "OrderID";
      this.dataGridTextColumn1.Name = "dataGridTextColumn1";
      this.dataGridTextColumn1.Title.Text = "OrderID";
      // 
      // dataGridTextColumn2
      // 
      this.dataGridTextColumn2.DataPropertyName = "ProductID";
      this.dataGridTextColumn2.Name = "dataGridTextColumn2";
      this.dataGridTextColumn2.Title.Text = "ProductID";
      // 
      // dataGridTextColumn3
      // 
      this.dataGridTextColumn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(204)))));
      this.dataGridTextColumn3.DataPropertyName = "UnitPrice";
      this.dataGridTextColumn3.Name = "dataGridTextColumn3";
      this.dataGridTextColumn3.Title.Text = "UnitPrice";
      // 
      // dataGridTextColumn4
      // 
      this.dataGridTextColumn4.DataPropertyName = "Quantity";
      this.dataGridTextColumn4.Name = "dataGridTextColumn4";
      this.dataGridTextColumn4.Title.Text = "Quantity";
      // 
      // dataGridTextColumn5
      // 
      this.dataGridTextColumn5.DataPropertyName = "Discount";
      this.dataGridTextColumn5.Name = "dataGridTextColumn5";
      this.dataGridTextColumn5.Title.Text = "Discount";
      // 
      // FrameMasterDetail
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.ordersBindingNavigator);
      this.Controls.Add(this.panel1);
      this.Name = "FrameMasterDetail";
      this.Size = new System.Drawing.Size(868, 528);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).EndInit();
      this.ordersBindingNavigator.ResumeLayout(false);
      this.ordersBindingNavigator.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.order_DetailsBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private NorthwindDataSet northwindDataSet;
    private System.Windows.Forms.BindingSource ordersBindingSource;
    private NorthwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
    private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.BindingNavigator ordersBindingNavigator;
    private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
    private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
    private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    private System.Windows.Forms.BindingSource order_DetailsBindingSource;
    private NorthwindDataSetTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private EhLib.WinForms.DataGridEh dataGrid1;
    private EhLib.WinForms.DataGridEh dataGrid2;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn1;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn2;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn3;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn4;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn5;
  }
}
