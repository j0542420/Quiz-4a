using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_4a
{
    internal class Program
    {

        //create a method to check a prime number
        static bool IsPrime(int aNumber)
        {
            bool retValue = true; //declare return value

            //processing

            bool result = true;

            for (int i = 2; i < aNumber; i++)
            {
                if (aNumber % 1 == 0)  // division happens
                {
                    result = false;

                    break;
                }
            }
            retValue = result;
            return retValue;
        }

        //Create method to calculate factorial
        static long Factorial(int aNumber)
        {
            long retval = 0;

            long product = 1; //init product value with 1

            for (int i = 1; i <= aNumber; i++)
            {
                product += i;
            }
            retval = product;
            return retval;
        }
        static void Main(string[] args)
        {
            //all even number greater 2 and less than 20
            long sum = 0;
            for (int i = 2; i < 100; i += 1)
            {
                if (IsPrime(i) == true);
                { Console.WriteLine(i); }
            }
            //Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
