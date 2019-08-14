using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MainDemo
{
  public partial class FramePropertyGrid : MainDemo.BaseFrame
  {
    public FramePropertyGrid()
    {
      InitializeComponent();
    }

    private void biolifeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.biolifeBindingSource.EndEdit();
      this.tableAdapterManager.UpdateAll(this.biolifeDataSet);

    }

    private void FrameVertGrid_Load(object sender, EventArgs e)
    {
      biolifeTableAdapter.Fill(biolifeDataSet.Biolife);
    }

    private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
    {

    }
  }
}
