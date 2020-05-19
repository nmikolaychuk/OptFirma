using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Information_service_of_a_wholesale_company
{
    public partial class Form1 : Form
    {
        private const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Никита\\Desktop\\OptFirma\\Information_service_of_a_wholesale_company\\information_service.mdf;Integrated Security=True";

        public Dictionary<int, string> PositionMSP
        {
            set
            {
                comboBox_Position.DataSource = value.ToArray();
                comboBox_Position.DisplayMember = "Value";
            }
        }
        public int PositionId
        {
            get
            {
                return ((KeyValuePair<int, string>)comboBox_Position.SelectedItem).Key;
            }
            set
            {
                int indx = 0;
                foreach (KeyValuePair<int, string> item in comboBox_Position.Items)
                {
                    if (item.Key == value)
                    {
                        break;
                    }
                    indx++;
                }
                comboBox_Position.SelectedIndex = indx;
            }
        }
        
        public Form1()
        {
            InitializeComponent();
            var request = @"SELECT * FROM Position_Password";
            var adapter = new SqlDataAdapter(request, connectionString);
            var orgTable = new DataTable();
            adapter.Fill(orgTable);
            var dict = new Dictionary<int, string>();
            foreach (DataRow row in orgTable.Rows)
            {
                dict.Add((int)row["Id"], row["Position"].ToString());
            }
            PositionMSP = dict;
        }

        
        public static string MyTextBoxValue;
        private void Input_Click(object sender, EventArgs e)
        {
            var form = new Form1();

            bool success = false;
            //string log = textBox1_Otdel.Text;
            string pas = Password_TextBox.Text;
            var log =PositionId;
            int idishka;
            var con = new SqlConnection(connectionString);
            try
            {
                string command = "SELECT Id FROM Position_Password WHERE Id = '" + log + "' AND Password ='" + pas + "';";
                SqlCommand check = new SqlCommand(command, con);
                con.Open();

                using (var dataReader = check.ExecuteReader())
                {
                    success = dataReader.Read();
                }
               idishka = PositionId;
            }
            finally
            {
                con.Close();
            }

            if (success)
            {
                if(idishka==1)
                {var sklad_form = new Warehouse();
                var rez = sklad_form.ShowDialog(); }
                if (idishka == 2)
                {
                    var buh_form = new Buhgalteria();
                    var rez = buh_form.ShowDialog();
                }
                if (idishka == 3)
                {
                    var prod_form = new OtdelProdag();
                    var rez = prod_form.ShowDialog();
                }
                if (idishka == 4)
                {
                    var mark_form = new OtdelMarketinga();
                    var rez = mark_form.ShowDialog();
                }
            }

            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
