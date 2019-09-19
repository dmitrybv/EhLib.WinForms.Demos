using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EhLib.WinForms;

namespace MainDemo
{
  public partial class FrameSolSelectRows : MainDemo.BaseFrame
  {

    //List<DataRowView> selectedRows = new List<DataRowView>();
    BindingSource selectedRows = new BindingSource();

    public FrameSolSelectRows()
    {
      InitializeComponent();

      this.countryTableAdapter.Fill(this.biolifeDataSet.country);

      gridSelectedRows.DataSource = selectedRows;

    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      dataGridEh1.Selection.KeepSelection = checkBox1.Checked;
    }

    private void dataGridEh1_SelectionChanged(object sender, DataGridSelectionChangeOperationEventArgs e)
    {
      labelSelInfo.Text = dataGridEh1.Selection.SelectedRowCount.ToString() + " Row(s) selected";

      if (e.ChangeOpType == SelectionChangeOperationType.RowSelected)
        selectedRows.Add(((EhLib.WinForms.DataGridRow)e.ChangingObject).SourceItem);
      else if (e.ChangeOpType == SelectionChangeOperationType.RowDeselected)
        selectedRows.Remove(((EhLib.WinForms.DataGridRow)e.ChangingObject).SourceItem);
      else
      {
        selectedRows.Clear();
        foreach(DataGridRow row in dataGridEh1.Selection.SelectedRows)
        {
          selectedRows.Add(row.SourceItem);
        }
      }
    }

    private void dataGridEh1_Title_CellMouseDown(object sender, DataGridTitleCellMouseEventArgs e)
    {
      if (dataGridEh1.Selection.SelectedRowCount == 0)
        dataGridEh1.Selection.SelectAllRows();
      else
        dataGridEh1.Selection.Clear();
    }

    private void dataGridEh1_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == ' ')
        dataGridEh1.CurrentRow.Selected = !dataGridEh1.CurrentRow.Selected;
    }

    private void dataGridTextColumn1_DataCellValuePull(object sender, DataGridDataValuePullEventArgs e)
    {
      string val = ((DataRowView)(e.Row.SourceItem))["Name"] as string;
      e.Value = val;
      e.Handled = true;
    }
  }
}
