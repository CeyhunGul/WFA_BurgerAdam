using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_BurgerAdam
{
    public class MenuType : MenuItem
    {
        public override string ToString()
        {
            return Name + " " + Price.ToString("C2");
        }
    }
}
