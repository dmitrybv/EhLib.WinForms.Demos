using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EhLib.WinForms;

namespace MainDemo
{
  public partial class FrameSolDataGridScrollEvents : BaseFrame
  {
    public FrameSolDataGridScrollEvents()
    {
      InitializeComponent();

      this.countryTableAdapter.Fill(this.biolifeDataSet.country);
    }

    private void UpdateHorzScrollBar()
    {
      hScrollBar1.Minimum = 0;
      hScrollBar1.Maximum = (int)(dataGrid1.HorzScrollBar.RollSize - 1);
      hScrollBar1.LargeChange = dataGrid1.HorzScrollBar.ViewportSize;

      if (hScrollBar1.LargeChange > hScrollBar1.Maximum)
        hScrollBar1.Enabled = false;
      else
        hScrollBar1.Enabled = true;
    }

    private void UpdateVertScrollBar()
    {
      vScrollBar1.Minimum = 0;
      vScrollBar1.Maximum = (int)(dataGrid1.VertScrollBar.RollSize - 1);
      vScrollBar1.LargeChange = dataGrid1.VertScrollBar.ViewportSize;

      if (vScrollBar1.LargeChange > vScrollBar1.Maximum)
        vScrollBar1.Enabled = false;
      else
        vScrollBar1.Enabled = true;
    }

    private void countryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.countryBindingSource.EndEdit();
      this.tableAdapterManager.UpdateAll(this.biolifeDataSet);
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void dataGrid1_HorzScrollBar_RollParamsChanged(object sender, EventArgs e)
    {
      UpdateHorzScrollBar();
    }

    private void dataGrid1_HorzScrollBar_ScrollPosChanged(object sender, EventArgs e)
    {
      hScrollBar1.Value = (int)dataGrid1.HorzScrollBar.ScrollPos;
      dataGrid2.HorzScrollBar.ScrollPos = (int)dataGrid1.HorzScrollBar.ScrollPos;
    }

    private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
    {
      dataGrid1.HorzScrollBar.ScrollPos = hScrollBar1.Value;
    }

    private void dataGrid1_VertScrollBar_RollParamsChanged(object sender, EventArgs e)
    {
      UpdateVertScrollBar();
    }

    private void dataGrid1_VertScrollBar_ScrollPosChanged(object sender, EventArgs e)
    {
      vScrollBar1.Value = (int)dataGrid1.VertScrollBar.ScrollPos;
      dataGrid2.VertScrollBar.ScrollPos = (int)dataGrid1.VertScrollBar.ScrollPos;
    }

    private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
    {
      dataGrid1.VertScrollBar.ScrollPos = vScrollBar1.Value;
    }

    private void dataGrid1_ColumnWidthChanged(object sender, EhLib.WinForms.DataGridColumnEventArgs e)
    {
      for(int i = 0; i < dataGrid1.Columns.Count; i++)
      {
        dataGrid2.Columns[i].Width = dataGrid1.Columns[i].Width;
      }
    }

    private void dataGrid1_DisplayColumnsMoved(object sender, DataGridDisplayColumnsMovedEventArgs e)
    {
      var colsToMoveGrid2 = new DataGridColumn[e.MovedColumns.Count];
      for (int i = 0; i < e.MovedColumns.Count; i++)
      {
        colsToMoveGrid2[i] = dataGrid2.Columns.FindColumnByPropertyName(e.MovedColumns[i].DataPropertyName);
      }
      dataGrid2.MoveDisplayColumns(colsToMoveGrid2, e.ToIndex);
    }
  }
}
