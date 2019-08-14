namespace MainDemo
{
  partial class FramePropertyGrid
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.biolifeDataSet = new MainDemo.BiolifeDataSet();
      this.biolifeBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.biolifeTableAdapter = new MainDemo.BiolifeDataSetTableAdapters.BiolifeTableAdapter();
      this.tableAdapterManager = new MainDemo.BiolifeDataSetTableAdapters.TableAdapterManager();
      this.dataGridTextColumn1 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn2 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn3 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn4 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn5 = new EhLib.WinForms.DataGridTextColumn();
      this.dataVertGridTextRow1 = new EhLib.WinForms.DataVertGridTextRow();
      this.dataVertGridTextRow2 = new EhLib.WinForms.DataVertGridTextRow();
      this.dataVertGridTextRow3 = new EhLib.WinForms.DataVertGridTextRow();
      this.dataVertGridTextRow4 = new EhLib.WinForms.DataVertGridTextRow();
      this.dataVertGridTextRow5 = new EhLib.WinForms.DataVertGridTextRow();
      this.dataVertGridTextRow6 = new EhLib.WinForms.DataVertGridTextRow();
      this.dataVertGridImageRow1 = new EhLib.WinForms.DataVertGridImageRow();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.dataGrid1 = new EhLib.WinForms.DataGridEh();
      this.dataPropertyGrid1 = new EhLib.WinForms.DataPropertyGridEh();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.biolifeDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.biolifeBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataPropertyGrid1)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // biolifeDataSet
      // 
      this.biolifeDataSet.DataSetName = "BiolifeDataSet";
      this.biolifeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // biolifeBindingSource
      // 
      this.biolifeBindingSource.DataMember = "Biolife";
      this.biolifeBindingSource.DataSource = this.biolifeDataSet;
      // 
      // biolifeTableAdapter
      // 
      this.biolifeTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.BiolifeTableAdapter = this.biolifeTableAdapter;
      this.tableAdapterManager.countryTableAdapter = null;
      this.tableAdapterManager.UpdateOrder = MainDemo.BiolifeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // dataGridTextColumn1
      // 
      this.dataGridTextColumn1.DataPropertyName = "SpeciesId";
      this.dataGridTextColumn1.FormatString = null;
      this.dataGridTextColumn1.Name = "dataGridTextColumn1";
      // 
      // dataGridTextColumn1.Title
      // 
      this.dataGridTextColumn1.Title.Text = "SpeciesId";
      // 
      // dataGridTextColumn2
      // 
      this.dataGridTextColumn2.DataPropertyName = "Category";
      this.dataGridTextColumn2.FormatString = null;
      this.dataGridTextColumn2.Name = "dataGridTextColumn2";
      // 
      // dataGridTextColumn2.Title
      // 
      this.dataGridTextColumn2.Title.Text = "Category";
      this.dataGridTextColumn2.Width = 89;
      // 
      // dataGridTextColumn3
      // 
      this.dataGridTextColumn3.DataPropertyName = "Common_name";
      this.dataGridTextColumn3.FormatString = null;
      this.dataGridTextColumn3.Name = "dataGridTextColumn3";
      // 
      // dataGridTextColumn3.Title
      // 
      this.dataGridTextColumn3.Title.Text = "Common_name";
      this.dataGridTextColumn3.Width = 132;
      // 
      // dataGridTextColumn4
      // 
      this.dataGridTextColumn4.DataPropertyName = "Species_Name";
      this.dataGridTextColumn4.FormatString = null;
      this.dataGridTextColumn4.Name = "dataGridTextColumn4";
      // 
      // dataGridTextColumn4.Title
      // 
      this.dataGridTextColumn4.Title.Text = "Species_Name";
      this.dataGridTextColumn4.Width = 152;
      // 
      // dataGridTextColumn5
      // 
      this.dataGridTextColumn5.DataPropertyName = "Length";
      this.dataGridTextColumn5.FormatString = null;
      this.dataGridTextColumn5.Name = "dataGridTextColumn5";
      // 
      // dataGridTextColumn5.Title
      // 
      this.dataGridTextColumn5.Title.Text = "Length";
      this.dataGridTextColumn5.Width = 54;
      // 
      // dataVertGridTextRow1
      // 
      this.dataVertGridTextRow1.DataPropertyName = "SpeciesId";
      this.dataVertGridTextRow1.Name = "dataVertGridTextRow1";
      // 
      // 
      // 
      this.dataVertGridTextRow1.Title.Text = "SpeciesId";
      // 
      // dataVertGridTextRow2
      // 
      this.dataVertGridTextRow2.DataPropertyName = "Category";
      this.dataVertGridTextRow2.Name = "dataVertGridTextRow2";
      // 
      // 
      // 
      this.dataVertGridTextRow2.Title.Text = "Category";
      // 
      // dataVertGridTextRow3
      // 
      this.dataVertGridTextRow3.DataPropertyName = "Common_name";
      this.dataVertGridTextRow3.Name = "dataVertGridTextRow3";
      // 
      // 
      // 
      this.dataVertGridTextRow3.Title.Text = "Common_name";
      // 
      // dataVertGridTextRow4
      // 
      this.dataVertGridTextRow4.DataPropertyName = "Species_Name";
      this.dataVertGridTextRow4.Name = "dataVertGridTextRow4";
      // 
      // 
      // 
      this.dataVertGridTextRow4.Title.Text = "Species_Name";
      // 
      // dataVertGridTextRow5
      // 
      this.dataVertGridTextRow5.DataPropertyName = "Length";
      this.dataVertGridTextRow5.Name = "dataVertGridTextRow5";
      // 
      // 
      // 
      this.dataVertGridTextRow5.Title.Text = "Length";
      // 
      // dataVertGridTextRow6
      // 
      this.dataVertGridTextRow6.DataPropertyName = "Notes";
      this.dataVertGridTextRow6.Name = "dataVertGridTextRow6";
      // 
      // 
      // 
      this.dataVertGridTextRow6.Title.Text = "Notes";
      // 
      // dataVertGridImageRow1
      // 
      this.dataVertGridImageRow1.DataPropertyName = "Graphic";
      this.dataVertGridImageRow1.Name = "dataVertGridImageRow1";
      // 
      // 
      // 
      this.dataVertGridImageRow1.Title.Text = "Graphic";
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 36);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.dataGrid1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.dataPropertyGrid1);
      this.splitContainer1.Size = new System.Drawing.Size(861, 462);
      this.splitContainer1.SplitterDistance = 397;
      this.splitContainer1.SplitterWidth = 8;
      this.splitContainer1.TabIndex = 3;
      this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
      // 
      // dataGrid1
      // 
      this.dataGrid1.DataSource = this.biolifeBindingSource;
      this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGrid1.Location = new System.Drawing.Point(0, 0);
      this.dataGrid1.Name = "dataGrid1";
      this.dataGrid1.Size = new System.Drawing.Size(397, 462);
      this.dataGrid1.StaticColumns.AddRange(new EhLib.WinForms.PropertyAxisBar[] {
            this.dataGridTextColumn1,
            this.dataGridTextColumn2,
            this.dataGridTextColumn3,
            this.dataGridTextColumn4,
            this.dataGridTextColumn5});
      this.dataGrid1.TabIndex = 0;
      // 
      // dataPropertyGrid1
      // 
      this.dataPropertyGrid1.DataSource = this.biolifeBindingSource;
      this.dataPropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataPropertyGrid1.Location = new System.Drawing.Point(0, 0);
      this.dataPropertyGrid1.Name = "dataPropertyGrid1";
      this.dataPropertyGrid1.RowOptions.HeightOptions.AutoExpand = true;
      this.dataPropertyGrid1.Size = new System.Drawing.Size(456, 462);
      this.dataPropertyGrid1.StaticRows.AddRange(new EhLib.WinForms.PropertyAxisBar[] {
            this.dataVertGridTextRow1,
            this.dataVertGridTextRow2,
            this.dataVertGridTextRow3,
            this.dataVertGridTextRow4,
            this.dataVertGridTextRow5,
            this.dataVertGridTextRow6,
            this.dataVertGridImageRow1});
      this.dataPropertyGrid1.TabIndex = 0;
      // 
      // 
      // 
      this.dataPropertyGrid1.TitleColumn.Width = 120;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(861, 36);
      this.panel1.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(32, 6);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(168, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "DataPropertyGrid";
      // 
      // FrameVertGrid
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.panel1);
      this.Name = "FrameVertGrid";
      this.Size = new System.Drawing.Size(861, 498);
      this.Load += new System.EventHandler(this.FrameVertGrid_Load);
      ((System.ComponentModel.ISupportInitialize)(this.biolifeDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.biolifeBindingSource)).EndInit();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataPropertyGrid1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private BiolifeDataSet biolifeDataSet;
    private System.Windows.Forms.BindingSource biolifeBindingSource;
    private BiolifeDataSetTableAdapters.BiolifeTableAdapter biolifeTableAdapter;
    private BiolifeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private EhLib.WinForms.DataGridEh dataGrid1;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn1;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn2;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn3;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn4;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn5;
    private EhLib.WinForms.DataPropertyGridEh dataPropertyGrid1;
    private EhLib.WinForms.DataVertGridTextRow dataVertGridTextRow1;
    private EhLib.WinForms.DataVertGridTextRow dataVertGridTextRow2;
    private EhLib.WinForms.DataVertGridTextRow dataVertGridTextRow3;
    private EhLib.WinForms.DataVertGridTextRow dataVertGridTextRow4;
    private EhLib.WinForms.DataVertGridTextRow dataVertGridTextRow5;
    private EhLib.WinForms.DataVertGridTextRow dataVertGridTextRow6;
    private EhLib.WinForms.DataVertGridImageRow dataVertGridImageRow1;
  }
}
