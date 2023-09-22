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
    public partial class MP_ChangePassword_PL : Form
    {
        MP_Users_BLL UsersBLL = new MP_Users_BLL();
        Users User = new Users();
        public MP_ChangePassword_PL()
        {
            InitializeComponent();
        }

        private void Options_CheckedChanged(object sender, EventArgs e)
        {
            foreach(Control x in this.Controls)
            {
                if (x is TextBox) x.Text = "";
            }
            if(optoldpassword.Checked)
            {
                cmbhintquestion.SelectedIndex = -1;
                lblhintquestion.Visible = false;
                lblhintanswer.Visible = false;
                cmbhintquestion.Visible = false;
                txthintanswer.Visible = false;
                lbloldpassword.Visible = true;
                txtoldpassword.Visible = true;
            }
            else if(opthintquestion.Checked)
            {
                lblhintquestion.Visible = true;
                lblhintanswer.Visible = true;
                cmbhintquestion.Visible =true;
                txthintanswer.Visible = true;
                lbloldpassword.Visible = false;
                txtoldpassword.Visible = false;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if(B.Text.Equals("Submit"))
            {
                if(optoldpassword.Checked)
                {
                    if (txtoldpassword.Text.Equals("")||txtnewpassword.Text.Equals("")||txtReenterpassword.Text.Equals(""))
                    {
                        MessageBox.Show("Entering all Fields is Mandatory");
                    }
                    else
                    {
                        string msg = UsersBLL.ChangePasswordWithOldPassword(txtoldpassword.Text, txtnewpassword.Text);
                        MessageBox.Show(msg);
                    }
                }
                else if(opthintquestion.Checked)
                {
                    if (txthintanswer.Text.Equals("")||cmbhintquestion.Text.Equals("")||txtnewpassword.Text.Equals(" ")||
                        txtReenterpassword.Text.Equals(""))
                    {
                        MessageBox.Show("Entering all Fields is Mandatory");
                    }
                    else
                    {
                        User.hintquestion = cmbhintquestion.Text;
                        User.hintanswer = txthintanswer.Text;
                        User.password = txtnewpassword.Text;
                        string msg = UsersBLL.ChangePassWordWithHintQuestion(User);
                        MessageBox.Show(msg);
                    }
                }
            }
            else
            {
                this.Close();
            }
        }

        private void txtReenterpassword_Leave(object sender, EventArgs e)
        {
            if(!txtnewpassword.Text.Equals(txtReenterpassword.Text))
            {
                MessageBox.Show("Mismatching Passwords");
            }
        }
        public void refresh()
        {
            foreach(Control x in this.Controls)
            {
                if (x is TextBox || x is ComboBox)
                    x.Text = "";
            }
        }

        private void MP_ChangePassword_PL_Load(object sender, EventArgs e)
        {
            optoldpassword.Checked = true;
        }
    }
}
