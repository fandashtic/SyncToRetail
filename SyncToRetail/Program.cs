using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncToRetail
{
    class Program
    {     
        static void Main(string[] args)
        {
            MasterProcess.GetBeat();
            MasterProcess.GetCustomer();
            MasterProcess.GetSalesMan();
            MasterProcess.GetSalesManBeat();
            MasterProcess.GetProduct();
            MasterProcess.GetTax();
            MasterProcess.GetUser();
            SalesProcess.GetSales();
            PurchaseProcess.GetPurchase();
            DbContext.GetTemp();
            //ReadLine();
        }

        static void WriteLine(string str = null)
        {
            Console.WriteLine(str);
        }

        static void ReadLine()
        {
            Console.ReadKey();
        }
    }
}
