    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4InterfacesAnimals
{

    interface IAnimal : IMakeNoise, IMakeTrick //

    {

        public string Type { get; } //missing {

        public string Name { get; }

        void Perform();

    }
}
