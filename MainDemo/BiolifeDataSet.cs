namespace MainDemo
{

  partial class BiolifeDataSet
  {
    public void LoadBiolife()
    {
      DataSetXmlHelper.LoadTable(Biolife, "Biolife.Biolife.xml");
    }

    public void LoadCountry()
    {
      DataSetXmlHelper.LoadTable(country, "Biolife.country.xml");
    }

    public void LoadTestTree()
    {
      DataSetXmlHelper.LoadTable(TestTree, "Biolife.TestTree.xml");
    }

    public void LoadPlannerData()
    {
      DataSetXmlHelper.LoadTable(PlannerData, "Biolife.PlannerData.xml");
    }

    public void LoadPlannerResources()
    {
      DataSetXmlHelper.LoadTable(PlannerResources, "Biolife.PlannerResources.xml");
    }

  }
}
