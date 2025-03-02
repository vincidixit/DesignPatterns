using Builder.Abstraction;
using Builder.Entity;
using Builder.Implementation;

namespace Builder.Client
{
    public class Application
    {
        public void BuildPizzas()
        {

            {
                //Building pizza from scratch

                IPizzaBuilder builder = Director.CreateEmptyPizzaBuilder();

                builder.SetCheese(Entity.Constants.Cheese.Parmesan)
                        .SetCrust(Entity.Constants.Crust.GlutenFree)
                        .SetSauce(Entity.Constants.Sauce.Pesto)
                        .SetTopping(new List<Entity.Constants.Topping> {
                            Entity.Constants.Topping.Pepperoni,
                        Entity.Constants.Topping.Mushrooms
                        });

                Pizza pizza = builder.Build();
                Console.WriteLine($"Pizza with {pizza.cheese} cheese, {pizza.crust} crust, {pizza.sauce} sauce, and toppings: {string.Join(", ", pizza.toppings)}");

            }

            {
                // Building pizza from pizza builder with some pre-configured defaults

                IPizzaBuilder builder = Director.CreateVeggiePizzaBuilder();

                // Overriding the sauce
                builder.SetSauce(Entity.Constants.Sauce.Pesto);

                Pizza pizza = builder.Build();
                Console.WriteLine($"Pizza with {pizza.cheese} cheese, {pizza.crust} crust, {pizza.sauce} sauce, and toppings: {string.Join(", ", pizza.toppings)}");

            }

            {
                // Building pizza from pizza builder with some pre-configured defaults

                IPizzaBuilder builder = Director.CreatePepperoniPizzaBuilder();

                Pizza pizza = builder.Build();
                Console.WriteLine($"Pizza with {pizza.cheese} cheese, {pizza.crust} crust, {pizza.sauce} sauce, and toppings: {string.Join(", ", pizza.toppings)}");
            }

        }
    }
}
