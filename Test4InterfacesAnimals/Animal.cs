using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4InterfacesAnimals
{
    abstract class Animal : IAnimal

    {

        private string name;
        private string type;



        protected Animal(string name, string type)

        {

            Name = name;
            Type = type;
        }




        public string Name

        {

            get { return name; }

            private set

            {

                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))

                {

                    throw new ArgumentException("Name can't be null or empty!");

                }

                name = value;

            }

        }



        public string Type
        {
            get { return type; }

            private set

            {

                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))

                {

                    throw new ArgumentException("Type can't be null or empty!");

                }

                type = value;

            }
        }



        public void Perform()

        {


            Console.WriteLine($">>> {this.MakeNoise()}");
            
            Console.WriteLine($">>> {this.MakeTrick()}");

        }
        public abstract string MakeNoise(); // Abstract method for making noise
        public abstract string MakeTrick(); // Abstract method for making tricks


        public override string ToString()

        {

            return $"{Type} {Name}";

        }

    }
}
