using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncToRetail
{
    public class SalesAbstract
    {
        public string InvoiceID { get; set; }
        public string InvoiceType { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string CustomerID { get; set; }
        public string BillingAddress { get; set; }
        public string ShippingAddress { get; set; }
        public string UserName { get; set; }
        public string GrossValue { get; set; }
        public string DiscountPercentage { get; set; }
        public string DiscountValue { get; set; }
        public string NetValue { get; set; }
        public string CreationTime { get; set; }
        public string Status { get; set; }
        public string TaxLocation { get; set; }
        public string InvoiceReference { get; set; }
        public string ReferenceNumber { get; set; }
        public string AdditionalDiscount { get; set; }
        public string Freight { get; set; }
        public string CreditTerm { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string DocumentID { get; set; }
        public string NewReference { get; set; }
        public string NewInvoiceReference { get; set; }
        public string OriginalInvoice { get; set; }
        public string ClientID { get; set; }
        public string Memo1 { get; set; }
        public string Memo2 { get; set; }
        public string Memo3 { get; set; }
        public string MemoLabel1 { get; set; }
        public string MemoLabel2 { get; set; }
        public string MemoLabel3 { get; set; }
        public string Flags { get; set; }
        public string ReferredBy { get; set; }
        public string Balance { get; set; }
        public string SalesmanID { get; set; }
        public string BeatID { get; set; }
        public string PaymentMode { get; set; }
        public string PaymentDetails { get; set; }
        public string ReturnType { get; set; }
        public string Salesman2 { get; set; }
        public string DocReference { get; set; }
        public string AmountRecd { get; set; }
        public string AdjRef { get; set; }
        public string AdjustedAmount { get; set; }
        public string GoodsValue { get; set; }
        public string AddlDiscountValue { get; set; }
        public string TotalTaxSuffered { get; set; }
        public string TotalTaxApplicable { get; set; }
        public string ProductDiscount { get; set; }
        public string RoundOffAmount { get; set; }
        public string AdjustmentValue { get; set; }
        public string Denominations { get; set; }
        public string ServiceCharge { get; set; }
        public string BranchCode { get; set; }
        public string CFormNo { get; set; }
        public string DFormNo { get; set; }
        public DateTime CancelDate { get; set; }
        public string VanNumber { get; set; }
        public string TaxOnMRP { get; set; }
        public string DocSerialType { get; set; }
        public string SchemeID { get; set; }
        public string SchemeDiscountPercentage { get; set; }
        public string SchemeDiscountAmount { get; set; }
        public string ClaimedAmount { get; set; }
        public string ClaimedAlready { get; set; }
        public string ExciseDuty { get; set; }
        public string DiscountBeforeExcise { get; set; }
        public string SalePriceBeforeExcise { get; set; }
        public string CustomerPoints { get; set; }
        public string VatTaxAmount { get; set; }
        public string SONumber { get; set; }
        public string GroupID { get; set; }
        public string DeliveryStatus { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string InvoiceSchemeID { get; set; }
        public string MultipleSchemeDetails { get; set; }
        public string TaxDiscountFlag { get; set; }
        public string DSTypeID { get; set; }
        public string AmendReasonID { get; set; }
        public string CancelReasonID { get; set; }
        public string CancelUser { get; set; }
        public string FromStateCode { get; set; }
        public string ToStateCode { get; set; }
        public string GSTIN { get; set; }
        public string GSTFlag { get; set; }
        public string GSTDocID { get; set; }
        public string GSTFullDocID { get; set; }
        public string AlternateCGCustomerName { get; set; }
        public string SRInvoiceID { get; set; }
        public string SRHH_Reference { get; set; }
    }
}
