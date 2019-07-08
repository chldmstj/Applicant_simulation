using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRY2.DBC
{
   public class CompanyT
    {
        public MySqlConnection conn = null;
        public CompanyT()
        {
            // String strConn = "Server=right.jbnu.ac.kr:3306;Database=A201514800;Uid=A201514800;Pwd=chldmstj016!;";
            String strConn = "Server=localhost;Database=windowp;Uid=root;Pwd=chldmstj016!";
            //  String strConn = " Data Source = 210.117.134.131,1433; Network Library = DBMSSOCN; Initial Catalog = windowp; User ID = root; Password = chldmstj016!;";
            //String strConn = " Data Source = right.jbnu.ac.kr,3306; Network Library = DBMSSOCN; Initial Catalog = windowp; User ID = root; Password = chldmstj016!;";
            conn = new MySqlConnection(strConn);
            

        }

        public void Insert_company_information(string id, int applicant_num)
        {
            string s = "err";
          
            try
            {
                
                DataSet ds = new DataSet();

                //MySqlDataAdapter 클래스를 이용하여 비연결 모드로 데이타 가져오기
                string sql = "SELECT id, applicant_num FROM company where id='" + id + "'";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "company");
                
                if (ds.Tables.Count > 0)
                {

                    foreach (DataRow r in ds.Tables[0].Rows)
                    {
                       s = r["applicant_num"].ToString();
                    
                    }

                    

                }
                
                if (s == "err")
                {
                    conn.Open();
                    String sqls = "INSERT INTO company (id, applicant_num) " +
                                    "VALUES ('" + id + "',0)";

                    MySqlCommand cmd = new MySqlCommand(sqls, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                   // s= "insert";
                }

              
               
              //applicant_num = Int32.Parse(s);

            }

            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
               // s = e.StackTrace;
            }

         //   return s;
        }

        public void Setapplicant_num (string id)
        {
            try
            {
                conn.Open();
                String sql = "update company set applicant_num = applicant_num+1 where id='"+id+"'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

        }

        public int Applicant_num(string id)
        {
            string s = null;
            int applicant_num = 0;

            try
            {
                DataSet ds = new DataSet();

                //MySqlDataAdapter 클래스를 이용하여 비연결 모드로 데이타 가져오기
                string sql = "SELECT applicant_num FROM company where id='" + id + "'";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "company");
                    
                if (ds.Tables.Count > 0)
                {

                    foreach (DataRow r in ds.Tables[0].Rows)
                    {
                        s = r["applicant_num"].ToString();

                    }
                }
                applicant_num = Int32.Parse(s);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                applicant_num = 1;
            }

            return applicant_num;

        }

    }
}
