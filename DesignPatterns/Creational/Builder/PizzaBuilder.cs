using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class PizzaBuilder
    {
        internal string Size { get; private set; } = "Medium";
        internal string Dough { get; private set; } = "Traditional";
        internal bool HasCheese { get; private set; }
        internal bool HasPepperoni { get; private set; }
        internal bool HasMushrooms { get; private set; }  

        public PizzaBuilder WithSize(string size)
        {
            Size = size;
            return this;
        }

        public PizzaBuilder WithDough(string dough)
        {
            Dough = dough;
            return this;
        }

        public PizzaBuilder AddCheese()
        {
            HasCheese = true;
            return this;
        }

        public PizzaBuilder AddPepperoni()
        {
            HasPepperoni = true;
            return this;
        }

        public PizzaBuilder AddMushtooms()
        {
            HasMushrooms = true;
            return this;
        }

        public Pizza Build()
        {
            if (string.IsNullOrEmpty(Size))
                throw new InvalidOperationException("The Pizza should have size.");

            return new Pizza(this);
        }
    }
}
