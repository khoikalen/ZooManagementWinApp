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
    public partial class frmCageDetailMovingAnimal : Form
    {
        IAnimalRepository animalRepository = new AnimalRepository();
        ICageRepository cageRepository = new CageRepository();
        IStaffRepository staffRepository = new StaffRepository();
        public Animal animalInformation { get; set; }
        public Cage cageInformation { get; set; }

        private void LoadData()
        {
            try
            {
            }
            catch (Exception)
            {

                throw;
            }
        }
        public frmCageDetailMovingAnimal()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
