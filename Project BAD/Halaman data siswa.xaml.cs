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

namespace Project_BAD
{
    /// <summary>
    /// Interaction logic for Halaman_data_siswa.xaml
    /// </summary>
    public partial class Halaman_data_siswa : Window
    {
        public Halaman_data_siswa()
        {
            InitializeComponent();
            tampil();
        }
        private void tampil()
        {

        }

        private void Buttontbh(object sender, RoutedEventArgs e)
        {
            Tambah_Data_Siswa tbhDataSisawa = new Tambah_Data_Siswa();
            tbhDataSisawa.Show();
            this.Close();
        }

        private void Buttonmenu(object sender, RoutedEventArgs e)
        {
            Halam_Utama halUtama = new Halam_Utama();
            halUtama.Show();
            this.Close();
        }
        private void btnEdit(object sender, RoutedEventArgs e)
        {

        }
        private void btnDetail(object sender, RoutedEventArgs e)
        {

        }
        private void btnHapus(object sender, RoutedEventArgs e)
        {

        }
    }
}
