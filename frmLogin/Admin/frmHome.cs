﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject.Models;
using DataAccess;

namespace WinApp
{
    public partial class frmHome : Form
    {
        IServiceRepository ServiceRepository = new ServiceRepository();
        IServiceTypeRepository ServiceTypeRepository = new ServiceTypeRepository();
        IAppointmentRepository AppointmentRepository = new AppointmentRepository();
        ICustomerRepository CustomerRepository = new CustomerRepository();
        IAccountRepository AccountRepository = new AccountRepository();
        BindingSource source;
        List<Panel> panelList = new List<Panel>();
        public Account accountLogin { get; set; }

        int index;
        public frmHome()
        {
            InitializeComponent();
        }

        private void buttonAppointment_Click(object sender, EventArgs e)
        {
            panelCustomer.SendToBack();
            panelService.SendToBack();
            panelDentist.SendToBack();
            panelAppointment.BringToFront();
            buttonAppointment.BackColor = Color.LightBlue;
            buttonDentist.BackColor = Color.Lavender;
            buttonService.BackColor = Color.Lavender;
            buttonCustomer.BackColor = Color.Lavender;
            LoadAllAppointmentList();
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            panelCustomer.BringToFront();
            panelService.SendToBack();
            panelDentist.SendToBack();
            panelAppointment.SendToBack();
            buttonAppointment.BackColor = Color.Lavender;
            buttonDentist.BackColor = Color.Lavender;
            buttonService.BackColor = Color.Lavender;
            buttonCustomer.BackColor = Color.LightBlue;
            LoadCustomerList(CustomerRepository.GetAll());
        }

        private void buttonService_Click(object sender, EventArgs e)
        {
            panelDentist.SendToBack();
            panelAppointment.SendToBack();
            panelCustomer.SendToBack();
            panelService.BringToFront();
            buttonAppointment.BackColor = Color.Lavender;
            buttonDentist.BackColor = Color.Lavender;
            buttonService.BackColor = Color.LightBlue;
            buttonCustomer.BackColor = Color.Lavender;
            GetAllServiceList();
        }

        private void buttonDentist_Click(object sender, EventArgs e)
        {
            panelAppointment.SendToBack();
            panelCustomer.SendToBack();
            panelService.SendToBack();
            panelDentist.BringToFront();
            buttonAppointment.BackColor = Color.Lavender;
            buttonDentist.BackColor = Color.LightBlue;
            buttonService.BackColor = Color.Lavender;
            buttonCustomer.BackColor = Color.Lavender;
            LoadDentistList();
        }

      
        private void loadServiceList(List<Service> services)
        {
            buttonServiceDisable.Enabled = false;
            if (services.Count == 0) {
                buttonServiceUpdate.Enabled = false;
                buttonServiceDisable.Enabled = false;
            }
            else
            {
                buttonServiceUpdate.Enabled = true;
              
            }
        
            source = new BindingSource();
         //   source.DataSource = null;
            source.DataSource = services;
            dataGridViewService.DataSource = source;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            panelAppointment.BringToFront();
            LoadDentistList();
            GetAllServiceList();
            


        }

     

        private void labelService_Click(object sender, EventArgs e)
        {

        }

        private void buttonServiceAdd_Click(object sender, EventArgs e)
        {
            frmServiceDetail frmServiceDetail = new frmServiceDetail
            {
                ServiceRepository = this.ServiceRepository,
                Insert = true
            };
            if (frmServiceDetail.ShowDialog() == DialogResult.OK)
            {
                GetAllServiceList();
            }

        }

        private void txtLinkLabelNameAccountLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmProfile frmProfile = new frmProfile()
            {
                accountInfo = accountLogin,
                AccountLogin = accountLogin,
            };
            frmProfile.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void buttonServiceUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewService.CurrentRow != null)
            {
                Service service = (Service)dataGridViewService.CurrentRow.DataBoundItem;
                frmServiceDetail frmService = new frmServiceDetail
                {
                    ServiceRepository = this.ServiceRepository,
                    serviceData = service,
                    Insert = false


                };
                if (frmService.ShowDialog() == DialogResult.OK)
                {
                    GetAllServiceList();
                }
            }
        }

        private void panelService_Paint(object sender, PaintEventArgs e)
        {

            var StatusDictionary = new Dictionary<int, string>();

            StatusDictionary.Add(1, "Active");
            StatusDictionary.Add(2, "Inactive");
          
            comboBoxServiceStatus.DataSource = StatusDictionary.ToList();
            comboBoxServiceStatus.DisplayMember = "Value";
            comboBoxServiceStatus.ValueMember = "Key";

            if(ServiceTypeRepository.GetServiceTypeList().Count == 0)
            {
                buttonServiceAdd.Enabled = false;
            }
            comboBoxServiceType.DataSource = ServiceTypeRepository.GetServiceTypeList();
            comboBoxServiceType.DisplayMember = "name";
            comboBoxServiceType.ValueMember = "id";

          

            if (dataGridViewService.Columns["ServiceType"] != null)
                dataGridViewService.Columns["ServiceType"].Visible = false;

            if (dataGridViewService.Columns["AppointmentServices"] != null)
                dataGridViewService.Columns["AppointmentServices"].Visible = false;



        }

        private void dataGridViewService_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewService.CurrentRow != null)
            {
                Service service = (Service)dataGridViewService.CurrentRow.DataBoundItem;
                frmServiceDetail frmService = new frmServiceDetail
                {
                    ServiceRepository = this.ServiceRepository,
                    serviceData = service,
                    Insert = false


                };
               if (frmService.ShowDialog() == DialogResult.OK)
                {
                    GetAllServiceList();
                }
            }
        }

        private void btnServiceLoad_Click(object sender, EventArgs e)
        {
            loadServiceList(ServiceRepository.GetServices());
        }

        private void buttonServiceFind_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            if (!string.IsNullOrEmpty(textBoxServiceName.Text))
                service.Name = textBoxServiceName.Text;
            if(!string.IsNullOrEmpty(comboBoxServiceStatus.Text))
                service.Status = Int32.Parse(comboBoxServiceStatus.SelectedValue.ToString());
            if (!string.IsNullOrEmpty(comboBoxServiceType.Text))
                service.ServiceTypeId = Int32.Parse(comboBoxServiceType.SelectedValue.ToString());

            loadServiceList( ServiceRepository.FilterService(service));
          
                
           
        }
        
        private void GetAllServiceList()
        {
            
            loadServiceList(ServiceRepository.GetActiveServiceList());
        }

        private void buttonServiceDisable_Click(object sender, EventArgs e)
        {
            Service service = (Service)dataGridViewService.CurrentRow.DataBoundItem;
          
            service.Status = 2;
            DialogResult result = MessageBox.Show("Do you want to disable this service?", "Yes", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                ServiceRepository.UpdateService(service);
            }
            GetAllServiceList();
        }


      

        private void panelCustomer_Paint(object sender, PaintEventArgs e)
        {
            if (dataGridViewCustomer.Columns["Appointments"] != null)
                dataGridViewCustomer.Columns["Appointments"].Visible = false;

          

        }

        // load customer list
        private void btnCustomerLoad_Click(object sender, EventArgs e)
        {
            LoadCustomerList(CustomerRepository.GetAll());
        }
        private void LoadCustomerList(List<Customer> customers)
        {
            source = new BindingSource();
            List<CustomerChange> changeList = new List<CustomerChange>();
            foreach (Customer customer in customers)
            {
                CustomerChange change = new CustomerChange()
                {
                    Id = customer.Id,
                    Name = customer.Name,
                    Phone = customer.Phone,
                    Gender = customer.Gender ? "Male" : "Female",
                    Dob = customer.Dob,
                };
                changeList.Add(change);

            }
            source.DataSource = changeList;
            dataGridViewCustomer.DataSource = source;
        }

        // filter customer by name and phone
        private void buttonCustomerFind_Click(object sender, EventArgs e)
        {
            string CustomerName = textBoxCustomerName.Text;
            string CustomerPhone = textBoxCustomerPhone.Text;
            

            if(!string.IsNullOrEmpty(CustomerName) && !string.IsNullOrEmpty(CustomerPhone))
            {
                LoadCustomerList(CustomerRepository.SearchCustomerByNameAndPhone(CustomerName, CustomerPhone));
            }
            else  if (string.IsNullOrEmpty(CustomerName) && !string.IsNullOrEmpty(CustomerPhone)) {
                LoadCustomerList(CustomerRepository.SearchCustomerByPhone(CustomerPhone));
            }
            else if (!string.IsNullOrEmpty(CustomerName) && string.IsNullOrEmpty(CustomerPhone))
            {
                LoadCustomerList(CustomerRepository.SearchCustomerByName(CustomerName));
            }
        }

        private void LoadAllAppointmentList()
        {
            LoadAppointmentList( AppointmentRepository.GetAppointmentsForAdmin());

        }
        private void LoadAppointmentList(List<Appointment> appointments)
        {
           
                source = new BindingSource();
                source.DataSource = appointments;
                dataGridViewAppointment.DataSource = source;
            

        }

        // Load appointment list

        private void btnLoadAppointmentList_Click(object sender, EventArgs e)
        {
            LoadAllAppointmentList();
        }

        private void panelAppointment_Paint(object sender, PaintEventArgs e)
        {
            var StatusDictionary = new Dictionary<int, string>();
            StatusDictionary.Add(0, "All");
            StatusDictionary.Add(1, "Waiting");
            StatusDictionary.Add(2, "Done");
            StatusDictionary.Add(3, "Cancel");
            comboxAppointmentStatus.DataSource = StatusDictionary.ToArray();
            comboxAppointmentStatus.DisplayMember = "Value";
            comboxAppointmentStatus.ValueMember = "Key";
            

            var DentistList = AccountRepository.GetALLDentistList();
            comboBoxAppointmentDentist.SelectedIndex = -1;
            if (DentistList.ToList().Count > 0)
            {

                
                comboBoxAppointmentDentist.DataSource = AccountRepository.GetALLDentistList();
                comboBoxAppointmentDentist.DisplayMember = "Name";
                comboBoxAppointmentDentist.ValueMember = "Id";
              

            }

            if (dataGridViewAppointment.Columns["Customer"] != null)
                dataGridViewAppointment.Columns["Customer"].Visible = false;

            if (dataGridViewAppointment.Columns["Dentist"] != null)
                dataGridViewAppointment.Columns["Dentist"].Visible = false;

            if (dataGridViewAppointment.Columns["AppointmentServices"] != null)
                dataGridViewAppointment.Columns["AppointmentServices"].Visible = false;

        }




        // Dentist
        private void panelDentist_Paint_1(object sender, PaintEventArgs e)
        {

          

            var StatusDictionary = new Dictionary<decimal, string>();
            StatusDictionary.Add(1, "Active");
            StatusDictionary.Add(2, "Inactive");
            comboDentistStatus.DataSource = StatusDictionary.ToArray();
            comboDentistStatus.DisplayMember = "Value";
            comboDentistStatus.ValueMember = "Key";

            if (dataGridViewDentist.Columns["Appointments"] != null)
                dataGridViewDentist.Columns["Appointments"].Visible = false;
            if (dataGridViewDentist.Columns["Role"] != null)
                dataGridViewDentist.Columns["Role"].Visible = false;

           
        }

        private void buttonDentistAdd_Click(object sender, EventArgs e)
        {
            frmDentistDetail frmDentistDetail = new frmDentistDetail
            {
                AccountRepository = this.AccountRepository,
                Insert = true

            };
            if (frmDentistDetail.ShowDialog() == DialogResult.OK)
            {
                LoadDentistList();
            }
        }

        private void btnDentistLoad_Click(object sender, EventArgs e)
        {
            if (AccountRepository.GetALLDentistList().Count == 0 || dataGridViewDentist.Rows.Count == 0)
            {
                buttonDentistUpdate.Enabled = false;
                btnDisableDentist.Enabled = false;
            }
            else
            {
                buttonDentistUpdate.Enabled = true;
                btnDisableDentist.Enabled = true;
            }
            LoadDentistList();

        }

        private void GetAllDentists(List<Account> Dentists)
        {
            btnDisableDentist.Enabled = false;
            if (Dentists.Count == 0)
            {
                buttonDentistUpdate.Enabled = false;
                btnDisableDentist.Enabled = false;

            }
            else
            {
                buttonDentistUpdate.Enabled = true;
                
            }
            source = new BindingSource();
            source.DataSource = Dentists;
            dataGridViewDentist.DataSource = source;

        }

        private void LoadDentistList()
        {

            GetAllDentists(AccountRepository.GetActiveDentistList());
        }

        private void buttonDentistUpdate_Click(object sender, EventArgs e)
        {
            Account account = (Account)dataGridViewDentist.CurrentRow.DataBoundItem;
            frmDentistDetail frmDentistDetail = new frmDentistDetail
            {
                AccountRepository = this.AccountRepository,
                Insert = false,
                accountData = account

            };
            if (frmDentistDetail.ShowDialog() == DialogResult.OK)
            {
                LoadDentistList();
            }

        }

        private void dataGridViewDentist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Account account = (Account)dataGridViewDentist.CurrentRow.DataBoundItem;
            frmDentistDetail frmDentistDetail = new frmDentistDetail
            {
                AccountRepository = this.AccountRepository,
                Insert = false,
                accountData = account

            };
            if (frmDentistDetail.ShowDialog() == DialogResult.OK)
            {
                LoadDentistList();
            }
        }

        private void filterDentist_Click(object sender, EventArgs e)
        {
            try
            {
                string dentistName = textDentistName.Text;
               
                List<Account> DentistList = new List<Account>();
                Account account = new Account();

                if (!string.IsNullOrEmpty(dentistName))
                {
                    account.Name = dentistName;
                }
                if (!string.IsNullOrEmpty(comboDentistStatus.Text))
                {
                    account.Status = decimal.Parse(comboDentistStatus.SelectedValue.ToString());
                  
                }
               
                DentistList = AccountRepository.filterDentist(account);
               
                GetAllDentists(DentistList);
                

            } catch(Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
         
        }

        private void btnDisableDentist_Click(object sender, EventArgs e)
        {
            Account account = (Account)dataGridViewDentist.CurrentRow.DataBoundItem;

            account.Status = 2;
            DialogResult result = MessageBox.Show("Do you want to disable doctor?", "Yes", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                AccountRepository.UpdateAccount(account);
            }
            LoadDentistList();
        }

        private void buttonFindAppointment_Click(object sender, EventArgs e)
        {
            DateTime time = dateTimePickerAppointmentDate.Value.Date;
            string phone = textBoxAppointmentPhone.Text;
            int dentistId = 0;
            int status = 0;

            if (!string.IsNullOrEmpty(comboBoxAppointmentDentist.Text)) {
                dentistId = Int32.Parse(comboBoxAppointmentDentist.SelectedValue.ToString());
            }
        

            if (!string.IsNullOrEmpty(comboxAppointmentStatus.Text) || Int32.Parse(comboxAppointmentStatus.SelectedValue.ToString()) != 0){
                status = Int32.Parse(comboxAppointmentStatus.SelectedValue.ToString());
            }

           
            
          // LoadAppointmentList(AppointmentRepository.GetAppointmentList(time,phone,dentistId, (int)status));


            LoadAppointmentList( AppointmentRepository.FilterAppointmentForAdmin(time, phone, dentistId, status));

        }

     

        private void dataGridViewService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Service service = (Service)dataGridViewService.CurrentRow.DataBoundItem;
            if(service.Status ==2)
                buttonServiceDisable.Enabled = false;
            else
                buttonServiceDisable.Enabled = true;
        }

        private void dataGridViewDentist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Account account = (Account)dataGridViewDentist.CurrentRow.DataBoundItem;
            if (account.Status == 2)
                btnDisableDentist.Enabled = false;
            else
                btnDisableDentist.Enabled = true; ;
        }
    }
}
