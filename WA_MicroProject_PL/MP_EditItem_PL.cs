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
    public partial class MP_EditItem_PL : Form
    {
        MP_Items_BLL ItemsBLL = new MP_Items_BLL();
        DataSet ds;
        int index;
        public MP_EditItem_PL()
        {
            InitializeComponent();
        }

        private void MP_EditItem_PL_Load(object sender, EventArgs e)
        {
            ds = ItemsBLL.GetData();
            dgvitems.DataSource = ds.Tables[0];
            txtprice.Enabled = false;
            
        }

        private void dgvitems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            index = e.RowIndex;
            txtitem.Text = ds.Tables[0].Rows[index]["item"].ToString();
            txtprice.Text = ds.Tables[0].Rows[index]["price"].ToString();
            txtprice.Enabled = true;
        }

        public void refresh()
        {
            txtprice.Clear();
            txtitem.Clear();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if(B.Text.Equals("Edit"))
            {
                if(!txtprice.Text.Equals(""))
                {
                    ds.Tables[0].Rows[index]["price"] = txtprice.Text;
                    txtitem.Clear();
                    txtprice.Clear();
                    
                }
                else
                {
                    MessageBox.Show("Field(s) is Mandatory or\nSelect item to edit");
                }
            }
            else if(B.Text.Equals("Save"))
            {
                if(ds.HasChanges())
                {
                    string msg = ItemsBLL.SaveItems(" Edited ");
                    MessageBox.Show(msg);
                    txtitem.Clear();
                    txtprice.Clear();
                    txtprice.Enabled = false;
                }
                else
                {
                    MessageBox.Show("For saving,Editing Items is Mandatory");
                }
            }
            else
            {
                this.Close();
            }
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
    }
}
