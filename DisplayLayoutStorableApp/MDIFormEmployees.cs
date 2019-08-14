using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DisplayLayoutStorableApp
{
  public partial class MDIChildFormEmployees : BaseForm
  {
    public MDIChildFormEmployees()
    {
      InitializeComponent();
    }

    static MDIChildFormEmployees mdiForm;

    public static MDIChildFormEmployees CreateOrSelectForm(Form mdiParent)
    {
      if (mdiForm == null)
      {
        mdiForm = new MDIChildFormEmployees();
      }

      mdiForm.MdiParent = mdiParent;
      mdiForm.Show();
      mdiForm.BringToFront();

      return mdiForm;
    }

    protected override string GetSettingsID()
    {
      return "MDIChildFormEmployees";
    }

    protected override void GetFormControlsSettings(Dictionary<string, object> controlsSettings)
    {
      controlsSettings.Add("dataGridEh1", dataGridEh1.GetStorableSettings());
    }

    private void MDIChildForm_Load(object sender, EventArgs e)
    {
      //// TODO: This line of code loads data into the 'dBTestDataSet.Employees' table. You can move, or remove it, as needed.
      //this.employeesTableAdapter.Fill(this.dBTestDataSet.Employees);
      dBTestDataSet.LoadDataFile();

      LoadSettings();
    }

    private void MDIChildFormEmployees_FormClosed(object sender, FormClosedEventArgs e)
    {
      mdiForm = null;
    }
  }
}
