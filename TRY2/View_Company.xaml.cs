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
using TRY2.API;
using TRY2.DBC;
using TRY2.Show_acceptance_rate;

namespace TRY2
{
    /// <summary>
    /// View_Company.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class View_Company : Window
    {
        public int lv = 0;
        public List<Company> companies = new List<Company>();
        public View_Company(int level,string job_category)
        {
            InitializeComponent();
            lv = level;
            Parsing parsing = new Parsing();
           
            companies = parsing.Parsing_Title(job_category);
            lvControl.ItemsSource = companies;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lv == 0) MessageBox.Show("사용자 정보를 입력하세요");
            else
            {
              
                Company company = new Company();
                company = (Company)lvControl.Items[lvControl.SelectedIndex];
                

                CompanyT companyT = new CompanyT();
               companyT.Insert_company_information(company.Id, 0);
                Calculate_Rate calculate_Rate = new Calculate_Rate(lv, company.Id);
                MessageBox.Show(calculate_Rate.Result());
                //Show_Company show_Company = new Show_Company(lv, company.Id);
                //show_Company.Show();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LvControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Company company = new Company();
            company = companies[lvControl.SelectedIndex];
            TITLE.Text = company.Name;
            Content.Text = "  공고명: " + company.Title + "\n  회사위치: " + company.Location + "\n  업무: " + company.Job_category +
                "\n  경력: " + company.Experience_level + "\n  요구학력: " + company.Required_education + "\n  연봉: " + company.Salary;
         
        }
    }
}
