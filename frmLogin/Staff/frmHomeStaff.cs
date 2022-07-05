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
using WinApp;
using DataAccess;
namespace WinApp
{
    public partial class frmHomeStaff : Form
    {
        List<Panel> panelList = new List<Panel>();
        public Account accountLogin { get; set; }

        ICustomerRepository customerRepository = new CustomerRepository();
        IAppointmentRepository appointmentRepository = new AppointmentRepository();

        BindingSource source;
        BindingSource sourceAppointment;

        private static Customer customer;
        public frmHomeStaff()
        {
            InitializeComponent();
            customerRepository = new CustomerRepository();
        }

        private void LoadListCustomer(List<Customer> list)
        {
            List<CustomerChange> changeList = new List<CustomerChange>();
            foreach (Customer customer in list)
            {
                CustomerChange change = new CustomerChange()
                {
                    Id = customer.Id,
                    Name = customer.Name,
                    Phone = customer.Phone,
                    Gender = customer.Gender ?"Male":"Female",
                    Dob = customer.Dob,
                };
                changeList.Add(change);
            }
            source = new BindingSource();
            source.DataSource = changeList;
            dataGridViewCustomer.DataSource = source;
            customer = list[0];

            if (dataGridViewCustomer.Columns["Appointments"] != null)
            {
                dataGridViewCustomer.Columns["Appointments"].Visible = false;
            }

            if (dataGridViewCustomer.Columns["Dob"] != null)
            {
                dataGridViewCustomer.Columns["Dob"].HeaderText = "Date of birth";
            }

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
            LoadListCustomer(customerRepository.GetAll());
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
            LoadAppointmentList();
            LoadListCustomer(customerRepository.GetAll());
        }

        private void buttonFindAppointment_Click(object sender, EventArgs e)
        {

        }

        public void LoadAppointmentList()
        {
            dataGridViewAppointment.DataSource = appointmentRepository.GetAppointmentList(DateTime.Now.Date, "", 0, 0);
        }

        private void buttonAppointmentAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonAppointmentUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewAppointment.SelectedRows[0].Cells[0].Value.ToString());
            Appointment appointment = appointmentRepository.GetAppointmentById(id);
            frmAppointmentDetailStaff frmAppointmentDetailstaff = new frmAppointmentDetailStaff
            {
                appointmentRepository = appointmentRepository,
                customerRepository = customerRepository,
                appointment = appointment,
                InsertUpdateFlag = false,
            };
            Hide();
            Enabled = false;
            frmAppointmentDetailstaff.ShowDialog();
        }
        private void buttonCustomerAdd_Click(object sender, EventArgs e)
        {
            frmCustomerDetailStaff frmCustomerDetailStaff = new frmCustomerDetailStaff()
            {
                CustomerRepository = customerRepository,
                isInsert = true,
                Text = "Add new Customer",
            };
            if (frmCustomerDetailStaff.ShowDialog() == DialogResult.OK)
            {
                LoadListCustomer(customerRepository.GetAll());
            }
        }

        private void buttonCustomerUpdate_Click(object sender, EventArgs e)
        {
            frmCustomerDetailStaff frmCustomerDetailStaff = new frmCustomerDetailStaff()
            {
                CustomerRepository = customerRepository,
                isInsert = false,
                Text = "Update new Customer",
                CustomerInfo = customer,
            };
            if (frmCustomerDetailStaff.ShowDialog() == DialogResult.OK)
            {
                LoadListCustomer(customerRepository.GetAll());
            }
        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridViewCustomer.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());

            customer = customerRepository.GetById(id);
        }

        private void dataGridViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridViewCustomer.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());

            customer = customerRepository.GetById(id);
        }

        private void dataGridViewCustomer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCustomerDetailStaff frmCustomerDetailStaff = new frmCustomerDetailStaff()
            {
                CustomerRepository = customerRepository,
                isInsert = false,
                Text = "Update new Customer",
                CustomerInfo = customer,
            };
            if (frmCustomerDetailStaff.ShowDialog() == DialogResult.OK)
            {
                LoadListCustomer(customerRepository.GetAll());
            }
        }

        private void dataGridViewCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCustomerDetailStaff frmCustomerDetailStaff = new frmCustomerDetailStaff()
            {
                CustomerRepository = customerRepository,
                isInsert = false,
                Text = "Update new Customer",
                CustomerInfo = customer,
            };
            if (frmCustomerDetailStaff.ShowDialog() == DialogResult.OK)
            {
                LoadListCustomer(customerRepository.GetAll());
            }
        }

        private void buttonCustomerFind_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxCustomerName.Text.Trim();
                string phone = textBoxCustomerPhone.Text.Trim();
                if (name.Length != 0 && phone.Length != 0)
                {
                    LoadListCustomer(customerRepository.SearchCustomerByNameAndPhone(name, phone));
                }
                else
                {
                    if (phone.Length != 0)
                    {
                        LoadListCustomer(customerRepository.SearchCustomerByPhone(phone));

                    }
                    else if (name.Length != 0)
                    {
                        LoadListCustomer(customerRepository.SearchCustomerByName(name));
                    } else
                    {
                        LoadListCustomer(customerRepository.GetAll());
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewCustomer_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //var grid = (DataGridView)sender;

            //if (grid.Columns[e.ColumnIndex].Name == "Gender")
            //{
            //    bool x = (bool)e.Value;
            //    e.Value  = x ? "yes" : "no";

            //    e.FormattingApplied = true;
            //}


        }
    }
}

public class CustomerChange
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Gender{ get; set; }
    public DateTime Dob { get; set; }
}
