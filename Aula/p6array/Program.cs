using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array {
    class Test {
        static void Main(string[] args) {
            int[] luckyNumbers = { 1, 2, 3, 5, 8, 13, 21, 34, 55};
            string[] friends = new string[7];
            friends[0] = "Madeleine";
            friends[1] = "Mark";
            friends[2] = "Oliver";
            friends[3] = "Olivia";
            friends[4] = "Violett";
            friends[5] = "Harvey";
            friends[6] = "Roger";

            for (int i = 0; i < friends.Length; i++) {
                int pow;

                if (i % 2 == 1) {
                    pow = 3;
                } else {
                    pow = 2;
                }

                double number = cube(pow, 20);
                SayHi(friends[i], number);
            }
        }

        static void SayHi(string friend, double num) {
            Console.WriteLine($"Hello, {friend} and your age is {num}");
        }

        static double cube(int pow, double num) {
            return Math.Pow(num, pow);
        }
    }
}