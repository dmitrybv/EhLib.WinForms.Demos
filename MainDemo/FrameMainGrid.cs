using System;
using System.Collections;
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
  public partial class FrameMainGrid : BaseFrame
  {
    public FrameMainGrid()
    {
      InitializeComponent();

      //dataGrid1.AutoGenerateColumns = true;
      dataGrid1.AutoSizeColumnOptions.FitToClient = false;

      label1.Text = Properties.Resources.MainForm_Demos_MainGrid;
      colOrdedId.Title.Text = Properties.Resources.MainGrid_OrderID_Title;
      superTitleEmployee.Text = Properties.Resources.MainGrid_Employee_Title;
      colEmpId.Title.Text = Properties.Resources.MainGrid_ID_Title;
      colComboBoxEmpName.Title.Text = Properties.Resources.MainGrid_Name_Title;
      dataGridSuperTitle1.Text = Properties.Resources.MainGrid_Customer_Title;
      colCustId.Title.Text = Properties.Resources.MainGrid_ID_Title;
      dataGridComboBoxColumn1.Title.Text = Properties.Resources.MainGrid_Name_Title;
      colShipFee.Title.Text = Properties.Resources.MainGrid_Freight_Title;
      dataGridSuperTitle2.Text = Properties.Resources.MainGrid_Dates_Title;
      colOrdDate.Title.Text = Properties.Resources.MainGrid_Required_Title;
      colShipDate.Title.Text = Properties.Resources.MainGrid_Shipped_Title;
      colShipperId.Title.Text = Properties.Resources.MainGrid_ShipperId_Title;
      colShipName.Title.Text = Properties.Resources.MainGrid_ShipperName_Title;

      this.ordersTableAdapter.Fill(this.northwindDataSet.Orders);

      new MainDemo.NorthwindDataSetTableAdapters.EmployeesTableAdapter().Fill(this.northwindDataSet.Employees);
      new MainDemo.NorthwindDataSetTableAdapters.CustomersTableAdapter().Fill(this.northwindDataSet.Customers);

    }

    public override string SettingKey()
    {
      return "FrameMainGrid";
    }

    protected override void InitControlsSettings(Dictionary<string, object> controlsSettings)
    {
      controlsSettings.Add("dataGrid1", dataGrid1.GetStorableSettings());
    }

    private void dataGrid1_Click(object sender, EventArgs e)
    {
        
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //DataGridComboBoxColumn cbc = new DataGridComboBoxColumn();
      //dataGrid1.StaticColumns.Add(cbc);
      colComboBoxEmpName.DisplayMember = "Name";
      colComboBoxEmpName.ValueMember = "ID";

    }

    private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {

    }

    private void pictureBox1_Paint(object sender, PaintEventArgs e)
    {
//      object obj = EhLib.Properties.Resources.ResourceManager.GetObject("EhLib.EhLib_DataGrid", EhLib.Properties.Resources.Culture);
//      if (obj is System.Drawing.Bitmap)
//        e.Graphics.DrawImage(obj as System.Drawing.Bitmap, 1, 1);
////      e.Graphics.DrawImage(EhLib.Properties.Resources.EhLib_DataGrid, 1, 1);
      string[] reses = GetResourceNames();
    }

    public static string[] GetResourceNames()
    {
      var asm = typeof(EhLib.WinForms.DataGridEh).Assembly;
      return asm.GetManifestResourceNames();
      //string resName = asm.GetName().Name + ".g.resources";
      //using (var stream = asm.GetManifestResourceStream(resName))
      //using (var reader = new System.Resources.ResourceReader(stream))
      //{
      //  return reader.Cast<DictionaryEntry>().Select(entry => (string)entry.Key).ToArray();
      //}
    }

  }
}
