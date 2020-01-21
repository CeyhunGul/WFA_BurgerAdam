using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_BurgerAdam.UIForm;

namespace WFA_BurgerAdam.UIForm
{
    public partial class MenuItem : Form
    {
        public MenuItem()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MenuType menuType = new MenuType();
            menuType.Name = txtMenuName.Text;
            menuType.Price = nudPrice.Value;
            Form1.menuTypes.Add(menuType);
            MessageBox.Show("Menü eklendi");
            this.Close();
        }

        private void MenuItem_Load(object sender, EventArgs e)
        {

        }
    }
}
