using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq4
{
    /*
     * Generation Operator:-DefaultIfEmpty
     *  returns a new collection with the default value if the given collection on which DefaultIfEmpty() is invoked is empty.
     * Another overload method of DefaultIfEmpty() takes a value parameter that should be replaced with default value. 
     * 
     */
    internal class GenerationOperator
    {
        public static void Main(String[] args)
        {
            IList<string> emptyList = new List<string>();
            var newList1 = emptyList.DefaultIfEmpty();
            var newList2 = emptyList.DefaultIfEmpty("None");
            Console.WriteLine("Count: {0}", newList1.Count());
            Console.WriteLine("Value: {0}", newList1.ElementAt(0));

            Console.WriteLine("Count: {0}", newList2.Count());
            Console.WriteLine("Value: {0}", newList2.ElementAt(0));

        }
    }
}
