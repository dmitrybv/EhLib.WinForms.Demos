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
  public partial class FrameSolDataGridCustomDataCellPaint : BaseFrame
  {

    int mouseIconIndex = -1;

    public FrameSolDataGridCustomDataCellPaint()
    {
      InitializeComponent();

      var transport1 = new DataColumn();
      transport1.DataType = typeof(bool);
      transport1.DefaultValue = false;
      transport1.ColumnName = "transport1";
      transport1.Caption = "Bus";
      this.biolifeDataSet.country.Columns.Add(transport1);

      var transport2 = new DataColumn();
      transport2.ColumnName = "transport2";
      transport2.DataType = typeof(bool);
      transport2.DefaultValue = false;
      this.biolifeDataSet.country.Columns.Add(transport2);

      var transport3 = new DataColumn();
      transport3.ColumnName = "transport3";
      transport3.DataType = typeof(bool);
      transport3.DefaultValue = false;
      this.biolifeDataSet.country.Columns.Add(transport3);


      var transport4 = new DataColumn();
      transport4.ColumnName = "transport4";
      transport4.DataType = typeof(bool);
      transport4.DefaultValue = false;
      this.biolifeDataSet.country.Columns.Add(transport4);

      this.countryTableAdapter.Fill(this.biolifeDataSet.country);

      this.biolifeDataSet.country.Rows[0][transport1] = true;
      this.biolifeDataSet.country.Rows[0][transport2] = true;
      this.biolifeDataSet.country.Rows[1][transport3] = true;

      this.biolifeDataSet.country.Rows[2][transport4] = true;
      this.biolifeDataSet.country.Rows[3][transport2] = true;
      this.biolifeDataSet.country.Rows[4][transport3] = true;
      this.biolifeDataSet.country.Rows[5][transport1] = true;
      this.biolifeDataSet.country.Rows[6][transport3] = true;
      this.biolifeDataSet.country.Rows[7][transport1] = true;

    }

    private void GetIconsList(DataGridRow row, List<IconData> icons)
    {
      DataRowView rowView = (DataRowView)row.SourceItem;
      if (rowView["transport1"] is bool && (bool)rowView["transport1"])
        icons.Add(new IconData(0, this.biolifeDataSet.country.Columns["transport1"]));
      if (rowView["transport2"] is bool && (bool)rowView["transport2"])
        icons.Add(new IconData(1, this.biolifeDataSet.country.Columns["transport2"]));
      if (rowView["transport3"] is bool && (bool)rowView["transport3"])
        icons.Add(new IconData(2, this.biolifeDataSet.country.Columns["transport3"]));
      if (rowView["transport4"] is bool && (bool)rowView["transport4"])
        icons.Add(new IconData(3, this.biolifeDataSet.country.Columns["transport4"]));
    }

    private int GetIconInfoAtPos(DataGridRow row, Rectangle cellRect, int inCellX, int inCellY)
    {
      int ic = 0;
      var icons = new List<IconData>();
      GetIconsList(row, icons);

      Rectangle iconRect = new Rectangle(0, 0, 20, cellRect.Height);

      foreach (IconData id in icons)
      {
        if (iconRect.Contains(inCellX, inCellY))
        {
          return ic;
        }
        iconRect.Offset(20, 0);
        ic++;
      }
      return -1;
    }

    private int GetTransportIconsWidth(DataRowView rowView)
    {
      int custAreaWidth = 0;

      if (rowView["transport1"] is bool && (bool)rowView["transport1"])
        custAreaWidth = custAreaWidth + 20;
      if (rowView["transport2"] is bool && (bool)rowView["transport2"])
        custAreaWidth = custAreaWidth + 20;
      if (rowView["transport3"] is bool && (bool)rowView["transport3"])
        custAreaWidth = custAreaWidth + 20;
      if (rowView["transport4"] is bool && (bool)rowView["transport4"])
        custAreaWidth = custAreaWidth + 20;

      return custAreaWidth;
    }

    private void dataGridTextColumn1_DataCellClientAreaNeeded(object sender, DataGridDataCellClientAreaNeededEventArgs e)
    {
      if (e.Row == null) return;
      DataRowView rowView = (DataRowView)e.Row.SourceItem;
      int custAreaWidth = GetTransportIconsWidth(rowView);
      e.CellArgs.CellClientRect = EhLib.WinForms.EhLibUtils.CopyChangeRectangle(e.CellArgs.CellRect, custAreaWidth, 0, -custAreaWidth, 0);
    }

    private void dataGridTextColumn1_DataCellCustomAreaPaint(object sender, DataGridDataCellPaintEventArgs e)
    {
      if (e.Row == null) return;

      int iconPos = 0;
      Rectangle iconRect;
      SolidBrush backFill = new SolidBrush(e.Column.BackColor);
      int[] iconIndexes = new int[4] { -1, -1, -1, -1 };

      iconRect = e.CellArgs.CellRect;
      iconRect.Width = 20;

      DataRowView rowView = (DataRowView)e.Row.SourceItem;
      if (rowView["transport1"] is bool && (bool)rowView["transport1"])
        iconIndexes[0] = 0;
      if (rowView["transport2"] is bool && (bool)rowView["transport2"])
        iconIndexes[1] = 1;
      if (rowView["transport3"] is bool && (bool)rowView["transport3"])
        iconIndexes[2] = 2;
      if (rowView["transport4"] is bool && (bool)rowView["transport4"])
        iconIndexes[3] = 3;

      BasePaintCellStates cellPaintState = e.CellArgs.State;
      e.CellArgs.State = e.CellArgs.State & ~BasePaintCellStates.Current & ~BasePaintCellStates.Focused;
      Rectangle clientRect = e.CellArgs.ClientRect;

      foreach (int i in iconIndexes)
      {
        if (i >= 0)
        {
          e.CellArgs.ClientRect = iconRect;
          //e.Graphics.FillRectangle(backFill, iconRect);
          e.PaintBackground(e);
          if (iconPos == mouseIconIndex && e.CellArgs.RowIndex == dataGrid1.MouseHolderCellCoord.Y)
          {
            using (
              SolidBrush fillBrush = new SolidBrush(Color.FromArgb(255 / 3, SystemColors.Highlight)))
            {
              e.CellArgs.Graphics.FillRectangle(fillBrush, iconRect);
            }
          }
          PaintTransportIcon(e.CellArgs.Graphics, iconRect, i);
          iconPos++;
          iconRect.Offset(20, 0);
        }
      }

      e.CellArgs.ClientRect = clientRect;
      e.CellArgs.State = cellPaintState;
    }

    private void PaintTransportIcon(Graphics graphics, Rectangle iconRect, int iconPos)
    {
      Image image = imageList1.Images[iconPos];

      Rectangle imageArea = new Rectangle(Point.Empty, image.Size);
      imageArea = EhLibUtils.RectCenter(imageArea, iconRect);

      graphics.DrawImage(image, imageArea);
    }

    private void dataGridTextColumn1_DataCellMouseDown(object sender, DataGridDataCellMouseEventArgs e)
    {
      var icons = new List<IconData>();
      GetIconsList(e.Row, icons);

      Rectangle iconRect = e.CellArgs.CellRect;
      iconRect.Width = 20;
      iconRect.X = iconRect.X - 20;

      foreach (IconData id in icons)
      {
        iconRect.Offset(20, 0);
        if (iconRect.Contains(e.CellArgs.GridMouseArgs.Location))
        {
          DataRowView rowView = (DataRowView)e.Row.SourceItem;
          rowView.Row[id.DataColumn] = false;
          e.Handled = true;
          return;
        }
      }
    }

    private void dataGridTextColumn1_DataCellMouseMove(object sender, DataGridDataCellMouseEventArgs e)
    {
      if (e.Row == null) return;
      int iconIndex = GetIconInfoAtPos(e.Row, e.CellArgs.CellRect, e.CellArgs.InCellX, e.CellArgs.InCellY);
      if (mouseIconIndex != iconIndex)
      {
        dataGrid1.InvalidateCell(e.CellArgs.ColIndex, e.CellArgs.RowIndex);
        mouseIconIndex = iconIndex;
        dataGrid1.RestartMouseHoverEvent();
        toolTip1.Hide(dataGrid1);
      }
    }

    private void dataGridTextColumn1_DataCellMouseLeave(object sender, DataGridDataCellMouseLeaveEventArgs e)
    {
      mouseIconIndex = -1;
      toolTip1.Hide(dataGrid1);
    }

    private void dataGridTextColumn1_DataCellMouseHover(object sender, DataGridDataCellMouseEventArgs e)
    {
      if (e.Row == null) return;
      int iconIndex = GetIconInfoAtPos(e.Row, e.CellArgs.CellRect, e.CellArgs.InCellX, e.CellArgs.InCellY);
      if (iconIndex >= 0)
      {
        Point toolTipPos = e.CellArgs.GridMouseArgs.Location;
        toolTipPos.Y = toolTipPos.Y + 24;
        toolTip1.Show("Click the Icon to delete transport type", dataGrid1, toolTipPos, 2000);
      }
    }
  }

  class IconData
  {
    public IconData(int iconIdex, DataColumn dataColumn)
    {
      IconIdex = iconIdex;
      DataColumn = dataColumn;
    }

    public int IconIdex { get; set; }
    public DataColumn DataColumn { get; set; }
  }
}
