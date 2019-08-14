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

    int lastMaxId = 0; 

    public FrameSolDataGridAutoDataLoad()
    {
      InitializeComponent();
      fillToolStripButton_Click(null, null);
    }

    private void citiesTop100BindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.citiesBSource.EndEdit();
      this.tableAdapterManager.UpdateAll(this.cities10000DataSet);

    }

    private void fillToolStripButton_Click(object sender, EventArgs e)
    {
      try
      {
        citiesTop100TableAdapter.Fill(cities10000DataSet.CitiesTop100, new Nullable<int>(lastMaxId));

        object lastMaxIdObj = cities10000DataSet.CitiesTop100.Compute("Max(geonameid)", "");
        if (!EhLib.WinForms.EhLibUtils.DBValueEqual(lastMaxIdObj,null))
          lastMaxId = (int)lastMaxIdObj;
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
