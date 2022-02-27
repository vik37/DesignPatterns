using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Library.Books
{
    public class ReferenceBook : IBook
    {
        public string LibraryId { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        
        public string Title { get; set; }
    }
}
