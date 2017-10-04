using System;

public class Worker : Human
{
    private int hoursPerDay;
    private double weekSalary;

    public Worker(string firstName, string lastName, double weekSalary, int hoursPerDay)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.HoursPerDay = hoursPerDay;
        this.WeekSalary = weekSalary;
    }

    public override string LastName
    { get => base.LastName;
        set
        {
            if (value.Length<=3)
            {
                throw new ArgumentException("Expected length more than 3 symbols! Argument: lastName");
            }

            base.LastName = value;
        }
    }

    public double WeekSalary
    {
        get { return this.weekSalary; }
        set
        {
            if (value<10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }

            this.weekSalary = value;
        }
    }

    public int HoursPerDay
    {
        get { return this.hoursPerDay; }
        set
        {
            if (value<1 || value>12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }

            this.hoursPerDay = value;
        }
    }

    public double SalaryPerHour()
    {
        return weekSalary / (5.0 * hoursPerDay);
    }

    public override string ToString()
    {
        return base.ToString() + $"{Environment.NewLine}Week Salary: {this.weekSalary:f2}{Environment.NewLine}Hours per day: {this.hoursPerDay:f2}{Environment.NewLine}Salary per hour: {this.SalaryPerHour():f2}";
    }
}

