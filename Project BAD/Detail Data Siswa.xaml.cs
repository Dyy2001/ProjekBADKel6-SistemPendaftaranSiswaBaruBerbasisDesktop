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
    /// Interaction logic for Detail_Data_Siswa.xaml
    /// </summary>
    public partial class Detail_Data_Siswa : Window
    {
        SPSBEntities1 _db = new SPSBEntities1();

        string id_siswa1;
        public Detail_Data_Siswa()
        {
            InitializeComponent();
            id_siswa1 = id_siswa;
            tampilDataSiswa();
        }
        private void tampilDataSiswa()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLOCALDB;Initial Catalog=SPSB;Integrated Security=True");
            con.Open();

            string query = "SELECT nama_siswa from siswa WHERE id_siswa=@id_siswa";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id_siswa", id_siswa1);
            int namaSiswa = Convert.ToInt32(cmd.ExecuteScalar());

            string query1 = "SELECT nisn from siswa WHERE id_siswa=@id_siswa";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.AddWithValue("@id_siswa", id_siswa1);
            String nisn = Convert.ToString(cmd1.ExecuteScalar());

            string query2 = "SELECT nik from siswa WHERE id_siswa=@id_siswa";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.AddWithValue("@id_siswa", id_siswa1);
            String nik = Convert.ToString(cmd2.ExecuteScalar());

            string query3 = "SELECT tahun_ajaran from siswa WHERE id_siswa=@id_siswa";
            SqlCommand cmd3 = new SqlCommand(query3, con);
            cmd3.CommandType = CommandType.Text;
            cmd3.Parameters.AddWithValue("@id_siswa", id_siswa1);
            String tahun = Convert.ToString(cmd3.ExecuteScalar());

            string query4 = "SELECT asal_sekolah from siswa WHERE id_siswa=@id_siswa";
            SqlCommand cmd4 = new SqlCommand(query4, con);
            cmd4.CommandType = CommandType.Text;
            cmd4.Parameters.AddWithValue("@id_siswa", id_siswa1);
            String asalsekolah = Convert.ToString(cmd4.ExecuteScalar());

            string query5 = "SELECT ayah from siswa WHERE id_siswa=@id_siswa";
            SqlCommand cmd5 = new SqlCommand(query5, con);
            cmd5.CommandType = CommandType.Text;
            cmd5.Parameters.AddWithValue("@id_siswa", id_siswa1);
            int ayah = Convert.ToInt32(cmd5.ExecuteScalar());

            string query6 = "SELECT ibu from siswa WHERE id_siswa=@id_siswa";
            SqlCommand cmd6 = new SqlCommand(query6, con);
            cmd6.CommandType = CommandType.Text;
            cmd6.Parameters.AddWithValue("@id_siswa", id_siswa1);
            String ibu = Convert.ToString(cmd6.ExecuteScalar());

            string query7 = "SELECT wali from siswa WHERE id_siswa=@id_siswa";
            SqlCommand cmd7 = new SqlCommand(query7, con);
            cmd7.CommandType = CommandType.Text;
            cmd7.Parameters.AddWithValue("@id_siswa", id_siswa1);
            String wali = Convert.ToString(cmd7.ExecuteScalar());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
