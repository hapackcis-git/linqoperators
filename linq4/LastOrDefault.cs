using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq4
{
    /*
     * Last() Returns the last element from a collection, or the last element that satisfies a condition.
     * Throws exception if no element found.
     * LastOrDefault() Returns the last element from a collection, or the last element that satisfies a  condition.
     * Returns a default value if no element found.
     */
    internal class LastOrDefault
    {
       public static void Main(String[] args)
        {
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            IList<string> emptyList = new List<string>();
            Console.WriteLine(intList.Last());
            Console.WriteLine(intList.Last(i => i % 2 == 0));
            Console.WriteLine(emptyList.LastOrDefault());

        }
    }
}
