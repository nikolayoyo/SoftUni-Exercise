using System;

public class Tesla : Vehicle, IElectricCar
{
    private int batteries;

    public Tesla(string model, string color, int batteries): base(model,color)
    {
       
        this.batteries = batteries;
    }
    public int Battery => this.batteries;

    public override string ToString()
    {
        return base.ToString() + $" with {this.batteries} Batteries";
    }
}

