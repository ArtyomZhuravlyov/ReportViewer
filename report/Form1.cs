using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace report
{
    public partial class Form1 : Form
    {
        ReportViwer report;  //CREATE report window
        public Form1()
        {

            InitializeComponent();
            //ConnectWithDB().GetAwaiter();
           // string path = Path.GetFileName();
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //MessageBox.Show("Подключение открыто");
                var a = Convert.ToString(Guid.NewGuid());
               // MessageBox.Show($"Подключение открыто {a}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void  button1_Click(object sender, EventArgs e)
        {
            #region проверка что report открыт и не удалён
            if (report!=null && report.Visible)
                return;
            else if (report != null && report.IsDisposed)
                report = new ReportViwer();
            #endregion


            report = new ReportViwer();
            report.Name = "Report";
            Loading loading1 = new Loading();
            //await loading1.Show();
            try
            {
             //    await Task.Run(() => loading1.Show());
                //loading1.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //await Task.Run(() => report.Show());
            // await Task.Run(() => report.Show());
            report.Show();
        }


        //private static async Task ConnectWithDB()
        //{
        //    string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        await connection.OpenAsync();
        //        MessageBox.Show("Подключение открыто");
        //    }

        //}

    }
}
