using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace Project_BAD
{
    /// <summary>
    /// Interaction logic for Info_Pengguna.xaml
    /// </summary>
    public partial class Info_Pengguna : Window
    {
        SPSBEntities1 _db = new SPSBEntities1();

        string email1;
        string idadmin;


        public Info_Pengguna(string email)
        {
            InitializeComponent();

            email1 = email;

            tampil();
        }
        private void tampil()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLOCALDB;Initial Catalog=SPSB;Integrated Security=True");
            con.Open();

            string query = "SELECT id_admin from admin WHERE email=@email";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@email", email1);
            int id_admin = Convert.ToInt32(cmd.ExecuteScalar());

            string query1 = "SELECT username from admin WHERE email=@email";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.AddWithValue("@email", email1);
            String Nama = Convert.ToString( cmd1.ExecuteScalar());

            string query2 = "SELECT no_hp from admin WHERE email=@email";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.AddWithValue("@email", email1);
            String nohp = Convert.ToString(cmd2.ExecuteScalar());

            string query3 = "SELECT password from admin WHERE email=@email";
            SqlCommand cmd3 = new SqlCommand(query3, con);
            cmd3.CommandType = CommandType.Text;
            cmd3.Parameters.AddWithValue("@email", email1);
            String pass = Convert.ToString(cmd3.ExecuteScalar());


            lblNama.Content = Nama;
            lblEmail.Content = email1;
            lblNohp.Content = nohp;
            lblPass.Content = pass;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Halam_Utama halUtama = new Halam_Utama();
            halUtama.Show();
            this.Close();
        }
    }
}
