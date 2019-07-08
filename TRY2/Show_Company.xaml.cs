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
using MySql.Data;
using MySql.Data.MySqlClient;
using TRY2.Show_acceptance_rate;
using TRY2.DBC;

namespace TRY2
{

    public partial class Show_Company : Window
    {
       

        public Show_Company(int level,string id)
        {
            InitializeComponent();
           

            Calculate_Rate calculate_Rate = new Calculate_Rate(level,id);

            result.Content= calculate_Rate.Result();


     

        }

      

    }
}
