using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample {
    class DecoratorApp {
        static void Main(string[] args) {
            Book book = new Book("Schnell","My Home",10);
            Video video = new Video("Spielberg","Schindeler's list",23,60);
            book.Display();
            video.Display();

            /* Make video borrowable ,then borrow and display*/

            Console.WriteLine("Video made borrowable");
            Borrowable borrowvideo= new Borrowable(video);
            borrowvideo.BorrowItem("Cindy Lopez");
            borrowvideo.BorrowItem("Samuel King");
            borrowvideo.Display();
            Console.ReadKey();
            
        }
    }
}
