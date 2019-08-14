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

namespace MainDemo
{
  public partial class TmpFrameMainGridWithGridView : BaseFrame
  {
    public TmpFrameMainGridWithGridView()
    {
      InitializeComponent();

      //colShipFee.Footers[0].ValueFunction = DataGridFooterValueFunction.Sum;

      this.ordersTableAdapter.Fill(this.northwindDataSet.Orders);

      new MainDemo.NorthwindDataSetTableAdapters.EmployeesTableAdapter().Fill(this.northwindDataSet.Employees);
      new MainDemo.NorthwindDataSetTableAdapters.CustomersTableAdapter().Fill(this.northwindDataSet.Customers);

    }

    private void dataGrid1_Click(object sender, EventArgs e)
    {
        
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //DataGridComboBoxColumn cbc = new DataGridComboBoxColumn();
      //dataGrid1.StaticColumns.Add(cbc);
      //colComboBoxEmpName.DisplayMember = "Name";
      //colComboBoxEmpName.ValueMember = "ID";

    }

    private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
  }
}
