namespace MainDemo
{
  partial class FrameSearchBox
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.northwindDataSet = new MainDemo.NorthwindDataSet();
      this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.customersTableAdapter = new MainDemo.NorthwindDataSetTableAdapters.CustomersTableAdapter();
      this.tableAdapterManager = new MainDemo.NorthwindDataSetTableAdapters.TableAdapterManager();
      this.dataGrid1 = new EhLib.WinForms.DataGridEh();
      this.panel2 = new System.Windows.Forms.Panel();
      this.bFilterOnTyping = new System.Windows.Forms.Button();
      this.bPersistentShow = new System.Windows.Forms.Button();
      this.bFilterEnabled = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(676, 36);
      this.panel1.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(32, 6);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(118, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "Search Box";
      // 
      // northwindDataSet
      // 
      this.northwindDataSet.DataSetName = "NorthwindDataSet";
      this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // customersBindingSource
      // 
      this.customersBindingSource.DataMember = "Customers";
      this.customersBindingSource.DataSource = this.northwindDataSet;
      // 
      // customersTableAdapter
      // 
      this.customersTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.CategoriesTableAdapter = null;
      this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
      this.tableAdapterManager.EmployeesTableAdapter = null;
      this.tableAdapterManager.Order_DetailsTableAdapter = null;
      this.tableAdapterManager.OrdersTableAdapter = null;
      this.tableAdapterManager.ProductsTableAdapter = null;
      this.tableAdapterManager.ShippersTableAdapter = null;
      this.tableAdapterManager.UpdateOrder = MainDemo.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // dataGrid1
      // 
      this.dataGrid1.AutoGenerateColumns = true;
      this.dataGrid1.BackColor = System.Drawing.SystemColors.Window;
      this.dataGrid1.Cursor = System.Windows.Forms.Cursors.Default;
      this.dataGrid1.DataSource = this.customersBindingSource;
      this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGrid1.DrawStyle = null;
      this.dataGrid1.Location = new System.Drawing.Point(0, 80);
      this.dataGrid1.Name = "dataGrid1";
      // 
      // dataGrid1.SearchBox
      // 
      this.dataGrid1.SearchBox.Enabled = true;
      this.dataGrid1.SearchBox.FilterOnTyping = true;
      this.dataGrid1.SearchBox.HighlightSearchingText = false;
      this.dataGrid1.SearchBox.Visible = true;
      this.dataGrid1.Size = new System.Drawing.Size(676, 398);
      this.dataGrid1.TabIndex = 3;
      this.dataGrid1.Text = "dataGrid1";
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.bFilterEnabled);
      this.panel2.Controls.Add(this.bPersistentShow);
      this.panel2.Controls.Add(this.bFilterOnTyping);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 36);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(676, 44);
      this.panel2.TabIndex = 4;
      // 
      // bFilterOnTyping
      // 
      this.bFilterOnTyping.Location = new System.Drawing.Point(12, 10);
      this.bFilterOnTyping.Name = "bFilterOnTyping";
      this.bFilterOnTyping.Size = new System.Drawing.Size(159, 23);
      this.bFilterOnTyping.TabIndex = 0;
      this.bFilterOnTyping.Text = "FilterOnTyping (Yes)";
      this.bFilterOnTyping.UseVisualStyleBackColor = true;
      this.bFilterOnTyping.Click += new System.EventHandler(this.bFilterOnTyping_Click);
      // 
      // bPersistentShow
      // 
      this.bPersistentShow.Location = new System.Drawing.Point(177, 10);
      this.bPersistentShow.Name = "bPersistentShow";
      this.bPersistentShow.Size = new System.Drawing.Size(159, 23);
      this.bPersistentShow.TabIndex = 1;
      this.bPersistentShow.Text = "Persistent Show (Yes)";
      this.bPersistentShow.UseVisualStyleBackColor = true;
      this.bPersistentShow.Click += new System.EventHandler(this.bPersistentShow_Click);
      // 
      // bFilterEnabled
      // 
      this.bFilterEnabled.Location = new System.Drawing.Point(342, 10);
      this.bFilterEnabled.Name = "bFilterEnabled";
      this.bFilterEnabled.Size = new System.Drawing.Size(159, 23);
      this.bFilterEnabled.TabIndex = 2;
      this.bFilterEnabled.Text = "Filter Enabled (Yes)";
      this.bFilterEnabled.UseVisualStyleBackColor = true;
      this.bFilterEnabled.Click += new System.EventHandler(this.bFilterEnabled_Click);
      // 
      // FrameSearchBox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.dataGrid1);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "FrameSearchBox";
      this.Size = new System.Drawing.Size(676, 478);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private NorthwindDataSet northwindDataSet;
    private System.Windows.Forms.BindingSource customersBindingSource;
    private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
    private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private EhLib.WinForms.DataGridEh dataGrid1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button bFilterOnTyping;
    private System.Windows.Forms.Button bPersistentShow;
    private System.Windows.Forms.Button bFilterEnabled;
  }
}
