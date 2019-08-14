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
  public partial class FrameSolDataGridCustomIndicatorCellPaint : BaseFrame
  {
    public FrameSolDataGridCustomIndicatorCellPaint()
    {
      InitializeComponent();

      this.countryTableAdapter.Fill(this.biolifeDataSet.country);
    }

    private void dataGrid1_IndicatorColumn_CellMouseDown(object sender, DataGridIndicatorCellMouseEventArgs e)
    {
      Rectangle imageAreaRect = e.CellRect;
      imageAreaRect.X = imageAreaRect.Right - 16;
      imageAreaRect.Width = 16;
      if (imageAreaRect.Contains(e.GridMouseArgs.Location))
      {

        if (e.Row == null) return;
        DataGridColumn col = dataGrid1.Columns.FindColumnByPropertyName("Continent");
        string value = col.GetRowDisplayText(e.Row);
        DataRowView rowView = (DataRowView)e.Row.SourceItem;
        string showValue = rowView[0].ToString() + ", " +
                           rowView[1].ToString() + ", " +
                           rowView[2].ToString();

        if (value == "North America")
        {
          Point toolTipPoint = e.CellRect.Location;
          toolTipPoint.Offset(new Point(e.CellRect.Size));
          toolTip1.Show(showValue, dataGrid1, toolTipPoint, 2000);
        }
        e.Handled = true;
      }
    }

    private void dataGrid1_IndicatorColumn_CellPaint(object sender, DataGridIndicatorCellPaintEventArgs e)
    {
      e.PaintBackground(e);

      if (e.Row == null) return;
      DataGridColumn col = dataGrid1.Columns.FindColumnByPropertyName("Continent");
      string value = col.GetRowDisplayText(e.Row);

      if (value == "North America")
      {
        Bitmap im = Properties.Resources.Globe_North_America_16x16;
        //im.MakeTransparent();

        Rectangle imageAreaRect = e.ClientRect;
        imageAreaRect.X = imageAreaRect.Right - 16;
        imageAreaRect.Width = 16;

        Rectangle imageArea = new Rectangle(Point.Empty, im.Size);
        imageArea = EhLibUtils.RectCenter(imageArea, imageAreaRect);

        e.Graphics.DrawImage(im, imageArea);
      }

      Rectangle newPaintRect = e.ClientRect;
      newPaintRect.Width = newPaintRect.Width - 16;
      e.ClientRect = newPaintRect;

      e.PaintForeground(e);

      e.Handled = true;
    }

    private void dataGrid1_IndicatorColumn_CellQueryCursor(object sender, BaseGridCellQueryCursorEventArgs e)
    {
      Rectangle imageAreaRect = e.CellRect;
      imageAreaRect.X = imageAreaRect.Right - 16;
      imageAreaRect.Width = 16;
      if (imageAreaRect.Contains(e.GridMouseArgs.Location))
        e.Cursor = Cursors.Default;
    }

    private void dataGrid1_IndicatorColumn_CellWidthNeeded(object sender, DataGridIndicatorCellWidthNeededEventArgs e)
    {
      e.CellWidth = e.CellWidth + 16;
    }
  }
}
