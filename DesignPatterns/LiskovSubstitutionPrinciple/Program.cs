using LiskovSubstitutionPrinciple.DemoLibs;
using System;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        // Liskov Substitution Principles - objects of superclass
        // shall be replaceable with objects of its subclasses without breaking the application.
        static void Main(string[] args)
        {
            Manager accountingVP = new Manager();
            accountingVP.Firstname = "Emma";
            accountingVP.Lastname = "Stone";
            accountingVP.CalculatePerHoureRate(4);

            Employee emp = new Manager();
            emp.Firstname = "Viktor";
            emp.Lastname = "Zafirovski";
            emp.AssignManager(emp);
            emp.CalculatePerHoureRate(2);

            Console.WriteLine($"{emp.Firstname} {emp.Lastname}'salery is ${emp.Salery}/hour.");
            
            Console.ReadLine();
        }
    }
}
