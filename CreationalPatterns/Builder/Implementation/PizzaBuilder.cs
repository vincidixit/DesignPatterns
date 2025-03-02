using Builder.Abstraction;
using Builder.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Implementation
{
    public class PizzaBuilder : IPizzaBuilder
    {
        private readonly Pizza _pizza;
        
        public PizzaBuilder()
        {
            _pizza = new Pizza();
        }

        public IPizzaBuilder SetCheese(Constants.Cheese cheeseType)
        {
            _pizza.cheese = cheeseType;
            return this;
        }

        public IPizzaBuilder SetCrust(Constants.Crust crustType)
        {
            _pizza.crust = crustType;
            return this;
        }

        public IPizzaBuilder SetSauce(Constants.Sauce sauceType)
        {
            _pizza.sauce = sauceType;
            return this;
        }

        public IPizzaBuilder SetTopping(List<Constants.Topping> toppings)
        {
            _pizza.toppings = toppings;
            return this;
        }
        public Pizza Build()
        {
            return _pizza;
        }
    }
}
