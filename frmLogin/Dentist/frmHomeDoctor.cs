﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        public static AppointmentChange AppointmentChange { get; set; }
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
            panelUpdateAppointment.SendToBack();
            LoadListAppointment();
            txtLinkLabelNameAccountLogin.Text = accountLogin.Name;
        }



        private void buttonFindAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                string phone = textBoxAppointmentPhone.Text.Trim();
                LoadListAppointment(phone);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Find customer", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            }
            catch (Exception ex)
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

                foreach (DataGridViewColumn column in dgvService.Columns)
                {
                    if (column.Name != "Name")
                    {
                        column.Visible = false;
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load list service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadListAppointment(string phone)
        {
            source = new BindingSource();

            var listWaitting = appointmentRepository.GetAppointmentList(DateTime.Now, phone, accountLogin.Id, 1)
                            .OrderBy(o => DateTime.ParseExact(o.WorkingHour.Split('-')[0], "HH:mm", CultureInfo.InvariantCulture))
                            .ToList();
            var listDone = appointmentRepository.GetAppointmentList(DateTime.Now, phone, accountLogin.Id, 2)
                            .OrderBy(o => DateTime.ParseExact(o.WorkingHour.Split('-')[0], "HH:mm", CultureInfo.InvariantCulture))
                            .ToList();
            List<AppointmentChange> changeList = new List<AppointmentChange>();
            foreach (Appointment item in listWaitting)
            {
                AppointmentChange tmp = new AppointmentChange()
                {
                    Id = item.Id,
                    CustomerId = item.CustomerId,
                    CustomerName = customerRepository.GetById(item.CustomerId).Name,
                    StatusId = item.Status,
                    Status = item.Status == 1 ? "Waitting" :
                             item.Status == 2 ? "Done" :
                             item.Status == 3 ? "Cancel" : "",
                    WorkingHour = item.WorkingHour,
                };

                changeList.Add(tmp);
            }
            foreach (Appointment item in listDone)
            {
                AppointmentChange tmp = new AppointmentChange()
                {
                    Id = item.Id,
                    CustomerId = item.CustomerId,
                    CustomerName = customerRepository.GetById(item.CustomerId).Name,
                    StatusId = item.Status,
                    Status = item.Status == 1 ? "Waitting" :
                             item.Status == 2 ? "Done" :
                             item.Status == 3 ? "Cancel" : "",
                    WorkingHour = item.WorkingHour,
                };

                changeList.Add(tmp);
            }


            source.DataSource = changeList;

            dataGridViewAppointment.DataSource = source;

            if (dataGridViewAppointment.Columns["Id"] != null)
            {
                dataGridViewAppointment.Columns["Id"].Visible = false;
            }
            if (dataGridViewAppointment.Columns["CustomerId"] != null)
            {
                dataGridViewAppointment.Columns["CustomerId"].Visible = false;
            }
            if (dataGridViewAppointment.Columns["StatusId"] != null)
            {
                dataGridViewAppointment.Columns["StatusId"].Visible = false;
            }

            if (dataGridViewAppointment.Columns["CustomerName"] != null)
            {
                dataGridViewAppointment.Columns["CustomerName"].HeaderText = "Customer name";
            }
            if (dataGridViewAppointment.Columns["WorkingHour"] != null)
            {
                dataGridViewAppointment.Columns["WorkingHour"].HeaderText = "Working Hour";
            }

        }

        private void LoadListAppointment()
        {
            source = new BindingSource();

            var listWaitting = appointmentRepository.GetAppointmentList(DateTime.Now, "", accountLogin.Id, 1)
                            .OrderBy(o => DateTime.ParseExact(o.WorkingHour.Split('-')[0], "HH:mm", CultureInfo.InvariantCulture))
                            .ToList();
            var listDone = appointmentRepository.GetAppointmentList(DateTime.Now, "", accountLogin.Id, 2)
                            .OrderBy(o => DateTime.ParseExact(o.WorkingHour.Split('-')[0], "HH:mm", CultureInfo.InvariantCulture))
                            .ToList();
            List<AppointmentChange> changeList = new List<AppointmentChange>();
            foreach (Appointment item in listWaitting)
            {
                AppointmentChange tmp = new AppointmentChange()
                {
                    Id = item.Id,
                    CustomerId = item.CustomerId,
                    CustomerName = customerRepository.GetById(item.CustomerId).Name,
                    StatusId = item.Status,
                    Status = item.Status == 1 ? "Waitting" :
                             item.Status == 2 ? "Done" :
                             item.Status == 3 ? "Cancel" : "",
                    WorkingHour = item.WorkingHour,
                };

                changeList.Add(tmp);
            }
            foreach (Appointment item in listDone)
            {
                AppointmentChange tmp = new AppointmentChange()
                {
                    Id = item.Id,
                    CustomerId = item.CustomerId,
                    CustomerName = customerRepository.GetById(item.CustomerId).Name,
                    StatusId = item.Status,
                    Status = item.Status == 1 ? "Waitting" :
                             item.Status == 2 ? "Done" :
                             item.Status == 3 ? "Cancel" : "",
                    WorkingHour = item.WorkingHour,
                };

                changeList.Add(tmp);
            }


            source.DataSource = changeList;

            dataGridViewAppointment.DataSource = source;

            if (dataGridViewAppointment.Columns["Id"] != null)
            {
                dataGridViewAppointment.Columns["Id"].Visible = false;
            }
            if (dataGridViewAppointment.Columns["CustomerId"] != null)
            {
                dataGridViewAppointment.Columns["CustomerId"].Visible = false;
            }
            if (dataGridViewAppointment.Columns["StatusId"] != null)
            {
                dataGridViewAppointment.Columns["StatusId"].Visible = false;
            }

            if (dataGridViewAppointment.Columns["CustomerName"] != null)
            {
                dataGridViewAppointment.Columns["CustomerName"].HeaderText = "Customer name";
            }
            if (dataGridViewAppointment.Columns["WorkingHour"] != null)
            {
                dataGridViewAppointment.Columns["WorkingHour"].HeaderText = "Working Hour";
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
            }
            catch (Exception ex)
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
                appointmentInfo = new Appointment()
                {
                    Id = AppointmentChange.Id,
                    Description = description,
                    Status = 2,
                };

                appointmentRepository.UpdateAppointmentByDoctor(appointmentInfo);
                panelUpdateAppointment.SendToBack();
                panelAppointment.BringToFront();
            }
            catch (Exception ex)
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
                LoadListAppointment();
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

        private void dataGridViewAppointment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                AppointmentChange = new AppointmentChange()
                {
                    Id = int.Parse(dataGridViewAppointment.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString()),
                    CustomerName = dataGridViewAppointment.Rows[e.RowIndex].Cells["CustomerName"].FormattedValue.ToString(),
                    CustomerId = int.Parse(dataGridViewAppointment.Rows[e.RowIndex].Cells["CustomerId"].FormattedValue.ToString()),
                    WorkingHour = dataGridViewAppointment.Rows[e.RowIndex].Cells["WorkingHour"].FormattedValue.ToString(),
                    StatusId = int.Parse(dataGridViewAppointment.Rows[e.RowIndex].Cells["StatusId"].FormattedValue.ToString()),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DialogResult dialogResult = AppointmentChange.StatusId == 1 ? MessageBox.Show("Do you want to pick this appointment \n " +
                                                                         "Customer name: " + AppointmentChange.CustomerName + "\n" +
                                                                         "Working hour: " + AppointmentChange.WorkingHour,
                                                                         "Confirm pick appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                                                            :
                                                                         MessageBox.Show("Appointment history \n " +
                                                                         "Customer name: " + AppointmentChange.CustomerName + "\n" +
                                                                         "Working hour: " + AppointmentChange.WorkingHour,
                                                                         "Confirm pick appointment", MessageBoxButtons.OK, MessageBoxIcon.None);
            if (dialogResult == DialogResult.Yes)
            {
                if (AppointmentChange.StatusId == 1)
                {
                    try
                    {
                        panelAppointment.SendToBack();
                        panelUpdateAppointment.BringToFront();
                        LoadListServicesInAppointment(serviceRepository.GetServiceListByAppointmentId(AppointmentChange.Id));
                        customer = customerRepository.GetById(AppointmentChange.CustomerId);
                        LoadCustomer(customer);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Get next appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to quit?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                panelAppointment.BringToFront();
                panelUpdateAppointment.SendToBack();
                AppointmentChange = null;
                customer = null;
                txtDescription.Text = String.Empty;
            }
        }

        private void btnCheckAbsent_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you to check absent?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if( dialogResult == DialogResult.Yes)
            {
                appointmentInfo = new Appointment()
                {
                    Id = AppointmentChange.Id,
                    Status = 3,
                };

                appointmentRepository.UpdateAppointmentByDoctor(appointmentInfo);
                panelUpdateAppointment.SendToBack();
                panelAppointment.BringToFront();
                txtDescription.Text = String.Empty;
                dgvService.DataSource = null;
                txtCustomerName.Text = String.Empty;
                txtDateOfBirth.Text = String.Empty;
                txtGender.Text = String.Empty;
                txtPhone.Text = String.Empty;
                txtPhone.Text = String.Empty;
                LoadListAppointment();
                customer = null;
            }
        }
    }
}

public class AppointmentChange
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }

    public string WorkingHour { get; set; }

    public decimal StatusId { get; set; }
    public string Status { get; set; }


}
