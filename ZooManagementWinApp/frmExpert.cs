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


    public partial class frmExpert : Form
    {

        ILogRepository logRepository = new LogRepository();
        IFoodStorageRepository foodStorageRepository = new FoodStorageRepository();
        BindingSource source;
        public frmExpert()
        {
            InitializeComponent();
        }

        private void frmExpert_Load(object sender, EventArgs e)
        {
            LoadHealLog();
            LoadFoodStorage();
        }

        private void LoadHealLog()
        {
            var log = logRepository.GetLog("expert1@gmail.com");
            try
            {
                source = new BindingSource();
                source.DataSource = log;

                txtType.DataBindings.Clear();
                txtShortDescription.DataBindings.Clear();
                txtAnimalName.DataBindings.Clear();
                txtSpecies.DataBindings.Clear();
                dtpDatetime.DataBindings.Clear();
                dgvViewLog.DataBindings.Clear();

                txtSpecies.DataBindings.Add("Text", source, "Species");
                txtAnimalName.DataBindings.Add("Text", source, "AnimalName");
                txtShortDescription.DataBindings.Add("Text", source, "ShortDescription");
                txtType.DataBindings.Add("Text", source, "Type");
                dtpDatetime.DataBindings.Add("Text", source, "DateTime");

                dgvViewLog.DataSource = null;
                dgvViewLog.DataSource = source;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }






        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmFoodStorageDetails frmFoodStorageDetails = new frmFoodStorageDetails
            {
                InsertOrUpdate = false,
                FoodStorageRepository = foodStorageRepository,

            };
            if (frmFoodStorageDetails.ShowDialog() == DialogResult.OK)
            {
                LoadFoodStorage();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete it", "Yes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var food = GetObject();
                    foodStorageRepository.DeleteFood(food.Id);
                    LoadFoodStorage();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
  

        private void dgvViewFoodStorage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmFoodStorageDetails frmFoodStorageDetails = new frmFoodStorageDetails
            {
                InsertOrUpdate = true,
                FoodStorageInformation = GetObject(),
                FoodStorageRepository = foodStorageRepository,

            };
            if (frmFoodStorageDetails.ShowDialog() == DialogResult.OK)
            {
                LoadFoodStorage();
                source.Position = source.Count - 1;
            }
        }



        /*        public void LoadFoodType()
                {
                    try
                    {
                        var foodList = foodStorageRepository.GetAllFoodStorageType();
                        cbFilterFood.DataSource = foodList;
                        cbFilterFood.ValueMember = "Type";
                        cbFilterFood.DisplayMember = "Type";
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }*/

        private FoodStorage GetObject()
        {
            FoodStorage foodStorage = null;
            try
            {
                foodStorage = new FoodStorage
                {
                    Id = int.Parse(txtFoodID.Text),
                    Name = txtFoodName.Text,
                    Available = double.Parse(txtFoodAvailable.Text),
                    Type = txtFoodType.Text,
                };
            }
            catch (Exception)
            {

                throw;
            }

            return foodStorage;
        }



        private void LoadFoodStorage()
        {
            cbFilterFood.SelectedIndex = 0;
            var listFood = foodStorageRepository.GetFoodStorageByType(cbFilterFood.Text);
            try
            {
                source = new BindingSource();
                source.DataSource = listFood;
                txtFoodName.DataBindings.Clear();
                txtFoodType.DataBindings.Clear();
                txtFoodAvailable.DataBindings.Clear();
                txtFoodID.DataBindings.Clear();

                txtFoodName.DataBindings.Add("Text", source, "Name");
                txtFoodType.DataBindings.Add("Text", source, "Type");
                txtFoodAvailable.DataBindings.Add("Text", source, "Available");
                txtFoodID.DataBindings.Add("Text", source, "Id");

                dgvViewFoodStorage.DataSource = null;
                dgvViewFoodStorage.DataSource = source;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void cbFilterFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cbFilterFood.Text;
            var listFood = foodStorageRepository.GetFoodStorageByType(type);
            try
            {
                source = new BindingSource();
                source.DataSource = listFood;
                txtFoodName.DataBindings.Clear();
                txtFoodType.DataBindings.Clear();
                txtFoodAvailable.DataBindings.Clear();
                txtFoodID.DataBindings.Clear();


                txtFoodName.DataBindings.Add("Text", source, "Name");
                txtFoodType.DataBindings.Add("Text", source, "Type");
                txtFoodAvailable.DataBindings.Add("Text", source, "Available");
                txtFoodID.DataBindings.Add("Text", source, "Id");


                dgvViewFoodStorage.DataSource = null;
                dgvViewFoodStorage.DataSource = source;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


    }
}
