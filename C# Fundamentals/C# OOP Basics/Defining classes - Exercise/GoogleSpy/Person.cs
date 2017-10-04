using System;
using System.Collections.Generic;
using System.Text;

public class Person
  {
     private string name;
    private Car car;
    private Company company;
    private List<Parent> parents;
    private List<Parent> children;
    private List<Pokemon> pokemons;

    public Person(string name)
    {
        this.name = name;
        this.parents= new List<Parent>();
        this.children = new List<Parent>();
        this.pokemons = new List<Pokemon>();
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Company Company
    {
        get { return company; }
        set { company = value; }
    }

    public Car Car
    {
        get { return car; }
        set { car = value; }
    }
    
    public List<Parent> Parents
    {
        get { return parents; }
        set { parents = value; }
    }

    public List<Parent> Childrens
    {
        get { return children; }
        set { children = value; }
    }

    public List<Pokemon> Pokemons
    {
        get { return pokemons; }
        set { pokemons = value; }
    }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append($"{this.name}");
        stringBuilder.Append($"{Environment.NewLine}Company:");
        if (this.company!=null)
        {
            stringBuilder.Append($"{Environment.NewLine}{this.company.Name} {this.company.Department} {this.company.Salary:F2}");
        }

        stringBuilder.Append($"{Environment.NewLine}Car:");
        if (car!=null)
        {
            stringBuilder.Append($"{Environment.NewLine}{this.car.Model} {this.car.Speed}");
        }
       
        stringBuilder.Append($"{Environment.NewLine}Pokemon:{Environment.NewLine}{string.Join(Environment.NewLine, this.pokemons)}" +
            $"{Environment.NewLine}Parents:{Environment.NewLine}{string.Join(Environment.NewLine, this.parents)}" +
            $"{Environment.NewLine}Children:{Environment.NewLine}{string.Join(Environment.NewLine, this.children)}");


        return stringBuilder.ToString();
    }

}

