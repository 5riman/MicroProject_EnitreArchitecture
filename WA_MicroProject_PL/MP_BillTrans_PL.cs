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
    public partial class MP_BillTrans_PL : Form
    {
        MP_BillTrans_BLL BillTransBLL = new MP_BillTrans_BLL();
        DataSet ds;
        DataRow Rec;
        string BillNumber;
        public MP_BillTrans_PL(MP_BillMaster_PL Bill)
        {
            InitializeComponent();
            BillNumber = Bill.txtbillnumber.Text;
        }

        private void MP_BillTrans_PL_Load(object sender, EventArgs e)
        {
            ds = BillTransBLL.GetData();
            dgvbill.DataSource = ds.Tables[0];
            foreach(DataRow x in this.ds.Tables[1].Rows)
            {
                cmbitems.Items.Add(x["item"]);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if(B.Text.Equals("Add"))
            {
                foreach(Control x in this.Controls)
                {
                    if(x is TextBox ||x is ComboBox)
                        if(x.Text.Equals(""))
                        {
                            MessageBox.Show("All Fields are Mandatory");
                            return;
                        }
                }
                foreach(DataRow x in ds.Tables[0].Rows)
                {
                    if(x["ItemName"].ToString().Equals(cmbitems.Text))
                    {
                        x["Quantity"] = Convert.ToInt32(x["Quantity"]) + Convert.ToInt32(txtquantity.Text);
                        x["TotalPrice"] = Convert.ToDouble(x["TotalPrice"]) + Convert.ToDouble(txttotalprice.Text);
                        this.ClearData();
                        return;
                    }
                }
                Rec = ds.Tables[0].NewRow();
                Rec[0] = BillNumber;
                Rec[1] = cmbitems.SelectedItem;
                Rec[2] = txtprice.Text;
                Rec[3] = txtquantity.Text;
                Rec[4] = txttotalprice.Text;
                ds.Tables[0].Rows.Add(Rec);
                this.ClearData();
            }
            
        }
        public void ClearData()
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox || x is ComboBox)
                    x.Text = "";
            }
        }
        private void txtquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void cmbitems_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtquantity.Clear();
            txttotalprice.Clear();
            txtprice.Text = ds.Tables[1].Rows[cmbitems.SelectedIndex][1].ToString();

        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
            if (!txtquantity.Text.Equals(""))
                txttotalprice.Text = (Convert.ToDouble(txtprice.Text) * Convert.ToInt32(txtquantity.Text)).ToString();
            else
                txttotalprice.Clear();
        }
        public void UpdateData()
        {
            BillTransBLL.UpdateData();
        }
        public void refresh()
        {
            foreach(Control x in this.Controls)
            {
                if (x is TextBox || x is ComboBox)
                    x.Text = "";
                if(x is ComboBox)
                {
                    ComboBox c = (ComboBox)x;
                    c.Items.Clear();
                }
            }
        }
    }
}
