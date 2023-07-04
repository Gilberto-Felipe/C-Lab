using GenericsEventsProject.DataAccess;
using GenericsEventsProject.Models;
using System;
using System.Collections.Generic;

namespace GenericsEventsProject
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> personas = new List<PersonModel>()
            {
                new PersonModel { Id = "1", Name = "JuanShit", Email = "juanDoe@gmail.com" },
                new PersonModel { Id = "2", Name = "Masha", Email = "MashaP@yandex.com" },
                new PersonModel { Id = "3", Name = "Takita", Email = "takita@anime.com" },
            };

            List<LaptopModel> laptops = new List<LaptopModel>()
            {
                new LaptopModel { Manufacturer = "Toshiba", Model = "Satellite U940" },
                new LaptopModel { Manufacturer = "DellHeck", Model = "Dell Inspiron 5050" },
            };

            var personasData = new DataAccess<PersonModel>();
            var laptopsData = new DataAccess<LaptopModel>();

            personasData.BadWordFound += PersonasData_BadWordFound;
            laptopsData.BadWordFound += LaptopsData_BadWordFound;

            string filePath = @"C:\Users\gilbertor\AppData\Local\Temp\PersonasCSV.csv";
            personasData.SaveToCSV(personas, filePath);

            filePath = @"C:\Users\gilbertor\AppData\Local\Temp\LaptopsCSV.csv";
            laptopsData.SaveToCSV(laptops, filePath);

            Console.ReadLine();
        }

        private static void LaptopsData_BadWordFound(object sender, LaptopModel e)
        {
            Console.WriteLine($"The record of Manufacturer {e.Manufacturer} Model {e.Model} has badwords, and was not processed.");
        }

        private static void PersonasData_BadWordFound(object sender, PersonModel e)
        {
            Console.WriteLine($"The record Id {e.Id} Name {e.Name} Email {e.Email} has badwords, and was not processed.");
        }
    }
}
