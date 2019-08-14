using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainDemo
{
  public partial class FrameSearchBox : BaseFrame
  {
    public FrameSearchBox()
    {
      InitializeComponent();

      customersTableAdapter.Fill(northwindDataSet.Customers);

    }

    private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.customersBindingSource.EndEdit();
      this.tableAdapterManager.UpdateAll(this.northwindDataSet);

    }

    private void bFilterOnTyping_Click(object sender, EventArgs e)
    {
      dataGrid1.SearchBox.FilterOnTyping = !dataGrid1.SearchBox.FilterOnTyping;
      if (dataGrid1.SearchBox.FilterOnTyping)
        bFilterOnTyping.Text = "Filter On Typing (Yes)";
      else
        bFilterOnTyping.Text = "Filter On Typing (No)";
    }

    private void bPersistentShow_Click(object sender, EventArgs e)
    {
      dataGrid1.SearchBox.PersistentShowing = !dataGrid1.SearchBox.PersistentShowing;
      if (dataGrid1.SearchBox.PersistentShowing)
        bPersistentShow.Text = "Persistent Show (Yes)";
      else
        bPersistentShow.Text = "Persistent Show (No)";
    }

    private void bFilterEnabled_Click(object sender, EventArgs e)
    {
      dataGrid1.SearchBox.FilterEnabled = !dataGrid1.SearchBox.FilterEnabled;
      if (dataGrid1.SearchBox.FilterEnabled)
        bFilterEnabled.Text = "Filter Enabled (Yes)";
      else
        bFilterEnabled.Text = "Filter Enabled (No)";
    }
  }
}
