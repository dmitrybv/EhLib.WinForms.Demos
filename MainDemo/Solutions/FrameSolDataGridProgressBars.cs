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

  public partial class FrameSolDataGridProgressBars : BaseFrame
  {
    Font boldProgressFont = new Font("Microsoft Sans Serif", 7.5F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));

    public FrameSolDataGridProgressBars()
    {
      InitializeComponent();

      splitContainer1.SplitterWidth = 10;
      productsBindingSource.Sort = "UnitPrice";
      productsBindingSource.Filter = "CategoryID in (1,2,3)";

      dataGridProgressBarColumn3.ProgressBarRenderer = new EhLib.WinForms.SlopeGradientProgressBarRenderer();
      dataGridProgressBarColumn4.ProgressBarRenderer = new EhLib.WinForms.SlopeGradientProgressBarRenderer();

      this.productsTableAdapter.Fill(this.northwindDataSet.Products);
    }

    private void dataGridProgressBarColumn1_DataCellFormatParamsNeeded(object sender, DataGridProgressBarDataCellFormatParamsNeededEventArgs e)
    {
      if (e.Row == null) return;

      object val = e.Column.GetRowValue(e.Row);
      if (val is Decimal)
      {
        double dValue = (double)(Decimal)val;

        if (dValue > 100 / 4)
        {
          double quota = (double)(((Decimal)val - 100 / 4) / (100 / 4 * 3) * 255);
          if (quota > 255) quota = 255;
          e.CellArgs.BarFillColor = EhLibUtils.ApproximateColor(e.CellArgs.BarFillColor, Color.FromArgb(241, 171, 50), quota);
        }

        if (dValue > dataGridProgressBarColumn1.MaxValue)
        {
          e.CellArgs.Font = boldProgressFont;
        }
      }
    }

    private void dataGridProgressBarColumn1_DataCellDisplayValueNeeded(object sender, DataGridDataCellDisplayValueNeededEventArgs e)
    {
      if (!EhLibUtils.DBValueEqual(e.CellArgs.Value, null))
      {
        double dValue = (double)(Decimal)e.CellArgs.Value;
        if (dValue > dataGridProgressBarColumn4.MaxValue)
        {
          e.CellArgs.DisplayValue = ">100%";
          e.Handled = true;
        }
        else if (dValue > 0 && dValue < dataGridProgressBarColumn4.MaxValue / 100 / 2)
        {
          e.CellArgs.DisplayValue = "<1%";
          e.Handled = true;
        }
      }
    }

    private void DataGridProgressBarColumn2_DataCellFormatParamsNeeded(object sender, DataGridProgressBarDataCellFormatParamsNeededEventArgs e)
    {
      if (e.Row == null) return;

      object val = e.Column.GetRowValue(e.Row);
      if (val is decimal)
      {
        double dValue = (double)(decimal)val;

        if (dValue > dataGridProgressBarColumn1.MaxValue / 3)
        {
          e.CellArgs.Font = boldProgressFont;
        }
      }
    }
  }
}
