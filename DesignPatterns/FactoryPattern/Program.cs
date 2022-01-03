using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter first number");
            string input = Console.ReadLine();
            double num1, num2;
            bool result = Double.TryParse(input, out num1);
            if (!result)
            {
                Console.WriteLine("Please enter a number");
                return;
            }
            Console.WriteLine("Enter second number");

            result = Double.TryParse(Console.ReadLine(), out num2);
            if (!result)
            {
                Console.WriteLine("Please enter a number");
                return;
            }
            //Divide obj = new Divide();
            //obj.Calculate(num1, num2);

            Console.WriteLine("Enter add, subtract or divide");
            CalculateFactory factory = new CalculateFactory();
            
            ICalculate obj = factory.GetCalculation(Console.ReadLine());
            obj.Calculate(num1, num2);

            Console.ReadLine();
            Main();
        }
    }
}
