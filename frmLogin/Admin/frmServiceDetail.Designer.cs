﻿namespace WinApp
{
    partial class frmServiceDetail
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbServiceDetailID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbServiceType = new System.Windows.Forms.ComboBox();
            this.lbServiceType = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEstimatedTime = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(447, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 27);
            this.textBox3.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 27);
            this.textBox1.TabIndex = 3;
            // 
            // lbServiceDetailID
            // 
            this.lbServiceDetailID.AutoSize = true;
            this.lbServiceDetailID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbServiceDetailID.Location = new System.Drawing.Point(29, 28);
            this.lbServiceDetailID.Name = "lbServiceDetailID";
            this.lbServiceDetailID.Size = new System.Drawing.Size(25, 20);
            this.lbServiceDetailID.TabIndex = 4;
            this.lbServiceDetailID.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(312, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // cbServiceType
            // 
            this.cbServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServiceType.FormattingEnabled = true;
            this.cbServiceType.Location = new System.Drawing.Point(143, 82);
            this.cbServiceType.Name = "cbServiceType";
            this.cbServiceType.Size = new System.Drawing.Size(151, 28);
            this.cbServiceType.TabIndex = 6;
            // 
            // lbServiceType
            // 
            this.lbServiceType.AutoSize = true;
            this.lbServiceType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbServiceType.Location = new System.Drawing.Point(29, 90);
            this.lbServiceType.Name = "lbServiceType";
            this.lbServiceType.Size = new System.Drawing.Size(96, 20);
            this.lbServiceType.TabIndex = 7;
            this.lbServiceType.Text = "Service Type";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbStatus.Location = new System.Drawing.Point(447, 82);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(151, 28);
            this.cbStatus.TabIndex = 8;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbStatus.Location = new System.Drawing.Point(312, 82);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(53, 20);
            this.lbStatus.TabIndex = 9;
            this.lbStatus.Text = "Status";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(99, 202);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(508, 170);
            this.txtDescription.TabIndex = 10;
            this.txtDescription.Text = "Enter Service description..";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(143, 391);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(283, 391);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 29);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(417, 391);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(312, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Estimated Time";
            // 
            // cbEstimatedTime
            // 
            this.cbEstimatedTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstimatedTime.FormattingEnabled = true;
            this.cbEstimatedTime.Items.AddRange(new object[] {
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4"});
            this.cbEstimatedTime.Location = new System.Drawing.Point(447, 129);
            this.cbEstimatedTime.Name = "cbEstimatedTime";
            this.cbEstimatedTime.Size = new System.Drawing.Size(151, 28);
            this.cbEstimatedTime.TabIndex = 14;
            // 
            // frmServiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(667, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEstimatedTime);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lbServiceType);
            this.Controls.Add(this.cbServiceType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbServiceDetailID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox3);
            this.Name = "frmServiceDetail";
            this.Text = "frmServiceDetail";
            this.Load += new System.EventHandler(this.frmServiceDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbServiceDetailID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbServiceType;
        private System.Windows.Forms.Label lbServiceType;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEstimatedTime;
    }
}