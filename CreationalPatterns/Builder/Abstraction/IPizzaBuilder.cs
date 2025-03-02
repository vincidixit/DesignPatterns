using Builder.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Builder.Entity.Constants;

namespace Builder.Abstraction
{
    public interface IPizzaBuilder
    {
        IPizzaBuilder SetCrust(Crust crustType);

        IPizzaBuilder SetSauce(Sauce sauceType);

        IPizzaBuilder SetCheese(Cheese cheeseType);

        IPizzaBuilder SetTopping(List<Topping> toppings);

        Pizza Build();
    }
}
