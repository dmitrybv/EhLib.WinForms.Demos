using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EhLib.WinForms;

namespace MainDemo
{
  public partial class FrameCrossedRadioMatrix : MainDemo.BaseFrame
  {

    List<ColRowCheckedData> colRowCheckedList = new List<ColRowCheckedData>();
    //Dictionary<int, int> colRowCheckedState = new Dictionary<int, int>();
    BlankDataCellManager blankCell = new BlankDataCellManager();

    public FrameCrossedRadioMatrix()
    {
      InitializeComponent();

      blankCell.BackFiller.FillStyle = CellFillStyle.Solid;
      blankCell.BoundGrid = dataGridEh1;

      colRowCheckedList.Add(new ColRowCheckedData(1, 2));
      colRowCheckedList.Add(new ColRowCheckedData(2, 3));
      colRowCheckedList.Add(new ColRowCheckedData(3, 4));
      colRowCheckedList.Add(new ColRowCheckedData(4, 1));
      colRowCheckedList.Add(new ColRowCheckedData(5, 5));

      baseBindingSource.DataSource = colRowCheckedList;
      gridBaseList.DataSource = baseBindingSource;
      dataGridEh1.DataSource = colRowCheckedList;

    }

    private void gridBaseList_CreatingDynamicColumnsForDataProperty(object sender, DataGridDynamicColumnsCreatingEventArgs e)
    {
      e.CreateColumns(e);
      if (e.Columns.Length > 0)
          e.Columns[0].HorzAlign = HorizontalAlignment.Center;
      e.Handled = true;
    }

    private void dataGridEh1_DataCellPullValue(object sender, DataGridDataCellPullValueEventArgs e)
    {
      int colNum = int.Parse(e.Column.Title.Text);
      int rowNum = FindColRowDataByCol(colNum).RowNum;
      if (rowNum == e.Row.VisibleIndex + 1)
        e.Value = true;
      e.Handled = true;
    }

    private ColRowCheckedData FindColRowDataByCol(int colNum)
    {
      foreach(ColRowCheckedData colRowData in colRowCheckedList)
      {
        if (colRowData.ColNum == colNum)
          return colRowData;
      }
      return null;
    }

    private void dataGridEh1_DataCellPushValue(object sender, DataGridDataCellPushValueEventArgs e)
    {
      int colNum = int.Parse(e.Column.Title.Text);
      int newRowNum = e.Row.VisibleIndex + 1;
      ColRowCheckedData colRowData = FindColRowDataByCol(colNum);
      if (colRowData != null)
      {
        int oldRowNum = colRowData.RowNum;
        colRowData.RowNum = newRowNum;

        foreach (ColRowCheckedData crd in colRowCheckedList)
        {
          if (crd != colRowData && crd.RowNum == newRowNum)
          {
            crd.RowNum = oldRowNum;
            break;
          }
        }
      }

      dataGridEh1.Invalidate();
      gridBaseList.Invalidate();

      e.Handled = true;
    }

    private void dataGridEh1_DataCellManagerNeeded(object sender, DataGridDataCellManagerNeededEventArgs e)
    {
      int colNum = int.Parse(e.Column.Title.Text);
      if (e.Column.VisibleIndex == e.Row.VisibleIndex &&
          FindColRowDataByCol(colNum).RowNum != e.Row.VisibleIndex + 1)
      {
        e.CellManager = blankCell;
      }
    }

    private void dataGridEh1_DataCellFormatParamsNeeded(object sender, DataGridDataCellFormatParamsNeededEventArgs e)
    {
      if (e.Column == null) return;
      int colNum = int.Parse(e.Column.Title.Text);
      if (e.Column.VisibleIndex == e.Row.VisibleIndex &&
          FindColRowDataByCol(colNum).RowNum == e.Row.VisibleIndex + 1)
      {
        e.CellArgs.BackColor = Color.OrangeRed;
      }
    }

    private void dataGrid1_VertScrollBar_ScrollPosChanged(object sender, EventArgs e)
    {

    }
  }

  public class ColRowCheckedData
  {
    public ColRowCheckedData(int colNum, int rowNum)
    {
      ColNum = colNum;
      RowNum = rowNum;
    }

    public int ColNum { get; set; }
    public int RowNum { get; set; }
  }
}
