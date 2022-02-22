using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple.DemoLibs
{
    public class Ceo : BaseEmployee, IManager
    {
        public override decimal CalculatePerHoureRate(int rank)
        {
            decimal baseAmount = 150M;
            Salery = baseAmount * rank;
            return Salery;
            
        }
        public void GeneratePerformanceReview()
        {
            // Simulate reviewing a direct report
            Console.WriteLine("I'm reviewing a direct report's performance.");
        }
        public void FirstSomeone()
        {
            Console.WriteLine("You're Fired!");
        }
    }
}
