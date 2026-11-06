using System.Collections;
using System.Collections.Generic;
#if NETFRAMEWORK
using System.Web.Script.Serialization;
#else
using System.Text.Json;
#endif

namespace DisplayLayoutStorableApp
{
  /// <summary>
  /// JSON of the stored form and grid settings. net48: JavaScriptSerializer (System.Web.Extensions);
  /// net8: System.Text.Json, which is part of .NET. Deserialize returns values as JavaScriptSerializer does:
  /// objects - Dictionary&lt;string, object&gt;, arrays - ArrayList, numbers - int (long, decimal if larger).
  /// DataGridEh.ReadStorableSettings expects exactly these types.
  /// </summary>
  internal static class StorableSettingsJsonHelper
  {
    public static string Serialize(Dictionary<string, object> settings)
    {
#if NETFRAMEWORK
      JavaScriptSerializer serializer = new JavaScriptSerializer();
      return serializer.Serialize(settings);
#else
      return JsonSerializer.Serialize(settings);
#endif
    }

    public static Dictionary<string, object> Deserialize(string json)
    {
#if NETFRAMEWORK
      JavaScriptSerializer serializer = new JavaScriptSerializer();
      return serializer.Deserialize<Dictionary<string, object>>(json);
#else
      using (JsonDocument document = JsonDocument.Parse(json))
      {
        return ToObject(document.RootElement) as Dictionary<string, object>;
      }
#endif
    }

#if !NETFRAMEWORK
    private static object ToObject(JsonElement element)
    {
      switch (element.ValueKind)
      {
        case JsonValueKind.Object:
          Dictionary<string, object> dictionary = new Dictionary<string, object>();
          foreach (JsonProperty property in element.EnumerateObject())
            dictionary[property.Name] = ToObject(property.Value);
          return dictionary;

        case JsonValueKind.Array:
          ArrayList list = new ArrayList();
          foreach (JsonElement item in element.EnumerateArray())
            list.Add(ToObject(item));
          return list;

        case JsonValueKind.String:
          return element.GetString();

        case JsonValueKind.Number:
          int intValue;
          if (element.TryGetInt32(out intValue))
            return intValue;
          long longValue;
          if (element.TryGetInt64(out longValue))
            return longValue;
          return element.GetDecimal();

        case JsonValueKind.True:
          return true;

        case JsonValueKind.False:
          return false;

        default:
          return null;
      }
    }
#endif
  }
}
