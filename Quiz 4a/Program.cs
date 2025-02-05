using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_4a
{
    internal class Program
    {
        static long Factorial(int aNumber)
        {
            //Create method to calculate factorial
            long retval = Int32.MinValue;

            long product = 1;

            for (int i = 1; i <= aNumber; i++)
            {
                product += i;
            }
            retval = product;
            return retval;
        }
        static void Main(string[] args)
        {
            //declarations

            Console.WriteLine(Factorial(20));


            Console.Read();






        }
    }
}
