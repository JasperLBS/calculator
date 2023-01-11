using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class calucator
    {
        static int number1;
        static int number2;
        static int sum;

        public calucator()
        {
            number1 = 0;
            number2 = 0;
            sum = 0;
        }
        public static void Addition()
        {
            Console.Write("\nEnter first number: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("\nEnter second number: ");
            number2 = int.Parse(Console.ReadLine());
            sum = number1 + number2;
            Console.WriteLine("The sum of the two numbers is: {0}", sum);

        }
    }
}
