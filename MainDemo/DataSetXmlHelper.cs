using System;
using System.Data;
using System.IO;

namespace MainDemo
{
  /// <summary>
  /// Loads the demo data of the typed DataSets from XML files in the Data folder of the application,
  /// one file per table (written by DataTable.WriteXml without a schema: the schema is the DataSet itself).
  /// </summary>
  internal static class DataSetXmlHelper
  {
    public static string DataFilePath(string fileName)
    {
      return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", fileName);
    }

    /// <summary>
    /// Replaces the rows of the table with the rows of the file, as TableAdapter.Fill with ClearBeforeFill did.
    /// </summary>
    public static void LoadTable(DataTable table, string fileName)
    {
      table.Clear();
      table.BeginLoadData();
      table.ReadXml(DataFilePath(fileName));
      table.EndLoadData();
      // ReadXml adds rows as Added. Unchanged, as after TableAdapter.Fill.
      table.AcceptChanges();
    }
  }
}
