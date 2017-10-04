﻿using System;

public class Student : Human
{
    private string facultyNumber;

    public Student(string firstName, string  lastName, string facNum)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.FacultyNumber = facNum;
    }

    public string FacultyNumber
    {
        get { return this.facultyNumber; }
        set
        {
            if (value.Length<5 || value.Length>10)
            {
                throw new ArgumentException("Invalid faculty number!");
            }

            this.facultyNumber = value;
        }
    }

    public override string ToString()
    {
        return base.ToString() + $"{Environment.NewLine}Faculty number: {this.facultyNumber}";
    }

}

