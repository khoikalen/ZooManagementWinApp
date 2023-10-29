using BusinessObjects.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZooManagementWinApp
{
    public partial class frmCageDetail : Form
    {
        public ICageRepository CageRepository { get; set; }
        public IAreaRepository areaRepository = new AreaRepostitory();
        public IStaffRepository staffRepository = new StaffRepository();
        public bool InsertOrUpdate { get; set; }
        public Cage CageInfo { get; set; }
        public frmCageDetail()
        {
            InitializeComponent();
        }


        private void frmCageDetail_Load(object sender, EventArgs e)
        {
            LoadAreasList();
            LoadStaffsList();
            cboStaffId.SelectedIndex = 0;
            cboAreaId.SelectedIndex = 0;
            cboCageStatus.SelectedIndex = 0;
            txtCageQuantity.Text = "0";
            txtCageQuantity.Enabled = false;

            txtCageID.Enabled = false;
            if (InsertOrUpdate == true)
            {
                txtCageID.Text = CageInfo.Id.ToString();
                txtCageName.Text = CageInfo.Name;
                txtCageQuantity.Text = CageInfo.Quantity.ToString();
                cboCageStatus.Text = CageInfo.CageStatus;
                cboAreaId.SelectedIndex = CageInfo.AreaId - 1;
                cboStaffId.SelectedIndex = CageInfo.StaffId -2;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var cage = new Cage();
                if (InsertOrUpdate == false)
                {
                    cage = new Cage
                    {
                        Name = txtCageName.Text,
                        Quantity = int.Parse(txtCageQuantity.Text),
                        CageStatus = cboCageStatus.Text,
                        CageType = "Close",
                        AreaId = int.Parse(cboAreaId.SelectedValue.ToString()),
                        StaffId = int.Parse(cboStaffId.SelectedValue.ToString()),
                    };
                    CageRepository.InsertCage(cage);
                }
                else
                {
                    cage = new Cage
                    {
                        Id = int.Parse(txtCageID.Text),
                        Name = txtCageName.Text,
                        Quantity = int.Parse(txtCageQuantity.Text),
                        CageStatus = cboCageStatus.Text,
                        CageType = "Close",
                        AreaId = int.Parse(cboAreaId.SelectedValue.ToString()),
                        StaffId = int.Parse(cboStaffId.SelectedValue.ToString()),
                    };
                    CageRepository.UpdateCage(cage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save cage");
            }
        }

        private void LoadAreasList()
        {
            try
            {
                var areaList = areaRepository.GetAreas();
                cboAreaId.DataSource = areaList;
                cboAreaId.ValueMember = "Id";
                cboAreaId.DisplayMember = "Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Areas List");
            }
        }

        private void LoadStaffsList()
        {
            try
            {
                var staffList = staffRepository.GetStaffs();
                List<staff> staffView = new List<staff>();
                foreach (staff staff in staffList)
                {
                    if (staff.Id != 1)
                    {
                        staffView.Add(staff);
                    }
                }
                cboStaffId.DataSource = staffView;
                cboStaffId.ValueMember = "Id";
                cboStaffId.DisplayMember = "Email";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Staffs List");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void cboCageStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCageStatus.SelectedIndex == 1)
            {
                txtCageName.Text = "Empty Cage";
                txtCageName.Enabled = false;
            } else
            {
                txtCageName.Clear();
                txtCageName.Enabled = true;
            }
        }
    }
}
