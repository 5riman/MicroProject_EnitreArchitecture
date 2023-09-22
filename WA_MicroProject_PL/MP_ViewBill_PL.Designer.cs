
namespace WA_MicroProject_PL
{
    partial class MP_ViewBill_PL
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
            this.dgvitemdetails = new System.Windows.Forms.DataGridView();
            this.lblitemdetails = new System.Windows.Forms.Label();
            this.dgvbilldetails = new System.Windows.Forms.DataGridView();
            this.lblbilldetails = new System.Windows.Forms.Label();
            this.cmbbillnumber = new System.Windows.Forms.ComboBox();
            this.lblbillnumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitemdetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbilldetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(285, 467);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(106, 34);
            this.btnclose.TabIndex = 13;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // dgvitemdetails
            // 
            this.dgvitemdetails.AllowUserToAddRows = false;
            this.dgvitemdetails.AllowUserToDeleteRows = false;
            this.dgvitemdetails.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvitemdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvitemdetails.Location = new System.Drawing.Point(27, 279);
            this.dgvitemdetails.Name = "dgvitemdetails";
            this.dgvitemdetails.ReadOnly = true;
            this.dgvitemdetails.RowHeadersWidth = 51;
            this.dgvitemdetails.RowTemplate.Height = 24;
            this.dgvitemdetails.Size = new System.Drawing.Size(745, 163);
            this.dgvitemdetails.TabIndex = 12;
            // 
            // lblitemdetails
            // 
            this.lblitemdetails.AutoSize = true;
            this.lblitemdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemdetails.Location = new System.Drawing.Point(23, 249);
            this.lblitemdetails.Name = "lblitemdetails";
            this.lblitemdetails.Size = new System.Drawing.Size(117, 24);
            this.lblitemdetails.TabIndex = 11;
            this.lblitemdetails.Text = "Item Details";
            // 
            // dgvbilldetails
            // 
            this.dgvbilldetails.AllowUserToAddRows = false;
            this.dgvbilldetails.AllowUserToDeleteRows = false;
            this.dgvbilldetails.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvbilldetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbilldetails.Location = new System.Drawing.Point(33, 112);
            this.dgvbilldetails.Name = "dgvbilldetails";
            this.dgvbilldetails.ReadOnly = true;
            this.dgvbilldetails.RowHeadersWidth = 51;
            this.dgvbilldetails.RowTemplate.Height = 24;
            this.dgvbilldetails.Size = new System.Drawing.Size(745, 112);
            this.dgvbilldetails.TabIndex = 10;
            // 
            // lblbilldetails
            // 
            this.lblbilldetails.AutoSize = true;
            this.lblbilldetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbilldetails.Location = new System.Drawing.Point(29, 73);
            this.lblbilldetails.Name = "lblbilldetails";
            this.lblbilldetails.Size = new System.Drawing.Size(106, 24);
            this.lblbilldetails.TabIndex = 9;
            this.lblbilldetails.Text = "Bill Details";
            // 
            // cmbbillnumber
            // 
            this.cmbbillnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbillnumber.FormattingEnabled = true;
            this.cmbbillnumber.Location = new System.Drawing.Point(344, 26);
            this.cmbbillnumber.Name = "cmbbillnumber";
            this.cmbbillnumber.Size = new System.Drawing.Size(193, 30);
            this.cmbbillnumber.TabIndex = 8;
            this.cmbbillnumber.SelectedIndexChanged += new System.EventHandler(this.cmbbillnumber_SelectedIndexChanged);
            // 
            // lblbillnumber
            // 
            this.lblbillnumber.AutoSize = true;
            this.lblbillnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbillnumber.Location = new System.Drawing.Point(155, 29);
            this.lblbillnumber.Name = "lblbillnumber";
            this.lblbillnumber.Size = new System.Drawing.Size(183, 24);
            this.lblbillnumber.TabIndex = 7;
            this.lblbillnumber.Text = "Select Bill Number";
            // 
            // MP_ViewBill_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.dgvitemdetails);
            this.Controls.Add(this.lblitemdetails);
            this.Controls.Add(this.dgvbilldetails);
            this.Controls.Add(this.lblbilldetails);
            this.Controls.Add(this.cmbbillnumber);
            this.Controls.Add(this.lblbillnumber);
            this.Name = "MP_ViewBill_PL";
            this.Text = "View_Bill";
            this.Load += new System.EventHandler(this.MP_ViewBill_PL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvitemdetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbilldetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DataGridView dgvitemdetails;
        private System.Windows.Forms.Label lblitemdetails;
        private System.Windows.Forms.DataGridView dgvbilldetails;
        private System.Windows.Forms.Label lblbilldetails;
        private System.Windows.Forms.ComboBox cmbbillnumber;
        private System.Windows.Forms.Label lblbillnumber;
    }
}