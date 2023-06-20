using InheritanceMiniProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMiniProject.Models
{
    public class Soda : Inventory, IPurchasable
    {
        public string Brand { get; set; }
        public string Presentation { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            Console.WriteLine("A soda was purchased");
        }
    }
}
