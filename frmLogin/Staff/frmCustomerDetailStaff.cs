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
                if (!ValidateAll())
                {
                    MessageBox.Show("Error input.", isInsert ? "Add new customer" : "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                    return;
                }
                string phone = txtPhone.Text.Trim();
                string tmp = "";
                for (int i = 0; i < phone.Length; i++)
                {
                    if ("0123456789".Contains(phone[i]))
                    {
                        tmp += phone[i];
                    }
                }

                Customer newCustomer = new Customer()
                {
                    Name = txtCustomerName.Text.Trim(),
                    Gender = cbGender.Text.Trim() == "Male",
                    Dob = DateTime.Parse(txtDateOfBirth.Text.Trim()),
                    Phone = tmp,
                };
                if (isInsert)
                {
                    CustomerRepository.AddNewCustomer(newCustomer);
                }
                else
                {
                    newCustomer.Id = CustomerInfo.Id;
                    CustomerRepository.UpdateCustomer(newCustomer);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, isInsert ? "Add new customer" : "update customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            if (isInsert)
            {
                txtPhone.Text = String.Empty;
                txtCustomerName.Text = String.Empty;
                txtDateOfBirth.Text = String.Empty;
                txtDateOfBirth.Text = String.Empty;
            }
            else
            {
                txtCustomerID.Text = CustomerInfo.Id.ToString();
                txtPhone.Text = CustomerInfo.Phone;
                txtCustomerName.Text = CustomerInfo.Name;
                txtDateOfBirth.Text = CustomerInfo.Dob.ToString();
                txtDateOfBirth.Text = CustomerInfo.Gender ? "Male" : "Female";
            }
        }

        private void frmCustomerDetailStaff_Load(object sender, EventArgs e)
        {
            if (isInsert)
            {
                txtPhone.Text = String.Empty;
                txtCustomerName.Text = String.Empty;
                txtDateOfBirth.Text = String.Empty;
                txtDateOfBirth.Text = String.Empty;
                btnSave.Text = "Add";
            }
            else
            {
                txtCustomerID.Text = CustomerInfo.Id.ToString();
                txtPhone.Text = CustomerInfo.Phone;
                txtCustomerName.Text = CustomerInfo.Name;
                txtDateOfBirth.Text = CustomerInfo.Dob.ToString("MM/dd/yyyy");
                cbGender.Text = CustomerInfo.Gender ? "Male" : "Female";
            }
        }

        private bool ValidateAll()
        {
            bool flag = true;
            if (txtCustomerName.Text.Length < 8 || txtCustomerName.Text.Length > 50)
            {
                flag = false;
                errorName.Text = "Length of name must be from 8 to 50 characters.";
                errorName.Visible = true;
            }

            try
            {
                DateTime.Parse(txtDateOfBirth.Text);
            }
            catch
            {
                flag = false;
                errorDateOfBirth.Text = "Please choose date of birth.";
                errorDateOfBirth.Visible = true;
            }

            try
            {
                DateTime.Parse(txtDateOfBirth.Text);
            }
            catch
            {
                flag = false;
                errorDateOfBirth.Text = "Please choose date of birth.";
                errorDateOfBirth.Visible = true;
            }

            string phone = txtPhone.Text.Trim();
            string tmp = "";
            for (int i = 0; i < phone.Length; i++)
            {
                if ("0123456789".Contains(phone[i]))
                {
                    tmp += phone[i];
                }
            }

            if(tmp.Length != 10)
            {
                errorPhone.Text = "Phone length must be 8.";
                errorPhone.Visible = true;
            }

            if(cbGender.Text != "Male" && cbGender.Text != "Female")
            {
                errorGender.Text = "Please choose gender";
                errorGender.Visible = true;
            }

            return flag;
        }
    }
}
