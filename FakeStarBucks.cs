using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMakers
{
    public class FakeStarBucks : ICoffeeMaker
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