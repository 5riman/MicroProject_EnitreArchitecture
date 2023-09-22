using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLib_MicroProject_DAL;
using System.Data;
namespace CLib_MicroProject_BLL
{
   public class MP_ViewBill_BLL
    {
        MP_ViewBill_DAL ViewBillDAL = new MP_ViewBill_DAL();
        public DataSet ViewBill()
        {
            return ViewBillDAL.ViewBill();
        }
    }
}
