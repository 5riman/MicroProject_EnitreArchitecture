using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLib_MicroProject_CDL;
using System.Data;
using System.Data.SqlClient;
namespace CLib_MicroProject_DAL
{
  public class MP_BillTrans_DAL
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommandBuilder bldr;
        public MP_BillTrans_DAL()
        {
            con = new SqlConnection(GlobalData.sqlConString);
        }
        public DataSet GetData()
        {
            string query = "select *from billtrans where billNumber is null; select *from items";
            da = new SqlDataAdapter(query, con);
            GlobalData.ds = new DataSet();
            bldr = new SqlCommandBuilder(da);
            da.Fill(GlobalData.ds, "itemtrans");
            return GlobalData.ds;
        }
        
        public void UpdateData()
        {
            da.Update(GlobalData.ds.Tables[0]);
        }
    }
}
