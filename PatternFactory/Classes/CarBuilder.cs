using PatternFactory.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory.Classes
{
    class CarBuilder : Builder
    {
        public override Vehisle VehisleCreate()
        {
            return new Car();
        }
    }
}
