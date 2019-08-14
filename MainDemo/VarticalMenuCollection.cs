using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDemo
{
  class VarticalMenuCollection : List<VarticalMenuItem>
  {

  }

  class VarticalMenuItem
  {
    public string MenuName { get; set; }
    public Type RefFrameClass { get; set; }
    public object RefFrame { get; set; }
  }

}
