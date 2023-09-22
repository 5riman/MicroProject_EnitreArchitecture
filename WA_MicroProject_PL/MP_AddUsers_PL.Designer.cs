
namespace WA_MicroProject_PL
{
    partial class MP_AddUsers_PL
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
            this.btnclose = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncreate = new System.Windows.Forms.Button();
            this.txthintanswer = new System.Windows.Forms.TextBox();
            this.lblhintanswer = new System.Windows.Forms.Label();
            this.cmbhintquestion = new System.Windows.Forms.ComboBox();
            this.lblhintquestion = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.lbllastname = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.txtconfirmpassword = new System.Windows.Forms.TextBox();
            this.lblconfirmpassword = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(409, 380);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(123, 35);
            this.btnclose.TabIndex = 33;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(253, 380);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(123, 35);
            this.btnclear.TabIndex = 32;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.Button_Click);
            // 
            // btncreate
            // 
            this.btncreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreate.Location = new System.Drawing.Point(101, 380);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(123, 35);
            this.btncreate.TabIndex = 31;
            this.btncreate.Text = "Create";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.Button_Click);
            // 
            // txthintanswer
            // 
            this.txthintanswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthintanswer.Location = new System.Drawing.Point(281, 327);
            this.txthintanswer.Name = "txthintanswer";
            this.txthintanswer.Size = new System.Drawing.Size(325, 30);
            this.txthintanswer.TabIndex = 30;
            this.txthintanswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_KeyPress);
            // 
            // lblhintanswer
            // 
            this.lblhintanswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhintanswer.Location = new System.Drawing.Point(30, 327);
            this.lblhintanswer.Name = "lblhintanswer";
            this.lblhintanswer.Size = new System.Drawing.Size(223, 32);
            this.lblhintanswer.TabIndex = 29;
            this.lblhintanswer.Text = "Enter Hint Answer";
            // 
            // cmbhintquestion
            // 
            this.cmbhintquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbhintquestion.FormattingEnabled = true;
            this.cmbhintquestion.Items.AddRange(new object[] {
            "What\'s your NickName?",
            "What\'s your PetName?",
            "What\'s your Favourite Game?",
            "What\'s your Favourite Color?"});
            this.cmbhintquestion.Location = new System.Drawing.Point(281, 273);
            this.cmbhintquestion.Name = "cmbhintquestion";
            this.cmbhintquestion.Size = new System.Drawing.Size(325, 33);
            this.cmbhintquestion.TabIndex = 28;
            // 
            // lblhintquestion
            // 
            this.lblhintquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhintquestion.Location = new System.Drawing.Point(11, 273);
            this.lblhintquestion.Name = "lblhintquestion";
            this.lblhintquestion.Size = new System.Drawing.Size(242, 32);
            this.lblhintquestion.TabIndex = 27;
            this.lblhintquestion.Text = "Select Hint Question";
            // 
            // txtlastname
            // 
            this.txtlastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastname.Location = new System.Drawing.Point(281, 228);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(325, 30);
            this.txtlastname.TabIndex = 26;
            this.txtlastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_KeyPress);
            // 
            // lbllastname
            // 
            this.lbllastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastname.Location = new System.Drawing.Point(44, 228);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(209, 32);
            this.lbllastname.TabIndex = 25;
            this.lbllastname.Text = "Enter Last Name";
            // 
            // txtfirstname
            // 
            this.txtfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstname.Location = new System.Drawing.Point(281, 179);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(325, 30);
            this.txtfirstname.TabIndex = 24;
            this.txtfirstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_KeyPress);
            // 
            // lblfirstname
            // 
            this.lblfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.Location = new System.Drawing.Point(46, 182);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(207, 32);
            this.lblfirstname.TabIndex = 23;
            this.lblfirstname.Text = "Enter First Name";
            // 
            // txtconfirmpassword
            // 
            this.txtconfirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmpassword.Location = new System.Drawing.Point(281, 129);
            this.txtconfirmpassword.Name = "txtconfirmpassword";
            this.txtconfirmpassword.Size = new System.Drawing.Size(325, 30);
            this.txtconfirmpassword.TabIndex = 22;
            this.txtconfirmpassword.Leave += new System.EventHandler(this.txtconfirmpassword_Leave);
            // 
            // lblconfirmpassword
            // 
            this.lblconfirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfirmpassword.Location = new System.Drawing.Point(30, 132);
            this.lblconfirmpassword.Name = "lblconfirmpassword";
            this.lblconfirmpassword.Size = new System.Drawing.Size(223, 32);
            this.lblconfirmpassword.TabIndex = 21;
            this.lblconfirmpassword.Text = "Confirm Password";
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(281, 83);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(325, 30);
            this.txtpassword.TabIndex = 20;
            // 
            // lblpassword
            // 
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(60, 83);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(193, 32);
            this.lblpassword.TabIndex = 19;
            this.lblpassword.Text = "Enter Password";
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(281, 36);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(325, 30);
            this.txtusername.TabIndex = 18;
            // 
            // lblusername
            // 
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(60, 36);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(193, 32);
            this.lblusername.TabIndex = 17;
            this.lblusername.Text = "Enter UserName";
            // 
            // MP_AddUsers_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.txthintanswer);
            this.Controls.Add(this.lblhintanswer);
            this.Controls.Add(this.cmbhintquestion);
            this.Controls.Add(this.lblhintquestion);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.lbllastname);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.lblfirstname);
            this.Controls.Add(this.txtconfirmpassword);
            this.Controls.Add(this.lblconfirmpassword);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblusername);
            this.Name = "MP_AddUsers_PL";
            this.Text = "Create_User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.TextBox txthintanswer;
        private System.Windows.Forms.Label lblhintanswer;
        private System.Windows.Forms.ComboBox cmbhintquestion;
        private System.Windows.Forms.Label lblhintquestion;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.TextBox txtconfirmpassword;
        private System.Windows.Forms.Label lblconfirmpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblusername;
    }
}