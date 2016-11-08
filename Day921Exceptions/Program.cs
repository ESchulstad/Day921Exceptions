using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day921Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            try
            {
                Console.WriteLine("Enter a number");
                string numberText = Console.ReadLine();
                int number = int.Parse(numberText);
                Console.WriteLine("your number is " + number);
            }
            catch(FormatException objectName)
            {
                Console.WriteLine("This is not valid");
            }
            */

            float result;
            int num;

            Console.Write("Enter a number: ");

            try
            {
                num = Convert.ToInt32(Console.ReadLine());

                if (num < 0)
                {
                    Console.WriteLine("Please enter a number greater than zero.");
                    num = int.Parse(Console.ReadLine());
                }
                else
                {

                    result = (float)Math.Sqrt(num);
                    Console.WriteLine("The result is:{0}", result);
                }

            }
            catch(Exception)
            {
                Console.WriteLine("Error, I cannot calculate the Square Root.");
            }
            

        }
    }
}
