class Box
{
    private double lenght;
    private double width;
    private double height;
   
    public Box(double a, double b, double c)
    {
        this.lenght = a;
        this.width = b;
        this.height = c;
    }

    public double Surface()
    {
        return 2 * lenght * width + 2 * width * height + 2 * lenght * height;
    }

    public double Volume()
    {
        return lenght * width * height;
    }

    public double Lateral()
    {
        return 2 * this.lenght * this.height + 2 * this.width * this.height;
    }
}

