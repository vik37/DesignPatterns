using InterfaceSegregationPrinciple.Library.GeneralInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Library.Books
{
    public interface IBorrowableBook : IBorrowable, IBook
    {
    }
}
