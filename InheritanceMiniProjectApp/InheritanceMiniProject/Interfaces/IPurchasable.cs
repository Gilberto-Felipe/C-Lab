using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMiniProject.Interfaces
{
    public interface IPurchasable : IInventory
    {
        void Purchase();
    }
}
