using HomeWorkNum8.Models;

namespace HomeWorkNum8.Factories;

public class AnimalFactory
{
    public static Animal CreateCat()
    {
        return new Animal("Cat", "Meow");
    }
    
    public static Animal CreateDog()
    {
        return new Animal("Dog", "Woof");
    }
    
    public static Animal CreateDuck()
    {
        return new Animal("Duck", "Quack");
    }
}