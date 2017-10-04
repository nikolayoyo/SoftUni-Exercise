using System;

public class Robot : IIdiable
{
    private string id;
    private string mode;

    public Robot(string model,string id)
    {
        this.id = id;
        this.mode = model;
    }
    public string Id => this.id;
}

