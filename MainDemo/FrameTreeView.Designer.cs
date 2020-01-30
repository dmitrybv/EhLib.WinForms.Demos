namespace MainDemo
{
  partial class FrameTreeView
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrameTreeView));
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.biolifeDataSet = new MainDemo.BiolifeDataSet();
      this.testTreeBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.testTreeTableAdapter = new MainDemo.BiolifeDataSetTableAdapters.TestTreeTableAdapter();
      this.tableAdapterManager = new MainDemo.BiolifeDataSetTableAdapters.TableAdapterManager();
      this.testTreeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
      this.testTreeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.dataGridEh1 = new EhLib.WinForms.DataGridEh();
      this.testTreeDataGridEhNODNAMEColumn = new EhLib.WinForms.DataGridTextColumn();
      this.testTreeDataGridEhIDColumn = new EhLib.WinForms.DataGridTextColumn();
      this.testTreeDataGridEhID_PARENTColumn = new EhLib.WinForms.DataGridTextColumn();
      this.testTreeDataGridEhExpandedColumn = new EhLib.WinForms.DataGridTextColumn();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.biolifeDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.testTreeBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.testTreeBindingNavigator)).BeginInit();
      this.testTreeBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridEh1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(676, 36);
      this.panel1.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(32, 6);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(284, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "DataGridEh - TreeView mode";
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.checkBox1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 36);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(676, 44);
      this.panel2.TabIndex = 4;
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Checked = true;
      this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox1.Location = new System.Drawing.Point(14, 14);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(104, 17);
      this.checkBox1.TabIndex = 0;
      this.checkBox1.Text = "View as TreeList";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
      // 
      // biolifeDataSet
      // 
      this.biolifeDataSet.DataSetName = "BiolifeDataSet";
      this.biolifeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // testTreeBindingSource
      // 
      this.testTreeBindingSource.DataMember = "TestTree";
      this.testTreeBindingSource.DataSource = this.biolifeDataSet;
      // 
      // testTreeTableAdapter
      // 
      this.testTreeTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.BiolifeTableAdapter = null;
      this.tableAdapterManager.countryTableAdapter = null;
      this.tableAdapterManager.TestTreeTableAdapter = this.testTreeTableAdapter;
      this.tableAdapterManager.UpdateOrder = MainDemo.BiolifeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // testTreeBindingNavigator
      // 
      this.testTreeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.testTreeBindingNavigator.BindingSource = this.testTreeBindingSource;
      this.testTreeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.testTreeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.testTreeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.testTreeBindingNavigatorSaveItem});
      this.testTreeBindingNavigator.Location = new System.Drawing.Point(0, 80);
      this.testTreeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.testTreeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.testTreeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.testTreeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.testTreeBindingNavigator.Name = "testTreeBindingNavigator";
      this.testTreeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.testTreeBindingNavigator.Size = new System.Drawing.Size(676, 25);
      this.testTreeBindingNavigator.TabIndex = 5;
      this.testTreeBindingNavigator.Text = "bindingNavigator1";
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorAddNewItem.Text = "Add new";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "Delete";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveFirstItem.Text = "Move first";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMovePreviousItem.Text = "Move previous";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Position";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Current position";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveNextItem.Text = "Move next";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveLastItem.Text = "Move last";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // testTreeBindingNavigatorSaveItem
      // 
      this.testTreeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.testTreeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("testTreeBindingNavigatorSaveItem.Image")));
      this.testTreeBindingNavigatorSaveItem.Name = "testTreeBindingNavigatorSaveItem";
      this.testTreeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
      this.testTreeBindingNavigatorSaveItem.Text = "Save Data";
      this.testTreeBindingNavigatorSaveItem.Click += new System.EventHandler(this.testTreeBindingNavigatorSaveItem_Click);
      // 
      // dataGridEh1
      // 
      this.dataGridEh1.AllowedOperations.AddRecord = false;
      this.dataGridEh1.AllowedOperations.DeleteRecord = false;
      this.dataGridEh1.DataMember = "";
      this.dataGridEh1.DataSource = this.testTreeBindingSource;
      this.dataGridEh1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridEh1.Location = new System.Drawing.Point(0, 105);
      this.dataGridEh1.Name = "dataGridEh1";
      // 
      // dataGridEh1.SearchBox
      // 
      this.dataGridEh1.SearchBox.Enabled = true;
      this.dataGridEh1.Size = new System.Drawing.Size(676, 373);
      this.dataGridEh1.StaticColumns.AddRange(new EhLib.WinForms.PropertyAxisBar[] {
            this.testTreeDataGridEhNODNAMEColumn,
            this.testTreeDataGridEhIDColumn,
            this.testTreeDataGridEhID_PARENTColumn,
            this.testTreeDataGridEhExpandedColumn});
      this.dataGridEh1.TabIndex = 5;
      // 
      // dataGridEh1.TreeViewArea
      // 
      this.dataGridEh1.TreeView.RefParentRowPropertyName = "ID_PARENT";
      this.dataGridEh1.TreeView.RowKeyPropertyName = "ID";
      this.dataGridEh1.TreeView.TreeListActive = true;
      this.dataGridEh1.TreeView.TreeViewAreaVisible = true;
      this.dataGridEh1.TreeView.NewNodeInit += new System.EventHandler<EhLib.WinForms.DataGridTreeViewNewNodeInitEventArgs>(this.dataGridEh1_TreeView_NewNodeInit);
      // 
      // testTreeDataGridEhNODNAMEColumn
      // 
      this.testTreeDataGridEhNODNAMEColumn.DataPropertyName = "NODNAME";
      this.testTreeDataGridEhNODNAMEColumn.Name = "testTreeDataGridEhNODNAMEColumn";
      // 
      // testTreeDataGridEhNODNAMEColumn.Title
      // 
      this.testTreeDataGridEhNODNAMEColumn.Title.Text = "NODNAME";
      this.testTreeDataGridEhNODNAMEColumn.Width = 168;
      // 
      // testTreeDataGridEhIDColumn
      // 
      this.testTreeDataGridEhIDColumn.DataPropertyName = "ID";
      this.testTreeDataGridEhIDColumn.Name = "testTreeDataGridEhIDColumn";
      // 
      // testTreeDataGridEhIDColumn.Title
      // 
      this.testTreeDataGridEhIDColumn.Title.Text = "ID";
      this.testTreeDataGridEhIDColumn.Width = 70;
      // 
      // testTreeDataGridEhID_PARENTColumn
      // 
      this.testTreeDataGridEhID_PARENTColumn.DataPropertyName = "ID_PARENT";
      this.testTreeDataGridEhID_PARENTColumn.Name = "testTreeDataGridEhID_PARENTColumn";
      // 
      // testTreeDataGridEhID_PARENTColumn.Title
      // 
      this.testTreeDataGridEhID_PARENTColumn.Title.Text = "ID_PARENT";
      this.testTreeDataGridEhID_PARENTColumn.Width = 102;
      // 
      // testTreeDataGridEhExpandedColumn
      // 
      this.testTreeDataGridEhExpandedColumn.DataPropertyName = "Expanded";
      this.testTreeDataGridEhExpandedColumn.Name = "testTreeDataGridEhExpandedColumn";
      // 
      // testTreeDataGridEhExpandedColumn.Title
      // 
      this.testTreeDataGridEhExpandedColumn.Title.Text = "Expanded";
      this.testTreeDataGridEhExpandedColumn.Width = 24;
      // 
      // FrameTreeView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.dataGridEh1);
      this.Controls.Add(this.testTreeBindingNavigator);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "FrameTreeView";
      this.Size = new System.Drawing.Size(676, 478);
      this.Load += new System.EventHandler(this.FrameTreeView_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.biolifeDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.testTreeBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.testTreeBindingNavigator)).EndInit();
      this.testTreeBindingNavigator.ResumeLayout(false);
      this.testTreeBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridEh1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.CheckBox checkBox1;
        private BiolifeDataSet biolifeDataSet;
        private System.Windows.Forms.BindingSource testTreeBindingSource;
        private BiolifeDataSetTableAdapters.TestTreeTableAdapter testTreeTableAdapter;
        private BiolifeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator testTreeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton testTreeBindingNavigatorSaveItem;
        private EhLib.WinForms.DataGridEh dataGridEh1;
        private EhLib.WinForms.DataGridTextColumn testTreeDataGridEhNODNAMEColumn;
        private EhLib.WinForms.DataGridTextColumn testTreeDataGridEhIDColumn;
        private EhLib.WinForms.DataGridTextColumn testTreeDataGridEhID_PARENTColumn;
        private EhLib.WinForms.DataGridTextColumn testTreeDataGridEhExpandedColumn;
    }
}
