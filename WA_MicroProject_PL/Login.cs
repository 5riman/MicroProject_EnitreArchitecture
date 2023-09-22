using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLib_MicroProject_BLL;
using CLib_MicroProject_CDL;
namespace WA_MicroProject_PL
{
    public partial class Login_Form : Form
    {
        Users User = new Users();
        MP_Users_BLL UsersBLL = new MP_Users_BLL();
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (!(txtusername.Text.Equals("") || txtpassword.Text.Equals("")))
            {
                User.username = txtusername.Text;
                User.password = txtpassword.Text;
                int i = UsersBLL.CheckCredentials(User);
                if (i == 1)
                {
                    GlobalData.userName = txtusername.Text;
                    MessageBox.Show("UserLogin Successful ");
                    MDIParent_Form mdi = new MDIParent_Form();
                    this.Hide();
                    mdi.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials");
                }
            }
            else
            {
                MessageBox.Show("Field(s) is Mandatory");
            }

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
