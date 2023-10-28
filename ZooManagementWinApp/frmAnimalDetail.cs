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

        public frmAnimalDetail()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Animal animal = new Animal()
                {
                    Name = txtAnimalName.Text,
                    Dob = DateTime.Parse(txtAnimalDOB.Text),
                    Dez = DateTime.Now,
                    Gender = txtAnimalGender.Text,
                    Specie = txtAnimalSpecie.Text,
                    Status = txtAnimalStatus.Text,
                    CageId = 1
                };
                animalRepository.CreateNewAnimal(animal);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void frmAnimalDetail_Load(object sender, EventArgs e)
        {
            txtAnimalGender.SelectedIndex = 0;
        }
    }
}
