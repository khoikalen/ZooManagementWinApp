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
        BindingSource source;
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            LoadStaffsList();
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
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Load Staffs List");
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
    }
}
