using System;

namespace TemplateMethodPattern
{
    // Template Method Pattern: Subclasses decidehow to implement steps in an algoritm.
    class Program
    {
        static void Main(string[] args)
        {
            ExelFile obj1 = new ExelFile();
            obj1.ReadProccessAndSaveData();
            //obj1.ReadData();
            //obj1.ProccessData();
            //obj1.SaveData();

            TextFile obj2 = new TextFile();
            obj2.ReadProccessAndSaveData();
            //obj2.ReadData();
            //obj2.ProccessData();
            //obj2.SaveData();
            Console.ReadLine();
        }
    }
}
