using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class Pizza
    {        
        public string Size { get; }
        public string Dough {  get; }
        public bool HasCheese { get;  }
        public bool HasPepperoni { get; }
        public bool HasMushrooms { get; }

        public Pizza(PizzaBuilder builder)
        {
            Size = builder.Size;
            Dough = builder.Dough;
            HasCheese = builder.HasCheese;
            HasPepperoni = builder.HasPepperoni;
            HasMushrooms = builder.HasMushrooms;
        }

        public string Describe()
        {
            var extras = $"{(HasCheese ? "Cheese " : "")}{(HasPepperoni ? "Pepperoni " : "")}{(HasMushrooms ? "Mushrooms" : "")}";
            return $"Pizza {Size} with dough {Dough}. Extras: {(string.IsNullOrEmpty(extras) ? "None" : extras)}";
        }
    }
}
