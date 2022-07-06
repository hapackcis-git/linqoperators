using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq4
{
    internal class SingleOrDefault
    {
        /*
         * Single:- Returns the only element from a collection, or the only element 
         * that satisfies a condition.If Single() found no elements or more than one elements in the collection then throw InvalidOperationException.
         * 
         * SingleOrDefault:The same as Single, except that it returns a default value of a specified generic type,instead of throwing an exception if no element found for the specified condition.
         * However, it will throw InvalidOperationException if it found more than one element for the specified condition in the collection.
         * 
         */
        public static void Main(String[] args)
        {
            IList<int> oneElementList = new List<int>() { 7 };
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
         
            IList<string> emptyList = new List<string>();

            Console.WriteLine("The only element in oneElementList: {0}", oneElementList.Single());
            Console.WriteLine("The only element in oneElementList: {0}",
                         oneElementList.SingleOrDefault());

            Console.WriteLine("Element in emptyList: {0}", emptyList.SingleOrDefault());

            Console.WriteLine("The only element which is less than 10 in intList: {0}",
                         intList.Single(i => i < 10));

            //Followings throw an exception
            //Console.WriteLine("The only Element in intList: {0}", intList.Single());
            //Console.WriteLine("The only Element in intList: {0}", intList.SingleOrDefault());
            //Console.W
        }
    }
}
