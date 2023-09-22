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
    public partial class MP_BillMaster_PL : Form
    {
        MP_BillTrans_PL BillTransPL;
        BillMaster Bill = new BillMaster();
        MP_BillMaster_BLL BillMasterBLL = new MP_BillMaster_BLL();
        Tax NewTax = new Tax();
        double bill;
        public MP_BillMaster_PL()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if(B.Text.Equals("Save"))
            {
                foreach (Control x in this.Controls)
                {
                    if (x is TextBox)
                        if (x.Text.Equals(""))
                        {
                            MessageBox.Show("All fields are Mandatory");
                            return;
                        }
                }
                if(Convert.ToDouble(txtbillamount.Text)==0)
                {
                    MessageBox.Show("No items selected\nAdd items to generate bill");
                    btnadditems.Enabled = true;
                    return;
                }
                if (Convert.ToDouble(txtdiscount.Text) > Convert.ToDouble(txtbillamount.Text))
                {
                    MessageBox.Show("Discount cannot be greater than billamount");
                    txtdiscount.Focus();
                    return;

                }
                Bill.billNumber = txtbillnumber.Text;
                Bill.billDate = Convert.ToDateTime(txtbilldate.Text);
                Bill.billAmount = Convert.ToDouble(txtbillamount.Text);
                Bill.sgst = Convert.ToDouble(txtsgst.Text);
                Bill.cgst = Convert.ToDouble(txtcgst.Text);
                Bill.discount = Convert.ToDouble(txtdiscount.Text);
                Bill.totalBill = Convert.ToDouble(txttotalbill.Text);
                NewTax.sgst = Convert.ToDouble(txtsgst.Text);
                NewTax.cgst = Convert.ToDouble(txtcgst.Text);
                BillMasterBLL.AddTax(NewTax);
               string msg= BillMasterBLL.AddBill(Bill);
                BillTransPL.UpdateData();
                MessageBox.Show(msg);

            }
            else if(B.Text.Equals("Clear"))
            {
                foreach (Control x in this.Controls)
                    if (x is TextBox)
                        x.Text = "";
                txtbillnumber.Enabled = true;
                btnadditems.Enabled = true;
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
                if (x is TextBox)
                    x.Text = "";
            }
            txtbillnumber.Enabled = true;
        }
        private void btnadditems_Click(object sender, EventArgs e)
        {
            if (!txtbillnumber.Text.Equals(""))
            {
                if (!BillMasterBLL.CheckBillNumAvailability(txtbillnumber.Text))
                {
                    if (BillTransPL == null || BillTransPL.IsDisposed)
                        BillTransPL = new MP_BillTrans_PL(this);
                    BillTransPL.refresh();
                    DialogResult result=  BillTransPL.ShowDialog();
                    if (DialogResult.OK == result)
                    {
                        txtdiscount.Clear();
                        txtdiscount.Enabled = true;
                        txtbillnumber.Enabled = false;
                        btnadditems.Enabled = false;
                        txtbilldate.Text = DateTime.Now.ToString();
                        double amount = 0;
                        foreach (DataRow x in GlobalData.ds.Tables[0].Rows)
                        {
                            amount += Convert.ToDouble(x["TotalPrice"]);
                        }
                        txtbillamount.Text = amount.ToString();
                        txtcgst.Text = (Convert.ToDouble(txtbillamount.Text) * 0.15).ToString();
                        txtsgst.Text = (Convert.ToDouble(txtbillamount.Text) * 0.15).ToString();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Bill With this Number Already Generated");
                }
            }
            else
            {
                MessageBox.Show("Entering Bill Number is Mandatory");
            }

        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            if(!txtdiscount.Text.Equals(""))
            {
                
                    bill= (Convert.ToDouble(txtbillamount.Text) + Convert.ToDouble(txtsgst.Text) +
                    Convert.ToDouble(txtcgst.Text) - Convert.ToDouble(txtdiscount.Text));
                txttotalbill.Text = bill.ToString();
            }
            else
            {
                txttotalbill.Clear();
            }
        }

        private void txtdiscount_Leave(object sender, EventArgs e)
        {
           
            
        }

        private void txtbillnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtbillnumber.Text.Length == 4)
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                    MessageBox.Show("Bill Number Completed");
                    return;
                }
            }
            if(txtbillnumber.Text.Length==0)
            {
                if(!e.KeyChar.Equals('B')&& e.KeyChar!=(char)Keys.Back)
                {
                    MessageBox.Show("First Letter should be 'B'");
                    e.Handled = true;
                }
              
            }
            else {

                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    MessageBox.Show("Digits only Allowed");
                    e.Handled = true;
                }
            }
        }

        private void MP_BillMaster_PL_Load(object sender, EventArgs e)
        {
            btnadditems.Enabled = true;
        }
    }
}
