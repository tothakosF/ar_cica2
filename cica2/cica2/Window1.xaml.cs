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

namespace cica2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void jatakB_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.regiojatek.hu/blog/download/tarsasjatek/51466_Robban%C3%B3_cic%C3%A1k_k%C3%A1rtyaj%C3%A1t%C3%A9k_j%C3%A1t%C3%A9kszab%C3%A1ly.pdf");
        }

        private void kezdB_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
