using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMakers
{
    public class StarBucksStore
    {
        private readonly ICoffeeMaker service;
        public StarBucksStore(ICoffeeMaker service)
        {
            this.service = service;
        }
        public string OrderCoffee(int sugarPerSpoon, int coffeeCount)
        {
            if (service.CheckCoffeeAvailability())
            {
                return service.CoffeeMaking(sugarPerSpoon, coffeeCount);
            }
            else
            {
                return "coffee unavailable";
            }
        }
    }
}
