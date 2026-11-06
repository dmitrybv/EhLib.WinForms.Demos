namespace ProcessList
{
  internal static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {

#if NETFRAMEWORK
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
#else
      // To customize application configuration such as set high DPI settings or default font,
      // see https://aka.ms/applicationconfiguration.
      ApplicationConfiguration.Initialize();
#endif

      Application.Run(new FormProcessList());
    }
  }
}