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
    public partial class frmExpertDetail : Form
    {
        public IExpertRepository expertRepository1 { get; set; }
        public IAccountRepository AccountRepository = new AccountRepository();
        public IAreaRepository areaRepository = new AreaRepostitory();
        public IStaffRepository staffRepository = new StaffRepository();
        public bool InsertOrUpdate { get; set; }
        public Expert ExpertInfo { get; set; }
        public frmExpertDetail()
        {
            InitializeComponent();
        }

        private void frmExpertDetail_Load(object sender, EventArgs e)
        {
            LoadAreasList();
            cboAreaID.SelectedIndex = 0;
            cboGender.SelectedIndex = 0;
            txtExpertID.Enabled = false;

            if (InsertOrUpdate == true)
            {
                txtExpertID.Text = ExpertInfo.Id.ToString();
                txtFirstName.Text = ExpertInfo.FirstName;
                txtLastName.Text = ExpertInfo.LastName;
                cboGender.Text = ExpertInfo.Gender;
                dtpStartDay.Text = ExpertInfo.StartDay.ToString();
                txtEmail.Text = ExpertInfo.Email;
                txtPhoneNumber.Text = ExpertInfo.PhoneNumber;
                cboAreaID.SelectedIndex = (int)ExpertInfo.AreaId - 1;
                txtEmail.Enabled = false;
                txtPassword.Enabled = false;
            }
        }

        private void LoadAreasList()
        {
            try
            {
                var areaList = areaRepository.GetAreas();
                cboAreaID.DataSource = areaList;
                cboAreaID.ValueMember = "Id";
                cboAreaID.DisplayMember = "Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Areas List");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var expert = new Expert();
                var account = new Account();
                if (InsertOrUpdate == false)
                {
                    expert = new Expert
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Gender = cboGender.Text,
                        StartDay = DateTime.Parse(dtpStartDay.Text),
                        Email = txtEmail.Text,
                        PhoneNumber = txtPhoneNumber.Text,
                        AreaId = int.Parse(cboAreaID.SelectedValue.ToString()),
                    };
                    account = new Account
                    {
                        Email = txtEmail.Text,
                        Password = txtPassword.Text,
                        Role = "EXPERT",
                    };
                    ValidationContext context = new ValidationContext(expert);
                    List<ValidationResult> results = new List<ValidationResult>();
                    if (!Validator.TryValidateObject(expert, context, results))
                    {
                        foreach (ValidationResult result in results)
                        {
                            MessageBox.Show(result.ErrorMessage, "Message");
                            return;
                        }
                    }
                    var expertList = expertRepository1.GetExperts();
                    var staffList = staffRepository.GetStaffs();
                    if ((expertList.SingleOrDefault(e => e.Email == expert.Email) == null) && (staffList.SingleOrDefault(s => s.Email == expert.Email) == null))
                    {
                        if ((expertList.SingleOrDefault(e => e.PhoneNumber == expert.PhoneNumber) == null) && staffList.SingleOrDefault(s => s.PhoneNumber == expert.PhoneNumber) == null)
                        {
                            expertRepository1.InsertExpert(expert);
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
                    expert = new Expert
                    {
                        Id = int.Parse(txtExpertID.Text),
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Gender = cboGender.Text,
                        StartDay = DateTime.Parse(dtpStartDay.Text),
                        Email = txtEmail.Text,
                        PhoneNumber = txtPhoneNumber.Text,
                        AreaId = int.Parse(cboAreaID.SelectedValue.ToString()),
                    };
                    ValidationContext context = new ValidationContext(expert);
                    List<ValidationResult> results = new List<ValidationResult>();
                    if (!Validator.TryValidateObject(expert, context, results))
                    {
                        foreach (ValidationResult result in results)
                        {
                            MessageBox.Show(result.ErrorMessage, "Message");
                            return;
                        }
                    }
                    var expertList = expertRepository1.GetExperts();
                    var staffList = staffRepository.GetStaffs();
                    var accountList = AccountRepository.GetAccounts();
                    accountList = accountList.Where(a => a.Email != expert.Email);
                    if (accountList.SingleOrDefault(a => a.Email == expert.Email) == null)
                    {
                        var expertPhoneNumber = ExpertInfo.PhoneNumber;
                        expertList = expertList.Where(e => e.PhoneNumber != expertPhoneNumber).ToList();
                        staffList = staffList.Where(s => s.PhoneNumber != expertPhoneNumber).ToList();
                        if ((expertList.SingleOrDefault(e => e.PhoneNumber == expert.PhoneNumber) == null) && staffList.SingleOrDefault(s => s.PhoneNumber == expert.PhoneNumber) == null)
                        {
                            expertRepository1.UpdateExpert(expert);
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
                MessageBox.Show(ex.Message, "Save an Expert");
            }
        }
    }
}
