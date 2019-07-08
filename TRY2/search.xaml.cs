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
    /// search.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class search : Page
    {
        private int Level;
        public search(int level)
        {
            InitializeComponent();
            // MessageBox.Show(level.ToString());
            Level = level;
        }

        private void search_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Search(object sender, RoutedEventArgs e)
        {
            selectnameproperty = list.Text;

            if (Web_Master.IsSelected == true)
            {
                code.Content = "401";
            }

            if (Server_Network_Security.IsSelected == true)
            {
                code.Content = "402";
            }

            if (Web_Planning.IsSelected == true)
            {
                code.Content = "403";
            }

            if (Web_Development.IsSelected == true)
            {
                code.Content = "404";
            }

            if (Game.IsSelected == true)
            {
                code.Content = "405";
            }

            if (Content_Site_Operation.IsSelected == true)
            {
                code.Content = "406";
            }

            if (Application_Development.IsSelected == true)
            {
                code.Content = "407";
            }

            if (System_Development.IsSelected == true)
            {
                code.Content = "408";
            }

            if (ERP_System_Analysis_and_Design.IsSelected == true)
            {
                code.Content = "409";
            }

            if (Communication_Mobile.IsSelected == true)
            {
                code.Content = "410";
            }

            if (Hardware_Software.IsSelected == true)
            {
                code.Content = "411";
            }

            if (Web_Design.IsSelected == true)
            {
                code.Content = "412";
            }

            if (Publication_and_UI_Development.IsSelected == true)
            {
                code.Content = "413";
            }

            if (Video_Editing_Codecs.IsSelected == true)
            {
                code.Content = "414";
            }

            if (IT_Design_Computer_Education.IsSelected == true)
            {
                code.Content = "415";
            }

            if (Database_and_DBAs.IsSelected == true)
            {
                code.Content = "416";
            }

            if (AI_Bigdata.IsSelected == true)
            {
                code.Content = "417";
            }

            View_Company view_Company = new View_Company(Level, code.Content.ToString());
            view_Company.Show();
        }



        public string selectnameproperty
        {
            get { return (string)GetValue(selectnamepropertyProperty); }
            set { SetValue(selectnamepropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for selectnameproperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty selectnamepropertyProperty =
            DependencyProperty.Register("selectnameproperty", typeof(string), typeof(search), new PropertyMetadata(new PropertyChangedCallback(selectnamechange)));

        private static void selectnamechange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            search selectname = d as search;
            string oldselect = (string)e.OldValue;

            selectname.selectinfotextblock.Text = oldselect;
        }

    }
}
