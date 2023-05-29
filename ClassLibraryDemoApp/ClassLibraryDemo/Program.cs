using DataLibrary;

Console.WriteLine("Hello, World!");

var person = new PersonModel();

person.FirstName = "Test";
person.LastName = "Library";

Console.WriteLine($"{person.FullName}");
