using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW17.Profiles
{
    public class SalaryType : IProfile
    {
        public void CalculateInterest()
        {
            Console.WriteLine("Реализация зарплатного счёта");
            Account account = new Account();
            account.Interest = account.Balance * 0.5;
        }
    }
}
