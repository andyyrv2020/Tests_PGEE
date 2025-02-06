using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5People
{
    public class Person
    {
        private string firstName;
        private int age;

        public Person(string firstName, int age)
        {
            FirstName = firstName;
            Age = age; // Добавена липсваща запетая
        }

        public string FirstName
        {
            get { return firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The first name cannot be null or empty", nameof(value));
                }
                firstName = value;
            }
        }

        public int Age
        {
            get { return age; }
            private set
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Age should be in the range [0..120]");
                }
                age = value;
            }
        }
    }
}
