using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public abstract class DataProccessor
    {
        public void ReadProccessAndSaveData()
        {
            ReadData();
            ProccessData();
            SaveData();
        }
        public abstract void ReadData();
        public abstract void ProccessData();
        public void SaveData()
        {
            Console.WriteLine("Save data to db");
        }
    }
}
