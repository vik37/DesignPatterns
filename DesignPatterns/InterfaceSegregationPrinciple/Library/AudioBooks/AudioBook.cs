using InterfaceSegregationPrinciple.Library.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Library.AudioBooks
{
    public class AudioBook : IBorrowableAudioBook
    {
        public AudioBook()
        {
            this.LibraryId = RandomIds.CreateRandomId();
        }
        public string LibraryId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        
        public int CheckOutDurationDays { get; set; } = 14;
        public string Borrower { get; set; }
        public DateTime BorrowDate { get; set; }
        public int RuntimeInMinutes { get; set; }
        
        public void CheckIn()
        {
            Borrower = "";
        }

        public void CheckOut(string borrower)
        {
            Borrower = borrower;
            BorrowDate = DateTime.Now;
        }

        public DateTime GetDueDate()
        {
            return BorrowDate.AddDays(CheckOutDurationDays);
        }
    }
}
