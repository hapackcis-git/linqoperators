using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq4
{
    /*
     * Quantifier Operators:-The quantifier operators evaluate elements of the sequence on some condition and return 
     * a boolean value to indicate that some or all elements satisfy the condition.
     * 
     * All: Checks if all the elements in a sequence satifies the specified condition.
     * Any: Checks if any of the elements in a sequence satifies the specified condition
     * Contains:Checks if the sequence contains a specific element.
     * 
     * 
     * 
     */
    internal class Quantifiers
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
            bool ms = students.All(x => x.Age > 12 && x.Age < 20);
            bool ms1 = students.Any(x => x.Age > 12 && x.Age < 20);  
            Console.WriteLine(ms1);
        }
    }
}
