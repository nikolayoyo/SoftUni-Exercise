using MessingWithGenericsAndCats.Animals.Basic;
using MessingWithGenericsAndCats.Constants;
using MessingWithGenericsAndCats.IOManager;
using System;
using System.Text;

namespace MessingWithGenericsAndCats
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private FoodPreference foodPreference;
        private string color;
        private string breed;
        private bool sleep;

        protected Animal(string name, int age, string color, string breed,FoodPreference preference)
        {
            this.Name = name;
            this.Age = age;
            this.color = color;
            this.foodPreference = preference;
        }

        public string Breed
        {
            get => this.breed;
            private set
            {
                if (value.Length<3)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidBreed);
                }
            }
        }

        public bool Sleep
        {
            get=> this.sleep;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (value.Length<3)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidNameLenght);
                }

                this.name = value;
            }
        }

        public int Age
        {
            get => this.age;
            private set
            {
                if (value<0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidAge);
                }

                this.age = value;
            }
        }

        public virtual void GoToSleep()
        {
            this.sleep = true;
            OutputPrinter.PrintLine($"{this.name} fall asleep.");
        }

        public virtual void Wake()
        {
            this.sleep = false;
            OutputPrinter.PrintLine($"{this.name} woke up.");
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"{this.Name}: {this.GetType().ToString()} - {this.breed}, {this.Age} years old.");
            return builder.ToString();
        }
    }
}
