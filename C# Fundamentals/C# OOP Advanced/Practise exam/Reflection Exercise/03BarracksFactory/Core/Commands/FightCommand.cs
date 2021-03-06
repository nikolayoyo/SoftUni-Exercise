﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03BarracksFactory.Contracts;

namespace _03BarracksFactory.Core.Commands
{
    class FightCommand : Command
    {
        public FightCommand(string[] data, IRepository repository, IUnitFactory factory) : base(data, repository, factory)
        {
        }

        public override string Execute()
        {
            Environment.Exit(0);
            return string.Empty;
        }
    }
}
