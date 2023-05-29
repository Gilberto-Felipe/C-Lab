// Class Instantiation 

using InstantiatedClasses;

var person = new Person();

UserMessages.WelcomeUser();

Data.GetPersonalData(person);

UserMessages.PrintData(person);

UserMessages.Goodbye();
