namespace MainDemo
{
  partial class FrameCellDataIsLink
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      EhLib.WinForms.DataGridFooterRow dataGridFooterRow1 = new EhLib.WinForms.DataGridFooterRow();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGrid1 = new EhLib.WinForms.DataGridEh();
      this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.biolifeDataSet = new MainDemo.BiolifeDataSet();
      this.dataGridTextColumn1 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn2 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn3 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn4 = new EhLib.WinForms.DataGridTextColumn();
      this.dataGridTextColumn5 = new EhLib.WinForms.DataGridTextColumn();
      this.colWikiLink = new EhLib.WinForms.DataGridTextColumn();
      this.colUrl = new EhLib.WinForms.DataGridTextColumn();
      this.countryTableAdapter = new MainDemo.BiolifeDataSetTableAdapters.countryTableAdapter();
      this.tableAdapterManager = new MainDemo.BiolifeDataSetTableAdapters.TableAdapterManager();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.biolifeDataSet)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(700, 36);
      this.panel1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(32, 6);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(175, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "Cell Data Is a Link";
      // 
      // orderIDDataGridViewTextBoxColumn
      // 
      this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "Order ID";
      this.orderIDDataGridViewTextBoxColumn.HeaderText = "Order ID";
      this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
      // 
      // dataGrid1
      // 
      this.dataGrid1.Cursor = System.Windows.Forms.Cursors.Default;
      this.dataGrid1.DataMember = "";
      this.dataGrid1.DataSource = this.countryBindingSource;
      this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGrid1.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataGrid1.Footer.Rows.AddRange(new EhLib.WinForms.DataGridFooterRow[] {
            dataGridFooterRow1});
      this.dataGrid1.GridState = EhLib.WinForms.BaseGridState.Normal;
      // 
      // 
      // 
      this.dataGrid1.HorzScrollBar.ExtraBar.Visible = true;
      this.dataGrid1.HorzScrollBar.Height = 24;
      this.dataGrid1.IndicatorColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.dataGrid1.IndicatorColumn.HorzLine.Style = System.Drawing.Drawing2D.DashStyle.Dot;
      this.dataGrid1.IndicatorTitle.Pressable = true;
      this.dataGrid1.IndicatorTitle.UseGlobalMenu = true;
      this.dataGrid1.Location = new System.Drawing.Point(0, 36);
      this.dataGrid1.Name = "dataGrid1";
      this.dataGrid1.RowOptions.HorzLine.Style = System.Drawing.Drawing2D.DashStyle.Dot;
      this.dataGrid1.Size = new System.Drawing.Size(700, 443);
      this.dataGrid1.StaticColumns.AddRange(new EhLib.WinForms.PropertyAxisBar[] {
            this.dataGridTextColumn1,
            this.dataGridTextColumn2,
            this.dataGridTextColumn3,
            this.dataGridTextColumn4,
            this.dataGridTextColumn5,
            this.colWikiLink,
            this.colUrl});
      this.dataGrid1.TabIndex = 1;
      this.dataGrid1.Text = "dataGrid1";
      // 
      // 
      // 
      this.dataGrid1.Title.SortMarking.SortMarkable = true;
      this.dataGrid1.Title.Filter.Active = true;
      this.dataGrid1.Title.HeightOptions.AutoExpand = true;
      this.dataGrid1.Title.SortMarking.MultiSortMarkable = true;
      this.dataGrid1.Click += new System.EventHandler(this.dataGrid1_Click);
      // 
      // countryBindingSource
      // 
      this.countryBindingSource.DataMember = "country";
      this.countryBindingSource.DataSource = this.biolifeDataSet;
      // 
      // biolifeDataSet
      // 
      this.biolifeDataSet.DataSetName = "BiolifeDataSet";
      this.biolifeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // dataGridTextColumn1
      // 
      this.dataGridTextColumn1.DataPropertyName = "Name";
      this.dataGridTextColumn1.Name = "dataGridTextColumn1";
      this.dataGridTextColumn1.Title.Text = "Name";
      // 
      // dataGridTextColumn2
      // 
      this.dataGridTextColumn2.DataPropertyName = "Capital";
      this.dataGridTextColumn2.Name = "dataGridTextColumn2";
      this.dataGridTextColumn2.Title.Text = "Capital";
      // 
      // dataGridTextColumn3
      // 
      this.dataGridTextColumn3.DataPropertyName = "Continent";
      this.dataGridTextColumn3.Name = "dataGridTextColumn3";
      this.dataGridTextColumn3.Title.Text = "Continent";
      // 
      // dataGridTextColumn4
      // 
      this.dataGridTextColumn4.DataPropertyName = "Area";
      this.dataGridTextColumn4.Name = "dataGridTextColumn4";
      this.dataGridTextColumn4.Title.Text = "Area";
      // 
      // dataGridTextColumn5
      // 
      this.dataGridTextColumn5.DataPropertyName = "Population";
      this.dataGridTextColumn5.Name = "dataGridTextColumn5";
      this.dataGridTextColumn5.Title.Text = "Population";
      // 
      // colWikiLink
      // 
      this.colWikiLink.CellDataIsLink = true;
      this.colWikiLink.DataPropertyName = "WikiLinkText";
      this.colWikiLink.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.colWikiLink.Name = "colWikiLink";
      this.colWikiLink.Title.Text = "WikiLinkText";
      this.colWikiLink.Width = 151;
      this.colWikiLink.DataCellContentClick += new System.EventHandler<EhLib.WinForms.DataGridDataCellEventArgs>(this.dataGridTextColumn6_CellContentClick);
      // 
      // colUrl
      // 
      this.colUrl.DataPropertyName = "WikiLinkURL";
      this.colUrl.Name = "colUrl";
      this.colUrl.Title.Text = "WikiLinkURL";
      this.colUrl.Visible = false;
      this.colUrl.Width = 163;
      // 
      // countryTableAdapter
      // 
      this.countryTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.BiolifeTableAdapter = null;
      this.tableAdapterManager.countryTableAdapter = this.countryTableAdapter;
      this.tableAdapterManager.UpdateOrder = MainDemo.BiolifeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // FrameCellDataIsLink
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.dataGrid1);
      this.Controls.Add(this.panel1);
      this.Name = "FrameCellDataIsLink";
      this.Size = new System.Drawing.Size(700, 479);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.biolifeDataSet)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private EhLib.WinForms.DataGridEh dataGrid1;
    private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.BindingSource countryBindingSource;
    private BiolifeDataSet biolifeDataSet;
    private BiolifeDataSetTableAdapters.countryTableAdapter countryTableAdapter;
    private BiolifeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn1;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn2;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn3;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn4;
    private EhLib.WinForms.DataGridTextColumn dataGridTextColumn5;
    private EhLib.WinForms.DataGridTextColumn colWikiLink;
    private EhLib.WinForms.DataGridTextColumn colUrl;
  }
}
