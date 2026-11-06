using System;
using System.Collections.Generic;
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
  public partial class FramePivotGrid : BaseFrame
  {
    public FramePivotGrid()
    {
      InitializeComponent();
    }

    private void FramePivotGrid_Load(object sender, EventArgs e)
    {
      northwindDataSet1.LoadOrders();

      RebuildPivotFields();
      RebuildDefaultStruct();
      LoadSourceData();
      UpdateCaptions();
    }

    private void RebuildPivotFields()
    {
      pivotDataSourceEh1.PivotFields.RebuildPivotFields();
    }

    private void RebuildDefaultStruct()
    {
      pivotDataSourceEh1.ColumnFields.Clear();
      pivotDataSourceEh1.RowFields.Clear();
      pivotDataSourceEh1.ValueFieldDefs.Clear();

      pivotDataSourceEh1.RowFields.Add(pivotDataSourceEh1.PivotFields["OrderDate.Year"]);
      pivotDataSourceEh1.RowFields.Add(pivotDataSourceEh1.PivotFields["CustomerID"]);

      pivotDataSourceEh1.ColumnFields.Add(pivotDataSourceEh1.PivotFields["EmployeeID"]);

      PivotFieldValueInfo vfDef = new PivotFieldValueInfo()
      {
        PivotField = pivotDataSourceEh1.PivotFields["Freight"],
        SumFunction = PivotValueType.Sum
      };
      pivotDataSourceEh1.ValueFieldDefs.Add(vfDef);

    }

    private void LoadSourceData()
    {
      pivotDataSourceEh1.CreateAndFillSourceTable();
      //dataGridSourceTable.DataSource = pivotDataSourceEh1.SourceTable;
      tabControl1.SelectedTab = tabPage1;
    }

    private void UpdateCaptions()
    {
      miAutoWordWrap.Text = "AutoWordWrap = " + pivotGridEh1.ColumnAxisOptions.AutoWordWrap.ToString();
      miTotalsBeforeData.Text = "TotalsBeforeData = " + pivotGridEh1.ColumnAxisOptions.TotalsBeforeData.ToString();
      miTotalAtParentLevel.Text = "TotalAtParentLevel = " + pivotGridEh1.ColumnAxisOptions.TotalAtParentLevel.ToString();
      miHeightAutoExpand.Text = "HeightAutoExpand = " + pivotGridEh1.ColumnAxisOptions.HeightAutoExpand.ToString();
      miMultiValInRows.Text = "MultiValInRows = " + pivotGridEh1.GridOptions.MultiValuesInRowsAxis.ToString();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (pivotDataSourceEh1.ColumnFields.Count == 0 &&
          pivotDataSourceEh1.RowFields.Count == 0)
      {
        MessageBox.Show("Please, assign Column Fields and/or Row Fields to make Pivot Structure!");
      }
      else
      {
        try
        {
          pivotDataSourceEh1.BuildPivotData();
        }
        catch (Exception exp)
        {

          if (EhLibUtils.IsCriticalException(exp))
          {
            throw;
          }
          else
          {
            MessageBox.Show(exp.Message);
          }
        }
      }
      tabControl1.SelectedTab = tabPage1;
    }

    private void bOptions_Click(object sender, EventArgs e)
    {
      contextMenuStrip1.Show(bOptions, new Point(0, bOptions.Height));
    }

    private void miAutoWordWrap_Click(object sender, EventArgs e)
    {
      pivotGridEh1.RowAxisOptions.AutoWordWrap = !pivotGridEh1.RowAxisOptions.AutoWordWrap;
      pivotGridEh1.ColumnAxisOptions.AutoWordWrap = !pivotGridEh1.ColumnAxisOptions.AutoWordWrap;
      UpdateCaptions();
      button1_Click(null, null);
    }

    private void miTotalsBeforeData_Click(object sender, EventArgs e)
    {
      pivotGridEh1.RowAxisOptions.TotalsBeforeData = !pivotGridEh1.RowAxisOptions.TotalsBeforeData;
      pivotGridEh1.ColumnAxisOptions.TotalsBeforeData = !pivotGridEh1.ColumnAxisOptions.TotalsBeforeData;
      UpdateCaptions();
      button1_Click(null, null);
    }

    private void miTotalAtParentLevel_Click(object sender, EventArgs e)
    {
      pivotGridEh1.RowAxisOptions.TotalAtParentLevel = !pivotGridEh1.RowAxisOptions.TotalAtParentLevel;
      pivotGridEh1.ColumnAxisOptions.TotalAtParentLevel = !pivotGridEh1.ColumnAxisOptions.TotalAtParentLevel;
      UpdateCaptions();
      button1_Click(null, null);
    }

    private void miHeightAutoExpand_Click(object sender, EventArgs e)
    {
      pivotGridEh1.RowAxisOptions.HeightAutoExpand = !pivotGridEh1.RowAxisOptions.HeightAutoExpand;
      pivotGridEh1.ColumnAxisOptions.HeightAutoExpand = !pivotGridEh1.ColumnAxisOptions.HeightAutoExpand;
      UpdateCaptions();
      button1_Click(null, null);
    }

    private void miMultiValInRows_Click(object sender, EventArgs e)
    {
      pivotGridEh1.GridOptions.MultiValuesInRowsAxis = !pivotGridEh1.GridOptions.MultiValuesInRowsAxis;
      UpdateCaptions();
      button1_Click(null, null);
    }
  }
}
