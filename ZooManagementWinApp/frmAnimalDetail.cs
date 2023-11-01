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
    public partial class frmAnimalDetail : Form
    {
        IAnimalRepository animalRepository = new AnimalRepository();
        ICageRepository cageRepository = new CageRepository();
        public Cage cageInformation { get; set; }
        public Animal animalInformation { get; set; }
        public Boolean InsertOrUpdate { get; set; }
        public frmAnimalDetail()
        {
            InitializeComponent();
        }

        private void LoadDetailData()
        {
            /* cboAnimalCage.DataSource = animalRepository.GetAllAnimals();
             cboAnimalCage.ValueMember = "Id";
             cboAnimalCage.DisplayMember = "Name";*/
            if (InsertOrUpdate)
            {
                cboAnimalStatus.SelectedIndex = 0;
                txtAnimalCage.Text = cageInformation.Name;
                txtAnimalSpecie.Text = animalRepository.GetAnimalSpecie(cageInformation.Id);
            }
            else
            {
                txtAnimalName.Text = animalInformation.Name;
                txtAnimalDOB.Text = animalInformation.Dob.ToString();
                txtAnimalDEZ.Text = animalInformation.Dez.ToString();
                txtAnimalGender.Text = animalInformation.Gender;
                txtAnimalSpecie.Text = animalInformation.Specie;
                cboAnimalStatus.Text = animalInformation.Status;
                txtAnimalCage.Text = cageInformation.Name;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (InsertOrUpdate)
                {
                    Animal animal = new Animal()
                    {
                        Name = txtAnimalName.Text,
                        Dob = DateTime.Parse(txtAnimalDOB.Text),
                        Dez = DateTime.Now,
                        Gender = txtAnimalGender.Text,
                        Specie = txtAnimalSpecie.Text,
                        Status = cboAnimalStatus.Text,
                        CageId = cageInformation.Id,
                    };
                    animalRepository.CreateNewAnimal(animal);
                }
                else
                {
                    Animal animal = new Animal()
                    {
                        Id = animalInformation.Id,
                        Name = txtAnimalName.Text,
                        Dob = DateTime.Parse(txtAnimalDOB.Text),
                        Dez = DateTime.Now,
                        Gender = txtAnimalGender.Text,
                        Specie = txtAnimalSpecie.Text,
                        Status = cboAnimalStatus.Text,
                        CageId = cageInformation.Id,
                    };
                    animalRepository.UpdateAnimalInformation(animal);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void frmAnimalDetail_Load(object sender, EventArgs e)
        {
            txtAnimalGender.SelectedIndex = 0;
            LoadDetailData();
        }
    }
}
