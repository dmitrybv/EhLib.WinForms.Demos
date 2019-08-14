using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.Script.Serialization;

namespace MainDemo
{
  public partial class BaseFrame : UserControl
  {
    public BaseFrame()
    {
      InitializeComponent();
    }

    public virtual void LoadSettingsAsJSonStr(string settings)
    {
      if (String.IsNullOrEmpty(settings)) return;

      JavaScriptSerializer serializer = new JavaScriptSerializer();
      Dictionary<string, object> fs = serializer.Deserialize<Dictionary<string, object>>(settings);
      //fs.InitForm(this);
      ReadStorableSettings(fs);
    }

    protected virtual void ReadStorableSettings(Dictionary<string, object> settings)
    {
      object controlsObj;
      if (settings.TryGetValue("Controls", out controlsObj))
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

    public string GetSettingsAsJSonStr()
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

      var controlsDic = new Dictionary<string, object>();
      InitControlsSettings(controlsDic);
      if (controlsDic.Count > 0)
        settingsDic.Add("Controls", controlsDic);

      return settingsDic;
    }

    protected virtual void InitControlsSettings(Dictionary<string, object> controlsSettings)
    {
    }

    public virtual string SettingKey()
    {
      return null;
    }
  }
}
