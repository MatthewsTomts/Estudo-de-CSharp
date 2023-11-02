using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance {
    class Program {
        static void Main(string[] args) {
            Chef violett = new();
            violett.MakeSalad();
            violett.MakeChicken();
            violett.MakeSpecialDish();

            Console.WriteLine();
            
            ItalianChef harvey = new();
            harvey.MakeSalad();
            harvey.MakeChicken();
            harvey.MakeSpecialDish();
            harvey.MakePasta();
        }
    }
}