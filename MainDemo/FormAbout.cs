using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EhLib.WinForms;

namespace MainDemo
{
  public partial class FormAbout : Form
  {
    public FormAbout()
    {
      InitializeComponent();

      System.Reflection.Assembly ehLibAssemly = typeof(EhLib.WinForms.DataGridEh).Assembly;
      Version ehLibVer = typeof(EhLib.WinForms.DataGridEh).Assembly.GetName().Version;
      //AssemblyConfiguration

      tbVersion.Text = "Version " + ehLibVer.Major.ToString() + "." + ehLibVer.Minor.ToString();
      tbBuild.Text = "Build " + ehLibVer.Major.ToString() + "." +
                               ehLibVer.Minor.ToString() + "." +
                               ehLibVer.Build.ToString();

      object[] atrbs = ehLibAssemly.GetCustomAttributes(typeof(System.Reflection.AssemblyConfigurationAttribute), false);
      if (atrbs.Length > 0)
        tbConfiguration.Text = (atrbs[0] as System.Reflection.AssemblyConfigurationAttribute).Configuration;
      else
        tbConfiguration.Text = "";

      tbBuild.GotFocus += textBox1_GotFocus;
      tbBuild.MouseUp += textBox1_MouseUp;
      tbBuild.Leave += textBox1_Leave;

      tbVersion.GotFocus += textBox1_GotFocus;
      tbVersion.MouseUp += textBox1_MouseUp;
      tbVersion.Leave += textBox1_Leave;
    }

    protected override void WndProc(ref Message m)
    {
      switch (m.Msg)
      {
        case NativeMethods.WM_NCHITTEST:
          m.Result = (IntPtr)(NativeMethods.HTCAPTION);
          break;

        default:
          base.WndProc(ref m);
          break;
      }
    }

    private void FormAbout_Paint(object sender, PaintEventArgs e)
    {
      Rectangle r = ClientRectangle;
      r.Inflate(-1, -1);
      e.Graphics.DrawRectangle(new Pen(Color.FromArgb(30, 109, 186), 2), r);

      r.Inflate(-2, -2);
      r.Width = r.Width - 1;
      r.Height = r.Height - 1;
      e.Graphics.DrawRectangle(new Pen(Color.FromArgb(30, 109, 186), 1), r);
    }

    private void FormAbout_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Escape)
        Close();
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      string text = (sender as LinkLabel).Text;
      string linkText;

      if (text.Contains("@"))
        linkText = "mailto:" + text;
      else
        linkText = "http://" + text;
      System.Diagnostics.Process.Start(linkText);
    }

    void textBox1_Leave(object sender, EventArgs e)
    {
      var senderTextBox = (sender as TextBoxEh);
      senderTextBox.Tag = false;
    }

    void textBox1_GotFocus(object sender, EventArgs e)
    {
      var senderTextBox = (sender as TextBoxEh);
      if (MouseButtons == MouseButtons.None)
      {
        senderTextBox.SelectAll();
        senderTextBox.Tag = false;
      }
    }

    void textBox1_MouseUp(object sender, MouseEventArgs e)
    {
      var senderTextBox = (sender as TextBoxEh);
      if ((!(senderTextBox.Tag is bool) || (bool)senderTextBox.Tag == false) && senderTextBox.SelectionLength == 0)
      {
        senderTextBox.Tag = true;
        senderTextBox.SelectAll();
      }
    }

  }
}
