using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HW17.Profiles
{
    internal class StandartType : IProfile
    {

        public void CalculateInterest()
        {
            Console.WriteLine("Реализация стандартного счёта");
            Account account = new Account();
            account.Interest = account.Balance * 0.4;
            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;

            if (account.Balance >= 1000)
                account.Interest -= account.Balance * 0.4;
        }
    }
}
