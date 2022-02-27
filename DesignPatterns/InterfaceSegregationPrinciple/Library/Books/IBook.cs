using InterfaceSegregationPrinciple.Library.GeneralInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Library.Books
{
    public interface IBook : ILibraryItem
    {
        public string Author { get; set; }
        public int Pages { get; set; }
    }
}
