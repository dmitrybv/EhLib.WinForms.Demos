namespace MainDemo
{
  partial class FramePlanner
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
      this.button2 = new System.Windows.Forms.Button();
      this.bHd2 = new System.Windows.Forms.Button();
      this.bHd1 = new System.Windows.Forms.Button();
      this.bDay = new System.Windows.Forms.Button();
      this.bHh2 = new System.Windows.Forms.Button();
      this.bWeek = new System.Windows.Forms.Button();
      this.bHh1 = new System.Windows.Forms.Button();
      this.bMonth = new System.Windows.Forms.Button();
      this.bVD2 = new System.Windows.Forms.Button();
      this.bYear = new System.Windows.Forms.Button();
      this.bVd1 = new System.Windows.Forms.Button();
      this.bVh1 = new System.Windows.Forms.Button();
      this.bVh2 = new System.Windows.Forms.Button();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.splitContainer2 = new System.Windows.Forms.SplitContainer();
      this.plannerCalendarPickerEh1 = new EhLib.WinForms.PlannerCalendarPickerEh();
      this.plannerControlEh1 = new EhLib.WinForms.PlannerControlEh();
      this.plannerDataSourceEh1 = new EhLib.WinForms.PlannerDataSourceEh();
      this.plannerDayViewEh1 = new EhLib.WinForms.PlannerDayViewEh();
      this.plannerWeekViewEh1 = new EhLib.WinForms.PlannerWeekViewEh();
      this.plannerMonthViewEh1 = new EhLib.WinForms.PlannerMonthViewEh();
      this.plannerHorzYearViewEh1 = new EhLib.WinForms.PlannerHorzYearViewEh();
      this.plannerVertHoursLineViewEh1 = new EhLib.WinForms.PlannerVertHoursLineViewEh();
      this.plannerVertDaysLineViewEh1 = new EhLib.WinForms.PlannerVertDaysLineViewEh();
      this.plannerHorzHoursLineViewEh1 = new EhLib.WinForms.PlannerHorzHoursLineViewEh();
      this.plannerHorzDaysLineViewEh1 = new EhLib.WinForms.PlannerHorzDaysLineViewEh();
      this.gridResources = new EhLib.WinForms.DataGridEh();
      this.plannerResourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.biolifeDataSet = new MainDemo.BiolifeDataSet();
      this.resIDCol = new EhLib.WinForms.DataGridTextColumn();
      this.resNameCol = new EhLib.WinForms.DataGridTextColumn();
      this.plannerResourcesTableAdapter = new MainDemo.BiolifeDataSetTableAdapters.PlannerResourcesTableAdapter();
      this.tableAdapterManager = new MainDemo.BiolifeDataSetTableAdapters.TableAdapterManager();
      this.plannerDataTableAdapter = new MainDemo.BiolifeDataSetTableAdapters.PlannerDataTableAdapter();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      this.plannerControlEh1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.plannerDayViewEh1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.plannerWeekViewEh1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.plannerMonthViewEh1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.plannerHorzYearViewEh1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.plannerVertHoursLineViewEh1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.plannerVertDaysLineViewEh1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.plannerHorzHoursLineViewEh1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.plannerHorzDaysLineViewEh1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridResources)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.plannerResourcesBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.biolifeDataSet)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.button2);
      this.panel1.Controls.Add(this.bHd2);
      this.panel1.Controls.Add(this.bHd1);
      this.panel1.Controls.Add(this.bDay);
      this.panel1.Controls.Add(this.bHh2);
      this.panel1.Controls.Add(this.bWeek);
      this.panel1.Controls.Add(this.bHh1);
      this.panel1.Controls.Add(this.bMonth);
      this.panel1.Controls.Add(this.bVD2);
      this.panel1.Controls.Add(this.bYear);
      this.panel1.Controls.Add(this.bVd1);
      this.panel1.Controls.Add(this.bVh1);
      this.panel1.Controls.Add(this.bVh2);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(870, 62);
      this.panel1.TabIndex = 16;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(20, 14);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(179, 36);
      this.button2.TabIndex = 15;
      this.button2.Text = "FillData";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // bHd2
      // 
      this.bHd2.Location = new System.Drawing.Point(767, 14);
      this.bHd2.Name = "bHd2";
      this.bHd2.Size = new System.Drawing.Size(48, 36);
      this.bHd2.TabIndex = 14;
      this.bHd2.Text = "HD2";
      this.bHd2.UseVisualStyleBackColor = true;
      this.bHd2.Click += new System.EventHandler(this.bDay_Click);
      // 
      // bHd1
      // 
      this.bHd1.Location = new System.Drawing.Point(720, 14);
      this.bHd1.Name = "bHd1";
      this.bHd1.Size = new System.Drawing.Size(48, 36);
      this.bHd1.TabIndex = 13;
      this.bHd1.Text = "HD1";
      this.bHd1.UseVisualStyleBackColor = true;
      this.bHd1.Click += new System.EventHandler(this.bDay_Click);
      // 
      // bDay
      // 
      this.bDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.bDay.Location = new System.Drawing.Point(216, 14);
      this.bDay.Name = "bDay";
      this.bDay.Size = new System.Drawing.Size(48, 36);
      this.bDay.TabIndex = 2;
      this.bDay.Text = "Day";
      this.bDay.UseVisualStyleBackColor = true;
      this.bDay.Click += new System.EventHandler(this.bDay_Click);
      // 
      // bHh2
      // 
      this.bHh2.Location = new System.Drawing.Point(673, 14);
      this.bHh2.Name = "bHh2";
      this.bHh2.Size = new System.Drawing.Size(48, 36);
      this.bHh2.TabIndex = 12;
      this.bHh2.Text = "HH2";
      this.bHh2.UseVisualStyleBackColor = true;
      this.bHh2.Click += new System.EventHandler(this.bDay_Click);
      // 
      // bWeek
      // 
      this.bWeek.Location = new System.Drawing.Point(263, 14);
      this.bWeek.Name = "bWeek";
      this.bWeek.Size = new System.Drawing.Size(48, 36);
      this.bWeek.TabIndex = 3;
      this.bWeek.Text = "Week";
      this.bWeek.UseVisualStyleBackColor = true;
      this.bWeek.Click += new System.EventHandler(this.bDay_Click);
      // 
      // bHh1
      // 
      this.bHh1.Location = new System.Drawing.Point(626, 14);
      this.bHh1.Name = "bHh1";
      this.bHh1.Size = new System.Drawing.Size(48, 36);
      this.bHh1.TabIndex = 11;
      this.bHh1.Text = "HH1";
      this.bHh1.UseVisualStyleBackColor = true;
      this.bHh1.Click += new System.EventHandler(this.bDay_Click);
      // 
      // bMonth
      // 
      this.bMonth.Location = new System.Drawing.Point(310, 14);
      this.bMonth.Name = "bMonth";
      this.bMonth.Size = new System.Drawing.Size(51, 36);
      this.bMonth.TabIndex = 4;
      this.bMonth.Text = "Month";
      this.bMonth.UseVisualStyleBackColor = true;
      this.bMonth.Click += new System.EventHandler(this.bDay_Click);
      // 
      // bVD2
      // 
      this.bVD2.Location = new System.Drawing.Point(561, 14);
      this.bVD2.Name = "bVD2";
      this.bVD2.Size = new System.Drawing.Size(48, 36);
      this.bVD2.TabIndex = 10;
      this.bVD2.Text = "VD2";
      this.bVD2.UseVisualStyleBackColor = true;
      this.bVD2.Click += new System.EventHandler(this.bDay_Click);
      // 
      // bYear
      // 
      this.bYear.Location = new System.Drawing.Point(360, 14);
      this.bYear.Name = "bYear";
      this.bYear.Size = new System.Drawing.Size(48, 36);
      this.bYear.TabIndex = 6;
      this.bYear.Text = "Year";
      this.bYear.UseVisualStyleBackColor = true;
      this.bYear.Click += new System.EventHandler(this.bDay_Click);
      // 
      // bVd1
      // 
      this.bVd1.Location = new System.Drawing.Point(514, 14);
      this.bVd1.Name = "bVd1";
      this.bVd1.Size = new System.Drawing.Size(48, 36);
      this.bVd1.TabIndex = 9;
      this.bVd1.Text = "VD1";
      this.bVd1.UseVisualStyleBackColor = true;
      this.bVd1.Click += new System.EventHandler(this.bDay_Click);
      // 
      // bVh1
      // 
      this.bVh1.Location = new System.Drawing.Point(420, 14);
      this.bVh1.Name = "bVh1";
      this.bVh1.Size = new System.Drawing.Size(48, 36);
      this.bVh1.TabIndex = 7;
      this.bVh1.Text = "VH1";
      this.bVh1.UseVisualStyleBackColor = true;
      this.bVh1.Click += new System.EventHandler(this.bDay_Click);
      // 
      // bVh2
      // 
      this.bVh2.Location = new System.Drawing.Point(467, 14);
      this.bVh2.Name = "bVh2";
      this.bVh2.Size = new System.Drawing.Size(48, 36);
      this.bVh2.TabIndex = 8;
      this.bVh2.Text = "VH2";
      this.bVh2.UseVisualStyleBackColor = true;
      this.bVh2.Click += new System.EventHandler(this.bDay_Click);
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.splitContainer1.Location = new System.Drawing.Point(0, 62);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.plannerControlEh1);
      this.splitContainer1.Size = new System.Drawing.Size(870, 581);
      this.splitContainer1.SplitterDistance = 242;
      this.splitContainer1.SplitterWidth = 10;
      this.splitContainer1.TabIndex = 17;
      // 
      // splitContainer2
      // 
      this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.splitContainer2.Location = new System.Drawing.Point(0, 0);
      this.splitContainer2.Name = "splitContainer2";
      this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer2.Panel1
      // 
      this.splitContainer2.Panel1.Controls.Add(this.plannerCalendarPickerEh1);
      // 
      // splitContainer2.Panel2
      // 
      this.splitContainer2.Panel2.Controls.Add(this.gridResources);
      this.splitContainer2.Size = new System.Drawing.Size(242, 581);
      this.splitContainer2.SplitterDistance = 253;
      this.splitContainer2.SplitterWidth = 10;
      this.splitContainer2.TabIndex = 0;
      // 
      // plannerCalendarPickerEh1
      // 
      this.plannerCalendarPickerEh1.BackColor = System.Drawing.SystemColors.Window;
      this.plannerCalendarPickerEh1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.plannerCalendarPickerEh1.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.plannerCalendarPickerEh1.Location = new System.Drawing.Point(0, 0);
      this.plannerCalendarPickerEh1.Name = "plannerCalendarPickerEh1";
      this.plannerCalendarPickerEh1.PlannerControl = this.plannerControlEh1;
      this.plannerCalendarPickerEh1.Size = new System.Drawing.Size(242, 253);
      this.plannerCalendarPickerEh1.TabIndex = 0;
      this.plannerCalendarPickerEh1.Text = "plannerCalendarPickerEh1";
      // 
      // plannerControlEh1
      // 
      this.plannerControlEh1.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.plannerControlEh1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.plannerControlEh1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.plannerControlEh1.Location = new System.Drawing.Point(0, 0);
      this.plannerControlEh1.Name = "plannerControlEh1";
      this.plannerControlEh1.PlannerDataSource = this.plannerDataSourceEh1;
      this.plannerControlEh1.PlannerViews.Add(this.plannerDayViewEh1);
      this.plannerControlEh1.PlannerViews.Add(this.plannerWeekViewEh1);
      this.plannerControlEh1.PlannerViews.Add(this.plannerMonthViewEh1);
      this.plannerControlEh1.PlannerViews.Add(this.plannerHorzYearViewEh1);
      this.plannerControlEh1.PlannerViews.Add(this.plannerVertHoursLineViewEh1);
      this.plannerControlEh1.PlannerViews.Add(this.plannerVertDaysLineViewEh1);
      this.plannerControlEh1.PlannerViews.Add(this.plannerHorzHoursLineViewEh1);
      this.plannerControlEh1.PlannerViews.Add(this.plannerHorzDaysLineViewEh1);
      this.plannerControlEh1.Size = new System.Drawing.Size(618, 581);
      this.plannerControlEh1.TabIndex = 0;
      this.plannerControlEh1.TimeSpanOptions.BorderColor = System.Drawing.Color.Empty;
      // 
      // plannerDayViewEh1
      // 
      this.plannerDayViewEh1.Name = "plannerDayViewEh1";
      // 
      // plannerWeekViewEh1
      // 
      this.plannerWeekViewEh1.Name = "plannerWeekViewEh1";
      // 
      // plannerMonthViewEh1
      // 
      this.plannerMonthViewEh1.Name = "plannerMonthViewEh1";
      // 
      // plannerHorzYearViewEh1
      // 
      this.plannerHorzYearViewEh1.Name = "plannerHorzYearViewEh1";
      // 
      // plannerVertHoursLineViewEh1
      // 
      this.plannerVertHoursLineViewEh1.Name = "plannerVertHoursLineViewEh1";
      // 
      // plannerVertDaysLineViewEh1
      // 
      this.plannerVertDaysLineViewEh1.Name = "plannerVertDaysLineViewEh1";
      // 
      // plannerHorzHoursLineViewEh1
      // 
      this.plannerHorzHoursLineViewEh1.Name = "plannerHorzHoursLineViewEh1";
      // 
      // plannerHorzDaysLineViewEh1
      // 
      this.plannerHorzDaysLineViewEh1.Name = "plannerHorzDaysLineViewEh1";
      // 
      // gridResources
      // 
      this.gridResources.AutoSizeColumnOptions.FitToClient = true;
      this.gridResources.DataMember = "";
      this.gridResources.DataSource = this.plannerResourcesBindingSource;
      this.gridResources.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // gridResources.IndicatorColumn
      // 
      this.gridResources.IndicatorColumn.ShowRecNo = false;
      this.gridResources.IndicatorColumn.ShowRowIndicator = false;
      this.gridResources.IndicatorColumn.ShowRowselCheckboxes = true;
      this.gridResources.Location = new System.Drawing.Point(0, 0);
      this.gridResources.Name = "gridResources";
      this.gridResources.Size = new System.Drawing.Size(242, 318);
      this.gridResources.StaticColumns.AddRange(new EhLib.WinForms.PropertyAxisBar[] {
            this.resIDCol,
            this.resNameCol});
      this.gridResources.TabIndex = 1;
      // 
      // plannerResourcesBindingSource
      // 
      this.plannerResourcesBindingSource.DataMember = "PlannerResources";
      this.plannerResourcesBindingSource.DataSource = this.biolifeDataSet;
      // 
      // biolifeDataSet
      // 
      this.biolifeDataSet.DataSetName = "BiolifeDataSet";
      this.biolifeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // resIDCol
      // 
      this.resIDCol.DataPropertyName = "ID";
      this.resIDCol.FillWeight = 32F;
      this.resIDCol.Name = "resIDCol";
      // 
      // resIDCol.Title
      // 
      this.resIDCol.Title.Text = "ID";
      this.resIDCol.Width = 32;
      // 
      // resNameCol
      // 
      this.resNameCol.DataPropertyName = "ResName";
      this.resNameCol.FillWeight = 189F;
      this.resNameCol.Name = "resNameCol";
      // 
      // resNameCol.Title
      // 
      this.resNameCol.Title.Text = "ResName";
      this.resNameCol.Width = 189;
      // 
      // plannerResourcesTableAdapter
      // 
      this.plannerResourcesTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.BiolifeTableAdapter = null;
      this.tableAdapterManager.countryTableAdapter = null;
      this.tableAdapterManager.PlannerDataTableAdapter = null;
      this.tableAdapterManager.PlannerResourcesTableAdapter = this.plannerResourcesTableAdapter;
      this.tableAdapterManager.TestTreeTableAdapter = null;
      this.tableAdapterManager.UpdateOrder = MainDemo.BiolifeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // plannerDataTableAdapter
      // 
      this.plannerDataTableAdapter.ClearBeforeFill = true;
      // 
      // FramePlanner
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.panel1);
      this.Name = "FramePlanner";
      this.Size = new System.Drawing.Size(870, 643);
      this.Load += new System.EventHandler(this.FramePlanner_Load);
      this.panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
      this.splitContainer2.ResumeLayout(false);
      this.plannerControlEh1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.plannerDayViewEh1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.plannerWeekViewEh1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.plannerMonthViewEh1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.plannerHorzYearViewEh1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.plannerVertHoursLineViewEh1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.plannerVertDaysLineViewEh1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.plannerHorzHoursLineViewEh1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.plannerHorzDaysLineViewEh1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridResources)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.plannerResourcesBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.biolifeDataSet)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bHd2;
        private System.Windows.Forms.Button bHd1;
        private System.Windows.Forms.Button bDay;
        private System.Windows.Forms.Button bHh2;
        private System.Windows.Forms.Button bWeek;
        private System.Windows.Forms.Button bHh1;
        private System.Windows.Forms.Button bMonth;
        private System.Windows.Forms.Button bVD2;
        private System.Windows.Forms.Button bYear;
        private System.Windows.Forms.Button bVd1;
        private System.Windows.Forms.Button bVh1;
        private System.Windows.Forms.Button bVh2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private EhLib.WinForms.PlannerCalendarPickerEh plannerCalendarPickerEh1;
        private EhLib.WinForms.DataGridEh gridResources;
        private EhLib.WinForms.DataGridTextColumn resIDCol;
        private EhLib.WinForms.DataGridTextColumn resNameCol;
        private EhLib.WinForms.PlannerControlEh plannerControlEh1;
        private EhLib.WinForms.PlannerDataSourceEh plannerDataSourceEh1;
        private EhLib.WinForms.PlannerDayViewEh plannerDayViewEh1;
        private EhLib.WinForms.PlannerWeekViewEh plannerWeekViewEh1;
        private EhLib.WinForms.PlannerMonthViewEh plannerMonthViewEh1;
    private EhLib.WinForms.PlannerVertHoursLineViewEh plannerVertHoursLineViewEh1;
    private EhLib.WinForms.PlannerVertDaysLineViewEh plannerVertDaysLineViewEh1;
    private EhLib.WinForms.PlannerHorzHoursLineViewEh plannerHorzHoursLineViewEh1;
    private EhLib.WinForms.PlannerHorzDaysLineViewEh plannerHorzDaysLineViewEh1;
    private EhLib.WinForms.PlannerHorzYearViewEh plannerHorzYearViewEh1;
    private System.Windows.Forms.BindingSource plannerResourcesBindingSource;
    private BiolifeDataSet biolifeDataSet;
    private BiolifeDataSetTableAdapters.PlannerResourcesTableAdapter plannerResourcesTableAdapter;
    private BiolifeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private BiolifeDataSetTableAdapters.PlannerDataTableAdapter plannerDataTableAdapter;
  }
}
