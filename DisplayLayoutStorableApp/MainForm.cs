using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DisplayLayoutStorableApp
{
  public partial class MainForm : BaseForm
  {
    ArrayList MdiChildrenList = new ArrayList();
    private bool firstActive = true;
    private MdiClient mdiClient;
    private string formBackText;

    public MainForm()
    {
      InitializeComponent();

      foreach (var control in Controls)
      {
        if (control is MdiClient)
        {
          mdiClient = control as MdiClient;
          break;
        }
      }

      if (mdiClient != null)
      {
        mdiClient.Paint += OnMdiClientPaint;
        mdiClient.Resize += MdiClient_Resize;
      }

      formBackText = "Open File->Country Menu item to open Country MDIClient Form \n" +
        "Then resize and move columns in the Grid \n" +
        "Select File->Exit menu to close Application \n" +
        "Then launch Application to see how it restore Forms, Form positions and Grid columns state";
    }

    protected override Dictionary<string, object> GetStorableSettings()
    {
      Dictionary<string, object> result = base.GetStorableSettings();
      result.Add("MdiChildrenList", MdiChildrenList);
      return result;
    }

    protected override void ReadStorableSettings(SettingsDictionaryGroup settingsGroup)
    {
      base.ReadStorableSettings(settingsGroup);

      object valAsObj;
      if (settingsGroup.Dic.TryGetValue("MdiChildrenList", out valAsObj))
      {
        if (valAsObj is ArrayList)
          MdiChildrenList = (ArrayList)valAsObj;
      }
    }

    protected override string GetSettingsID()
    {
      return "MainForm";
    }

    private void NewChildFormToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MDIChildFormCountries.CreateOrSelectForm(this);
    }

    private void MiCustomers_Click(object sender, EventArgs e)
    {
      MDIChildFormCustomers.CreateOrSelectForm(this);
    }

    private void MiEmployees_Click(object sender, EventArgs e)
    {
      MDIChildFormEmployees.CreateOrSelectForm(this);
    }

    private void WindowCascadeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.LayoutMdi(MdiLayout.Cascade);
    }

    private void WindowTileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.LayoutMdi(MdiLayout.TileVertical);
    }

    private void WindowTileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.LayoutMdi(MdiLayout.TileHorizontal);
    }

    private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      MdiChildrenList.Clear();
      while (MdiChildren.Length > 0)
      {
        Form f = ActiveMdiChild;
        MdiChildrenList.Add(f.GetType().FullName);
        f.Close();
        if (!f.IsDisposed) return;
      }
      MdiChildrenList.Reverse();
    }

    private void MainForm_Activated(object sender, EventArgs e)
    {
      if (firstActive && Visible)
      {
        firstActive = false;
        foreach (var mdiFormObjName in MdiChildrenList)
        {
          string mdiFormName = (string)mdiFormObjName;
          Type t = Type.GetType(mdiFormName);
          if (t != null)
          {
            MethodInfo statMethod = t.GetMethod("CreateOrSelectForm", BindingFlags.Static | BindingFlags.Public);
            if (statMethod != null)
              statMethod.Invoke(null, new object[] { this });
          }
        }
      }
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      LoadSettings();
    }

    private void OnMdiClientPaint(object sender, PaintEventArgs e)
    {
      //e.Graphics.FillRectangle(Brushes.Blue, mdiClient.ClientRectangle);
      Rectangle drawRect = new Rectangle(Point.Empty, mdiClient.ClientSize);
      drawRect.Inflate(-4, -4);
      EhLib.WinForms.EhLibUtils.DrawText(e.Graphics, formBackText, Font, drawRect,
        SystemColors.WindowFrame, HorizontalAlignment.Left, VerticalAlignment.Top, EhLib.WinForms.TextFormatFlagsEh.None);
    }

    private void MdiClient_Resize(object sender, EventArgs e)
    {
      mdiClient.Invalidate();
    }

  }
}
