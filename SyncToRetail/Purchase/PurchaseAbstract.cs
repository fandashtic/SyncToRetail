using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncToRetail
{
    public class PurchaseAbstract
    {
        public string BillID { get; set; }
        public string GRNID { get; set; }
        public string BillDate { get; set; }
        public string VendorID { get; set; }
        public string Username { get; set; }
        public string Value { get; set; }
        public string CreationTime { get; set; }
        public string Status { get; set; }
        public string InvoiceReference { get; set; }
        public string BillReference { get; set; }
        public string DocumentID { get; set; }
        public string NewGRNID { get; set; }
        public string DocumentReference { get; set; }
        public string OriginalBill { get; set; }
        public string ClientID { get; set; }
        public string TaxAmount { get; set; }
        public string AdjustmentAmount { get; set; }
        public string Balance { get; set; }
        public string Discount { get; set; }
        public string DiscountOption { get; set; }
        public string AdjRef { get; set; }
        public string AdjustedAmount { get; set; }
        public string PaymentID { get; set; }
        public string Remarks { get; set; }
        public string CreditTerm { get; set; }
        public string PaymentDate { get; set; }
        public string Flags { get; set; }
        public string CancelUserName { get; set; }
        public string CancelDate { get; set; }
        public string TaxOnMRP { get; set; }
        public string DocIDReference { get; set; }
        public string DocSerialType { get; set; }
        public string AdjustmentValue { get; set; }
        public string ExciseDuty { get; set; }
        public string DiscountBeforeExcise { get; set; }
        public string PurchasePriceBeforeExcise { get; set; }
        public string FAPaymentID { get; set; }
        public string VATTaxAmount { get; set; }
        public string OctroiAmount { get; set; }
        public string Freight { get; set; }
        public string AddlDiscountPercentage { get; set; }
        public string AddlDiscountAmount { get; set; }
        public string ProductDiscount { get; set; }
        public string Surcharge { get; set; }
        public string TaxDiscountFlag { get; set; }
        public string TaxType { get; set; }
        public string GSTFlag { get; set; }
        public string StateType { get; set; }
        public string FromStatecode { get; set; }
        public string ToStatecode { get; set; }
        public string GSTIN { get; set; }
        public string GSTEnableFlag { get; set; }
        public string ODNumber { get; set; }

    }
}
