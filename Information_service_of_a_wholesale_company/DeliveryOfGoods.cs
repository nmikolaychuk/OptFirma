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

        private const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Никита\\Desktop\\1\\Information_service_of_a_wholesale_company\\information_service.mdf;Integrated Security=True";

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
            var Query = @"SELECT * FROM Nakladnie
			                    JOIN SaveInfo
				                    ON Nakladnie.Id = SaveInfo.id_nakladS
			                    JOIN InfoTovar
				                    ON SaveInfo.id_info = InfoTovar.Id
								JOIN Naklad_Priduct
									ON Nakladnie.Id = Naklad_Priduct.id_naklad
								JOIN Product
									ON Naklad_Priduct.id_tovar = Product.Id
                                WHERE Nakladnie.Id = '" + number + "'";
            SqlDataAdapter AORder = new SqlDataAdapter(Query, connectionString);
            DataTable Ttable = new DataTable();
            AORder.Fill(Ttable);
            var Tovar = "";
            var Kolvo = 0;
            var KolvonaSklade = 0;
            var id = 0;

            foreach (DataRow Row in Ttable.Rows)
            {
                Tovar = Row["Nazvanie"].ToString();
                Kolvo = Convert.ToInt32(Row["kol"].ToString());
                KolvonaSklade = Convert.ToInt32(Row["Quantity"].ToString());

                //if (Kolvo < KolvonaSklade)
                //{
                //    var request = @"UPDATE TOP(1) Product SET Quantity = Quantity - '" + Kolvo + "' WHERE Product.NameOfItem = '" + Tovar + "' AND Product.Quantity > 0";
                //    var command = new SqlCommand(request, connection);
                //    command.ExecuteNonQuery();
                //}
                //else
                //{
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
                //}
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
                var request = @"SELECT * FROM Nakladnie
			                    JOIN SaveInfo
				                    ON Nakladnie.Id = SaveInfo.id_nakladS
			                    JOIN InfoTovar
				                    ON SaveInfo.id_info = InfoTovar.Id
								JOIN Naklad_Priduct
									ON Nakladnie.Id = Naklad_Priduct.id_naklad
								JOIN Product
									ON Naklad_Priduct.id_tovar = Product.Id
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
                //delivery_dgv.Columns["id_tovar"].Visible = false;
                delivery_dgv.Columns["id_naklad"].Visible = false;
                // delivery_dgv.Columns["Id2"].Visible = false;
                delivery_dgv.Columns["NameOfItem"].Visible = false;
                delivery_dgv.Columns["Units_id"].Visible = false;
                delivery_dgv.Columns["Made"].Visible = false;
                delivery_dgv.Columns["ValidUntil"].Visible = false;
                delivery_dgv.Columns["Quantity"].Visible = false;
                delivery_dgv.Columns["StorageTemperature"].Visible = false;
                delivery_dgv.Columns["Warehouse_id"].Visible = false;
                delivery_dgv.Columns["PurchasePrice"].Visible = false;

                delivery_dgv.Columns["Nazvanie"].HeaderText = "Позиция";
                delivery_dgv.Columns["Price"].HeaderText = "Цена";
                delivery_dgv.Columns["kol"].HeaderText = "Количество";
            }
        }
    }
}
