namespace MainDemo
{
  partial class FramePolyCellColumn
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FramePolyCellColumn));
      this.northwindDataSet = new MainDemo.NorthwindDataSet();
      this.bsPolyCellColumnTable = new System.Windows.Forms.BindingSource(this.components);
      this.dataGridTextColumn1 = new EhLib.WinForms.DataGridTextColumn();
      this.textDataCell1 = new EhLib.WinForms.TextDataCellManager();
      this.checkBoxDataCell1 = new EhLib.WinForms.CheckBoxDataCellManager();
      this.comboBoxDataCell1 = new EhLib.WinForms.ComboBoxDataCellManager();
      this.imageDataCell1 = new EhLib.WinForms.ImageDataCellManager();
      this.progressBarDataCell1 = new EhLib.WinForms.ProgressBarDataCellManager();
      this.buttonDataCell1 = new EhLib.WinForms.ButtonDataCellManager();
      this.dataGridTextColumn3 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGrid1 = new EhLib.WinForms.DataGridEh();
      this.dataGridDynaCellColumn1 = new EhLib.WinForms.DataGridColumn();
      this.maskedTextDataCell1 = new EhLib.WinForms.MaskedTextDataCellManager();
      this.radioButtonDataCell1 = new EhLib.WinForms.RadioButtonDataCellManager();
      this.dateTimeDataCell1 = new EhLib.WinForms.DateTimeDataCellManager();
      this.blankDataCell1 = new EhLib.WinForms.BlankDataCellManager();
      this.dataGridTextColumn2 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn4 = new EhLib.WinForms.DataGridTextColumn();
      this.polyCellColumnTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
      this.polyCellColumnTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsPolyCellColumnTable)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.polyCellColumnTableBindingNavigator)).BeginInit();
      this.polyCellColumnTableBindingNavigator.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // northwindDataSet
      // 
      this.northwindDataSet.DataSetName = "NorthwindDataSet";
      this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // bsPolyCellColumnTable
      // 
      this.bsPolyCellColumnTable.DataMember = "PolyCellColumnTable";
      this.bsPolyCellColumnTable.DataSource = this.northwindDataSet;
      // 
      // dataGridTextColumn1
      // 
      this.dataGridTextColumn1.BackColor = System.Drawing.SystemColors.Window;
      this.dataGridTextColumn1.DataPropertyName = "Caption";
      this.dataGridTextColumn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataGridTextColumn1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataGridTextColumn1.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.dataGridTextColumn1.Name = "dataGridTextColumn1";
      this.dataGridTextColumn1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
      // 
      // dataGridTextColumn1.Title
      // 
      this.dataGridTextColumn1.Title.Text = "Caption";
      this.dataGridTextColumn1.VertAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Top;
      this.dataGridTextColumn1.Width = 213;
      // 
      // textDataCell1
      // 
      this.textDataCell1.HeightOptions.AutoExpand = false;
      // 
      // checkBoxDataCell1
      // 
      this.checkBoxDataCell1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.checkBoxDataCell1.HeightOptions.AutoExpand = false;
      // 
      // comboBoxDataCell1
      // 
      this.comboBoxDataCell1.HeightOptions.AutoExpand = false;
      this.comboBoxDataCell1.Items.AddRange(new object[] {
            "Yes",
            "No"});
      // 
      // progressBarDataCell1
      // 
      this.progressBarDataCell1.HeightOptions.AutoExpand = false;
      // 
      // buttonDataCell1
      // 
      this.buttonDataCell1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.buttonDataCell1.HeightOptions.AutoExpand = false;
      this.buttonDataCell1.Text = null;
      // 
      // dataGridTextColumn3
      // 
      this.dataGridTextColumn3.BackColor = System.Drawing.SystemColors.Window;
      this.dataGridTextColumn3.DataPropertyName = "ValueType";
      this.dataGridTextColumn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataGridTextColumn3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataGridTextColumn3.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.dataGridTextColumn3.Name = "dataGridTextColumn3";
      this.dataGridTextColumn3.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
      // 
      // dataGridTextColumn3.Title
      // 
      this.dataGridTextColumn3.Title.Text = "ValueType";
      this.dataGridTextColumn3.VertAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Top;
      this.dataGridTextColumn3.DataValuePull += new System.EventHandler<EhLib.WinForms.DataGridDataValuePullEventArgs>(this.dataGridTextColumn3_DataCellValuePull);
      // 
      // dataGrid1
      // 
      this.dataGrid1.ColumnOptions.CacheDisplayValues = false;
      this.dataGrid1.ColumnOptions.EditItemOptions.PaintBackgroundTime = EhLib.WinForms.DataGridCellItemPaintTime.Always;
      this.dataGrid1.DataSource = this.bsPolyCellColumnTable;
      this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // 
      // 
      this.dataGrid1.EmptyDataInfo.Text = null;
      this.dataGrid1.Location = new System.Drawing.Point(0, 61);
      this.dataGrid1.Name = "dataGrid1";
      this.dataGrid1.RowOptions.HeightOptions.AutoExpand = true;
      this.dataGrid1.Size = new System.Drawing.Size(674, 542);
      this.dataGrid1.StaticColumns.AddRange(new EhLib.WinForms.PropertyAxisBar[] {
            this.dataGridTextColumn1,
            this.dataGridDynaCellColumn1,
            this.dataGridTextColumn2,
            this.dataGridTextColumn3,
            this.dataGridTextColumn4});
      this.dataGrid1.TabIndex = 3;
      this.dataGrid1.Text = "dataGrid1";
      this.dataGrid1.BindingContextChanged += new System.EventHandler(this.dataGrid1_BindingContextChanged);
      this.dataGrid1.Click += new System.EventHandler(this.dataGrid1_Click);
      // 
      // dataGridDynaCellColumn1
      // 
      this.dataGridDynaCellColumn1.BackColor = System.Drawing.SystemColors.Window;
      this.dataGridDynaCellColumn1.DataPropertyName = "Value";
      this.dataGridDynaCellColumn1.ExtraCellManagers.Add(this.textDataCell1);
      this.dataGridDynaCellColumn1.ExtraCellManagers.Add(this.checkBoxDataCell1);
      this.dataGridDynaCellColumn1.ExtraCellManagers.Add(this.comboBoxDataCell1);
      this.dataGridDynaCellColumn1.ExtraCellManagers.Add(this.imageDataCell1);
      this.dataGridDynaCellColumn1.ExtraCellManagers.Add(this.progressBarDataCell1);
      this.dataGridDynaCellColumn1.ExtraCellManagers.Add(this.buttonDataCell1);
      this.dataGridDynaCellColumn1.ExtraCellManagers.Add(this.maskedTextDataCell1);
      this.dataGridDynaCellColumn1.ExtraCellManagers.Add(this.radioButtonDataCell1);
      this.dataGridDynaCellColumn1.ExtraCellManagers.Add(this.dateTimeDataCell1);
      this.dataGridDynaCellColumn1.ExtraCellManagers.Add(this.blankDataCell1);
      this.dataGridDynaCellColumn1.Name = "dataGridDynaCellColumn1";
      // 
      // dataGridDynaCellColumn1.Title
      // 
      this.dataGridDynaCellColumn1.Title.Text = "Value";
      this.dataGridDynaCellColumn1.DataCellManagerNeeded += new System.EventHandler<EhLib.WinForms.DataGridDataCellManagerNeededEventArgs>(this.dataGridDynaCellColumn1_QueryDataCellObject);
      // 
      // maskedTextDataCell1
      // 
      this.maskedTextDataCell1.Mask = "00:00";
      // 
      // dataGridTextColumn2
      // 
      this.dataGridTextColumn2.BackColor = System.Drawing.SystemColors.Window;
      this.dataGridTextColumn2.DataPropertyName = "Value";
      this.dataGridTextColumn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataGridTextColumn2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataGridTextColumn2.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.dataGridTextColumn2.Name = "dataGridTextColumn2";
      this.dataGridTextColumn2.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
      // 
      // dataGridTextColumn2.Title
      // 
      this.dataGridTextColumn2.Title.Text = "Value as String";
      this.dataGridTextColumn2.VertAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Top;
      this.dataGridTextColumn2.Width = 136;
      this.dataGridTextColumn2.DataValuePush += new System.EventHandler<EhLib.WinForms.DataGridDataValuePushEventArgs>(this.dataGridTextColumn2_DataCellValuePush);
      // 
      // dataGridTextColumn4
      // 
      this.dataGridTextColumn4.BackColor = System.Drawing.SystemColors.Window;
      this.dataGridTextColumn4.DataPropertyName = "RefCellObject";
      this.dataGridTextColumn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataGridTextColumn4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.dataGridTextColumn4.HorzAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.dataGridTextColumn4.Name = "dataGridTextColumn4";
      this.dataGridTextColumn4.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
      // 
      // dataGridTextColumn4.Title
      // 
      this.dataGridTextColumn4.Title.Text = "RefCellObject";
      this.dataGridTextColumn4.VertAlign = System.Windows.Forms.VisualStyles.VerticalAlignment.Top;
      this.dataGridTextColumn4.Width = 83;
      // 
      // polyCellColumnTableBindingNavigator
      // 
      this.polyCellColumnTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.polyCellColumnTableBindingNavigator.BindingSource = this.bsPolyCellColumnTable;
      this.polyCellColumnTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.polyCellColumnTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.polyCellColumnTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.polyCellColumnTableBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripButton1});
      this.polyCellColumnTableBindingNavigator.Location = new System.Drawing.Point(0, 36);
      this.polyCellColumnTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.polyCellColumnTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.polyCellColumnTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.polyCellColumnTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.polyCellColumnTableBindingNavigator.Name = "polyCellColumnTableBindingNavigator";
      this.polyCellColumnTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.polyCellColumnTableBindingNavigator.Size = new System.Drawing.Size(674, 25);
      this.polyCellColumnTableBindingNavigator.TabIndex = 2;
      this.polyCellColumnTableBindingNavigator.Text = "bindingNavigator1";
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
      this.bindingNavigatorPositionItem.Click += new System.EventHandler(this.bindingNavigatorPositionItem_Click);
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
      // polyCellColumnTableBindingNavigatorSaveItem
      // 
      this.polyCellColumnTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.polyCellColumnTableBindingNavigatorSaveItem.Enabled = false;
      this.polyCellColumnTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("polyCellColumnTableBindingNavigatorSaveItem.Image")));
      this.polyCellColumnTableBindingNavigatorSaveItem.Name = "polyCellColumnTableBindingNavigatorSaveItem";
      this.polyCellColumnTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
      this.polyCellColumnTableBindingNavigatorSaveItem.Text = "Save Data";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // toolStripButton1
      // 
      this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
      this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton1.Name = "toolStripButton1";
      this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
      this.toolStripButton1.Text = "toolStripButton1";
      this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(674, 36);
      this.panel1.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(32, 6);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(254, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "Different editors in column";
      // 
      // FramePolyCellColumn
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.dataGrid1);
      this.Controls.Add(this.polyCellColumnTableBindingNavigator);
      this.Controls.Add(this.panel1);
      this.Name = "FramePolyCellColumn";
      this.Size = new System.Drawing.Size(674, 603);
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsPolyCellColumnTable)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.polyCellColumnTableBindingNavigator)).EndInit();
      this.polyCellColumnTableBindingNavigator.ResumeLayout(false);
      this.polyCellColumnTableBindingNavigator.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private NorthwindDataSet northwindDataSet;
    private System.Windows.Forms.BindingSource bsPolyCellColumnTable;
    private System.Windows.Forms.BindingNavigator polyCellColumnTableBindingNavigator;
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
    private System.Windows.Forms.ToolStripButton polyCellColumnTableBindingNavigatorSaveItem;
    private EhLib.WinForms.DataGridEh dataGrid1;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn1;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn2;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn3;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn4;
    private EhLib.WinForms.DataGridColumn dataGridDynaCellColumn1;
    private EhLib.WinForms.TextDataCellManager textDataCell1;
    private EhLib.WinForms.CheckBoxDataCellManager checkBoxDataCell1;
    private EhLib.WinForms.ComboBoxDataCellManager comboBoxDataCell1;
    private EhLib.WinForms.ImageDataCellManager imageDataCell1;
    private EhLib.WinForms.ProgressBarDataCellManager progressBarDataCell1;
    private EhLib.WinForms.ButtonDataCellManager buttonDataCell1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton toolStripButton1;
    private EhLib.WinForms.MaskedTextDataCellManager maskedTextDataCell1;
    private EhLib.WinForms.RadioButtonDataCellManager radioButtonDataCell1;
    private EhLib.WinForms.DateTimeDataCellManager dateTimeDataCell1;
    private EhLib.WinForms.BlankDataCellManager blankDataCell1;
  }
}
