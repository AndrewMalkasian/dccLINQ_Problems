using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    public static class StringTheory
    {
        public delegate IEnumerable<string> DoThingToStringList(List<string> strings);

        public static IEnumerable<string> ReturnTHSubStrings(List<string> strings)
        {
            return strings.Where(s => s.ToLower().Contains("th"));
        }

    }
}
