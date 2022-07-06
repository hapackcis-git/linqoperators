using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq4
{
    /*
     * Contains:-The Contains operator checks  whether a specified element exist 
     * in the collection or not and returns a boolean.
     * 
     * The Contains() extension method has following two overloads.
     * The first overload method requires a value to check in the  collection and the second overload method requires additional parameter
     * of IEqualityComparer type for custom equality comparision.
     * the Contains() extension method requires a value to check as a input parameter.
     * Type of a value must be same as type of generic collection.
     */
    internal class Contains
    {
        public static void Main(String[] args)
        {

            IList<int> intlist=new List<int>() { 1,2,3,4,5};
            bool ms=intlist.Contains(10);
            Console.WriteLine(ms);


            List<student> students = new List<student>()
            {
                new student() { Id = 1,Name = "John", Age = 18 } ,
                new student() { Id = 2, Name = "Steve",  Age = 21 } ,
                new student() { Id= 3,Name = "Bill",  Age = 18 } ,
                new student() {Id = 4,Name = "Ram" , Age = 20 } ,
                new student() { Id = 5, Name = "Ron" , Age = 21 }
            };
            student std = new student() { Id = 3, Name = "Bill" };
            ms= students.Contains(std);
            Console.WriteLine(ms);
        }
    }
}
