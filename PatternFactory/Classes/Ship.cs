using PatternFactory.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory.Classes
{
    class Ship : Vehisle
    {
        public override void Info()
        {
            Console.WriteLine("I am Ship !!! ");
        }
    }
}
