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
    public partial class frmStaff : Form
    {
        ICageRepository cageRepository = new CageRepository();
        IStaffRepository staffRepository = new StaffRepository();
        IAccountRepository accountRepository = new AccountRepository();
        IAnimalRepository animalRepository = new AnimalRepository();
        IFoodRepository foodRepository = new FoodRepository();
        IMealRepository mealRepository = new MealRepository();
        public String staffEmail { get; set; }
        public String staffPassword { get; set; }
        BindingSource source;
        public frmStaff()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            source = new BindingSource();
            var cageList = cageRepository.GetCagesByStaffEmail(staffEmail);
            foreach (var cage in cageList)
            {
                cage.Quantity = animalRepository.AnimalQuantityInCage(cage.Id);
            }
            source.DataSource = cageList;
            var staffInfo = staffRepository.GetStaffByEmail(staffEmail);

            txtStaffEmail.Text = staffInfo.Email;
            txtStaffName.Text = staffInfo.FirstName + " " + staffInfo.LastName;
            txtStaffID.Text = staffInfo.Id.ToString();
            txtStaffPhonenumber.Text = staffInfo.PhoneNumber.ToString();
            cboStaffGender.Text = staffInfo.Gender;

            txtCageID.DataBindings.Clear();
            txtCageName.DataBindings.Clear();
            txtCageQuantity.DataBindings.Clear();
            cboCageStatus.DataBindings.Clear();
            txtCageAreaID.DataBindings.Clear();

            txtCageID.DataBindings.Add("Text", source, "Id");
            txtCageName.DataBindings.Add("Text", source, "Name");
            txtCageQuantity.DataBindings.Add("Text", source, "Quantity");
            cboCageStatus.DataBindings.Add("Text", source, "CageStatus");
            txtCageAreaID.DataBindings.Add("Text", source, "AreaId");

            dgvCageList.DataBindings.Clear();
            dgvCageList.DataSource = source;
            dgvCageList.Columns["CageType"].Visible = false;
            dgvCageList.Columns["Area"].Visible = false;
            dgvCageList.Columns["staff"].Visible = false;
            dgvCageList.Columns["Animals"].Visible = false;
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnUpdatePersonalInformation_Click(object sender, EventArgs e)
        {
            frmStaffDetail frmStaffDetail = new frmStaffDetail()
            {
                Text = "Update personal information",
                InsertOrUpdate = true,
                StaffInfo = staffRepository.GetStaffByEmail(staffEmail),
                userRole = "STAFF",
                staffPassword = accountRepository.GetAccountPassWordByEmail(staffEmail),
            };
            if (frmStaffDetail.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnViewCage_Click(object sender, EventArgs e)
        {
            var selectedCage = cageRepository.GetCageById(int.Parse(txtCageID.Text));
     
                frmAnimal frmAnimal = new frmAnimal()
                {
                    Text = txtCageName.Text,
                    cageInformation = cageRepository.GetCageById(int.Parse(txtCageID.Text)),
                    staffInformation = staffRepository.GetStaffByEmail(staffEmail),
                    currentCage = cageRepository.GetCageById(int.Parse(txtCageID.Text))
                };
                this.Hide();
                if (frmAnimal.ShowDialog() == DialogResult.Cancel)
                {
                    LoadData();
                    this.Show();
            }
           
        }

        private void btnViewCageMeal_Click(object sender, EventArgs e)
        {
            List<Animal> animals = new List<Animal>();
            List<Meal> meals = new List<Meal>();
            List<Food> foods = new List<Food>();
            int index = 0;
            animals = animalRepository.GetAnimalByCageID(int.Parse(txtCageID.Text));
            if (animals.Count==0)
            {
                MessageBox.Show("There is no animal in this cage");
                return;
            }
            foreach (Animal animal in animals)
            {
                var meal = mealRepository.GetMealByAnimalId(animal.Id);
                if (meal == null)
                {
                    MessageBox.Show("Meal " + animal.Name + " has not been created");
                    return;
                }
                meals.Add(meal);
            }
            foreach (Meal meal in meals)
            {
                foods.AddRange(foodRepository.GetFoodByMealId(meal.Id));
            }
            var groupItems = foods.GroupBy(food => food.Name)
                .Select(group =>
                {
                    var firstItem = group.First();
                    firstItem.Weight = group.Sum(item => item.Weight);
                    return firstItem;
                }).ToList();
            frmFoodInMeal frm = new frmFoodInMeal()
            {
                ViewCageOrAnimal = true,
                StaffOrExpert = true,
                FoodViewByCage = groupItems,
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Confirm Successfully");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }
    }
}
