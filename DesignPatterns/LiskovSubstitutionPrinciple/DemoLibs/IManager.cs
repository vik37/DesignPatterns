using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple.DemoLibs
{
    public interface IManager : IEmployee
    {
        void GeneratePerformanceReview();
    }
}
