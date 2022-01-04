using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public class TextFile : DataProccessor
    {
        
        public override void ReadData()
        {
            Console.WriteLine("Read data from text file");
        }
        public override void ProccessData()
        {
            Console.WriteLine("Proccess data from text file");
        }
        
    }
}
