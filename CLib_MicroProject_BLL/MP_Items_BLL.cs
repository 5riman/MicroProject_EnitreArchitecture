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
    public class MP_Items_BLL
    {
        MP_Items_DAL ItemsDAL = new MP_Items_DAL();
        public MP_Items_BLL()
        {
            
        }
        public DataSet GetData()
        {
            return ItemsDAL.GetData();
        }
        public string SaveItems(string form)
        {
            return ItemsDAL.SaveItems(form);
        }
    }
}
