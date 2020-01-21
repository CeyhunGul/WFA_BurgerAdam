using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_BurgerAdam.Models
{
  public class OrderInfo
    {
        public decimal Giro { get; set; }
        public int TotalOrderCount { get; set; }
        public decimal TotalPriceOfExtraMaterial{ get; set; }
        public int SoldMenuCount { get; set; }
    }
}
