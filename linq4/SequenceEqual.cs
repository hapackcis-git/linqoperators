using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq4
{
    internal class SequenceEqual
    {
        public static void Main(String[] args)
        {

            List<student> student1 = new List<student>()
            {
                new student() { Id = 1,Name = "John", Age = 18 } ,
                new student() { Id = 2, Name = "Steve",  Age = 21 } ,
                new student() { Id= 3,Name = "Bill",  Age = 18 } ,
                new student() {Id = 4,Name = "Ram" , Age = 20 } ,
                new student() { Id = 5, Name = "Ron" , Age = 21 }
            };


            List<student> student2 = new List<student>()
            {
                new student() { Id = 1,Name = "John", Age = 18 } ,
                new student() { Id = 2, Name = "Steve",  Age = 21 } ,
                new student() { Id= 3,Name = "Bill",  Age = 18 } ,
                new student() {Id = 4,Name = "Ram" , Age = 20 } ,
                new student() { Id = 5, Name = "Ron" , Age = 21 }
            };
            bool b1=student1.SequenceEqual(student2,new StudentComparer());
            Console.WriteLine(b1);

        }
    }

    class StudentComparer : IEqualityComparer<student>
    {
        public bool Equals(student x, student y)
        {
           if(x.Id== y.Id && x.Name.ToLower()==y.Name.ToLower()) 
                return true;
           return false;
        }

        public int GetHashCode(student obj)
        {
           return obj.GetHashCode(); 
        }
    }
}
