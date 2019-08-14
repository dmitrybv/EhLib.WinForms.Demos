namespace DisplayLayoutStorableApp
{
  partial class MDIChildFormCountries
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.dataGridEh1 = new EhLib.WinForms.DataGridEh();
      this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dBTestDataSet = new DisplayLayoutStorableApp.DBTestDataSet();
      this.countryTableAdapter = new DisplayLayoutStorableApp.DBTestDataSetTableAdapters.countryTableAdapter();
      this.tableAdapterManager = new DisplayLayoutStorableApp.DBTestDataSetTableAdapters.TableAdapterManager();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridEh1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dBTestDataSet)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(800, 47);
      this.panel1.TabIndex = 0;
      // 
      // dataGridEh1
      // 
      this.dataGridEh1.DataMember = "";
      this.dataGridEh1.DataSource = this.countryBindingSource;
      this.dataGridEh1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridEh1.Location = new System.Drawing.Point(0, 47);
      this.dataGridEh1.Name = "dataGridEh1";
      this.dataGridEh1.Size = new System.Drawing.Size(800, 403);
      this.dataGridEh1.TabIndex = 1;
      // 
      // countryBindingSource
      // 
      this.countryBindingSource.DataMember = "country";
      this.countryBindingSource.DataSource = this.dBTestDataSet;
      // 
      // dBTestDataSet
      // 
      this.dBTestDataSet.DataSetName = "DBTestDataSet";
      this.dBTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // countryTableAdapter
      // 
      this.countryTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.countryTableAdapter = this.countryTableAdapter;
      this.tableAdapterManager.CustomersTableAdapter = null;
      this.tableAdapterManager.EmployeesTableAdapter = null;
      this.tableAdapterManager.UpdateOrder = DisplayLayoutStorableApp.DBTestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // MDIChildFormCountries
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.dataGridEh1);
      this.Controls.Add(this.panel1);
      this.Name = "MDIChildFormCountries";
      this.Text = "Countries";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MDIChildFormCountries_FormClosed);
      this.Load += new System.EventHandler(this.MDIChildForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridEh1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dBTestDataSet)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private EhLib.WinForms.DataGridEh dataGridEh1;
    private DBTestDataSet dBTestDataSet;
    private System.Windows.Forms.BindingSource countryBindingSource;
    private DBTestDataSetTableAdapters.countryTableAdapter countryTableAdapter;
    private DBTestDataSetTableAdapters.TableAdapterManager tableAdapterManager;
  }
}