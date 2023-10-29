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

namespace ZooManagementWinApp
{
    public partial class frmAdmin : Form
    {
        IStaffRepository staffRepository = new StaffRepository();
        ICageRepository cageRepository = new CageRepository();
        IAccountRepository accountRepository = new AccountRepository();
        IExpertRepository expertRepository = new ExpertRepository();
        BindingSource source;
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            LoadStaffsList();
            LoadCagesList();
            LoadExpertList();
        }

        private void LoadStaffsList()
        {
            var staffs = staffRepository.GetStaffs();
            try
            {
                List<staff> staffView = new List<staff>();
                foreach (staff staff in staffs)
                {
                    if (staff.Id != 1)
                    {
                        staffView.Add(staff);
                    }
                }
                source = new BindingSource();
                source.DataSource = staffView;

                txtStaffID.DataBindings.Clear();
                txtStaffFirstName.DataBindings.Clear();
                txtStaffLastName.DataBindings.Clear();
                txtGender.DataBindings.Clear();
                dtpStatDay.DataBindings.Clear();
                txtStaffEmail.DataBindings.Clear();
                txtStaffPhoneNumber.DataBindings.Clear();

                txtStaffID.DataBindings.Add("Text", source, "Id");
                txtStaffFirstName.DataBindings.Add("Text", source, "FirstName");
                txtStaffLastName.DataBindings.Add("Text", source, "LastName");
                txtGender.DataBindings.Add("Text", source, "Gender");
                dtpStatDay.DataBindings.Add("Text", source, "StartDay");
                txtStaffEmail.DataBindings.Add("Text", source, "Email");
                txtStaffPhoneNumber.DataBindings.Add("Text", source, "PhoneNumber");

                dgvStaff.DataSource = null;
                dgvStaff.DataSource = source;
                dgvStaff.Columns["Cages"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Staffs List");
            }
        }

        private void LoadExpertList()
        {
            var experts = expertRepository.GetExperts();
            try
            {
                source = new BindingSource();
                source.DataSource = experts;

                txtExpertID.DataBindings.Clear();
                txtExpertFirstName.DataBindings.Clear();
                txtExpertLastName.DataBindings.Clear();
                txtGenderExpert.DataBindings.Clear();
                dtpExpertStartDay.DataBindings.Clear();
                txtExpertEmail.DataBindings.Clear();
                txtExpertPhoneNumber.DataBindings.Clear();
                txtExpertAreaID.DataBindings.Clear();

                txtExpertID.DataBindings.Add("Text", source, "Id");
                txtExpertFirstName.DataBindings.Add("Text", source, "FirstName");
                txtExpertLastName.DataBindings.Add("Text", source, "LastName");
                txtGenderExpert.DataBindings.Add("Text", source, "Gender");
                dtpExpertStartDay.DataBindings.Add("Text", source, "StartDay");
                txtExpertEmail.DataBindings.Add("Text", source, "Email");
                txtExpertPhoneNumber.DataBindings.Add("Text", source, "PhoneNumber");
                txtExpertAreaID.DataBindings.Add("Text", source, "AreaId");

                dgvExpertManagement.DataSource = null;
                dgvExpertManagement.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Experts List");
            }
        }

        private void LoadCagesList()
        {
            var cages = cageRepository.GetCages();
            try
            {
                source = new BindingSource();
                source.DataSource = cages;

                txtCagePrimaryID.DataBindings.Clear();
                txtCageName.DataBindings.Clear();
                txtCageQuantity.DataBindings.Clear();
                txtCageStatus.DataBindings.Clear();
                txtAreaForeignID.DataBindings.Clear();
                txtStaffForeignID.DataBindings.Clear();

                txtCagePrimaryID.DataBindings.Add("Text", source, "Id");
                txtCageName.DataBindings.Add("Text", source, "Name");
                txtCageQuantity.DataBindings.Add("Text", source, "Quantity");
                txtCageStatus.DataBindings.Add("Text", source, "CageStatus");
                txtAreaForeignID.DataBindings.Add("Text", source, "AreaId");
                txtStaffForeignID.DataBindings.Add("Text", source, "StaffId");


                dgvCageManagement.DataSource = null;
                dgvCageManagement.DataSource = source;

                dgvCageManagement.Columns["CageType"].Visible = false;
                dgvCageManagement.Columns["Area"].Visible = false;
                dgvCageManagement.Columns["Staff"].Visible = false;
                dgvCageManagement.Columns["Animals"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Cages List");
            }
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            frmStaffDetail frmStaffDetail = new frmStaffDetail
            {
                Text = "Add a new Staff",
                InsertOrUpdate = false,
                StaffRepository = staffRepository
            };
            if (frmStaffDetail.ShowDialog() == DialogResult.OK)
            {
                LoadStaffsList();
                source.Position = source.Count - 1;
            }
        }

        private void dgvStaff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmStaffDetail f = new frmStaffDetail
            {
                Text = "Update the staff",
                InsertOrUpdate = true,
                StaffInfo = GetStaffObject(),
                StaffRepository = staffRepository
            };
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadStaffsList();
                source.Position = source.Count - 1;
            }
        }

        private staff GetStaffObject()
        {
            staff staff = null;
            try
            {
                staff = new staff
                {
                    Id = int.Parse(txtStaffID.Text),
                    FirstName = txtStaffFirstName.Text,
                    LastName = txtStaffLastName.Text,
                    Gender = txtGender.Text,
                    StartDay = DateTime.Parse(dtpStatDay.Text),
                    Email = txtStaffEmail.Text,
                    PhoneNumber = txtStaffPhoneNumber.Text
                };
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error at get staff object");
            }
            return staff;
        }

        private Expert GetExpertObject()
        {
            Expert expert = null;
            try
            {
                expert = new Expert
                {
                    Id = int.Parse(txtExpertID.Text),
                    FirstName = txtExpertFirstName.Text,
                    LastName = txtExpertLastName.Text,
                    Gender = txtGenderExpert.Text,
                    StartDay = DateTime.Parse(dtpExpertStartDay.Text),
                    Email = txtExpertEmail.Text,
                    PhoneNumber = txtExpertPhoneNumber.Text,
                    AreaId = int.Parse(txtExpertAreaID.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error at get expert object");
            }
            return expert;
        }

        private Cage GetCageObject()
        {
            Cage cage = null;
            try
            {
                cage = new Cage
                {
                    Id = int.Parse(txtCagePrimaryID.Text),
                    Name = txtCageName.Text,
                    Quantity = int.Parse(txtCageQuantity.Text),
                    CageStatus = txtCageStatus.Text,
                    AreaId = int.Parse(txtAreaForeignID.Text),
                    StaffId = int.Parse(txtStaffForeignID.Text),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Cage Object");
            }
            return cage;
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            try
            {
                var staff = GetStaffObject();
                var confirm = MessageBox.Show("Are you sure to delete this staff?", "Confirm Delete!", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    staffRepository.DeleteStaffs(staff.Id);
                    accountRepository.DeleteAccountByEmail(staff.Email);
                }
                LoadStaffsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a staff");
            }
        }

        private void btnAddCage_Click(object sender, EventArgs e)
        {
            frmCageDetail frmCageDetail = new frmCageDetail
            {
                Text = "Add a cage",
                InsertOrUpdate = false,
                CageRepository = cageRepository,
            };
            if (frmCageDetail.ShowDialog() == DialogResult.OK)
            {
                LoadCagesList();
                source.Position = source.Count - 1;
            }
        }

        private void dgvCageManagement_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCageDetail frmCageDetail = new frmCageDetail
            {
                Text = "Update the cage",
                InsertOrUpdate = true,
                CageInfo = GetCageObject(),
                CageRepository = cageRepository
            };
            if (frmCageDetail.ShowDialog() == DialogResult.OK)
            {
                LoadCagesList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDeleteCage_Click(object sender, EventArgs e)
        {
            try
            {
                var cage = GetCageObject();
                if (cage.Quantity == 0)
                {
                    var confirm = MessageBox.Show("Are you sure to delete this cage?", "Confirm Delete!", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        cageRepository.DeleteCage(cage.Id);
                    }
                    LoadCagesList();
                }
                else
                {
                    MessageBox.Show("There are still animals in cage");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a cage");
            }
        }

        private void btnAddExpert_Click(object sender, EventArgs e)
        {
            frmExpertDetail frmExpertDetail = new frmExpertDetail
            {
                Text = "Add an expert",
                InsertOrUpdate = false,
                expertRepository1 = expertRepository
            };
            if (frmExpertDetail.ShowDialog() == DialogResult.OK)
            {
                LoadExpertList();
                source.Position = source.Count - 1;
            }
        }

        private void dgvExpertManagement_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmExpertDetail frmExpertDetail = new frmExpertDetail
            {
                Text = "Update the expert",
                InsertOrUpdate = true,
                ExpertInfo = GetExpertObject(),
                expertRepository1 = expertRepository,
            };
            if (frmExpertDetail.ShowDialog() == DialogResult.OK)
            {
                LoadExpertList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDeleteExpert_Click(object sender, EventArgs e)
        {
            try
            {
                var expert = GetExpertObject();
                var confirm = MessageBox.Show("Are you sure to delete this expert?", "Confirm Delete!", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    expertRepository.DeleteExpert(expert.Id);
                    accountRepository.DeleteAccountByEmail(expert.Email);
                }
                LoadExpertList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete an expert");
            }
        }
    }
}
