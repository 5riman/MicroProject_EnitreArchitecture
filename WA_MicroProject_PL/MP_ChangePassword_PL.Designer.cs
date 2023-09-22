
namespace WA_MicroProject_PL
{
    partial class MP_ChangePassword_PL
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
            this.lblhintanswer = new System.Windows.Forms.Label();
            this.txthintanswer = new System.Windows.Forms.TextBox();
            this.cmbhintquestion = new System.Windows.Forms.ComboBox();
            this.lblhintquestion = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.txtReenterpassword = new System.Windows.Forms.TextBox();
            this.lblreenterpassword = new System.Windows.Forms.Label();
            this.txtnewpassword = new System.Windows.Forms.TextBox();
            this.lblnewpassword = new System.Windows.Forms.Label();
            this.txtoldpassword = new System.Windows.Forms.TextBox();
            this.lbloldpassword = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.opthintquestion = new System.Windows.Forms.RadioButton();
            this.optoldpassword = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblhintanswer
            // 
            this.lblhintanswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhintanswer.Location = new System.Drawing.Point(74, 208);
            this.lblhintanswer.Name = "lblhintanswer";
            this.lblhintanswer.Size = new System.Drawing.Size(195, 23);
            this.lblhintanswer.TabIndex = 30;
            this.lblhintanswer.Text = "Enter Hint Answer";
            this.lblhintanswer.Visible = false;
            // 
            // txthintanswer
            // 
            this.txthintanswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthintanswer.Location = new System.Drawing.Point(321, 208);
            this.txthintanswer.Name = "txthintanswer";
            this.txthintanswer.Size = new System.Drawing.Size(254, 28);
            this.txthintanswer.TabIndex = 29;
            this.txthintanswer.Visible = false;
            // 
            // cmbhintquestion
            // 
            this.cmbhintquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbhintquestion.FormattingEnabled = true;
            this.cmbhintquestion.Items.AddRange(new object[] {
            "What is your nickname?",
            "What is your petname?",
            "What is your name?",
            "What is your favourite game?",
            "What is your favourite subject?"});
            this.cmbhintquestion.Location = new System.Drawing.Point(321, 156);
            this.cmbhintquestion.Name = "cmbhintquestion";
            this.cmbhintquestion.Size = new System.Drawing.Size(254, 30);
            this.cmbhintquestion.TabIndex = 28;
            this.cmbhintquestion.Visible = false;
            // 
            // lblhintquestion
            // 
            this.lblhintquestion.AutoSize = true;
            this.lblhintquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhintquestion.Location = new System.Drawing.Point(74, 162);
            this.lblhintquestion.Name = "lblhintquestion";
            this.lblhintquestion.Size = new System.Drawing.Size(201, 24);
            this.lblhintquestion.TabIndex = 27;
            this.lblhintquestion.Text = "Select Hint Question";
            this.lblhintquestion.Visible = false;
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(347, 379);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(115, 34);
            this.btnclose.TabIndex = 26;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.Location = new System.Drawing.Point(200, 379);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(115, 34);
            this.btnsubmit.TabIndex = 25;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.Button_Click);
            // 
            // txtReenterpassword
            // 
            this.txtReenterpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReenterpassword.Location = new System.Drawing.Point(321, 301);
            this.txtReenterpassword.Name = "txtReenterpassword";
            this.txtReenterpassword.Size = new System.Drawing.Size(254, 28);
            this.txtReenterpassword.TabIndex = 24;
            this.txtReenterpassword.Leave += new System.EventHandler(this.txtReenterpassword_Leave);
            // 
            // lblreenterpassword
            // 
            this.lblreenterpassword.AutoSize = true;
            this.lblreenterpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreenterpassword.Location = new System.Drawing.Point(73, 305);
            this.lblreenterpassword.Name = "lblreenterpassword";
            this.lblreenterpassword.Size = new System.Drawing.Size(189, 24);
            this.lblreenterpassword.TabIndex = 23;
            this.lblreenterpassword.Text = "Re-Enter Password";
            // 
            // txtnewpassword
            // 
            this.txtnewpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewpassword.Location = new System.Drawing.Point(321, 253);
            this.txtnewpassword.Name = "txtnewpassword";
            this.txtnewpassword.Size = new System.Drawing.Size(254, 28);
            this.txtnewpassword.TabIndex = 22;
            // 
            // lblnewpassword
            // 
            this.lblnewpassword.AutoSize = true;
            this.lblnewpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewpassword.Location = new System.Drawing.Point(71, 257);
            this.lblnewpassword.Name = "lblnewpassword";
            this.lblnewpassword.Size = new System.Drawing.Size(204, 24);
            this.lblnewpassword.TabIndex = 21;
            this.lblnewpassword.Text = "Enter New Password";
            // 
            // txtoldpassword
            // 
            this.txtoldpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoldpassword.Location = new System.Drawing.Point(321, 203);
            this.txtoldpassword.Name = "txtoldpassword";
            this.txtoldpassword.Size = new System.Drawing.Size(254, 28);
            this.txtoldpassword.TabIndex = 20;
            // 
            // lbloldpassword
            // 
            this.lbloldpassword.AutoSize = true;
            this.lbloldpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloldpassword.Location = new System.Drawing.Point(74, 207);
            this.lbloldpassword.Name = "lbloldpassword";
            this.lbloldpassword.Size = new System.Drawing.Size(195, 24);
            this.lbloldpassword.TabIndex = 19;
            this.lbloldpassword.Text = "Enter Old Password";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltype.Location = new System.Drawing.Point(268, 38);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(153, 29);
            this.lbltype.TabIndex = 18;
            this.lbltype.Text = "Select Type";
            // 
            // opthintquestion
            // 
            this.opthintquestion.AutoSize = true;
            this.opthintquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opthintquestion.Location = new System.Drawing.Point(330, 84);
            this.opthintquestion.Name = "opthintquestion";
            this.opthintquestion.Size = new System.Drawing.Size(225, 29);
            this.opthintquestion.TabIndex = 17;
            this.opthintquestion.TabStop = true;
            this.opthintquestion.Text = "Using Hint Question";
            this.opthintquestion.UseVisualStyleBackColor = true;
            this.opthintquestion.CheckedChanged += new System.EventHandler(this.Options_CheckedChanged);
            // 
            // optoldpassword
            // 
            this.optoldpassword.AutoSize = true;
            this.optoldpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optoldpassword.Location = new System.Drawing.Point(66, 84);
            this.optoldpassword.Name = "optoldpassword";
            this.optoldpassword.Size = new System.Drawing.Size(228, 29);
            this.optoldpassword.TabIndex = 16;
            this.optoldpassword.TabStop = true;
            this.optoldpassword.Text = "Using Old Password";
            this.optoldpassword.UseVisualStyleBackColor = true;
            this.optoldpassword.CheckedChanged += new System.EventHandler(this.Options_CheckedChanged);
            // 
            // MP_ChangePassword_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.lblhintanswer);
            this.Controls.Add(this.txthintanswer);
            this.Controls.Add(this.cmbhintquestion);
            this.Controls.Add(this.lblhintquestion);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txtReenterpassword);
            this.Controls.Add(this.lblreenterpassword);
            this.Controls.Add(this.txtnewpassword);
            this.Controls.Add(this.lblnewpassword);
            this.Controls.Add(this.txtoldpassword);
            this.Controls.Add(this.lbloldpassword);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.opthintquestion);
            this.Controls.Add(this.optoldpassword);
            this.Name = "MP_ChangePassword_PL";
            this.Text = "Change_Password";
            this.Load += new System.EventHandler(this.MP_ChangePassword_PL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhintanswer;
        private System.Windows.Forms.TextBox txthintanswer;
        private System.Windows.Forms.ComboBox cmbhintquestion;
        private System.Windows.Forms.Label lblhintquestion;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.TextBox txtReenterpassword;
        private System.Windows.Forms.Label lblreenterpassword;
        private System.Windows.Forms.TextBox txtnewpassword;
        private System.Windows.Forms.Label lblnewpassword;
        private System.Windows.Forms.TextBox txtoldpassword;
        private System.Windows.Forms.Label lbloldpassword;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.RadioButton opthintquestion;
        private System.Windows.Forms.RadioButton optoldpassword;
    }
}