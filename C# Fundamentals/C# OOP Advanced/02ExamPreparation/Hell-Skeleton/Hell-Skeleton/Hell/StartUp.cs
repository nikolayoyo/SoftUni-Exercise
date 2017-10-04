public class StartUp
{
    public static void Main()
    {
        IInputReader reader = new InputReader();
        IOutputWriter writer = new OutputWriter();
        HeroManager manager = new HeroManager();

        Engine engine = new Engine(reader, writer, manager);
        engine.Run();
    }
}