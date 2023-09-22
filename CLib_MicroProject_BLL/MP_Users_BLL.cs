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
    
   public class MP_Users_BLL
    {
        MP_Users_DAL UsersDAL = new MP_Users_DAL();
        public string AddNewUser(Users NewUser)
        {
            return UsersDAL.AddNewUser(NewUser);
        }

        public string DeleteUser()
        {
            return UsersDAL.DeleteUser();
        }
        public DataSet viewuser()
        {
            return UsersDAL.ViewUser();
        }
        public string ChangePasswordWithOldPassword(string oldpassword,string newpassword)
        {
            return UsersDAL.ChangePasswordWithOldPassword(oldpassword, newpassword);
        }
        public string ChangePassWordWithHintQuestion(Users User)
        {
            return UsersDAL.ChangePasswordWithHintQuestion(User);
        }
        public DataSet DeleteGetData()
        {
            return UsersDAL.DeleteGetData();
        }
        public int CheckCredentials(Users NewUser)
        {
            return UsersDAL.CheckCredentials(NewUser);
        }

        
    }
}
