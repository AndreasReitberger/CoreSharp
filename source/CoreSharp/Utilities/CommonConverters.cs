using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AndreasReitberger.Core.Utilities
{
    public static class CommonConverters
    {
        public static List<string> DictionaryToStringList(Dictionary<string, List<string>> dict)
        {
            List<string> list = new();
            if (dict == null) return list;
            foreach (KeyValuePair<string, List<string>> pairs in dict)
            {
                list.AddRange(pairs.Value);
            }
            return list;
        }

        public static string StackToPath(Stack<string> stack, string separator)
        {
            StringBuilder sb = new();
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                sb.Append(stack.ElementAt(i));
                if (i > 0)
                {
                    sb.Append(separator);
                }
            }
            return sb.ToString();
        }
    }
}
