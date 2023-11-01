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
    public partial class frmFoodStorageDetails : Form
    {
        public frmFoodStorageDetails()
        {
            InitializeComponent();
        }


        public IFoodStorageRepository FoodStorageRepository = new FoodStorageRepository();
        public bool InsertOrUpdate { get; set; }
        public FoodStorage FoodStorageInformation { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (InsertOrUpdate == false)
                {
                    var food = new FoodStorage
                    {
                        Name = txtFoodName.Text,
                        Type = cbFoodType.Text,
                        Available = double.Parse(txtFoodAvailable.Text),

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
                    FoodStorageRepository.InsertFood(food);

                }
                else
                {
                    var food = new FoodStorage
                    {
                        Id = int.Parse(txtFoodID.Text),
                        Name = txtFoodName.Text,
                        Type = cbFoodType.Text,
                        Available = double.Parse(txtFoodAvailable.Text),

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

                    FoodStorageRepository.UpdateFood(food);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Food is existed");
            }
        }

        private void btnCancle_Click(object sender, EventArgs e) => Close();

        private void frmFoodStorageDetails_Load(object sender, EventArgs e)
        {
            cbFoodType.SelectedIndex = 0;
            txtFoodID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                lbTitle.Text = "Update food in storage";
                txtFoodID.Text = FoodStorageInformation.Id.ToString();
                txtFoodName.Text = FoodStorageInformation.Name.ToString();
                cbFoodType.Text = FoodStorageInformation.Type.ToString();
                txtFoodAvailable.Text = FoodStorageInformation.Available.ToString();
            }
            else
            {
                lbTitle.Text = "Add new food";
                txtFoodID.Enabled = false;
            }
        }
    }
}
