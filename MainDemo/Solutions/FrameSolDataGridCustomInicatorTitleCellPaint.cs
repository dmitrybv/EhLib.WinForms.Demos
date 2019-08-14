using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EhLib.WinForms;
using System.Windows.Forms.VisualStyles;

namespace MainDemo
{
  public partial class FrameSolDataGridCustomIndicatorTitleCellPaint : BaseFrame
  {

    /// <summary>
    /// Indicates that now mouse position is in the question mark area
    /// </summary>
    bool mouseInCustPart;

    /// <summary>
    /// FrameSolDataGridCustomIndicatorTitleCellPaint Constructor
    /// </summary>
    public FrameSolDataGridCustomIndicatorTitleCellPaint()
    {
      InitializeComponent();

      this.countryTableAdapter.Fill(this.biolifeDataSet.country);
      richTextBox1.LoadFile("Doc\\FrameSolDataGridCustomIndicatorTitleCellPaint.rtf");
    }

    /// <summary>
    /// The dataGrid1.IndicatorTitle.CellMouseClick event handler
    /// Show simple Dialog when mouse clicks on the IndicatorTitle cell in the question mark area
    /// </summary>
    private void dataGrid1_IndicatorTitle_CellMouseClick(object sender, BaseGridCellMouseEventArgs e)
    {
      Rectangle custRect = e.CellRect;
      custRect.Width = 10;
      if (custRect.Contains(e.GridMouseArgs.Location))
      {
        MessageBox.Show("dataGrid1_IndicatorTitle_MouseClick. InCellPost: ("
          + e.InCellX.ToString() + "," + e.InCellY.ToString() + ")  " + e.Button.ToString());
        e.Handled = true;
      }
    }

    /// <summary>
    /// The dataGrid1.IndicatorTitle.CellMouseDown event handler
    /// Suppress CellMouseDown event when mouse down on question mark area to prevent open IndicatorTitle DropDown menu
    /// </summary>
    private void dataGrid1_IndicatorTitle_CellMouseDown(object sender, BaseGridCellMouseEventArgs e)
    {
      Rectangle custRect = e.CellRect;
      custRect.Width = 10;
      if (custRect.Contains(e.GridMouseArgs.Location))
      {
        e.Handled = true;
      }
    }

    /// <summary>
    /// The dataGrid1.IndicatorTitle.CellMouseMove event handler
    /// Highlight the question mark area when mouse move over this area
    /// </summary>
    private void dataGrid1_IndicatorTitle_CellMouseMove(object sender, BaseGridCellMouseEventArgs e)
    {
      bool locMouseInCustPart;

      Rectangle custBackRect = e.CellRect;
      custBackRect.Width = 10;

      locMouseInCustPart = custBackRect.Contains(e.InCellX, e.InCellY);
      if (locMouseInCustPart != mouseInCustPart)
      {
        mouseInCustPart = locMouseInCustPart;
        dataGrid1.InvalidateCell(e.ColIndex, e.RowIndex);
      }
    }

    /// <summary>
    /// The dataGrid1.IndicatorTitle.CellPaint event handler
    /// Draw question mark in question mark area, 
    /// reduce the area size of standard rendering,
    /// than call default paint handler.
    /// </summary>
    private void dataGrid1_IndicatorTitle_CellPaint(object sender, BaseGridCellPaintEventArgs e)
    {

      //PaintBackground
      Rectangle custBackRect = e.ClientRect;
      custBackRect.Width = 10;

      if (custBackRect.Contains(e.InCellMousePos))
      {
        e.Graphics.FillRectangle(new SolidBrush(Color.BurlyWood), custBackRect);
      }
      else
      {
        e.Graphics.FillRectangle(new SolidBrush(SystemColors.ButtonFace), custBackRect);
      }

      EhLibUtils.DrawText(e.Graphics, "?", new Font(dataGrid1.Font.FontFamily, 5), custBackRect,
        SystemColors.WindowText, HorizontalAlignment.Center, VerticalAlignment.Center, 0);

      //PaintForeground
      Rectangle newBackgroundRect = e.ClientRect;
      newBackgroundRect.X = newBackgroundRect.X + 10;
      newBackgroundRect.Width = newBackgroundRect.Width - 10;
      e.ClientRect = newBackgroundRect;

      e.PaintBackground(e);
      e.PaintForeground(e);
      e.Handled = true;
    }
  }
}
