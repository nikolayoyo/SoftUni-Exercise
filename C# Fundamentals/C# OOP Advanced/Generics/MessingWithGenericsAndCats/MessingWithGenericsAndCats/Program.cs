namespace MessingWithGenericsAndCats
{
    using MessingWithGenericsAndCats.IOManager;
    using MessingWithGenericsAndCats.Manager;

    public class Program
    {
        public static void Main(string[] args)
        {
            var manager = new ShelterManager();
            var someDog = new Dog("Pesho", 20, "Black", "German Sheepard");
            var misho = new Dog("Misho", 10, "Red", "German Gay");
            var steven = new Dog("steven", 4, "Pink", "Pincher");
            try
            {
               
                var someCat = new Cat("Pyuseee", -21, "Black", "No luck Cat");

                manager.AddAnimal(someDog);
                manager.AddAnimal(misho);
                manager.AddAnimal(steven);
            }
            catch (System.ArgumentException ex)
            {

                OutputPrinter.PrintLine(ex.Message);
            }


            manager.GetAllAnimals();
        }
    }
}
