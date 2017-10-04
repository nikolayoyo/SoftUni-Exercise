namespace _03BarracksFactory.Core.Factories
{
    using System;
    using Contracts;
    using System.Reflection;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            var unitInfo = Type.GetType($"_03BarracksFactory.Models.Units.{unitType}");

            var ctor = unitInfo.GetConstructor(BindingFlags.NonPublic| BindingFlags.Public | BindingFlags.Instance, null, new Type[0], null);

            return (IUnit)ctor.Invoke(null);
        }
    }
}
