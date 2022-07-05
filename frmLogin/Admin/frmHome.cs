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
            source.DataSource = services;
            dataGridViewService.DataSource = source;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            panelAppointment.BringToFront();
        }

        private void panelDentist_Paint(object sender, PaintEventArgs e)
        {

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
                frmService.Show();
            }
        }

        private void panelService_Paint(object sender, PaintEventArgs e)
        {
           
          
            dataGridViewService.DataSource = ServiceRepository.GetServices();
            comboBoxServiceType.DataSource = ServiceTypeRepository.GetServiceTypeList();
            comboBoxServiceType.DisplayMember = "name";
            comboBoxServiceType.ValueMember = "id";

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
                    this.Refresh();
                }
            }
        }

        private void btnServiceLoad_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void buttonServiceFind_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            if (!string.IsNullOrEmpty(textBoxServiceName.Text))
                service.Name = textBoxServiceName.Text;
            if(!string.IsNullOrEmpty(comboBoxServiceStatus.Text))
                service.Status = int.Parse(comboBoxServiceStatus.Text);
            if (!string.IsNullOrEmpty(comboBoxServiceType.Text))
                service.ServiceTypeId = Int32.Parse(comboBoxServiceType.SelectedValue.ToString());
            dataGridViewService.DataSource = 
                ServiceRepository.FilterService(service);
            MessageBox.Show(ServiceRepository.FilterService(service).Count.ToString());
        }

       
    }
}
