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
    public partial class frmTradeCage : Form
    {
        public ICageRepository cageRepository = new CageRepository();
        public IStaffRepository staffRepository = new StaffRepository();
        BindingSource source;
        public bool TradeOrAssign = false;
        public string staffDeleteEmail;
        public frmTradeCage()
        {
            InitializeComponent();
        }

        private void frmTradeCage_Load(object sender, EventArgs e)
        {

            LoadCageList();
            LoadStaffList();
        }

        private void LoadCageList()
        {
            try
            {
                var cageList = new List<Cage>();
                if (TradeOrAssign == false)
                {
                    cageList = (List<Cage>)cageRepository.GetCages();
                }
                else
                {
                    cageList = cageRepository.GetCagesByStaffEmail(staffDeleteEmail);
                }


                cboCage.DataSource = cageList;
                cboCage.ValueMember = "Id";
                cboCage.DisplayMember = "Name";


                source = new BindingSource();
                source.DataSource = cageList;

                dgvCage.DataSource = null;
                dgvCage.DataSource = source;

                dgvCage.Columns["CageType"].Visible = false;
                dgvCage.Columns["Area"].Visible = false;
                dgvCage.Columns["Staff"].Visible = false;
                dgvCage.Columns["Animals"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load cage list in trade form");
            }
        }

        private void LoadStaffList()
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
                cboStaff.DataSource = staffView;
                cboStaff.ValueMember = "Id";
                cboStaff.DisplayMember = "Email";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load staff list in trade form");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int cageId = int.Parse(cboCage.SelectedValue.ToString());
                Cage cage = cageRepository.GetCageById(cageId);
                String staffEmail = cboStaff.Text;
                staff chosenStaff = staffRepository.GetStaffByEmail(staffEmail);
                Cage cageAssign = new Cage
                {
                    Id = cageId,
                    Name = cage.Name,
                    Quantity = cage.Quantity,
                    CageStatus = cage.CageStatus,
                    CageType = cage.CageType,
                    AreaId = cage.AreaId,
                    StaffId = chosenStaff.Id,
                };
                cageRepository.UpdateCage(cageAssign);
                var checkCageList = cageRepository.GetCagesByStaffEmail(staffDeleteEmail);
                if (checkCageList.Count > 0)
                {
                    frmTradeCage frm = new frmTradeCage
                    {
                        staffDeleteEmail = staffDeleteEmail,
                        TradeOrAssign = true,
                    };
                    this.Hide();
                    frm.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save assign cage");
            }


        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
