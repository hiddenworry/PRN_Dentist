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
        public frmServiceDetail()
        {
            InitializeComponent();
        }

     

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void frmServiceDetail_Load(object sender, EventArgs e)
        {
            cbServiceType.DataSource = ServiceTypeRepository.GetServiceTypeList();
            cbServiceType.DisplayMember = "name";
            cbServiceType.ValueMember = "id";
            

        }
    }
}
