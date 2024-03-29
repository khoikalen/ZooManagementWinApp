﻿using BusinessObjects.Models;
using Microsoft.VisualBasic.Logging;
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
        IAnimalRepository animalRepository = new AnimalRepository();
        ICageRepository cageRepository = new CageRepository();
        IMealRepository mealRepository = new MealRepository();
        IFoodRepository foodRepository = new FoodRepository();
        IExpertRepository expertRepository = new ExpertRepository();
        BindingSource source;
        public String email { get; set; }
        public static int animalId;
        private int currentPage = 1;
        private int itemsPerPage = 8;
        bool check = true;
        public frmExpert()
        {
            InitializeComponent();
        }

        private void frmExpert_Load(object sender, EventArgs e)
        {
            LoadHealLog();
            LoadFoodStorage();
            LoadAnimal();
            LoadExpertInformation();
        }

        private void LoadHealLog()
        {
            var log = logRepository.GetHealthLogs(email);
            int startIndex = (currentPage - 1) * itemsPerPage;
            int endIndex = Math.Min(startIndex + itemsPerPage, log.Count());
            try
            {
                source = new BindingSource();
                source.DataSource = log.Skip(startIndex).Take(endIndex - startIndex).ToList();

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
                    var food = GetFoodStorageObject();
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
                FoodStorageInformation = GetFoodStorageObject(),
                FoodStorageRepository = foodStorageRepository,

            };
            if (!check)
            {
                check = true;
                return;
            }
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

        private FoodStorage GetFoodStorageObject()
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
                check = false;
                MessageBox.Show("Can not update null value");
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



        private void LoadAnimal()
        {
            var listCage = cageRepository.GetCagesByExpertEmail(email);
            List<Animal> animals = new List<Animal>();
            foreach (var cage in listCage)
            {
                animals.AddRange(animalRepository.GetAllAnimalsByCageID(cage.Id));
            }
            try
            {
                source = new BindingSource();
                source.DataSource = animals;

                txtAnimalD.DataBindings.Clear();
                txtAnimalGender.DataBindings.Clear();
                txtAnimalName.DataBindings.Clear();
                txtAnimalSpecies.DataBindings.Clear();
                txtAnimalStatus.DataBindings.Clear();
                dtpDEZ.DataBindings.Clear();
                dtpDOB.DataBindings.Clear();


                txtAnimalD.DataBindings.Add("Text", source, "Id");
                txtAnimalGender.DataBindings.Add("Text", source, "Gender");
                txtName.DataBindings.Add("Text", source, "Name");
                txtAnimalSpecies.DataBindings.Add("Text", source, "Specie");
                txtAnimalStatus.DataBindings.Add("Text", source, "Status");
                dtpDEZ.DataBindings.Add("Text", source, "Dez");
                dtpDOB.DataBindings.Add("Text", source, "Dob");


                dgvAnimals.DataSource = null;
                dgvAnimals.DataSource = source;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public Animal GetAnimalObject()
        {
            Animal animal = null;
            try
            {
                animal = new Animal
                {
                    Id = int.Parse(txtAnimalD.Text),
                    Name = txtName.Text,
                    Gender = txtAnimalGender.Text,
                    Specie = txtAnimalSpecies.Text,
                    Status = txtAnimalStatus.Text,
                    Dob = DateTime.Parse(dtpDOB.Text),
                    Dez = DateTime.Parse(dtpDEZ.Text),
                };
            }
            catch (Exception)
            {

                throw;
            }
            return animal;
        }




        private void btnCreateMeal_Click(object sender, EventArgs e)
        {
            Animal animal = GetAnimalObject();
            var mealExist = mealRepository.GetMealByAnimalId(animal.Id);
            if (mealExist != null)
            {
                MessageBox.Show("Meal was created");
            }
            else
            {
                Meal meal = new Meal
                {
                    Name = txtAnimalName.Text + "meal",
                    AnimalId = int.Parse(txtAnimalD.Text)
                };
                mealRepository.Add(meal);
                MessageBox.Show("Create Meal Successfully");
            }

        }





        public void LoadFood()
        {
            var food = foodRepository.GetAllFood();
            try
            {
                source = new BindingSource();
                source.DataSource = food;
                txtAnimalD.DataBindings.Clear();
                txtAnimalGender.DataBindings.Clear();
                txtName.DataBindings.Clear()
;
                txtAnimalD.DataBindings.Add("Text", source, "Id");
                txtName.DataBindings.Add("Text", source, "Name");
                txtAnimalGender.DataBindings.Add("Text", source, "Weight");


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            frmFoodDetails frm = new frmFoodDetails
            {
                InsertOrUpdate = false,
                AnimalId = animalId,
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadFood();
                source.Position = source.Count - 1;
            }
        }

        private void dgvAnimals_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmFoodInMeal frm = new frmFoodInMeal
            {
                AnimalInfo = GetAnimalObject()
            };
            Animal animal = GetAnimalObject();
            var meal = mealRepository.GetMealByAnimalId(animal.Id);
            if (meal == null)
            {
                MessageBox.Show("Meal has not been created | Please create meal");
            }
            else
            {
                frm.ShowDialog();
            }


        }

        public void LoadExpertInformation()
        {

            var expert = expertRepository.GetExpertByEmail(email);
            String name = expert.FirstName + " " + expert.LastName;
            cboExpertGender.SelectedIndex = 0;
            try
            {
                txtExpertID.Text = expert.Id.ToString();
                txtExpertName.Text = name;
                txtExpertEmail.Text = expert.Email;
                txtExpertPhonenumber.Text = expert.PhoneNumber;
                cboExpertGender.Text = expert.Gender;

            }
            catch (Exception)
            {

                throw;
            }



        }

        private void btnUpdatePersonalInformation_Click(object sender, EventArgs e)
        {
            frmExpertDetail frmStaffDetail = new frmExpertDetail()
            {
                Text = "Update personal information",
                InsertOrUpdate = true,
                ExpertInfo = expertRepository.GetExpertByEmail(email),
                expertRepository1 = expertRepository,
            };
            if (frmStaffDetail.ShowDialog() == DialogResult.OK)
            {
                LoadExpertInformation();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin()
            {

            };
            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var log = logRepository.GetHealthLogsBySpecies(txtLogAnimalSpecies.Text, email);
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadHealLog();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            var log = logRepository.GetHealthLogs(email);
            int maxPage = (int)Math.Ceiling((double)log.Count() / itemsPerPage);
            if (currentPage < maxPage)
            {
                currentPage++;
                LoadHealLog();
            }
        }
    }
}
