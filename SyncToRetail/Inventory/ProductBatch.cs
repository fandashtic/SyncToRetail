using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncToRetail.Inventory
{
    public class ProductBatch
    {
        public string Batch_Code { get; set; }
        public string Batch_Number { get; set; }
        public string Product_Code { get; set; }
        public string GRN_ID { get; set; }
        public string Expiry { get; set; }
        public string Quantity { get; set; }
        public string PurchasePrice { get; set; }
        public string PurchaseTax { get; set; }
        public string SalePrice { get; set; }
        public string TaxCode { get; set; }
        public string PTS { get; set; }
        public string PTR { get; set; }
        public string ECP { get; set; }
        public string QuantityReceived { get; set; }
        public string Company_Price { get; set; }
        public string Flags { get; set; }
        public string OriginalBatch { get; set; }
        public string Client_ID { get; set; }
        public string Damage { get; set; }
        public string DamagesReason { get; set; }
        public string PKD { get; set; }
        public string ClaimedAlready { get; set; }
        public string Free { get; set; }
        public string StockTransferID { get; set; }
        public string BatchReference { get; set; }
        public string TaxSuffered { get; set; }
        public string UOM { get; set; }
        public string UOMQty { get; set; }
        public string UOMPrice { get; set; }
        public string CreationDate { get; set; }
        public string StkAdj { get; set; }
        public string ComboID { get; set; }
        public string TaxOnMRP { get; set; }
        public string Promotion { get; set; }
        public string DocType { get; set; }
        public string DocID { get; set; }
        public string ExciseDuty { get; set; }
        public string ExciseID { get; set; }
        public string GRNTaxSuffered { get; set; }
        public string GRNTaxID { get; set; }
        public string GRNApplicableOn { get; set; }
        public string GRNPartOff { get; set; }
        public string Applicableon { get; set; }
        public string Partofpercentage { get; set; }
        public string Vat_Locality { get; set; }
        public string Serial { get; set; }
        public string ReceInvItemOrder { get; set; }
        public string OrgPTS { get; set; }
        public string StockReconID { get; set; }
        public string TaxType { get; set; }
        public string PFM { get; set; }
        public string MRPforTax { get; set; }
        public string DocDate { get; set; }
        public string MRPPerPack { get; set; }
        public string TOQ { get; set; }
        public string GSTTaxType { get; set; }
        public string MarginDetID { get; set; }
        public string MarginPerc { get; set; }
        public string MarginOn { get; set; }
        public string MarginAddOn { get; set; }

    }
}
