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
    public partial class MP_AddUsers_PL : Form
    {
        MP_Users_BLL UsersBLL = new MP_Users_BLL();
        Users User = new Users();
        public MP_AddUsers_PL()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (B.Text.Equals("Create"))
            {
                foreach (Control x in this.Controls)
                {
                    if (x is TextBox || x is ComboBox)
                    {
                        if (x.Text.Equals(""))
                        {
                            MessageBox.Show("All fields are Mandatory");
                            return;
                         }
                    }
                }
                User.username = txtusername.Text;
                User.password = txtpassword.Text;
                User.firstname = txtfirstname.Text;
                User.lastname = txtlastname.Text;
                User.hintquestion = cmbhintquestion.Text;
                User.hintanswer = txthintanswer.Text;
                string msg = UsersBLL.AddNewUser(User);
                MessageBox.Show(msg);

            }
            else if (B.Text.Equals("Clear"))
            {
                foreach (Control x in this.Controls)
                {
                    if (x is TextBox || x is ComboBox)
                        x.Text = "";
                }
                
            }
            else
            {
                this.Close();
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
        private void txtconfirmpassword_Leave(object sender, EventArgs e)
        {
            if(!txtpassword.Text.Equals(txtconfirmpassword.Text))
            {
                MessageBox.Show("Mismatching Passwords");
                txtconfirmpassword.Focus();
            }

        }

        private void Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Name != txthintanswer.Name)
            {
                if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                    e.Handled = true;
            }
        }
    }
}
