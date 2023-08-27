using HW17.Profiles;

namespace HW17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account profile1 = new Account();
            profile1.Balance = 50;
            profile1.AccountType(new SalaryType());
        }
    }
}