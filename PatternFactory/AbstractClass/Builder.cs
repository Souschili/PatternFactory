using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactory.AbstractClass
{
    // сильно упрощеный класс
    abstract class Builder
    {
        
        //фабричный метод
        abstract public Vehisle VehisleCreate();
    }
}
