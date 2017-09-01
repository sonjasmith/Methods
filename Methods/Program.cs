using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 25;
            int number2 = 50;
            int total = Add(number1, number2);
            Console.WriteLine(total);
        }
        public static int Add(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber; //place holders...don't interfere with one another because of scope

            return sum; //now invoke method
        }
        
        public static int Multiply(int firstNumber, int secondNumber)
        {
            int product = firstNumber * secondNumber;

            return product;
        }
    }
}
