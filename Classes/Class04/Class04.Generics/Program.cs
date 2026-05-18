
using Class04.Generics.Domain.Data;
using Class04.Generics.Domain.Models;
using Class04.Generics.Helpers;

List<int> numbers = new() { 1, 2, 4, 5 };
List<string> strings = ["str1", "str2", "str3"];
List<bool> bools = new List<bool>() { true, false, true };

//NonGenericListHelper nonGenericListHelper = new NonGenericListHelper();

//nonGenericListHelper.PrintStrings(strings);
//nonGenericListHelper.PrintInfoForStrings(strings);

//nonGenericListHelper.PrintIntegers(numbers);
//nonGenericListHelper.PrintInfoForIntegers(numbers);

//nonGenericListHelper.PrintBooleans(bools);
//nonGenericListHelper.PrintInfoForBools(bools);

//GenericListHe_per genericListHelper = new GenericListHe_per();
//GenericListHe_per.PrintItemsInfo(strings);
//genericListHelper.PrintItems(strings);

//genericListHelper.PrintItems<int>(numbers);
//GenericListHe_per.PrintItemsInfo<int>(numbers);

//genericListHelper.PrintItems<bool>(bools);
//GenericListHe_per.PrintItemsInfo<bool>(bools);


GenericDB<Order> OrdersDb = new GenericDB<Order>();
GenericDB<Product> ProductsDb = new GenericDB<Product>();

// Inserting Data

OrdersDb.Insert(new Order { Id = 1, Address = "Bob St.", Receiver = "Bob" });
OrdersDb.Insert(new Order { Id = 2, Address = "John St.", Receiver = "John" });
OrdersDb.Insert(new Order { Id = 3, Address = "Jane St.", Receiver = "Jane" });

ProductsDb.Insert(new Product { Id = 1, Title = "Mouse", Description = "Wireless mouse"});
ProductsDb.Insert(new Product { Id = 2, Title = "USB", Description = "64MB"});

Console.ReadLine();

OrdersDb.PrintAll();
ProductsDb.PrintAll();