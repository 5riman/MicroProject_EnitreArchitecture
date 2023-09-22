using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLib_MicroProject_CDL;
using CLib_MicroProject_DAL;
using System.Data;
namespace CLib_MicroProject_BLL
{
  public  class MP_BillTrans_BLL
    {
        MP_BillTrans_DAL BillTransDAL = new MP_BillTrans_DAL();
        public DataSet GetData()
        {
            return BillTransDAL.GetData();
        }
        public void UpdateData()
        {
            BillTransDAL.UpdateData();
        }
    }
}
