using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_BurgerAdam.UIForm;
using WFA_BurgerAdam.Utilities;

namespace WFA_BurgerAdam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal totalPrice;
       public static List<Menu> Orders = new List<Menu>(); 
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMenu.DataSource = menuTypes;
            foreach (var extra in extras)
            {
                flowLayoutPanel1.Controls.Add(new CheckBox { Text = extra.Name, Tag = extra.Price });
            }
        }

        public static List<MenuType> menuTypes = new List<MenuType>() {
             new MenuType{ Name="ChesseeBurger",Price=20},
             new MenuType{ Name = "TavukBurger", Price = 30 },
             new MenuType{ Name = "KöfteBurger", Price = 40 },
             new MenuType{ Name = "Wooper", Price = 50 },
            };

        List<Extra> extras = new List<Extra>() {
                new Extra { Name = "Domates", Price = 0.5m },
             new Extra { Name = "Acı Sos", Price = 0.5m },
             new Extra { Name = "Peynir", Price = 0.5m },
             new Extra { Name = "Turşu", Price = 0.5m },
             new Extra { Name = "Barbekü", Price = 0.5m },
             new Extra { Name = "Hardal", Price = 0.5m },
            };

        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
            ListOrder();
            FormTools.Clear(this.Controls);
        }

        private void BtnCompleteOrder_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Şipariş İşleminiz Tamamlamak İstiyormusunuz", "Sipariş Onay", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                foreach (Menu item in lstOrderList.Items)
                {
                    Orders.Add(item);
                }
                totalPrice = 0;
                lvlTotalPrice.Text = totalPrice.ToString("C1");
                lstOrderList.Items.Clear();
                MessageBox.Show("Şipariş Verilmiştir En Kısa Zamanda Kapınızda");
            }
        }

        void ListOrder()//Listbox'da siparişleri Listele
        {
            Menu menu = CreateMenu();
            lstOrderList.Items.Add(menu);
            totalPrice += menu.Price;
            lvlTotalPrice.Text = totalPrice.ToString("C1"); // Türk lirası işareti 
        }

        int SelectMenuSize() // DÜZELTİLEBİLİR
        {
            int selectedSize = -1;
            foreach (Control item in this.Controls)
            {
                if (item is RadioButton)
                {
                    RadioButton rdb = (RadioButton)item;
                    if (rdb.Checked)
                    {
                        switch (rdb.Text)
                        {
                            case "Orta": selectedSize = 0; break;
                            case "Büyük": selectedSize = 1; break;
                            case "King": selectedSize = 2; break;
                        }
                    }
                }
            }
            return selectedSize;
        }

        Menu CreateMenu()
        {
            Menu menu = new Menu();
            menu.Size = (Size)SelectMenuSize();
            menu.MenuType = (MenuType)cmbMenu.SelectedItem;
            menu.Quantity =(int)nudQuantity.Value;
            menu.Extras = SelectMenuExtras();
            menu.CalculateMenuPrice();
            return menu;
        }

        List<Extra> SelectMenuExtras()
        {
            List<Extra> SelectedExtra = new List<Extra>();
            foreach (CheckBox chk in flowLayoutPanel1.Controls)
            {
                if (chk.Checked)
                {
                    SelectedExtra.Add(extras.Find(x => x.Name == chk.Text));
                }
            }
            return SelectedExtra;
        }
    }

}
