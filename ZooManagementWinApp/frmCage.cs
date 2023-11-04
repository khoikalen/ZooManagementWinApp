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
    public partial class frmCage : Form
    {
        ICageRepository cageRepository = new CageRepository();
        IAnimalRepository animalRepository = new AnimalRepository();
        IStaffRepository staffRepository = new StaffRepository();
        public Animal animalInformation { get; set; }
        public staff staffInformation { get; set; }
        public Cage selectedCage { get; set; }
        BindingSource source;

        private void LoadData()
        {
            source = new BindingSource();
            var cageList = cageRepository.GetCagesByStaffEmail(staffInformation.Email);
            List<Cage> cageList2 = new List<Cage>();
            foreach (var cage in cageList)
            {
                cage.Quantity = animalRepository.AnimalQuantityInCage(cage.Id);
            }
            foreach (var cage in cageList)
            {
                if (!cage.Id.Equals(selectedCage.Id))
                {
                    cageList2.Add(cage);
                }
            }
            source.DataSource = null;
            source.DataSource = cageList2;

            txtCagePrimaryID.DataBindings.Clear();
            txtCageName.DataBindings.Clear();
            txtCageQuantity.DataBindings.Clear();
            txtCageStatus.DataBindings.Clear();

            txtCagePrimaryID.DataBindings.Add("Text", source, "Id");
            txtCageName.DataBindings.Add("Text", source, "Name");
            txtCageQuantity.DataBindings.Add("Text", source, "Quantity");
            txtCageStatus.DataBindings.Add("Text", source, "CageStatus");

            dgvCageManagement.DataSource = null;
            dgvCageManagement.DataSource = source;
            dgvCageManagement.Columns["CageType"].Visible = false;
            dgvCageManagement.Columns["Area"].Visible = false;
            dgvCageManagement.Columns["Staff"].Visible = false;
            dgvCageManagement.Columns["Animals"].Visible = false;
            dgvCageManagement.Columns["AreaId"].Visible = false;
            dgvCageManagement.Columns["StaffId"].Visible = false;
        }
        public frmCage()
        {
            InitializeComponent();

        }

        private void frmCage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmCageDetailMovingAnimal frmCageDetailMovingAnimal = new frmCageDetailMovingAnimal()
            {
                Text = "Update current cage form",
                cageInformation = cageRepository.GetCageById(int.Parse(txtCagePrimaryID.Text)),
                animalInformation = animalInformation,
            };
            if (frmCageDetailMovingAnimal.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                this.Close();
            }
        }
    }
}
