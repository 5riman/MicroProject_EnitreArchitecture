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
namespace WA_MicroProject_PL
{
    public partial class MP_ViewUser_PL : Form
    {
        MP_Users_BLL UsersBLL = new MP_Users_BLL();
        public MP_ViewUser_PL()
        {
            InitializeComponent();
        }

        private void MP_ViewUser_PL_Load(object sender, EventArgs e)
        {
            dgvuser.DataSource = UsersBLL.viewuser().Tables[0];
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
