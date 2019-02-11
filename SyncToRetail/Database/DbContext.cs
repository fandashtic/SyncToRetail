using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncToRetail
{
    public class DbContext
    {

        public static List<Tax> GetTax()
        {
            try
            {
                List<Tax> list = new List<Tax>();

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("select * from Tax With (NOLOCK)", connection);
                    cmd.CommandTimeout = 0;
                    cmd.CommandType = CommandType.Text;
                    DataSet ds = new DataSet();
                    //cmd.Parameters.AddWithValue("@CentreId", centreId);                        
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    if (sda != null)
                    {
                        sda.Fill(ds);
                    }

                    if (ds != null && ds.Tables.Count > 0)
                    {
                        DataTable dtTable = ds.Tables[0];
                        list = Helper.DataTableToList<Tax>(dtTable);
                    }

                }

                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<User> GetUser()
        {
            try
            {
                List<User> list = new List<User>();
                DataSet ds = new DataSet();
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("select * from Users With (NOLOCK)", connection);
                    cmd.CommandTimeout = 0;
                    cmd.CommandType = CommandType.Text;                    
                    //cmd.Parameters.AddWithValue("@CentreId", centreId);                        
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    if (sda != null)
                    {
                        sda.Fill(ds);
                    }                    
                }
                if(ds != null && ds.Tables.Count > 0)
                {
                    DataTable dtTable = ds.Tables[0];
                    list = Helper.DataTableToList<User>(dtTable);
                }

                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

