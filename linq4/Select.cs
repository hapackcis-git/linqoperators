using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq4
{
    //There are two projection operators available in LINQ 1).Select 2).SelectMany
  /*
   * Select:- The Select operator always returns an IEnumerable collection which contains elements based on a transformation function.It is similar to the 
   * Select clause of SQL that produces a flat result set.
   * 
   */
    internal class Select
    {
        public static void Main(String[] args)
        {
            List<student> students = new List<student>()
            {
                new student() { Id = 1,Name = "John", Age = 18 } ,
                new student() { Id = 2, Name = "Steve",  Age = 21 } ,
                new student() { Id= 3,Name = "Bill",  Age = 18 } ,
                new student() {Id = 4,Name = "Ram" , Age = 20 } ,
                new student() { Id = 5, Name = "Ron" , Age = 21 }
            };
            var qs=(from s in students
                    select s.Name);
            foreach(var s in qs)
            {
                Console.WriteLine(s);
            }

            var qs1 = (from s in students
                       select new { s.Name, s.Age });

            foreach(var s in qs1)
            {
                Console.WriteLine(s.Name,s.Age);
            }
            var ms = students.Select(s => new { s.Name, s.Age });
            foreach(var s in ms)
            {
                Console.WriteLine(s.Name,s.Age);
            }

        }

    }
}
