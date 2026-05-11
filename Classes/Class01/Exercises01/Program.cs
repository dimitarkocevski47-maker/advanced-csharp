//1.Create a console application that detect provided names in a provided text 🔹
//The application should ask for names to be entered until the user enteres x
//After that the application should ask for a text
//When that is done the application should show how many times that name was included in the text ignoring upper/lower case

using System.Xml.Linq;

List<string> names = new List<string>();

while (true)
{
    Console.WriteLine("Enter a name (or x to stop): ");
    string input = Console.ReadLine();
    if (input.ToLower() == "x")
    {
        break;
    }
        names.Add(input);
}

Console.WriteLine("Enter text");
string text = Console.ReadLine();

string[] words = text.Split(' ');

Console.WriteLine("========== Results ==========");
foreach (var name in names)
{
    int count = 0;
    foreach (var word in words)
    {
       
        if (name.ToLower() == word.ToLower())
        {
            count++;
        }
        Console.WriteLine($"{name} is found {count} times");
    }
   
}

Console.ReadLine();