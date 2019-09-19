namespace MainDemo
{
  partial class FrameCrossedRadioMatrix
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
      this.baseBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.dataGridEh1 = new EhLib.WinForms.DataGridEh();
      this.dataGridRadioButtonColumn1 = new EhLib.WinForms.DataGridRadioButtonColumn();
      this.dataGridRadioButtonColumn2 = new EhLib.WinForms.DataGridRadioButtonColumn();
      this.dataGridRadioButtonColumn3 = new EhLib.WinForms.DataGridRadioButtonColumn();
      this.dataGridRadioButtonColumn4 = new EhLib.WinForms.DataGridRadioButtonColumn();
      this.dataGridRadioButtonColumn5 = new EhLib.WinForms.DataGridRadioButtonColumn();
      this.gridBaseList = new EhLib.WinForms.DataGridEh();
      ((System.ComponentModel.ISupportInitialize)(this.baseBindingSource)).BeginInit();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridEh1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridBaseList)).BeginInit();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 51);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(840, 479);
      this.tabControl1.TabIndex = 10;
      // 
      // tabPage1
      // 
      this.tabPage1.AutoScroll = true;
      this.tabPage1.Controls.Add(this.dataGridEh1);
      this.tabPage1.Controls.Add(this.gridBaseList);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(832, 453);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Demo";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.richTextBox1);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(832, 453);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Description";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // richTextBox1
      // 
      this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.richTextBox1.Location = new System.Drawing.Point(3, 3);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(826, 447);
      this.richTextBox1.TabIndex = 1;
      this.richTextBox1.Text = "Use RadioButtonColumn and DataGridEh.DataCellManagerNeeded event to make grid loo" +
    "ks like a matrix with radiobuttons and crossed line of blank cells";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(840, 51);
      this.panel1.TabIndex = 11;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(9, 32);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(809, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "RadioButtonColumn and DataGridEh.DataCellManagerNeeded event allows make DataGrid" +
    "Eh looks like a matrix with radiobuttons and diagonal crossed line of blank cell" +
    "s";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(6, 5);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(203, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "Crossed RadioMatrix";
      // 
      // dataGridEh1
      // 
      this.dataGridEh1.AllowedOperations.AddRecord = false;
      this.dataGridEh1.AllowedOperations.DeleteRecord = false;
      this.dataGridEh1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridEh1.ColumnOptions.AllowMoveColumns = false;
      this.dataGridEh1.ColumnOptions.AllowResizeColumns = false;
      this.dataGridEh1.ColumnOptions.AllowShowEditor = false;
      this.dataGridEh1.ColumnOptions.SidePadding = new System.Windows.Forms.Padding(3, 4, 3, 4);
      // 
      // 
      // 
      this.dataGridEh1.IndicatorColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataGridEh1.IndicatorColumn.RecNoShowStep = 1;
      this.dataGridEh1.IndicatorColumn.ShowRowIndicator = false;
      // 
      // 
      // 
      this.dataGridEh1.IndicatorTitle.Pressable = false;
      this.dataGridEh1.IndicatorTitle.ShowDropDownSign = false;
      this.dataGridEh1.IndicatorTitle.UseGlobalMenu = false;
      this.dataGridEh1.Location = new System.Drawing.Point(8, 6);
      this.dataGridEh1.Name = "dataGridEh1";
      this.dataGridEh1.Selection.RowHighlight = false;
      this.dataGridEh1.Size = new System.Drawing.Size(571, 441);
      this.dataGridEh1.StaticColumns.AddRange(new EhLib.WinForms.PropertyAxisBar[] {
            this.dataGridRadioButtonColumn1,
            this.dataGridRadioButtonColumn2,
            this.dataGridRadioButtonColumn3,
            this.dataGridRadioButtonColumn4,
            this.dataGridRadioButtonColumn5});
      this.dataGridEh1.TabIndex = 6;
      // 
      // 
      // 
      this.dataGridEh1.Title.HorzAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.dataGridEh1.Title.Padding = new System.Windows.Forms.Padding(4);
      this.dataGridEh1.DataValuePull += new System.EventHandler<EhLib.WinForms.DataGridDataValuePullEventArgs>(this.dataGridEh1_DataCellValuePull);
      this.dataGridEh1.DataValuePush += new System.EventHandler<EhLib.WinForms.DataGridDataValuePushEventArgs>(this.dataGridEh1_DataCellValuePush);
      this.dataGridEh1.DataCellManagerNeeded += new System.EventHandler<EhLib.WinForms.DataGridDataCellManagerNeededEventArgs>(this.dataGridEh1_DataCellManagerNeeded);
      this.dataGridEh1.DataCellFormatParamsNeeded += new System.EventHandler<EhLib.WinForms.DataGridDataCellFormatParamsNeededEventArgs>(this.dataGridEh1_DataCellFormatParamsNeeded);
      // 
      // dataGridRadioButtonColumn1
      // 
      this.dataGridRadioButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.dataGridRadioButtonColumn1.Name = "dataGridRadioButtonColumn1";
      // 
      // 
      // 
      this.dataGridRadioButtonColumn1.Title.Text = "1";
      this.dataGridRadioButtonColumn1.Title.ToolTipText = null;
      this.dataGridRadioButtonColumn1.Width = 64;
      // 
      // dataGridRadioButtonColumn2
      // 
      this.dataGridRadioButtonColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.dataGridRadioButtonColumn2.Name = "dataGridRadioButtonColumn2";
      // 
      // 
      // 
      this.dataGridRadioButtonColumn2.Title.Text = "2";
      this.dataGridRadioButtonColumn2.Title.ToolTipText = null;
      this.dataGridRadioButtonColumn2.Width = 64;
      // 
      // dataGridRadioButtonColumn3
      // 
      this.dataGridRadioButtonColumn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.dataGridRadioButtonColumn3.Name = "dataGridRadioButtonColumn3";
      // 
      // 
      // 
      this.dataGridRadioButtonColumn3.Title.Text = "3";
      this.dataGridRadioButtonColumn3.Title.ToolTipText = null;
      this.dataGridRadioButtonColumn3.Width = 64;
      // 
      // dataGridRadioButtonColumn4
      // 
      this.dataGridRadioButtonColumn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.dataGridRadioButtonColumn4.Name = "dataGridRadioButtonColumn4";
      // 
      // 
      // 
      this.dataGridRadioButtonColumn4.Title.Text = "4";
      this.dataGridRadioButtonColumn4.Title.ToolTipText = null;
      this.dataGridRadioButtonColumn4.Width = 64;
      // 
      // dataGridRadioButtonColumn5
      // 
      this.dataGridRadioButtonColumn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.dataGridRadioButtonColumn5.Name = "dataGridRadioButtonColumn5";
      // 
      // 
      // 
      this.dataGridRadioButtonColumn5.Title.Text = "5";
      this.dataGridRadioButtonColumn5.Title.ToolTipText = null;
      this.dataGridRadioButtonColumn5.Width = 64;
      // 
      // gridBaseList
      // 
      this.gridBaseList.AllowedOperations.AddRecord = false;
      this.gridBaseList.AllowedOperations.DeleteRecord = false;
      this.gridBaseList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.gridBaseList.AutoSizeColumnOptions.FitToClient = true;
      this.gridBaseList.ColumnOptions.SidePadding = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.gridBaseList.ColumnOptions.WrapMode = EhLib.WinForms.CellTextWrapMode.NoWrap;
      this.gridBaseList.Location = new System.Drawing.Point(585, 6);
      this.gridBaseList.Name = "gridBaseList";
      this.gridBaseList.Selection.RowSelect = true;
      this.gridBaseList.Size = new System.Drawing.Size(241, 441);
      this.gridBaseList.TabIndex = 5;
      // 
      // 
      // 
      this.gridBaseList.Title.HorzAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.gridBaseList.Title.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.gridBaseList.DynamicColumnsCreating += new System.EventHandler<EhLib.WinForms.DataGridDynamicColumnsCreatingEventArgs>(this.gridBaseList_CreatingDynamicColumnsForDataProperty);
      // 
      // FrameCrossedRadioMatrix
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.panel1);
      this.Name = "FrameCrossedRadioMatrix";
      this.Size = new System.Drawing.Size(840, 530);
      ((System.ComponentModel.ISupportInitialize)(this.baseBindingSource)).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridEh1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridBaseList)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.BindingSource baseBindingSource;
    private EhLib.WinForms.DataGridEh gridBaseList;
    private EhLib.WinForms.DataGridEh dataGridEh1;
    private EhLib.WinForms.DataGridRadioButtonColumn dataGridRadioButtonColumn1;
    private EhLib.WinForms.DataGridRadioButtonColumn dataGridRadioButtonColumn2;
    private EhLib.WinForms.DataGridRadioButtonColumn dataGridRadioButtonColumn3;
    private EhLib.WinForms.DataGridRadioButtonColumn dataGridRadioButtonColumn4;
    private EhLib.WinForms.DataGridRadioButtonColumn dataGridRadioButtonColumn5;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.RichTextBox richTextBox1;
  }
}
