namespace FlightBooking
{
    partial class FlightBooking
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radPassport = new System.Windows.Forms.RadioButton();
            this.radIDCard = new System.Windows.Forms.RadioButton();
            this.lblDocumentNo = new System.Windows.Forms.Label();
            this.txtDocumentNo = new System.Windows.Forms.TextBox();
            this.lblIssue = new System.Windows.Forms.Label();
            this.dtPickerIssue = new System.Windows.Forms.DateTimePicker();
            this.lblExpiry = new System.Windows.Forms.Label();
            this.dtPickerExpiry = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.numBaggage = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBooking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numBaggage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "To:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(53, 6);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(172, 20);
            this.txtTo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "From:";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(304, 6);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(172, 20);
            this.txtFrom.TabIndex = 1;
            // 
            // monthCalendar
            // 
            this.monthCalendar.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar.Location = new System.Drawing.Point(18, 38);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 2;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(76, 212);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(162, 20);
            this.txtFirstname.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "First name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last name:";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(314, 212);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(162, 20);
            this.txtLastname.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Travel Document:";
            // 
            // radPassport
            // 
            this.radPassport.AutoSize = true;
            this.radPassport.Location = new System.Drawing.Point(110, 243);
            this.radPassport.Name = "radPassport";
            this.radPassport.Size = new System.Drawing.Size(66, 17);
            this.radPassport.TabIndex = 6;
            this.radPassport.TabStop = true;
            this.radPassport.Text = "Passport";
            this.radPassport.UseVisualStyleBackColor = true;
            this.radPassport.CheckedChanged += new System.EventHandler(this.radPassport_CheckedChanged);
            // 
            // radIDCard
            // 
            this.radIDCard.AutoSize = true;
            this.radIDCard.Location = new System.Drawing.Point(182, 243);
            this.radIDCard.Name = "radIDCard";
            this.radIDCard.Size = new System.Drawing.Size(61, 17);
            this.radIDCard.TabIndex = 6;
            this.radIDCard.TabStop = true;
            this.radIDCard.Text = "ID Card";
            this.radIDCard.UseVisualStyleBackColor = true;
            this.radIDCard.CheckedChanged += new System.EventHandler(this.radIDCard_CheckedChanged);
            // 
            // lblDocumentNo
            // 
            this.lblDocumentNo.AutoSize = true;
            this.lblDocumentNo.Location = new System.Drawing.Point(273, 245);
            this.lblDocumentNo.Name = "lblDocumentNo";
            this.lblDocumentNo.Size = new System.Drawing.Size(74, 13);
            this.lblDocumentNo.TabIndex = 3;
            this.lblDocumentNo.Text = "Document no:";
            // 
            // txtDocumentNo
            // 
            this.txtDocumentNo.Location = new System.Drawing.Point(364, 242);
            this.txtDocumentNo.Name = "txtDocumentNo";
            this.txtDocumentNo.Size = new System.Drawing.Size(112, 20);
            this.txtDocumentNo.TabIndex = 4;
            // 
            // lblIssue
            // 
            this.lblIssue.AutoSize = true;
            this.lblIssue.Location = new System.Drawing.Point(12, 274);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(110, 13);
            this.lblIssue.TabIndex = 5;
            this.lblIssue.Text = "Document issue date:";
            // 
            // dtPickerIssue
            // 
            this.dtPickerIssue.Location = new System.Drawing.Point(170, 268);
            this.dtPickerIssue.Name = "dtPickerIssue";
            this.dtPickerIssue.Size = new System.Drawing.Size(200, 20);
            this.dtPickerIssue.TabIndex = 7;
            this.dtPickerIssue.ValueChanged += new System.EventHandler(this.dtPickerIssue_ValueChanged);
            // 
            // lblExpiry
            // 
            this.lblExpiry.AutoSize = true;
            this.lblExpiry.Location = new System.Drawing.Point(12, 300);
            this.lblExpiry.Name = "lblExpiry";
            this.lblExpiry.Size = new System.Drawing.Size(113, 13);
            this.lblExpiry.TabIndex = 5;
            this.lblExpiry.Text = "Document expiry date:";
            // 
            // dtPickerExpiry
            // 
            this.dtPickerExpiry.Location = new System.Drawing.Point(170, 294);
            this.dtPickerExpiry.Name = "dtPickerExpiry";
            this.dtPickerExpiry.Size = new System.Drawing.Size(200, 20);
            this.dtPickerExpiry.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Baggage:";
            // 
            // numBaggage
            // 
            this.numBaggage.Location = new System.Drawing.Point(71, 321);
            this.numBaggage.Name = "numBaggage";
            this.numBaggage.Size = new System.Drawing.Size(120, 20);
            this.numBaggage.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(197, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "kgs";
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(15, 357);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(461, 23);
            this.btnBooking.TabIndex = 10;
            this.btnBooking.Text = "Booking (without paying)";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // FlightBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 387);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numBaggage);
            this.Controls.Add(this.dtPickerExpiry);
            this.Controls.Add(this.dtPickerIssue);
            this.Controls.Add(this.radIDCard);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblExpiry);
            this.Controls.Add(this.radPassport);
            this.Controls.Add(this.lblIssue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDocumentNo);
            this.Controls.Add(this.lblDocumentNo);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.label1);
            this.Name = "FlightBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fight Booking";
            this.Load += new System.EventHandler(this.FlightBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBaggage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radPassport;
        private System.Windows.Forms.RadioButton radIDCard;
        private System.Windows.Forms.Label lblDocumentNo;
        private System.Windows.Forms.TextBox txtDocumentNo;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.DateTimePicker dtPickerIssue;
        private System.Windows.Forms.Label lblExpiry;
        private System.Windows.Forms.DateTimePicker dtPickerExpiry;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numBaggage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBooking;
    }
}

