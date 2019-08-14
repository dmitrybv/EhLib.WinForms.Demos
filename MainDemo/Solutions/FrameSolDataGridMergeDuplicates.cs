using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EhLib.WinForms;
using System.Drawing.Drawing2D;
using System.Windows.Forms.VisualStyles;

namespace MainDemo
{
  public partial class FrameSolDataGridMergeDuplicates : BaseFrame
  {
    DataGridColumn mergeDuplicatedCol;
 
    public FrameSolDataGridMergeDuplicates()
    {
      InitializeComponent();
    }

    private void FrameSolDataGridMergeDuplicates_Load(object sender, EventArgs e)
    {
      ordersTableAdapter.Fill(northwindDataSet.Orders);
      employeesTableAdapter.Fill(northwindDataSet.Employees);
      customersTableAdapter.Fill(northwindDataSet.Customers);

      //ordersBindingSource.Sort = "CustomerID";
      dataGrid1.Title.SortMarking.SortMarkers.SetSortState(dataGrid1CustomerIDCol, ListSortDirection.Ascending);
      dataGrid1.Title.SortMarking.ApplySortMakers();
      UpdateMergeDuplicatedCol();
    }

    private void UpdateMergeDuplicatedCol()
    {
      if (mergeDuplicatedCol != null)
      {
        mergeDuplicatedCol.MergeDuplicates = false;
        mergeDuplicatedCol.VertAlign = VerticalAlignment.Top;
        mergeDuplicatedCol.ResetBackColor();
        mergeDuplicatedCol = null;
      }

      if (dataGrid1.Title.SortMarking.SortMarkers.Count > 0)
      {
        mergeDuplicatedCol = dataGrid1.Title.SortMarking.SortMarkers[0].Column;
        mergeDuplicatedCol.MergeDuplicates = true;
        mergeDuplicatedCol.VertAlign = VerticalAlignment.Center;
        mergeDuplicatedCol.BackColor = Color.Linen;
      }
    }

    private void DataGrid1_HorzLineParamsNeeded(object sender, DataGridHorzLineParamsNeededEventArgs e)
    {
      object sortedVal;
      object nextSortedVal;
      DataGridRow nextRow;
      if (e.Row == null) return;
      DataGridColumn sortedCol;

      if (dataGrid1.Title.SortMarking.SortMarkers.Count > 0)
      {
        sortedCol = dataGrid1.Title.SortMarking.SortMarkers[0].Column;

        if (e.Row.VisibleIndex < dataGrid1.VisibleRows.Count - 1)
        {
          sortedVal = sortedCol.GetRowValue(e.Row);

          nextRow = dataGrid1.VisibleRows[e.Row.VisibleIndex + 1];
          nextSortedVal = sortedCol.GetRowValue(nextRow);

          if (!EhLibUtils.DBValueEqual(sortedVal, nextSortedVal))
          {
            e.Style = DashStyle.Solid;
            e.Color = dataGrid1.LineOptions.DarkColor;
          }
        }
        else if (e.Row.VisibleIndex == dataGrid1.VisibleRows.Count - 1)
        {
          e.Style = DashStyle.Solid;
          e.Color = dataGrid1.LineOptions.DarkColor;
        }
      }
    }

    private void DataGrid1_Title_InteractiveSortMarkingChanged(object sender, SortMarkingChangedEventArgs e)
    {
      e.Sort(e);
      e.Handled = true;
      if (dataGrid1.VisibleRows.Count > 0)
        dataGrid1.CurrentRowIndex = 0;
      UpdateMergeDuplicatedCol();
    }
  }
}
