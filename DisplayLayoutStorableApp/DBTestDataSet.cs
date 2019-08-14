using System;
using System.Data;

namespace DisplayLayoutStorableApp
{
  partial class DBTestDataSet
  {
    public void LoadDataFile()
    {
      foreach (DataTable t in Tables)
        t.BeginLoadData();

      string path = AppDomain.CurrentDomain.BaseDirectory + "\\dBTestDataSet-DbData.Xml";
      ReadXml(path);

      foreach (DataTable t in Tables)
        t.EndLoadData();
    }
  }
}
