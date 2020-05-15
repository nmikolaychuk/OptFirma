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
    public partial class Warehouse : Form
    {
        public Warehouse()
        {
            InitializeComponent();
        }
        
        private const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\knopk\\Desktop\\optfirma\\Information_service_of_a_wholesale_company\\information_service.mdf;Integrated Security=True";

        void updateWarehouseDGV()
        {
            var request = @"SELECT * FROM Product 
                                JOIN Warehouse
                                    ON Product.Warehouse_id=Warehouse.Id
                                JOIN UnitsForProduct
                                    ON Product.Units_id=UnitsForProduct.Id";
            var adapter = new SqlDataAdapter(request, connectionString);
            DataTable warehouseTable = new DataTable();
            adapter.Fill(warehouseTable);
            warehouse_dgv.DataSource = warehouseTable;

            warehouse_dgv.Columns["Id"].Visible = false;
            warehouse_dgv.Columns["Id1"].Visible = false;
            warehouse_dgv.Columns["Id2"].Visible = false;
            warehouse_dgv.Columns["Warehouse_id"].Visible = false;
            warehouse_dgv.Columns["Units_id"].Visible = false;

            warehouse_dgv.Columns["NameOfItem"].HeaderText = "Наименование";
            warehouse_dgv.Columns["Units"].HeaderText = "Единицы измерения";
            warehouse_dgv.Columns["Made"].HeaderText = "Дата поступления";
            warehouse_dgv.Columns["ValidUntil"].HeaderText = "Дата истечения срока годности";
            warehouse_dgv.Columns["Quantity"].HeaderText = "Количество";
            warehouse_dgv.Columns["purchasePrice"].HeaderText = "Цена закупки";
            warehouse_dgv.Columns["StorageTemperature"].HeaderText = "Температура хранения";
            warehouse_dgv.Columns["partOfTheWarehouse"].HeaderText = "Размещение";
        }

        void updateNakladnieDGV()
        {
            var request = @"SELECT DISTINCT Data, Naklad FROM InfoTovar
                           JOIN SaveInfo
                               ON InfoTovar.Id = SaveInfo.id_info
                            JOIN NakladnieSave
                                ON NakladnieSave.Id = SaveInfo.id_nakladS
                            JOIN Nakladnie
                                ON SaveInfo.id_nakladS = Nakladnie.Id";

            var adapter = new SqlDataAdapter(request, connectionString);
            DataTable nakladnieTable = new DataTable();
            adapter.Fill(nakladnieTable);
            nakladnie_dgv.DataSource = nakladnieTable;

            nakladnie_dgv.Columns["Data"].HeaderText = "Дата составления";
            nakladnie_dgv.Columns["Naklad"].HeaderText = "Номер накладной";
        }

        void updateSpisanieDGV()
        {
            var request = @"SELECT * FROM Spisanie";

            var adapter = new SqlDataAdapter(request, connectionString);
            DataTable spisanieTable = new DataTable();
            adapter.Fill(spisanieTable);
            spisanie_dgv.DataSource = spisanieTable;

            spisanie_dgv.Columns["Id"].Visible = false;

            spisanie_dgv.Columns["AktSpisanie"].HeaderText = "Номер акта списания";
            spisanie_dgv.Columns["data"].HeaderText = "Дата составления";
        }

        private void Warehouse_Load(object sender, EventArgs e)
        {
            updateWarehouseDGV();
            updateNakladnieDGV();
            updateSpisanieDGV();
        }

        private void add_things_button_Click(object sender, EventArgs e)
        {
            var form = new AddThings();
            {
                var request = "SELECT * FROM Warehouse";
                var adapter = new SqlDataAdapter(request, connectionString);
                var warehouse_table = new DataTable();
                adapter.Fill(warehouse_table);

                var dict = new Dictionary<int, string>();
                foreach (DataRow row in warehouse_table.Rows)
                {
                    dict.Add((int)row["id"], row["partOfTheWarehouse"].ToString());
                }
                form.WarehouseData = dict;
            }

            {
                var request = "SELECT * FROM UnitsForProduct";
                var adapter = new SqlDataAdapter(request, connectionString);
                var units_table = new DataTable();
                adapter.Fill(units_table);

                var dict = new Dictionary<int, string>();
                foreach (DataRow row in units_table.Rows)
                {
                    dict.Add((int)row["id"], row["Units"].ToString());
                }
                form.UnitsData = dict;
            }
            var res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                var name = form.add_name_textbox.Text;
                var count = form.add_count_textbox.Text;
                var temper = form.add_temp_textbox.Text;
                var price = form.add_price_textbox.Text;
                var warehouseid = form.WarehouseIdSelect;
                var unitsid = form.UnitsIdSelect;

                form.add_date_enter.CustomFormat = "yyyy-MM-dd";
                form.add_date_enter.Format = DateTimePickerFormat.Custom;
                var date_enter = form.add_date_enter.Value;

                form.add_date_outtime.CustomFormat = "yyyy-MM-dd";
                form.add_date_outtime.Format = DateTimePickerFormat.Custom;
                var date_outtime = form.add_date_outtime.Value;

                var connection = new SqlConnection(connectionString);
                connection.Open();

                var request = @"INSERT INTO Product (NameOfItem, Units_id, Made, ValidUntil, Quantity, StorageTemperature, Warehouse_id, PurchasePrice)
                                    VALUES ('" + name + "','" + unitsid.ToString() + "','" + date_enter.ToString("yyyy-MM-dd") + "'," +
                                    "'" + date_outtime.ToString("yyyy-MM-dd") + "','" + count + "','" + temper + "','" + warehouseid.ToString() + "','" + price + "')";
                var command = new SqlCommand(request, connection);
                command.ExecuteNonQuery();

                connection.Close();
                updateWarehouseDGV();
            }
        }

        private void edit_things_button_Click(object sender, EventArgs e)
        {
            var row = warehouse_dgv.SelectedRows.Count > 0 ? warehouse_dgv.SelectedRows[0] : null;
            if (row == null)
            {
                MessageBox.Show("Сначала укажите строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var form = new AddThings();

            form.add_name_textbox.Text = row.Cells["NameOfItem"].Value.ToString();
            form.add_count_textbox.Text = row.Cells["Quantity"].Value.ToString();
            form.add_temp_textbox.Text = row.Cells["StorageTemperature"].Value.ToString();
            form.add_price_textbox.Text = row.Cells["PurchasePrice"].Value.ToString();
            form.add_date_enter.Text = row.Cells["Made"].Value.ToString();
            form.add_date_outtime.Text = row.Cells["ValidUntil"].Value.ToString();

            {
                var request = "SELECT * FROM Warehouse";
                var adapter = new SqlDataAdapter(request, connectionString);
                var warehouse_table = new DataTable();
                adapter.Fill(warehouse_table);

                var dict = new Dictionary<int, string>();
                foreach (DataRow dbrow in warehouse_table.Rows)
                {
                    dict.Add((int)dbrow["id"], dbrow["partOfTheWarehouse"].ToString());
                }
                form.WarehouseData = dict;
            }
            form.WarehouseIdSelect = (int)row.Cells["Warehouse_id"].Value;
            {
                var request = "SELECT * FROM UnitsForProduct";
                var adapter = new SqlDataAdapter(request, connectionString);
                var units_table = new DataTable();
                adapter.Fill(units_table);

                var dict = new Dictionary<int, string>();
                foreach (DataRow dbrow in units_table.Rows)
                {
                    dict.Add((int)dbrow["id"], dbrow["Units"].ToString());
                }
                form.UnitsData = dict;
            }
            form.UnitsIdSelect = (int)row.Cells["Units_id"].Value;

            var res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                var name = form.add_name_textbox.Text;
                var count = form.add_count_textbox.Text;
                var temper = form.add_temp_textbox.Text;
                var price = form.add_price_textbox.Text;
                var warehouseid = form.WarehouseIdSelect;
                var unitsid = form.UnitsIdSelect;

                form.add_date_enter.CustomFormat = "yyyy-MM-dd";
                form.add_date_enter.Format = DateTimePickerFormat.Custom;
                var date_enter = form.add_date_enter.Value;

                form.add_date_outtime.CustomFormat = "yyyy-MM-dd";
                form.add_date_outtime.Format = DateTimePickerFormat.Custom;
                var date_outtime = form.add_date_outtime.Value;
                var id = row.Cells["id"].Value.ToString();

                var connection = new SqlConnection(connectionString);
                connection.Open();

                var request = @"UPDATE Product SET
                                   NameOfItem='" + name + "',Units_id='" + unitsid.ToString() + "',Made='" + date_enter.ToString("yyyy-MM-dd") + "',ValidUntil=" +
                                    "'" + date_outtime.ToString("yyyy-MM-dd") + "',Quantity='" + count + "',StorageTemperature='" + temper + "',Warehouse_id='" + warehouseid.ToString() + "',PurchasePrice='" + price + "' WHERE id='" + id + "'";
                var command = new SqlCommand(request, connection);
                command.ExecuteNonQuery();

                connection.Close();
                updateWarehouseDGV();
            }
        }

        private void delete_things_button_Click(object sender, EventArgs e)
        {
            updateWarehouseDGV();
        }

        private void things_outtime_button_Click(object sender, EventArgs e)
        {
            var form = new OuttimeThings();
            var res = form.ShowDialog();
        }

        private void NewDannie_Click(object sender, EventArgs e)
        {
            updateSpisanieDGV();
            updateNakladnieDGV();
        }
    }
}
