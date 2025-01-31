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

            return ($"Meow!");

        }



        public override string MakeTrick()

        {

            return ($"No trick for you! I'm too lazy!");

        }
    }
}
