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
  public partial class MDIChildFormCustomers : BaseForm
  {
    public MDIChildFormCustomers()
    {
      InitializeComponent();
    }

    static MDIChildFormCustomers mdiForm;

    public static MDIChildFormCustomers CreateOrSelectForm(Form mdiParent)
    {
      if (mdiForm == null)
      {
        mdiForm = new MDIChildFormCustomers();
      }

      mdiForm.MdiParent = mdiParent;
      mdiForm.Show();
      mdiForm.BringToFront();

      return mdiForm;
    }

    protected override string GetSettingsID()
    {
      return "MDIChildFormCustomers";
    }

    protected override void GetFormControlsSettings(Dictionary<string, object> controlsSettings)
    {
      controlsSettings.Add("dataGridEh1", dataGridEh1.GetStorableSettings());
    }

    private void MDIChildForm_Load(object sender, EventArgs e)
    {
      //// TODO: This line of code loads data into the 'dBTestDataSet.Customers' table. You can move, or remove it, as needed.
      //this.customersTableAdapter.Fill(this.dBTestDataSet.Customers);
      dBTestDataSet.LoadDataFile();

      LoadSettings();
    }

    private void MDIChildFormCustomers_FormClosed(object sender, FormClosedEventArgs e)
    {
      mdiForm = null;
    }
  }
}
