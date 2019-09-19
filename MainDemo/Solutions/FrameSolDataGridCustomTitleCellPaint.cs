using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MainDemo
{
  public partial class FrameSolDataGridCustomTitleCellPaint : BaseFrame
  {
    bool mouseInPlusArea;
    object MouseInObject;

    public FrameSolDataGridCustomTitleCellPaint()
    {
      InitializeComponent();

      this.customersTableAdapter.Fill(this.northwindDataSet.Customers);
    }

    private void DrawPlusMinusSign(Graphics graphics, Rectangle rect, bool isPlus)
    {
      Rectangle imageArea = new Rectangle(Point.Empty, new Size(8, 8));
      imageArea = EhLib.WinForms.EhLibUtils.RectCenter(imageArea, rect);

      graphics.DrawRectangle(new Pen(SystemColors.ButtonShadow), imageArea);

      Rectangle fillRect = imageArea;
      fillRect.Inflate(-1, -1);
      fillRect.Width = fillRect.Width + 1;
      fillRect.Height = fillRect.Height + 1;

      Color fillColor;
      if (mouseInPlusArea && MouseInObject == colAddressFull.Title)
        fillColor = Color.FromArgb(255 / 5, SystemColors.Highlight);
      else
        fillColor = SystemColors.Window;

      using (SolidBrush fillBrush = new SolidBrush(fillColor))
      {
        graphics.FillRectangle(fillBrush, fillRect);
      }

      imageArea.Inflate(-2, -2);
      Point p1 = new Point(imageArea.Left, (imageArea.Top + imageArea.Bottom) / 2);
      Point p2 = new Point(imageArea.Right, (imageArea.Top + imageArea.Bottom) / 2);
      graphics.DrawLine(new Pen(SystemColors.WindowText), p1, p2);

      if (isPlus)
      {
        Point p3 = new Point((imageArea.Left + imageArea.Right) / 2, imageArea.Top);
        Point p4 = new Point((imageArea.Left + imageArea.Right) / 2, imageArea.Bottom);
        graphics.DrawLine(new Pen(SystemColors.WindowText), p3, p4);
      }
    }

    private void superTitleAddress_CustomAreaPaint(object sender, EhLib.WinForms.SuperTitlePaintEventArgs e)
    {
      Rectangle imageAreaRect = e.CellRect;
      imageAreaRect.Width = 16;

      DrawPlusMinusSign(e.Graphics, imageAreaRect, false);
    }

    private void colAddressFull_Title_CellCustomAreaPaint(object sender, EhLib.WinForms.DataGridTitleCellPaintEventArgs e)
    {
      Rectangle imageAreaRect = e.CellRect;
      imageAreaRect.Width = 16;

      DrawPlusMinusSign(e.Graphics, imageAreaRect, true);
    }

    private void colAddressFull_Title_CellClientRectNeeded(object sender, EhLib.WinForms.DataGridTitleCellClientAreaNeededEventArgs e)
    {
      e.CellClientRect = EhLib.WinForms.EhLibUtils.ChangeRectangle(e.CellClientRect, 16, 0, -16, 0);
    }

    private void superTitleAddress_ClientRectNeeded(object sender, EhLib.WinForms.DataGridSuperTitleCellClientAreaNeededEventArgs e)
    {
      e.CellClientRect = EhLib.WinForms.EhLibUtils.ChangeRectangle(e.CellClientRect, 16, 0, -16, 0);
    }

    private void superTitleAddress_MouseDown(object sender, EhLib.WinForms.DataGridTitleCellMouseEventArgs e)
    {
    }

    private void superTitleAddress_MouseDown(object sender, EhLib.WinForms.DataGridSuperTitleCellMouseEventArgs e)
    {
      if (e.InCellX < 16)
      {
        superTitleAddress.Visible = false;
        colAddressFull.Visible = true;
        e.Handled = true;
      }
    }

    private void colAddressFull_Title_CellMouseDown(object sender, EhLib.WinForms.DataGridTitleCellMouseEventArgs e)
    {
      if (superTitleAddress.Visible) return;

      if (e.InCellX < 16)
      {
        superTitleAddress.Visible = true;
        colAddressFull.Visible = false;
        e.Handled = true;
      }
    }

    private void colAddressFull_Title_CellQueryCursor(object sender, EhLib.WinForms.BaseGridCellQueryCursorEventArgs e)
    {
      Rectangle plusAreaRect = e.CellRect;
      plusAreaRect.Width = 16;
      if (plusAreaRect.Contains(e.GridMouseArgs.Location))
        e.Cursor = Cursors.Default;
    }

    private void colAddressFull_Title_MouseMove(object sender, EhLib.WinForms.DataGridTitleCellMouseEventArgs e)
    {
      bool newMouseInPlusArea;
      if (e.InCellX < 16)
        newMouseInPlusArea = true;
      else
        newMouseInPlusArea = false;

      if (newMouseInPlusArea != mouseInPlusArea || MouseInObject != colAddressFull.Title)
      {
        dataGrid1.Title.Invalidate();
        mouseInPlusArea = newMouseInPlusArea;
        MouseInObject = colAddressFull.Title;
      }
    }

    private void superTitleAddress_MouseMove(object sender, EhLib.WinForms.DataGridSuperTitleCellMouseEventArgs e)
    {
      bool newMouseInPlusArea;
      if (e.InCellX < 16)
        newMouseInPlusArea = true;
      else
        newMouseInPlusArea = false;

      if (newMouseInPlusArea != mouseInPlusArea || MouseInObject != superTitleAddress)
      {
        dataGrid1.Title.Invalidate();
        mouseInPlusArea = newMouseInPlusArea;
        MouseInObject = superTitleAddress;
      }
    }

    private void colAddressFull_Title_MouseLeave(object sender, EhLib.WinForms.DataGridTitleCellEventArgs e)
    {
      mouseInPlusArea = false;
      MouseInObject = null;
      dataGrid1.Title.Invalidate();
    }

    private void superTitleAddress_MouseLeave(object sender, EhLib.WinForms.DataGridSuperTitleCellEventArgs e)
    {
      mouseInPlusArea = false;
      MouseInObject = null;
      dataGrid1.Title.Invalidate();
    }

    private void dataGrid1_Title_CellMouseDown(object sender, EhLib.WinForms.DataGridTitleCellMouseEventArgs e)
    {
      //e.Handled = true;
    }

  }
}
