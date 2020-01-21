using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_BurgerAdam.Utilities
{
    public class FormTools
    {
        public static void Clear(Control.ControlCollection collection)
        {
            foreach (Control item in collection)
            {
                if (item is CheckBox)
                {
                    CheckBox chk = (CheckBox)item;
                    chk.Checked = false;
                }
                else if (item is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)item;
                    nud.Value = 1;
                }
                else if (item is RadioButton)
                {
                    RadioButton rdb = (RadioButton)item;
                    rdb.Checked = rdb.Text == "Orta" ? true : false;
                }
                else if (item is ComboBox)
                {
                    ComboBox cmb = (ComboBox)item;
                    cmb.SelectedIndex = -1;
                }
                else if (item is FlowLayoutPanel)
                {
                    FlowLayoutPanel flp = (FlowLayoutPanel)item;
                    Clear(flp.Controls);
                }
            }

        }
    }
}
