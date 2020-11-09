namespace VpApp
{
    partial class SignUp
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
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTransaction = new System.Windows.Forms.Label();
            this.lblReport = new System.Windows.Forms.Label();
            this.lblSMS = new System.Windows.Forms.Label();
            this.chkReport = new System.Windows.Forms.CheckBox();
            this.chkTransaction = new System.Windows.Forms.CheckBox();
            this.chkSMS = new System.Windows.Forms.CheckBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.radBad = new System.Windows.Forms.RadioButton();
            this.radNormal = new System.Windows.Forms.RadioButton();
            this.radGood = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(112, 12);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(240, 20);
            this.txtFirstname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First name:";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(112, 38);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(240, 20);
            this.txtLastname.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last name:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 64);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email address:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radGood);
            this.groupBox1.Controls.Add(this.radNormal);
            this.groupBox1.Controls.Add(this.radBad);
            this.groupBox1.Controls.Add(this.lblTransaction);
            this.groupBox1.Controls.Add(this.lblReport);
            this.groupBox1.Controls.Add(this.lblSMS);
            this.groupBox1.Controls.Add(this.chkReport);
            this.groupBox1.Controls.Add(this.chkTransaction);
            this.groupBox1.Controls.Add(this.chkSMS);
            this.groupBox1.Location = new System.Drawing.Point(14, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Services";
            // 
            // lblTransaction
            // 
            this.lblTransaction.AutoSize = true;
            this.lblTransaction.Location = new System.Drawing.Point(130, 66);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(0, 13);
            this.lblTransaction.TabIndex = 5;
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Location = new System.Drawing.Point(130, 43);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(0, 13);
            this.lblReport.TabIndex = 4;
            // 
            // lblSMS
            // 
            this.lblSMS.AutoSize = true;
            this.lblSMS.Location = new System.Drawing.Point(130, 20);
            this.lblSMS.Name = "lblSMS";
            this.lblSMS.Size = new System.Drawing.Size(0, 13);
            this.lblSMS.TabIndex = 3;
            // 
            // chkReport
            // 
            this.chkReport.AutoSize = true;
            this.chkReport.Location = new System.Drawing.Point(38, 42);
            this.chkReport.Name = "chkReport";
            this.chkReport.Size = new System.Drawing.Size(58, 17);
            this.chkReport.TabIndex = 2;
            this.chkReport.Text = "Report";
            this.chkReport.UseVisualStyleBackColor = true;
            this.chkReport.CheckedChanged += new System.EventHandler(this.chkReport_CheckedChanged);
            // 
            // chkTransaction
            // 
            this.chkTransaction.AutoSize = true;
            this.chkTransaction.Location = new System.Drawing.Point(38, 65);
            this.chkTransaction.Name = "chkTransaction";
            this.chkTransaction.Size = new System.Drawing.Size(82, 17);
            this.chkTransaction.TabIndex = 1;
            this.chkTransaction.Text = "Transaction";
            this.chkTransaction.UseVisualStyleBackColor = true;
            this.chkTransaction.CheckedChanged += new System.EventHandler(this.chkTransaction_CheckedChanged);
            // 
            // chkSMS
            // 
            this.chkSMS.AutoSize = true;
            this.chkSMS.Location = new System.Drawing.Point(38, 19);
            this.chkSMS.Name = "chkSMS";
            this.chkSMS.Size = new System.Drawing.Size(49, 17);
            this.chkSMS.TabIndex = 0;
            this.chkSMS.Text = "SMS";
            this.chkSMS.UseVisualStyleBackColor = true;
            this.chkSMS.CheckedChanged += new System.EventHandler(this.chkSMS_CheckedChanged);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(277, 196);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 23);
            this.btnSignUp.TabIndex = 9;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // radBad
            // 
            this.radBad.AutoSize = true;
            this.radBad.Location = new System.Drawing.Point(197, 18);
            this.radBad.Name = "radBad";
            this.radBad.Size = new System.Drawing.Size(44, 17);
            this.radBad.TabIndex = 6;
            this.radBad.TabStop = true;
            this.radBad.Text = "Bad";
            this.radBad.UseVisualStyleBackColor = true;
            // 
            // radNormal
            // 
            this.radNormal.AutoSize = true;
            this.radNormal.Location = new System.Drawing.Point(197, 41);
            this.radNormal.Name = "radNormal";
            this.radNormal.Size = new System.Drawing.Size(58, 17);
            this.radNormal.TabIndex = 7;
            this.radNormal.TabStop = true;
            this.radNormal.Text = "Normal";
            this.radNormal.UseVisualStyleBackColor = true;
            // 
            // radGood
            // 
            this.radGood.AutoSize = true;
            this.radGood.Location = new System.Drawing.Point(197, 64);
            this.radGood.Name = "radGood";
            this.radGood.Size = new System.Drawing.Size(51, 17);
            this.radGood.TabIndex = 8;
            this.radGood.TabStop = true;
            this.radGood.Text = "Good";
            this.radGood.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 229);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTransaction;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Label lblSMS;
        private System.Windows.Forms.CheckBox chkReport;
        private System.Windows.Forms.CheckBox chkTransaction;
        private System.Windows.Forms.CheckBox chkSMS;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.RadioButton radGood;
        private System.Windows.Forms.RadioButton radNormal;
        private System.Windows.Forms.RadioButton radBad;
    }
}