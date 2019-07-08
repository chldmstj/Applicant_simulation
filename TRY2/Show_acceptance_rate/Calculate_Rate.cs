using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TRY2.DBC;

namespace TRY2.Show_acceptance_rate
{
   public class Calculate_Rate 
    {

        public int Applicant_Level;
        public string Id = "";
        DBc applicant = new DBc();
        CompanyT company = new CompanyT();
        string resp;
        public Calculate_Rate (int level,string id)
        {
            Applicant_Level = level;
            Id = id;
          //  Result();
        }

        public string Result()
        {
            int applicant_id = company.Applicant_num(Id) + 1;
            string res = applicant.Insert_applicant_information(applicant_id, Applicant_Level, Id);
            company.Setapplicant_num(Id);
            int rank = applicant.Applicant_rank(Applicant_Level, Id);
            
            if (rank <= Math.Ceiling(applicant_id * 0.3)) resp = "90%";
            else if (Math.Ceiling(applicant_id * 0.6) >= rank && rank > Math.Ceiling(applicant_id * 0.3)) resp = "50%";
            else if (Math.Truncate(applicant_id * 0.9) < rank) resp = "30% 미만";
            else resp = "예측 불가(DB 부족)";
            string result = "지원자" + applicant_id + "명 중 " + rank + "등 으로 합격률은" + resp + " 입니다.";
            return result;
        }










        //public string Acceptance_Rate_ID
        //{
        //    get { return (string)GetValue(Acceptance_Rate_IDProperty); }
        //    set { SetValue(Acceptance_Rate_IDProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for Acceptance_Rate_ID.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty Acceptance_Rate_IDProperty =
        //    DependencyProperty.Register("Acceptance_Rate_ID", typeof(string), typeof(Calculate_Rate), new PropertyMetadata(0));





        /////////////////////////////////////////////////////
        /////


        //public int Acceptance_Rate_Level
        //{
        //    get { return (int)GetValue(Acceptance_Rate_LevelProperty); }
        //    set { SetValue(Acceptance_Rate_LevelProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for Acceptance_Rate_Level.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty Acceptance_Rate_LevelProperty =
        //    DependencyProperty.Register("Acceptance_Rate_Level", typeof(int), typeof(Calculate_Rate), new PropertyMetadata(0));



    }
}
