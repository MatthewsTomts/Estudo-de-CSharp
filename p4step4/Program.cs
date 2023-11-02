using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step4 {
    class Test {
        static void Main(string[] args) {
            Console.Write("Enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Hello, {number + number2}");
        }
    }
}