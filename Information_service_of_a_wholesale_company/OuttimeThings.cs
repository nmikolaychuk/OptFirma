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
    public partial class OuttimeThings : Form
    {
        public OuttimeThings()
        {
            InitializeComponent();
        }

        private const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Никита\\Desktop\\1\\Information_service_of_a_wholesale_company\\information_service.mdf;Integrated Security=True";

        void updateOuttimeDGV()
        {
            var time = DateTime.Today;

            var request = @"SELECT * FROM Product 
                                JOIN Warehouse
                                    ON Product.Warehouse_id=Warehouse.Id
                                JOIN UnitsForProduct
                                    ON Product.Units_id=UnitsForProduct.Id
                                WHERE Product.ValidUntil < '" + time.ToString("yyyy-MM-dd") + "'";
            var adapter = new SqlDataAdapter(request, connectionString);
            DataTable outtimeTable = new DataTable();
            adapter.Fill(outtimeTable);
            outtime_things_dgv.DataSource = outtimeTable;

            outtime_things_dgv.Columns["Id"].Visible = false;
            outtime_things_dgv.Columns["Id1"].Visible = false;
            outtime_things_dgv.Columns["Id2"].Visible = false;
            outtime_things_dgv.Columns["Warehouse_id"].Visible = false;
            outtime_things_dgv.Columns["Units_id"].Visible = false;

            outtime_things_dgv.Columns["NameOfItem"].HeaderText = "Наименование";
            outtime_things_dgv.Columns["Units"].HeaderText = "Единицы измерения";
            outtime_things_dgv.Columns["Made"].HeaderText = "Дата поступления";
            outtime_things_dgv.Columns["ValidUntil"].HeaderText = "Дата истечения срока годности";
            outtime_things_dgv.Columns["Quantity"].HeaderText = "Количество";
            outtime_things_dgv.Columns["purchasePrice"].HeaderText = "Цена закупки";
            outtime_things_dgv.Columns["StorageTemperature"].HeaderText = "Температура хранения";
            outtime_things_dgv.Columns["partOfTheWarehouse"].HeaderText = "Размещение";
        }

        private void OuttimeThings_Load(object sender, EventArgs e)
        {
            updateOuttimeDGV();
        }
        
        private void do_akt_Click(object sender, EventArgs e)
        {
            var query = @"SELECT Id FROM Spisanie WHERE Id=(SELECT MAX(Id) FROM Spisanie)";
            //var query = @"SELECT COUNT(Id) FROM Spisanie";
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
                int m=1;
                res = m.ToString();
                path = "Акт списания " + res + ".txt";
            }
            else
            {
                int m = Convert.ToInt32(res);
                m++;
                res = m.ToString();
                path = "Акт списания " + res + ".txt"; }
            var time = DateTime.Today;

            var request = @"SELECT * FROM Product 
                                JOIN Warehouse
                                    ON Product.Warehouse_id=Warehouse.Id
                                JOIN UnitsForProduct
                                    ON Product.Units_id=UnitsForProduct.Id
                                WHERE Product.ValidUntil < '" + time.ToString("yyyy-MM-dd") + "'";
            var adapter = new SqlDataAdapter(request, connectionString);
            DataTable outtimeTable = new DataTable();
            adapter.Fill(outtimeTable);
            outtime_things_dgv.DataSource = outtimeTable;

            string text = @"
        Утверждаю:
                                                                         Генеральный директор
                                                                         _________________Ф.И.О.
                                                             
                                      АКТ № " + res + "";
            string text1 = @"                       НА СПИСАНИЕ ТОВАРОВ


        Комиссия в составе:
        Главный бухгалтер ________________(подпись)________________________Ф.И.О.
        Кладовщик_______________________(подпись) _______________________Ф.И.О.
        Исполнительный директор_________________________(подпись)_______________________Ф.И.О.
        
        Произвела списание материалов в связи с их непригодностью для дальнейшего
        использования.


                                                                                            ";
            
            /*if (!File.Exists(path))*/ 
            FileStream fs1 = File.Create(path);
            fs1.Close();
            //StreamWriter FS = new StreamWriter("./data.ns");

            StreamWriter output = new StreamWriter(path);
            
            output.WriteLine(text+text1);
                    List<int> col_n = new List<int>();
                    foreach (DataGridViewColumn col in outtime_things_dgv.Columns)
                        if (col.Visible)
                        {
                            //sw.Write(col.HeaderText + "\t");
                            col_n.Add(col.Index);
                        }
                    //sw.WriteLine();
                    int x = outtime_things_dgv.RowCount;
                    if (outtime_things_dgv.AllowUserToAddRows) x--;

                    for (int i = 0; i < x; i++)
                    {
                        for (int y = 0; y < col_n.Count; y++)
                    output.Write(outtime_things_dgv[col_n[y], i].Value + "\t");
                output.Write(" \r\n");
                    }

            output.WriteLine(@"                                    
                                                          
                                                                    Дата составления акта: "+time.ToString("dd.MM.yyyy г.")+"");
            output.Close();
        
        var connection = new SqlConnection(connectionString);
        connection.Open();
                var req = @"INSERT INTO Spisanie (Id, AktSpisanie, data) VALUES ('" + res + "', 'Akt " + res + "', '" + time.ToString("yyyy-MM-dd") + "')";
        var command = new SqlCommand(req, connection);
        command.ExecuteNonQuery();
                connection.Close();
            Process.Start(path);
        }

        private void spisanie_button_Click(object sender, EventArgs e)
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();
            var time = DateTime.Today;
            var request = @"UPDATE Product SET Quantity = 0 WHERE Product.ValidUntil < '" + time.ToString("yyyy-MM-dd") + "'";

            var command = new SqlCommand(request, connection);
            command.ExecuteNonQuery();

            connection.Close();
            updateOuttimeDGV();
        }

        private void Inform_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для списания товара необходимо сначала составить акт списания, а затем списать товар.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}

    