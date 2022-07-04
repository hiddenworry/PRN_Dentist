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
    public partial class frmCustomerDetailStaff : Form
    {
        public frmCustomerDetailStaff()
        {
            InitializeComponent();
        }
        public bool isInsert;

        public ICustomerRepository CustomerRepository { get; set; }

        public Customer CustomerInfo { get; set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

     

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            cbGender.Text = string.Empty;
            txtDateOfBirth.Text = string.Empty;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                Customer newCustomer = new Customer()
                {
                    Name = txtCustomerID.Text.Trim(),
                    Gender = cbGender.Text.Trim() == "Male",
                    Dob = DateTime.Parse(txtDateOfBirth.Text.Trim()),
                    Phone = txtPhone.Text.Trim(),
                };
                if (isInsert)
                {
                    CustomerRepository.AddNewCustomer(newCustomer);
                }
                else
                {
                    CustomerRepository.UpdateCustomer(newCustomer);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, isInsert ? "Add new customer" : "update customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }
    }
}
