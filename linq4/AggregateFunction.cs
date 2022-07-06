using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq4
{
    /*
     * Aggregation Operators:Aggregate
     * The aggregation operators perform mathematical operations like
     * Average,Aggregate,Count,Max,Min and Sum, on the numeric property of the elements in the collection.
     * 
     * The Aggregate method performs an accumulate operation.
     * Aggregate extension method has the following overload methods:
     * The following demonstrates Aggregatemethod tha returns comma separated elements of the string  list.
     * 
     */
    internal class AggregateFunction
    {
        public static void Main(String[] args)
        {
            IList<String> strList=new List<String>() {"one","two","three","four","five"};
            var s = strList.Aggregate((s1, s2) => s1 + "," + s2);
            Console.WriteLine(s);

            /*
             * The second overload method of Aggregate requires first
             * parameter for seed value to accumulate.Second parameter is Func type delegate.
             * 
             */


            List<student> students = new List<student>()
            {
                new student() { Id = 1,Name = "John", Age = 18 } ,
                new student() { Id = 2, Name = "Steve",  Age = 21 } ,
                new student() { Id= 3,Name = "Bill",  Age = 18 } ,
                new student() {Id = 4,Name = "Ram" , Age = 20 } ,
                new student() { Id = 5, Name = "Ron" , Age = 21 }
            };
           
        }
    }
}
