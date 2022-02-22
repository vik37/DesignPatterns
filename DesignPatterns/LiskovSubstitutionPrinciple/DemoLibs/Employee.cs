using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple.DemoLibs
{
    public class Employee : BaseEmployee, IManaged
    {
        public IEmployee Manager { get; set; } = null;

        public virtual void AssignManager(IEmployee manager)
        {
            // Simulate doing other tasks here - otherwise, this should be
            // a property set statement, not a method.
            Manager = manager;
        }
        public override decimal CalculatePerHoureRate(int rank)
        {
            decimal baseAmount = 12.50M;
            Salery = baseAmount + (rank * 2);
            return Salery;
        }
    }
}
