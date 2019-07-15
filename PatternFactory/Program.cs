using PatternFactory.AbstractClass;
using PatternFactory.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Builder builder = new CarBuilder();
            Vehisle vehisle = builder.VehisleCreate();
            vehisle.Info();

            Builder buider1 = new ShipBuilder();
            Vehisle vehisle1 = buider1.VehisleCreate();
            vehisle1.Info();

        }
    }
}
