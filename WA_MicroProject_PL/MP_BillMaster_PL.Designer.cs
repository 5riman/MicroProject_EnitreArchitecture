
namespace WA_MicroProject_PL
{
    partial class MP_BillMaster_PL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnadditems = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txttotalbill = new System.Windows.Forms.TextBox();
            this.lbltotalbill = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.lbldiscount = new System.Windows.Forms.Label();
            this.txtsgst = new System.Windows.Forms.TextBox();
            this.lblsgst = new System.Windows.Forms.Label();
            this.txtcgst = new System.Windows.Forms.TextBox();
            this.lblcgst = new System.Windows.Forms.Label();
            this.txtbillamount = new System.Windows.Forms.TextBox();
            this.lblbillamount = new System.Windows.Forms.Label();
            this.txtbilldate = new System.Windows.Forms.TextBox();
            this.lblbilldate = new System.Windows.Forms.Label();
            this.txtbillnumber = new System.Windows.Forms.TextBox();
            this.lblbillnumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnadditems
            // 
            this.btnadditems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadditems.Location = new System.Drawing.Point(609, 27);
            this.btnadditems.Name = "btnadditems";
            this.btnadditems.Size = new System.Drawing.Size(133, 35);
            this.btnadditems.TabIndex = 35;
            this.btnadditems.Text = "Add Items";
            this.btnadditems.UseVisualStyleBackColor = true;
            this.btnadditems.Click += new System.EventHandler(this.btnadditems_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(325, 391);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(116, 35);
            this.btnclear.TabIndex = 34;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(481, 391);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(116, 35);
            this.btnclose.TabIndex = 33;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(169, 391);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(116, 35);
            this.btnsave.TabIndex = 32;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.Button_Click);
            // 
            // txttotalbill
            // 
            this.txttotalbill.Enabled = false;
            this.txttotalbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalbill.Location = new System.Drawing.Point(304, 330);
            this.txttotalbill.Name = "txttotalbill";
            this.txttotalbill.Size = new System.Drawing.Size(245, 28);
            this.txttotalbill.TabIndex = 31;
            // 
            // lbltotalbill
            // 
            this.lbltotalbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalbill.Location = new System.Drawing.Point(145, 333);
            this.lbltotalbill.Name = "lbltotalbill";
            this.lbltotalbill.Size = new System.Drawing.Size(140, 23);
            this.lbltotalbill.TabIndex = 30;
            this.lbltotalbill.Text = "Total Bill";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Enabled = false;
            this.txtdiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscount.Location = new System.Drawing.Point(304, 277);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(245, 28);
            this.txtdiscount.TabIndex = 29;
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged);
            this.txtdiscount.Leave += new System.EventHandler(this.txtdiscount_Leave);
            // 
            // lbldiscount
            // 
            this.lbldiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiscount.Location = new System.Drawing.Point(85, 282);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(208, 23);
            this.lbldiscount.TabIndex = 28;
            this.lbldiscount.Text = "Enter Discount";
            // 
            // txtsgst
            // 
            this.txtsgst.Enabled = false;
            this.txtsgst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsgst.Location = new System.Drawing.Point(304, 227);
            this.txtsgst.Name = "txtsgst";
            this.txtsgst.Size = new System.Drawing.Size(245, 28);
            this.txtsgst.TabIndex = 27;
            // 
            // lblsgst
            // 
            this.lblsgst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsgst.Location = new System.Drawing.Point(165, 227);
            this.lblsgst.Name = "lblsgst";
            this.lblsgst.Size = new System.Drawing.Size(74, 23);
            this.lblsgst.TabIndex = 26;
            this.lblsgst.Text = "SGST";
            // 
            // txtcgst
            // 
            this.txtcgst.Enabled = false;
            this.txtcgst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcgst.Location = new System.Drawing.Point(303, 176);
            this.txtcgst.Name = "txtcgst";
            this.txtcgst.Size = new System.Drawing.Size(245, 28);
            this.txtcgst.TabIndex = 25;
            // 
            // lblcgst
            // 
            this.lblcgst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcgst.Location = new System.Drawing.Point(161, 181);
            this.lblcgst.Name = "lblcgst";
            this.lblcgst.Size = new System.Drawing.Size(78, 23);
            this.lblcgst.TabIndex = 24;
            this.lblcgst.Text = "CGST";
            // 
            // txtbillamount
            // 
            this.txtbillamount.Enabled = false;
            this.txtbillamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbillamount.Location = new System.Drawing.Point(302, 123);
            this.txtbillamount.Name = "txtbillamount";
            this.txtbillamount.Size = new System.Drawing.Size(245, 28);
            this.txtbillamount.TabIndex = 23;
            // 
            // lblbillamount
            // 
            this.lblbillamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbillamount.Location = new System.Drawing.Point(86, 126);
            this.lblbillamount.Name = "lblbillamount";
            this.lblbillamount.Size = new System.Drawing.Size(210, 23);
            this.lblbillamount.TabIndex = 22;
            this.lblbillamount.Text = "Bill Amount is";
            // 
            // txtbilldate
            // 
            this.txtbilldate.Enabled = false;
            this.txtbilldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbilldate.Location = new System.Drawing.Point(303, 73);
            this.txtbilldate.Name = "txtbilldate";
            this.txtbilldate.Size = new System.Drawing.Size(245, 28);
            this.txtbilldate.TabIndex = 21;
            // 
            // lblbilldate
            // 
            this.lblbilldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbilldate.Location = new System.Drawing.Point(119, 78);
            this.lblbilldate.Name = "lblbilldate";
            this.lblbilldate.Size = new System.Drawing.Size(178, 23);
            this.lblbilldate.TabIndex = 20;
            this.lblbilldate.Text = "Bill Date is";
            // 
            // txtbillnumber
            // 
            this.txtbillnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbillnumber.Location = new System.Drawing.Point(304, 27);
            this.txtbillnumber.Name = "txtbillnumber";
            this.txtbillnumber.Size = new System.Drawing.Size(245, 28);
            this.txtbillnumber.TabIndex = 19;
            this.txtbillnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbillnumber_KeyPress);
            // 
            // lblbillnumber
            // 
            this.lblbillnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbillnumber.Location = new System.Drawing.Point(58, 25);
            this.lblbillnumber.Name = "lblbillnumber";
            this.lblbillnumber.Size = new System.Drawing.Size(240, 23);
            this.lblbillnumber.TabIndex = 18;
            this.lblbillnumber.Text = "Enter Bill Number";
            // 
            // MP_BillMaster_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.btnadditems);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txttotalbill);
            this.Controls.Add(this.lbltotalbill);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.lbldiscount);
            this.Controls.Add(this.txtsgst);
            this.Controls.Add(this.lblsgst);
            this.Controls.Add(this.txtcgst);
            this.Controls.Add(this.lblcgst);
            this.Controls.Add(this.txtbillamount);
            this.Controls.Add(this.lblbillamount);
            this.Controls.Add(this.txtbilldate);
            this.Controls.Add(this.lblbilldate);
            this.Controls.Add(this.txtbillnumber);
            this.Controls.Add(this.lblbillnumber);
            this.Name = "MP_BillMaster_PL";
            this.Text = "BillMaster";
            this.Load += new System.EventHandler(this.MP_BillMaster_PL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadditems;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txttotalbill;
        private System.Windows.Forms.Label lbltotalbill;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label lbldiscount;
        public System.Windows.Forms.TextBox txtsgst;
        private System.Windows.Forms.Label lblsgst;
        public System.Windows.Forms.TextBox txtcgst;
        private System.Windows.Forms.Label lblcgst;
        public System.Windows.Forms.TextBox txtbillamount;
        private System.Windows.Forms.Label lblbillamount;
        public System.Windows.Forms.TextBox txtbilldate;
        private System.Windows.Forms.Label lblbilldate;
        public System.Windows.Forms.TextBox txtbillnumber;
        private System.Windows.Forms.Label lblbillnumber;
    }
}