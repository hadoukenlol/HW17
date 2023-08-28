using HW17.Profiles;

namespace HW17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var profile1 = new Viewer();

            profile1.ViewMethod(new SalaryType());

            Console.WriteLine();

            var profile2 = new Viewer();
            profile2.ViewMethod(new StandartType());
        }
    }
}