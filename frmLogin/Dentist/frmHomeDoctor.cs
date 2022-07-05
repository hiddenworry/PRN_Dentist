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
using WinApp.Dentist;
namespace WinApp
{
    public partial class frmHomeDoctor : Form
    {
        List<Panel> panelList = new List<Panel>();

        ICustomerRepository customerRepository = new CustomerRepository();
        IAppointmentRepository appointmentRepository = new AppointmentRepository();
        IAppointmentServiceRepository appointmentServiceRepository = new AppointmentServiceRepository();
        IServiceRepository serviceRepository = new ServiceRepository();
        BindingSource source;

        private static Customer customer;

        private static Appointment appointmentInfo;
        public Account accountLogin { get; set; }
        int index;
        public frmHomeDoctor()
        {
            InitializeComponent();
            customerRepository = new CustomerRepository();
            appointmentRepository = new AppointmentRepository();
            appointmentServiceRepository = new AppointmentServiceRepository();
            serviceRepository = new ServiceRepository();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            panelAppointment.BringToFront();
            LoadListAppointment(appointmentRepository.GetAppointmentList(DateTime.Now, "", accountLogin.Id,2));
            txtLinkLabelNameAccountLogin.Text = accountLogin.Name;
        }



        private void buttonFindAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                string phone = textBoxAppointmentPhone.Text.Trim();
                LoadListAppointment(appointmentRepository.GetAppointmentList(DateTime.Now, phone, accountLogin.Id, 2));
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Find customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void btnNextAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                panelAppointment.SendToBack();
                panelUpdateAppointment.BringToFront();
                appointmentInfo = appointmentRepository.GetAppointmentNearest();
                LoadListServicesInAppointment(serviceRepository.GetServiceListByAppointmentId(appointmentInfo.Id));
                customer = customerRepository.GetById(appointmentInfo.CustomerId);
                LoadCustomer(customer);
            } catch(Exception ex)
            {
              MessageBox.Show(ex.Message, "Get next appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCustomer(Customer customer)
        {
            try
            {
                txtCustomerName.Text = customer.Name;
                txtDateOfBirth.Text = customer.Dob.ToString("dd/MM/yyyy");
                txtGender.Text = customer.Gender ? "Male" : "Female";
                txtPhone.Text = customer.Phone;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Load customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadListServicesInAppointment(List<Service> list)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = list;
                dgvService.DataSource = null;
                dgvService.DataSource = source;

                foreach(DataGridViewColumn column in dgvService.Columns)
                {
                    if(column.Name != "Name")
                    {
                        column.Visible = false;
                    }
                    
                }

              
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load list service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void LoadListAppointment(List<Appointment> list)
        {
            source = new BindingSource();
            source.DataSource = list;
            dataGridViewAppointment.DataSource = source;

            if(dataGridViewAppointment.Columns["Description"] != null)
            {
                dataGridViewAppointment.Columns["Description"].Visible = false;
            }
            if(dataGridViewAppointment.Columns["Customer"] != null)
            {
                dataGridViewAppointment.Columns["Customer"].Visible = false;
            }
            if(dataGridViewAppointment.Columns["Dentist"] != null)
            {
                dataGridViewAppointment.Columns["Dentist"].Visible = false;
            }
            if(dataGridViewAppointment.Columns["AppointmentServices"] != null)
            {
                dataGridViewAppointment.Columns["AppointmentServices"].Visible = false;
            }
            if (dataGridViewAppointment.Columns["Status"] != null)
            {
                dataGridViewAppointment.Columns["Status"].Visible = false;
            }
            if (dataGridViewAppointment.Columns["Id"] != null)
            {
                dataGridViewAppointment.Columns["Id"].Visible = false;
            }
            if (dataGridViewAppointment.Columns["DentistId"] != null)
            {
                dataGridViewAppointment.Columns["DentistId"].Visible = false;
            }
            if (dataGridViewAppointment.Columns["WorkingHour"] != null)
            {
                dataGridViewAppointment.Columns["WorkingHour"].HeaderText = "Working hour";
            }
            if (dataGridViewAppointment.Columns["Time"] != null)
            {
                dataGridViewAppointment.Columns["Time"].HeaderText = "Time come";
            }
            if (dataGridViewAppointment.Columns["CustomerId"] != null)
            {
                dataGridViewAppointment.Columns["CustomerId"].HeaderText = "Customer Id";
            }

        }

        private void btnViewHistoryCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                frmCustomerHistory customerHistory = new frmCustomerHistory()
                {
                    customerInfo = customer,
                    ServiceRepository = serviceRepository,
                AppointmentRepository = appointmentRepository,
                    CustomerRepository = customerRepository,
                };
                customerHistory.ShowDialog();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "View history", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to submit?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }
            try
            {
                string description = txtDescription.Text.Trim();
                
                appointmentInfo.Description = description;
                appointmentInfo.Status = 5;
                appointmentRepository.UpdateAppointment(appointmentInfo);
                panelUpdateAppointment.SendToBack();
                panelAppointment.BringToFront();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Finish appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtDescription.Text = String.Empty;
                dgvService.DataSource = null;
                txtCustomerName.Text = String.Empty;
                txtDateOfBirth.Text = String.Empty;
                txtGender.Text = String.Empty;
                txtPhone.Text = String.Empty;
                txtPhone.Text = String.Empty;
                LoadListAppointment(appointmentRepository.GetAppointmentList(DateTime.Now, "", 3, 2));
                panelUpdateAppointment.SendToBack();
                panelAppointment.BringToFront();
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

        private void txtLinkLabelNameAccountLogin_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
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
    }
}
