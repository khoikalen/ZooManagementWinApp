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
    public partial class frmAnimal : Form
    {
        IAnimalRepository animalRepository = new AnimalRepository();
        BindingSource source;
        public frmAnimal()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                source = new BindingSource();
                source.DataSource = animalRepository.GetAllAnimals();

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
                cboAnimalCage.DataBindings.Add("Text", source, "CageId");

                dgvAnimalList.DataSource = null;
                dgvAnimalList.DataSource = source;
            }
            catch (Exception ex)
            {

                throw new Exception("");
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAnimalDetail frmAnimalDetail = new frmAnimalDetail();
            if (frmAnimalDetail.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void frmAnimal_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
