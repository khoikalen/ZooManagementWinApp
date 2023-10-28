using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagementWinApp
{
    public partial class frmStaffDetail : Form
    {
        public IStaffRepository StaffRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public staff StaffInfo { get; set; }
        public frmStaffDetail()
        {
            InitializeComponent();
        }

        private void frmStaffDetail_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
