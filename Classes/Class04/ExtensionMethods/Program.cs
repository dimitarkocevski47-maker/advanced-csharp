
using ExtensionMethods.Helpers;
using ExtensionMethods.Helpers.Piggybacking;
using ExtensionMethods.Models;

List<int> numbers = new() { 1, 2, 4, 5 };
List<string> strings = ["str1", "str2", "str3"];

//ListHelpers.PrintItems<int>(numbers);
//ListHelpers.PrintItems(strings);
numbers.PrintItems();
strings.PrintItems();

Console.ReadLine();

numbers.PrintListInfo();
strings.PrintListInfo();

Console.ReadLine();

string bobLong = "Bob Bobsky";
string bobShorten = bobLong.Truncate(3);
Console.WriteLine(bobShorten);
Console.WriteLine("Bob Bobsky".Truncate(5));

Product product = new Product
{
    Id = 1,
    Description = "Product Description",
    Title = "Product Title"
};
product.PrintInfo