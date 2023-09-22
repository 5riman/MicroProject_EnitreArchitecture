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
   public class MP_Users_DAL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlCommandBuilder bldr;
        DataSet ds;
        public MP_Users_DAL()
        {
            con = new SqlConnection(GlobalData.sqlConString);
        }
        public int DBoperation(SqlCommand cmd)
        {
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                con.Close();
                return i;
            }
            catch(Exception E)
            {
                return 0;
            }
        }
        public string AddNewUser(Users NewUser)
        {
            string Query = "insert into users values(@p1,@p2,@p3,@p4,@p5,@p6)";
            cmd = new SqlCommand(Query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p1", NewUser.username);
            cmd.Parameters.AddWithValue("@p2", NewUser.password);
            cmd.Parameters.AddWithValue("@p3", NewUser.firstname);
            cmd.Parameters.AddWithValue("@p4", NewUser.lastname);
            cmd.Parameters.AddWithValue("@p5", NewUser.hintquestion);
            cmd.Parameters.AddWithValue("@p6", NewUser.hintanswer);
            int i= DBoperation(cmd);
            if (i == 1)
            {
                return "User Created Successfully";
            }
            else return "UserName Already Registered";
        }
        public string DeleteUser()
        {
            try
            {
                da.Update(ds.Tables[0]);
                return "User(s) Deleted Successfully";
            }
            catch
            {
                return "some error occurred";
            }
        }
        public string ChangePasswordWithOldPassword(string oldpassword,string newpassword)
        {
            string Query = "select count(*) from Users where UserName=@p1 and Password=@p2";
            cmd = new SqlCommand(Query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p1", GlobalData.userName);
            cmd.Parameters.AddWithValue("@p2", oldpassword);
            int i = CheckAvailability(cmd);
            if (i == 1)
            {
                return ChangePassword(newpassword);
            }
            else
                return "Invalid Credentials";
        }
        public string ChangePassword(string newpassword)
        {
            string Query = "update Users set Password=@p1 where UserName=@p2";
            cmd = new SqlCommand(Query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p1", newpassword);
            cmd.Parameters.AddWithValue("@p2", GlobalData.userName);
           int i= DBoperation(cmd);
            if (i == 0)
                return "some error occured";
            else
            {
                return "Password Changed Successfully";
            }
        }
        public string ChangePasswordWithHintQuestion(Users User)
        {
            string Query = "select count(*) from Users where hintquestion=@p1 and hintanswer=@p2 and username=@p3";
            cmd = new SqlCommand(Query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p1", User.hintquestion);
            cmd.Parameters.AddWithValue("@p2", User.hintanswer);
            cmd.Parameters.AddWithValue("@p3", GlobalData.userName);
            int i = CheckAvailability(cmd);
            if(i==1)
            {
                return ChangePassword(User.password);
               
            }
            else
            {
                return "Invalid Credentials";
            }
        }
        public int CheckAvailability(SqlCommand cmd)
        {
            con.Open();
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return i;
        }
        public DataSet ViewUser()
        {
            String Query = "select UserName,FirstName,LastName from Users";
            return GetData(Query);  
        }
        public DataSet DeleteGetData()
        {
            String Query = "select *from Users where Username!='" + GlobalData.userName + "'";
            return GetData(Query);
        }
        public DataSet GetData(string Query)
        {
            da = new SqlDataAdapter(Query, con);
            bldr = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "users");
            return ds;
        }
        public int  CheckCredentials(Users User)
        {
            string query = "select count(*) from users where username=@p1 and password=@p2";
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p1", User.username);
            cmd.Parameters.AddWithValue("@p2", User.password);
            return CheckAvailability(cmd);
            
                
        }
    }
}
