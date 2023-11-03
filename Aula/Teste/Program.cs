using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance;
class Program {
    static void Main(string[] args) {
        int[] numbers = { 2, 2, 3, 4 };
        List<string> lista = new List<string>() {
            "jose", "Jasmin"
        };

        lista.Add("lista");

        foreach(string item in lista) {
            Console.WriteLine(item);
        }

        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }

        // Count is an attribute of List<> that represents the length of the List
        for (int i = 0; i < lista.Count; i++) {
            Console.WriteLine(lista[i]);
        }

        // Iterates through the array to count its elements.
        for (int i = 0; i < numbers.Count(); i++)
        {
            Console.WriteLine(numbers[i]);
        }

        // More efficient that the one above because, already has the length stored
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}
