using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq4
{
    /*
     * Element Operators:ElementAt,ElementAtOrDefault
     * Element operators return a particular element from a sequence (collection).
     * ElementAt:Returns the element at a specified index in a collection.
     * ElementAtorDefault:-Returns the element at a specified collection, or the first element that satisfies a condition.
     * First:-Returns the first element of a collection, or the first element that satisfies a condition
     * FirstOrDefault:-Returns the last element of a collection,or the last element that satisfies a condtion.
     *LastOrDefault:-Return the last element of a collection, or the last element that satisfies a condition.
     *Single:- Returns the only element of a collection, or the only element that satisfies a condition.
     *SingleOrDefault:-Returns the only element of a collection, or the only element that satisfies a condition.Returns a default value if no suc element exists or the collection does not contain exactly one element.
     *
     *The ElementAt() method returns an element from the specified index from  a given collection.
     *If the specified index is out of the range of a collection then it will throw an Index out of range exception.Please note that index is a zero based index.
     *The ElmentAtOrDefault() method also returns an element from specified indes from a collection and if the specified index is out of range of a collection then it will return a default value of the data type instead of throwing an error.
     *
     *
     *
     *
     *
     */
    internal class ElementOperators
    {
        public static void Main(String[] args)
        {
            IList<int> intlist=new List<int>() { 10,21,30,45,50,87};
            IList<string> strList = new List<string>() { "One", "Two", null, "Four", "Five" };
            Console.WriteLine("1st Element in inlist:{0}", intlist.ElementAt(0));
            Console.WriteLine("1st Element in strlist:{0}", strList.ElementAt(0));

            Console.WriteLine("3rd Element in intList: {0}", intlist.ElementAtOrDefault(2));
            Console.WriteLine("3rd Element in strList: {0}", strList.ElementAtOrDefault(2));

            Console.WriteLine("10th Element in intList: {0} - default int value", intlist.ElementAtOrDefault(9));
            Console.WriteLine("10th Element in strList: {0} - default string value (null)", strList.ElementAtOrDefault(9));


            Console.WriteLine("intList.ElementAt(9) throws an exception: Index out of range");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(intlist.ElementAt(9));

        }
    }
}