﻿using System;

class Tire 
{
    private double presure;
    private int age;

    public Tire(double presure, int age)
    {
        this.presure = presure;
        this.age = age;
    }

    public double Presure
    {
        get
        {
            return this.presure;
        }
        set
        {
            this.presure = value;
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
}

