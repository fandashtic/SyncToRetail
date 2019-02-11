using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncToRetail
{
    public class Tax
    {
        public string Tax_Code { get; set; }
        public string Tax_Description { get; set; }
        public string Percentage { get; set; }
        public string CreationDate { get; set; }
        public string Active { get; set; }
        public string CST_Percentage { get; set; }
        public string LSTApplicableOn { get; set; }
        public string LSTPartOff { get; set; }
        public string CSTApplicableOn { get; set; }
        public string CSTPartOff { get; set; }
        public string CS_TaxCode { get; set; }
        public string EffectiveFrom { get; set; }
        public string GSTFlag { get; set; }

    }
}
