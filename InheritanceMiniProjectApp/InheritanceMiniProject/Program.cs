using InheritanceMiniProject.Interfaces;
using InheritanceMiniProject.Models;
using System;
using System.Collections.Generic;

namespace InheritanceMiniProject
{
    public class Program
    {
        static void Main()
        {
            var rents = new List<IRentable>();
            var sales = new List<IPurchasable>();

            var auto = new Auto()
            {
                ProductName = "Jetta 2023",
                DealerFee = 25,
                QuantityInStock = 100,
            };

            var bus = new Buss()
            {
                TravelDate = DateTime.Now,
                NumberSits = 40,
                ProductName = "Bus Mercedez Benz 2020",

            };

            var soda = new Soda()
            {
                ProductName = "Soda",
                Brand = "Mirinda",
                Presentation = "Can 250 ml"
            };

            rents.Add(auto);
            rents.Add(bus);
            rents.Add(new Auto { ProductName = "Kia Optima", DealerFee = 25, QuantityInStock = 100 });

            sales.Add(soda);
            sales.Add(new Soda { ProductName = "Soda",
                Brand = "Pepsi",
                Presentation = "Can 250 ml"
            });


            Console.WriteLine("Welcome to my Vehicle Agency");

            Console.WriteLine("Our products include: Autos, Busses, and Sodas");

            Console.WriteLine("Do you want to rent or buy something: (type rent or buy)");

            var decision = Console.ReadLine();

            if (decision.ToLower() == "rent")
            {
                foreach (var item in rents)
                {
                    Console.WriteLine(item.ProductName);
                    Console.WriteLine("Do you want to rent it? (type yes or no)");
                    decision = Console.ReadLine();

                    if (decision.ToLower() == "yes")
                    {
                        item.Rent();
                    }
                }

                Console.WriteLine("Do you want to return an item? (type yes or no)");
                decision = Console.ReadLine();

                if (decision.ToLower() == "yes")
                {
                    foreach (var item in rents)
                    {
                        Console.WriteLine(item.ProductName);
                        Console.WriteLine("Do you want to return it? (type yes or no)");
                        decision = Console.ReadLine();

                        if (decision.ToLower() == "yes")
                        {
                            item.Return();
                        }
                    }
                }
            }
            else
            {
                foreach (var item in sales)
                {
                    Console.WriteLine($"{item.ProductName}");
                    Console.WriteLine("Do you want to purchase it? (type yes or no)");
                    decision = Console.ReadLine();

                    if (decision.ToLower() == "yes")
                    {
                        item.Purchase();
                    }
                }
            }

            Console.WriteLine("Thank you for your visit.");
            Console.WriteLine("Good bye!");

            Console.ReadLine();
        }
    }
}
