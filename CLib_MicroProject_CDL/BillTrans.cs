using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLib_MicroProject_CDL
{
   public class BillTrans
    {
        public string billNumber { set; get; }
        public string itemName { set; get; }
        public double price { set; get; }
        public int quantity { set; get; }
        public double totalPrice { set; get; }
    }
}
