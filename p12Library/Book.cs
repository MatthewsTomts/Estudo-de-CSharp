using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p12Library {
    class Book {
        private string title;
        private string author;
        private int pages;
        static public bool test = true; // It is stored on the Class instead of the Object
        public bool teset2 = false;
        public static int bookCount = 0;

        public Book(int pages, string title, string author) {
            this.pages = pages;
            this.title = title;
            this.author = author;
            bookCount++;
        }

        public int BookCount {
            get {return bookCount; }
        }

        public string Title {
            get { return title; }
            set { this.title = value; }
        }

        public string Author {
            get { return author; }
            set { this.author = value; }
        }

        public int Pages {
            get { return pages; }
            set { this.pages = value; }
        }

        // Java
        public void SetTitle (string title) {
            this.title = title;
        }

        public string GetTitle () {
            return this.title;
        }

        public void SetAuthor (string author) {
            this.author = author;
        }

        public string GetAuthor () {
            return this.author;
        }

        public void SetPages (int pages) {
            this.pages = pages;
        }

        public int GetPages () {
            return this.pages;
        }
    }
}