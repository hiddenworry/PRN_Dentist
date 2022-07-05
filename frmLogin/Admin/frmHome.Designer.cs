namespace WinApp
{
    partial class frmHome
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
            this.panelService = new System.Windows.Forms.Panel();
            this.labelService = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelServiceStatus = new System.Windows.Forms.Label();
            this.comboBoxServiceStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxServiceType = new System.Windows.Forms.ComboBox();
            this.labelServiceType = new System.Windows.Forms.Label();
            this.buttonServiceFind = new System.Windows.Forms.Button();
            this.textBoxServiceName = new System.Windows.Forms.TextBox();
            this.labelServicename = new System.Windows.Forms.Label();
            this.buttonServiceDetail = new System.Windows.Forms.Button();
            this.buttonServiceUpdate = new System.Windows.Forms.Button();
            this.buttonServiceAdd = new System.Windows.Forms.Button();
            this.dataGridViewService = new System.Windows.Forms.DataGridView();
            this.panelDentist = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelDentist = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelDentistStatus = new System.Windows.Forms.Label();
            this.comboDentistStatus = new System.Windows.Forms.ComboBox();
            this.button = new System.Windows.Forms.Button();
            this.textDentistName = new System.Windows.Forms.TextBox();
            this.labelDentistName = new System.Windows.Forms.Label();
            this.buttonDentistDetail = new System.Windows.Forms.Button();
            this.buttonDentistUpdate = new System.Windows.Forms.Button();
            this.buttonDentistAdd = new System.Windows.Forms.Button();
            this.dataGridViewDentist = new System.Windows.Forms.DataGridView();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCustomerPhone = new System.Windows.Forms.TextBox();
            this.labelCustomerPhone = new System.Windows.Forms.Label();
            this.buttonCustomerFind = new System.Windows.Forms.Button();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.labelNameCustomer = new System.Windows.Forms.Label();
            this.buttonDetailCustomer = new System.Windows.Forms.Button();
            this.buttonCustomerUpdate = new System.Windows.Forms.Button();
            this.buttonCustomerAdd = new System.Windows.Forms.Button();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.buttonAppointment = new System.Windows.Forms.Button();
            this.buttonCustomer = new System.Windows.Forms.Button();
            this.buttonService = new System.Windows.Forms.Button();
            this.buttonDentist = new System.Windows.Forms.Button();
            this.panelAppointment = new System.Windows.Forms.Panel();
            this.labelAppointment = new System.Windows.Forms.Label();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonFindAppointment = new System.Windows.Forms.Button();
            this.textBoxAppointmentPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.dateTimePickerAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAppointmentDentist = new System.Windows.Forms.ComboBox();
            this.buttonAppointmentDetail = new System.Windows.Forms.Button();
            this.buttonAppointmentUpdate = new System.Windows.Forms.Button();
            this.buttonAppointmentAdd = new System.Windows.Forms.Button();
            this.dataGridViewAppointment = new System.Windows.Forms.DataGridView();
            this.txtLinkLabelNameAccountLogin = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.panelService.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).BeginInit();
            this.panelDentist.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDentist)).BeginInit();
            this.panelCustomer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.panelAppointment.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // panelService
            // 
            this.panelService.BackColor = System.Drawing.Color.LightBlue;
            this.panelService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelService.Controls.Add(this.labelService);
            this.panelService.Controls.Add(this.groupBox2);
            this.panelService.Controls.Add(this.buttonServiceDetail);
            this.panelService.Controls.Add(this.buttonServiceUpdate);
            this.panelService.Controls.Add(this.buttonServiceAdd);
            this.panelService.Controls.Add(this.dataGridViewService);
            this.panelService.Location = new System.Drawing.Point(814, 48);
            this.panelService.Name = "panelService";
            this.panelService.Size = new System.Drawing.Size(775, 450);
            this.panelService.TabIndex = 14;
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelService.Location = new System.Drawing.Point(110, 57);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(288, 37);
            this.labelService.TabIndex = 12;
            this.labelService.Text = "Service Management";
            this.labelService.Click += new System.EventHandler(this.labelService_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelServiceStatus);
            this.groupBox2.Controls.Add(this.comboBoxServiceStatus);
            this.groupBox2.Controls.Add(this.comboBoxServiceType);
            this.groupBox2.Controls.Add(this.labelServiceType);
            this.groupBox2.Controls.Add(this.buttonServiceFind);
            this.groupBox2.Controls.Add(this.textBoxServiceName);
            this.groupBox2.Controls.Add(this.labelServicename);
            this.groupBox2.Location = new System.Drawing.Point(501, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 166);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // labelServiceStatus
            // 
            this.labelServiceStatus.AutoSize = true;
            this.labelServiceStatus.Location = new System.Drawing.Point(18, 92);
            this.labelServiceStatus.Name = "labelServiceStatus";
            this.labelServiceStatus.Size = new System.Drawing.Size(49, 20);
            this.labelServiceStatus.TabIndex = 14;
            this.labelServiceStatus.Text = "Status";
            // 
            // comboBoxServiceStatus
            // 
            this.comboBoxServiceStatus.FormattingEnabled = true;
            this.comboBoxServiceStatus.Location = new System.Drawing.Point(85, 89);
            this.comboBoxServiceStatus.Name = "comboBoxServiceStatus";
            this.comboBoxServiceStatus.Size = new System.Drawing.Size(127, 28);
            this.comboBoxServiceStatus.TabIndex = 13;
            // 
            // comboBoxServiceType
            // 
            this.comboBoxServiceType.FormattingEnabled = true;
            this.comboBoxServiceType.Location = new System.Drawing.Point(85, 55);
            this.comboBoxServiceType.Name = "comboBoxServiceType";
            this.comboBoxServiceType.Size = new System.Drawing.Size(127, 28);
            this.comboBoxServiceType.TabIndex = 12;
            // 
            // labelServiceType
            // 
            this.labelServiceType.AutoSize = true;
            this.labelServiceType.Location = new System.Drawing.Point(18, 58);
            this.labelServiceType.Name = "labelServiceType";
            this.labelServiceType.Size = new System.Drawing.Size(40, 20);
            this.labelServiceType.TabIndex = 11;
            this.labelServiceType.Text = "Type";
            // 
            // buttonServiceFind
            // 
            this.buttonServiceFind.Location = new System.Drawing.Point(56, 126);
            this.buttonServiceFind.Name = "buttonServiceFind";
            this.buttonServiceFind.Size = new System.Drawing.Size(139, 29);
            this.buttonServiceFind.TabIndex = 10;
            this.buttonServiceFind.Text = "Find";
            this.buttonServiceFind.UseVisualStyleBackColor = true;
            // 
            // textBoxServiceName
            // 
            this.textBoxServiceName.Location = new System.Drawing.Point(85, 20);
            this.textBoxServiceName.Name = "textBoxServiceName";
            this.textBoxServiceName.Size = new System.Drawing.Size(127, 27);
            this.textBoxServiceName.TabIndex = 6;
            // 
            // labelServicename
            // 
            this.labelServicename.AutoSize = true;
            this.labelServicename.Location = new System.Drawing.Point(18, 25);
            this.labelServicename.Name = "labelServicename";
            this.labelServicename.Size = new System.Drawing.Size(49, 20);
            this.labelServicename.TabIndex = 4;
            this.labelServicename.Text = "Name";
            // 
            // buttonServiceDetail
            // 
            this.buttonServiceDetail.Location = new System.Drawing.Point(340, 141);
            this.buttonServiceDetail.Name = "buttonServiceDetail";
            this.buttonServiceDetail.Size = new System.Drawing.Size(139, 29);
            this.buttonServiceDetail.TabIndex = 9;
            this.buttonServiceDetail.Text = "Detail";
            this.buttonServiceDetail.UseVisualStyleBackColor = true;
            // 
            // buttonServiceUpdate
            // 
            this.buttonServiceUpdate.Location = new System.Drawing.Point(195, 141);
            this.buttonServiceUpdate.Name = "buttonServiceUpdate";
            this.buttonServiceUpdate.Size = new System.Drawing.Size(139, 29);
            this.buttonServiceUpdate.TabIndex = 8;
            this.buttonServiceUpdate.Text = "Update";
            this.buttonServiceUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonServiceAdd
            // 
            this.buttonServiceAdd.Location = new System.Drawing.Point(50, 141);
            this.buttonServiceAdd.Name = "buttonServiceAdd";
            this.buttonServiceAdd.Size = new System.Drawing.Size(139, 29);
            this.buttonServiceAdd.TabIndex = 5;
            this.buttonServiceAdd.Text = "Add";
            this.buttonServiceAdd.UseVisualStyleBackColor = true;
            this.buttonServiceAdd.Click += new System.EventHandler(this.buttonServiceAdd_Click);
            // 
            // dataGridViewService
            // 
            this.dataGridViewService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewService.Location = new System.Drawing.Point(3, 176);
            this.dataGridViewService.Name = "dataGridViewService";
            this.dataGridViewService.RowHeadersWidth = 51;
            this.dataGridViewService.RowTemplate.Height = 29;
            this.dataGridViewService.Size = new System.Drawing.Size(754, 261);
            this.dataGridViewService.TabIndex = 7;
            // 
            // panelDentist
            // 
            this.panelDentist.BackColor = System.Drawing.Color.LightBlue;
            this.panelDentist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDentist.Controls.Add(this.button1);
            this.panelDentist.Controls.Add(this.labelDentist);
            this.panelDentist.Controls.Add(this.groupBox3);
            this.panelDentist.Controls.Add(this.buttonDentistDetail);
            this.panelDentist.Controls.Add(this.buttonDentistUpdate);
            this.panelDentist.Controls.Add(this.buttonDentistAdd);
            this.panelDentist.Controls.Add(this.dataGridViewDentist);
            this.panelDentist.Location = new System.Drawing.Point(814, 520);
            this.panelDentist.Name = "panelDentist";
            this.panelDentist.Size = new System.Drawing.Size(775, 450);
            this.panelDentist.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelDentist
            // 
            this.labelDentist.AutoSize = true;
            this.labelDentist.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDentist.Location = new System.Drawing.Point(109, 45);
            this.labelDentist.Name = "labelDentist";
            this.labelDentist.Size = new System.Drawing.Size(288, 37);
            this.labelDentist.TabIndex = 12;
            this.labelDentist.Text = "Dentist Management";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelDentistStatus);
            this.groupBox3.Controls.Add(this.comboDentistStatus);
            this.groupBox3.Controls.Add(this.button);
            this.groupBox3.Controls.Add(this.textDentistName);
            this.groupBox3.Controls.Add(this.labelDentistName);
            this.groupBox3.Location = new System.Drawing.Point(501, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 166);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter";
            // 
            // labelDentistStatus
            // 
            this.labelDentistStatus.AutoSize = true;
            this.labelDentistStatus.Location = new System.Drawing.Point(18, 78);
            this.labelDentistStatus.Name = "labelDentistStatus";
            this.labelDentistStatus.Size = new System.Drawing.Size(49, 20);
            this.labelDentistStatus.TabIndex = 14;
            this.labelDentistStatus.Text = "Status";
            // 
            // comboDentistStatus
            // 
            this.comboDentistStatus.FormattingEnabled = true;
            this.comboDentistStatus.Location = new System.Drawing.Point(80, 75);
            this.comboDentistStatus.Name = "comboDentistStatus";
            this.comboDentistStatus.Size = new System.Drawing.Size(127, 28);
            this.comboDentistStatus.TabIndex = 13;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(77, 123);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(139, 29);
            this.button.TabIndex = 10;
            this.button.Text = "Find";
            this.button.UseVisualStyleBackColor = true;
            // 
            // textDentistName
            // 
            this.textDentistName.Location = new System.Drawing.Point(80, 37);
            this.textDentistName.Name = "textDentistName";
            this.textDentistName.Size = new System.Drawing.Size(127, 27);
            this.textDentistName.TabIndex = 6;
            // 
            // labelDentistName
            // 
            this.labelDentistName.AutoSize = true;
            this.labelDentistName.Location = new System.Drawing.Point(18, 39);
            this.labelDentistName.Name = "labelDentistName";
            this.labelDentistName.Size = new System.Drawing.Size(49, 20);
            this.labelDentistName.TabIndex = 4;
            this.labelDentistName.Text = "Name";
            // 
            // buttonDentistDetail
            // 
            this.buttonDentistDetail.Location = new System.Drawing.Point(240, 141);
            this.buttonDentistDetail.Name = "buttonDentistDetail";
            this.buttonDentistDetail.Size = new System.Drawing.Size(126, 29);
            this.buttonDentistDetail.TabIndex = 9;
            this.buttonDentistDetail.Text = "Detail";
            this.buttonDentistDetail.UseVisualStyleBackColor = true;
            // 
            // buttonDentistUpdate
            // 
            this.buttonDentistUpdate.Location = new System.Drawing.Point(130, 141);
            this.buttonDentistUpdate.Name = "buttonDentistUpdate";
            this.buttonDentistUpdate.Size = new System.Drawing.Size(104, 29);
            this.buttonDentistUpdate.TabIndex = 8;
            this.buttonDentistUpdate.Text = "Update";
            this.buttonDentistUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDentistAdd
            // 
            this.buttonDentistAdd.Location = new System.Drawing.Point(17, 141);
            this.buttonDentistAdd.Name = "buttonDentistAdd";
            this.buttonDentistAdd.Size = new System.Drawing.Size(107, 29);
            this.buttonDentistAdd.TabIndex = 5;
            this.buttonDentistAdd.Text = "Add";
            this.buttonDentistAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDentist
            // 
            this.dataGridViewDentist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDentist.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewDentist.Location = new System.Drawing.Point(-1, 176);
            this.dataGridViewDentist.Name = "dataGridViewDentist";
            this.dataGridViewDentist.RowHeadersWidth = 51;
            this.dataGridViewDentist.RowTemplate.Height = 29;
            this.dataGridViewDentist.Size = new System.Drawing.Size(754, 261);
            this.dataGridViewDentist.TabIndex = 7;
            // 
            // panelCustomer
            // 
            this.panelCustomer.BackColor = System.Drawing.Color.LightBlue;
            this.panelCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCustomer.Controls.Add(this.labelCustomer);
            this.panelCustomer.Controls.Add(this.groupBox1);
            this.panelCustomer.Controls.Add(this.buttonDetailCustomer);
            this.panelCustomer.Controls.Add(this.buttonCustomerUpdate);
            this.panelCustomer.Controls.Add(this.buttonCustomerAdd);
            this.panelCustomer.Controls.Add(this.dataGridViewCustomer);
            this.panelCustomer.Location = new System.Drawing.Point(3, 520);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(775, 450);
            this.panelCustomer.TabIndex = 13;
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCustomer.Location = new System.Drawing.Point(108, 59);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(319, 37);
            this.labelCustomer.TabIndex = 12;
            this.labelCustomer.Text = "Customer Management";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCustomerPhone);
            this.groupBox1.Controls.Add(this.labelCustomerPhone);
            this.groupBox1.Controls.Add(this.buttonCustomerFind);
            this.groupBox1.Controls.Add(this.textBoxCustomerName);
            this.groupBox1.Controls.Add(this.labelNameCustomer);
            this.groupBox1.Location = new System.Drawing.Point(501, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 166);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // textBoxCustomerPhone
            // 
            this.textBoxCustomerPhone.Location = new System.Drawing.Point(85, 64);
            this.textBoxCustomerPhone.Name = "textBoxCustomerPhone";
            this.textBoxCustomerPhone.Size = new System.Drawing.Size(127, 27);
            this.textBoxCustomerPhone.TabIndex = 12;
            // 
            // labelCustomerPhone
            // 
            this.labelCustomerPhone.AutoSize = true;
            this.labelCustomerPhone.Location = new System.Drawing.Point(18, 67);
            this.labelCustomerPhone.Name = "labelCustomerPhone";
            this.labelCustomerPhone.Size = new System.Drawing.Size(50, 20);
            this.labelCustomerPhone.TabIndex = 11;
            this.labelCustomerPhone.Text = "Phone";
            // 
            // buttonCustomerFind
            // 
            this.buttonCustomerFind.Location = new System.Drawing.Point(73, 122);
            this.buttonCustomerFind.Name = "buttonCustomerFind";
            this.buttonCustomerFind.Size = new System.Drawing.Size(139, 29);
            this.buttonCustomerFind.TabIndex = 10;
            this.buttonCustomerFind.Text = "Find";
            this.buttonCustomerFind.UseVisualStyleBackColor = true;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(85, 31);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(127, 27);
            this.textBoxCustomerName.TabIndex = 6;
            // 
            // labelNameCustomer
            // 
            this.labelNameCustomer.AutoSize = true;
            this.labelNameCustomer.Location = new System.Drawing.Point(18, 34);
            this.labelNameCustomer.Name = "labelNameCustomer";
            this.labelNameCustomer.Size = new System.Drawing.Size(49, 20);
            this.labelNameCustomer.TabIndex = 4;
            this.labelNameCustomer.Text = "Name";
            // 
            // buttonDetailCustomer
            // 
            this.buttonDetailCustomer.Location = new System.Drawing.Point(340, 141);
            this.buttonDetailCustomer.Name = "buttonDetailCustomer";
            this.buttonDetailCustomer.Size = new System.Drawing.Size(139, 29);
            this.buttonDetailCustomer.TabIndex = 9;
            this.buttonDetailCustomer.Text = "Detail";
            this.buttonDetailCustomer.UseVisualStyleBackColor = true;
            // 
            // buttonCustomerUpdate
            // 
            this.buttonCustomerUpdate.Location = new System.Drawing.Point(195, 141);
            this.buttonCustomerUpdate.Name = "buttonCustomerUpdate";
            this.buttonCustomerUpdate.Size = new System.Drawing.Size(139, 29);
            this.buttonCustomerUpdate.TabIndex = 8;
            this.buttonCustomerUpdate.Text = "Update";
            this.buttonCustomerUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonCustomerAdd
            // 
            this.buttonCustomerAdd.Location = new System.Drawing.Point(50, 141);
            this.buttonCustomerAdd.Name = "buttonCustomerAdd";
            this.buttonCustomerAdd.Size = new System.Drawing.Size(139, 29);
            this.buttonCustomerAdd.TabIndex = 5;
            this.buttonCustomerAdd.Text = "Add";
            this.buttonCustomerAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(3, 176);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.RowHeadersWidth = 51;
            this.dataGridViewCustomer.RowTemplate.Height = 29;
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
            // buttonService
            // 
            this.buttonService.Location = new System.Drawing.Point(411, 12);
            this.buttonService.Name = "buttonService";
            this.buttonService.Size = new System.Drawing.Size(139, 29);
            this.buttonService.TabIndex = 3;
            this.buttonService.Text = "Service";
            this.buttonService.UseVisualStyleBackColor = true;
            this.buttonService.Click += new System.EventHandler(this.buttonService_Click);
            // 
            // buttonDentist
            // 
            this.buttonDentist.Location = new System.Drawing.Point(587, 12);
            this.buttonDentist.Name = "buttonDentist";
            this.buttonDentist.Size = new System.Drawing.Size(139, 29);
            this.buttonDentist.TabIndex = 4;
            this.buttonDentist.Text = "Dentist";
            this.buttonDentist.UseVisualStyleBackColor = true;
            this.buttonDentist.Click += new System.EventHandler(this.buttonDentist_Click);
            // 
            // panelAppointment
            // 
            this.panelAppointment.BackColor = System.Drawing.Color.LightBlue;
            this.panelAppointment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAppointment.Controls.Add(this.labelAppointment);
            this.panelAppointment.Controls.Add(this.groupBoxFilter);
            this.panelAppointment.Controls.Add(this.buttonAppointmentDetail);
            this.panelAppointment.Controls.Add(this.buttonAppointmentUpdate);
            this.panelAppointment.Controls.Add(this.buttonAppointmentAdd);
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
            this.labelAppointment.Size = new System.Drawing.Size(367, 37);
            this.labelAppointment.TabIndex = 12;
            this.labelAppointment.Text = "Appointment Management";
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.label2);
            this.groupBoxFilter.Controls.Add(this.comboBox1);
            this.groupBoxFilter.Controls.Add(this.buttonFindAppointment);
            this.groupBoxFilter.Controls.Add(this.textBoxAppointmentPhone);
            this.groupBoxFilter.Controls.Add(this.label3);
            this.groupBoxFilter.Controls.Add(this.labelPhone);
            this.groupBoxFilter.Controls.Add(this.dateTimePickerAppointmentDate);
            this.groupBoxFilter.Controls.Add(this.label1);
            this.groupBoxFilter.Controls.Add(this.comboBoxAppointmentDentist);
            this.groupBoxFilter.Location = new System.Drawing.Point(501, 4);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(225, 195);
            this.groupBoxFilter.TabIndex = 11;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Filter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Status";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 28);
            this.comboBox1.TabIndex = 11;
            // 
            // buttonFindAppointment
            // 
            this.buttonFindAppointment.Location = new System.Drawing.Point(43, 160);
            this.buttonFindAppointment.Name = "buttonFindAppointment";
            this.buttonFindAppointment.Size = new System.Drawing.Size(139, 29);
            this.buttonFindAppointment.TabIndex = 10;
            this.buttonFindAppointment.Text = "Find";
            this.buttonFindAppointment.UseVisualStyleBackColor = true;
            // 
            // textBoxAppointmentPhone
            // 
            this.textBoxAppointmentPhone.Location = new System.Drawing.Point(77, 59);
            this.textBoxAppointmentPhone.Name = "textBoxAppointmentPhone";
            this.textBoxAppointmentPhone.Size = new System.Drawing.Size(127, 27);
            this.textBoxAppointmentPhone.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(6, 64);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(50, 20);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Phone";
            // 
            // dateTimePickerAppointmentDate
            // 
            this.dateTimePickerAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAppointmentDate.Location = new System.Drawing.Point(77, 26);
            this.dateTimePickerAppointmentDate.Name = "dateTimePickerAppointmentDate";
            this.dateTimePickerAppointmentDate.Size = new System.Drawing.Size(127, 27);
            this.dateTimePickerAppointmentDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dentist";
            // 
            // comboBoxAppointmentDentist
            // 
            this.comboBoxAppointmentDentist.FormattingEnabled = true;
            this.comboBoxAppointmentDentist.Location = new System.Drawing.Point(77, 92);
            this.comboBoxAppointmentDentist.Name = "comboBoxAppointmentDentist";
            this.comboBoxAppointmentDentist.Size = new System.Drawing.Size(127, 28);
            this.comboBoxAppointmentDentist.TabIndex = 0;
            // 
            // buttonAppointmentDetail
            // 
            this.buttonAppointmentDetail.Location = new System.Drawing.Point(336, 164);
            this.buttonAppointmentDetail.Name = "buttonAppointmentDetail";
            this.buttonAppointmentDetail.Size = new System.Drawing.Size(139, 29);
            this.buttonAppointmentDetail.TabIndex = 9;
            this.buttonAppointmentDetail.Text = "Detail";
            this.buttonAppointmentDetail.UseVisualStyleBackColor = true;
            // 
            // buttonAppointmentUpdate
            // 
            this.buttonAppointmentUpdate.Location = new System.Drawing.Point(191, 164);
            this.buttonAppointmentUpdate.Name = "buttonAppointmentUpdate";
            this.buttonAppointmentUpdate.Size = new System.Drawing.Size(139, 29);
            this.buttonAppointmentUpdate.TabIndex = 8;
            this.buttonAppointmentUpdate.Text = "Update";
            this.buttonAppointmentUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonAppointmentAdd
            // 
            this.buttonAppointmentAdd.Location = new System.Drawing.Point(46, 164);
            this.buttonAppointmentAdd.Name = "buttonAppointmentAdd";
            this.buttonAppointmentAdd.Size = new System.Drawing.Size(139, 29);
            this.buttonAppointmentAdd.TabIndex = 5;
            this.buttonAppointmentAdd.Text = "Add";
            this.buttonAppointmentAdd.UseVisualStyleBackColor = true;
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
            // txtLinkLabelNameAccountLogin
            // 
            this.txtLinkLabelNameAccountLogin.AutoSize = true;
            this.txtLinkLabelNameAccountLogin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLinkLabelNameAccountLogin.Location = new System.Drawing.Point(1399, 16);
            this.txtLinkLabelNameAccountLogin.Name = "txtLinkLabelNameAccountLogin";
            this.txtLinkLabelNameAccountLogin.Size = new System.Drawing.Size(90, 25);
            this.txtLinkLabelNameAccountLogin.TabIndex = 27;
            this.txtLinkLabelNameAccountLogin.TabStop = true;
            this.txtLinkLabelNameAccountLogin.Text = "linkLabel1";
            this.txtLinkLabelNameAccountLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtLinkLabelNameAccountLogin_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(1316, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Welcome, ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1616, 1022);
            this.Controls.Add(this.txtLinkLabelNameAccountLogin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panelAppointment);
            this.Controls.Add(this.panelCustomer);
            this.Controls.Add(this.panelDentist);
            this.Controls.Add(this.panelService);
            this.Controls.Add(this.buttonDentist);
            this.Controls.Add(this.buttonService);
            this.Controls.Add(this.buttonCustomer);
            this.Controls.Add(this.buttonAppointment);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panelService.ResumeLayout(false);
            this.panelService.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).EndInit();
            this.panelDentist.ResumeLayout(false);
            this.panelDentist.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDentist)).EndInit();
            this.panelCustomer.ResumeLayout(false);
            this.panelCustomer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.panelAppointment.ResumeLayout(false);
            this.panelAppointment.PerformLayout();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAppointment;
        private System.Windows.Forms.Button buttonCustomer;
        private System.Windows.Forms.Button buttonService;
        private System.Windows.Forms.Button buttonDentist;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCustomerFind;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label labelNameCustomer;
        private System.Windows.Forms.Button buttonDetailCustomer;
        private System.Windows.Forms.Button buttonCustomerUpdate;
        private System.Windows.Forms.Button buttonCustomerAdd;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.TextBox textBoxCustomerPhone;
        private System.Windows.Forms.Label labelCustomerPhone;
        private System.Windows.Forms.Panel panelService;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelServiceType;
        private System.Windows.Forms.Button buttonServiceFind;
        private System.Windows.Forms.TextBox textBoxServiceName;
        private System.Windows.Forms.Label labelServicename;
        private System.Windows.Forms.Button buttonServiceDetail;
        private System.Windows.Forms.Button buttonServiceUpdate;
        private System.Windows.Forms.Button buttonServiceAdd;
        private System.Windows.Forms.DataGridView dataGridViewService;
        private System.Windows.Forms.ComboBox comboBoxServiceType;
        private System.Windows.Forms.Label labelServiceStatus;
        private System.Windows.Forms.ComboBox comboBoxServiceStatus;
        private System.Windows.Forms.Panel panelDentist;
        private System.Windows.Forms.Label labelDentist;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelDentistStatus;
        private System.Windows.Forms.ComboBox comboDentistStatus;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox textDentistName;
        private System.Windows.Forms.Label labelDentistName;
        private System.Windows.Forms.Button buttonDentistDetail;
        private System.Windows.Forms.Button buttonDentistUpdate;
        private System.Windows.Forms.Button buttonDentistAdd;
        private System.Windows.Forms.DataGridView dataGridViewDentist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelAppointment;
        private System.Windows.Forms.Label labelAppointment;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonFindAppointment;
        private System.Windows.Forms.TextBox textBoxAppointmentPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointmentDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAppointmentDentist;
        private System.Windows.Forms.Button buttonAppointmentDetail;
        private System.Windows.Forms.Button buttonAppointmentUpdate;
        private System.Windows.Forms.Button buttonAppointmentAdd;
        private System.Windows.Forms.DataGridView dataGridViewAppointment;
        private System.Windows.Forms.LinkLabel txtLinkLabelNameAccountLogin;
        private System.Windows.Forms.Label label8;
    }
}