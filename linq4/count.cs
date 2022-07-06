using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq4
{
    /*
     * Aggregation Operator:Count
     *The Count operator returns the number of elements in the collection or number of elements that have satisfied the given condition.
     *The Count() extenstion method has the following two overloads:
     *Count() Overlaods:
     *int Count<TSource>();
     *
int   Count<TSource>(Func<TSource, bool> predicate)
    The first overload method of Count, returns the number of elements in the specified collection,
    whereas the second overload method retunrs the number of elements which have 
    satisfied the specified condition given as lambda expression/predicate function.


     *
     */
    internal class count
    {
        public static void Main(String[] args)
        {
            IList<int> list = new List<int>() { 10, 21, 30, 45, 50 };
            var totalElements = list.Count();
            Console.WriteLine("Total Elements:{0}", totalElements);
            var evenElements = list.Count(i => i % 2 == 0);
            Console.WriteLine("Even Elements:{0}", evenElements);


            List<student> students = new List<student>()
            {
                new student() { Id = 1,Name = "John", Age = 18 } ,
                new student() { Id = 2, Name = "Steve",  Age = 21 } ,
                new student() { Id= 3,Name = "Bill",  Age = 18 } ,
                new student() {Id = 4,Name = "Ram" , Age = 20 } ,
                new student() { Id = 5, Name = "Ron" , Age = 21 }
            };

            var qs = (from s in students
                      select s.Age).Count();
            Console.WriteLine(qs);

            var ms = students.Count(x => x.Age >= 18);
            Console.WriteLine(ms);
            var oldes = students.Max(x => x.Age >= 20);
        }
    }
}
