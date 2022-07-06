using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq4
{
    internal class Concatenationcs
    {
        public static void Main(String[] args)
        {
            IList<string> collection1 = new List<string>() { "One", "Two", "Three" };
            IList<string> collection2 = new List<string>() { "Five", "Six" };
            var c=collection1.Concat(collection2);
            foreach(string str in c)
            {
                Console.WriteLine(str); 
            }
        }
    }

}
