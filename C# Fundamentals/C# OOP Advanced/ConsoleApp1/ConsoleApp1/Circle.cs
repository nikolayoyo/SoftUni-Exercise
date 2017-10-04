using System;

public class Circle : IDrawable
{
    private double r;

    public Circle(double r)
    {
        this.r = r;
    }

    public void Draw()
    {
        double r_in = this.r - 0.4;
        double r_out = this.r + 0.4;

        for (double y = this.r; y >= -this.r; --y)
        {
            for (double x = -this.r; x < r_out; x+=0.5)
            {
                double value = x * x + y * y;
                if (value>=r_in*r_in && value<= r_out* r_out)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
}

