namespace Vecka2.Models;

public class Car
{
    public Engine Engine { get; set; }

    public Car()
    {
        Engine = new Engine();
    }
}