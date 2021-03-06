﻿using System;

public class Human
{
    private string firstName;
    private string lastName;

    public virtual string LastName
    {
        get { return this.lastName; }
        set
        {
            if (char.IsLower(value[0]))
            {
                throw new Exception("Expected upper case letter! Argument: lastName");
            }

            if (value.Length<3)
            {
                throw new Exception("Expected length at least 3 symbols! Argument: lastName ");
            }

            this.lastName = value;
        }
    }

    public string FirstName
    {
        get { return this.firstName; }
        set
        {
            if (char.IsLower(value[0]))
            {
                throw new Exception("Expected upper case letter!Argument: firstName");
            }

            if (value.Length < 4)
            {
                throw new Exception("Expected length at least 4 symbols! Argument: firstName");
            }

            this.firstName = value;
        }
    }

    public override string ToString()
    {
        return $"First Name: {this.firstName}{Environment.NewLine}Last Name: {this.lastName}";
    }
}

