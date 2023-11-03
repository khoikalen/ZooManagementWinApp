using BusinessObjects.Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        public IStaffRepository StaffRepository = new StaffRepository();
        public IAccountRepository AccountRepository = new AccountRepository();
        public IExpertRepository expertRepository = new ExpertRepository();
        public bool InsertOrUpdate { get; set; }
        public staff StaffInfo { get; set; }
        public String staffPassword { get; set; }
        public String userRole { get; set; }
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
                if (userRole.Equals("STAFF"))
                {
                    txtPassword.Enabled = true;
                    txtEmail.Enabled = false;
                    txtPassword.Text = staffPassword;
                }
                else
                {

                    txtPassword.Enabled = false;
                    txtPassword.PasswordChar = '*';
                    txtPassword.Text = AccountRepository.GetAccountPassWordByEmail(StaffInfo.Email);
                }
                txtStaffID.Text = StaffInfo.Id.ToString();
                txtFirstName.Text = StaffInfo.FirstName;
                txtLastName.Text = StaffInfo.LastName;
                cboGender.Text = StaffInfo.Gender;
                dtpStartDay.Text = StaffInfo.StartDay.ToString();
                txtEmail.Text = StaffInfo.Email;
                txtPhoneNumber.Text = StaffInfo.PhoneNumber;
                txtEmail.Enabled = false;

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
                    staff = new staff
                    {
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
                    ValidationContext context = new ValidationContext(staff);
                    List<ValidationResult> results = new List<ValidationResult>();
                    if (!Validator.TryValidateObject(staff, context, results))
                    {
                        foreach (ValidationResult result in results)
                        {
                            MessageBox.Show(result.ErrorMessage, "Message");
                            return;
                        }
                    }

                    var expertList = expertRepository.GetExperts();
                    var staffList = StaffRepository.GetStaffs();
                    if ((expertList.SingleOrDefault(e => e.Email == staff.Email) == null) && (staffList.SingleOrDefault(s => s.Email == staff.Email) == null))
                    {
                        if ((expertList.SingleOrDefault(e => e.PhoneNumber == staff.PhoneNumber) == null) && staffList.SingleOrDefault(s => s.PhoneNumber == staff.PhoneNumber) == null)
                        {
                            StaffRepository.InsertStaff(staff);
                            AccountRepository.InsertAccount(account);
                        }
                        else
                        {
                            MessageBox.Show("Phone number is already existed!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email is already existed!");
                    }
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
                    account = new Account
                    {
                        Id = AccountRepository.GetAccountIDByEmail(StaffInfo.Email),
                        Email = txtEmail.Text,
                        Password = txtPassword.Text,
                        Role = "STAFF"
                    };


                    AccountRepository.UpdateAccount(account);
                    StaffRepository.UpdateStaff(staff);
                    staffPassword = account.Password;
                    ValidationContext context = new ValidationContext(staff);
                    List<ValidationResult> results = new List<ValidationResult>();
                    if (!Validator.TryValidateObject(staff, context, results))
                    {
                        foreach (ValidationResult result in results)
                        {
                            MessageBox.Show(result.ErrorMessage, "Message");
                            return;
                        }
                    }
                    var expertList = expertRepository.GetExperts();
                    var staffList = StaffRepository.GetStaffs();
                    var accountList = AccountRepository.GetAccounts();
                    string staffEmail = txtEmail.Text;
                    accountList = accountList.Where(a => a.Email != staffEmail).ToList();
                    if (accountList.SingleOrDefault(a => a.Email == staff.Email) == null)
                    {
                        string staffPhoneNUmber = StaffInfo.PhoneNumber;
                        expertList = expertList.Where(e => e.PhoneNumber != staffPhoneNUmber).ToList();
                        staffList = staffList.Where(s => s.PhoneNumber != staffPhoneNUmber).ToList();
                        if ((expertList.SingleOrDefault(e => e.PhoneNumber == staff.PhoneNumber) == null) && staffList.SingleOrDefault(s => s.PhoneNumber == staff.PhoneNumber) == null)
                        {
                            AccountRepository.UpdateAccount(account);
                            StaffRepository.UpdateStaff(staff);
                            staffPassword = account.Password;
                            MessageBox.Show("Updated successfully");
                        }
                        else
                        {
                            MessageBox.Show("Phone number is already existed!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email is already existed!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save a staff");
            }
        }
    }
}
