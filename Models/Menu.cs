using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_BurgerAdam
{
   public class Menu
    {
        public int Quantity { get; set; }
        public MenuType MenuType { get; set; }
        public Size Size { get; set; }
        public List<Extra> Extras { get; set; } // normalde bu gibi listeleri foregin key ile tutarız fakat veri tabanı işlemleri yapmadıgımız için iç içe verileri tuttuk. 
        public decimal Price { get; set; }



       public void CalculateMenuPrice()
        {
            Price = MenuType.Price;
            foreach (var extra in Extras)
            {
                Price += extra.Price;
            }
            switch (Size)
            {
                case Size.Orta: break;
                case Size.Büyük: Price += 2; break;
                case Size.King: Price += 3; break;
            }
            Price *= Quantity;
        }


        public override string ToString()
        {
            string extras = "";
            foreach (var item in Extras)
            {
                extras += item.Name + " ";
            }
            return $"{MenuType},{Size},{extras} Fiyat : {Price} Adet : {Quantity}";
        }
    }



   public enum Size
    {
        Orta = 0,
        Büyük,
        King
    }
}
