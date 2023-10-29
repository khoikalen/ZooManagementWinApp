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
    public partial class frmExpertDetail : Form
    {
        public IExpertRepository expertRepository1 { get; set; }
        public IAccountRepository AccountRepository = new AccountRepository();
        public IAreaRepository areaRepository = new AreaRepostitory();
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
                txtPassword.Enabled = false;
                cboAreaID.SelectedIndex = (int)ExpertInfo.AreaId - 1;
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
                    expertRepository1.InsertExpert(expert);
                    AccountRepository.InsertAccount(account);
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
                    expertRepository1.UpdateExpert(expert);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save an Expert");
            }
        }
    }
}
