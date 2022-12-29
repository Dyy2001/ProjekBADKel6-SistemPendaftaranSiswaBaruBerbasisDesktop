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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace Project_BAD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLOCALDB;Initial Catalog=SPSB;Integrated Security=True;Pooling=False");
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string query = "SELECT COUNT(1) from admin WHERE Username=@Usename AND Password=@Password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Usename", txtNama.Text);
                cmd.Parameters.AddWithValue("@Password", txtPass.Text);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 1)
                {
                    Halam_Utama halUtama = new Halam_Utama();
                    halUtama.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username atau Password Salah");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Daftar Daf = new Daftar();
            Daf.Show();
            this.Close();
        }
    }
}