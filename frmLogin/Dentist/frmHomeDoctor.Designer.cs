namespace WinApp
{
    partial class frmHomeDoctor
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
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.btnNextCustomer = new System.Windows.Forms.Button();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.buttonAppointment = new System.Windows.Forms.Button();
            this.buttonCustomer = new System.Windows.Forms.Button();
            this.panelAppointment = new System.Windows.Forms.Panel();
            this.labelAppointment = new System.Windows.Forms.Label();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.buttonFindAppointment = new System.Windows.Forms.Button();
            this.textBoxAppointmentPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.btnNextAppointment = new System.Windows.Forms.Button();
            this.dataGridViewAppointment = new System.Windows.Forms.DataGridView();
            this.panelUpdateAppointment = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnViewHistoryCustomer = new System.Windows.Forms.Button();
            this.panelCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.panelAppointment.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointment)).BeginInit();
            this.panelUpdateAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCustomer
            // 
            this.panelCustomer.BackColor = System.Drawing.Color.LightBlue;
            this.panelCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCustomer.Controls.Add(this.labelCustomer);
            this.panelCustomer.Controls.Add(this.btnNextCustomer);
            this.panelCustomer.Controls.Add(this.dataGridViewCustomer);
            this.panelCustomer.Location = new System.Drawing.Point(812, 48);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(775, 450);
            this.panelCustomer.TabIndex = 13;
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCustomer.Location = new System.Drawing.Point(55, 59);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(278, 37);
            this.labelCustomer.TabIndex = 12;
            this.labelCustomer.Text = "History of Customer";
            // 
            // btnNextCustomer
            // 
            this.btnNextCustomer.Location = new System.Drawing.Point(182, 141);
            this.btnNextCustomer.Name = "btnNextCustomer";
            this.btnNextCustomer.Size = new System.Drawing.Size(139, 29);
            this.btnNextCustomer.TabIndex = 9;
            this.btnNextCustomer.Text = "Next";
            this.btnNextCustomer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(3, 176);
            this.dataGridViewCustomer.MultiSelect = false;
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.ReadOnly = true;
            this.dataGridViewCustomer.RowHeadersWidth = 51;
            this.dataGridViewCustomer.RowTemplate.Height = 29;
            this.dataGridViewCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.dataGridViewCustomer.ShowEditingIcon = false;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(754, 257);
            this.dataGridViewCustomer.TabIndex = 7;
            // 
            // buttonAppointment
            // 
            this.buttonAppointment.BackColor = System.Drawing.Color.LightBlue;
            this.buttonAppointment.Location = new System.Drawing.Point(49, 12);
            this.buttonAppointment.Name = "buttonAppointment";
            this.buttonAppointment.Size = new System.Drawing.Size(139, 29);
            this.buttonAppointment.TabIndex = 1;
            this.buttonAppointment.Text = "Appointment";
            this.buttonAppointment.UseVisualStyleBackColor = false;
            this.buttonAppointment.Click += new System.EventHandler(this.buttonAppointment_Click);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Location = new System.Drawing.Point(230, 12);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Size = new System.Drawing.Size(139, 29);
            this.buttonCustomer.TabIndex = 2;
            this.buttonCustomer.Text = "Customer";
            this.buttonCustomer.UseVisualStyleBackColor = true;
            this.buttonCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
            // 
            // panelAppointment
            // 
            this.panelAppointment.BackColor = System.Drawing.Color.LightBlue;
            this.panelAppointment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAppointment.Controls.Add(this.labelAppointment);
            this.panelAppointment.Controls.Add(this.groupBoxFilter);
            this.panelAppointment.Controls.Add(this.btnNextAppointment);
            this.panelAppointment.Controls.Add(this.dataGridViewAppointment);
            this.panelAppointment.Location = new System.Drawing.Point(12, 48);
            this.panelAppointment.Name = "panelAppointment";
            this.panelAppointment.Size = new System.Drawing.Size(775, 450);
            this.panelAppointment.TabIndex = 16;
            // 
            // labelAppointment
            // 
            this.labelAppointment.AutoSize = true;
            this.labelAppointment.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAppointment.Location = new System.Drawing.Point(85, 59);
            this.labelAppointment.Name = "labelAppointment";
            this.labelAppointment.Size = new System.Drawing.Size(248, 37);
            this.labelAppointment.TabIndex = 12;
            this.labelAppointment.Text = "List Appointment ";
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.buttonFindAppointment);
            this.groupBoxFilter.Controls.Add(this.textBoxAppointmentPhone);
            this.groupBoxFilter.Controls.Add(this.labelPhone);
            this.groupBoxFilter.Location = new System.Drawing.Point(508, 38);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(225, 140);
            this.groupBoxFilter.TabIndex = 11;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter";
            // 
            // buttonFindAppointment
            // 
            this.buttonFindAppointment.Location = new System.Drawing.Point(81, 80);
            this.buttonFindAppointment.Name = "buttonFindAppointment";
            this.buttonFindAppointment.Size = new System.Drawing.Size(127, 29);
            this.buttonFindAppointment.TabIndex = 10;
            this.buttonFindAppointment.Text = "Find";
            this.buttonFindAppointment.UseVisualStyleBackColor = true;
            this.buttonFindAppointment.Click += new System.EventHandler(this.buttonFindAppointment_Click);
            // 
            // textBoxAppointmentPhone
            // 
            this.textBoxAppointmentPhone.Location = new System.Drawing.Point(81, 47);
            this.textBoxAppointmentPhone.Name = "textBoxAppointmentPhone";
            this.textBoxAppointmentPhone.Size = new System.Drawing.Size(127, 27);
            this.textBoxAppointmentPhone.TabIndex = 6;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(10, 52);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(50, 20);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Phone";
            // 
            // btnNextAppointment
            // 
            this.btnNextAppointment.Location = new System.Drawing.Point(313, 159);
            this.btnNextAppointment.Name = "btnNextAppointment";
            this.btnNextAppointment.Size = new System.Drawing.Size(139, 29);
            this.btnNextAppointment.TabIndex = 9;
            this.btnNextAppointment.Text = "Next";
            this.btnNextAppointment.UseVisualStyleBackColor = true;
            this.btnNextAppointment.Click += new System.EventHandler(this.btnNextAppointment_Click);
            // 
            // dataGridViewAppointment
            // 
            this.dataGridViewAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointment.Location = new System.Drawing.Point(-1, 205);
            this.dataGridViewAppointment.Name = "dataGridViewAppointment";
            this.dataGridViewAppointment.RowHeadersWidth = 51;
            this.dataGridViewAppointment.RowTemplate.Height = 29;
            this.dataGridViewAppointment.Size = new System.Drawing.Size(758, 232);
            this.dataGridViewAppointment.TabIndex = 7;
            // 
            // panelUpdateAppointment
            // 
            this.panelUpdateAppointment.BackColor = System.Drawing.Color.LightBlue;
            this.panelUpdateAppointment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUpdateAppointment.Controls.Add(this.btnViewHistoryCustomer);
            this.panelUpdateAppointment.Controls.Add(this.textBox5);
            this.panelUpdateAppointment.Controls.Add(this.label5);
            this.panelUpdateAppointment.Controls.Add(this.textBox4);
            this.panelUpdateAppointment.Controls.Add(this.label4);
            this.panelUpdateAppointment.Controls.Add(this.textBox3);
            this.panelUpdateAppointment.Controls.Add(this.label3);
            this.panelUpdateAppointment.Controls.Add(this.textBox2);
            this.panelUpdateAppointment.Controls.Add(this.Name);
            this.panelUpdateAppointment.Controls.Add(this.txtDescription);
            this.panelUpdateAppointment.Controls.Add(this.label1);
            this.panelUpdateAppointment.Controls.Add(this.btnFinish);
            this.panelUpdateAppointment.Controls.Add(this.dgvService);
            this.panelUpdateAppointment.Location = new System.Drawing.Point(12, 530);
            this.panelUpdateAppointment.Name = "panelUpdateAppointment";
            this.panelUpdateAppointment.Size = new System.Drawing.Size(775, 450);
            this.panelUpdateAppointment.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Update Appointment";
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(313, 404);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(139, 29);
            this.btnFinish.TabIndex = 9;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            // 
            // dgvService
            // 
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Location = new System.Drawing.Point(3, 196);
            this.dgvService.MultiSelect = false;
            this.dgvService.Name = "dgvService";
            this.dgvService.ReadOnly = true;
            this.dgvService.RowHeadersWidth = 51;
            this.dgvService.RowTemplate.Height = 29;
            this.dgvService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.dgvService.ShowEditingIcon = false;
            this.dgvService.Size = new System.Drawing.Size(370, 187);
            this.dgvService.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(379, 196);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(391, 187);
            this.txtDescription.TabIndex = 13;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(18, 66);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(49, 20);
            this.Name.TabIndex = 14;
            this.Name.Text = "Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 27);
            this.textBox2.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Gender";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(85, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(224, 27);
            this.textBox3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Date Of Birth";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(471, 66);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(224, 27);
            this.textBox4.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phone";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(471, 119);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(224, 27);
            this.textBox5.TabIndex = 15;
            // 
            // btnViewHistoryCustomer
            // 
            this.btnViewHistoryCustomer.Location = new System.Drawing.Point(313, 161);
            this.btnViewHistoryCustomer.Name = "btnViewHistoryCustomer";
            this.btnViewHistoryCustomer.Size = new System.Drawing.Size(139, 29);
            this.btnViewHistoryCustomer.TabIndex = 16;
            this.btnViewHistoryCustomer.Text = "View history";
            this.btnViewHistoryCustomer.UseVisualStyleBackColor = true;
            // 
            // frmHomeDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1616, 1022);
            this.Controls.Add(this.panelUpdateAppointment);
            this.Controls.Add(this.panelAppointment);
            this.Controls.Add(this.panelCustomer);
            this.Controls.Add(this.buttonCustomer);
            this.Controls.Add(this.buttonAppointment);
            this.Name = "frmHomeDoctor";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panelCustomer.ResumeLayout(false);
            this.panelCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.panelAppointment.ResumeLayout(false);
            this.panelAppointment.PerformLayout();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointment)).EndInit();
            this.panelUpdateAppointment.ResumeLayout(false);
            this.panelUpdateAppointment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAppointment;
        private System.Windows.Forms.Button buttonCustomer;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.Button btnNextCustomer;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.Panel panelAppointment;
        private System.Windows.Forms.Label labelAppointment;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Button buttonFindAppointment;
        private System.Windows.Forms.TextBox textBoxAppointmentPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Button btnNextAppointment;
        private System.Windows.Forms.DataGridView dataGridViewAppointment;
        private System.Windows.Forms.Panel panelUpdateAppointment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.Button btnViewHistoryCustomer;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox txtDescription;
    }
}