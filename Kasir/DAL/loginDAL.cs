using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasir
{
    class loginDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["Kasir.Properties.Settings.dbkasirConnectionString"].ConnectionString;

        public bool loginCheck(loginBLL l)
        {
            //Create a boolean and set its value to false and retrunt it

            bool isSuccess = false;

            //Connection to Database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //SQL Query to check login
                string sql = "select * from Pengguna where  username=@username AND password=@password" ;

                //Creatng Command to pass value
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@username", l.username);
                cmd.Parameters.AddWithValue("@password", l.password);
        

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
               
                adapter.Fill(dt);
                //Checkng the rows in DataTable
                if (dt.Rows.Count > 0)
                {
                    //Login Successfully
                    isSuccess = true;
                }
                else
                {
                    //login Failed
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public loginBLL getrole(string username)
        {
            loginBLL u = new loginBLL();
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                string sql = "select role from Pengguna where username = 'role' ";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    u.role = (dt.Rows[4]["role"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return u;
        }

    }
}
