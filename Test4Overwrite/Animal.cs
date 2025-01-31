using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4Overwrite
{
    class Animal
    {
        public virtual void MakeTrick()
        {
            Console.WriteLine("No trick!");
        }
    }
}
