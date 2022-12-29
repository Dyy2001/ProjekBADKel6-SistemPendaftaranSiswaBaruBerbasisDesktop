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
    /// Interaction logic for Detail_asal_sekolah.xaml
    /// </summary>
    public partial class Detail_asal_sekolah : Window
    {
        SPSBEntities1 _db = new SPSBEntities1();
        string id_asal_sekolah1;
        public Detail_asal_sekolah()
        {
            InitializeComponent();
            id_asal_sekolah1 = id_asal_sekolah;
            DetailAsalSekolah();
        }
        private void DetailAsalSekolah()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLOCALDB;Initial Catalog=SPSB;Integrated Security=True");
            con.Open();

            string query = "SELECT asal_sekolah from asal_sekolah WHERE id_asal_sekolah=@id_asal_sekolah";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id_asal_sekolah", id_asal_sekolah1);
            int asalSekolah = Convert.ToInt32(cmd.ExecuteScalar());

            string query1 = "SELECT npsn from asal_sekolah WHERE id_asal_sekolah=@id_asal_sekolah";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.AddWithValue("@id_asal_sekolah", id_asal_sekolah1);
            String npsn = Convert.ToString(cmd1.ExecuteScalar());

            string query2 = "SELECT alamat_sekolah from asal_sekolah WHERE id_asal_sekolah=@id_asal_sekolah";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.AddWithValue("@id_asal_sekolah", id_asal_sekolah1);
            String altSekolah = Convert.ToString(cmd2.ExecuteScalar());

            string query3 = "SELECT kecamatan from asal_sekolah WHERE id_asal_sekolah=@id_asal_sekolah";
            SqlCommand cmd3 = new SqlCommand(query3, con);
            cmd3.CommandType = CommandType.Text;
            cmd3.Parameters.AddWithValue("@id_asal_sekolah", id_asal_sekolah1);
            String kec = Convert.ToString(cmd3.ExecuteScalar());

            string query4 = "SELECT kabupaten_kota from asal_sekolah WHERE id_asal_sekolah=@id_asal_sekolah";
            SqlCommand cmd4 = new SqlCommand(query4, con);
            cmd4.CommandType = CommandType.Text;
            cmd4.Parameters.AddWithValue("@id_asal_sekolah", id_asal_sekolah1);
            String kota = Convert.ToString(cmd4.ExecuteScalar());

            string query5 = "SELECT provinsi from asal_sekolah WHERE id_asal_sekolah=@id_asal_sekolah";
            SqlCommand cmd5 = new SqlCommand(query5, con);
            cmd5.CommandType = CommandType.Text;
            cmd5.Parameters.AddWithValue("@id_asal_sekolah", id_asal_sekolah1);
            int prov = Convert.ToInt32(cmd5.ExecuteScalar());
        }
    }
}
