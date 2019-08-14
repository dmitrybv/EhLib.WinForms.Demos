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
  public partial class FramePolyCellColumn : BaseFrame
  {
    public FramePolyCellColumn()
    {
      InitializeComponent();

      DataRowView row = (DataRowView)bsPolyCellColumnTable.AddNew();
      row[0] = "Text value";
      row[1] = "Text";
      row[2] = typeof(System.String);
      row[3] = textDataCell1;

      row = (DataRowView)bsPolyCellColumnTable.AddNew();
      row[0] = "Masked text value";
      row[1] = "23:20";
      row[2] = typeof(System.String);
      row[3] = maskedTextDataCell1;

      row = (DataRowView)bsPolyCellColumnTable.AddNew();
      row[0] = "Boolean value as Checkbox";
      row[1] = true;
      row[2] = typeof(System.Boolean);
      row[3] = checkBoxDataCell1;

      row = (DataRowView)bsPolyCellColumnTable.AddNew();
      row[0] = "Boolean value as Readiobox";
      row[1] = true;
      row[2] = typeof(System.Boolean);
      row[3] = radioButtonDataCell1;

      row = (DataRowView)bsPolyCellColumnTable.AddNew();
      row[0] = "Combobox text(Yes, No)";
      row[1] = "Yes";
      row[2] = typeof(System.String);
      row[3] = comboBoxDataCell1;

      row = (DataRowView)bsPolyCellColumnTable.AddNew();
      row[0] = "Image value ";
      row[1] = Properties.Resources.EhLibBrand32;
      row[2] = typeof(System.Drawing.Bitmap);
      row[3] = imageDataCell1;

      row = (DataRowView)bsPolyCellColumnTable.AddNew();
      row[0] = "ProgressBar (Deicmal)";
      row[1] = 33;
      row[2] = typeof(System.Int32);
      row[3] = progressBarDataCell1;

      row = (DataRowView)bsPolyCellColumnTable.AddNew();
      row[0] = "Button";
      row[1] = "Button Text";
      row[2] = typeof(System.String);
      row[3] = buttonDataCell1;

      row = (DataRowView)bsPolyCellColumnTable.AddNew();
      row[0] = "Date";
      row[1] = DateTime.Today;
      row[2] = typeof(System.DateTime);
      row[3] = dateTimeDataCell1;

      row = (DataRowView)bsPolyCellColumnTable.AddNew();
      row[0] = "Blank";
      row[1] = "";
      row[2] = typeof(System.String);
      row[3] = blankDataCell1;

      bsPolyCellColumnTable.Position = 0;

    }

    private void dataGrid1_Click(object sender, EventArgs e)
    {

    }

    private void dataGridDynaCellColumn1_QueryDataCellObject(object sender, EhLib.WinForms.DataGridDataCellManagerNeededEventArgs e)
    {
      DataRowView rv = (DataRowView)e.Row.SourceItem;
      object value = rv[3];
      if (!(value is DBNull))
        e.CellManager = (BaseGridCellManager)value;
    }

    private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
    {
    }

    private void dataGrid1_BindingContextChanged(object sender, EventArgs e)
    {
      //dataGrid1.Rows[3].Height = Properties.Resources.EhLibBrand32.Height;
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
      foreach (DataGridColumn col in dataGrid1.StaticColumns)
        col.Frozen = DataGridColumnFrozenState.ToLeftSide;
    }

    private void dataGridTextColumn3_DataCellPullValue(object sender, DataGridDataCellPullValueEventArgs e)
    {
      object val = dataGridDynaCellColumn1.GetRowValue(e.Row);
      if (val != null)
        e.Value = val.GetType().ToString();
      else
        e.Value = "<null>";
      e.Handled = true;
    }

    private void dataGridTextColumn2_DataCellPushValue(object sender, DataGridDataCellPushValueEventArgs e)
    {
      DataRowView row = (DataRowView)e.Row.SourceItem;

      TypeConverter converter = TypeDescriptor.GetConverter((Type)row[2]);
      e.Value = converter.ConvertFrom(e.Value);
    }
  }
}
