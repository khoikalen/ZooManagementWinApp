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
    public partial class frmFoodDetails : Form
    {
        public frmFoodDetails()
        {
            InitializeComponent();
        }
        IFoodStorageRepository foodStorageRepository = new FoodStorageRepository();
        IFoodRepository foodRepository = new FoodRepository();
        IMealRepository mealRepository = new MealRepository();
        IFoodInMealRepository foodInMealRepository = new FoodInMealRepository();
        public bool InsertOrUpdate { get; set; }
        public Food FoodInfo { get; set; }
        public Animal AnimalInfo { get; set; }
        public Meal MealInfo { get; set; }
        public int AnimalId { get; set; }

        public void LoadFoodName()
        {
            try
            {
                var list = foodStorageRepository.GetAllFoodStorage();
                cbFoodName.DataSource = list;
                cbFoodName.ValueMember = "Id";
                cbFoodName.DisplayMember = "Name";

            }
            catch (Exception)
            {

                throw;
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                double weight = 0;
                var foodInStorage = foodStorageRepository.GetFoodInStorageById(int.Parse(cbFoodName.SelectedValue.ToString()));
                double quantity = double.Parse(txtQuantity.Text);
                if (quantity < foodInStorage.Available)
                {
                    if (InsertOrUpdate == false)
                    {
                        Boolean check = false;
                        var mealCheck = mealRepository.GetMealByAnimalId(AnimalId);
                        List<Food> foodCheck = foodRepository.GetFoodByMealId(mealCheck.Id);
                        foreach (var f in foodCheck)
                        {

                            if (cbFoodName.Text == f.Name)
                            {
                                id = f.Id;
                                weight = (double)f.Weight;
                                check = true;
                            }
                        }
                        if (check == true)
                        {
                            var food = new Food()
                            {
                                Id = id,
                                Name = cbFoodName.Text,
                                Weight = double.Parse(txtQuantity.Text) + weight,
                            };
                            foodRepository.UpdateFood(food);
                        }
                        else
                        {
                            var food = new Food
                            {
                                Name = cbFoodName.Text,
                                Weight = double.Parse(txtQuantity.Text),
                            };
                            ValidationContext context = new ValidationContext(food);
                            IList<ValidationResult> errors = new List<ValidationResult>();
                            if (!Validator.TryValidateObject(food, context, errors))
                            {
                                foreach (ValidationResult result in errors)
                                {
                                    MessageBox.Show(result.ErrorMessage, "Can not be left blank");
                                    return;
                                }
                            }
                            foodRepository.InsertFood(food);
                            Meal meals = mealRepository.GetMealByAnimalId(AnimalId);
                            var meal = new Meal();
                            if (meals == null)
                            {
                                meal = new Meal
                                {
                                    Name = "Meal",
                                    AnimalId = AnimalId,
                                };
                                mealRepository.Add(meal);
                            }

                            var foodInMeal = new FoodInMeal
                            {
                                FoodId = food.Id,
                                MealId = meals.Id,
                            };
                            foodInMealRepository.AddInMeal(foodInMeal);
                        }

                    }
                    else
                    {
                        var food = new Food
                        {
                            Id = int.Parse(txtFoodID.Text),
                            Name = cbFoodName.Text,
                            Weight = double.Parse(txtQuantity.Text),
                        };
                        foodRepository.UpdateFood(food);
                    }
                }
                else
                {
                    MessageBox.Show("Not enough " + foodInStorage.Name);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }



        private void btnCancle_Click(object sender, EventArgs e) => Close();

        private void FoodDetails_Load(object sender, EventArgs e)
        {
            LoadFoodName();
            cbFoodName.SelectedIndex = 0;
            txtFoodID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                gbTitle.Text = "Update Food";
                txtFoodID.Text = FoodInfo.Id.ToString();
                txtQuantity.Text = FoodInfo.Weight.ToString();
                cbFoodName.Text = FoodInfo.Name.ToString();

            }
            else
            {
                gbTitle.Text = "Add more food";
                txtFoodID.Enabled = false;
            }
        }
    }
}
