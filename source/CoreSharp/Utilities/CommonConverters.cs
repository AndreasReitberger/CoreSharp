using System.Collections.Generic;

namespace AndreasReitberger.Core.Utilities
{
    public static class CommonConverters
    {
        public static List<string> DictionaryToStringList(Dictionary<string, List<string>> dict)
        {
            List<string> list = new List<string>();
            if (dict == null) return list;
            foreach (KeyValuePair<string, List<string>> pairs in dict)
            {
                list.AddRange(pairs.Value);
            }
            return list;
        }
    }
}
