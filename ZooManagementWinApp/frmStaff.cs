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
    public partial class frmStaff : Form
    {
        ICageRepository cageRepository = new CageRepository();
        IStaffRepository staffRepository = new StaffRepository();
        
        BindingSource source;
        public frmStaff()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            source = new BindingSource();
            source.DataSource = cageRepository.GetCagesByStaffEmail("bao@gmail.com");
            var staffName = staffRepository.GetStaffById(2);

            txtCageID.DataBindings.Clear();
            txtCageName.DataBindings.Clear();
            txtCageQuantity.DataBindings.Clear();
            cboCageStatus.DataBindings.Clear();
            txtCageAreaID.DataBindings.Clear();
            txtCageStaffID.DataBindings.Clear();

            txtCageID.DataBindings.Add("Text", source, "Id");
            txtCageName.DataBindings.Add("Text", source, "Name");
            txtCageQuantity.DataBindings.Add("Text", source, "Quantity");
            cboCageStatus.DataBindings.Add("Text", source, "CageStatus");
            txtCageAreaID.DataBindings.Add("Text", source, "AreaId");
            txtCageStaffID.Text = staffName.FirstName + " " + staffName.LastName;

            dgvCageList.DataBindings.Clear();
            dgvCageList.DataSource = source;
            dgvCageList.Columns["CageType"].Visible = false;
            dgvCageList.Columns["Area"].Visible = false;
            dgvCageList.Columns["staff"].Visible = false;
            dgvCageList.Columns["Animals"].Visible = false;
        }
        private void LoadStaffName()
        {

        }
        private void frmStaff_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
