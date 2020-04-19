using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainDemo
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      //EhLib.WinForms.EhLibUtils.DebugPaint = true;
      //EhLib.WinForms.EhLibManager.DefaultEhLibManager.DropDownDebug = true;

      AppDomain.CurrentDomain.UnhandledException +=
          new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainForm());
    }

    private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
      try
      {
        Exception ex = (Exception)e.ExceptionObject;
      }
      catch (Exception exc)
      {
        try
        {
          MessageBox.Show("Fatal Non-UI Error",
              "Fatal Non-UI Error. Could not write the error to the event log. Reason: "
              + exc.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        finally
        {
          //Application.Exit();
        }
      }
    }

  }
}
