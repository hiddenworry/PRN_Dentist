﻿namespace WinApp
{
    partial class frmDentistDetail
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
            this.txtDentistName = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.cbDentistGender = new System.Windows.Forms.ComboBox();
            this.txtDentistPassword = new System.Windows.Forms.TextBox();
            this.txtDentistLoginName = new System.Windows.Forms.TextBox();
            this.txtDentistID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtDentistName
            // 
            this.txtDentistName.Location = new System.Drawing.Point(268, 173);
            this.txtDentistName.Name = "txtDentistName";
            this.txtDentistName.Size = new System.Drawing.Size(190, 27);
            this.txtDentistName.TabIndex = 0;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbID.Location = new System.Drawing.Point(159, 53);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(25, 20);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "ID";
            // 
            // cbDentistGender
            // 
            this.cbDentistGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDentistGender.FormattingEnabled = true;
            this.cbDentistGender.Location = new System.Drawing.Point(268, 218);
            this.cbDentistGender.Name = "cbDentistGender";
            this.cbDentistGender.Size = new System.Drawing.Size(190, 28);
            this.cbDentistGender.TabIndex = 2;
            // 
            // txtDentistPassword
            // 
            this.txtDentistPassword.Location = new System.Drawing.Point(268, 129);
            this.txtDentistPassword.Name = "txtDentistPassword";
            this.txtDentistPassword.Size = new System.Drawing.Size(190, 27);
            this.txtDentistPassword.TabIndex = 5;
            // 
            // txtDentistLoginName
            // 
            this.txtDentistLoginName.Location = new System.Drawing.Point(268, 84);
            this.txtDentistLoginName.Name = "txtDentistLoginName";
            this.txtDentistLoginName.Size = new System.Drawing.Size(190, 27);
            this.txtDentistLoginName.TabIndex = 6;
            // 
            // txtDentistID
            // 
            this.txtDentistID.Location = new System.Drawing.Point(268, 46);
            this.txtDentistID.Name = "txtDentistID";
            this.txtDentistID.ReadOnly = true;
            this.txtDentistID.Size = new System.Drawing.Size(190, 27);
            this.txtDentistID.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(159, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(156, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(159, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(159, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Gender";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSave.Location = new System.Drawing.Point(159, 327);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 34);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LavenderBlush;
            this.button2.Location = new System.Drawing.Point(311, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnReset.Location = new System.Drawing.Point(456, 327);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(113, 34);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(159, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(268, 261);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(190, 28);
            this.cbStatus.TabIndex = 16;
            // 
            // frmDentistDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(746, 441);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDentistID);
            this.Controls.Add(this.txtDentistLoginName);
            this.Controls.Add(this.txtDentistPassword);
            this.Controls.Add(this.cbDentistGender);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.txtDentistName);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmDentistDetail";
            this.Text = "frmDentistDetail";
            this.Load += new System.EventHandler(this.frmDentistDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDentistName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.ComboBox cbDentistGender;
        private System.Windows.Forms.TextBox txtDentistPassword;
        private System.Windows.Forms.TextBox txtDentistLoginName;
        private System.Windows.Forms.TextBox txtDentistID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbStatus;
    }
}