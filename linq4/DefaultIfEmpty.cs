using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq4
{
    internal class DefaultIfEmpty
    {
        public static void Main(String[] args)
        {
            IList<student> emptyStudentList = new List<student>();
            var newStudentList1 = emptyStudentList.DefaultIfEmpty();
            var newStudentList2 = emptyStudentList.DefaultIfEmpty(new student() { Id = 0, Name = "" });

            Console.WriteLine("Count: {0} ", newStudentList1.Count());
            Console.WriteLine("Student ID: {0} ", newStudentList1.ElementAt(0));
            Console.WriteLine("Count: {0} ", newStudentList2.Count());
            Console.WriteLine("Student ID: {0} ", newStudentList2.ElementAt(0).Id);

        }
    }
}
