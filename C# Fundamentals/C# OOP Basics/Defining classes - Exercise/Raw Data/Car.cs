
using System.Collections.Generic;
using System.Linq;

class Car
{
    private string model;
    private List<Tire> tires;
    private Engine engine;
    private Cargo cargo;

    public Car(string model,
        int engineSpeed, int enginePower, 
        int cargoWeight, string cargoType,
        double tire1Pressure, int tire1Age, 
        double tire2Pressure, int tire2Age,
        double tire3Pressure, int tire3Age, 
        double tire4Pressure, int tire4Age)
    {
        this.model = model;
        this.engine = new Engine(engineSpeed, enginePower);
        this.cargo = new Cargo(cargoWeight, cargoType);
        this.tires = new List<Tire>()
        {
            new Tire(tire1Pressure, tire1Age),
            new Tire(tire2Pressure, tire2Age),
            new Tire(tire3Pressure, tire3Age),
            new Tire(tire4Pressure, tire4Age),

        };

    }

    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            this.model = value;
        }
    }
    
    public List<Tire> Tires
    {
        get
        {
            return this.tires;
        }
        set
        {
            this.tires = value;
        }
    }

    public Cargo Cargo
    {
        get
        {
            return this.cargo;
        }
        set
        {
            this.cargo = value;
        }
    }

    public Engine Engine
    {
        get
        {
            return this.engine;
        }
        set
        {
            this.engine = value;
        }
    }
}

