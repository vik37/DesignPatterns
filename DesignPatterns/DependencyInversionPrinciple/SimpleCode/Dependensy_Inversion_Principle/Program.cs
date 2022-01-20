﻿using DemoLibrary;
using System;

namespace Dependensy_Inversion_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            Person owner = new Person
            {
                FirstName = "Viktor",
                LastName = "Zafirovski",
                EmailAddress = "zaf.vik@viktor.org",
                PhoneNumber = "555-1116"
            };
            Chore chore = new Chore
            {
                ChoreName = "Take out the trash",
                Owner = owner
            };
            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.ComplateChore();
            Console.ReadLine();
        }
    }
}
