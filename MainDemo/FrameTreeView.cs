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
  public partial class FrameTreeView : BaseFrame
  {
    public FrameTreeView()
    {
      InitializeComponent();
      testTreeBindingNavigator.BindingSource = dataGridEh1.DataViewBindingSource;
    }

    private void FrameTreeView_Load(object sender, EventArgs e)
    {
      testTreeTableAdapter.Fill(biolifeDataSet.TestTree);
    }

    private void checkBox1_Click(object sender, EventArgs e)
    {
      dataGridEh1.TreeView.TreeListActive = checkBox1.Checked;
    }

    private void testTreeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.testTreeBindingSource.EndEdit();
      this.tableAdapterManager.UpdateAll(this.biolifeDataSet);

    }

    private void dataGridEh1_TreeView_NewNodeInit(object sender, EhLib.WinForms.DataGridTreeViewNewNodeInitEventArgs e)
    {
      DataRowView rowView = e.Row.SourceItem as DataRowView;
      object ExpandedObj = rowView["Expanded"];
      if (!EhLibUtils.DBValueEqual(ExpandedObj, null) &&
          (int)ExpandedObj == 1)
        e.Node.Expanded = true;
      else
        e.Node.Expanded = false;
    }
  }
}
