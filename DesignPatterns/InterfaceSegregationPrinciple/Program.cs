using InterfaceSegregationPrinciple.Library.AudioBooks;
using System;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            IBorrowableAudioBook audioBook = new AudioBook();
            audioBook.RuntimeInMinutes = 120;
            audioBook.Title = "Zoki Poki";
            audioBook.CheckOut("Mark Twen");
            
            
            var date =  audioBook.GetDueDate();
            Console.WriteLine($"Library Id: {audioBook.LibraryId}");
            Console.WriteLine($"Title:  { audioBook.Title}");
            Console.WriteLine($"Runtime: {audioBook.RuntimeInMinutes}");
            Console.WriteLine($"Borrower {audioBook.Borrower}");
            Console.WriteLine($"Borrow Date: {date}");
            audioBook.CheckIn();
            Console.ReadLine();
        }
    }
}
