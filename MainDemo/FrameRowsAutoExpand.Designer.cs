namespace MainDemo
{
  partial class FrameRowsAutoExpand
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrameRowsAutoExpand));
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.biolifeBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.biolifeDataSet = new MainDemo.BiolifeDataSet();
      this.categoriesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
      this.categoriesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.biolifeTableAdapter = new MainDemo.BiolifeDataSetTableAdapters.BiolifeTableAdapter();
      this.tableAdapterManager = new MainDemo.BiolifeDataSetTableAdapters.TableAdapterManager();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.dataGrid1 = new EhLib.WinForms.DataGridEh();
      this.dataGridTextColumn1 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn2 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn3 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn4 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn5 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn6 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridImageColumn1 = new EhLib.WinForms.DataGridImageColumn();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.biolifeBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.biolifeDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingNavigator)).BeginInit();
      this.categoriesBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(824, 38);
      this.panel1.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(32, 6);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(182, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "Rows AutoExpand";
      // 
      // biolifeBindingSource
      // 
      this.biolifeBindingSource.DataMember = "Biolife";
      this.biolifeBindingSource.DataSource = this.biolifeDataSet;
      // 
      // biolifeDataSet
      // 
      this.biolifeDataSet.DataSetName = "BiolifeDataSet";
      this.biolifeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // categoriesBindingNavigator
      // 
      this.categoriesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.categoriesBindingNavigator.BindingSource = this.biolifeBindingSource;
      this.categoriesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.categoriesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.categoriesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.categoriesBindingNavigatorSaveItem});
      this.categoriesBindingNavigator.Location = new System.Drawing.Point(0, 38);
      this.categoriesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.categoriesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.categoriesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.categoriesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.categoriesBindingNavigator.Name = "categoriesBindingNavigator";
      this.categoriesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.categoriesBindingNavigator.Size = new System.Drawing.Size(824, 25);
      this.categoriesBindingNavigator.TabIndex = 2;
      this.categoriesBindingNavigator.Text = "bindingNavigator1";
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
      // categoriesBindingNavigatorSaveItem
      // 
      this.categoriesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.categoriesBindingNavigatorSaveItem.Enabled = false;
      this.categoriesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriesBindingNavigatorSaveItem.Image")));
      this.categoriesBindingNavigatorSaveItem.Name = "categoriesBindingNavigatorSaveItem";
      this.categoriesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
      this.categoriesBindingNavigatorSaveItem.Text = "Save Data";
      // 
      // biolifeTableAdapter
      // 
      this.biolifeTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.BiolifeTableAdapter = this.biolifeTableAdapter;
      this.tableAdapterManager.countryTableAdapter = null;
      this.tableAdapterManager.UpdateOrder = MainDemo.BiolifeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      this.openFileDialog1.InitialDirectory = "C:\\DelphiStuff\\EhLib6_4\\Info\\Images\\";
      // 
      // dataGrid1
      // 
      this.dataGrid1.Background.GridOpacityOptions.CellsOpacity = 200;
      this.dataGrid1.Background.Image = global::MainDemo.Properties.Resources.jellyfish_small;
      this.dataGrid1.Background.ImageOptions.Opacity = 100;
      this.dataGrid1.Background.ImageOptions.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
      this.dataGrid1.Background.ImageOptions.Scale = 0.7D;
      this.dataGrid1.Background.Visible = true;
      this.dataGrid1.DataMember = "";
      this.dataGrid1.DataSource = this.biolifeBindingSource;
      this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // 
      // 
      this.dataGrid1.EmptyDataInfo.Text = null;
      this.dataGrid1.GridState = EhLib.WinForms.BaseGridState.Normal;
      this.dataGrid1.Location = new System.Drawing.Point(0, 63);
      this.dataGrid1.Name = "dataGrid1";
      this.dataGrid1.RowOptions.HeightOptions.AutoExpand = true;
      this.dataGrid1.Size = new System.Drawing.Size(824, 507);
      this.dataGrid1.StaticColumns.AddRange(new EhLib.WinForms.PropertyAxisBar[] {
            this.dataGridTextColumn1,
            this.dataGridTextColumn2,
            this.dataGridTextColumn3,
            this.dataGridTextColumn4,
            this.dataGridTextColumn5,
            this.dataGridTextColumn6,
            this.dataGridImageColumn1});
      this.dataGrid1.TabIndex = 3;
      this.dataGrid1.Text = "dataGrid1";
      // 
      // dataGridTextColumn1
      // 
      this.dataGridTextColumn1.DataPropertyName = "SpeciesId";
      this.dataGridTextColumn1.Name = "dataGridTextColumn1";
      this.dataGridTextColumn1.Title.Text = "SpeciesId";
      // 
      // dataGridTextColumn2
      // 
      this.dataGridTextColumn2.DataPropertyName = "Category";
      this.dataGridTextColumn2.Name = "dataGridTextColumn2";
      this.dataGridTextColumn2.Title.Text = "Category";
      // 
      // dataGridTextColumn3
      // 
      this.dataGridTextColumn3.DataPropertyName = "Common_name";
      this.dataGridTextColumn3.Name = "dataGridTextColumn3";
      this.dataGridTextColumn3.Title.Text = "Common_name";
      // 
      // dataGridTextColumn4
      // 
      this.dataGridTextColumn4.DataPropertyName = "Species_Name";
      this.dataGridTextColumn4.Name = "dataGridTextColumn4";
      this.dataGridTextColumn4.Title.Text = "Species_Name";
      // 
      // dataGridTextColumn5
      // 
      this.dataGridTextColumn5.DataPropertyName = "Length";
      this.dataGridTextColumn5.Name = "dataGridTextColumn5";
      this.dataGridTextColumn5.Title.Text = "Length";
      // 
      // dataGridTextColumn6
      // 
      this.dataGridTextColumn6.DataPropertyName = "Notes";
      this.dataGridTextColumn6.Name = "dataGridTextColumn6";
      this.dataGridTextColumn6.Title.Text = "Notes";
      this.dataGridTextColumn6.Width = 496;
      // 
      // dataGridImageColumn1
      // 
      this.dataGridImageColumn1.DataPropertyName = "Graphic";
      this.dataGridImageColumn1.Name = "dataGridImageColumn1";
      this.dataGridImageColumn1.Title.Text = "Graphic";
      this.dataGridImageColumn1.Width = 256;
      // 
      // FrameRowsAutoExpand
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.dataGrid1);
      this.Controls.Add(this.categoriesBindingNavigator);
      this.Controls.Add(this.panel1);
      this.Name = "FrameRowsAutoExpand";
      this.Size = new System.Drawing.Size(824, 570);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.biolifeBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.biolifeDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingNavigator)).EndInit();
      this.categoriesBindingNavigator.ResumeLayout(false);
      this.categoriesBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.BindingNavigator categoriesBindingNavigator;
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
    private System.Windows.Forms.ToolStripButton categoriesBindingNavigatorSaveItem;
    private EhLib.WinForms.DataGridEh dataGrid1;
    private System.Windows.Forms.BindingSource biolifeBindingSource;
    private BiolifeDataSet biolifeDataSet;
    private BiolifeDataSetTableAdapters.BiolifeTableAdapter biolifeTableAdapter;
    private BiolifeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn1;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn2;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn3;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn4;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn5;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn6;
    private EhLib.WinForms.DataGridImageColumn dataGridImageColumn1;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
  }
}
