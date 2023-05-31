using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookLibrary.Models
{
    public class GuestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PeopleInParty { get; set; }
        public string MessageToHost { get; set; }
        public string GuestInfo
        {
            get { return $"First name: { FirstName } \nLast name: { LastName } \nNumber of people in the party: { PeopleInParty } \nMessage to the host: { MessageToHost}"; }
        }

    }
}
