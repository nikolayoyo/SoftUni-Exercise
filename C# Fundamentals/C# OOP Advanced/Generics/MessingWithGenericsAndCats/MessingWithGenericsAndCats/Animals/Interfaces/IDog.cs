namespace MessingWithGenericsAndCats.Animals.Interfaces
{
    public interface IDog
    {
        void Bark();

        void Fetch<T>(T thingToBring);
    }
}
