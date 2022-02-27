using InterfaceSegregationPrinciple.Library.GeneralInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Library.AudioBooks
{
    public interface IBorrowableAudioBook : IAudioBook, IBorrowable
    {
    }
}
