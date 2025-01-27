using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4AbstractionSalaries
{
    class FullTimeEmployee : BaseEmployee
    {
        public FullTimeEmployee(string name) : base(name) { }
        public override double CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 10.8;
        }
    }
}
