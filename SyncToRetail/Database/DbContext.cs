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
        #region MasterProcess

        public static List<Tax> GetTax()
        {
            List<Tax> list = new List<Tax>();
            try
            {
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
            }
            catch (Exception ex)
            {
                //throw ex;
            }
            return list;
        }

        public static List<User> GetUser()
        {
            List<User> list = new List<User>();
            try
            {
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
            }
            catch (Exception ex)
            {
                //throw ex;
            }
            return list;
        }

        public static List<Beat> GetBeat()
        {
            List<Beat> list = new List<Beat>();
            try
            {
                DataSet ds = new DataSet();
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("select * from Beat With (NOLOCK)", connection);
                    cmd.CommandTimeout = 0;
                    cmd.CommandType = CommandType.Text;
                    //cmd.Parameters.AddWithValue("@CentreId", centreId);                        
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    if (sda != null)
                    {
                        sda.Fill(ds);
                    }
                }
                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable dtTable = ds.Tables[0];
                    list = Helper.DataTableToList<Beat>(dtTable);
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }
            return list;
        }

        public static List<Customer> GetCustomer()
        {
            List<Customer> list = new List<Customer>();
            try
            {
                DataSet ds = new DataSet();
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("select * from Customer With (NOLOCK)", connection);
                    cmd.CommandTimeout = 0;
                    cmd.CommandType = CommandType.Text;
                    //cmd.Parameters.AddWithValue("@CentreId", centreId);                        
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    if (sda != null)
                    {
                        sda.Fill(ds);
                    }
                }
                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable dtTable = ds.Tables[0];
                    list = Helper.DataTableToList<Customer>(dtTable);
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }
            return list;
        }

        public static List<Product> GetProduct()
        {
            List<Product> list = new List<Product>();
            try
            {
                DataSet ds = new DataSet();
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("select * from Product With (NOLOCK)", connection);
                    cmd.CommandTimeout = 0;
                    cmd.CommandType = CommandType.Text;
                    //cmd.Parameters.AddWithValue("@CentreId", centreId);                        
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    if (sda != null)
                    {
                        sda.Fill(ds);
                    }
                }
                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable dtTable = ds.Tables[0];
                    list = Helper.DataTableToList<Product>(dtTable);
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }
            return list;
        }

        public static List<SalesMan> GetSalesMan()
        {
            List<SalesMan> list = new List<SalesMan>();
            try
            {
                DataSet ds = new DataSet();
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("select * from SalesMan With (NOLOCK)", connection);
                    cmd.CommandTimeout = 0;
                    cmd.CommandType = CommandType.Text;
                    //cmd.Parameters.AddWithValue("@CentreId", centreId);                        
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    if (sda != null)
                    {
                        sda.Fill(ds);
                    }
                }
                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable dtTable = ds.Tables[0];
                    list = Helper.DataTableToList<SalesMan>(dtTable);
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }
            return list;
        }

        public static List<SalesManBeat> GetSalesManBeat()
        {
            List<SalesManBeat> list = new List<SalesManBeat>();
            try
            {
                DataSet ds = new DataSet();
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("select * from SalesManBeat With (NOLOCK)", connection);
                    cmd.CommandTimeout = 0;
                    cmd.CommandType = CommandType.Text;
                    //cmd.Parameters.AddWithValue("@CentreId", centreId);                        
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    if (sda != null)
                    {
                        sda.Fill(ds);
                    }
                }
                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable dtTable = ds.Tables[0];
                    list = Helper.DataTableToList<SalesManBeat>(dtTable);
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }
            return list;
        }

        #endregion MasterProcess

        #region Purchase

        public static List<Purchase> GetPurchase()
        {
            List<Purchase> list = new List<Purchase>();
            try
            {
                DataSet ds = new DataSet();
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("select * from Purchase With (NOLOCK)", connection);
                    cmd.CommandTimeout = 0;
                    cmd.CommandType = CommandType.Text;
                    //cmd.Parameters.AddWithValue("@CentreId", centreId);                        
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    if (sda != null)
                    {
                        sda.Fill(ds);
                    }
                }
                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable dtTable = ds.Tables[0];
                    list = Helper.DataTableToList<Purchase>(dtTable);
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }
            return list;
        }

        #endregion Purchase

        #region Sales

        public static List<Sales> GetSales()
        {
            List<Sales> list = new List<Sales>();
            try
            {
                DataSet ds = new DataSet();
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("select * from Sales With (NOLOCK)", connection);
                    cmd.CommandTimeout = 0;
                    cmd.CommandType = CommandType.Text;
                    //cmd.Parameters.AddWithValue("@CentreId", centreId);                        
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    if (sda != null)
                    {
                        sda.Fill(ds);
                    }
                }
                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable dtTable = ds.Tables[0];
                    list = Helper.DataTableToList<Sales>(dtTable);
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }
            return list;
        }

        #endregion Sales

        #region Test
        public static List<Temp> GetTemp()
        {
            List<Temp> list = new List<Temp>();
            try
            {
                DataSet ds = new DataSet();
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GetTemp", connection);
                    cmd.CommandTimeout = 0;
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@CentreId", centreId);                        
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    if (sda != null)
                    {
                        sda.Fill(ds);
                    }
                }
                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable dtTable = ds.Tables[0];
                    List <Centres> Centres = new List<Centres>();
                    List<Users1> Users1 = new List<Users1>();
                    Centres = Helper.DataTableToList<Centres>(ds.Tables[0]);
                    Users1 = Helper.DataTableToList<Users1>(ds.Tables[1]);
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }
            return list;
        }
        #endregion Test

    }
}

