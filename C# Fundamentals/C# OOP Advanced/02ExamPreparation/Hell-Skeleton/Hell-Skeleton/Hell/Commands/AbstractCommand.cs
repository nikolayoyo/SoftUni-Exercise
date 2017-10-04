using System.Collections.Generic;


public abstract class AbstractCommand
    {
        private IList<string> args;
        private IManager manager;

        protected AbstractCommand(IList<string> args, IManager manager)
        {
            this.args = args;
            this.manager = manager;
        }
        
        protected IManager Manager
        {
            get => this.manager;
        }

        protected IList<string> ArgsList
        {
            get => this.args;
        }

        public abstract string Execute();
    }
