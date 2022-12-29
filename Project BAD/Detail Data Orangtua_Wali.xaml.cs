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
    /// Interaction logic for Detail_Data_Orangtua_Wali.xaml
    /// </summary>
    public partial class Detail_Data_Orangtua_Wali : Window
    {
        SPSBEntities1 _db = new SPSBEntities1();

        string id_ayah1;
        string id_ibu1;
        string id_wali1;
        public Detail_Data_Orangtua_Wali(int id_ayah, int id_ibu, int id_wali)
        {
            InitializeComponent();
            id_ayah1 = id_ayah;
            id_ibu1 = id_ibu;
            id_wali1 = id_wali;
            tampilDetailOrtu();


        }
        private void tampilDetailOrtu()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLOCALDB;Initial Catalog=SPSB;Integrated Security=True");
            con.Open();

            string query = "SELECT nama_ayah from ayah WHERE id_ayah=@id_ayah";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id_ayah", id_ayah1);
            int namaAyah = Convert.ToInt32(cmd.ExecuteScalar());

            string query1 = "SELECT nik_ayah from ayah WHERE id_ayah=@id_ayah";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.AddWithValue("@id_ayah", id_ayah1);
            String nikAyah = Convert.ToString(cmd1.ExecuteScalar());

            string query2 = "SELECT tanggal_lahir_ayah from ayah WHERE id_ayah=@id_ayah";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.AddWithValue("@id_ayah", id_ayah1);
            String tglAyah = Convert.ToString(cmd2.ExecuteScalar());

            string query3 = "SELECT alamat_ayah from ayah WHERE id_ayah=@id_ayah";
            SqlCommand cmd3 = new SqlCommand(query3, con);
            cmd3.CommandType = CommandType.Text;
            cmd3.Parameters.AddWithValue("@id_ayah", id_ayah1);
            String altAyah = Convert.ToString(cmd3.ExecuteScalar());

            string query4 = "SELECT pekerjaan_ayah from ayah WHERE id_ayah=@id_ayah";
            SqlCommand cmd4 = new SqlCommand(query4, con);
            cmd4.CommandType = CommandType.Text;
            cmd4.Parameters.AddWithValue("@id_ayah", id_ayah1);
            String pkjAyah = Convert.ToString(cmd4.ExecuteScalar());

            string query5 = "SELECT nama_ibu from ibu WHERE id_ibu=@id_ibu";
            SqlCommand cmd5 = new SqlCommand(query5, con);
            cmd5.CommandType = CommandType.Text;
            cmd5.Parameters.AddWithValue("@id_ibu", id_ibu1);
            int namaIbu = Convert.ToInt32(cmd5.ExecuteScalar());

            string query6 = "SELECT nik_ibu from ibu WHERE id_ibu=@id_ibu";
            SqlCommand cmd6 = new SqlCommand(query6, con);
            cmd6.CommandType = CommandType.Text;
            cmd6.Parameters.AddWithValue("@id_ibu", id_ibu1);
            String nikIbu = Convert.ToString(cmd6.ExecuteScalar());

            string query7 = "SELECT tanggal_lahir_ibu from ibu WHERE id_ibu=@id_ibu";
            SqlCommand cmd7 = new SqlCommand(query7, con);
            cmd7.CommandType = CommandType.Text;
            cmd7.Parameters.AddWithValue("@id_ibu", id_ibu1);
            String tglIbu = Convert.ToString(cmd7.ExecuteScalar());

            string query8 = "SELECT alamat_ibu from ibu WHERE id_ibu=@id_ibu";
            SqlCommand cmd8 = new SqlCommand(query8, con);
            cmd8.CommandType = CommandType.Text;
            cmd8.Parameters.AddWithValue("@id_ibu", id_ibu1);
            String altIbu = Convert.ToString(cmd8.ExecuteScalar());

            string query9 = "SELECT pekerjaan_ibu from ibu WHERE id_ibu=@id_ibu";
            SqlCommand cmd9 = new SqlCommand(query9, con);
            cmd9.CommandType = CommandType.Text;
            cmd9.Parameters.AddWithValue("@id_ibu", id_ibu1);
            String pkjIbu = Convert.ToString(cmd9.ExecuteScalar());

            string query10 = "SELECT nama_wali from wali WHERE id_wali=@id_wali";
            SqlCommand cmd10 = new SqlCommand(query10, con);
            cmd10.CommandType = CommandType.Text;
            cmd10.Parameters.AddWithValue("@id_wali", id_wali1);
            int namaWali = Convert.ToInt32(cmd10.ExecuteScalar());

            string query11 = "SELECT nik_wali from wali WHERE id_wali=@id_wali";
            SqlCommand cmd11 = new SqlCommand(query11, con);
            cmd11.CommandType = CommandType.Text;
            cmd11.Parameters.AddWithValue("@id_wali", id_wali1);
            String nikWali = Convert.ToString(cmd11.ExecuteScalar());

            string query12 = "SELECT tanggal_lahir_wali from wali WHERE id_wali=@id_wali";
            SqlCommand cmd12 = new SqlCommand(query12, con);
            cmd12.CommandType = CommandType.Text;
            cmd12.Parameters.AddWithValue("@id_wali", id_wali1);
            String tglWali = Convert.ToString(cmd12.ExecuteScalar());

            string query13 = "SELECT alamat_wali from wali WHERE id_wali=@id_wali";
            SqlCommand cmd13 = new SqlCommand(query13, con);
            cmd13.CommandType = CommandType.Text;
            cmd13.Parameters.AddWithValue("@id_wali", id_wali1);
            String altWali = Convert.ToString(cmd13.ExecuteScalar());

            string query14 = "SELECT pekerjaan_wali from wali WHERE id_wali=@id_wali";
            SqlCommand cmd14 = new SqlCommand(query14, con);
            cmd14.CommandType = CommandType.Text;
            cmd14.Parameters.AddWithValue("@id_wali", id_wali1);
            String pkjWali = Convert.ToString(cmd14.ExecuteScalar());


        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
