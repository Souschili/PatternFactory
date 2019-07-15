using PatternFactory.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory.Classes
{
    class ShipBuilder : Builder
    {
        public override Vehisle VehisleCreate()
        {
            return new Ship();
        }
    }
}
