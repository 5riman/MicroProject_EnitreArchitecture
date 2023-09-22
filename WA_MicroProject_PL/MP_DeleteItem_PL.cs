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
    public partial class MP_DeleteItem_PL : Form
    {
        MP_Items_BLL ItemsBLL = new MP_Items_BLL();
        DataSet ds;
        int index;
        public MP_DeleteItem_PL()
        {
            InitializeComponent();
            ds=ItemsBLL.GetData();
            
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if(B.Text.Equals("Delete"))
            {
                if (!txtitem.Text.Equals(""))
                {
                    dgvitems.Rows.RemoveAt(index);
                    this.ClearData();
                }
                else
                {
                    MessageBox.Show("Select an Item to Delete");
                }
                
            }
            else if(B.Text.Equals("Save"))
            {
                if(ds.HasChanges())
                {
                   string msg=ItemsBLL.SaveItems(" Deleted ");
                    MessageBox.Show(msg);
                    this.ClearData();
                    
                }
                else
                {
                    MessageBox.Show("For saving,Deleting Items is Mandatory");
                }
            }
            else
            {
                this.Close();
            }
        }

        private void dgvitems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            txtitem.Text = ds.Tables[0].Rows[index]["item"].ToString();
            txtprice.Text = ds.Tables[0].Rows[index]["price"].ToString();
        }
        public void ClearData()
        {
            txtitem.Clear();
            txtprice.Clear();
        }

        private void MP_DeleteItem_PL_Load(object sender, EventArgs e)
        {
                ds= ItemsBLL.GetData();
            dgvitems.DataSource = ds.Tables[0];
            this.txtitem.Enabled = false;
            this.txtitem.Enabled = false;
        }
        public void refresh()
        {
            txtitem.Clear();
            txtprice.Clear();
           
        }
    }
}
