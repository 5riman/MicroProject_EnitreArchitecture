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
    public partial class MP_DeleteUser_PL : Form
    {
        MP_Users_BLL UsersBLL = new MP_Users_BLL();
        DataSet ds;
        int index;
        public MP_DeleteUser_PL()
        {
            InitializeComponent();
        }

        private void MP_DeleteUser_PL_Load(object sender, EventArgs e)
        {
            ds = UsersBLL.DeleteGetData();
            dgvuser.DataSource = ds.Tables[0];
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if(B.Text.Equals("Delete"))
            {
                try
                {
                    dgvuser.Rows.RemoveAt(index);
                }
                catch
                {
                    MessageBox.Show("Select a record to delete");
                }
            }
            else if(B.Text.Equals("Save"))
            {
                if(ds.HasChanges())
                {
                    string msg = UsersBLL.DeleteUser();
                    MessageBox.Show(msg);
                }
                else
                {
                    MessageBox.Show("For saving Deleting Users is Mandatory");
                }
            }
            else
            {
                this.Close();
            }
        }

        private void dgvuser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                index = e.RowIndex;
           

        }
    }
}
