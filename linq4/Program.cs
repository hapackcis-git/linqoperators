using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq4
{
    //Grouping Operator
    /*
     * The grouping operators do the same thing as the GroupBy clause of SQL query.
     * The grouping operators create a group of elements based on the given key.
     * This group is contained in a special type of collection  that implements an IGrouping <TKey,TSource> interface where TKey is a key value,
     * on which the group of has been formed and Tsource is the collection of elements that matches the grouping key value.
     * 
     * 
     * GroupBy:- The GroupBy operator returns groups of elements based on some key value.
     * Each group is represented by IGrouping<TKey,TElement> object.
     * 
     * 
     * ToLookup:-ToLookup is the same as GroupBy;the only difference is the execution of GroupBy is deferred whereas ToLookup execution is immediate.
     * 
     * GroupBy:- The GroupBy operator returns a group of elements from the given collection based on some key value.Each group is represented by IGrouping<TKey,TElement> object.Also,the GroupBy method has eight overload methods,so you can use appropriate extension
     * method based on your requirment in method syntax.
     * 
     * Note:-A LINQ query can end with a GroupBy or Select Clause.
     * 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            List<student> students = new List<student>()
            {
                new student() { Id = 1,Name = "John", Age = 18 } ,
                new student() { Id = 2, Name = "Steve",  Age = 21 } ,
                new student() { Id= 3,Name = "Bill",  Age = 18 } ,
                new student() {Id = 4,Name = "Ram" , Age = 20 } ,
                new student() { Id = 5, Name = "Ron" , Age = 21 }
            };
            var qs = (from s in students
                      group s by s.Age);
            foreach (var item in qs)
            {
                Console.WriteLine("Group by:{0}", item.Key);
                foreach (var s in item)
                {
                    Console.WriteLine("Name:{0}", s.Name);

                }
            }

            var ms = students.GroupBy(s => s.Age);
            foreach (var item in ms)
            {
                Console.WriteLine("AgeGroup:{0}", item.Key);
                foreach (var s in item)
                {
                    Console.WriteLine(s.Name);
                }
            }
           var ms1=students.ToLookup(s=>s.Name);
            foreach (var item in ms1)
            {
                Console.WriteLine("AgeGroup:{0}",item.Key);
                foreach(var s in item)
                {
                    Console.WriteLine(s.Name);
                }
            }

        }

    }
    public class student
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public int Age { get; set; }
    }
}
