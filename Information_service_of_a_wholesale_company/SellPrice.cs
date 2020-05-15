using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information_service_of_a_wholesale_company
{
    public partial class SellPrice : Form
    {
        public SellPrice()
        {
            InitializeComponent();
        }

        private void okey_sellprice_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancel_sellprice_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public Dictionary<int, string> ProductData     // ассоциативный массив
        {
            set
            {
                product_sellprice_combobox.DataSource = value.ToArray();
                product_sellprice_combobox.DisplayMember = "Value";
            }
        }

        public Dictionary<int, string> PriceData     // ассоциативный массив
        {
            set
            {
                price_combobox.DataSource = value.ToArray();
                price_combobox.DisplayMember = "Value";
            }
        }

        public int ProductIdSelect
        {
            get
            {
                return ((KeyValuePair<int, string>)product_sellprice_combobox.SelectedItem).Key;
            }
            set
            {
                int idx = 0;
                foreach (KeyValuePair<int, string> item in product_sellprice_combobox.Items)
                {
                    if (item.Key == value)
                    {
                        break;
                    }
                    idx++;
                }
                product_sellprice_combobox.SelectedIndex = idx;
            }
        }

        public int PriceIdSelect
        {
            get
            {
                return ((KeyValuePair<int, string>)price_combobox.SelectedItem).Key;
            }
            set
            {
                int idx = 0;
                foreach (KeyValuePair<int, string> item in price_combobox.Items)
                {
                    if (item.Key == value)
                    {
                        break;
                    }
                    idx++;
                }
                price_combobox.SelectedIndex = idx;
            }
        }
    }
}
