using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4Overwrite
{
    class Dog : Animal
    {
        public override void MakeTrick()
        {
            Console.WriteLine("Give a paw!");
        }
    }
}
