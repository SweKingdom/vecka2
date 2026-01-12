namespace Vecka2.Models;

public class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("The dog is eating!");
    }
    
    public void Bark()
    {
        Console.WriteLine("The dog is barking!");
    }
}