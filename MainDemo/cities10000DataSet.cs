namespace MainDemo
{
  partial class cities10000DataSet
  {
    private const string CitiesFileName = "cities10000.Cities1000Small.xml";

    public void LoadCities1000Small()
    {
      DataSetXmlHelper.LoadTable(Cities1000Small, CitiesFileName);
    }

    /// <summary>
    /// All cities into CitiesTop100.
    /// </summary>
    public void LoadCitiesTop100()
    {
      LoadCitiesTop100(0, int.MaxValue);
    }

    /// <summary>
    /// count cities into CitiesTop100, starting from position startPos in the order of geonameid,
    /// as the database query SELECT TOP 100 ... ORDER BY geonameid did.
    /// </summary>
    public void LoadCitiesTop100(int startPos, int count)
    {
      // The file holds rows of Cities1000Small: read it into that table of a separate DataSet,
      // then copy the requested rows. Cities1000Small and CitiesTop100 have the same columns.
      cities10000DataSet source = new cities10000DataSet();
      source.LoadCities1000Small();
      System.Data.DataRow[] rows = source.Cities1000Small.Select("", "geonameid");

      CitiesTop100.Clear();
      CitiesTop100.BeginLoadData();
      for (int i = startPos; i < rows.Length && i - startPos < count; i++)
        CitiesTop100.LoadDataRow(rows[i].ItemArray, true);
      CitiesTop100.EndLoadData();
    }
  }
}
