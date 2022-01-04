using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public class ExelFile : DataProccessor
    {
        
        public override void ReadData()
        {
            Console.WriteLine("Read data from exel file");
        }
        public override void ProccessData()
        {
            Console.WriteLine("Proccess data from exel file");
        }
    }
}
