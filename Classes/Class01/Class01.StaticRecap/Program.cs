

using Class01.StaticRecap;

HelloWorld();
void HelloWorld()
{
    Console.WriteLine("Hello World");
}

var mario = new Developer("Mario", "Rossi", 30);
Console.WriteLine(mario.GetNumberOfDeveloper());
Console.WriteLine(Developer.NumberOfDevelopers);
Developer.ResetNumberOfDevelopers();
Console.WriteLine(Developer.NumberOfDevelopers);


Console.ReadLine();