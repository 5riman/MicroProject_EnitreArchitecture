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
    public class MP_Items_DAL
    {
        SqlConnection con;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter da;
        SqlCommandBuilder bldr;
        public MP_Items_DAL()
        {
            con = new SqlConnection(GlobalData.sqlConString);
        }
        public DataSet GetData()
        {
            string query = "select *from Items";
            da = new SqlDataAdapter(query, con);
            ds = new DataSet();
            bldr = new SqlCommandBuilder(da);
            da.Fill(ds, "emp");
            return ds; 
        }
        public string SaveItems(string form)
        {
            da.Update(ds.Tables[0]);
            return "Item(s)"+form+ "Successfully";
        }
    }
}
