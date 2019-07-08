using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRY2.DBC
{
  public class DBc
    {
       public MySqlConnection conn=null;
        public DBc()
            {
            //String strConn = "Server=right.jbnu.ac.kr:3306;Database=A201514800;Uid=A201514800;Pwd=chldmstj016!;";
             String strConn = "Server=localhost;Database=windowp;Uid=root;Pwd=chldmstj016!";
            // String strConn = " Data Source = 210.117.134.131,1433; Network Library = DBMSSOCN; Initial Catalog = windowp; User ID = root; Password = chldmstj016!;";
           // String strConn = " Data Source = right.jbnu.ac.kr,3306; Network Library = DBMSSOCN; Initial Catalog = windowp; User ID = root; Password = chldmstj016!;";
            conn = new MySqlConnection(strConn);

            }

        public string Insert_applicant_information(int applicant_id,int level,string companyid)
        {
            
            string id = applicant_id.ToString();
            try
            {
                //String strConn = "Server=localhost;Database=windowp;Uid=root;Pwd=chldmstj016!;";
                //conn = new MySqlConnection(strConn);
                conn.Open();
                String sql = "INSERT INTO applicant (id, level, companyid) " +
                                "VALUES ('"+id+"', "+level+",'"+companyid+"')";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "ok";
            }

            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return "fail";
            }


       
        }

        public int SelectData(string id)
        {
            string s = null;
            int applicant_num=0;

            try
            {
                DataSet ds = new DataSet();

                //MySqlDataAdapter 클래스를 이용하여 비연결 모드로 데이타 가져오기
                string sql = "SELECT applicant_num FROM company where id='"+id+"'";
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

        public int Applicant_rank(int applicant_level,string id)
        {
            string s = null;
            int rank = 0;
            
            try
            {
                DataSet ds = new DataSet();

                //MySqlDataAdapter 클래스를 이용하여 비연결 모드로 데이타 가져오기
                string sql = "select count(*) as cnt from(select * from applicant where CompanyID = '"+id+"')CNT where level > "+applicant_level;
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "company");

                if (ds.Tables.Count > 0)
                {

                    foreach (DataRow r in ds.Tables[0].Rows)
                    {
                        s =  r["cnt"].ToString();

                    }
                }
                rank = Int32.Parse(s);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                rank = 50;
            }

            return rank+1;

        }
    }
}
