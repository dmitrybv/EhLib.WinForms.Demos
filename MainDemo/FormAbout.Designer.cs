namespace MainDemo
{
  partial class FormAbout
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
      this.bClose = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.linkLabel2 = new System.Windows.Forms.LinkLabel();
      this.linkLabel3 = new System.Windows.Forms.LinkLabel();
      this.tbBuild = new EhLib.WinForms.TextBoxEh();
      this.bevelControl3 = new EhLib.WinForms.BevelControl();
      this.bevelControl2 = new EhLib.WinForms.BevelControl();
      this.bevelControl1 = new EhLib.WinForms.BevelControl();
      this.tbVersion = new EhLib.WinForms.TextBoxEh();
      this.label4 = new System.Windows.Forms.Label();
      this.tbConfiguration = new EhLib.WinForms.TextBoxEh();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbBuild)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbVersion)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbConfiguration)).BeginInit();
      this.SuspendLayout();
      // 
      // bClose
      // 
      this.bClose.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.bClose.ForeColor = System.Drawing.SystemColors.WindowText;
      this.bClose.Location = new System.Drawing.Point(325, 361);
      this.bClose.Name = "bClose";
      this.bClose.Size = new System.Drawing.Size(87, 27);
      this.bClose.TabIndex = 0;
      this.bClose.Text = "Close";
      this.bClose.UseVisualStyleBackColor = true;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(5, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(253, 81);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      // 
      // linkLabel1
      // 
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(122)))), ((int)(((byte)(41)))));
      this.linkLabel1.Location = new System.Drawing.Point(262, 74);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(92, 15);
      this.linkLabel1.TabIndex = 4;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "www.ehlib.com";
      this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(9, 266);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(101, 15);
      this.label1.TabIndex = 8;
      this.label1.Text = "Technical support";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(9, 292);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(41, 15);
      this.label2.TabIndex = 9;
      this.label2.Text = "Email:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(9, 319);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(45, 15);
      this.label3.TabIndex = 10;
      this.label3.Text = "Forum:";
      // 
      // linkLabel2
      // 
      this.linkLabel2.AutoSize = true;
      this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(122)))), ((int)(((byte)(41)))));
      this.linkLabel2.Location = new System.Drawing.Point(91, 292);
      this.linkLabel2.Name = "linkLabel2";
      this.linkLabel2.Size = new System.Drawing.Size(116, 15);
      this.linkLabel2.TabIndex = 11;
      this.linkLabel2.TabStop = true;
      this.linkLabel2.Text = "support@ehlib.com";
      this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      // 
      // linkLabel3
      // 
      this.linkLabel3.AutoSize = true;
      this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(122)))), ((int)(((byte)(41)))));
      this.linkLabel3.Location = new System.Drawing.Point(91, 319);
      this.linkLabel3.Name = "linkLabel3";
      this.linkLabel3.Size = new System.Drawing.Size(97, 15);
      this.linkLabel3.TabIndex = 12;
      this.linkLabel3.TabStop = true;
      this.linkLabel3.Text = "forum.ehlib.com";
      this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      // 
      // tbBuild
      // 
      this.tbBuild.Border.Style = EhLib.WinForms.ControlBorderStyle.None;
      this.tbBuild.BoundLabel = null;
      this.tbBuild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(176)))));
      this.tbBuild.Location = new System.Drawing.Point(264, 37);
      this.tbBuild.Name = "tbBuild";
      this.tbBuild.Size = new System.Drawing.Size(148, 16);
      this.tbBuild.TabIndex = 14;
      this.tbBuild.TabStop = false;
      this.tbBuild.Text = "Build 0.0.0";
      // 
      // bevelControl3
      // 
      this.bevelControl3.BevelStyle = EhLib.WinForms.BevelStyle.Lowered;
      this.bevelControl3.BevelType = EhLib.WinForms.BevelType.Box;
      this.bevelControl3.HighlightColor = System.Drawing.SystemColors.ButtonHighlight;
      this.bevelControl3.Location = new System.Drawing.Point(12, 347);
      this.bevelControl3.Name = "bevelControl3";
      this.bevelControl3.ShadowColor = System.Drawing.SystemColors.ButtonShadow;
      this.bevelControl3.Size = new System.Drawing.Size(400, 2);
      this.bevelControl3.TabIndex = 13;
      this.bevelControl3.Text = "bevelControl3";
      // 
      // bevelControl2
      // 
      this.bevelControl2.BevelStyle = EhLib.WinForms.BevelStyle.Lowered;
      this.bevelControl2.BevelType = EhLib.WinForms.BevelType.Box;
      this.bevelControl2.HighlightColor = System.Drawing.SystemColors.ButtonHighlight;
      this.bevelControl2.Location = new System.Drawing.Point(12, 252);
      this.bevelControl2.Name = "bevelControl2";
      this.bevelControl2.ShadowColor = System.Drawing.SystemColors.ButtonShadow;
      this.bevelControl2.Size = new System.Drawing.Size(400, 2);
      this.bevelControl2.TabIndex = 7;
      this.bevelControl2.Text = "bevelControl2";
      // 
      // bevelControl1
      // 
      this.bevelControl1.BevelStyle = EhLib.WinForms.BevelStyle.Lowered;
      this.bevelControl1.BevelType = EhLib.WinForms.BevelType.Box;
      this.bevelControl1.HighlightColor = System.Drawing.SystemColors.ButtonHighlight;
      this.bevelControl1.Location = new System.Drawing.Point(12, 108);
      this.bevelControl1.Name = "bevelControl1";
      this.bevelControl1.ShadowColor = System.Drawing.SystemColors.ButtonShadow;
      this.bevelControl1.Size = new System.Drawing.Size(400, 2);
      this.bevelControl1.TabIndex = 5;
      this.bevelControl1.Text = "bevelControl1";
      // 
      // tbVersion
      // 
      this.tbVersion.Border.Style = EhLib.WinForms.ControlBorderStyle.None;
      this.tbVersion.BoundLabel = null;
      this.tbVersion.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
      this.tbVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(176)))));
      this.tbVersion.Location = new System.Drawing.Point(264, 9);
      this.tbVersion.Name = "tbVersion";
      this.tbVersion.Size = new System.Drawing.Size(136, 26);
      this.tbVersion.TabIndex = 16;
      this.tbVersion.TabStop = false;
      this.tbVersion.Text = "Version 0.0";
      // 
      // label4
      // 
      this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
      this.label4.Location = new System.Drawing.Point(12, 116);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(391, 121);
      this.label4.TabIndex = 17;
      this.label4.Text = resources.GetString("label4.Text");
      // 
      // tbConfiguration
      // 
      this.tbConfiguration.Border.Style = EhLib.WinForms.ControlBorderStyle.None;
      this.tbConfiguration.BoundLabel = null;
      this.tbConfiguration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(176)))));
      this.tbConfiguration.Location = new System.Drawing.Point(264, 55);
      this.tbConfiguration.Name = "tbConfiguration";
      this.tbConfiguration.Size = new System.Drawing.Size(148, 16);
      this.tbConfiguration.TabIndex = 18;
      this.tbConfiguration.TabStop = false;
      this.tbConfiguration.Text = "Src Included";
      // 
      // FormAbout
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(424, 399);
      this.Controls.Add(this.tbConfiguration);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.tbVersion);
      this.Controls.Add(this.tbBuild);
      this.Controls.Add(this.bevelControl3);
      this.Controls.Add(this.linkLabel3);
      this.Controls.Add(this.linkLabel2);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.bevelControl2);
      this.Controls.Add(this.bevelControl1);
      this.Controls.Add(this.linkLabel1);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.bClose);
      this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(176)))));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.KeyPreview = true;
      this.Name = "FormAbout";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "About EhLib";
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormAbout_Paint);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAbout_KeyDown);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbBuild)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbVersion)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tbConfiguration)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button bClose;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.LinkLabel linkLabel1;
    private EhLib.WinForms.BevelControl bevelControl1;
    private EhLib.WinForms.BevelControl bevelControl2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.LinkLabel linkLabel2;
    private System.Windows.Forms.LinkLabel linkLabel3;
    private EhLib.WinForms.BevelControl bevelControl3;
    private EhLib.WinForms.TextBoxEh tbBuild;
    private EhLib.WinForms.TextBoxEh tbVersion;
    private System.Windows.Forms.Label label4;
    private EhLib.WinForms.TextBoxEh tbConfiguration;
  }
}