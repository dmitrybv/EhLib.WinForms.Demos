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

      this.biolifeDataSet.LoadCountry();

    }

    private void dataGrid1_Click(object sender, EventArgs e)
    {

    }

    private void dataGridTextColumn6_CellContentClick(object sender, DataGridDataCellEventArgs e)
    {
      string url = colUrl.GetRowDisplayText(e.Row);
      System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo(url);
      startInfo.UseShellExecute = true;
      System.Diagnostics.Process.Start(startInfo);
    }

  }
}
