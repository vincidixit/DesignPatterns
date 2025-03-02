using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Builder.Entity.Constants;

namespace Builder.Entity
{
    public class Pizza
    {
        public Crust crust { get; set; }

        public Sauce sauce { get; set; }

        public Cheese cheese { get; set; }

        public List<Topping> toppings { get; set; }

    }
}
