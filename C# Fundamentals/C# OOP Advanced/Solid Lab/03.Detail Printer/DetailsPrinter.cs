namespace _03.Detail_Printer
{
    using System;
    using System.Collections.Generic;

    public class DetailsPrinter
    {
        private IList<IPrintable> employees;

        public DetailsPrinter(IList<IPrintable> employees)
        {
            this.employees = employees;
        }

        public void printDetails()
        {
            foreach (IPrintable employee in this.employees)
            {
                Console.WriteLine(employee.GetInfo());      
            }
        }
    }
}