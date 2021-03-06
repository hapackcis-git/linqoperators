using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq4
{
    internal class FirstOrDefault
    {
        public static void Main(String[] args)
        {
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
            IList<string> emptyList = new List<string>();

            Console.WriteLine(intList.First());
            Console.WriteLine(intList.First(i=>i%2==0));
            Console.WriteLine(strList.First());
        


            Console.WriteLine("\n=====================================================================================");
            Console.WriteLine("1st Element in intList:{0}",intList.FirstOrDefault());
            Console.WriteLine("1st Even Element in intList:{0}",intList.FirstOrDefault(i=>i%2==0));
            Console.WriteLine("1st Element in strList:{0}",strList.FirstOrDefault());
            Console.WriteLine("1st Element in emptyList:{0}",emptyList.FirstOrDefault());
        }
    }
}
