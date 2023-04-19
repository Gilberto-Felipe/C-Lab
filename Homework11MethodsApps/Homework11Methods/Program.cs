// Homework 11 Methods 

// Create Console App

// Tasks
/// Welcome method
/// Method to ask for user's name
/// Method to say "Hello {name}"
/// Llamar estos metodos desde Program.cs
/// 

using Homework11Methods;

ConsoleMessages.Welcome();

(string firstName, string lastName) = ConsoleMessages.AskName();

ConsoleMessages.SayHello(firstName, lastName);
