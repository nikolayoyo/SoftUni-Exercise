using MessingWithGenericsAndCats.Constants;
using MessingWithGenericsAndCats.IOManager;
using System;
using System.Text;

namespace MessingWithGenericsAndCats.Manager
{ 
    public class ShelterManager
    {
        private Shelter shelter;

        public ShelterManager()
        {
            this.shelter = new Shelter();
        }

        public void AddAnimal(Animal animal)
        {
            if (animal == null)
            {
                throw new NullReferenceException();
            }

            this.shelter.AddAnimal(animal);
        }

        public void GetAllAnimals()
        {
            var builder = new StringBuilder();
            var counter = 1;
            foreach (var animal in shelter.Animals)
            {
                builder.AppendLine($"{counter}{animal.ToString()}");
                counter++;
            }
        }

        public void GetInfoForCurrentAnimal(int id)
        {
            if (1>id || id>this.shelter.Animals.Count)
            {
                throw new ArgumentException(ExceptionMessages.InvalidAnimalNumber);
            }

            this.shelter.Animals[id].ToString();
        }
    }
}
