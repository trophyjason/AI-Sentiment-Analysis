using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project_441101_2223
{
    public static class ConsoleHelpers
    {
        public static int GetIntegerInRange(int pMin, int pMax, string pMessage)
        {
            if (pMin > pMax)
            {
                throw new Exception($"Minimum value {pMin} cannot be greater than maximum value {pMax}");
            }

            int result;

            do
            {
                Console.WriteLine(pMessage);
                Console.WriteLine($"Please enter a number between {pMin} and {pMax} inclusive.");

                string userInput = Console.ReadLine();

                try
                {
                    result = int.Parse(userInput);
                }
                catch
                {
                    Console.WriteLine($"{userInput} is not a number");
                    continue;
                }

                if (result >= pMin && result <= pMax)
                {
                    return result;
                }
                Console.WriteLine($"{result} is not between {pMin} and {pMax} inclusive.");
            } while (true);
        }
        public static double GetAmount(string pMessage)
        {
            double result;

            do
            {
                Console.WriteLine(pMessage);

                string userInput = Console.ReadLine();

                try
                {
                    result = double.Parse(userInput);
                }
                catch
                {
                    Console.WriteLine($"{userInput} is not a number");
                    continue;
                }

                if(result > 0)
                {
                    return result;
                }
                Console.WriteLine($"{result} is less than zero");
            }
            while(true);
        }
        public static void TransactionHeadings()
        {
            Console.WriteLine("{0,0} {1,8}", "Type","Amount");
        }
        public static void TransactionFormat(string text1, string num1)
        {
            Console.WriteLine("{0,0} {1,8}", text1, num1);
        }
        public static void SummaryHeadings()
        {
            Console.WriteLine("{0,0} {1,8} {2,15} {3,10} {4,10}", "Id", "Sale", "Purchases", "Refund", "Profit");
        }
        public static void SummaryFormat(string num1, string num2, string num3, string num4, string num5)
        {
            Console.WriteLine("{0,0} {1,8} {2,15} {3,10} {4,10}", num1, num2, num3, num4, num5);
        }
    }
}
