using BusinessObject.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class frmAppointmentDetailStaff : Form
    {
        public IAppointmentRepository appointmentRepository;
        public ICustomerRepository customerRepository;
        public IAppointmentServiceRepository appointmentServiceRepository;
        public IServiceRepository serviceRepository;
        public List<Service> detailList;
        public Appointment appointment;
        public bool InsertUpdateFlag;
        public frmAppointmentDetailStaff()
        {
            InitializeComponent();
            appointmentServiceRepository = new AppointmentServiceRepository();
            serviceRepository = new ServiceRepository();
        }

        private void frmAppointmentDetailStaff_Load(object sender, EventArgs e)
        {
            comboBoxService.DataSource = serviceRepository.GetServices();
            comboBoxService.DisplayMember = "Name";
            comboBoxService.ValueMember = "Id";
            if (InsertUpdateFlag)
            {
                dateTimePickerTime.Value = DateTime.Now;
                detailList = new List<Service>();
                dataGridViewDetail.DataSource = detailList;
            }
            else
            {
                dateTimePickerTime.Value = appointment.Time;
                comboBoxWorkingHour.Text = appointment.WorkingHour;
                textBoxPhone.Text = customerRepository.GetById(appointment.Id).Phone;
                detailList = serviceRepository.GetServiceListByAppointmentId(appointment.Id);
                dataGridViewDetail.DataSource = detailList;
            }
        }

        public void LoadDetailList()
        {
            dataGridViewDetail.DataSource = detailList;
        }

        private void comboBoxService_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MessageBox.Show("aaaaaaa");
        }

        private void dataGridViewDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonDeleteService.Enabled = true;
        }
    }
}
