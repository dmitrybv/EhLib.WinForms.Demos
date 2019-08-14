namespace ProcessList
{
  partial class FormProcessList
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
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.panel2 = new System.Windows.Forms.Panel();
      this.numericBoxEh1 = new EhLib.WinForms.NumericBoxEh();
      this.boundLabel1 = new EhLib.WinForms.BoundLabel();
      this.inEditUpDownButton1 = new EhLib.WinForms.InEditUpDownButton();
      this.bStartStopAutoUpdate = new System.Windows.Forms.Button();
      this.bsProcessList = new System.Windows.Forms.BindingSource(this.components);
      this.gridProcessList = new EhLib.WinForms.DataGridEh();
      this.colDisplayName = new EhLib.WinForms.DataGridTextColumn();
      this.colCPUUsage = new EhLib.WinForms.DataGridTextColumn();
      this.colMemUsage = new EhLib.WinForms.DataGridTextColumn();
      this.colPID = new EhLib.WinForms.DataGridTextColumn();
      this.colProcessType = new EhLib.WinForms.DataGridTextColumn();
      this.colPath = new EhLib.WinForms.DataGridTextColumn();
      this.colProcessUser = new EhLib.WinForms.DataGridTextColumn();
      this.colStatus = new EhLib.WinForms.DataGridTextColumn();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericBoxEh1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsProcessList)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridProcessList)).BeginInit();
      this.SuspendLayout();
      // 
      // timer1
      // 
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.numericBoxEh1);
      this.panel2.Controls.Add(this.boundLabel1);
      this.panel2.Controls.Add(this.bStartStopAutoUpdate);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(814, 45);
      this.panel2.TabIndex = 6;
      // 
      // numericBoxEh1
      // 
      this.numericBoxEh1.BoundLabel = this.boundLabel1;
      // 
      // 
      // 
      this.numericBoxEh1.EditButton.Visible = false;
      this.numericBoxEh1.InEditControls.Add(this.inEditUpDownButton1);
      this.numericBoxEh1.Location = new System.Drawing.Point(276, 10);
      this.numericBoxEh1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.numericBoxEh1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericBoxEh1.Name = "numericBoxEh1";
      this.numericBoxEh1.Size = new System.Drawing.Size(100, 20);
      this.numericBoxEh1.TabIndex = 8;
      this.numericBoxEh1.Text = "2";
      this.numericBoxEh1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
      // 
      // boundLabel1
      // 
      this.boundLabel1.AutoSize = true;
      this.boundLabel1.Location = new System.Drawing.Point(202, 13);
      this.boundLabel1.Name = "boundLabel1";
      this.boundLabel1.Position = EhLib.WinForms.LabelPosition.LeftCenter;
      this.boundLabel1.Size = new System.Drawing.Size(71, 13);
      this.boundLabel1.TabIndex = 7;
      this.boundLabel1.Text = "Update every";
      // 
      // bStartStopAutoUpdate
      // 
      this.bStartStopAutoUpdate.Location = new System.Drawing.Point(12, 10);
      this.bStartStopAutoUpdate.Name = "bStartStopAutoUpdate";
      this.bStartStopAutoUpdate.Size = new System.Drawing.Size(159, 23);
      this.bStartStopAutoUpdate.TabIndex = 0;
      this.bStartStopAutoUpdate.Text = "Start autorefresh";
      this.bStartStopAutoUpdate.UseVisualStyleBackColor = true;
      this.bStartStopAutoUpdate.Click += new System.EventHandler(this.BStartStopAutoUpdate_Click);
      // 
      // gridProcessList
      // 
      this.gridProcessList.AutoGenerateColumns = true;
      this.gridProcessList.ColumnOptions.SidePadding = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.gridProcessList.DataSource = this.bsProcessList;
      this.gridProcessList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridProcessList.LineOptions.HorzLines = false;
      this.gridProcessList.Location = new System.Drawing.Point(0, 45);
      this.gridProcessList.Name = "gridProcessList";
      this.gridProcessList.ReadOnly = true;
      // 
      // gridProcessList.SearchBox
      // 
      this.gridProcessList.SearchBox.FilterOnTyping = true;
      this.gridProcessList.Selection.AllowedSelection.All = false;
      this.gridProcessList.Selection.AllowedSelection.Cells = false;
      this.gridProcessList.Selection.AllowedSelection.Columns = false;
      this.gridProcessList.Selection.AllowedSelection.Rows = false;
      this.gridProcessList.Selection.RowHighlight = false;
      this.gridProcessList.Selection.RowSelect = true;
      this.gridProcessList.Size = new System.Drawing.Size(814, 380);
      this.gridProcessList.StaticColumns.AddRange(new EhLib.WinForms.PropertyAxisBar[] {
            this.colDisplayName,
            this.colCPUUsage,
            this.colMemUsage,
            this.colPID,
            this.colProcessType,
            this.colPath,
            this.colProcessUser,
            this.colStatus});
      this.gridProcessList.TabIndex = 7;
      this.gridProcessList.Text = "dataGrid1";
      // 
      // gridProcessList.Title
      // 
      this.gridProcessList.Title.Filter.Active = true;
      this.gridProcessList.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
      this.gridProcessList.Title.HorzLine.Color = System.Drawing.SystemColors.ControlDark;
      this.gridProcessList.Title.HorzLine.Visible = true;
      this.gridProcessList.Title.Padding = new System.Windows.Forms.Padding(4, 20, 3, 4);
      this.gridProcessList.Title.SortMarking.SortMarkable = true;
      this.gridProcessList.Title.InteractiveSortMarkingChanged += new System.EventHandler<EhLib.WinForms.SortMarkingChangedEventArgs>(this.GridProcessList_Title_InteractiveSortMarkingChanged);
      // 
      // colDisplayName
      // 
      this.colDisplayName.DataPropertyName = "DisplayName";
      this.colDisplayName.FormatString = null;
      this.colDisplayName.Name = "colDisplayName";
      // 
      // colDisplayName.Title
      // 
      this.colDisplayName.Title.Text = "Name";
      this.colDisplayName.Width = 226;
      this.colDisplayName.DataCellClientAreaNeeded += new System.EventHandler<EhLib.WinForms.DataGridDataCellClientAreaNeededEventArgs>(this.ColDisplayName_DataCellClientAreaNeeded);
      this.colDisplayName.DataCellCustomAreaPaint += new System.EventHandler<EhLib.WinForms.DataGridDataCellPaintEventArgs>(this.ColDisplayName_DataCellCustomAreaPaint);
      // 
      // colCPUUsage
      // 
      this.colCPUUsage.DataPropertyName = "CpuUsage";
      this.colCPUUsage.FormatString = "0.0%;-0.0%;0%";
      this.colCPUUsage.Name = "colCPUUsage";
      // 
      // colCPUUsage.Title
      // 
      this.colCPUUsage.Title.SortMarking.FirstSortDirection = System.ComponentModel.ListSortDirection.Descending;
      this.colCPUUsage.Title.Text = "CPU";
      this.colCPUUsage.Title.CellPaint += new System.EventHandler<EhLib.WinForms.DataGridTitleCellPaintEventArgs>(this.colCPUUsage_Title_CellPaint);
      this.colCPUUsage.Width = 61;
      // 
      // colMemUsage
      // 
      this.colMemUsage.DataPropertyName = "MemoryUsageAsString";
      this.colMemUsage.FormatString = null;
      this.colMemUsage.HorzAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.colMemUsage.Name = "colMemUsage";
      // 
      // colMemUsage.Title
      // 
      this.colMemUsage.Title.SortMarking.FirstSortDirection = System.ComponentModel.ListSortDirection.Descending;
      this.colMemUsage.Title.Text = "Memory";
      this.colMemUsage.Title.CellPaint += new System.EventHandler<EhLib.WinForms.DataGridTitleCellPaintEventArgs>(this.colMemUsage_Title_CellPaint);
      this.colMemUsage.Width = 89;
      // 
      // colPID
      // 
      this.colPID.DataPropertyName = "ProcessID";
      this.colPID.FormatString = null;
      this.colPID.Name = "colPID";
      // 
      // colPID.Title
      // 
      this.colPID.Title.Text = "PID";
      this.colPID.Width = 77;
      // 
      // colProcessType
      // 
      this.colProcessType.DataPropertyName = "ProcessType";
      this.colProcessType.FormatString = null;
      this.colProcessType.Name = "colProcessType";
      // 
      // colProcessType.Title
      // 
      this.colProcessType.Title.SortMarking.SortMarkable = false;
      this.colProcessType.Title.Text = "Type";
      this.colProcessType.Width = 119;
      // 
      // colPath
      // 
      this.colPath.DataPropertyName = "Path";
      this.colPath.Name = "colPath";
      // 
      // colPath.Title
      // 
      this.colPath.Title.Text = "Path";
      this.colPath.Width = 188;
      // 
      // colProcessUser
      // 
      this.colProcessUser.DataPropertyName = "ProcessUser";
      this.colProcessUser.Name = "colProcessUser";
      // 
      // colProcessUser.Title
      // 
      this.colProcessUser.Title.Text = "ProcessUser";
      this.colProcessUser.Width = 96;
      // 
      // colStatus
      // 
      this.colStatus.DataPropertyName = "Status";
      this.colStatus.Name = "colStatus";
      // 
      // colStatus.Title
      // 
      this.colStatus.Title.Text = "Status";
      this.colStatus.Width = 152;
      // 
      // FormProcessList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(814, 425);
      this.Controls.Add(this.gridProcessList);
      this.Controls.Add(this.panel2);
      this.Name = "FormProcessList";
      this.Text = "Process List";
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericBoxEh1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsProcessList)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridProcessList)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.BindingSource bsProcessList;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button bStartStopAutoUpdate;
    private EhLib.WinForms.NumericBoxEh numericBoxEh1;
    private EhLib.WinForms.BoundLabel boundLabel1;
    private EhLib.WinForms.InEditUpDownButton inEditUpDownButton1;
    private EhLib.WinForms.DataGridEh gridProcessList;
    private EhLib.WinForms.DataGridTextColumn colDisplayName;
    private EhLib.WinForms.DataGridTextColumn colCPUUsage;
    private EhLib.WinForms.DataGridTextColumn colMemUsage;
    private EhLib.WinForms.DataGridTextColumn colPID;
    private EhLib.WinForms.DataGridTextColumn colProcessType;
    private EhLib.WinForms.DataGridTextColumn colPath;
    private EhLib.WinForms.DataGridTextColumn colProcessUser;
    private EhLib.WinForms.DataGridTextColumn colStatus;
  }
}

