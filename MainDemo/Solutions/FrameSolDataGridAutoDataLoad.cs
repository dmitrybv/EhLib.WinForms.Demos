using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MainDemo
{
  public partial class FrameSolDataGridAutoDataLoad : BaseFrame
  {

    // Number of cities already loaded: the start position of the next portion
    int loadedCount = 0;

    public FrameSolDataGridAutoDataLoad()
    {
      InitializeComponent();
      fillToolStripButton_Click(null, null);
    }

    private void citiesTop100BindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.citiesBSource.EndEdit();
      this.cities10000DataSet.AcceptChanges();
    }

    private void fillToolStripButton_Click(object sender, EventArgs e)
    {
      try
      {
        cities10000DataSet.LoadCitiesTop100(loadedCount, 100);
        loadedCount += cities10000DataSet.CitiesTop100.Rows.Count;
        cities10000DataSet.Cities1000Small.Merge(cities10000DataSet.CitiesTop100);
      }
      catch (System.Exception ex)
      {
        System.Windows.Forms.MessageBox.Show(ex.Message);
      }

    }

    private void dataGrid1_VertScrollBar_ScrollPosChanged(object sender, EventArgs e)
    {
      EhLib.WinForms.DataGridVertScrollBar sb = dataGrid1.VertScrollBar;
      //label2.Text = sb.ScrollPos.ToString() + ":" + sb.RollSize.ToString() + ":" + sb.ViewportSize.ToString();
      if (sb.ScrollPos + sb.ViewportSize == sb.RollSize)
        fillToolStripButton_Click(null, null);
    }
  }
}
