namespace WinApp
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
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(403, 55);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 27);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lbServiceDetailID
            // 
            this.lbServiceDetailID.AutoSize = true;
            this.lbServiceDetailID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbServiceDetailID.Location = new System.Drawing.Point(29, 62);
            this.lbServiceDetailID.Name = "lbServiceDetailID";
            this.lbServiceDetailID.Size = new System.Drawing.Size(25, 20);
            this.lbServiceDetailID.TabIndex = 4;
            this.lbServiceDetailID.Text = "ID";
            this.lbServiceDetailID.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(312, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbServiceType
            // 
            this.cbServiceType.FormattingEnabled = true;
            this.cbServiceType.Location = new System.Drawing.Point(143, 118);
            this.cbServiceType.Name = "cbServiceType";
            this.cbServiceType.Size = new System.Drawing.Size(151, 28);
            this.cbServiceType.TabIndex = 6;
            this.cbServiceType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbServiceType
            // 
            this.lbServiceType.AutoSize = true;
            this.lbServiceType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbServiceType.Location = new System.Drawing.Point(29, 126);
            this.lbServiceType.Name = "lbServiceType";
            this.lbServiceType.Size = new System.Drawing.Size(96, 20);
            this.lbServiceType.TabIndex = 7;
            this.lbServiceType.Text = "Service Type";
            this.lbServiceType.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(403, 118);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(151, 28);
            this.cbStatus.TabIndex = 8;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbStatus.Location = new System.Drawing.Point(312, 126);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(53, 20);
            this.lbStatus.TabIndex = 9;
            this.lbStatus.Text = "Status";
            this.lbStatus.Click += new System.EventHandler(this.label4_Click);
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
            // frmServiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(667, 465);
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
    }
}