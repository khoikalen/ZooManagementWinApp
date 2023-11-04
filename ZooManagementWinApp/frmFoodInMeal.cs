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
    public partial class frmFoodInMeal : Form
    {
        public frmFoodInMeal()
        {
            InitializeComponent();
        }
        IFoodRepository foodRepository = new FoodRepository();
        IMealRepository mealRepository = new MealRepository();
        IFoodStorageRepository foodStorageRepository = new FoodStorageRepository();
        IFoodInMealRepository foodInMealRepository = new FoodInMealRepository();
        public bool StaffOrExpert { get; set; }
        public bool ViewCageOrAnimal { get; set; }
        public Animal AnimalInfo { get; set; }
        public List<Food> FoodViewByCage { get; set; }
        BindingSource source;
        string dupli = "";

        private void frmFoodInMeal_Load(object sender, EventArgs e)
        {

            LoadFood();
        }


        private void LoadFood()
        {
            List<Food> food = new List<Food>();

            if (ViewCageOrAnimal)
            {
                food = FoodViewByCage;
            }
            else
            {

                var meal = mealRepository.GetMealByAnimalId(AnimalInfo.Id);
                /*                if (meal == null)
                                {
                                    MessageBox.Show("Meal has not been created");
                                    this.Hide();
                                    return;
                                }*/
                food = foodRepository.GetFoodByMealId(meal.Id);
                btnConfirmMeal.Visible = false;

            }
            try
            {
                source = new BindingSource();
                source.DataSource = food;

                txtFoodID.DataBindings.Clear();
                txtFoodName.DataBindings.Clear();
                txtFoodWeight.DataBindings.Clear();

                txtFoodID.DataBindings.Add("Text", source, "Id");
                txtFoodName.DataBindings.Add("Text", source, "Name");
                txtFoodWeight.DataBindings.Add("Text", source, "Weight");

                dgvFood.DataSource = null;
                dgvFood.DataSource = source;

                if (StaffOrExpert)
                {
                    btnDelete.Visible = false;
                    btnAddFood.Visible = false;
                }
                else
                {
                    btnConfirmMeal.Visible = false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Food GetFoodObject()
        {
            Food food = null;
            try
            {
                food = new Food
                {
                    Id = int.Parse(txtFoodID.Text),
                    Name = txtFoodName.Text,
                    Weight = double.Parse(txtFoodWeight.Text),
                };
            }
            catch (Exception)
            {

                throw;
            }
            return food;
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            frmFoodDetails frm = new frmFoodDetails
            {
                InsertOrUpdate = false,
                AnimalId = AnimalInfo.Id,
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadFood();
                source.Position = source.Count - 1;
            }
        }

        private void dgvFood_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmFoodDetails frm = new frmFoodDetails
            {
                InsertOrUpdate = true,
                FoodInfo = GetFoodObject(),
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadFood();
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
                    var food = GetFoodObject();
                    foodInMealRepository.DelInMeal(food.Id);
                    foodRepository.DeleteFood(food.Id);
                    LoadFood();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnConfirmMeal_Click(object sender, EventArgs e)
        {
            bool check = true;
            List<FoodStorage> fs = new List<FoodStorage>();
            var foodStorage = foodStorageRepository.GetAllFoodStorage();
            foreach (var food in FoodViewByCage)
            {
                var available = foodStorage.Where(storage => storage.Name == food.Name);
                double? result = available.Select(a => a.Available).SingleOrDefault();
                if (food.Weight > result)
                {
                    check = false;
                    dupli += food.Name;
                }
            }

            if (check)
            {
                foreach (var food in FoodViewByCage)
                {
                    FoodStorage storage = foodStorageRepository.GetFoodInStorageByName(food.Name);
                    storage.Available = storage.Available - food.Weight;
                    foodStorageRepository.UpdateFood(storage);
                }
            }
            else
            {
                MessageBox.Show(dupli + " does not have enough");
            }

        }


    }
}
