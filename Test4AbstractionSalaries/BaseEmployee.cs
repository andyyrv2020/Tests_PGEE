using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4AbstractionSalaries
{
    abstract class BaseEmployee
    {
		public string Name { get; set; }

        public BaseEmployee(string name)
        {
            Name = name;
        }

        public abstract double CalculateSalary(int workingHours);
    }
}
