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
    public partial class OtdelMarketinga : Form
    {
        public OtdelMarketinga()
        {
            InitializeComponent();

            oftenorder_from_timepicker.CustomFormat = "dd.MM.yyyy г.";
            oftenorder_from_timepicker.Format = DateTimePickerFormat.Custom;

            oftenorder_to_timepicker.CustomFormat = "dd.MM.yyyy г.";
            oftenorder_to_timepicker.Format = DateTimePickerFormat.Custom;

            naimoften_from_timepicker.CustomFormat = "dd.MM.yyyy г.";
            naimoften_from_timepicker.Format = DateTimePickerFormat.Custom;

            naimoften_to_timepicker.CustomFormat = "dd.MM.yyyy г.";
            naimoften_to_timepicker.Format = DateTimePickerFormat.Custom;
        }

        private const string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\knopk\\Desktop\\optfirma\\Information_service_of_a_wholesale_company\\information_service.mdf;Integrated Security=True";

        void updateNaibOftenDGV()
        {
            var date_from = oftenorder_from_timepicker.Value;
            var date_to = oftenorder_to_timepicker.Value;

            var request = @"SELECT TOP 10 Nazvanie, COUNT(Nazvanie) AS FREC FROM InfoTovar
                              JOIN SaveInfo ON InfoTovar.Id = SaveInfo.id_info
                              JOIN NakladnieSave ON NakladnieSave.Id = SaveInfo.id_nakladS
                        WHERE NakladnieSave.Data BETWEEN '" + date_from.ToString("yyyy-MM-dd") 
                              + "' AND '" + date_to.ToString("yyyy-MM-dd")
                              + "' GROUP BY Nazvanie ORDER BY FREC DESC";
            SqlDataAdapter Order = new SqlDataAdapter(request, connectionString);
            DataTable table = new DataTable();
            Order.Fill(table);
            naibzakaztovar_dgv.DataSource = table;

            naibzakaztovar_dgv.Columns["Nazvanie"].HeaderText = "Наименование продукта";
            naibzakaztovar_dgv.Columns["FREC"].HeaderText = "Количество заказов";
        }

        void updateNaimOftenDGV()
        {
            var date_from = naimoften_from_timepicker.Value;
            var date_to = naimoften_to_timepicker.Value;

            var request = @"SELECT TOP 10 Nazvanie, COUNT(Nazvanie) AS FREC FROM InfoTovar
                                JOIN SaveInfo ON InfoTovar.Id = SaveInfo.id_info
                                JOIN NakladnieSave ON NakladnieSave.Id = SaveInfo.id_nakladS
                                WHERE NakladnieSave.Data BETWEEN '" + date_from.ToString("yyyy-MM-dd") + "' AND '" + date_to.ToString("yyyy-MM-dd")
                                + "' GROUP BY Nazvanie ORDER BY FREC";
            SqlDataAdapter Order = new SqlDataAdapter(request, connectionString);
            DataTable table = new DataTable();
            Order.Fill(table);
            naimoften_dgv.DataSource = table;

            naimoften_dgv.Columns["Nazvanie"].HeaderText = "Наименование продукта";
            naimoften_dgv.Columns["FREC"].HeaderText = "Количество заказов";
        }

        void updateNaimProfitDGV()
        {
            var date_from = naimProfit_from_timepicker.Value;
            var date_to = naimProfit_to_timepicker.Value;

            var request = @"SELECT TOP 10 Nazvanie, SUM(Price * kol) AS cena FROM InfoTovar
                                JOIN SaveInfo ON InfoTovar.Id = SaveInfo.id_info
                                JOIN NakladnieSave ON NakladnieSave.Id = SaveInfo.id_nakladS
                                WHERE NakladnieSave.Data BETWEEN '" + date_from.ToString("yyyy-MM-dd") + "' AND '" + date_to.ToString("yyyy-MM-dd")  + "' GROUP BY[Nazvanie] ORDER BY cena";

            SqlDataAdapter Order = new SqlDataAdapter(request, connectionString);
            DataTable table = new DataTable();
            Order.Fill(table);
            naimpribtovar_dgv.DataSource = table;

            naimpribtovar_dgv.Columns["Nazvanie"].HeaderText = "Наименование продукта";
            naimpribtovar_dgv.Columns["cena"].HeaderText = "Прибыль с продукта";
        }

        void updateProfitClientDGV()
        {
            var request = @"SELECT TOP 10 [Person], SUM([Summ]) FROM [NakladnieSave] 
                                 GROUP BY [Person] ORDER BY SUM([Summ]) DESC";
            SqlDataAdapter Order = new SqlDataAdapter(request, connectionString);
            DataTable Clienttable = new DataTable();
            Order.Fill(Clienttable);
            naibpribclient_dgv.DataSource = Clienttable;

            naibpribclient_dgv.Columns["Person"].HeaderText = "Клиент";
            naibpribclient_dgv.Columns["Column1"].HeaderText = "Сумма заказов";
        }

        private void OtdelMarketinga_Load(object sender, EventArgs e)
        {
            updateNaibOftenDGV();
            updateNaimOftenDGV();
            updateNaimProfitDGV();
            updateProfitClientDGV();
        }

        private void show_table_oftenorder_Click(object sender, EventArgs e)
        {
            updateNaibOftenDGV();
        }

        private void show_table_naimoften_button_Click(object sender, EventArgs e)
        {
            updateNaimOftenDGV();
        }

        private void danieClick_Click(object sender, EventArgs e)
        {
            updateNaimProfitDGV();
        }
    }
}
