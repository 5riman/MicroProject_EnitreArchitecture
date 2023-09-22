using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLib_MicroProject_CDL;
using CLib_MicroProject_BLL;
namespace WA_MicroProject_PL
{
    public partial class MP_AddItem_PL : Form
    {
        DataSet ds;
        DataRow Rec;
        MP_Items_BLL ItemsBLL = new MP_Items_BLL();
        public MP_AddItem_PL()
        {
            InitializeComponent();
            ds = ItemsBLL.GetData();
            dgvitems.DataSource = ds.Tables[0];
        }

        private void AddItem_Load(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text.Equals("Add"))
            {
                foreach (Control x in this.Controls)
                    if (x is TextBox)
                        if (x.Text == "")
                        {
                            MessageBox.Show("Entering Fields is Mandatory");
                            return;
                        }
                Rec = ds.Tables[0].NewRow();
                Rec[0] = txtitem.Text;
                Rec[1] = txtprice.Text;
                foreach (DataRow x in ds.Tables[0].Rows)
                {
                    if (x["item"].Equals(txtitem.Text))
                    {
                        MessageBox.Show("Item Already available");
                        txtitem.Clear();
                        txtprice.Clear();
                        return;
                    }
                }

                ds.Tables[0].Rows.Add(Rec);
                txtitem.Clear();
                txtprice.Clear();
            }
            else if (b.Text.Equals("Save"))
            {
                if (!ds.HasChanges())
                    MessageBox.Show("For saving Adding Items is Mandatory");
                else
                {
                    string msg = ItemsBLL.SaveItems(" Added ");
                    MessageBox.Show(msg);
                    txtitem.Clear();
                    txtprice.Clear();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            TextBox T = (TextBox)sender;
            if (T.Name.Equals("txtitem"))
            {
                if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                    e.Handled = true;

            }
            else
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                    e.Handled = true;

            }
        }
        public void refresh()
        {
            txtitem.Text = "";
            txtprice.Text = "";
        }
    }
}
