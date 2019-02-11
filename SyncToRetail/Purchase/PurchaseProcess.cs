using Newtonsoft.Json;
using SyncToRetail.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncToRetail
{
    public class PurchaseProcess
    {
        public static bool UploadPurchase(List<Sales.Sales> list)
        {
            try
            {
                var json = JsonConvert.SerializeObject(list);
                FirebaseDB.UploadServices(json, "Purchase");
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool GetPurchase()
        {
            try
            {
                List<Sales.Sales> list = new List<Sales.Sales>();
                UploadPurchase(list);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
