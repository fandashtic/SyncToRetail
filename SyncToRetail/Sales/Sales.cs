using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncToRetail
{
    public class Sales
    {
        public SalesAbstract Abstract { get; set; }
        public List<SalesDetail> Details { get; set; }
    }
}
