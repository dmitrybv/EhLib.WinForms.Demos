namespace MainDemo
{

    partial class BiolifeDataSet
    {
        MainDemo.BiolifeDataSetTableAdapters.BiolifeTableAdapter biolifeTableAdapter;
        MainDemo.BiolifeDataSetTableAdapters.BiolifeTableAdapter BiolifeTableAdapter
        {
            get
            {
                if (biolifeTableAdapter == null)
                    biolifeTableAdapter = new MainDemo.BiolifeDataSetTableAdapters.BiolifeTableAdapter();
                return biolifeTableAdapter;
            }
        }

        public void ApplyUpdatesToTable(System.Data.DataTable dataTable)
        {
            if (dataTable == Biolife)
            {
                BiolifeTableAdapter.Update(Biolife);
            }
        }

        public void FillTable(System.Data.DataTable dataTable)
        {
            if (dataTable == Biolife)
            {
                BiolifeTableAdapter.Fill(Biolife);
            }
        }

    }
}
