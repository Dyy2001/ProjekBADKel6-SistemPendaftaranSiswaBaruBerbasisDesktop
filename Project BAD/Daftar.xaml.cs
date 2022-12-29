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
    /// Interaction logic for Daftar.xaml
    /// </summary>
    public partial class Daftar : Window
    {

        SPSBEntities1 _db = new SPSBEntities1();

        public Daftar()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            admin newAdmin = new admin()
            {
                username = txtNama.Text,
                email = txtEmail.Text,
                no_hp = txtNohp.Text,
                password = txtPass.Text
            };
            _db.admins.Add(newAdmin);
            _db.SaveChanges();
            _db.admins.ToList();

            string email = txtEmail.Text;

            Info_Pengguna info = new Info_Pengguna(email);
            info.Show();
            this.Close();
        }
    }
}