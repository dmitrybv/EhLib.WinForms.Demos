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
  public partial class FrameSolBlankCell : MainDemo.BaseFrame
  {
    public FrameSolBlankCell()
    {
      InitializeComponent();

      this.employeesTableAdapter.Fill(this.northwindDataSet.Employees);
    }

    private void dataGridEh1RegionColumn_DataCellManagerNeeded(object sender, DataGridDataCellManagerNeededEventArgs e)
    {
      object val = dataGridEh1CountryColumn.GetRowValue(e.Row);
      if (!EhLibUtils.DBValueEqual("USA", val))
        e.CellManager = blankCell;
    }
  }
}
