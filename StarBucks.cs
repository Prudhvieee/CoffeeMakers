using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMakers
{
    public class StarBucks : ICoffeeMaker
    {
        public bool CheckCoffeeAvailability()
        {
            return true;
        }

        public string CoffeeMaking(int sugarPerSpoon, int coffeePack)
        {
            throw new NotImplementedException();
        }
    }
    public class StubStarBucks : ICoffeeMaker
    {
        public bool CheckCoffeeAvailability()
        {
            return true;
        }

        public string CoffeeMaking(int sugarPerSpoon, int coffeePack)
        {
            return "your order is received";
        }
    }
}
