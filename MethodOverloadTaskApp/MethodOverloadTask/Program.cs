using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = new EmployeeModel
            {
                FirstName = "Elon",
                LastName = "Musk",
                Email = "genius@elon.com",
            };

            employee.StartDate = employee.SetStartDate();
            Console.WriteLine(employee.StartDate);

            string stringDate = "2023-06-24 20:36:43";
            DateTime date = DateTime.ParseExact(stringDate, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            employee.StartDate = employee.SetStartDate(date);
            Console.WriteLine(employee.StartDate);

            string stringNextDate = "2023-06-30 20:36:43";
            DateTime nextDate = DateTime.ParseExact(stringNextDate, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            employee.StartDate = employee.SetStartDate(date, nextDate);
            Console.WriteLine(employee.StartDate);

            employee.StartDate = employee.SetStartDate(hasInitialDate: true, date, true, nextDate);
            Console.WriteLine(employee.StartDate);


            Console.ReadLine();
        }
    }
}
