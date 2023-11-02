using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step3 {
    class Test {
        static void Main(string[] args) {
            string phrase = "Giraffe Academy";
            char grade = 'C';
            int age = 30;
            double numb = 3.0000000900;

            Console.WriteLine("Size of the phrase: " + phrase.Length);  
            Console.WriteLine("Teste".ToUpper());
            Console.WriteLine("Lower contains t? " + "Teste".ToLower().Contains("t"));
            Console.WriteLine("Char on position 4-2 (2): " + "teste"[4-2]);
            Console.WriteLine("Substring starting on 0 and getting 5 character: " +
                "teste jose".Substring(3,5));
            Console.WriteLine("Index of s: " + "teste".IndexOf("s"));
            Console.WriteLine("Index of a: " + "teste".IndexOf("a"));
            Console.WriteLine("Substring 2 to end: " + "teste".Substring(2));
            Console.WriteLine("3/2 is: " + 3/2);
            Console.WriteLine("which is difference from 3/2.0: " + 3/2.0);
            Console.WriteLine(Math.Pow(3, 2.1));
            Console.WriteLine(grade);  
            Console.WriteLine(age); 
            Console.WriteLine(numb); 
        }
    }
}