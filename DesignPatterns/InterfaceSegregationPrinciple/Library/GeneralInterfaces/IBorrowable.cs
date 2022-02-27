using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Library.GeneralInterfaces
{
    public interface IBorrowable
    {
        public int CheckOutDurationDays { get; set; }
        public string Borrower { get; set; }
        public DateTime BorrowDate { get; set; }
        public void CheckOut(string borrower);
        public void CheckIn();
        public DateTime GetDueDate();
    }
}
