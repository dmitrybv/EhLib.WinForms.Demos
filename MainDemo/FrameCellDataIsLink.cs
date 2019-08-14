using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EhLib.WinForms;
using System.Drawing.Drawing2D;

namespace MainDemo
{
  public partial class FrameCellDataIsLink : BaseFrame
  {
    public FrameCellDataIsLink()
    {
      InitializeComponent();

      this.countryTableAdapter.Fill(this.biolifeDataSet.country);

    }

    private void dataGrid1_Click(object sender, EventArgs e)
    {

    }

    private void dataGridTextColumn6_CellContentClick(object sender, DataGridDataCellEventArgs e)
    {
      string url = colUrl.GetRowDisplayText(e.Row);
      System.Diagnostics.Process.Start(url);
    }

  }
}
