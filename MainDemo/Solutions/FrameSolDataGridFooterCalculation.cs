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
  public partial class FrameSolDataGridFooterCalculation : BaseFrame
  {
    bool selectionTypeRows = false;
    AggregationCalculator custCalculator = new SumCalculator();
    bool mergedFooterCellPainted = false;

    public FrameSolDataGridFooterCalculation()
    {
      InitializeComponent();

      this.order_DetailsTableAdapter.Fill(this.northwindDataSet.Order_Details);
      richTextBox1.LoadFile("Doc\\FrameSolDataGridFooterCalculation.rtf");
    }

    /// <summary>
    /// The DataGridTextColumn.Footer.RowStepCalculation event handler
    /// For footer cell for "Discount" field. accounts only those records in which the value of the field "Discount" > 0
    /// </summary>
    private void dataGridTextColumn5_Footer_RowStepCalculation(object sender, EhLib.WinForms.DataGridFooterCalculationEventArgs e)
    {
      object val = e.Column.GetRowValue(e.Row);
      if (val == null || (Single)val == 0)
        e.Handled = true;
    }

    /// <summary>
    /// The DataGridTextColumn.Footer.CellFormatValue event handler
    /// For footer cell for "Discount" field. Format display value
    /// </summary>
    private void dataGridTextColumn5_Footer_CellFormatValue(object sender, EhLib.WinForms.DataGridFooterCellFormatValueEventArgs e)
    {
      if (e.FooterItemIndex == 0)
      {
        e.FormattedValue =
          EhLibManager.DefaultEhLibManager.ValueConverter.FormatValue(e.SourceValue, typeof(string));
        e.FormattedValue = "Count (Discount > 0) = " + e.FormattedValue;
        e.Handled = true;
      }
    }

    /// <summary>
    /// DataGridEh.Footer.RowStepCalculation event handler
    /// Take into account only the selected records in the records selection mode.
    /// </summary>
    private void dataGridEh1_Footer_RowStepCalculation(object sender, EhLib.WinForms.DataGridFooterCalculationEventArgs e)
    {
      if (selectionTypeRows)
      {
        if (!e.Row.Selected)
          e.Handled = true;
      }
    }

    /// <summary>
    /// DataGridEh.SelectionChanged event handler
    /// Recalculate footers if selected records changed.
    /// </summary>
    private void dataGridEh1_SelectionChanged(object sender, DataGridSelectionChangeOperationEventArgs e)
    {
      if (dataGridEh1.Selection.SelectionType == EhLib.WinForms.GridSelectionType.Rows)
      {
        selectionTypeRows = true;
        dataGridEh1.RecalcFooters();
      }
      else if (dataGridEh1.Selection.SelectionType != EhLib.WinForms.GridSelectionType.Rows && selectionTypeRows == true)
      {
        selectionTypeRows = false;
        dataGridEh1.RecalcFooters();
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      dataGridEh1.Footer.Rows.BeginUpdate();
      dataGridEh1.Footer.Rows.Insert(0, new DataGridFooterRow());
      dataGridEh1.Footer.Rows.Add(new DataGridFooterRow());
      //dataGridEh1.Footer.Rows.RemoveAt(1);
      dataGridEh1.Footer.Rows.EndUpdate();
    }

    /// <summary>
    /// columnUnitPrice.Footer.InitCalculation event handler
    /// Prepare UnitPrice for calculation
    /// SumCalculator custCalculator is used to calculate Sums
    /// </summary>
    private void columnUnitPrice_Footer_InitCalculation(object sender, DataGridFooterCalculationEventArgs e)
    {
      if (e.FooterItemIndex == 1)
      {
        custCalculator.InitCalcData(e.Column.DataType);
      }
    }

    /// <summary>
    /// columnUnitPrice.Footer.RowStepCalculation event handler
    /// Calculate custCalculator step for one Row
    /// </summary>
    private void columnUnitPrice_Footer_RowStepCalculation(object sender, DataGridFooterCalculationEventArgs e)
    {
      if (e.FooterItemIndex == 1)
      {
        object upVal = columnUnitPrice.GetRowValue(e.Row);
        object qnVal = columnQuantity.GetRowValue(e.Row);
        if (!EhLibUtils.DBValueEqual(upVal, null) && !EhLibUtils.DBValueEqual(qnVal, null))
        {
          Decimal upv = Convert.ToDecimal(upVal);
          Decimal qnv = Convert.ToDecimal(qnVal);

          Decimal decVal = upv * qnv;
          custCalculator.StepCalcData(decVal);
        }
      }
    }

    /// <summary>
    /// columnUnitPrice.Footer.FinalizeCalculation event handler
    /// Finalizing the calculation and returning the calculated amount
    /// </summary>
    private void columnUnitPrice_Footer_FinalizeCalculation(object sender, DataGridFooterCalculationEventArgs e)
    {
      if (e.FooterItemIndex == 1)
      {
        e.Value = custCalculator.FinalizeCalcData();
      }
    }

    /// <summary>
    /// columnUnitPrice.Footer.CellPaint event handler
    /// Paint UnitPrice cell with the capture of the Quantity cell area to create the effect of a merged cells
    /// </summary>
    private void columnUnitPrice_Footer_CellPaint(object sender, DataGridFooterCellPaintEventArgs e)
    {
      if (e.AreaRowIndex == 1)
      {
        if (!mergedFooterCellPainted)
        {
          Rectangle rect = e.ClientRect;
          rect.Width = rect.Width + dataGridEh1.ColWidths[e.ColIndex + 1];
          e.ClientRect = rect;

          e.PaintBackground(e);
          e.PaintForeground(e);

          mergedFooterCellPainted = true;
        }
        e.Handled = true;
      }
    }

    /// <summary>
    /// columnQuantity.Footer.CellPaint event handler
    /// Force paint of UnitPrice cell if columnUnitPrice_Footer_CellPaint event was not fired. 
    /// In some cases, this can happen.
    /// </summary>
    private void columnQuantity_Footer_CellPaint(object sender, DataGridFooterCellPaintEventArgs e)
    {
      if (e.AreaRowIndex == 1)
      {
        if (!mergedFooterCellPainted)
        {
          Rectangle rect = e.ClientRect;
          rect.X = rect.X - dataGridEh1.ColWidths[e.ColIndex - 1];
          rect.Width = dataGridEh1.ColWidths[e.ColIndex - 1];
          rect.Height = dataGridEh1.RowHeights[e.RowIndex];
          //dataGridEh1.PaintCellArea(e.Graphics, e.ColIndex - 1, e.RowIndex, rect, e.State);
          e.CellRect = rect;
          e.Paint(e);

          //e.CellClientRect = rect;
          //columnUnitPrice_Footer_CellPaint(sender, e);
          mergedFooterCellPainted = true;
        }
        e.Handled = true;
      }
    }

    /// <summary>
    /// DataGridEh.Paint event handler
    /// mergedFooterCellPainted to false to indicate that the merged cell has not yet been rendered.
    /// </summary>
    private void dataGridEh1_Paint(object sender, ControlPaintEventArgs e)
    {
      mergedFooterCellPainted = false;
    }
  }
}
