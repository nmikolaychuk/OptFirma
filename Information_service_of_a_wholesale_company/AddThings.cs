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
    public partial class AddThings : Form
    {
        public AddThings()
        {
            InitializeComponent();

            add_date_enter.MinDate = new DateTime(2000, 1, 1);
            add_date_enter.MaxDate = DateTime.Today;

            add_date_outtime.MinDate = new DateTime(2019, 1, 1);
            add_date_outtime.MaxDate = new DateTime(2030, 1, 1);
        }

        private void okey_button_add_thing_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancel_button_add_thing_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public Dictionary<int, string> WarehouseData     // ассоциативный массив
        {
            set
            {
                add_position_combobox.DataSource = value.ToArray();
                add_position_combobox.DisplayMember = "Value";
            }
        }

        public Dictionary<int, string> UnitsData     // ассоциативный массив
        {
            set
            {
                add_units_combobox.DataSource = value.ToArray();
                add_units_combobox.DisplayMember = "Value";
            }
        }

        public int WarehouseIdSelect
        {
            get
            {
                return ((KeyValuePair<int, string>)add_position_combobox.SelectedItem).Key;
            }
            set
            {
                int idx = 0;
                foreach (KeyValuePair<int, string> item in add_position_combobox.Items)
                {
                    if (item.Key == value)
                    {
                        break;
                    }
                    idx++;
                }
                add_position_combobox.SelectedIndex = idx;
            }
        }

        public int UnitsIdSelect
        {
            get
            {
                return ((KeyValuePair<int, string>)add_units_combobox.SelectedItem).Key;
            }
            set
            {
                int idx = 0;
                foreach (KeyValuePair<int, string> item in add_units_combobox.Items)
                {
                    if (item.Key == value)
                    {
                        break;
                    }
                    idx++;
                }
                add_units_combobox.SelectedIndex = idx;
            }
        }
    }
}
