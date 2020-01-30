using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EhLib.WinForms;
using System.Reflection;
using System.IO;

namespace MainDemo
{
  public partial class FrameSolFolderExplorer : BaseFrame
  {

    TreeListGeneric<FileSystemFolterTreeNode> foltersTreeList = new TreeListGeneric<FileSystemFolterTreeNode>();
    List<FileSystemFolterTreeNode> flatList = new List<FileSystemFolterTreeNode>();

    public FrameSolFolderExplorer()
    {
      InitializeComponent();

      dataGridEh1.TreeView.NodeStateRenderer = new FlatTriangleTreeNodeStateRenderer();

      bindingSource1.DataSource = flatList;
    }

    public void LoadData()
    {
      string[] directories = Directory.GetDirectories(textBoxEh1.Text);

      foltersTreeList.Clear();

      foreach (string dirPath in directories)
      {
        FileSystemFolterTreeNode dirNode = foltersTreeList.CreateNewNode();
        dirNode.Path = dirPath;
        dirNode.Name = new DirectoryInfo(dirPath).Name;
        foltersTreeList.AddNode(dirNode, foltersTreeList.Root, TreeListNodeAttachMode.AddChild, false);

        LoadSubFolders(dirNode, false);
        //LoadSubSubFolders(dirNode);

      }

      RebuildFlatList();
    }

    private void LoadSubFolders(FileSystemFolterTreeNode node, bool updateFlatList)
    {
      string[] directories = null;
      node.SubFoldersLoaded = true;

      try
      {
        directories = Directory.GetDirectories(node.Path);
      }
      catch (System.UnauthorizedAccessException)
      {
        return;
      }

      foreach (string dirPath in directories)
      {
        FileSystemFolterTreeNode dirNode = foltersTreeList.CreateNewNode();
        dirNode.Path = dirPath;
        dirNode.Name = new DirectoryInfo(dirPath).Name;
        foltersTreeList.AddNode(dirNode, node, TreeListNodeAttachMode.AddChild, false);

        //if (loadSubSubFolders == true)
        //  LoadSub Folders(dirNode, false);
      }

      if (updateFlatList)
        RebuildFlatList();
    }

    private void LoadSubSubFolders(FileSystemFolterTreeNode node)
    {
      foreach (FileSystemFolterTreeNode n in node.Items)
      {
        LoadSubFolders(n, false);
      }

      node.SubSubFoldersLoaded = true;
      RebuildFlatList();
    }

    private void RebuildFlatList()
    {
      long savedScrollPos = dataGridEh1.VertScrollBar.ScrollPos;
      FileSystemFolterTreeNode curNode;
      if (dataGridEh1.CurrentRow == null)
        curNode = null;
      else
        curNode = dataGridEh1.CurrentRow.SourceItem as FileSystemFolterTreeNode;
      flatList.Clear();
      flatList.AddRange(foltersTreeList.GetAsFlatList(true, true));
      bindingSource1.ResetBindings(false);

      for (int i = 0; i < bindingSource1.List.Count; i++)
      {
        object item = bindingSource1.List[i];
        if (item == curNode)
        {
          bindingSource1.Position = i;
          break;
        }
      }
      dataGridEh1.VertScrollBar.ScrollPos = savedScrollPos;
    }

    public static IEnumerable<string> GetDirectoryFiles(string rootPath, string patternMatch, SearchOption searchOption)
    {
      var foundFiles = Enumerable.Empty<string>();

      if (searchOption == SearchOption.AllDirectories)
      {
        try
        {
          IEnumerable<string> subDirs = Directory.EnumerateDirectories(rootPath);
          foreach (string dir in subDirs)
          {
            // Add files in subdirectories recursively to the list
            foundFiles = foundFiles.Concat(GetDirectoryFiles(dir, patternMatch, searchOption));
          }
        }
        catch (UnauthorizedAccessException) { }
        catch (PathTooLongException) { }
      }

      try
      {
        // Add files from the current directory
        foundFiles = foundFiles.Concat(Directory.EnumerateFiles(rootPath, patternMatch));
      }
      catch (UnauthorizedAccessException) { }

      return foundFiles;
    }

    private long CalcFolderSize(string path)
    {
      long totalSize = GetDirectoryFiles(path, "*.*", SearchOption.AllDirectories).Sum(file => new FileInfo(file).Length);

      return totalSize;
    }

    public class FileSystemFolterTreeNode : BaseTreeNode
    {

      public FileSystemFolterTreeNode()
      {
        Size = "?";
      }

      public string Name
      {
        get;
        set;
      }

      public string Path
      {
        get;
        set;
      }

      public bool SubFoldersLoaded
      {
        get;
        set;
      }

      public bool SubSubFoldersLoaded
      {
        get;
        set;
      }

      public string Size
      {
        get;
        set;
      }

      public new FileSystemFolterTreeNode Parent
      {
        get { return (FileSystemFolterTreeNode)base.Parent; }
      }

      public override string ToString()
      {
        return Path;
      }
    }

    private void dataGridEh1_TreeViewArea_NodeStateNeeded(object sender, DataGridTreeViewNodeStateNeededEventArgs e)
    {
      if (e.Row == null) return;
      FileSystemFolterTreeNode node = (FileSystemFolterTreeNode)e.Row.SourceItem;
      e.NodeLevel = node.Level;
      e.HasChildren = node.HasChildren;
      e.Expanded = node.Expanded;
      e.ParentItem = node.Parent;
    }

    private void dataGridEh1_TreeViewArea_ExpandedStateSet(object sender, DataGridTreeViewNodeExpandedStateSetEventArgs e)
    {
      if (e.Row == null) return;
      FileSystemFolterTreeNode node = (FileSystemFolterTreeNode)e.Row.SourceItem;
      node.Expanded = e.Expanded;
      if (node.Expanded && !node.SubSubFoldersLoaded)
        LoadSubSubFolders(node);
      RebuildFlatList();
    }

    private void textBoxEh1_EditButton_Click(object sender, InEditControlClickEventArgs e)
    {
      DialogResult result = folderBrowserDialog1.ShowDialog();
      if (result == DialogResult.OK)
      {
        textBoxEh1.Text = folderBrowserDialog1.SelectedPath;
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      LoadData();
    }

    private void dataGridTextColumn4_DataCellFormatParamsNeeded(object sender, DataGridDataCellFormatParamsNeededEventArgs e)
    {
      if (e.Row == null) return;
      FileSystemFolterTreeNode node = (FileSystemFolterTreeNode)e.Row.SourceItem;
      if (node.Size == "?")
        e.CellArgs.HorzAlign = HorizontalAlignment.Center;
      else
        e.CellArgs.HorzAlign = HorizontalAlignment.Right;
    }

    private void dataGridTextColumn4_DataCellMouseClick(object sender, DataGridDataCellMouseEventArgs e)
    {
      if (e.Row == null) return;
      FileSystemFolterTreeNode node = (FileSystemFolterTreeNode)e.Row.SourceItem;
      long size = CalcFolderSize(node.Path);

      if (size > 1024 * 10)
      {
        size = size / 1024;

        if (size > 1024 * 10)
        {
          size = size / 1024;

          if (size > 1024 * 10)
          {
            size = size / 1024;
            node.Size = size.ToString("N0") + " Gb";
          }
          else
          {
            node.Size = size.ToString("N0") + " Mb";
          }
        }
        else
        {
          node.Size = size.ToString("N0") + " Kb";
        }
      }
      else
      {
        node.Size = size.ToString("N0") + " b";
      }
    }

    private void dataGridTextColumn4_DataCellToolTipInfoNeeded(object sender, DataGridDataCellToolTipInfoEventArgs e)
    {
      e.ToolTipText = "Clieck Here to calculate folder size!";
    }

    private void dataGridTextColumn3_DataCellClientAreaNeeded(object sender, DataGridDataCellClientAreaNeededEventArgs e)
    {
      if (e.Row == null) return;
      int custAreaWidth = 18;
      e.CellArgs.CellClientRect = EhLib.WinForms.EhLibUtils.CopyChangeRectangle(e.CellArgs.CellRect, custAreaWidth, 0, -custAreaWidth, 0);
    }

    private void dataGridTextColumn3_DataCellCustomAreaPaint(object sender, DataGridDataCellPaintEventArgs e)
    {
      if (e.Row == null) return;

      BasePaintCellStates cellPaintState = e.CellArgs.State;
      e.CellArgs.State = e.CellArgs.State & ~BasePaintCellStates.Current & ~BasePaintCellStates.Focused;
      Rectangle clientRect = e.CellArgs.ClientRect;

      Rectangle folderAreaRect = e.CellArgs.ClientRect;
      folderAreaRect.X = e.CellArgs.CustomRect.Left;
      folderAreaRect.Width = e.CellArgs.ClientRect.Left - e.CellArgs.CustomRect.Left;

      e.CellArgs.ClientRect = folderAreaRect;
      e.PaintBackground(e);

      e.CellArgs.ClientRect = clientRect;
      e.CellArgs.State = cellPaintState;

      FileSystemFolterTreeNode node = (FileSystemFolterTreeNode)e.Row.SourceItem;

      {
        Rectangle folderSignRect = folderAreaRect;
        Image folderImage;
        if (node.Expanded || !node.HasChildren)
          folderImage = Properties.Resources.FolderOpen;
        else
          folderImage = Properties.Resources.FolderClosed;
        folderSignRect = new Rectangle(Point.Empty, folderImage.Size);
        folderSignRect = EhLibUtils.RectCenter(folderSignRect, folderAreaRect);
        //folderSignRect.X = folderSignRect.Left + 2;
        e.CellArgs.Graphics.DrawImage(folderImage, folderSignRect);
      }
    }
  }
}
