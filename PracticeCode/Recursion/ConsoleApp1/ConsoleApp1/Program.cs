using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));

            Console.WriteLine(PowerOf(2,4));

            Console.WriteLine(Addition(100));
        }


        static private int Factorial(int input)
        {
            if (input == 1)
                return 1;

            return input * Factorial(input - 1);
        }

        //static private double PowerOf(double baseNum, int timesOfPower, int start)
        //{
        //    if (start > timesOfPower)
        //        return 1;

        //        return baseNum * PowerOf(baseNum, timesOfPower, start +1);
        //}

        static private double PowerOf(double baseNum, int timesOfPower)
        {
            if (timesOfPower == 1)
                return baseNum;

            return baseNum * PowerOf(baseNum, timesOfPower-1);
        }



        static private int Addition(int input)
        {
            if (input == 1)
                return 1;

            return input  + Addition(input -1);
        }
    }
}
