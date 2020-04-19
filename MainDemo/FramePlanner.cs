using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EhLib.WinForms;

namespace MainDemo
{
  public partial class FramePlanner : BaseFrame
  {
    public FramePlanner()
    {
      InitializeComponent();

      splitContainer2.SplitterWidth = 10;

      bDay.Tag = new FramePlannerButtonTagData() { PlannerView = plannerDayViewEh1 };
      bWeek.Tag = new FramePlannerButtonTagData() { PlannerView = plannerWeekViewEh1 };
      bMonth.Tag = new FramePlannerButtonTagData() { PlannerView = plannerMonthViewEh1 };
      bYear.Tag = new FramePlannerButtonTagData() { PlannerView = plannerHorzYearViewEh1 };

      // Vert
      bVh1.Tag = new FramePlannerButtonTagData() { PlannerView = plannerVertHoursLineViewEh1, HoursLineRange = HoursLineRange.Day};
      bVh2.Tag = new FramePlannerButtonTagData() { PlannerView = plannerVertHoursLineViewEh1, HoursLineRange = HoursLineRange.Week};

      bVd1.Tag = new FramePlannerButtonTagData() { PlannerView = plannerVertDaysLineViewEh1, DaysLineRange = DaysLineRange.Week};
      bVD2.Tag = new FramePlannerButtonTagData() { PlannerView = plannerVertDaysLineViewEh1, DaysLineRange = DaysLineRange.Month };

      // Horz
      bHh1.Tag = new FramePlannerButtonTagData() { PlannerView = plannerHorzHoursLineViewEh1, HoursLineRange = HoursLineRange.Day };
      bHh2.Tag = new FramePlannerButtonTagData() { PlannerView = plannerHorzHoursLineViewEh1, HoursLineRange = HoursLineRange.Week };

      bHd1.Tag = new FramePlannerButtonTagData() { PlannerView = plannerHorzDaysLineViewEh1, DaysLineRange = DaysLineRange.Week };
      bHd2.Tag = new FramePlannerButtonTagData() { PlannerView = plannerHorzDaysLineViewEh1, DaysLineRange = DaysLineRange.Month };
    }

    private void bDay_Click(object sender, EventArgs e)
    {
      bDay.Font = Font;
      bWeek.Font = Font;
      bMonth.Font = Font;
      bYear.Font = Font;
      bVh1.Font = Font;
      bVh2.Font = Font;
      bVd1.Font = Font;
      bVD2.Font = Font;
      bHd2.Font = Font;
      bHd1.Font = Font;
      bHh2.Font = Font;
      bHh1.Font = Font;

      Button btn = sender as Button;
      btn.Font = new Font(Font, FontStyle.Bold);
      FramePlannerButtonTagData td = btn.Tag as FramePlannerButtonTagData;
      if (td.PlannerView is PlannerVertHoursLineViewEh)
        (td.PlannerView as PlannerVertHoursLineViewEh).TimeRange = td.HoursLineRange;
      else if (td.PlannerView is PlannerVertDaysLineViewEh)
        (td.PlannerView as PlannerVertDaysLineViewEh).TimeRange = td.DaysLineRange;
      else if (td.PlannerView is PlannerHorzHoursLineViewEh)
        (td.PlannerView as PlannerHorzHoursLineViewEh).TimeRange = td.HoursLineRange;
      else if (td.PlannerView is PlannerHorzDaysLineViewEh)
        (td.PlannerView as PlannerHorzDaysLineViewEh).TimeRange = td.DaysLineRange;

      plannerControlEh1.ActivePlannerView = td.PlannerView;
    }

    private void FramePlanner_Load(object sender, EventArgs e)
    {
      this.plannerResourcesTableAdapter.Fill(this.biolifeDataSet.PlannerResources);
      this.plannerDataTableAdapter.Fill(this.biolifeDataSet.PlannerData);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      plannerDataSourceEh1.BeginUpdate();

      plannerDataSourceEh1.Resources.Clear();

      ReadOnlyCollection<DataGridRow> selRows = gridResources.Selection.SelectedRows;
      for (int i = 0; i <= selRows.Count - 1; i++)
      {
        DataGridRow gridRow = selRows[i];

        var res = new PlannerResource();
        res.Name = (string)resNameCol.GetRowValue(gridRow);
        res.ResourceId = i; //(int)resIDCol.GetRowValue(gridRow);
        switch (i % 4)
        {
          case 0: res.Color = Color.Green; break;
          case 1: res.Color = Color.FromArgb(0x26, 0x84, 0xD9); break;
          case 2: res.Color = Color.Navy; break;
          case 3: res.Color = Color.Purple; break;
        }
        plannerDataSourceEh1.Resources.Add(res);

      }

      //-- Move event to current day
      BiolifeDataSet.PlannerDataDataTable table = this.biolifeDataSet.PlannerData;
      DataRow[] foundRows = this.biolifeDataSet.PlannerData.Select("Title = 'Busy time'");
      DateTime baseOldDate = ((DateTime)foundRows[0]["StartTime"]).Date;
      //TimeSpan span = new DateTime(DateTime.Today.Year, 1, 1) - baseOldDate;
      TimeSpan span = DateTime.Today - baseOldDate;

      foreach (var r in table)
      {
        r.BeginEdit();
        r["StartTime"] = (DateTime)r["StartTime"] + span;
        r["EndTime"] = (DateTime)r["EndTime"] + span;
        r.EndEdit();
      }

      //-- Fill the Data
      plannerDataSourceEh1.ClearItems();

      foreach (var r in table)
      {
        if (r.InPlanner == true)
        {
          PlannerDataItem planItem = plannerDataSourceEh1.NewPlannerItem();
          planItem.ItemId = r["Id"];
          planItem.StartTime = (DateTime)r["StartTime"];
          planItem.EndTime = (DateTime)r["EndTime"];
          planItem.Title = ObjectToString(r["Title"]);
          planItem.Body = ObjectToString(r["Body"]);
          planItem.AllDay = (bool)r["AllDay"];
          planItem.ResourceId = r["ResourceID"];
          planItem.ReadOnly = (bool)r["ReadOnly"];
          if (planItem.ReadOnly)
            planItem.FillColor = EhLibUtils.ColorToGray(plannerControlEh1.TimeSpanOptions.GetActualColor());
          plannerDataSourceEh1.FetchTimePlanItem(planItem);
        }
      }

      plannerDataSourceEh1.EndUpdate();

      plannerControlEh1.CurrentTime = DateTime.Today;
    }

    private string ObjectToString(object v)
    {
      if (EhLibUtils.DBValueEqual(v, null))
        return "";
      else
        return v.ToString();
    }

  }

  public class FramePlannerButtonTagData
  {
    public BasePlannerViewEh PlannerView { get; set; }
    public HoursLineRange HoursLineRange { get; set; }
    public DaysLineRange DaysLineRange { get; set; }
}
}
