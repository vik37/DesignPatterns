using InterfaceSegregationPrinciple.Library.GeneralInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Library.DVDs
{
    public interface IBorrowableDVD : IDVD, IBorrowable
    {
    }
}
