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

    public class MP_BillMaster_DAL
    {
        SqlConnection con;
        SqlCommand cmd;
        public MP_BillMaster_DAL()
        {
            con = new SqlConnection(GlobalData.sqlConString);
        }
        public string AddBill(BillMaster Bill)
        {
            string query = "insert into BillMaster values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p1", Bill.billNumber);
            cmd.Parameters.AddWithValue("@p2", Bill.billDate);
            cmd.Parameters.AddWithValue("@p3", Bill.billAmount);
            cmd.Parameters.AddWithValue("@p4", Bill.sgst);
            cmd.Parameters.AddWithValue("@p5", Bill.cgst);
            cmd.Parameters.AddWithValue("@p6", Bill.discount);
            cmd.Parameters.AddWithValue("@p7", Bill.totalBill);
            cmd.Parameters.AddWithValue("@p8", GlobalData.userName);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i == 1)
                return "Bill saved successfully";
            else
            {
                return "Some error occurred";
            }

        }
        public void AddTax(Tax NewTax)
        {
            string query = "insert into Tax values(@p1,@p2)";
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p1", NewTax.sgst);
            cmd.Parameters.AddWithValue("@p2", NewTax.cgst);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public bool CheckBillNumAvailability(string BillNum)
        {
            string query = "select count(*) from billmaster where billnumber='" + BillNum + "'";
            cmd = new SqlCommand(query, con);
            con.Open();
           int i=Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            if (i == 1)
                return true;
            else return false;
        }

    }
}
