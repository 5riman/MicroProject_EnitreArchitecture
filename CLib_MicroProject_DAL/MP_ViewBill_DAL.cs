using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CLib_MicroProject_CDL;
namespace CLib_MicroProject_DAL
{
    public class MP_ViewBill_DAL
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        public MP_ViewBill_DAL()
        {
            con = new SqlConnection(GlobalData.sqlConString);
        }
        public DataSet ViewBill()
        {
            string query = "select *from BillMaster;select *from billtrans";
            da = new SqlDataAdapter(query, con);
            ds = new DataSet();
            da.Fill(ds, "billdetails");
            return ds;
        }
    }
}
