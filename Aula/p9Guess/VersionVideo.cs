// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using System.Xml.Serialization;

// namespace p8while {
//     class VersionVideo {
//         static void Main(string[] args) {
//             string secretWord = "Tomaz";
//             bool outOfGuess = false;
//             int guessLimit = 3;
//             string guess = "";
//             int count = 0;

//             while (guess != secretWord && !outOfGuess) {
//                 if (count < guessLimit) {
//                     Console.Write("Enter a guess: ");
//                     guess = Console.ReadLine() ?? "";
//                     count++;
//                 } else {
//                     outOfGuess = true;
//                 }
//             }

//             if (!outOfGuess) {
//                 Console.WriteLine("You Win!!!");
//             } else {
//                 Console.WriteLine("You Lose!!!");
//             }

//         }
//     }
// }