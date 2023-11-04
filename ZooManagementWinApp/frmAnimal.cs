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
using System.Xml.Linq;

namespace ZooManagementWinApp
{
    public partial class frmAnimal : Form
    {
        IAnimalRepository animalRepository = new AnimalRepository();
        ICageRepository cageRepository = new CageRepository();
        public staff staffInformation { get; set; }
        public Cage cageInformation { get; set; }
        BindingSource source;
        public frmAnimal()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                if (animalRepository.GetAnimalByCageID(cageInformation.Id).Count == 0)
                {
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
                source = new BindingSource();
                source.DataSource = animalRepository.GetAnimalByCageID(cageInformation.Id);

                txtAnimalDEZ.DataBindings.Clear();
                txtAnimalDOB.DataBindings.Clear();
                txtAnimalGender.DataBindings.Clear();
                txtAnimalID.DataBindings.Clear();
                txtAnimalName.DataBindings.Clear();
                txtAnimalSpecie.DataBindings.Clear();
                txtAnimalStatus.DataBindings.Clear();

                txtAnimalDEZ.DataBindings.Add("Text", source, "Dez");
                txtAnimalDOB.DataBindings.Add("Text", source, "Dob");
                txtAnimalGender.DataBindings.Add("Text", source, "Gender");
                txtAnimalID.DataBindings.Add("Text", source, "Id");
                txtAnimalName.DataBindings.Add("Text", source, "Name");
                txtAnimalSpecie.DataBindings.Add("Text", source, "Specie");
                txtAnimalStatus.DataBindings.Add("Text", source, "Status");
                cboAnimalCage.Text = cageInformation.Name;

                dgvAnimalList.DataSource = null;
                dgvAnimalList.DataSource = source;
                dgvAnimalList.Columns["Cage"].Visible = false;
                dgvAnimalList.Columns["AnimalLogs"].Visible = false;
                dgvAnimalList.Columns["Meals"].Visible = false;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAnimalDetail frmAnimalDetail = new frmAnimalDetail()
            {
                Text = "Add new Animal to the cage",
                cageInformation = cageRepository.GetCageById(cageInformation.Id),
                InsertOrUpdate = true,
            };
            frmAnimalDetail.ShowDialog();
            LoadData();
        }
        private void UpdateCageQuantity()
        {
            var cageList = cageRepository.GetCages();
            foreach (var cage in cageList)
            {
                cage.Quantity = animalRepository.AnimalQuantityInCage(cage.Id);
                cageRepository.UpdateCage(cage);
            }
        }
        private void frmAnimal_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private Animal GetAnimalObject()
        {
            return animalRepository.SearchAnimalByID(int.Parse(txtAnimalID.Text));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var animal = GetAnimalObject();
                var confirm = MessageBox.Show("Are you sure to delete this animal?", "Confirm Delete!", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    animalRepository.DeleteAnimal(GetAnimalObject());
                    UpdateCageQuantity();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a staff");
            }
            LoadData();
        }

        private void dgvAnimalList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmAnimalDetail frmAnimalDetail = new frmAnimalDetail()
            {
                Text = "Update Animal Information",
                InsertOrUpdate = false,
                animalInformation = GetAnimalObject(),
                cageInformation = cageInformation
            };
            if (txtAnimalID != null && txtAnimalID.Text != "0")
            {
                if (frmAnimalDetail.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Can not update null value!");
            }
        }

        private void btnMoveCage_Click(object sender, EventArgs e)
        {
            frmCage frmCage = new frmCage()
            {
                animalInformation = GetAnimalObject(),
                staffInformation = staffInformation,
                selectedCage = cageInformation,
            };
            if (frmCage.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                if (cageRepository.GetCageById(cageInformation.Id).Quantity == 0) this.Close();
            }
        }

        

        private void btnViewMeal_Click(object sender, EventArgs e)
        {
            frmFoodInMeal frm = new frmFoodInMeal()
            {
                AnimalInfo = GetAnimalObject(),
                StaffOrExpert = true
            };
            frm.ShowDialog();

        }
    }
}
