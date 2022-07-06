using System;
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
        }

      
        private void loadServiceList(List<Service> services)
        {
            source = new BindingSource();
         //   source.DataSource = null;
            source.DataSource = services;
            dataGridViewService.DataSource = source;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            panelAppointment.BringToFront();
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
            frmServiceDetail.Show();

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

            source.DataSource = ServiceRepository.FilterService(service);
          
                
           
        }

        private void GetAllServiceList()
        {
            loadServiceList(ServiceRepository.GetServices());
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
            source = new BindingSource();
            source.DataSource = CustomerRepository.GetAll();
            dataGridViewCustomer.DataSource = source;
        }

        // filter customer by name and phone
        private void buttonCustomerFind_Click(object sender, EventArgs e)
        {
            string CustomerName = textBoxCustomerName.Text;
            string CustomerPhone = textBoxCustomerPhone.Text;
            

            if(!string.IsNullOrEmpty(CustomerName) && !string.IsNullOrEmpty(CustomerPhone))
            {
                source.DataSource = CustomerRepository.SearchCustomerByNameAndPhone(CustomerName, CustomerPhone);
            }
            else  if (string.IsNullOrEmpty(CustomerName) && !string.IsNullOrEmpty(CustomerPhone)) {
                source.DataSource = CustomerRepository.SearchCustomerByPhone(CustomerPhone);
            }
            else if (!string.IsNullOrEmpty(CustomerName) && string.IsNullOrEmpty(CustomerPhone))
            {
                source.DataSource = CustomerRepository.SearchCustomerByName(CustomerName);
            }
        }



        // Load appointment list

        private void btnLoadAppointmentList_Click(object sender, EventArgs e)
        {
            source = new BindingSource();
            source.DataSource = AppointmentRepository.GetAppointmentsForAdmin();
            dataGridViewAppointment.DataSource = source;
        }

        private void panelAppointment_Paint(object sender, PaintEventArgs e)
        {
            if (dataGridViewAppointment.Columns["Customer"] != null)
                dataGridViewAppointment.Columns["Customer"].Visible = false;

            if (dataGridViewAppointment.Columns["Dentist"] != null)
                dataGridViewAppointment.Columns["Dentist"].Visible = false;

            if (dataGridViewAppointment.Columns["AppointmentServices"] != null)
                dataGridViewAppointment.Columns["AppointmentServices"].Visible = false;

        }




        // Dentist
        private void panelDentist_Paint(object sender, PaintEventArgs e)
        {
            source = new BindingSource();
            source.DataSource = AccountRepository.GetALLDentistList();
        }

    }
}
