using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple.DemoLibs
{
    public abstract class BaseEmployee : IEmployee
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public decimal Salery { get; set; }

        public virtual decimal CalculatePerHoureRate(int rank)
        {
            decimal baseAmount = 12.50M;
            Salery = baseAmount + (rank * 2);
            return Salery;
        }
    }
}
