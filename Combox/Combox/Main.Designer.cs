﻿namespace Combox
{
    partial class Main
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
            this.cmbProvice = new System.Windows.Forms.ComboBox();
            this.lblSelectProvice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Provice";
            // 
            // cmbProvice
            // 
            this.cmbProvice.FormattingEnabled = true;
            this.cmbProvice.Location = new System.Drawing.Point(95, 10);
            this.cmbProvice.Name = "cmbProvice";
            this.cmbProvice.Size = new System.Drawing.Size(107, 21);
            this.cmbProvice.TabIndex = 1;
            this.cmbProvice.SelectedIndexChanged += new System.EventHandler(this.cmbProvice_SelectedIndexChanged);
            // 
            // lblSelectProvice
            // 
            this.lblSelectProvice.AutoSize = true;
            this.lblSelectProvice.Location = new System.Drawing.Point(13, 48);
            this.lblSelectProvice.Name = "lblSelectProvice";
            this.lblSelectProvice.Size = new System.Drawing.Size(0, 13);
            this.lblSelectProvice.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSelectProvice);
            this.Controls.Add(this.cmbProvice);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProvice;
        private System.Windows.Forms.Label lblSelectProvice;
    }
}

