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
using System.Runtime.CompilerServices;

namespace Information_service_of_a_wholesale_company
{
    public partial class DeliveryOfGoods : Form
    {
        public DeliveryOfGoods()
        {
            InitializeComponent();
        }

        private const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Никита\\Desktop\\OptFirma\\Information_service_of_a_wholesale_company\\information_service.mdf;Integrated Security=True";

        private void InformationDelivery_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для получения заказа введите номер заказа и нажмите <<Забрать заказ>>", "Information", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void pickuporder_Click(object sender, EventArgs e)
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();

            var form = new NumberOfOrder();

            var number = number_textbox.Text;

            if (number == "")
            {
                MessageBox.Show("Укажите номер заказа!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            //var Query = @"SELECT * FROM Nakladnie
            //           JOIN SaveInfo
            //            ON Nakladnie.Id = SaveInfo.id_nakladS
            //           JOIN InfoTovar
            //            ON SaveInfo.id_info = InfoTovar.Id
            //                    WHERE Nakladnie.Id = '" + number + "'";
            var Query = @"SELECT * FROM InfoTovar
					JOIN SaveInfo
						ON InfoTovar.Id = SaveInfo.id_info
					JOIN Nakladnie
						ON SaveInfo.id_nakladS = Nakladnie.Id
                    WHERE Nakladnie.Id = '" + number + "'";
            SqlDataAdapter AORder = new SqlDataAdapter(Query, connectionString);
            DataTable Ttable = new DataTable();
            AORder.Fill(Ttable);

            
            var flag_req = @"SELECT delivery_flag FROM Nakladnie WHERE Nakladnie.Id = '" + number + "'";
            var command_flag = new SqlCommand(flag_req, connection);
            command_flag.ExecuteNonQuery();

            SqlDataAdapter order_flag = new SqlDataAdapter(flag_req, connectionString);
            DataTable table_flag = new DataTable();
            order_flag.Fill(table_flag);

            var flag = 0;
            foreach (DataRow Row in table_flag.Rows)
            {
                flag = Convert.ToInt32(Row["delivery_flag"].ToString());
            }

            if (flag == 1)
            {
                MessageBox.Show("Товар уже выдан!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                var Tovar = "";
                var Kolvo = 0;
                var KolvonaSklade = 0;
                var id = 0;

                foreach (DataRow Row in Ttable.Rows)
                {
                    Tovar = Row["Nazvanie"].ToString();
                    Kolvo = Convert.ToInt32(Row["kol"].ToString());

                    var request1 = @"SELECT Id, Quantity FROM Product WHERE Product.NameOfItem = '" + Tovar + "' AND Product.Quantity > 0";
                    var command1 = new SqlCommand(request1, connection);
                    command1.ExecuteNonQuery();

                    SqlDataAdapter Order = new SqlDataAdapter(request1, connectionString);
                    DataTable table = new DataTable();
                    Order.Fill(table);

                    foreach (DataRow dbRow in table.Rows)
                    {
                        KolvonaSklade = Convert.ToInt32(dbRow["Quantity"].ToString());
                        id = Convert.ToInt32(dbRow["Id"].ToString());

                        if (Kolvo < KolvonaSklade)
                        {
                            var request = @"UPDATE Product SET Quantity = Quantity - '" + Kolvo + "' WHERE Product.Id = '" + id + "'";
                            var command = new SqlCommand(request, connection);
                            command.ExecuteNonQuery();
                            break;
                        }
                        else
                        {
                            var request = @"UPDATE Product SET Quantity = 0 WHERE Product.Id = '" + id + "'";
                            var command = new SqlCommand(request, connection);
                            command.ExecuteNonQuery();

                            Kolvo -= KolvonaSklade;
                            continue;
                        }
                    }

                }

                var flag_new = @"UPDATE Nakladnie SET delivery_flag = 1 WHERE Nakladnie.Id = '" + number + "'";
                var command_flag_new = new SqlCommand(flag_new, connection);
                command_flag_new.ExecuteNonQuery();

                this.Close();

                MessageBox.Show("Товар успешно выдан", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            connection.Close();
        }

        private void number_of_order_Click(object sender, EventArgs e)
        {
            var form = new NumberOfOrder();
            var res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                var number_of_order = form.numberoforder_textbox.Text;
                number_textbox.Text = number_of_order;
                var request = @"SELECT * FROM InfoTovar
					JOIN SaveInfo
						ON InfoTovar.Id = SaveInfo.id_info
					JOIN Nakladnie
						ON SaveInfo.id_nakladS = Nakladnie.Id
                                WHERE Nakladnie.Id = '" + number_of_order + "'";
                var adapter = new SqlDataAdapter(request, connectionString);
                DataTable delivery = new DataTable();
                adapter.Fill(delivery);
                delivery_dgv.DataSource = delivery;

                delivery_dgv.Columns["Id"].Visible = false;
                delivery_dgv.Columns["Naklad"].Visible = false;
                delivery_dgv.Columns["id_nakladS"].Visible = false;
                delivery_dgv.Columns["id_info"].Visible = false;
                delivery_dgv.Columns["Id1"].Visible = false;
                delivery_dgv.Columns["delivery_flag"].Visible = false;

                delivery_dgv.Columns["Nazvanie"].HeaderText = "Позиция";
                delivery_dgv.Columns["Price"].HeaderText = "Цена";
                delivery_dgv.Columns["kol"].HeaderText = "Количество";
            }
        }
    }
}
