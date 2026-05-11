using Domain.BaseEntity;
using Domain.Interfaces;
using Domain.Models;

#region Creating instances (objects)


Developer dev = new Developer("Bob", "Bobsky", 35, "+1 123 532 2343", new List<string> { "JavaScript", "C#", "C++" }, 5);

Tester tester = new Tester("Jill", "Wayne", 24, "+1 223 305 1234", 10);

Operations operations = new Operations("Greg", "Gregsky", 38, "+1 234 434 5353", ["Optimus", "ProtoBeat", "Abacus"]);

DevOps devOps = new DevOps("Jhon", "Doe", 29, "+1 123 123 1234", false, true);

QAEngineer qa = new QAEngineer("Steve", "Stevenson", 34, "+1 123 354 4323", ["Selenium", "Playwright"]);

//Person pesrson = new Person("Dimitar", "Kocevski", 19, "+1 123 345 9892");

Console.WriteLine(dev.GetInfo());

Console.WriteLine(tester.GetInfo());

Console.WriteLine(devOps.GetInfo());


#endregion

Console.ReadLine();

#region Testing methods

dev.Code();
dev.Greet("Buddy");

qa.Code();
qa.TestFeature("Log in");

devOps.Code();
Console.WriteLine(devOps.CheckInfrastructure(500) ? "Error occured!" : "Evrything is fine");

#endregion