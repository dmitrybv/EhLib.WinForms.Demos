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
  public partial class FrameMasterDetail : BaseFrame
  {
    public FrameMasterDetail()
    {
      InitializeComponent();

      ordersTableAdapter.Fill(northwindDataSet.Orders);
      order_DetailsTableAdapter.Fill(northwindDataSet.Order_Details);

      dataGridTextColumn3.BackColor = Color.FromArgb(100, Color.Red);
      dataGridTextColumn3.BackColor = Color.FromArgb(127, Color.FromArgb(0x00FFC35C));
      
    }

    private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.ordersBindingSource.EndEdit();
      this.tableAdapterManager.UpdateAll(this.northwindDataSet);

    }
  }
}
