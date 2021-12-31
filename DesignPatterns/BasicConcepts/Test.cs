using System;

namespace BasicConcepts
{
    class Test
    {
        interface IA
        {
            void MethodA();
            
        }
        class B : IA
        {
            public void MethodA()
            {
                Console.WriteLine("B - MA");
            }
            public void MethodB()
            {
                Console.WriteLine("B - MB");
            }
        }
        static void Main()
        {
            //Console.WriteLine("A obj");
            //A aobj = new A();
            //aobj.MethodA();
            Console.WriteLine("B obj");
            B bobj = new B();
            bobj.MethodA();
            bobj.MethodB();
            //Superclass obj = new Subclass()
            int x = 10;
            IA obj1 = new B();
            Console.WriteLine("A or B? obj");
            obj1.MethodA();
            ((B)obj1).MethodB();
            (obj1 as B).MethodB();
            //Can not du this
            //B obj = new A();
            Console.ReadLine();
        }
    }
}
