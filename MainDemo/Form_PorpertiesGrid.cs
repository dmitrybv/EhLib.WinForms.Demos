using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MainDemo
{
  public partial class Form_PorpertiesGrid : Form
  {
    [DllImport("user32.dll")]
    static extern IntPtr GetFocus();

    public static Form_PorpertiesGrid form_PorpertiesGrid;

    public Form_PorpertiesGrid()
    {
      InitializeComponent();

      form_PorpertiesGrid = this;
    }

    public static void ShowPropertiesGridFormForFocused()
    {
      IntPtr wndHandle = GetFocus();
      Control focusedControl = FromChildHandle(wndHandle);
      if (focusedControl != null)
      {
        if (focusedControl.Name == "")
          focusedControl = focusedControl.Parent;
        ShowPropertiesGridFormFor(focusedControl);
      }

    }

    public static void ShowPropertiesGridFormFor(object SelectingObject)
    {
      if (form_PorpertiesGrid == null)
        form_PorpertiesGrid = new Form_PorpertiesGrid();
      form_PorpertiesGrid.propertyGrid1.SelectedObject = SelectingObject;
      form_PorpertiesGrid.Text = SelectingObject.ToString();
      form_PorpertiesGrid.Show();
    }

    private void Form_PorpertiesGrid_FormClosed(object sender, FormClosedEventArgs e)
    {
      form_PorpertiesGrid = null;
    }
  }
}
