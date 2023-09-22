using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLib_MicroProject_CDL
{
    public class BillMaster
    {
        public string billNumber { set; get; }
        public DateTime billDate { set; get; }
        public double billAmount { set; get; }
        public double sgst { set; get; }
        public double cgst { set; get; }
        public double discount { set; get; }
        public double totalBill { set; get; }
        public string userName { set; get; }
    }
}
