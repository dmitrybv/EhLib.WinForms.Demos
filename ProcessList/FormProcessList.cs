using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using EhLib.WinForms;

namespace ProcessList
{
  public partial class FormProcessList : Form
  {
    List<ProcessListRow> processList = new List<ProcessListRow>();

    PerformanceCounter cpuCounter;
    PerformanceCounter memCounter;
    private Font titlePercentFont;
    float memUsageTotalPercent;
    float cpuUsageTotalPercent;
    private bool dataInitialised;
    DataGridSortItem sorting;

    public FormProcessList()
    {
      InitializeComponent();

      titlePercentFont = new Font(gridProcessList.Title.Font.FontFamily, (float)gridProcessList.Title.Font.Size * 115 / 100);
      timer1.Interval = (int)numericBoxEh1.Value.Value * 1000;
      sorting = new DataGridSortItem();
      sorting.SortDirection = ListSortDirection.Ascending;
      sorting.Column = colDisplayName;
      //colDisplayName.Title.SortMarker = SortOrder.Ascending;
      gridProcessList.Title.SortMarking.SortMarkers.SetSortState(colDisplayName, ListSortDirection.Ascending);

    }

    private void SortProcessList()
    {
      PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(typeof(ProcessListRow));
      PropertyDescriptor sortPd = pdc[sorting.Column.DataPropertyName];

      processList.Sort(
        (r1, r2) =>
        {
          int res1 = string.Compare(r1.ProcessType, r2.ProcessType);
          if (res1 == 0)
          {
            int result;
            object val1 = sortPd.GetValue(r1);
            object val2 = sortPd.GetValue(r2);
            if (val1 == null && val2 == null) return 0;
            if (val1 == null)
              result = -1;
            else if (val2 == null)
              result = 1;
            else
            {
              IComparable comparable = (IComparable)val1;
              result = comparable.CompareTo(val2);
            }
            if (sorting.SortDirection == ListSortDirection.Descending)
              result = result * -1;
            return result;
          }
          else
            return res1;
        }
      );

    }

    private void UpdateData()
    {
      UpdateDataFromProcess();
    }

    private void InitData()
    {
      InitDataFromProcess();
    }

    private void InitDataFromProcess()
    {
      bsProcessList.DataSource = processList;
      bsProcessList.RaiseListChangedEvents = false;// SuspendBinding();
      bsProcessList.Clear();

      Process[] processes = Process.GetProcesses();

      foreach (Process process in processes)
      {
        //if (process.MainWindowHandle != IntPtr.Zero)
        //&& process.ProcessName == "Project1")
        {
          string displayName = process.ProcessName;
          ProcessModule mainModule = null;
          FileVersionInfo fileVersionInfo = null;

          if (!IconExtractor.CanOpenProcessForWatching(process.Id)) continue;

          //row.CanWatchProcess = IconExtracotr.CanOpenProcessForWatching(process.Id);
          //if (row.CanWatchProcess)
          {
            try { mainModule = process.MainModule; }
            catch { }
          }

          if (mainModule == null) continue;

          if (mainModule != null)
          {
            try { fileVersionInfo = mainModule.FileVersionInfo; }
            catch { mainModule = null; }
          }

          if (mainModule != null &&
              fileVersionInfo != null &&
              !String.IsNullOrEmpty(fileVersionInfo.FileDescription)
          )
            displayName = fileVersionInfo.FileDescription;
          else
            displayName = process.ProcessName;
          //bsProcessList.Add(process);

          ProcessListRow row = new ProcessListRow();
          row.ProcessID = process.Id;
          row.DisplayName = displayName;
          try
          {
            if (!IconExtractor.Is64Bit(process))
              row.DisplayName = row.DisplayName + " (32 bit)";
          }
          catch { }

          row.ProcessUser = IconExtractor.GetProcessUser(process);

          if (!process.Responding)
          {
            if (process.Threads.Count > 0 &&
                process.Threads[0].ThreadState == System.Diagnostics.ThreadState.Wait &&
                process.Threads[0].WaitReason == ThreadWaitReason.Suspended
            )
              row.Status = "Suspended";
            else
              row.Status = "Not responding";
          }

          if (process.MainWindowHandle != IntPtr.Zero)
            row.ProcessType = "App";
          else
            row.ProcessType = "Background process";

          if (mainModule != null)
          {
            row.Path = mainModule.FileName;
            //row.CommandLine = GetCommandLine(process);

            Icon icon = IconExtractor.GetIconForFile(mainModule.FileName, IconExtractor.ShellIconSize.SmallIcon);
            row.Icon = icon.ToBitmap();
            //row.Icon = Icon.ExtractAssociatedIcon(mainModule.FileName).ToBitmap();
          }

          row.LastMonitorTime = DateTime.UtcNow;

          //if (row.CanWatchProcess)
          {
            try
            {
              row.LastTotalProcessorTime = process.TotalProcessorTime;
            }
            catch
            {
              row.LastTotalProcessorTime = TimeSpan.FromTicks(0);
            }
          }

          //var wallTime = DateTime.Now - process.StartTime;
          //if (process.HasExited) wallTime = process.ExitTime - process.StartTime;
          //var procTime = process.TotalProcessorTime;
          //row.CpuUsage = (float)(100 * procTime.TotalMilliseconds / wallTime.TotalMilliseconds);

          //Icon ico = Icon.ExtractAssociatedIcon(theProcess.MainModule.FileName);

          processList.Add(row);
        }
      }

      SortProcessList();

      bsProcessList.RaiseListChangedEvents = true;
      //bsProcessList.ResumeBinding();
      bsProcessList.ResetBindings(true);
      //dataGridEh2.AutoSizeColumnOptions.ConsiderRowsMode
    }

    private void UpdateDataFromProcess()
    {
      SortedList<int, Process> sortedProcs = new SortedList<int, Process>();
      List<Process> procList = new List<Process>(Process.GetProcesses());
      Dictionary<int, Process> dicProcs = procList.ToDictionary<Process, int>(x => x.Id);

      foreach (ProcessListRow p in processList)
      {
        Process dicPr;
        if (dicProcs.TryGetValue(p.ProcessID, out dicPr))
        {
          DateTime monitorTime = DateTime.UtcNow;
          double timeDelta = (monitorTime - p.LastMonitorTime).TotalSeconds;

          TimeSpan totalProcessorTime = TimeSpan.FromTicks(0);
          try { totalProcessorTime = dicPr.TotalProcessorTime; }
          catch { }

          double processTimeDelta = (totalProcessorTime - p.LastTotalProcessorTime).TotalSeconds;

          p.CpuUsage = processTimeDelta / (Environment.ProcessorCount * timeDelta);
          p.LastMonitorTime = monitorTime;
          p.LastTotalProcessorTime = totalProcessorTime;

          p.MemoryUsage = dicPr.WorkingSet64;
          p.MemoryUsageAsString = ((double)p.MemoryUsage / 1024 / 1024).ToString("0.0;-0.0;0") + " MB";
        }
      }

      int CutProcID = (bsProcessList.Current as ProcessListRow).ProcessID;

      SortProcessList();
      bsProcessList.ResetBindings(false);
    }

    //
    // Event Handlers
    //
    private void colCPUUsage_Title_CellPaint(object sender, EhLib.WinForms.DataGridTitleCellPaintEventArgs e)
    {
      e.Paint(e);
      Rectangle drawRect = e.ClientRect;
      drawRect = EhLib.WinForms.EhLibUtils.ChangeRectangle(drawRect, 2, 2, -4, -2);

      HorizontalAlignment horzAlign;
      if ((e.State & EhLib.WinForms.BasePaintCellStates.RowHotTrack) != 0)
        horzAlign = HorizontalAlignment.Left;
      else
        horzAlign = HorizontalAlignment.Right;

      string text = cpuUsageTotalPercent.ToString("0") + " %";

      EhLibUtils.DrawText(e.Graphics, text, titlePercentFont, drawRect,
        gridProcessList.Title.ForeColor, horzAlign, VerticalAlignment.Top, 0);
      e.Handled = true;
    }

    private void colMemUsage_Title_CellPaint(object sender, EhLib.WinForms.DataGridTitleCellPaintEventArgs e)
    {
      e.Paint(e);
      Rectangle drawRect = e.ClientRect;
      drawRect = EhLib.WinForms.EhLibUtils.ChangeRectangle(drawRect, 2, 2, -4, -2);
      string text = memUsageTotalPercent.ToString("0") + "%";
      HorizontalAlignment horzAlign;
      if ((e.State & EhLib.WinForms.BasePaintCellStates.RowHotTrack) != 0)
        horzAlign = HorizontalAlignment.Left;
      else
        horzAlign = HorizontalAlignment.Right;

      EhLib.WinForms.EhLibUtils.DrawText(e.Graphics, text, titlePercentFont, drawRect,
        gridProcessList.Title.ForeColor, horzAlign, VerticalAlignment.Top, 0);
      e.Handled = true;
    }

    private void GridProcessList_Title_InteractiveSortMarkingChanged(object sender, EhLib.WinForms.SortMarkingChangedEventArgs e)
    {
      if (gridProcessList.Title.SortMarking.SortMarkers.Count > 0)
      {
        sorting.SortDirection = gridProcessList.Title.SortMarking.SortMarkers[0].SortDirection;
        sorting.Column = gridProcessList.Title.SortMarking.SortMarkers[0].Column;
      }
      else
      {
        sorting.SortDirection = ListSortDirection.Ascending;
        sorting.Column = colDisplayName;
      }

      SortProcessList();
      bsProcessList.ResetBindings(false);

      e.Handled = true;
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      if (cpuCounter == null)
      {
        cpuCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        //cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        cpuUsageTotalPercent = cpuCounter.NextValue();
      }
      else
      {
        cpuUsageTotalPercent = cpuCounter.NextValue();
      }

      if (memCounter == null)
        memCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");
      memUsageTotalPercent = memCounter.NextValue();

      if (dataInitialised)
        //UpdateDataInThread();
        UpdateData();

      gridProcessList.Title.Invalidate();
    }

    private void BStartStopAutoUpdate_Click(object sender, EventArgs e)
    {
      if (dataInitialised)
        UpdateData();
      else
        InitData();

      dataInitialised = true;
      timer1.Enabled = true;
    }

    private void ColDisplayName_DataCellClientAreaNeeded(object sender, DataGridDataCellClientAreaNeededEventArgs e)
    {
      Rectangle clientRect = e.CellArgs.CellClientRect;
      clientRect.X = clientRect.X + e.CellArgs.CellRect.Height + 4;
      clientRect.Width = clientRect.Width - e.CellArgs.CellRect.Height - 4;

      e.CellArgs.CellClientRect = clientRect;
    }

    private void ColDisplayName_DataCellCustomAreaPaint(object sender, DataGridDataCellPaintEventArgs e)
    {
      //e.PaintBackground()
      if (e.Row == null) return;

      //Background
      EhLib.WinForms.BasePaintCellStates cellPaintState = e.CellArgs.State;
      e.CellArgs.State = e.CellArgs.State &
                ~EhLib.WinForms.BasePaintCellStates.Current &
                ~EhLib.WinForms.BasePaintCellStates.Focused &
                ~EhLib.WinForms.BasePaintCellStates.RowSelected;
      Rectangle clientRect = e.CellArgs.ClientRect;

      Rectangle folderAreaRect = e.CellArgs.ClientRect;
      folderAreaRect.X = e.CellArgs.CustomRect.Left;
      folderAreaRect.Width = e.CellArgs.ClientRect.Left - e.CellArgs.CustomRect.Left;

      e.CellArgs.ClientRect = folderAreaRect;
      e.PaintBackground(e);

      e.CellArgs.ClientRect = clientRect;
      e.CellArgs.State = cellPaintState;

      //Foreground
      Rectangle areaRect = e.CellArgs.CustomRect;
      areaRect.Width = e.CellArgs.CellRect.Height + 2;
      Image image = (e.Row.SourceItem as ProcessListRow).Icon;
      if (image != null)
      {
        Rectangle folderSignRect = new Rectangle(Point.Empty, image.Size);
        if (folderSignRect.Width > e.CellArgs.CellRect.Height - 2) folderSignRect.Width = e.CellArgs.CellRect.Height - 2;
        if (folderSignRect.Height > e.CellArgs.CellRect.Height - 2) folderSignRect.Height = e.CellArgs.CellRect.Height - 2;
        folderSignRect = EhLib.WinForms.EhLibUtils.RectCenter(folderSignRect, areaRect);
        //folderSignRect.X = folderSignRect.Left + 2;
        e.CellArgs.Graphics.DrawImage(image, folderSignRect);
      }
    }

  }

  public class ProcessListRow
  {
    public string DisplayName { get; set; }

    public int ProcessID { get; set; }

    public double CpuUsage { get; set; }

    [Browsable(false)]
    public long MemoryUsage { get; set; }

    public string ProcessType { get; set; }

    public string MemoryUsageAsString { get; set; }

    public string Path { get; set; }

    [Browsable(false)]
    public string CommandLine { get; set; }

    public string ProcessUser { get; set; }

    public string Status { get; set; }

    [Browsable(false)]
    public Bitmap Icon { get; set; }

    [Browsable(false)]
    public TimeSpan LastTotalProcessorTime { get; set; }

    [Browsable(false)]
    public DateTime LastMonitorTime { get; set; }

  }

  static class IconExtractor
  {

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct SHFILEINFO
    {
      public IntPtr hIcon;
      public int iIcon;
      public uint dwAttributes;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
      public string szDisplayName;
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
      public string szTypeName;
    };

    [DllImport("shell32.dll", CharSet = CharSet.Auto)]
    private static extern IntPtr SHGetFileInfo(
      string pszPath,
      uint dwFileAttributes,
      ref SHFILEINFO psfi,
      uint cbFileInfo,
      uint uFlags);

    [DllImport("User32.dll")]
    public static extern int DestroyIcon(IntPtr hIcon);

    const uint SHGFI_ICON = 0x100;
    const uint SHGFI_LARGEICON = 0x0;    // 32x32 pixels
    const uint SHGFI_SMALLICON = 0x1;    // 16x16 pixels
    //public const int SHGFI_ICON = 0x000000100;

    public enum ShellIconSize : uint
    {
      SmallIcon = SHGFI_ICON | SHGFI_SMALLICON,
      LargeIcon = SHGFI_ICON | SHGFI_LARGEICON
    }

    [DllImport("kernel32.dll")]
    public static extern IntPtr OpenProcess(uint processAccess, bool bInheritHandle, int processId);

    [DllImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    static extern bool CloseHandle(IntPtr hObject);

    [DllImport("advapi32.dll", SetLastError = true)]
    private static extern bool OpenProcessToken(IntPtr ProcessHandle, uint DesiredAccess, out IntPtr TokenHandle);

    [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool IsWow64Process([In] IntPtr process, [Out] out bool wow64Process);

    public static Icon GetIconForFile(string filename, ShellIconSize size)
    {
      SHFILEINFO shinfo = new SHFILEINFO();
      IntPtr hImgSmall = SHGetFileInfo(filename, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), (uint)size);

      Icon icon = (Icon)Icon.FromHandle(shinfo.hIcon).Clone();
      DestroyIcon(shinfo.hIcon);
      return icon;

      //SHFILEINFO shinfo = new SHFILEINFO();
      //SHGetFileInfo(filename, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), (uint)size);
      //return Icon.FromHandle(shinfo.hIcon);
    }

    public static bool CanOpenProcessForWatching(int pid)
    {
      var processHandle = OpenProcess(0x0400 | 0x0010, false, pid);

      if (processHandle == IntPtr.Zero)
        return false;
      else
        CloseHandle(processHandle);

      return true;
    }

    public static string GetProcessUser(Process process)
    {
      IntPtr processHandle = IntPtr.Zero;

      try { OpenProcessToken(process.Handle, 8, out processHandle); }
      catch { }

      if (processHandle != IntPtr.Zero)
      {
        WindowsIdentity wi = new WindowsIdentity(processHandle);
        CloseHandle(processHandle);

        string name;
        string fullName = wi.Name;
        int p = fullName.LastIndexOf("\\");
        if (p >= 0)
          name = fullName.Substring(p + 1);
        else
          name = fullName;
        return name;
      }
      return null;
    }

    public static bool Is64Bit(Process process)
    {
      if (!Environment.Is64BitOperatingSystem)
        return false;
      // if this method is not available in your version of .NET, use GetNativeSystemInfo via P/Invoke instead

      bool isWow64;
      if (!IsWow64Process(process.Handle, out isWow64))
        throw new Win32Exception();
      return !isWow64;
    }

  }

}
