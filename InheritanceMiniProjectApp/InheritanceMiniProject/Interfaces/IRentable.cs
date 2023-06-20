using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMiniProject.Interfaces
{
    public interface IRentable : IInventory
    {
        void Rent();
        void Return();
    }
}
