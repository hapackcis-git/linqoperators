using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq4
{
    internal class AverageLinq
    {
        public static void Main(String[] args)
        {
            IList<int> list = new List<int>() { 10,20,30};
            var avg = list.Average();

            Console.WriteLine(avg);



            List<student> students = new List<student>()
            {
                new student() { Id = 1,Name = "John", Age = 18 } ,
                new student() { Id = 2, Name = "Steve",  Age = 21 } ,
                new student() { Id= 3,Name = "Bill",  Age = 18 } ,
                new student() {Id = 4,Name = "Ram" , Age = 20 } ,
                new student() { Id = 5, Name = "Ron" , Age = 21 }
            };
            var ms=students.Average(x => x.Age);    
            Console.WriteLine(ms);  
        }
    }
}
