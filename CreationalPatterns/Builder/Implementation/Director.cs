using Builder.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Implementation
{
    public class Director
    {
        public static IPizzaBuilder CreateEmptyPizzaBuilder()
        {
            return new PizzaBuilder();
        }

        public static IPizzaBuilder CreatePepperoniPizzaBuilder()
        {
            var pizzaBuilder = CreateEmptyPizzaBuilder();

            return pizzaBuilder.SetCheese(Entity.Constants.Cheese.Mozzarella)
                    .SetCrust(Entity.Constants.Crust.Thin)
                    .SetSauce(Entity.Constants.Sauce.Tomato)
                    .SetTopping(new List<Entity.Constants.Topping> {
                            Entity.Constants.Topping.Pepperoni,
                        Entity.Constants.Topping.Mushrooms
                    });
        }

        public static IPizzaBuilder CreateVeggiePizzaBuilder()
        {
            var pizzaBuilder = CreateEmptyPizzaBuilder();

            return pizzaBuilder.SetCheese(Entity.Constants.Cheese.Vegan)
                    .SetCrust(Entity.Constants.Crust.Thin)
                    .SetSauce(Entity.Constants.Sauce.Tomato)
                    .SetTopping(new List<Entity.Constants.Topping> {
                            Entity.Constants.Topping.Mushrooms,
                        Entity.Constants.Topping.Onions,
                        Entity.Constants.Topping.Olives,
                        Entity.Constants.Topping.Peppers
                    });
        }
    }
}
