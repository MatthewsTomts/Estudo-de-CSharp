using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace p8while {
    class Test {
        static void Main(string[] args) {
            string secretWord = "Tomaz";
            int guessLimit = 3;
            int count = 0;
            string guess;

            do {
                Console.Write("Enter a guess: ");
                guess = Console.ReadLine() ?? "";
                count++;
                if (guess == secretWord) {
                    Console.WriteLine("You Win!!!");
                    break;
                } else if (count == guessLimit) {
                    Console.WriteLine("You Lose!!!");
                    break;
                }
            } while (true);

        }
    }
}