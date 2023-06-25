using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadTask
{
    internal class EmployeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime SetStartDate()
        {
            return SetStartDate(true, DateTime.Now, false, DateTime.Now.AddDays(7));
        }

        public DateTime SetStartDate(DateTime date)
        {
            return SetStartDate(true, date, false, DateTime.Now.AddDays(7));
        }

        public DateTime SetStartDate(DateTime date, DateTime nextDate)
        {
            return SetStartDate(true, date, true, nextDate);
        }

        public DateTime SetStartDate(bool hasInitialDate, DateTime date, bool hasNextDate, DateTime nextDate)
        {
            if (hasInitialDate == false)
            { 
                return StartDate = DateTime.MinValue;
            }

            if (hasInitialDate && hasNextDate)
            {
                return StartDate = date > nextDate ? date : nextDate;
            }

            return StartDate = date;
        }
    }
}
