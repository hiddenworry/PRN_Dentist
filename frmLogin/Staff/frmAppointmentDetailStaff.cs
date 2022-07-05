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

            }
            else
            {
                dateTimePickerTime.Value = appointment.Time;
                comboBoxWorkingHour.Text = appointment.WorkingHour;
                textBoxPhone.Text = customerRepository.GetById(appointment.Id).Phone;
                dataGridViewDetail.DataSource = appointmentServiceRepository.GetAppointmentServiceListByAppointmentId(appointment.Id);
            }
        }
    }
}
