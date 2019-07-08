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

namespace TRY2
{
    /// <summary>
    /// information_input.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class information_input : Page
    {
        int score = 0;
        int prizenum1 = 0;
        int prizenum2 = 0;
        int prizenum3 = 0;

        public information_input()
        {
            InitializeComponent();
        }

        private void Accept(object sender, RoutedEventArgs e)
        {
            if (projectCombobox.Visibility == Visibility.Visible)
            {
                if (smallproject.IsSelected == true)
                {
                    score += 30;
                }
                if (middleproject.IsSelected == true)
                {
                    score += 40;
                }
                if (bigproject.IsSelected == true)
                {
                    score += 50;
                }


            }

            if (s1.IsChecked == true)
            {
                score += 10;
            }

            if (s2.IsChecked == true)
            {
                score += 8;
            }

            if (s3.IsChecked == true)
            {
                score += 6;
            }

            if (s4.IsChecked == true)
            {
                score += 4;
            }

            if (o1.IsChecked == true)
            {
                score += 10;
            }

            if (o2.IsChecked == true)
            {
                score += 30;
            }

            if (o3.IsChecked == true)
            {
                score += 50;
            }

            if (o4.IsChecked == true)
            {
                score += 80;
            }

            if (o5.IsChecked == true)
            {
                score += 120;
            }
            if (m2.IsChecked == true)
            {
                score -= 20;
            }

            if (t1.IsChecked == true)
            {
                score += 50;
            }

            if (t2.IsChecked == true)
            {
                score += 70;
            }

            if (t3.IsChecked == true)
            {
                score += 90;
            }

            if (t4.IsChecked == true)
            {
                score += 110;
            }

            if (t5.IsChecked == true)
            {
                score += 130;
            }

            if (ccna.IsChecked == true)
            {
                score += 50;
            }

            if (ccnp.IsChecked == true)
            {
                score += 50;
            }

            if (info0.IsChecked == true)
            {
                score += 30;
            }

            if (linux.IsChecked == true && linux1.IsSelected)
            {
                score += 50;
            }

            if (linux.IsChecked == true && linux2.IsSelected)
            {
                score += 30;
            }

            
            //this.NavigationService.Navigate(new Page3(),score); 페이지넘어가는것
            this.NavigationService.Navigate(new search(score), score);
        }

        private void s1_Checked_1(object sender, RoutedEventArgs e)
        {
        }

        private void s2_Checked_1(object sender, RoutedEventArgs e)
        {
        }

        private void s3_Checked_1(object sender, RoutedEventArgs e)
        {
        }

        private void s4_Checked_1(object sender, RoutedEventArgs e)
        {
        }

        private void o1_Checked_1(object sender, RoutedEventArgs e)
        {
        }

        private void o2_Checked_1(object sender, RoutedEventArgs e)
        {
        }

        private void o3_Checked_1(object sender, RoutedEventArgs e)
        {
        }

        private void o4_Checked_1(object sender, RoutedEventArgs e)
        {
        }

        private void o5_Checked_1(object sender, RoutedEventArgs e)
        {
        }

        private void m1_Checked_1(object sender, RoutedEventArgs e)
        {
        }

        private void m2_Checked_1(object sender, RoutedEventArgs e)
        {
        }

        private void m3_Checked_1(object sender, RoutedEventArgs e)
        {
        }

        private void t1_Checked_1(object sender, RoutedEventArgs e)
        {
        }

        private void t2_Checked_1(object sender, RoutedEventArgs e)
        {
        }

        private void t3_Checked_1(object sender, RoutedEventArgs e)
        {
        }

        private void t4_Checked_1(object sender, RoutedEventArgs e)
        {
        }

        private void t5_Checked_1(object sender, RoutedEventArgs e)
        {
        }

        private void t6_Checked_1(object sender, RoutedEventArgs e)
        {
        }

        private void ccna_Checked_1(object sender, RoutedEventArgs e)
        {
        }

        private void ccnp_Checked_1(object sender, RoutedEventArgs e)
        {
        }

        private void info0_Checked_1(object sender, RoutedEventArgs e)
        {
        }

        private void projecto_Checked_1(object sender, RoutedEventArgs e)
        {
            projectCombobox.Visibility = Visibility.Visible;
        }

        private void projectx_Checked_1(object sender, RoutedEventArgs e)
        {
            projectCombobox.Visibility = Visibility.Hidden;
        }

        private void Prizecombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void PrizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (indomestic.IsSelected == true)
            {
                score += Convert.ToInt32(Prizenumbox.Text) * 20;
                prizenum1 += Convert.ToInt32(Prizenumbox.Text);
            }
            if (inforeign.IsSelected == true)
            {
                score += Convert.ToInt32(Prizenumbox.Text) * 30;
                prizenum2 += Convert.ToInt32(Prizenumbox.Text);
            }
            if (inschool.IsSelected == true)
            {
                score += Convert.ToInt32(Prizenumbox.Text) * 10;
                prizenum3 += Convert.ToInt32(Prizenumbox.Text);
            }

            PrizeLabel.Content = "국내:" + prizenum1.ToString() + "국외:" + prizenum2.ToString() + "교내:" + prizenum3.ToString();
        }

        private void Prizenumbox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Prizenumbox.Text = "";
        }

        private void Resetbutton_Click(object sender, RoutedEventArgs e)
        {
            score = 0;
            prizenum1 = 0;
            prizenum2 = 0;
            prizenum3 = 0;
            PrizeLabel.Content =
                "국내:" + prizenum1.ToString() + "국외:" + prizenum2.ToString() + "교내:" + prizenum3.ToString();
        }


        private void linuxrank_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void info_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void linux_Checked_1(object sender, RoutedEventArgs e)
        {

        }


    }
}