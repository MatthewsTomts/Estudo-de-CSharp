using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using teste; // I can use other namespace with using (Example Module)

namespace p12Library {
    class Program {
        static void Main(string[] args) {
            // Cannot create an object of a static class
            // Module teste = new();
            Module.SayHi();

            Book blondeLocks = new (32, "Goldilocks and the Three Bears", "Robert Southey");
            Console.WriteLine("The Book Title: " + blondeLocks.GetTitle());
            Console.WriteLine("The Book Author: " + blondeLocks.GetAuthor());
            Console.WriteLine("The Book Number of Pages: " + blondeLocks.GetPages() + "\n");

            Console.WriteLine(Book.test);
            Console.WriteLine(blondeLocks.teset2 + "\n");

            Book lordRings = new (700, "Lord of The Rings", "Tolkein");
            lordRings.Title = "The Hobbit";
            Console.WriteLine("The Book Title: " + lordRings.Title);
            Console.WriteLine("The Book Author: " + lordRings.Author);
            Console.WriteLine("The Book Number of Pages: " + lordRings.Pages);

            Console.WriteLine("\nNumber of books: " + Book.bookCount);
            Console.WriteLine("Number of books: " + lordRings.BookCount);
        }
    }
}