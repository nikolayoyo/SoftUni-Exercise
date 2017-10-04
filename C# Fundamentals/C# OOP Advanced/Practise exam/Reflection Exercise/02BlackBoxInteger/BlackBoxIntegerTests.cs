namespace _02BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    class BlackBoxIntegerTests
    {
        static void Main(string[] args)
        {
            var type = typeof(BlackBoxInt);
            var ctor = type.GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[0], null);

            var inst = (BlackBoxInt)ctor.Invoke(null);
            
            string cmdInput;

            while ((cmdInput = Console.ReadLine()) != "END")
            {
                var name = cmdInput.Split('_')[0];
                object[] value = { int.Parse(cmdInput.Split('_')[1]) };

                var method = type.GetMethod(name, BindingFlags.NonPublic | BindingFlags.Instance);

                method.Invoke(inst,value);

                Console.WriteLine(type.GetField("innerValue", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(inst));
            }
        }
    }
}
