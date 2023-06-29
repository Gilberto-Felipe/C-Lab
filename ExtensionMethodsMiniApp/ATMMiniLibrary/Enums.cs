using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMiniLibrary
{
    public class Enums
    {
        public enum Transaction
        {
            CheckBalance,
            WithdrawMoney,
            MakeDeposit,
            Exit
        }
    }
}
