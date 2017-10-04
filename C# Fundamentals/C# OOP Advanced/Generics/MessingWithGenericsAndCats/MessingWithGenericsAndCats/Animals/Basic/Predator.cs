namespace MessingWithGenericsAndCats.Animals.Basic
{
    public class Predator : Animal
    {
        public Predator(string name, int age, string color, string breed) : base(name, age, color, breed, FoodPreference.Meat)
        {
        }
    }
}
