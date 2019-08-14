using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.Script.Serialization;

namespace DisplayLayoutStorableApp
{
  public partial class BaseForm : Form
  {
    public BaseForm()
    {
      InitializeComponent();
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
      base.OnFormClosed(e);

      string settings = GetSettingsAsJSonStr();
      string sID = GetSettingsID();

      if (!String.IsNullOrEmpty(sID))
        Program.appUserSettings[sID] = settings;
    }

    protected string GetSettingsAsJSonStr()
    {
      JavaScriptSerializer serializer = new JavaScriptSerializer();
      Dictionary<string, object> fs = GetStorableSettings();
      string json = serializer.Serialize(fs);
      return json;
    }

    protected virtual string GetSettingsID()
    {
      return null;
    }

    //
    //Save settings
    //
    protected virtual Dictionary<string, object> GetStorableSettings()
    {
      var settingsDic = new Dictionary<string, object>();

      GetFormPropertiesSettings(settingsDic);

      var controlsDic = new Dictionary<string, object>();
      GetFormControlsSettings(controlsDic);
      if (controlsDic.Count > 0)
        settingsDic.Add("Controls", controlsDic);

      return settingsDic;
    }

    protected virtual void GetFormPropertiesSettings(Dictionary<string, object> settingsDic)
    {
      settingsDic.Add("WindowState", WindowState.ToString());
      if (WindowState == FormWindowState.Normal)
      {
        settingsDic.Add("Location", Location);
        settingsDic.Add("Size", Size);
      }
      else
      {
        settingsDic.Add("Location", RestoreBounds.Location);
        settingsDic.Add("Size", RestoreBounds.Size);
      }
    }

    protected virtual void GetFormControlsSettings(Dictionary<string, object> controlsSettings)
    {
    }

    //
    // Load Settings
    //
    protected virtual void LoadSettings()
    {
      string sID = GetSettingsID();
      if (!String.IsNullOrEmpty(sID) && Program.appUserSettings.ContainsKey(sID))
        LoadSettingsAsJSonStr(Program.appUserSettings[sID]);
    }

    protected virtual void LoadSettingsAsJSonStr(string settings)
    {
      JavaScriptSerializer serializer = new JavaScriptSerializer();
      SettingsDictionaryGroup sdg = new SettingsDictionaryGroup();
      sdg.Dic = serializer.Deserialize<Dictionary<string, object>>(settings);
      //fs.InitForm(this);
      ReadStorableSettings(sdg);
    }

    protected virtual void ReadStorableSettings(SettingsDictionaryGroup settingsGroup)
    {
      Location = settingsGroup.GetValue("Location", Location);

      Size = settingsGroup.GetValue("Size", Size);

      object controlsObj;
      if (settingsGroup.Dic.TryGetValue("Controls", out controlsObj))
      {
        if (controlsObj is Dictionary<string, object>)
        {
          Dictionary<string, object> controls = (Dictionary<string, object>)controlsObj;

          foreach (KeyValuePair<string, object> di in controls)
          {
            Control[] ctrls = Controls.Find(di.Key, true);
            if (ctrls.Length != 1) continue;
            EhLib.WinForms.DataGridEh grid = ctrls[0] as EhLib.WinForms.DataGridEh;
            Dictionary<string, object> controlSettings = di.Value as Dictionary<string, object>;
            if (grid != null && controlSettings != null)
              grid.ReadStorableSettings(controlSettings);
          }
        }
      }

    }

  }

  public class SettingsDictionaryGroup
  {
    public Dictionary<string, object> Dic;

    public int GetValue(string itemName, int defaultValue)
    {
      object valAsObj;
      if (Dic.TryGetValue(itemName, out valAsObj))
      {
        if (valAsObj is int)
          return (int)valAsObj;
      }
      return defaultValue;
    }

    public string GetValue(string itemName, string defaultValue)
    {
      object valAsObj;
      if (Dic.TryGetValue(itemName, out valAsObj))
      {
        if (valAsObj is string)
          return (string)valAsObj;
      }
      return defaultValue;
    }

    public bool GetValue(string itemName, bool defaultValue)
    {
      object valAsObj;
      if (Dic.TryGetValue(itemName, out valAsObj))
      {
        if (valAsObj is bool)
          return (bool)valAsObj;
      }
      return defaultValue;
    }

    public Size GetValue(string itemName, Size defaultValue)
    {
      object valAsObj;
      if (Dic.TryGetValue(itemName, out valAsObj))
      {
        if (valAsObj is Size)
        {
          return (Size)valAsObj;
        }
        else if (valAsObj is Dictionary<string, object>)
        {
          Dictionary<string, object> sizeDic = valAsObj as Dictionary<string, object>;
          object o;
          Size size = defaultValue;
          sizeDic.TryGetValue("Width", out o);
          if (o is int) size.Width = (int)o;
          sizeDic.TryGetValue("Height", out o);
          if (o is int) size.Height = (int)o;
          return size;
        }
      }
      return defaultValue;
    }

    public Point GetValue(string itemName, Point defaultValue)
    {
      object valAsObj;
      if (Dic.TryGetValue(itemName, out valAsObj))
      {
        if (valAsObj is Size)
        {
          return (Point)valAsObj;
        }
        else if (valAsObj is Dictionary<string, object>)
        {
          Dictionary<string, object> pointDic = valAsObj as Dictionary<string, object>;
          object o;
          Point point = defaultValue;
          pointDic.TryGetValue("X", out o);
          if (o is int) point.X = (int)o;
          pointDic.TryGetValue("Y", out o);
          if (o is int) point.Y = (int)o;
          return point;
        }
      }
      return defaultValue;
    }
  }

}
