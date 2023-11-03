using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace madlibs {
    class Test {
        static void Main(string[] args) {
            string color, plural, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine() ?? "red";

            Console.Write("Enter a plural noun: ");
            plural = Console.ReadLine() ?? "Violets";

            Console.Write("Enter a celebrity name: ");
            celebrity = Console.ReadLine() ?? "Icky";

            Console.WriteLine($"Roses are {color}");
            Console.WriteLine($"{plural} are blue");
            Console.WriteLine($"I love {celebrity}");
        }
    }
}