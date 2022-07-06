using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq4
{
    /*
     * There is only one euality operator:SequenceEqual.The SequenceEqual method checks whether the number of elements,value of each element and order of elements in two collections are 
     * equal or not.
     *  If the collection contains elements of primitive data types then it compares the values and number of elements, whereas collection with complex type elements, checks the references of the objects.
     *  So, if the objects have the same reference then they considered as equal otherwise they are considered not equal.
     * The SequenceEqual extension method checks the references of two objects to determine
     * whether two sequences are equal or not.This may give wrong result.
     * 
     */
    internal class EqualityOperator
    {
        public static void Main(String[] args)
        {
            //IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Three" };

            //IList<string> strList2 = new List<string>() { "One", "Two", "Three", "Four", "Three" };
            // bool b1 = strList1.SequenceEqual(strList2);
            //Console.WriteLine(b1);


            student std=new student() { Id=1,Name="Bill"};
            IList<student> std1=new List<student>() { std};
            IList<student> std2=new List<student>(){ std};
            bool b1 = std1.SequenceEqual(std2);
            Console.WriteLine(b1);
            student std3 = new student() { Id = 2, Name = "Amit" };
            student std4 = new student() { Id = 2, Name = "Amit" };
            IList<student> std5=new List<student>(){ std3 };
            IList<student> std6=new List<student>(){ std4 };
           b1=std5.SequenceEqual(std6);
            Console.WriteLine(b1);
        }
    }
}
