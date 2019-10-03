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

namespace WpfApplication12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int nhap = 0;
        int tong = 0;
        int tongchan = 0;
        int tongle = 0;
        int s = 0;
        int n;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Tinh_Click_1(object sender, RoutedEventArgs e)
        {


            int nhap = Convert.ToInt32(lblNhap.Text);
            int tong = 0;
            int tongchan = 0;
            int tongle = 0;

            if (tbxTong.IsChecked == true)
            {
                for (int i = 0; i <= nhap; i++)
                {
                    tong= tong + i;
                }
                tbxTong.Text = tong.ToString();
            }
            if (tbxTongchan.IsChecked == true)
            {
                for (int i = 0; i <= nhap; i++)
                    if (i % 2 == 0)
                    {
                        tongchan += i;
                        tbxTongchan.Text = tongchan.ToString();
                    }
            }
            if (tbxTongle.IsChecked == true)
            {
                for (int i = 0; i <= nhap; i++)
                    if (i % 2 != 0)
                    {
                        tongle += i;
                        tbxTongle.Text = tongle.ToString();
                    }
            }

        }
       

        private void r1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void rc_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void rl_Checked(object sender, RoutedEventArgs e)
        {


        }

        private void btnhuy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}