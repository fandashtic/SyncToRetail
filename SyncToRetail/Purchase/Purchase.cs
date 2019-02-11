using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncToRetail
{
    public class Purchase
    {
        public PurchaseAbstract Abstract { get; set; }
        public List<PurchaseDetail> Details { get; set; }
    }
}
