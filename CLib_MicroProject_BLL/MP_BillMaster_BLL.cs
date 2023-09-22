using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CLib_MicroProject_DAL;
using CLib_MicroProject_CDL;
namespace CLib_MicroProject_BLL
{
   public class MP_BillMaster_BLL
    {
        MP_BillMaster_DAL BillMasterDAL = new MP_BillMaster_DAL();
        public string AddBill(BillMaster NewBill)
        {
            return BillMasterDAL.AddBill(NewBill);
        }
        public void AddTax(Tax NewTax)
        {
            BillMasterDAL.AddTax(NewTax);
        }
        public bool CheckBillNumAvailability(string BillNum)
        {
            return BillMasterDAL.CheckBillNumAvailability(BillNum);
        }


    }
}
