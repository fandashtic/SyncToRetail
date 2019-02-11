﻿using Newtonsoft.Json;
using SyncToRetail.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncToRetail
{
    public class SalesProcess
    {
        public static bool UploadSales(List<Sales.Sales> list)
        {
            try
            {                
                var json = JsonConvert.SerializeObject(list);
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
                List<Sales.Sales> list = new List<Sales.Sales>();
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

