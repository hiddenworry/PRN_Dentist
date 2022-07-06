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
    public partial class frmDentistDetail : Form
    {
        public IAccountRepository AccountRepository { get; set; }

        public bool Insert { get; set; }

        public Account accountData { get; set; }
        public frmDentistDetail()
        {
            InitializeComponent();
        }


     

        private void frmDentistDetail_Load(object sender, EventArgs e)
        {
            var GenderDictionary = new Dictionary<bool, string>();
            GenderDictionary.Add(true, "Male");
            GenderDictionary.Add(false, "female");
            cbDentistGender.DataSource = GenderDictionary.ToList();
            cbDentistGender.DisplayMember = "Value";
            cbDentistGender.ValueMember = "Key";


            var StatusDictionary = new Dictionary<decimal, string>();
            StatusDictionary.Add(1, "Active");
            StatusDictionary.Add(2, "Inactive");
            cbStatus.DataSource = StatusDictionary.ToArray();
            cbStatus.DisplayMember = "Value";
            cbStatus.ValueMember = "Key";

            if (Insert)
            {
                txtDentistID.Visible = false;
                txtDentistID.Enabled = false;
                lbID.Visible = false;
            } else
            {
                lbID.Visible = true;
                txtDentistID.Visible = true;
                txtDentistID.Enabled = false;
               
                lbID.Visible = true;
                txtDentistID.Text = accountData.Id.ToString();
                txtDentistName.Text = accountData.Name.ToString();
                txtDentistLoginName.Text = accountData.Username.ToString();
                txtDentistPassword.Text = accountData.Password.ToString();
                cbDentistGender.SelectedValue = accountData.Gender;
                cbStatus.SelectedValue = accountData.Status;

            }
        }
        private Account LoadData()
        {
            Account account = new Account();
           
            if (Insert == false)
            {
                account.Id = int.Parse(txtDentistID.Text);
            }
            account.Name = txtDentistName.Text;
            account.Username = txtDentistLoginName.Text;
            account.Password = txtDentistPassword.Text;
            account.Status = decimal.Parse(cbStatus.SelectedValue.ToString());
            account.Gender = Boolean.Parse(cbDentistGender.SelectedValue.ToString());
            return account;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                if (Validate())
                {
                    Account Dentist = LoadData();

                    if (Insert == true)
                    {
                        DialogResult result = MessageBox.Show("Do you want to Save", "Add doctor", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            AccountRepository.AddDentistAccount(Dentist);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    if (Insert == false)
                    {
                        DialogResult result = MessageBox.Show("Do you want to Save", "Update doctor", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            AccountRepository.UpdateDentistAccount(Dentist);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Validation error");
                }
            } catch(Exception ex)
            {
                throw new Exception(ex.Data.ToString());
            }
        }

        private bool Validate()
        {
            if (
                string.IsNullOrEmpty(txtDentistName.Text)||txtDentistName.TextLength < 8 ||
                string.IsNullOrEmpty(txtDentistLoginName.Text)||txtDentistLoginName.TextLength < 8 ||
                string.IsNullOrEmpty(txtDentistPassword.Text)
                )
            {
                return false;
            }
            return true;
        }
    }


}
