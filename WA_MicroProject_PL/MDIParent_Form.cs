using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WA_MicroProject_PL
{
    public partial class MDIParent_Form : Form
    {
        MP_AddItem_PL Add_Item;
        MP_EditItem_PL Edit_Item;
        MP_DeleteItem_PL Delete_Item;
        MP_AddUsers_PL Add_Users;
        MP_DeleteUser_PL Delete_User;
        MP_ChangePassword_PL Change_Password;
        MP_ViewUser_PL View_User;
        MP_BillMaster_PL Bill_Master;
        MP_ViewBill_PL View_Bill;
        

        public MDIParent_Form()
        {
            InitializeComponent();
        }

        private void Option(object sender, EventArgs e)
        {
            ToolStripMenuItem MItem = (ToolStripMenuItem)sender;
            switch(MItem.Name)
            {
                case "AddItem":
                                    if (Add_Item == null || Add_Item.IsDisposed)
                                        Add_Item = new MP_AddItem_PL();
                                    Add_Item.ShowDialog();
                                    Add_Item.refresh();
                                    break;

                case "EditItem":
                                    if (Edit_Item == null || Edit_Item.IsDisposed)
                                        Edit_Item = new MP_EditItem_PL();
                                    Edit_Item.refresh();
                                    Edit_Item.ShowDialog();
                                    break;

                case "DeleteItem":
                                if (Delete_Item == null || Delete_Item.IsDisposed)
                                    Delete_Item = new MP_DeleteItem_PL();
                                else
                                {
                                    Delete_Item.refresh();
                                }
                                    Delete_Item.ShowDialog();
                                    break;

                case "Exit":
                                this.Close();
                                break;

                case "AddNewUser":
                                    if (Add_Users == null || Add_Users.IsDisposed)
                                        Add_Users= new MP_AddUsers_PL();
                                    Add_Users.refresh();
                                    Add_Users.ShowDialog();
                                    break;

                case "DeleteUser":
                                    if (Delete_User == null || Delete_User.IsDisposed)
                                        Delete_User = new MP_DeleteUser_PL();
                                    Delete_User.ShowDialog();
                                    break;

                case "ChangePassword":
                                        if (Change_Password == null || Change_Password.IsDisposed)
                                            Change_Password = new MP_ChangePassword_PL();
                                        Change_Password.refresh();                    
                                        Change_Password.ShowDialog();
                                        break;

                case "ViewUser":
                                    if (View_User == null || View_User.IsDisposed)
                                        View_User = new MP_ViewUser_PL();
                                    View_User.ShowDialog();
                                    break;

                case "NewBill":
                                    if (Bill_Master == null || Bill_Master.IsDisposed)
                                        Bill_Master = new MP_BillMaster_PL();
                                    Bill_Master.refresh();
                                    Bill_Master.ShowDialog();
                                    break;

                case "ViewBill":
                                    if (View_Bill == null || View_Bill.IsDisposed)
                                        View_Bill = new MP_ViewBill_PL();
                                    View_Bill.refresh();
                                    View_Bill.ShowDialog();
                                    break;
                default:
                    break;
            }
        }
    }
}
