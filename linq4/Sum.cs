using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq4
{
    internal class Sum
    {
        //The Sum() method calculates the sum of numeric items in the collection.
        /*
         * The following example demonstrates Sum() on primitive collection.
         */
        public static void Main(String[] args)
        {
            IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };
            var total=intList.Sum();
            Console.WriteLine(total);
            var sumOfEvenElements = intList.Sum(i =>
            {
                if (i % 2 == 0)
                    return i;
                return 0;
            });
            Console.WriteLine("Sum of Even Elements:{0}",sumOfEvenElements);

        }
    }
}
