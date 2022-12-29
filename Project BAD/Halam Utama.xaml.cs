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
    /// Interaction logic for Halam_Utama.xaml
    /// </summary>
    public partial class Halam_Utama : Window
    {
        public Halam_Utama()
        {
            InitializeComponent();
        }
        private void BtnData(object sender, RoutedEventArgs e)
        {
            Halaman_data_siswa halDataSiswa = new Halaman_data_siswa();
            halDataSiswa.Show();
            this.Close();
        }

        private void BtnStat(object sender, RoutedEventArgs e)
        {
            halam_Statistic halStat = new halam_Statistic();
            halStat.Show();
            this.Close();
        }

        private void BtnLogout(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
