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
using WinApp;
using DataAccess;
namespace WinApp
{
    public partial class frmHomeStaff : Form
    {
        List<Panel> panelList = new List<Panel>();
        public Account accountLogin { get; set; }

        ICustomerRepository customerRepository;

        BindingSource source;
        int index;
        public frmHomeStaff()
        {
            InitializeComponent();
            customerRepository = new CustomerRepository();
        }

        private bool CheckAccountLogin()
        {
            if (accountLogin != null)
            {
                if (accountLogin.Role == 2)
                {
                    return true;
                }
            }
            return false;

        }

        private void LoadListCustomer(List<Customer> list)
        {
            source = new BindingSource();
            source.DataSource = list;
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

        private void buttonService_Click(object sender, EventArgs e)
        {
            panelAppointment.SendToBack();
            panelCustomer.SendToBack();
            buttonAppointment.BackColor = Color.Lavender;
            buttonCustomer.BackColor = Color.Lavender;
        }

        private void buttonDentist_Click(object sender, EventArgs e)
        {
            panelAppointment.SendToBack();
            panelCustomer.SendToBack();
            buttonAppointment.BackColor = Color.Lavender;
            buttonCustomer.BackColor = Color.Lavender;
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

        private void buttonAppointmentAdd_Click(object sender, EventArgs e)
        {

        }


        private void buttonCustomerAdd_Click_1(object sender, EventArgs e)
        {
            if (CheckAccountLogin())
            {
                frmCustomerDetailStaff form = new frmCustomerDetailStaff()
                {
                    Text = "Add new customer",
                    CustomerRepository = customerRepository,
                    isInsert = true,
                };
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadListCustomer(customerRepository.GetAll());
                }
            }
        }
    }
}
