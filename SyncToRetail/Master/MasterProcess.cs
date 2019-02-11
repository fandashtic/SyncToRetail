using Newtonsoft.Json;
using SyncToRetail.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncToRetail
{
    public class MasterProcess
    {
        #region Beat
        public static bool UploadBeat(List<Beat> list)
        {
            try
            {
                Dictionary<string, Beat> dataList = new Dictionary<string, Beat>();
                list.ForEach(l => {
                    dataList.Add(l.BeatID, l);
                });
                var json = JsonConvert.SerializeObject(dataList);
                FirebaseDB.UploadServices(json, "Beat");
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool GetBeat()
        {
            try
            {
                List<Beat> list = new List<Beat>();
                UploadBeat(list);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion Beat

        #region Customer
        public static bool UploadCustomer(List<Customer> list)
        {
            try
            {
                Dictionary<string, Customer> dataList = new Dictionary<string, Customer>();
                list.ForEach(l => {
                    dataList.Add(l.CustomerID, l);
                });
                var json = JsonConvert.SerializeObject(dataList);
                FirebaseDB.UploadServices(json, "Customer");
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool GetCustomer()
        {
            try
            {
                List<Customer> list = new List<Customer>();
                UploadCustomer(list);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion Customer

        #region Product
        public static bool UploadProduct(List<Product> list)
        {
            try
            {
                Dictionary<string, Product> dataList = new Dictionary<string, Product>();
                list.ForEach(l => {
                    dataList.Add(l.Product_Code, l);
                });
                var json = JsonConvert.SerializeObject(dataList);
                FirebaseDB.UploadServices(json, "Product");
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool GetProduct()
        {
            try
            {
                List<Product> list = new List<Product>();
                UploadProduct(list);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion Product

        #region SalesMan
        public static bool UploadSalesMan(List<SalesMan> list)
        {
            try
            {
                Dictionary<string, SalesMan> dataList = new Dictionary<string, SalesMan>();
                list.ForEach(l => {
                    dataList.Add(l.SalesmanID, l);
                });
                var json = JsonConvert.SerializeObject(dataList);
                FirebaseDB.UploadServices(json, "SalesMan");
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool GetSalesMan()
        {
            try
            {
                List<SalesMan> list = new List<SalesMan>();
                UploadSalesMan(list);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion SalesMan

        #region SalesManBeat
        public static bool UploadSalesManBeat(List<SalesManBeat> list)
        {
            try
            {
                Dictionary<string, SalesManBeat> dataList = new Dictionary<string, SalesManBeat>();
                list.ForEach(l => {
                    dataList.Add(l.SalesmanID + "_" + l.BeatID + "_" + l.CustomerID, l);
                });
                var json = JsonConvert.SerializeObject(dataList);
                FirebaseDB.UploadServices(json, "SalesManBeat");
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool GetSalesManBeat()
        {
            try
            {
                List<SalesManBeat> list = new List<SalesManBeat>();
                UploadSalesManBeat(list);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion SalesManBeat

        #region Tax
        public static bool UploadTax(List<Tax> list)
        {
            try
            {
                Dictionary<string, Tax> dataList = new Dictionary<string, Tax>();
                list.ForEach(l => {
                    dataList.Add(l.Tax_Code, l);
                });
                var json = JsonConvert.SerializeObject(dataList);
                FirebaseDB.UploadServices(json, "Tax");
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool GetTax()
        {
            try
            {
                List<Tax> list = new List<Tax>();
                list = DbContext.GetTax();
                UploadTax(list);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion Tax

        #region User
        public static bool UploadUser(List<User> list)
        {
            try
            {
                Dictionary<string ,User> users = new Dictionary<string, User>();
                list.ForEach(l => {
                    users.Add(l.UserId, l);
                });
                var json = JsonConvert.SerializeObject(users);
                FirebaseDB.UploadServices(json, "User");
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool GetUser()
        {
            try
            {
                List<User> list = new List<User>();
                list = DbContext.GetUser();
                UploadUser(list);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion User

    }
}
