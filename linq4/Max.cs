using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq4
{
    internal class Max
    {
        public static void Main(String[] args)
        {
            IList<int> list = new List<int>();
            var largest = list.Max();
            Console.WriteLine(largest);
            var largestEvenList = list.Max(i =>
            {
                if (i % 2 == 0)
                    return i;
                return 0;
            });
            Console.WriteLine(largestEvenList);

        }

    }
}
