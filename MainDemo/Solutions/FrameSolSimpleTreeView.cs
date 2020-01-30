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

    List<AssemblyDataRow> baseTreeList = new List<AssemblyDataRow>();

    public FrameSolSimpleTreeView()
    {
      InitializeComponent();

      dataGridEh1.TreeView.NodeStateRenderer = new FlatTriangleTreeNodeStateRenderer();

      LoadData();
      bindingSource1.DataSource = baseTreeList;
    }

    public void LoadData()
    {
      Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();

      foreach (Assembly assembly in assemblies)
      {
        AssemblyDataRow asseblyNode = new AssemblyDataRow()
        {
          Name = assembly.GetName().Name
        };
        asseblyNode.Parent = asseblyNode; //ref it iteslf -> Root 
        baseTreeList.Add(asseblyNode);
        //asseblyNode.Expanded = true;

        { //Level  2 namespaces
          var namespaces = assembly.GetTypes()
                                   .Select(t => t.Namespace)
                                   .Distinct();

          foreach (string namespaceName in namespaces)
          {
            if (string.IsNullOrEmpty(namespaceName)) continue;

            AssemblyDataRow nsNode = new AssemblyDataRow()
            {
              Name = namespaceName,
              Parent = asseblyNode
            };

            baseTreeList.Add(nsNode);
            //nsNode.Expanded = true;

            { // Level 3 Types
              foreach (Type type in assembly.GetTypes())
              {
                if (type.Namespace == namespaceName)
                {
                  AssemblyDataRow typeNode = new AssemblyDataRow()
                  {
                    Name = type.Name,
                    Parent = nsNode
                  };

                  baseTreeList.Add(typeNode);
                }
              }
            }
          }
        }
      }

    }

    public class AssemblyDataRow 
    {
      public AssemblyDataRow()
      {
      }

      public AssemblyDataRow(string name, AssemblyDataRow parent)
      {
        Name = name;
        Parent = parent;
      }

      public string Name
      {
        get;
        set;
      }

      public AssemblyDataRow Parent
      {
        get;
        set;
      }
    }
  }
}
