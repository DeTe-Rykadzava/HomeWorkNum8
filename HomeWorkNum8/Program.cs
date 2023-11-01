// See https://aka.ms/new-console-template for more information

using HomeWorkNum8.Core;
using HomeWorkNum8.Factories;
using HomeWorkNum8.Models;

var animals = new List<Animal>
{
    AnimalFactory.CreateCat(),
    AnimalFactory.CreateDog(),
    AnimalFactory.CreateDuck()
};

// show all animals
Console.WriteLine("==================================");
Console.WriteLine("\tДоступные животные:");
for (int i = 0; i < animals.Count; i++)
{
    Console.WriteLine($"\t{i+1}:\t{animals[i].Name}");
}
Console.WriteLine("==================================");
// get animal num
int animalNumber;
while (true)
{
    animalNumber = (int)ConsoleReaderManager.GetUserInput("  Укажите номер животного", UserInputType.Int);
    if (animalNumber <= 0 || animalNumber > animals.Count)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Вы ввели не верный нормер животного. Попробуйте снова!");
        Console.ForegroundColor = ConsoleColor.White;
        continue;
    }

    animalNumber--;
    break;
}
Console.WriteLine($"\tВы выбрали {animalNumber+1} - {animals[animalNumber].Name}");
Console.WriteLine("==================================");
Console.WriteLine($"\t{animals[animalNumber].Name}:\t{animals[animalNumber].GetSound()}");
Console.WriteLine("==================================");
