using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Library.DVDs
{
    public interface IDVD
    {
        public List<string> Actors { get; set; }
        public int RuntimeInMinutes { get; set; }
    }
}
