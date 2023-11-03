using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10For {
    class Fibonacci {
        static void Main(string[] args) {
            Console.Write("How many numbers of the Fibonacci sequence do you want? ");
            int num;
            try {
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 0) {
                    throw new NegativeNumberException();
                }
            } catch (FormatException) {
                Console.WriteLine("Please enter a whole number.");
                return;
            } catch (NegativeNumberException e) {
                Console.WriteLine(e.Message);
                return;
            }

            int[] seq = Fib(num);

            for (int i = 0; i < num; i ++) {
                string sep = ", ";
                if (i == num-1) {
                    sep = "\n";
                }

                Console.Write(seq[i] + sep);
            }
        }

        static int[] Fib(int num) {
            int[] seq = new int[num];

            for (int i = 0; i < num; i++) {
                if (i == 0 || i == 1) {
                    seq[i] = i;
                } else {
                    seq[i] = seq[i-1] + seq[i-2];
                }
            }

            return seq;
        }
    }
}