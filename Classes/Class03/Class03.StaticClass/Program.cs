
using Class03.StaticClass;
using Class03.StaticClass.Helpers;

//ConsoleHelper consoleHelper = new ConsoleHelper();
ConsoleHelper.WriteInColor("====== Welcome to Order Managment System ======", ConsoleColor.Blue);

Console.WriteLine(OrdersStaticDB.Users.Count);