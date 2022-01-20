using DemoLibrary;
using System;

namespace Dependensy_Inversion_Principle
{
    class Program
    {
        /*
         * DEPENDENCY INVERSION PRINCIPLE -
         *    Depend upon abstraction. Do not depend upon concrete classes.
         */
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();
            owner.FirstName = "Viktor";
            owner.LastName = "Zafirovski";
            owner.EmailAddress = "zaf.vik@viktor.org";
            owner.PhoneNumber = "555-1116";

            IChore chore = Factory.CreateChore();
            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;
            
            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.ComplateChore();
            Console.ReadLine();
        }
    }
}
