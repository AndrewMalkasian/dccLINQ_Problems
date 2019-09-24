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

        public static IEnumerable<string> ReturnDistinctStringList(List<string> strings)
        {
            return strings.Distinct();
        }

        public static double SuperAverage(List<string> strings)
        {
            List<double> masterList = new List<double>();
            foreach (var item in strings)
            {
                var temporary = item.Split(',').Select(double.Parse).ToList();
                temporary.Remove(temporary.Min());
                masterList.Add(temporary.Average());
            }
            double average = masterList.Average();
            return average;
        }

    }
}
