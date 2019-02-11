using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncToRetail
{
    public class PurchaseDetail
    {
        public string BillID { get; set; }
        public string Product_Code { get; set; }
        public string Quantity { get; set; }
        public string PurchasePrice { get; set; }
        public string Amount { get; set; }
        public string TaxSuffered { get; set; }
        public string TaxAmount { get; set; }
        public string TaxCode { get; set; }
        public string Discount { get; set; }
        public string Batch { get; set; }
        public string Expiry { get; set; }
        public string PKD { get; set; }
        public string PTS { get; set; }
        public string PTR { get; set; }
        public string ECP { get; set; }
        public string SpecialPrice { get; set; }
        public string UOM { get; set; }
        public string UOMQty { get; set; }
        public string UOMPrice { get; set; }
        public string Flags { get; set; }
        public string ComboID { get; set; }
        public string Promotion { get; set; }
        public string Serial { get; set; }
        public string ExciseDuty { get; set; }
        public string PurchasePriceBeforeExciseAmount { get; set; }
        public string ExciseID { get; set; }
        public string VAT { get; set; }
        public string OctroiPercentage { get; set; }
        public string OctroiAmount { get; set; }
        public string Freight { get; set; }
        public string Surcharge { get; set; }
        public string DiscPerUnit { get; set; }
        public string OrgPTS { get; set; }
        public string Missing { get; set; }
        public string InvDiscPerc { get; set; }
        public string InvDiscAmtPerUnit { get; set; }
        public string InvDiscAmount { get; set; }
        public string OtherDiscPerc { get; set; }
        public string OtherDiscAmtPerUnit { get; set; }
        public string OtherDiscAmount { get; set; }
        public string NetPTS { get; set; }
        public string PTS_Margin { get; set; }
        public string PFM { get; set; }
        public string DISCTYPE { get; set; }
        public string MRPforTax { get; set; }
        public string MRPPerPack { get; set; }
        public string TOQ { get; set; }
        public string CS_TaxCode { get; set; }
        public string HSNNumber { get; set; }
        public string MarginDetID { get; set; }
        public string MarginPerc { get; set; }
        public string MarginOn { get; set; }
        public string MarginAddOn { get; set; }

    }
}
