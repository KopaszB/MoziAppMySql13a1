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
using MySqlConnector;
using System.Data;

namespace MoziAppMySql13a1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string connString = "server=localhost;user=root;password=;database=mozi;";
        List<string> korhatar = new List<string>() {"Válassz...","KN","12","16","18"};
        List<string> mufajok = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            cbx_korhatar.ItemsSource = korhatar;
            cbx_korhatar.SelectedIndex = 0;
            mufajfeltolt();
            cbx_mufaj.ItemsSource = mufajok;
            cbx_mufaj.SelectedIndex = 0;
        }

        private void mufajfeltolt()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string sqlMufaj = "SELECT DISTINCT mufaj FROM filmek;";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sqlMufaj, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    mufajok.Add("Válassz...");
                    foreach (DataRow sor in dt.Rows)
                    {
                        mufajok.Add(sor["mufaj"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba történt!");
                }
            }
        }

        private void btn_hozzaad_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_modosit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_torles_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_frissites_Click(object sender, RoutedEventArgs e)
        {

        }

        private void rbn_osszes_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void dg_filmek_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
