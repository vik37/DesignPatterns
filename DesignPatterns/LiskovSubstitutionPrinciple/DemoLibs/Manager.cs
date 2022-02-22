using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple.DemoLibs
{
    public class Manager : Employee, IManager
    {
        public override decimal CalculatePerHoureRate(int rank)
        {
            decimal baseAmount = 19.75M;
            Salery = baseAmount * (rank * 4);
            return Salery;
        }

        public void GeneratePerformanceReview()
        {
            //Simulate reviewing direct report!
            Console.WriteLine("I'm reviewing a direct report's performance.");
        }

    }
}
