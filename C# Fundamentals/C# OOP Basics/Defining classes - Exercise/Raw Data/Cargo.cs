class Cargo
{
    private int cargoSize;
    private string cargoType; 

    public Cargo(int cargoSize, string cargoType)
    {
        this.cargoType = cargoType;
        this.cargoSize = cargoSize;
    }

    public int CargoSize
    {
        get
        {
            return this.cargoSize;
        }
        set
        {
            this.cargoSize = value;
        }
    }

    public string CargoType
    {
        get
        {
            return this.cargoType;
        }
        set
        {
            this.cargoType = value;
        }
    }
}

