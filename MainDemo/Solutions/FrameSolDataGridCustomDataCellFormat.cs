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
  public partial class FrameSolDataGridCustomDataCellFormat : BaseFrame
  {
    public FrameSolDataGridCustomDataCellFormat()
    {
      InitializeComponent();

      this.countryTableAdapter.Fill(this.biolifeDataSet.country);
    }

    private void dataGrid1_DataCellFormatParamsNeeded(object sender, DataGridDataCellFormatParamsNeededEventArgs e)
    {
      if (e.Row == null) return;
      DataRowView rv = (DataRowView)e.Row.SourceItem;
      BiolifeDataSet.countryRow countryRow = (BiolifeDataSet.countryRow)rv.Row;
      if (!countryRow.IsContinentNull() && countryRow.Continent == "North America")
      {
        e.CellArgs.BackColor = Color.Bisque;
      }
    }

    private void dataGridTextColumn3_DataCellFormatParamsNeeded(object sender, DataGridDataCellFormatParamsNeededEventArgs e)
    {
      if (e.Row == null) return;
      if (EhLibUtils.DBValueEqual(e.Column.GetRowValue(e.Row), "North America"))
        e.CellArgs.Font = new Font(e.CellArgs.Font, FontStyle.Bold);
    }
  }
}
