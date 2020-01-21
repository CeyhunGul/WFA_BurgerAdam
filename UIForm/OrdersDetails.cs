using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_BurgerAdam.Models;

namespace WFA_BurgerAdam.UIForm
{
    public partial class OrdersDetails : Form
    {
        public OrdersDetails()
        {
            InitializeComponent();
        }

        private void OrdersDetails_Load(object sender, EventArgs e)
        {
            OrderInfo orderInfo = new OrderInfo();

            foreach (var menu in Form1.Orders)
            {
                listBox1.Items.Add(menu);
                orderInfo.Giro += menu.Price;
                orderInfo.SoldMenuCount += menu.Quantity;
                foreach (var item in menu.Extras)
                {
                    orderInfo.TotalPriceOfExtraMaterial += item.Price;
                }
            }
            orderInfo.TotalOrderCount = listBox1.Items.Count;
            ShowOrderDetails(orderInfo);
        }


        void ShowOrderDetails(OrderInfo orderInfo)
        {
            txtGiro.Text = orderInfo.Giro.ToString("C2");
            txtSoldMenuCount.Text = orderInfo.SoldMenuCount.ToString();
            txtTotalOrderCount.Text = orderInfo.TotalOrderCount.ToString();
            txtTotalPriceOfExtraMaterial.Text = orderInfo.TotalPriceOfExtraMaterial.ToString("C2");
        }

    }
}
