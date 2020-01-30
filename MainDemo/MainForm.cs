using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml;

namespace MainDemo
{
  public partial class MainForm : Form
  {
    static internal Dictionary<string, string> appUserSettings = new Dictionary<string, string>();

    VarticalMenuCollection vertMenu;
    VarticalMenuCollection vertMenuSolutions;
    BaseFrame curFrame = null;
    string LanguageId;
    EhLib.WinForms.DataGridPrintService gridPrintService = new EhLib.WinForms.DataGridPrintService();

    public MainForm()
    {
      InitializeComponent();
    }

    private void InitVertMenuDemos()
    {
      gridVertMenuDemos.Title.Visible = false;

      vertMenu = new VarticalMenuCollection();

      vertMenu.Add(new VarticalMenuItem() { MenuName = Properties.Resources.MainForm_Demos_MainGrid, RefFrameClass = typeof(FrameMainGrid) });
      vertMenu.Add(new VarticalMenuItem() { MenuName = Properties.Resources.MainForm_Demos_MasterDetail, RefFrameClass = typeof(FrameMasterDetail) });
      vertMenu.Add(new VarticalMenuItem() { MenuName = Properties.Resources.MainForm_Demos_RowsAutoExpent, RefFrameClass = typeof(FrameRowsAutoExpand) });
      vertMenu.Add(new VarticalMenuItem() { MenuName = Properties.Resources.MainForm_Demos_PropertyGrid, RefFrameClass = typeof(FramePropertyGrid) });

      //vertMenu.Add(new VarticalMenuItem() { MenuName = "Edit Controls", RefFrameClass = typeof(FrameEditControls) });
      vertMenu.Add(new VarticalMenuItem() { MenuName = Properties.Resources.MainForm_Demos_SearchBox, RefFrameClass = typeof(FrameSearchBox) });
      vertMenu.Add(new VarticalMenuItem() { MenuName = Properties.Resources.MainForm_Demos_DiferentEditor, RefFrameClass = typeof(FramePolyCellColumn) });
      vertMenu.Add(new VarticalMenuItem() { MenuName = Properties.Resources.MainForm_Demos_CellDataIsLink, RefFrameClass = typeof(FrameCellDataIsLink) });
      vertMenu.Add(new VarticalMenuItem() { MenuName = Properties.Resources.MainForm_Demos_DataGrouping, RefFrameClass = typeof(FrameDataGrouping) });
      vertMenu.Add(new VarticalMenuItem() { MenuName = "Row Detail Panel", RefFrameClass = typeof(FrameRowDetailPanel) });
      vertMenu.Add(new VarticalMenuItem() { MenuName = "Grid TreeView mode", RefFrameClass = typeof(FrameTreeView) });

      //vertMenu.Add(new VarticalMenuItem() { MenuName = "Main GridView (Tmp)", RefFrameClass = typeof(TmpFrameMainGridWithGridView) }); //Debug mode
      //vertMenu.Add(new VarticalMenuItem() { MenuName = "النص العربي", RefFrameClass = typeof(FrameSearchBox) });

      bsVertMenuDemos.DataSource = vertMenu;

    }

    private void InitVertMenuSolutions()
    {
      gridVertMenuSolutions.Title.Visible = false;

      vertMenuSolutions = new VarticalMenuCollection();

      vertMenuSolutions.Add(new VarticalMenuItem()
      {
        MenuName = "DataGridEh Custom DataCell Format",
        RefFrameClass = typeof(FrameSolDataGridCustomDataCellFormat)
      });

      vertMenuSolutions.Add(new VarticalMenuItem()
      {
        MenuName = "DataGridEh Custom Inicator Cell Paint",
        RefFrameClass = typeof(FrameSolDataGridCustomIndicatorCellPaint)
      });

      vertMenuSolutions.Add(new VarticalMenuItem()
      {
        MenuName = "DataGridEh Custom DataCell Paint",
        RefFrameClass = typeof(FrameSolDataGridCustomDataCellPaint)
      });

      vertMenuSolutions.Add(new VarticalMenuItem() {
        MenuName = "DataGridEh Scroll Events",
        RefFrameClass = typeof(FrameSolDataGridScrollEvents)
      });

      vertMenuSolutions.Add(new VarticalMenuItem()
      {
        MenuName = "DataGridEh Autoload in parts",
        RefFrameClass = typeof(FrameSolDataGridAutoDataLoad)
      });

      vertMenuSolutions.Add(new VarticalMenuItem()
      {
        MenuName = "DataGridEh Title Cell Custom Paint and Mouse Click",
        RefFrameClass = typeof(FrameSolDataGridCustomTitleCellPaint)
      });

      vertMenuSolutions.Add(new VarticalMenuItem()
      {
        MenuName = "DataGridEh Indicator Title Cell Custom Paint and Mouse Click",
        RefFrameClass = typeof(FrameSolDataGridCustomIndicatorTitleCellPaint)
      });

      vertMenuSolutions.Add(new VarticalMenuItem()
      {
        MenuName = "DataGridEh Footer Calculation",
        RefFrameClass = typeof(FrameSolDataGridFooterCalculation)
      });

      vertMenuSolutions.Add(new VarticalMenuItem()
      {
        MenuName = "Checked Grid",
        RefFrameClass = typeof(FrameSolSelectRows)
      });

      vertMenuSolutions.Add(new VarticalMenuItem()
      {
        MenuName = "Blank cells in the column",
        RefFrameClass = typeof(FrameSolBlankCell)
      });

      vertMenuSolutions.Add(new VarticalMenuItem()
      {
        MenuName = "Crossed RadioMatrix",
        RefFrameClass = typeof(FrameCrossedRadioMatrix)
      });

      vertMenuSolutions.Add(new VarticalMenuItem()
      {
        MenuName = "Simple TreeView",
        RefFrameClass = typeof(FrameSolSimpleTreeView)
      });

      vertMenuSolutions.Add(new VarticalMenuItem()
      {
        MenuName = "TreeView with External TreeList",
        RefFrameClass = typeof(FrameSolExternalTreeViewList)
      });

      vertMenuSolutions.Add(new VarticalMenuItem()
      {
        MenuName = "Disk Folders Explorer (TreeView)",
        RefFrameClass = typeof(FrameSolFolderExplorer)
      });

      vertMenuSolutions.Add(new VarticalMenuItem()
      {
        MenuName = "Progress bars",
        RefFrameClass = typeof(FrameSolDataGridProgressBars)
      });

      vertMenuSolutions.Add(new VarticalMenuItem()
      {
        MenuName = "DataGridEh: Merge Duplicates",
        RefFrameClass = typeof(FrameSolDataGridMergeDuplicates)
      });

      bsVertMenuSolutions.DataSource = vertMenuSolutions;
    }

    private void UpdateCurrentFrame()
    {
      BindingSource bSource = null;

      if (tabControl1.SelectedTab == tabPageDemos)
        bSource = bsVertMenuDemos;
      else if (tabControl1.SelectedTab == tabPageSolutions)
        bSource = bsVertMenuSolutions;

      BaseFrame uc;
      VarticalMenuItem vim = (bSource.Current as VarticalMenuItem);

      uc = (BaseFrame)vim.RefFrame;
      if (uc == null)
      {
        uc = (BaseFrame)Activator.CreateInstance(vim.RefFrameClass);
        uc.Dock = DockStyle.Fill;
        uc.Parent = splitContainer1.Panel2;
        vim.RefFrame = uc;
      }
      else
      {
        uc.BringToFront();
        uc.Visible = true;
      }

      if (curFrame != null && curFrame != uc)
        curFrame.Visible = false;
      curFrame = uc;
    }

    private void InitMenuItemLanguages()
    {
      miLanguages.DropDownItems.Clear();

      ToolStripMenuItem mi;
      List<CultureInfo> cultList = new List<CultureInfo>(CultureInfo.GetCultures(CultureTypes.AllCultures));
      List<ToolStripItem> miList = new List<ToolStripItem>();

      string[] dirs = Directory.GetDirectories(".");
      List<string> dirList = new List<string>();


      foreach (string dr in dirs)
        dirList.Add(dr.Substring(2));

      foreach (CultureInfo c in cultList)
      {
        if ((String.Compare(c.IetfLanguageTag, "en", true) == 0) ||
             (dirList.Any(p => String.Compare(c.IetfLanguageTag, p, true) == 0))
           )
        {
          mi = new ToolStripMenuItem();
          mi.Text = c.NativeName + " [" + c.IetfLanguageTag + "]";
          mi.Click += LanguageMenu_Click;
          mi.Tag = c;
          if (c.IetfLanguageTag == LanguageId)
            mi.Checked = true;
          miList.Add(mi);
        }
      }

      ToolStripSeparator tss = new ToolStripSeparator();
      miList.Add(tss);

      mi = new ToolStripMenuItem();
      mi.Text = "Auto [" + CultureInfo.InstalledUICulture.IetfLanguageTag + "]";
      mi.Click += LanguageMenu_Click;
      mi.Tag = null;
      if (String.IsNullOrEmpty(LanguageId))
        mi.Checked = true;
      miList.Add(mi);

      miLanguages.DropDownItems.AddRange(miList.ToArray());

    }

    private void SetLocalizableStrings()
    {
      Text = Properties.Resources.MainForm_Caption;
      exitToolStripMenuItem.Text = Properties.Resources.MainForm_MenuExit;
      miLanguages.Text = Properties.Resources.MainForm_MenuLanguage;
      miAbout.Text = Properties.Resources.MainForm_MenuAbout;
      toolStripStatusLabel1.Text = Properties.Resources.MainForm_StatusBarInfo;
      tsbExit.ToolTipText = Properties.Resources.Exit_ToolTip;
      tsbPreview.ToolTipText = Properties.Resources.PrintPreview_ToolTip;
      tsbEditCut.ToolTipText = Properties.Resources.Edit_Cut;
      tsbEditCopy.ToolTipText = Properties.Resources.Edit_Copy;
      tsbEditPaste.ToolTipText = Properties.Resources.Edit_Paste;
      tsbAbout.ToolTipText = Properties.Resources.HelpAbout_ToolTip;
      tsbBiDi.ToolTipText = Properties.Resources.UseUnuseVisualStyles_ToolTip;
      tsbUseVisualStyles.ToolTipText = Properties.Resources.RightToLeft_LeftToRightDirection_ToolTip;
      tabPageDemos.Text = Properties.Resources.MainForm_Demos_Page;
      tabPageSolutions.Text = Properties.Resources.MainForm_Solutions_Page;
    }

    private void SetAppLanguage()
    {
      if (String.IsNullOrEmpty(LanguageId)) return;

      List<CultureInfo> cultList = new List<CultureInfo>(CultureInfo.GetCultures(CultureTypes.AllCultures));

      foreach (var c in cultList)
      {
        if (String.Compare(c.IetfLanguageTag, LanguageId, true) == 0)
        {
          Thread.CurrentThread.CurrentUICulture = c;
          break;
        }
      }
    }

    private void LanguageMenu_Click(object sender, EventArgs e)
    {
      CultureInfo ci = (CultureInfo)(((ToolStripMenuItem)sender).Tag);
      string langName;

      if (ci == null)
      {
        langName = "(Autodeteced)";
        LanguageId = "";
      }
      else
      {
        langName = ci.DisplayName;
        LanguageId = ci.IetfLanguageTag;
      }

      string s = "The " + langName + " language was selected.\n";
      s = s + "The program must be restarted for the settings to take effect.\n";
      s = s + "Press Ok to restart, Cancel to stay in the application.";

      DialogResult dialogResult = MessageBox.Show(s, "Confirm application restart", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
      if (dialogResult == DialogResult.OK)
      {
        Application.Restart();
        //Environment.Exit(0);
      }
    }

    private void miAbout_Click(object sender, EventArgs e)
    {
      FormAbout fa = new FormAbout();
      fa.ShowDialog();
    }

    private void tsbAbout_Click(object sender, EventArgs e)
    {
      miAbout_Click(sender, e);
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void bsVertMenu_PositionChanged(object sender, EventArgs e)
    {
      UpdateCurrentFrame();
    }

    private void bsVertMenuSolutions_PositionChanged(object sender, EventArgs e)
    {
      UpdateCurrentFrame();
    }

    private void MainForm_RightToLeftChanged(object sender, EventArgs e)
    {
    }

    private void TsbBiDi_Click(object sender, EventArgs e)
    {
      if (RightToLeft == RightToLeft.No)
      {
        RightToLeft = RightToLeft.Yes;
        RightToLeftLayout = true;
      }
      else
      {
        RightToLeft = RightToLeft.No;
        RightToLeftLayout = false;
      }
    }

    private void MainForm_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F11)
        Form_PorpertiesGrid.ShowPropertiesGridFormForFocused();
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
      if (Application.VisualStyleState == VisualStyleState.ClientAndNonClientAreasEnabled)
        Application.VisualStyleState = VisualStyleState.NoneEnabled;
      else
        Application.VisualStyleState = VisualStyleState.ClientAndNonClientAreasEnabled;
    }

    protected virtual void LoadSettingsAsJSonStr(string settings)
    {
      if (String.IsNullOrEmpty(settings)) return;

      JavaScriptSerializer serializer = new JavaScriptSerializer();
      Dictionary<string, object> fs = serializer.Deserialize<Dictionary<string, object>>(settings);
      //fs.InitForm(this);
      ReadStorableSettings(fs);
    }

    protected virtual void ReadStorableSettings(Dictionary<string, object> settings)
    {
      object LanguageIdObj;
      if (settings.TryGetValue("LanguageId", out LanguageIdObj))
      {
        if (LanguageIdObj != null)
          LanguageId = LanguageIdObj.ToString();
      }

      object locationObj;
      if (settings.TryGetValue("Location", out locationObj))
      {
        if (locationObj is Point)
          Location = (Point)locationObj;
        else if (locationObj is Dictionary<string, object>)
        {
          Dictionary<string, object> locDic = locationObj as Dictionary<string, object>;
          object o;
          Point location = Location;
          locDic.TryGetValue("X", out o);
          if (o is int) location.X = (int)o;
          locDic.TryGetValue("Y", out o);
          if (o is int) location.Y = (int)o;
          Location = location;
        }
      }

      object sizeObj;
      if (settings.TryGetValue("Size", out sizeObj))
      {
        if (sizeObj is Size)
          Size = (Size)sizeObj;
        else if (locationObj is Dictionary<string, object>)
        {
          Dictionary<string, object> sizeDic = sizeObj as Dictionary<string, object>;
          object o;
          Size size = Size;
          sizeDic.TryGetValue("Width", out o);
          if (o is int) size.Width = (int)o;
          sizeDic.TryGetValue("Height", out o);
          if (o is int) size.Height = (int)o;
          Size = size;
        }
      }

      object controlsObj;
      if (settings.TryGetValue("Controls", out controlsObj))
      {
        if (controlsObj is Dictionary<string, object>)
        {
          Dictionary<string, object> controls = (Dictionary<string, object>)controlsObj;

          foreach (KeyValuePair<string, object> di in controls)
          {
            Control ctl = FindSettingsControl(this, di.Key);
            EhLib.WinForms.DataGridEh grid = ctl as EhLib.WinForms.DataGridEh;
            Dictionary<string, object> controlSettings = di.Value as Dictionary<string, object>;
            if (grid != null && controlSettings != null)
              grid.ReadStorableSettings(controlSettings);
          }
        }
      }
    }

    protected Control FindSettingsControl(Control rootControl,  string key)
    {
      Control result = null;

      foreach (Control c in rootControl.Controls)
      {
        if (String.Equals(key, c.Name, StringComparison.OrdinalIgnoreCase))
          return c;
        if (!(c is BaseFrame))
          result = FindSettingsControl(c, key);
        if (result != null) return result;
      }

      return result;
    }

    protected string GetSettingsAsJSonStr()
    {
      JavaScriptSerializer serializer = new JavaScriptSerializer();
      //FormSettingsKeeper fs = GetFormSettingsKeeper();
      Dictionary<string, object> fs = GetStorableSettings();
      string json = serializer.Serialize(fs);
      return json;
    }

    protected virtual Dictionary<string, object> GetStorableSettings()
    {
      var settingsDic = new Dictionary<string, object>();

      settingsDic.Add("LanguageId", LanguageId);

      settingsDic.Add("Location", Location);
      settingsDic.Add("Size", Size);

      var controlsDic = new Dictionary<string, object>();
      InitControlsSettings(controlsDic);
      if (controlsDic.Count > 0)
        settingsDic.Add("Controls", controlsDic);

      return settingsDic;
    }

    protected virtual void InitControlsSettings(Dictionary<string, object> controlsSettings)
    {
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      System.Reflection.Assembly ehLibAssemly = typeof(EhLib.WinForms.DataGridEh).Assembly;
      Version ehLibVer = typeof(EhLib.WinForms.DataGridEh).Assembly.GetName().Version;
      string ver = "Version " + ehLibVer.Major.ToString() + "." + ehLibVer.Minor.ToString();
      string build = "Build " + ehLibVer.Major.ToString() + "." +
                               ehLibVer.Minor.ToString() + "." +
                               ehLibVer.Build.ToString();

      appUserSettings = LoadSettingsFile();

      if (appUserSettings.ContainsKey("MainFormSettings"))
        LoadSettingsAsJSonStr(appUserSettings["MainFormSettings"]);

      SetAppLanguage();
      InitMenuItemLanguages();
      SetLocalizableStrings();
      InitVertMenuDemos();
      InitVertMenuSolutions();
      UpdateCurrentFrame();

      string key = curFrame.SettingKey();
      if (!String.IsNullOrEmpty(key) && appUserSettings.ContainsKey(key))
        curFrame.LoadSettingsAsJSonStr(appUserSettings[key]);

      Text = Text + ".  EhLib.WinForms " + ver + " " + build;
    }

    static internal Dictionary<string, string> LoadSettingsFile()
    {
      Dictionary<string, string> u = new Dictionary<string, string>();

      string filePath = Application.ExecutablePath + ".dsk";

      if (File.Exists(filePath))
      {
        dynamic xmlStr = File.ReadAllText(filePath);
        if (string.IsNullOrEmpty(xmlStr) == false)
        {
          XmlDocument doc = new XmlDocument();
          doc.Load(filePath);
          XmlNode root = doc.LastChild;
          if (root.Name == "Settings")
          {
            foreach (XmlNode node in root.ChildNodes)
            {
              u[node.Name] = node.InnerText;
            }
          }
        }
      }
      return u;
    }

    private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      string key = curFrame.SettingKey();
      if (!String.IsNullOrEmpty(key))
        appUserSettings[curFrame.SettingKey()] = curFrame.GetSettingsAsJSonStr();

      string settings = GetSettingsAsJSonStr();
      appUserSettings["MainFormSettings"] = settings;

      if (appUserSettings != null)
        SaveSettingsFile(appUserSettings);
    }

    static internal void SaveSettingsFile(Dictionary<string, string> u)
    {
      XmlDocument doc = new XmlDocument();
      XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
      doc.AppendChild(docNode);
      XmlNode body = doc.CreateElement("Settings");
      doc.AppendChild(body);

      foreach (var v in u)
      {
        XmlNode newElem = doc.CreateElement(v.Key);
        string outputjson = v.Value;
        XmlText newTextElem = doc.CreateTextNode(outputjson);
        newElem.AppendChild(newTextElem);
        body.AppendChild(newElem);
      }

      doc.PreserveWhitespace = true;

      string fileXmlPath = Application.ExecutablePath + ".dsk";

      XmlWriterSettings settings = new XmlWriterSettings
      {
        Indent = true,
        IndentChars = "  ",
        NewLineChars = "\r\n",
        NewLineHandling = NewLineHandling.Replace
      };
      using (XmlWriter writer = XmlWriter.Create(fileXmlPath, settings))
      {
        doc.Save(writer);
      }
      //doc.Save(fileXmlPath);
    }

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
      UpdateCurrentFrame();
    }

    private void mainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }

    private void tsbPreview_Click(object sender, EventArgs e)
    {
      EhLib.WinForms.DataGridEh activeGrid = EhLib.WinForms.EhLibUtils.GetFocusControl() as EhLib.WinForms.DataGridEh;
      if (activeGrid != null)  
      {
        gridPrintService.PrintPreview(activeGrid);
      }
    }

    private void tsbObjectInspector_Click(object sender, EventArgs e)
    {
      Form_PorpertiesGrid.ShowPropertiesGridFormForFocused();
    }
  }
}
