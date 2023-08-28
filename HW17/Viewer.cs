using HW17.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW17
{
    public class Viewer
    {
        public void ViewMethod(IProfile calc)
        {
            calc.CalculateInterest();
        }
    }
}
