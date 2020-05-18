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
    public partial class Buhgalteria : Form
    {
        public Buhgalteria()
        {
            InitializeComponent();

            sellfrom_timepicker.CustomFormat = "dd.MM.yyyy г.";
            sellfrom_timepicker.Format = DateTimePickerFormat.Custom;
            
            sellto_timepicker.CustomFormat = "dd.MM.yyyy г.";
            sellto_timepicker.Format = DateTimePickerFormat.Custom;
        }

        private const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Никита\\Desktop\\1\\Information_service_of_a_wholesale_company\\information_service.mdf;Integrated Security=True";

        void updateBuhgalteriaDGV()
        {
            var request = @"SELECT * FROM Product JOIN Product_has_Price 
                                ON Product.Id = Product_has_Price.product_id 
                      JOIN Buhgalteria 
                                ON Buhgalteria.Id = Product_has_Price.price_id";
            request += " WHERE Product.NameOfItem LIKE '%" + find_product_textbox.Text + "%'";

            var adapter = new SqlDataAdapter(request, connectionString);
            DataTable buhgalteriaTable = new DataTable();
            adapter.Fill(buhgalteriaTable);
            buhgalteria_dgv.DataSource = buhgalteriaTable;

            buhgalteria_dgv.Columns["Id"].Visible = false;
            buhgalteria_dgv.Columns["Id1"].Visible = false;
            buhgalteria_dgv.Columns["Units_id"].Visible = false;
            buhgalteria_dgv.Columns["Made"].Visible = false;
            buhgalteria_dgv.Columns["ValidUntil"].Visible = false;
            buhgalteria_dgv.Columns["Quantity"].Visible = false;
            buhgalteria_dgv.Columns["StorageTemperature"].Visible = false;
            buhgalteria_dgv.Columns["Warehouse_id"].Visible = false;
            buhgalteria_dgv.Columns["product_id"].Visible = false;
            buhgalteria_dgv.Columns["price_id"].Visible = false;


            buhgalteria_dgv.Columns["NameOfItem"].HeaderText = "Название продукта";
            buhgalteria_dgv.Columns["PurchasePrice"].HeaderText = "Цена закупки";
            buhgalteria_dgv.Columns["price"].HeaderText = "Цена продажи";
        }

        void updateProfitDGV()
        {
            var request = @"SELECT * FROM InfoTovar JOIN SaveInfo
                                ON InfoTovar.Id = SaveInfo.id_info
                            JOIN NakladnieSave
                                ON NakladnieSave.Id = SaveInfo.id_nakladS";
                           

            var adapter = new SqlDataAdapter(request, connectionString);
            DataTable profitTable = new DataTable();
            adapter.Fill(profitTable);
            profit_dgv.DataSource = profitTable;

            profit_dgv.Columns["Id"].Visible = false;
            profit_dgv.Columns["Id1"].Visible = false;
            profit_dgv.Columns["id_nakladS"].Visible = false;
            profit_dgv.Columns["id_info"].Visible = false;

            profit_dgv.Columns["Nazvanie"].HeaderText = "Название продукта";
            profit_dgv.Columns["Price"].HeaderText = "Цена продажи";
            profit_dgv.Columns["kol"].HeaderText = "Количество";
            profit_dgv.Columns["Person"].HeaderText = "Покупатель";
            profit_dgv.Columns["Data"].HeaderText = "Дата покупки";
            profit_dgv.Columns["Summ"].HeaderText = "Сумма покупки";
        }

        private void Buhgalteria_Load(object sender, EventArgs e)
        {
            updateBuhgalteriaDGV();
            updateProfitDGV();
        }

        private void sellprice_button_Click(object sender, EventArgs e)
        {
            var dbrow = buhgalteria_dgv.SelectedRows.Count > 0 ? buhgalteria_dgv.SelectedRows[0] : null;
            if (dbrow == null)
            {
                var form = new SellPrice();
                {
                    var request = "SELECT Id, NameOfItem + ' / ' + PurchasePrice AS prdct FROM Product";
                    var adapter = new SqlDataAdapter(request, connectionString);
                    var SellPrice_table = new DataTable();
                    adapter.Fill(SellPrice_table);

                    var dict = new Dictionary<int, string>();
                    foreach (DataRow row in SellPrice_table.Rows)
                    {
                        dict.Add((int)row["id"], row["prdct"].ToString());
                    }
                    form.ProductData = dict;
                }

                {
                    var request = "SELECT * FROM Buhgalteria";
                    var adapter = new SqlDataAdapter(request, connectionString);
                    var SellPrice_table = new DataTable();
                    adapter.Fill(SellPrice_table);

                    var dict = new Dictionary<int, string>();
                    foreach (DataRow row in SellPrice_table.Rows)
                    {
                        dict.Add((int)row["id"], row["price"].ToString());
                    }
                    form.PriceData = dict;
                }
                var res = form.ShowDialog();
                if (res == DialogResult.OK)
                {
                    var productid = form.ProductIdSelect;
                    var priceid = form.PriceIdSelect;

                    var connection = new SqlConnection(connectionString);
                    connection.Open();

                    var request = @"INSERT INTO Product_has_Price (product_id, price_id) VALUES ('" + productid.ToString() + "','" + priceid.ToString() + "')";

                    var command = new SqlCommand(request, connection);
                    command.ExecuteNonQuery();

                    connection.Close();
                    updateBuhgalteriaDGV();
                }
            }
            else
            {
                var form = new SellPrice();
                {
                    var request = "SELECT Id, NameOfItem + ' / ' + PurchasePrice AS prdct FROM Product";
                    var adapter = new SqlDataAdapter(request, connectionString);
                    var SellPrice_table = new DataTable();
                    adapter.Fill(SellPrice_table);

                    var dict = new Dictionary<int, string>();
                    foreach (DataRow row in SellPrice_table.Rows)
                    {
                        dict.Add((int)row["id"], row["prdct"].ToString());
                    }
                    form.ProductData = dict;
                }

                {
                    var request = "SELECT * FROM Buhgalteria";
                    var adapter = new SqlDataAdapter(request, connectionString);
                    var SellPrice_table = new DataTable();
                    adapter.Fill(SellPrice_table);

                    var dict = new Dictionary<int, string>();
                    foreach (DataRow row in SellPrice_table.Rows)
                    {
                        dict.Add((int)row["id"], row["price"].ToString());
                    }
                    form.PriceData = dict;
                }
                form.ProductIdSelect = (int)dbrow.Cells["product_id"].Value;
                form.PriceIdSelect = (int)dbrow.Cells["price_id"].Value;

                var res = form.ShowDialog();
                if (res == DialogResult.OK)
                {
                    var productid = form.ProductIdSelect;
                    var priceid = form.PriceIdSelect;
                    var productid_sel = dbrow.Cells["product_id"].Value.ToString();
                    var priceid_sel = dbrow.Cells["price_id"].Value.ToString();

                    var connection = new SqlConnection(connectionString);
                    connection.Open();

                    var request = @"UPDATE Product_has_Price SET 
                        product_id='" + productid.ToString() + "', price_id='" + priceid.ToString() + "' WHERE product_id=" + productid_sel.ToString() + " AND price_id=" + priceid_sel.ToString() + "";
                    var command = new SqlCommand(request, connection);
                    command.ExecuteNonQuery();

                    connection.Close();
                    updateBuhgalteriaDGV();
                }
            }
        }

        private void find_product_textbox_TextChanged(object sender, EventArgs e)
        {
            updateBuhgalteriaDGV();
        }

        private void info_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для редактирования цены продажи - указать строку.\n   Для установления цены продажи - не указывать", "Information", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void showsells_button_Click(object sender, EventArgs e)
        {
            var date_from = sellfrom_timepicker.Value;
            var date_to = sellto_timepicker.Value;

            var request = @"SELECT * FROM InfoTovar JOIN SaveInfo
                                ON InfoTovar.Id = SaveInfo.id_info
                            JOIN NakladnieSave
                                ON NakladnieSave.Id = SaveInfo.id_nakladS
                            WHERE NakladnieSave.Data BETWEEN '" + date_from.ToString("yyyy-MM-dd") + "' AND '" + date_to.ToString("yyyy-MM-dd") + "'";

            var adapter = new SqlDataAdapter(request, connectionString);
            DataTable profitTable = new DataTable();
            adapter.Fill(profitTable);
            profit_dgv.DataSource = profitTable;

            profit_dgv.Columns["Id"].Visible = false;
            profit_dgv.Columns["Id1"].Visible = false;
            profit_dgv.Columns["id_nakladS"].Visible = false;
            profit_dgv.Columns["id_info"].Visible = false;

            profit_dgv.Columns["Nazvanie"].HeaderText = "Название продукта";
            profit_dgv.Columns["Price"].HeaderText = "Цена продажи";
            profit_dgv.Columns["kol"].HeaderText = "Количество";
            profit_dgv.Columns["Person"].HeaderText = "Покупатель";
            profit_dgv.Columns["Data"].HeaderText = "Дата покупки";
            profit_dgv.Columns["Summ"].HeaderText = "Сумма покупки";
        }

        private void calcprofit_button_Click(object sender, EventArgs e)
        {
            var date_from = sellfrom_timepicker.Value;
            var date_to = sellto_timepicker.Value;

            var connection = new SqlConnection(connectionString);
            connection.Open();

            var request = @"SELECT SUM(Summ) AS TotalSum FROM InfoTovar JOIN SaveInfo
                                ON InfoTovar.Id = SaveInfo.id_info
                            JOIN NakladnieSave
                                ON NakladnieSave.Id = SaveInfo.id_nakladS
                            WHERE NakladnieSave.Data BETWEEN '" + date_from.ToString("yyyy-MM-dd") + "' AND '" + date_to.ToString("yyyy-MM-dd") + "'";
            var command = new SqlCommand(request, connection);

            profit_itog_textbox.Text = command.ExecuteScalar().ToString();
            connection.Close();
        }

    }
}
