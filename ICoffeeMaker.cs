using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMakers
{
    public interface ICoffeeMaker
    {
        bool CheckCoffeeAvailability();
        string CoffeeMaking(int sugarPerSpoon, int coffeePack);
    }
}
