using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
    public partial class OtdelProdag : Form
    {
        public OtdelProdag()
        {
            InitializeComponent();
        }
        private const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\knopk\\Desktop\\optfirma\\Information_service_of_a_wholesale_company\\information_service.mdf;Integrated Security=True";

        void updateScladDGV()
        {
            var time = DateTime.Today;

            var request = @"SELECT * FROM Product 
                                JOIN Warehouse
                                    ON Product.Warehouse_id=Warehouse.Id
                                JOIN UnitsForProduct
                                    ON Product.Units_id=UnitsForProduct.Id
                                WHERE Product.ValidUntil > '" + time.ToString("yyyy-MM-dd") + "'";
            var adapter = new SqlDataAdapter(request, connectionString);
            DataTable outtimeTable = new DataTable();
            adapter.Fill(outtimeTable);
            dataGrid_Sclad.DataSource = outtimeTable;

            dataGrid_Sclad.Columns["Id"].Visible = false;
            dataGrid_Sclad.Columns["Id1"].Visible = false;
            dataGrid_Sclad.Columns["Id2"].Visible = false;
            dataGrid_Sclad.Columns["Warehouse_id"].Visible = false;
            dataGrid_Sclad.Columns["Units_id"].Visible = false;
            dataGrid_Sclad.Columns["StorageTemperature"].Visible = false;
            dataGrid_Sclad.Columns["partOfTheWarehouse"].Visible = false;
            dataGrid_Sclad.Columns["Units"].Visible = false;
            dataGrid_Sclad.Columns["purchasePrice"].Visible = false;

            dataGrid_Sclad.Columns["NameOfItem"].HeaderText = "Наименование";
            dataGrid_Sclad.Columns["Made"].HeaderText = "Дата поступления";
            dataGrid_Sclad.Columns["ValidUntil"].HeaderText = "Дата истечения срока годности";
            dataGrid_Sclad.Columns["Quantity"].HeaderText = "Количество";

        }

        void updateListDGV()
        {
            var request = @"SELECT * FROM help_prod";
            var adapter = new SqlDataAdapter(request, connectionString);
            DataTable outtimeTable = new DataTable();
            adapter.Fill(outtimeTable);
            dataGridList.DataSource = outtimeTable;

            dataGridList.Columns["Id"].Visible = false;

            dataGridList.Columns["name"].HeaderText = "Наименование";
            dataGridList.Columns["kol"].HeaderText = "Количество";
            dataGridList.Columns["price"].HeaderText = "Цена";
            //for (int i = 0; i <= 10; i++) dataGridList.Rows.Add();

        }


        private void OtdelProdag_Load(object sender, EventArgs e)
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();
            var quest = @"DELETE  FROM help_prod";
            var command = new SqlCommand(quest, connection);
            command.ExecuteNonQuery();
            connection.Close();
            updateScladDGV();
            updateListDGV();
        }
        int ish = 0;
        int itogo = 0;
        int[] nums = new int[50];
        int[] numsss = new int[50];
        private void button2_Click(object sender, EventArgs e)
        {
            var row = dataGrid_Sclad.SelectedRows.Count > 0 ? dataGrid_Sclad.SelectedRows[0] : null;
            if (row == null)
            {
                MessageBox.Show("Сначала выбирете строку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var form = new ParametrProduct();
            form.name_product.Text = row.Cells["NameOfItem"].Value.ToString();
            var res = form.ShowDialog();
            var nomer = row.Cells["Id"].Value.ToString();
            if (res == DialogResult.OK)
            {
                var query = @"SELECT Id FROM help_prod WHERE Id=(SELECT MAX(Id) FROM help_prod)";
                SqlDataAdapter aOrder = new SqlDataAdapter(query, connectionString);
                DataTable table = new DataTable();
                aOrder.Fill(table);
                string res1 = "";
                foreach (DataRow Row in table.Rows)
                {
                    res1 += Row["Id"].ToString();
                }
                if (res1 == "")
                {
                    int m = 1;
                    res1 = m.ToString();
                }
                else
                {
                    int m = Convert.ToInt32(res1);
                    m++;
                    res1 = m.ToString();
                }
                var quer = @"SELECT Id FROM InfoTovar WHERE Id=(SELECT MAX(Id) FROM InfoTovar)";
                SqlDataAdapter AOrder = new SqlDataAdapter(quer, connectionString);
                DataTable Table = new DataTable();
                AOrder.Fill(Table);
                string ress = "";
                foreach (DataRow Row in Table.Rows)
                {
                    ress += Row["Id"].ToString();
                }
                if (ress == "")
                {
                    int m = 1;
                    ress = m.ToString();
                }
                else
                {
                    int m = Convert.ToInt32(ress);
                    m++;
                    ress = m.ToString();
                }
                var query1 = @"SELECT Product.NameOfItem,Buhgalteria.price FROM Product JOIN Product_has_Price
                                ON Product.Id=Product_has_Price.product_id
                            JOIN Buhgalteria
                                ON Buhgalteria.Id=Product_has_Price.price_id
                               WHERE Product.Id='"+nomer+"'";
                SqlDataAdapter aOrder1 = new SqlDataAdapter(query1, connectionString);
                DataTable table1 = new DataTable();
                aOrder1.Fill(table1);
                var res2 = "";
                foreach (DataRow Row1 in table1.Rows)
                {
                    res2 += Row1["price"].ToString();
                }
                var max_kol = row.Cells["Quantity"].Value.ToString();
                var koll = form.textBox_kol.Text;
                if (Convert.ToInt32(koll) > Convert.ToInt32(max_kol))
                {
                    MessageBox.Show("Превышено количество товара на складе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ish = 0;
                    ish = Convert.ToInt32(max_kol);
                    var Price = res2;
                    itogo += Convert.ToInt32(koll)*Convert.ToInt32(Price);
                    var menh_kol = (Convert.ToInt32(max_kol) - Convert.ToInt32(koll)).ToString();
                    var nname = form.name_product.Text;
                    var id = res1;
                    var idd = row.Cells["id"].Value.ToString();
                    nums[Convert.ToInt32(id)] = Convert.ToInt32(idd);
                    numsss[Convert.ToInt32(ress)] = Convert.ToInt32(ress);
                    var connection = new SqlConnection(connectionString);
                    connection.Open();
                    var request = @"INSERT INTO help_prod (name, kol,Id,price)
                                               VALUES ('" + nname + "','" + koll + "','" + id + "','" + Price + "')";

                    var request1 = @"UPDATE Product  SET Quantity='" + menh_kol + "' WHERE Id='" + idd + "'";
                    var request2 = @"INSERT INTO InfoTovar (Nazvanie, kol,Id,Price)
                                               VALUES ('" + nname + "','" + koll + "','" + ress + "','" + Price + "')";
                    var command = new SqlCommand(request, connection);
                    command.ExecuteNonQuery();
                    var command1 = new SqlCommand(request1, connection);
                    command1.ExecuteNonQuery();
                    var command3 = new SqlCommand(request2, connection);
                    command3.ExecuteNonQuery();
                    connection.Close();
                    updateListDGV();
                    updateScladDGV();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Client();
            var ress = form.ShowDialog();
            if (ress == DialogResult.OK)
            {
                var query = @"SELECT Id FROM Nakladnie WHERE Id=(SELECT MAX(Id) FROM Nakladnie)";
                SqlDataAdapter aOrder = new SqlDataAdapter(query, connectionString);
                DataTable table = new DataTable();
                aOrder.Fill(table);
                string res = "";
                foreach (DataRow row in table.Rows)
                {
                    res += row["Id"].ToString();
                }

                string path;
                if (res == "")
                {
                    int m = 1;
                    res = m.ToString();
                    path = "Накладная №'" + res + "'.txt";
                }
                else
                {
                    int m = Convert.ToInt32(res);
                    m++;
                    res = m.ToString();
                    path = "Накладная №'" + res + "'.txt";
                }
                var client= form.Client_TextBox.Text;
                var time = DateTime.Today;
                var request = @"SELECT * FROM help_prod";
                var adapter = new SqlDataAdapter(request, connectionString);
                DataTable outtimeTable = new DataTable();
                adapter.Fill(outtimeTable);
                dataGridList.DataSource = outtimeTable;

                string text1 = @"Накладная №'" + res + "' от '" + time + "'";
                string text2 = @"
Грузоотправитель: ООО БАБЛОС

Грузополучатель:'" + client + "'";

                string text3 = @"
Основание для отпуска: Продажа товаров";
                string text4 = @"
Наименование    Количество  Цена";
                FileStream fs1 = File.Create(path);
                fs1.Close();
                //StreamWriter FS = new StreamWriter("./data.ns");

                StreamWriter output = new StreamWriter(path);

                output.WriteLine(text1 + text2 + text3 + text4);
                List<int> col_n = new List<int>();
                foreach (DataGridViewColumn col in dataGridList.Columns)
                    if (col.Visible)
                    {
                        //sw.Write(col.HeaderText + "\t");
                        col_n.Add(col.Index);
                    }
                //sw.WriteLine();
                int x = dataGridList.RowCount;
                if (dataGridList.AllowUserToAddRows) x--;
          
                for (int i = 0; i < x; i++)
                {
                    for (int y = 0; y < col_n.Count; y++)
                    { 
                        output.Write(dataGridList[col_n[y], i].Value + "\t");
                    }
                    output.Write(" \r\n");
                    //var req2 = @"INSERT  INTO Naklad_Product (id_tovar, id_naklad) VALUES ('"  "','" + res + "')";
                }

                
                var nds = itogo * 0.2;

                output.WriteLine(@"Всего отпущено'" + x + "'"); output.WriteLine(@"наименований
            

                На сумму '" + itogo + "'"); output.WriteLine(@" руб.00 коп.



                в том числе НДС '" + nds + "'"); output.WriteLine(@" руб.00 коп.


                Отпуск разрешил

                (подпись) (должность) (Ф.И.О.)

                М. П.

                Отпустил

                (подпись) (должность) (Ф.И.О.)

                Получил

                (подпись) (должность) (Ф.И.О.)

                М. П.");
                output.Close();

                var connection = new SqlConnection(connectionString);
                connection.Open();
                var req = @"INSERT  INTO Nakladnie (Id, Naklad) VALUES ('" + res + "','Akt " + res + "')";
                var req1 = @"INSERT  INTO NakladnieSave (Id, Person, Data, Summ) VALUES ('" + res + "','" + client + "','" + time.ToString("yyyy-MM-dd") + "','" + itogo + "')";
                var command = new SqlCommand(req, connection);
                var command1 = new SqlCommand(req1, connection);
                command.ExecuteNonQuery();
                command1.ExecuteNonQuery();
                connection.Close();
                var quer = @"SELECT Id FROM InfoTovar WHERE Id=(SELECT MAX(Id) FROM InfoTovar)";
                SqlDataAdapter AOrder = new SqlDataAdapter(quer, connectionString);
                DataTable Table = new DataTable();
                AOrder.Fill(Table);
                string Res = "";
                foreach (DataRow Row in Table.Rows)
                {
                    Res += Row["Id"].ToString();
                }
                if (Res == "")
                {
                    int m = 1;
                    Res = m.ToString();
                }
                else
                {
                    int m = Convert.ToInt32(Res);
                    m=m-x+1;
                    Res = m.ToString();
                }
                int ccol = 0;
                for (int i = 1; i <= x; i++)
                {
                    if (i > 1) ccol++;
                    else ccol = Convert.ToInt32(Res);
                    var connection3 = new SqlConnection(connectionString);
                    connection3.Open();
                    var req2 = @"INSERT  INTO Naklad_Priduct (id_tovar, id_naklad) VALUES ('" + nums[i] + "','" + Convert.ToInt32(res) + "')";
                    var req3 = @"INSERT  INTO  SaveInfo (id_info, id_nakladS) VALUES ('" + numsss[ccol] + "','" + Convert.ToInt32(res) + "')";
                    var command3 = new SqlCommand(req2, connection3);
                    command3.ExecuteNonQuery();
                    var command4 = new SqlCommand(req3, connection3);
                    command4.ExecuteNonQuery();
                }

                Process.Start(path);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var row = dataGridList.SelectedRows.Count > 0 ? dataGridList.SelectedRows[0] : null;
            if (row == null)
            {
                MessageBox.Show("Сначала выбирете строку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var id = row.Cells["id"].Value.ToString();
            var nname = row.Cells["name"].Value.ToString();
            var connection = new SqlConnection(connectionString);
            var kol = ish.ToString();
            connection.Open();
            var request = @"DELETE FROM help_prod WHERE Id='" + id + "';";
            var request1 = @"UPDATE Product  SET Quantity='" + kol + "' WHERE NameOfItem='" + nname + "'";
            var command = new SqlCommand(request, connection);
            command.ExecuteNonQuery();
            var command1 = new SqlCommand(request1, connection);
            command1.ExecuteNonQuery();
            connection.Close();
            updateListDGV();
            updateScladDGV();
        }

        private void button5_Click(object sender, EventArgs e)
            {
                var row = dataGridList.SelectedRows.Count > 0 ? dataGridList.SelectedRows[0] : null;
                if (row == null)
                {
                    MessageBox.Show("Сначала выбирете строку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var form = new ParametrProduct();
                form.name_product.Text = row.Cells["name"].Value.ToString();
                form.textBox_kol.Text = row.Cells["kol"].Value.ToString();
                var res = form.ShowDialog();
                if (res == DialogResult.OK)
                {
                    var name = form.name_product.Text;
                    var Koll = form.textBox_kol.Text;
                    var delta = (ish - Convert.ToInt32(Koll)).ToString();
                    var id = row.Cells["id"].Value.ToString();
                    var connection = new SqlConnection(connectionString);
                    connection.Open();
                    var request = @"UPDATE help_prod SET name='" + name + "',kol='" + Koll + "' WHERE Id='" + id + "'";
                    var request1 = @"UPDATE Product  SET Quantity='" + delta + "' WHERE NameOfItem='" + name + "'";
                    var command = new SqlCommand(request, connection);
                    var command1 = new SqlCommand(request1, connection);
                    command.ExecuteNonQuery();
                    command1.ExecuteNonQuery();
                    connection.Close();
                    updateListDGV();
                    updateScladDGV();
                }
            
        }
    }
}
