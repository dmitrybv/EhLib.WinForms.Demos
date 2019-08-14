namespace DisplayLayoutStorableApp
{
  partial class MDIChildFormCustomers
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
      this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dBTestDataSet = new DisplayLayoutStorableApp.DBTestDataSet();
      this.customersTableAdapter = new DisplayLayoutStorableApp.DBTestDataSetTableAdapters.CustomersTableAdapter();
      this.tableAdapterManager = new DisplayLayoutStorableApp.DBTestDataSetTableAdapters.TableAdapterManager();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridEh1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
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
      this.dataGridEh1.DataSource = this.customersBindingSource;
      this.dataGridEh1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridEh1.Location = new System.Drawing.Point(0, 47);
      this.dataGridEh1.Name = "dataGridEh1";
      this.dataGridEh1.Size = new System.Drawing.Size(800, 403);
      this.dataGridEh1.TabIndex = 1;
      // 
      // customersBindingSource
      // 
      this.customersBindingSource.DataMember = "Customers";
      this.customersBindingSource.DataSource = this.dBTestDataSet;
      // 
      // dBTestDataSet
      // 
      this.dBTestDataSet.DataSetName = "DBTestDataSet";
      this.dBTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // customersTableAdapter
      // 
      this.customersTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.countryTableAdapter = null;
      this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
      this.tableAdapterManager.EmployeesTableAdapter = null;
      this.tableAdapterManager.UpdateOrder = DisplayLayoutStorableApp.DBTestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // MDIChildFormCustomers
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.dataGridEh1);
      this.Controls.Add(this.panel1);
      this.Name = "MDIChildFormCustomers";
      this.Text = "Customers";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MDIChildFormCustomers_FormClosed);
      this.Load += new System.EventHandler(this.MDIChildForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridEh1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dBTestDataSet)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private EhLib.WinForms.DataGridEh dataGridEh1;
    private DBTestDataSet dBTestDataSet;
    private System.Windows.Forms.BindingSource customersBindingSource;
    private DBTestDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
    private DBTestDataSetTableAdapters.TableAdapterManager tableAdapterManager;
  }
}