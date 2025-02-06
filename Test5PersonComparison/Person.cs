using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5PersonComparison
{
    public class Person : IComparable<Person> //Наследява се интерфейса IComparable 
    {
        private string name;
        private int age;
        private string city;

        public Person(string name, int age, string city)
        {
            Name = name;
            Age = age;
            City = city;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public int Age
        {
            get { return age; }
            private set { age = value; }
        }
        public string City
        {
            get { return city; }
            private set { city = value; }
        }


        public int CompareTo(Person other) //Създава се метод, който сравнява два обекта от тип Person
        {
            if (other == null) return 1;

            int nameComparison = string.Compare(Name, other.Name, StringComparison.Ordinal);
            if (nameComparison != 0) return nameComparison;

            int ageComparison = Age.CompareTo(other.Age);
            if (ageComparison != 0) return ageComparison;

            return string.Compare(City, other.City, StringComparison.Ordinal);
        }

    }
}
