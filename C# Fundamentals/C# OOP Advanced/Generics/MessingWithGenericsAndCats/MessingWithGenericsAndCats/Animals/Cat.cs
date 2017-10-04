using MessingWithGenericsAndCats.Animals.Basic;
using MessingWithGenericsAndCats.Animals.Interfaces;
using MessingWithGenericsAndCats.IOManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessingWithGenericsAndCats
{
    class Cat : Predator, ICat
    {
        public Cat(string name, int age, string color, string breed) : base(name, age, color, breed)
        {
        }

        public override void Wake()
        {
            base.Wake();
            this.Meow();
        }

        public void Meow()
        {
            OutputPrinter.PrintLine("Meow");
        }

        public void Roar()
        {
            OutputPrinter.PrintLine("Roar");
        }

        public override string ToString()
        {
            return base.ToString() + $"{Environment.NewLine}{this.Name}: \"Meow\"";
        }
    }
}
