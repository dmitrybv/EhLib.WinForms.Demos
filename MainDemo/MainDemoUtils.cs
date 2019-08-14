using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainDemo
{

  public class SafeDictionary<TKey, TValue> : Dictionary<TKey, TValue> where TValue : class
  {

    public new TValue this[TKey key]
    {
      get { return GetValue(key); }
      set { base[key] = value; }
    }

    public TValue GetValue(TKey key)
    {
      TValue result;
      if (base.TryGetValue(key, out result))
        return result;
      else
        return null;
    }
  }

}
