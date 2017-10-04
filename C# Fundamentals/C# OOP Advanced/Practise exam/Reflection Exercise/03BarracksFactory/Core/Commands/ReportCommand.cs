using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03BarracksFactory.Contracts;

namespace _03BarracksFactory.Core.Commands
{
    class ReportCommand : Command
    {
        public ReportCommand(string[] data, IRepository repository, IUnitFactory factory) : base(data, repository, factory)
        {
        }

        public override string Execute()
        {
            string output = this.Repository.Statistics;
            return output;
        }
    }
}
