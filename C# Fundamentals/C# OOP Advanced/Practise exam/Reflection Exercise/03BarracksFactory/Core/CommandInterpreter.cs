using _03BarracksFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Globalization;

namespace _03BarracksFactory.Core
{
    class CommandInterpreter : ICommandInterpreter
    {
        private const string CommandPrefix = "command";
        private IUnitFactory factory;
        private IRepository repository;
        

        public CommandInterpreter(IRepository repository, IUnitFactory factory)
        {
            this.factory = factory;
            this.repository = repository;
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            var finalCmdLook = commandName.ToLower() + CommandPrefix;


            var command = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(f => f.Name.ToLower().Equals(finalCmdLook));

            object[] parameters =
            {
                data[1],
                this.repository,
                this.factory
            };

            var ctor = command.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, null, null);

            return (IExecutable)ctor.Invoke(parameters);
        }
    }
}
