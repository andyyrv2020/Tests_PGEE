using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4InterfacesAnimals
{
    class Cat : Animal

    {
        public Cat(string name) : base(name, "Cat")
        {

        }

        public override string MakeNoise()

        {
            Console.WriteLine("Meow!");
            return "Meow!";
        }

        public override string MakeTrick()
        {
            Console.WriteLine("No trick for you! I'm too lazy");
            return "No trick for you! I'm too lazy!";
        }
    }
}
