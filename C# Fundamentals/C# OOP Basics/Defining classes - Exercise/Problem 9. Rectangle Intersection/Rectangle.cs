using System.Linq;

class Rectangle
    {
    public Rectangle(string id, double width, double height, double firstCoordinate, double secondCoordinate)
    {
        this.id = id;
        this.height = height;
        this.width = width;
        this.coordinates = new double[2] { firstCoordinate, secondCoordinate };
    }

    private string id;

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    private double width;

    public double Width
    {
        get { return width; }
        set { width = value; }
    }

    private double height;

    public double Height
    {
        get { return height; }
        set { height = value; }
    }

    private double[] coordinates;

    public double[] Coordinates
    {
        get { return coordinates; }
        set { coordinates = value; }
    }

    public bool ComparedTo(Rectangle secondOne)
    {
        if (this.height == secondOne.height
            && this.width == secondOne.width
            && this.coordinates[0] == secondOne.coordinates[0]
            && this.coordinates[1] == secondOne.coordinates[1])
        {
            return true;
        }

        return false;
    }
}

