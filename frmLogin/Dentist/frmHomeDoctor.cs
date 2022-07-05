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
    public partial class frmHomeDoctor : Form
    {
        List<Panel> panelList = new List<Panel>();

        ICustomerRepository customerRepository = new CustomerRepository();
        IAppointmentRepository appointmentRepository = new AppointmentRepository();

        BindingSource source;

        private static Customer customer;
        public Account accountLogin { get; set; }
        int index;
        public frmHomeDoctor()
        {
            InitializeComponent();
            customerRepository = new CustomerRepository();
            appointmentRepository = new AppointmentRepository();
        }

        private void buttonAppointment_Click(object sender, EventArgs e)
        {
            panelCustomer.SendToBack();
            panelAppointment.BringToFront();
            buttonAppointment.BackColor = Color.LightBlue;
            buttonCustomer.BackColor = Color.Lavender;
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            panelCustomer.BringToFront();
            panelAppointment.SendToBack();
            buttonAppointment.BackColor = Color.Lavender;
            buttonCustomer.BackColor = Color.LightBlue;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            panelAppointment.BringToFront();
        }

        

        private void buttonFindAppointment_Click(object sender, EventArgs e)
        {

        }

        private void btnNextAppointment_Click(object sender, EventArgs e)
        {

        }
    }
}