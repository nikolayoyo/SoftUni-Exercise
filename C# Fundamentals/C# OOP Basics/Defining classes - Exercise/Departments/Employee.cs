using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departments
{
    class Employee
    {
        private string name;
        private double salary;
        private string position;
        private string department;
        private string mandory;
        private int age;
        private string email;

        public Employee(string name, double salary, string position, string department, string email, int age)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.email = email;
            this.age = age;
        }

        public Employee(string name, double salary, string position , string department)
            : this(name, salary,position, department ,"n/a", -1)
        {
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public double Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                this.salary = value;
            }
        }

        public string Position
        {
            get
            {
                return this.position;
            }
            set
            {
                this.position = value;
            }
        }

        public string Department
        {
            get
            {
                return this.department;
            }
            set
            {
                this.department = value;
            }
        }

        public string Mandory
        {
            get
            {
                return this.mandory;
            }
            set
            {
                this.mandory = value;
            }
        }
    }
}
