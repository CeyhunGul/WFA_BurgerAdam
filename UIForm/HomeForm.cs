using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_BurgerAdam.UIForm
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        MenuItem menuItem = new MenuItem();
        Form1 order = new Form1();
        OrdersDetails orderDetail = new OrdersDetails();
        private void menuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menuItem.IsDisposed)
            {
                menuItem = new MenuItem();
            }
            menuItem.Show();
            menuItem.MdiParent = this;
        }

        private void siparişVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (order.IsDisposed)
            {
                order = new Form1();
            }
            order.Show();
            order.MdiParent = this;
        }

        private void siparişDetaylarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (orderDetail.IsDisposed)
            {
                orderDetail = new OrdersDetails();
            }
            orderDetail.Show();
            orderDetail.MdiParent = this;
        }

      
    }
}
