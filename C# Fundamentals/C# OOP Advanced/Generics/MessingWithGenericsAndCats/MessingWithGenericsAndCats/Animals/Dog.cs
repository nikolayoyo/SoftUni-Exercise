using System;
using MessingWithGenericsAndCats.Animals.Basic;
using MessingWithGenericsAndCats.Animals.Interfaces;
using MessingWithGenericsAndCats.IOManager;

namespace MessingWithGenericsAndCats
{
    public class Dog : Predator , IDog
    {


        public Dog(string name, int age, string color, string breed) : base(name, age, color,breed)
        {
        }

        public override void Wake()
        {
            base.Wake();
            this.Bark();
        }

        public void Bark()
        {
            OutputPrinter.PrintLine("Bark bark bitch");
        }

        public void Fetch<T>(T thingToBring)
        {
            OutputPrinter.PrintLine($"{this.Name} brought {thingToBring.GetType().ToString()}");
        }
        public override string ToString()
        {
            return base.ToString() + $"{Environment.NewLine}{this.Name}: \"Bark\"";
        }
    }
}
