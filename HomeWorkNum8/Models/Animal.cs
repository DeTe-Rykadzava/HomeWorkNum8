namespace HomeWorkNum8.Models;

public class Animal
{
    public string Name { get; private set; }

    private string _sound;

    public Animal(string name, string sound)
    {
        Name = name;
        _sound = sound;
    }

    public string GetSound()
    {
        return _sound;
    }
}