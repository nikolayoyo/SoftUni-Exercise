using System.Collections.Generic;
using System.Linq;

namespace MessingWithGenericsAndCats
{
    public class Shelter
    {
        private List<Animal> animals;

        public Shelter()
        {
            this.animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public IReadOnlyList<Animal> Animals
        {
            get => this.animals.OrderBy(a=> a.Age) as IReadOnlyList<Animal>;
        }
    }
}
