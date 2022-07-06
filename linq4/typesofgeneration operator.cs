using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq4
{
    /*
     * Generation Operators:Empty,Range,Repeat
     * Generation Operators:Empty,Range,Repeat
     * LINQ includes generation operators DefaultIfEmpty,Empty,Range & Repeat.The Empty operators DefaultIfEmpty,Empty, are not methods for
     * IEnumerabe or IQueryable but they are simply static methods defined in a static class Enumerable
     * Empty:
     * The Empty() method is not an extension method of IEnumerable or IQueryable like other LINQ methods.
     * It is a static method included in Enumerable static class.So, you can call it the same way as other static methods like Enumerable.Empty<TResult>().The Empty() method returns  an empty collection of a specified type as shown below.
     *
     *The Range() method returns a collection of IEnumerable<T> type with specified number of elements and seuential values starting from the first element.
     */
    internal class typesofgeneration_operator
    {
        public static void Main(String[] args)
        {
            var emptyCollection1=Enumerable.Empty<string>();
            var emptyCollection2=Enumerable.Empty<student>();
            Console.WriteLine("Count: {0} ", emptyCollection1.Count());
            Console.WriteLine("Type: {0} ", emptyCollection1.GetType().Name);

            Console.WriteLine("Count: {0} ", emptyCollection2.Count());
            Console.WriteLine("Type: {0} ", emptyCollection2.GetType().Name);
            var intCollection = Enumerable.Range(10, 10);
            Console.WriteLine("Total Count: {0}", intCollection.Count());

            for(int i=0; i < intCollection.Count(); i++)
            {
                Console.WriteLine("value at index{0}:{1}",i,intCollection.ElementAt(i));
            }


            var intCollection1 = Enumerable.Repeat<int>(10, 10);
            Console.WriteLine("Total Count: {0} ", intCollection1.Count());

            for (int i = 0; i < intCollection1.Count(); i++)
                Console.WriteLine("Value at index {0} : {1}", i, intCollection1.ElementAt(i));




        }
    }
}
