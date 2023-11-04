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
    public partial class frmTradeArea : Form
    {
        public IAreaRepository areaRepository = new AreaRepostitory();
        public IExpertRepository expertRepository = new ExpertRepository();
        BindingSource source;
        public frmTradeArea()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int areaId = int.Parse(cboAreaName.SelectedValue.ToString());
            Expert expert = expertRepository.GetExpertByEmail(cboExpert.Text);
            Expert expertAssign = new Expert
            {
                Id = expert.Id,
                FirstName = expert.FirstName,
                LastName = expert.LastName,
                Gender = expert.Gender,
                StartDay = expert.StartDay,
                Email = expert.Email,
                PhoneNumber = expert.PhoneNumber,
                AreaId = areaId,
            };
            expertRepository.UpdateExpert(expertAssign);
            MessageBox.Show("Update Successfully");
        }

        private void LoadAreaList()
        {
            try
            {
                var areas = areaRepository.GetAreas();
                cboAreaName.DataSource = areas;
                cboAreaName.ValueMember = "Id";
                cboAreaName.DisplayMember = "Name";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Area List");
            }
        }

        private void LoadExpertList()
        {
            try
            {
                var experts = expertRepository.GetExperts();
                cboExpert.DataSource = experts;
                cboExpert.ValueMember = "Id";
                cboExpert.DisplayMember = "Email";
                source = new BindingSource();
                source.DataSource = experts;

                dgvArea.DataSource = null;
                dgvArea.DataSource = source;
                dgvArea.Columns["Area"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Expert List");
            }
        }

        private void frmTradeArea_Load(object sender, EventArgs e)
        {
            LoadAreaList();
            LoadExpertList();
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
