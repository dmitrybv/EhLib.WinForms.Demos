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

namespace MainDemo
{
  public partial class FrameSolSimpleTreeView : BaseFrame
  {

    TreeListGeneric<SimpleTreeViewNode> baseTreeList = new TreeListGeneric<SimpleTreeViewNode>();
    List<SimpleTreeViewNode> flatList = new List<SimpleTreeViewNode>();

    public FrameSolSimpleTreeView()
    {
      InitializeComponent();

      dataGridEh1.TreeViewArea.NodeStateRenderer = new FlatTriangleTreeNodeStateRenderer();

      LoadData();
      bindingSource1.DataSource = flatList;
    }

    public void LoadData()
    {
      Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();

      foreach(Assembly assembly in assemblies)
      {
        SimpleTreeViewNode asseblyNode = new SimpleTreeViewNode()
        {
          Name = assembly.GetName().Name
        };

        baseTreeList.AddNode(asseblyNode, null, TreeListNodeAttachMode.AddChild, false);
        //asseblyNode.Expanded = true;

        { //Level  2 namespaces
          var namespaces = assembly.GetTypes()
                                   .Select(t => t.Namespace)
                                   .Distinct();

          foreach (string namespaceName in namespaces)
          {
            if (String.IsNullOrEmpty(namespaceName)) continue;

            SimpleTreeViewNode nsNode = new SimpleTreeViewNode()
            {
              Name = namespaceName
            };

            baseTreeList.AddNode(nsNode, asseblyNode, TreeListNodeAttachMode.AddChild, false);
            //nsNode.Expanded = true;

            { // Level 3 Types
              foreach (Type type in assembly.GetTypes())
              {
                if (type.Namespace == namespaceName)
                {
                  SimpleTreeViewNode typeNode = new SimpleTreeViewNode()
                  {
                    Name = type.Name
                  };

                  baseTreeList.AddNode(typeNode, nsNode, TreeListNodeAttachMode.AddChild, false);
                }
              }
            }
          }
        }
      }

      RebuildFlatList();
    }

    private void RebuildFlatList()
    {
      long savedScrollPos = dataGridEh1.VertScrollBar.ScrollPos;
      SimpleTreeViewNode curNode;
      if (dataGridEh1.CurrentRow == null)
        curNode = null;
      else
        curNode = dataGridEh1.CurrentRow.SourceItem as SimpleTreeViewNode;
      flatList.Clear();
      flatList.AddRange(baseTreeList.GetAsFlatList(true, true));
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

    public class SimpleTreeViewNode : BaseTreeNode
    {

      public SimpleTreeViewNode()
      {
      }

      public string Name
      {
        get;
        set;
      }

    }

    private void dataGridEh1_TreeViewArea_NodeStateNeeded(object sender, DataGridTreeViewNodeStateNeededEventArgs e)
    {
      if (e.Row == null) return;
      SimpleTreeViewNode node = (SimpleTreeViewNode)e.Row.SourceItem;
      e.NodeLevel = node.Level;
      e.HasChildren = node.HasChildren;
      e.Expanded = node.Expanded;
      e.ParentItem = node.Parent;
    }

    private void dataGridEh1_TreeViewArea_ExpandedStateSet(object sender, DataGridTreeViewNodeExpandedStateSetEventArgs e)
    {
      if (e.Row == null) return;
      SimpleTreeViewNode node = (SimpleTreeViewNode)e.Row.SourceItem;
      node.Expanded = e.Expanded;
      RebuildFlatList();
    }
  }
}
