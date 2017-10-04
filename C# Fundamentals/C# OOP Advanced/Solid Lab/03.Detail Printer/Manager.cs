using System;

namespace _03.Detail_Printer
{
    using System.Collections.Generic;

    public class Manager : Employee
    {
        public Manager(string name, ICollection<string> documents) : base(name)
        {
            this.Documents = new List<string>(documents);
        }

        public IReadOnlyCollection<string> Documents { get; set; }

        public override string GetInfo()
        {
            return base.GetInfo() + Environment.NewLine + string.Join(Environment.NewLine, Documents);
        }
    }
}
