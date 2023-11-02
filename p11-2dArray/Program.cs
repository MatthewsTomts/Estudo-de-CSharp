using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p112dArray {
    class Fibonacci {
        static void Main(string[] args) {
            int[,] numberGrid = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            string sep = ", ";
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    if (i == 2  && j == 2) {
                        sep = "\n";
                    }

                    Console.Write(numberGrid[i,j] + sep);
                }
            }

            int depth = 4;
            int[,] deep = new int[depth, depth];

            int count = 0;
            for (int i = 0; i < depth; i++) {
                for (int j = 0; j < depth; j++) {
                    deep[i,j] = ++count;
                }
            }
            
            sep = ", ";
            for (int i = 0; i < depth; i++) {
                for (int j = 0; j < depth; j++) {
                    if (i == depth-1  && j == depth-1) {
                        sep = "\n";
                    }

                    Console.Write(deep[i,j] + sep);
                }
            }
        }
    }
}