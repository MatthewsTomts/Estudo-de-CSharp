using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora {
    class Test {
        static void Main(string[] args) {
            Console.Write("Enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator: ");
            string op = Console.ReadLine() ?? "+";

            Console.Write("Enter another number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            switch (op) {
                case "-":
                    Console.WriteLine($"The substraction of this numbers is: {number - number2}");
                    break;
                case "+":
                    Console.WriteLine($"The substraction of this numbers is: {number + number2}");
                    break;
                case "/":
                    Console.WriteLine($"The substraction of this numbers is: {number / number2}");
                    break;
                case "x":
                    Console.WriteLine($"The substraction of this numbers is: {number * number2}");
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
        }
    }
}