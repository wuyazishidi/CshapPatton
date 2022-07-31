using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample {
    abstract class LibraryItem {
        private int numCopies;
        public int NumCopies {
            get { return numCopies; }
            set { numCopies = value; }
        }
        public abstract void Display();
    }

    class Book : LibraryItem {
        private string author;
        private string title;
        public Book(string author, string title, int numCopies) {
            this.author = author;
            this.title = title;
            this.NumCopies = numCopies;
        }
        public override void Display() {
            Console.WriteLine("Book---------");
            Console.WriteLine("Author:{0}", author);
            Console.WriteLine("Title{0}", title);
            Console.WriteLine("#Copies:{0}", NumCopies);
        }

    }

    class Video : LibraryItem {
        private string director;
        private string title;
        private int playTime;

        public Video(string director, string title, int numCopies, int playTime) {
            this.director = director;
            this.title = title;
            this.NumCopies = numCopies;
            this.playTime = playTime;
        }
        public override void Display() {
            Console.WriteLine("Video---------");
            Console.WriteLine("Director:{0}---------", director);
            Console.WriteLine("Title{0}", title);
            Console.WriteLine("#Copies:{0}", NumCopies);
            Console.WriteLine("#PlayTime:{0}", playTime);
        }
    }

    abstract class Decorator : LibraryItem {
        protected LibraryItem libraryItem;
        public Decorator(LibraryItem libraryItem) {
            this.libraryItem = libraryItem;
        }
        public override void Display() {
            libraryItem.Display();
        }
    }
    class Borrowable : Decorator {
        protected ArrayList borrowers = new ArrayList();
        public Borrowable(LibraryItem libraryItem) : base(libraryItem) { }

        public void BorrowItem(string name) {
            borrowers.Add(name);
            libraryItem.NumCopies--;
        }

        public void ReturnItem(string name) {
            borrowers.Remove(name);
            libraryItem.NumCopies++;
        }

        public override void Display() {
            base.Display();
            foreach (string borrower in borrowers) {
                Console.WriteLine("borrower:{0}",borrower);

            }
        }
    }
}
