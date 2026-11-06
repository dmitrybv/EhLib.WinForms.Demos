namespace MainDemo
{
  internal static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      AppDomain.CurrentDomain.UnhandledException +=
          new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

#if NETFRAMEWORK
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
#else
      // To customize application configuration such as set high DPI settings or default font,
      // see https://aka.ms/applicationconfiguration.
      ApplicationConfiguration.Initialize();
#endif

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