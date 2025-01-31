using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4InterfacesAnimals
{

    class Dog : Animal

    {
        public Dog(string name) : base(name, "Dog")
        {

        }

        public override string MakeNoise()

        {
            Console.WriteLine("Woof!");
            return "Woof!";
        }

        public override string MakeTrick()

        {
            Console.WriteLine("Hold my paw, human!");
            return "Hold my paw, human!";
        }

    }
}
