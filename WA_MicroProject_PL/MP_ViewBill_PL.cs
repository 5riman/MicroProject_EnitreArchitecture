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
    public partial class MP_ViewBill_PL : Form
    {
        DataSet ds;
        MP_ViewBill_BLL ViewBillBLL = new MP_ViewBill_BLL();
        public MP_ViewBill_PL()
        {
            InitializeComponent();
        }

        public void MP_ViewBill_PL_Load(object sender, EventArgs e)
        {
            ds = ViewBillBLL.ViewBill();
            foreach(DataRow x in this.ds.Tables[0].Rows)
            {
                cmbbillnumber.Items.Add(x[0]);
            }
            cmbbillnumber.Text = "";
        }
        public void refresh()
        {
            foreach(Control x in this.Controls)
            {
                if(x is DataGridView)
                {
                    DataGridView d = (DataGridView)x;
                    d.DataSource = "";
                }
                if (x is ComboBox)
                {
                    
                    ComboBox C = (ComboBox)x;
                    C.Items.Clear();
                }
            }
        }
        private void cmbbillnumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow[] BillMaster = ds.Tables[0].Select("billnumber='" + cmbbillnumber.Text + "'");
           DataTable dt= BillMaster.CopyToDataTable();
            dgvbilldetails.DataSource = dt;
            DataRow[] BillTrans = ds.Tables[1].Select("billnumber='" + cmbbillnumber.Text + "'");
            dt = BillTrans.CopyToDataTable();
            dgvitemdetails.DataSource = dt;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
