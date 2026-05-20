
using AnonymousMethods.Models;
#region Func
List<string> names = ["Alice", "Bob", "Charlie", "John", "Anna"];
List<string> empty = [];

// ===> One line lambda expression
string johnName = names.Find(name => name == "John");

string john2Name = names.Find(name =>
{
    if (name == "John")
    {
        return true;
    }
    return false;
});

// ===> Example of a Func with 2 parameters
Func<int, int, int> sum = (num1, num2) => num1 + num2;
int sumResult = sum(10, 20);
Console.WriteLine(sumResult);

Console.ReadLine();


// ===> Example of a Func with no parameters
Func<bool> isNamesEmpty = () => names.Count == 0;
Console.WriteLine("Is list empty " + isNamesEmpty());

Console.ReadLine();

// ===> Example of a Func with no parameters
Func<List<string>, bool> isListEmpty = list => list.Count == 0;
Console.WriteLine("The list name is " + isListEmpty(names));
Console.WriteLine("The list empty is " + isListEmpty(empty));

Console.ReadLine();

Func<int, int, bool> isLarger = (num1, num2) =>
{
    if (num1 > num2)
    {
        return true;
    }
    return false;
};

// ===> Example of a Func with 4 parameters
Func<int, string, double, bool, string> getUserInfo = (id, name, salary, isActive) =>
{
    return $"ID {id}, Name: {name}, Salary: {salary}, Is Active: {(isActive ? "Yes" : "No")}";
};

string userInfo = getUserInfo(1, "Bob", 3444.44, true);
Console.WriteLine(userInfo);

Console.ReadLine();

// ===> Example of a Func that uses class as type
Func<Person, string> getPersonName = person =>
{
    return person.Name;
};

Person bob = new Person { Name = "Bob" };
Console.WriteLine(getPersonName(bob));

Console.ReadLine();


#endregion


#region Action

Console.WriteLine("==========Action==========");

//Func<void> printHello = () => Console.WriteLine("Hello");
Action printHello = () => Console.WriteLine("Hello");
printHello();

Console.ReadLine();

Action<string> printRed = word =>
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(word);
    Console.ResetColor();
};

printRed("Something went wrong!");

Console.ReadLine();

Action<string, ConsoleColor> printInColor = (text, color) =>
{
    Console.ForegroundColor = color;
    Console.WriteLine(text);
    Console.ResetColor();
};

printInColor("This is blue text", ConsoleColor.Blue);
printInColor("This is green text", ConsoleColor.Green);

Console.ReadLine();
#endregion

#region Predicate
Console.WriteLine("==========Predicate==========");

Predicate<Person> isActive = person => person.IsActive;
Person dimitar = new();
Console.WriteLine(isActive(dimitar));

Console.ReadLine();
#endregion

printInColor("========== Func & Action with hof and LINQ", ConsoleColor.DarkMagenta);

string foundBob = names.Find(n => n == "Bob");

Predicate<string> isJill = n => n == "Jill";

string foundJill = names.Find(isJill);

Console.ReadLine();

Func<string, bool> namesStartsWithJ = n => n.StartsWith('J');
IEnumerable<string> namesWithJ = names.Where(namesStartsWithJ).ToList();