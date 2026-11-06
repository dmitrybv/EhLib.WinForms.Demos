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
      this.biolifeDataSet.AcceptChanges();
    }

    private void FrameVertGrid_Load(object sender, EventArgs e)
    {
      biolifeDataSet.LoadBiolife();
    }

    private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
    {

    }
  }
}
