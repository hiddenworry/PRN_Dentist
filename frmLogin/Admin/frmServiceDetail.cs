﻿using BusinessObject.Models;
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
    public partial class frmServiceDetail : Form
    {
        IServiceTypeRepository ServiceTypeRepository = new ServiceTypeRepository();
        public IServiceRepository ServiceRepository { get; set; }

        public Service serviceData { get; set; }

        public bool Insert { get; set; }
        public frmServiceDetail()
        {
            InitializeComponent();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Service service = LoadData();
                if (Insert)
                {
                    DialogResult result = MessageBox.Show("Do You Want to Save?", "Add", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result.Equals(DialogResult.OK))
                    {
                        ServiceRepository.SaveService(service);
                        this.DialogResult = DialogResult.OK;

                    }

                }
                else
                {
                    DialogResult result = MessageBox.Show("Do You Want to Save?", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result.Equals(DialogResult.OK))
                    {
                        ServiceRepository.UpdateService(service);
                        this.DialogResult = DialogResult.OK;


                    }

                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally {
                this.Close();
            }
            

        }

        private Service LoadData()
        {
            Service service = new Service();
            if (!Insert)
            {
                service.Id = int.Parse(txtServiceID.Text);
            }
            service.Name = txtServiceName.Text;
            service.Status = int.Parse(cbStatus.Text);
            service.EstimatedTime = float.Parse(cbEstimatedTime.Text);
            service.ServiceTypeId = Int32.Parse(cbServiceType.SelectedValue.ToString());
            service.Description = txtDescription.Text;
            return service;

        }

        private void frmServiceDetail_Load(object sender, EventArgs e)
        {
            // load service type
            cbServiceType.DataSource = ServiceTypeRepository.GetServiceTypeList();
            cbServiceType.DisplayMember = "name";
            cbServiceType.ValueMember = "id";

            txtServiceID.Enabled = false;

            if (Insert)
            {
                lbServiceDetailID.Visible = false;
                txtServiceID.Visible = false;
               
            }
            else
            {
                txtServiceID.Text = serviceData.Id.ToString();
                txtServiceName.Text = serviceData.Name.ToString();
                cbStatus.Text = serviceData.Status.ToString();
                cbServiceType.Text = serviceData.ServiceTypeId.ToString();
                cbEstimatedTime.Text = serviceData.EstimatedTime.ToString();
                txtDescription.Text = serviceData.Description;
            }
            
            

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtServiceName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            cbEstimatedTime.SelectedIndex = 1;
            cbServiceType.SelectedIndex = 1;
            cbStatus.SelectedIndex = 1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
