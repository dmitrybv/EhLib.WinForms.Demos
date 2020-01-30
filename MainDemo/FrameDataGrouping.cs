using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EhLib.WinForms;

namespace MainDemo
{
  public partial class FrameDataGrouping : MainDemo.BaseFrame
  {
    public FrameDataGrouping()
    {
      InitializeComponent();
    }

    private void FrameDataGrouping_Load(object sender, EventArgs e)
    {
      this.ordersTableAdapter.Fill(this.northwindDataSet.Orders);

      var row0 = dataGridEh1.VisibleRows[0] as DataGridGroupingRow;
      row0.DataGroupingNode.Expanded = true;

      var row1 = dataGridEh1.VisibleRows[1] as DataGridGroupingRow;
      row1.DataGroupingNode.Expanded = true;

      dataGridEh1.CurrentRowIndex = 2;
      dataGridEh1_DataGrouping_GroupDescriprionsChanged(null, null);
    }

    private void dataGridEh1_DataGrouping_GroupDescriprionsChanged(object sender, EventArgs e)
    {
      int cnt = dataGridEh1.DataGrouping.GroupDescriptions.Count;
      for (int i = 0; i < cnt; i++)
      {
        DataGridGroupDescription gd = dataGridEh1.DataGrouping.GroupDescriptions[i];
        int quota = 255 * i / cnt;
        gd.BackColor = EhLibUtils.ApproximateColor(Color.NavajoWhite, dataGridEh1.BackColor, quota);
      }
    }

    private void dataGridColumnFooterItem2_CellFormatValue(object sender, DataGridFooterCellFormatValueEventArgs e)
    {
      if (e.RowContext.DataGroupFooterRow != null)
      {
        e.FormattedValue = "";
        e.Handled = true;
      }
    }
  }
}
