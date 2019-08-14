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
  public partial class MDIChildFormCountries : BaseForm
  {
    public MDIChildFormCountries()
    {
      InitializeComponent();
    }


    static MDIChildFormCountries mdiForm;

    public static MDIChildFormCountries CreateOrSelectForm(Form mdiParent)
    {
      if (mdiForm == null)
      {
        mdiForm = new MDIChildFormCountries();
      }

      mdiForm.MdiParent = mdiParent;
      mdiForm.Show();
      mdiForm.BringToFront();

      return mdiForm;
    }

    protected override string GetSettingsID()
    {
      return "MDIChildFormCountries";
    }

    protected override void GetFormControlsSettings(Dictionary<string, object> controlsSettings)
    {
      controlsSettings.Add("dataGridEh1", dataGridEh1.GetStorableSettings());
    }

    private void MDIChildForm_Load(object sender, EventArgs e)
    {
      //// TODO: This line of code loads data into the 'dBTestDataSet.country' table. You can move, or remove it, as needed.
      //this.countryTableAdapter.Fill(this.dBTestDataSet.country);
      dBTestDataSet.LoadDataFile();

      LoadSettings();
    }

    private void MDIChildFormCountries_FormClosed(object sender, FormClosedEventArgs e)
    {
      mdiForm = null;
    }
  }
}
