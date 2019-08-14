namespace MainDemo
{
  partial class FrameSolDataGridAutoDataLoad
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrameSolDataGridAutoDataLoad));
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.dataGrid1 = new EhLib.WinForms.DataGridEh();
      this.citiesBSource = new System.Windows.Forms.BindingSource(this.components);
      this.cities10000DataSet = new MainDemo.cities10000DataSet();
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
      this.citiesTop100TableAdapter = new MainDemo.cities10000DataSetTableAdapters.CitiesTop100TableAdapter();
      this.tableAdapterManager = new MainDemo.cities10000DataSetTableAdapters.TableAdapterManager();
      this.citiesTop100BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
      this.citiesTop100BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.cities1000SmallTableAdapter = new MainDemo.cities10000DataSetTableAdapters.Cities1000SmallTableAdapter();
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.citiesBSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cities10000DataSet)).BeginInit();
      this.tabPage1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.citiesTop100BindingNavigator)).BeginInit();
      this.citiesTop100BindingNavigator.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBox1.Location = new System.Drawing.Point(3, 3);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(761, 562);
      this.textBox1.TabIndex = 0;
      this.textBox1.Text = resources.GetString("textBox1.Text");
      // 
      // dataGrid1
      // 
      this.dataGrid1.AllowedOperations.AddRecord = false;
      this.dataGrid1.AllowedOperations.ChangeRecord = false;
      this.dataGrid1.AllowedOperations.DeleteRecord = false;
      this.dataGrid1.AutoGenerateColumns = true;
      this.dataGrid1.DataSource = this.citiesBSource;
      this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // 
      // 
      this.dataGrid1.EmptyDataInfo.Text = null;
      this.dataGrid1.GridState = EhLib.WinForms.BaseGridState.Normal;
      // 
      // 
      // 
      this.dataGrid1.HorzScrollBar.ExtraBar.Visible = true;
      this.dataGrid1.Location = new System.Drawing.Point(3, 3);
      this.dataGrid1.Name = "dataGrid1";
      this.dataGrid1.Size = new System.Drawing.Size(761, 562);
      this.dataGrid1.TabIndex = 7;
      // 
      // 
      // 
      this.dataGrid1.VertScrollBar.ScrollPosChanged += new System.EventHandler<System.EventArgs>(this.dataGrid1_VertScrollBar_ScrollPosChanged);
      // 
      // citiesBSource
      // 
      this.citiesBSource.DataMember = "Cities1000Small";
      this.citiesBSource.DataSource = this.cities10000DataSet;
      // 
      // cities10000DataSet
      // 
      this.cities10000DataSet.DataSetName = "cities10000DataSet";
      this.cities10000DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // dataGridTextColumn10
      // 
      this.dataGridTextColumn10.DataPropertyName = "Population";
      this.dataGridTextColumn10.Name = "dataGridTextColumn10";
      this.dataGridTextColumn10.Title.Text = "Population";
      // 
      // dataGridTextColumn9
      // 
      this.dataGridTextColumn9.DataPropertyName = "Area";
      this.dataGridTextColumn9.Name = "dataGridTextColumn9";
      this.dataGridTextColumn9.Title.Text = "Area";
      // 
      // dataGridTextColumn8
      // 
      this.dataGridTextColumn8.DataPropertyName = "Continent";
      this.dataGridTextColumn8.Name = "dataGridTextColumn8";
      this.dataGridTextColumn8.Title.Text = "Continent";
      this.dataGridTextColumn8.Width = 119;
      // 
      // dataGridTextColumn7
      // 
      this.dataGridTextColumn7.DataPropertyName = "Capital";
      this.dataGridTextColumn7.Name = "dataGridTextColumn7";
      this.dataGridTextColumn7.Title.Text = "Capital";
      this.dataGridTextColumn7.Width = 179;
      // 
      // dataGridTextColumn6
      // 
      this.dataGridTextColumn6.DataPropertyName = "Name";
      this.dataGridTextColumn6.Name = "dataGridTextColumn6";
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
      this.tabPage1.Size = new System.Drawing.Size(767, 568);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Demo";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 61);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(775, 594);
      this.tabControl1.TabIndex = 9;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.textBox1);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(767, 568);
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
      this.label1.Size = new System.Drawing.Size(244, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "DataGridEh Scroll Events";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(775, 36);
      this.panel1.TabIndex = 8;
      // 
      // citiesTop100TableAdapter
      // 
      this.citiesTop100TableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.Cities1000SmallTableAdapter = null;
      this.tableAdapterManager.CitiesTop100TableAdapter = this.citiesTop100TableAdapter;
      this.tableAdapterManager.UpdateOrder = MainDemo.cities10000DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // citiesTop100BindingNavigator
      // 
      this.citiesTop100BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.citiesTop100BindingNavigator.BindingSource = this.citiesBSource;
      this.citiesTop100BindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.citiesTop100BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.citiesTop100BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.citiesTop100BindingNavigatorSaveItem});
      this.citiesTop100BindingNavigator.Location = new System.Drawing.Point(0, 36);
      this.citiesTop100BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.citiesTop100BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.citiesTop100BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.citiesTop100BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.citiesTop100BindingNavigator.Name = "citiesTop100BindingNavigator";
      this.citiesTop100BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.citiesTop100BindingNavigator.Size = new System.Drawing.Size(775, 25);
      this.citiesTop100BindingNavigator.TabIndex = 10;
      this.citiesTop100BindingNavigator.Text = "bindingNavigator1";
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
      // citiesTop100BindingNavigatorSaveItem
      // 
      this.citiesTop100BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.citiesTop100BindingNavigatorSaveItem.Enabled = false;
      this.citiesTop100BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("citiesTop100BindingNavigatorSaveItem.Image")));
      this.citiesTop100BindingNavigatorSaveItem.Name = "citiesTop100BindingNavigatorSaveItem";
      this.citiesTop100BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
      this.citiesTop100BindingNavigatorSaveItem.Text = "Save Data";
      this.citiesTop100BindingNavigatorSaveItem.Click += new System.EventHandler(this.citiesTop100BindingNavigatorSaveItem_Click);
      // 
      // cities1000SmallTableAdapter
      // 
      this.cities1000SmallTableAdapter.ClearBeforeFill = true;
      // 
      // FrameSolDataGridAutoDataLoad
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.citiesTop100BindingNavigator);
      this.Controls.Add(this.panel1);
      this.Name = "FrameSolDataGridAutoDataLoad";
      this.Size = new System.Drawing.Size(775, 655);
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.citiesBSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cities10000DataSet)).EndInit();
      this.tabPage1.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.citiesTop100BindingNavigator)).EndInit();
      this.citiesTop100BindingNavigator.ResumeLayout(false);
      this.citiesTop100BindingNavigator.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

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
    private cities10000DataSet cities10000DataSet;
    private System.Windows.Forms.BindingSource citiesBSource;
    private cities10000DataSetTableAdapters.CitiesTop100TableAdapter citiesTop100TableAdapter;
    private cities10000DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.BindingNavigator citiesTop100BindingNavigator;
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
    private System.Windows.Forms.ToolStripButton citiesTop100BindingNavigatorSaveItem;
    private cities10000DataSetTableAdapters.Cities1000SmallTableAdapter cities1000SmallTableAdapter;
  }
}
