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
    public partial class frmStaffDetail : Form
    {
        public IStaffRepository StaffRepository { get; set; }
        public IAccountRepository AccountRepository = new AccountRepository();
        public bool InsertOrUpdate { get; set; }
        public staff StaffInfo { get; set; }
        public frmStaffDetail()
        {
            InitializeComponent();
        }

        private void frmStaffDetail_Load(object sender, EventArgs e)
        {
            cboGender.SelectedIndex = 0;
            txtStaffID.Enabled = false;

            if (InsertOrUpdate == true)
            {
                txtStaffID.Text = StaffInfo.Id.ToString();
                txtFirstName.Text = StaffInfo.FirstName;
                txtLastName.Text = StaffInfo.LastName;
                cboGender.Text = StaffInfo.Gender;
                dtpStartDay.Text = StaffInfo.StartDay.ToString();
                txtEmail.Text = StaffInfo.Email;
                txtPhoneNumber.Text = StaffInfo.PhoneNumber;
                txtPassword.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var staff = new staff();
                var account = new Account();
                if (InsertOrUpdate == false)
                {
                    staff = new staff { 
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Gender = cboGender.Text,
                        StartDay = DateTime.Parse(dtpStartDay.Text),
                        Email = txtEmail.Text,
                        PhoneNumber = txtPhoneNumber.Text,
                    };
                    account = new Account
                    {
                        Email = txtEmail.Text,
                        Password = txtPassword.Text,
                        Role = "STAFF",
                    };
                    StaffRepository.InsertStaff(staff);
                    AccountRepository.InsertAccount(account);
                }
                else
                {
                    staff = new staff
                    {
                        Id = int.Parse(txtStaffID.Text),
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Gender = cboGender.Text,
                        StartDay = DateTime.Parse(dtpStartDay.Text),
                        Email = txtEmail.Text,
                        PhoneNumber = txtPhoneNumber.Text,
                    };
                    StaffRepository.UpdateStaff(staff);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add a staff");
            }
        }
    }
}
