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
    /// intention_select.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class intention_select : Page
    {
        public intention_select()
        {
            InitializeComponent();
        }

        private void Button_Click_YES(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new information_input());
        }

        private void Button_Click_NO(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new search(0));
        }
    }
}
