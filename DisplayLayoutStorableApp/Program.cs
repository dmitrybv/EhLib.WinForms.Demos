using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace DisplayLayoutStorableApp
{
  static class Program
  {

    static internal Dictionary<string, string> appUserSettings = new Dictionary<string, string>();

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      appUserSettings = LoadSettings();

      Application.Run(new MainForm());

      SaveSettings(appUserSettings);
    }

    static internal Dictionary<string, string> LoadSettings()
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

    static internal void SaveSettings(Dictionary<string, string> u)
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
  }
}
