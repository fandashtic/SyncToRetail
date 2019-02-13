using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncToRetail
{
    public class SalesProcess
    {
        public static bool UploadSales(List<Sales> list)
        {
            try
            {                     
                Dictionary<string, Sales> sales = new Dictionary<string, Sales>();
                list.ForEach(l => {
                    sales.Add(l.Abstract.InvoiceID, l);
                });
                var json = JsonConvert.SerializeObject(sales);
                FirebaseDB.UploadServices(json, "Sales");
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool GetSales()
        {
            try
            {
                List<Sales> list = new List<Sales>();
                UploadSales(list);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
    }
}

