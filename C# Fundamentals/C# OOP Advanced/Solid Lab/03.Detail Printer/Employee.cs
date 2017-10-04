namespace _03.Detail_Printer
{
    public class Employee : IPrintable
    {
        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }


        public virtual string GetInfo()
        {
            return this.Name;
        }
    }
}