using BusinessObjects.Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZooManagementWinApp
{
    public partial class frmCageDetailMovingAnimal : Form
    {
        IAnimalRepository animalRepository = new AnimalRepository();
        ICageRepository cageRepository = new CageRepository();
        IStaffRepository staffRepository = new StaffRepository();
        IAreaRepository areaRepository = new AreaRepostitory();
        ILogRepository logRepository = new LogRepository();
        public Animal animalInformation { get; set; }
        public Cage cageInformation { get; set; }
        public Cage currentCage { get; set; }
        private void LoadData()
        {
            try
            {
                txtCageID.Text = cageInformation.Id.ToString();
                txtCageName.Text = cageInformation.Name;
                txtCageArea.Text = areaRepository.GetAreaByID(cageInformation.AreaId).Name;
                txtCageQuantity.Text = cageInformation.Quantity.ToString();
                txtCageStatus.Text = "Owned";
                txtCageStaff.Text = staffRepository.GetStaffById(cageInformation.StaffId).Email;
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

        private Cage GetCageObject()
        {
            return cageRepository.GetCageById(cageInformation.Id);
        }

        private void UpdateAnimalCage(int cageID)
        {
            var animal = animalInformation;
            animal.CageId = cageID;
            animalRepository.UpdateAnimalInformation(animal);
        }
        private void UpdateCageQuantity()
        {
            var cageList = cageRepository.GetCages();
            foreach (var cage in cageList)
            {
                cage.Quantity = animalRepository.AnimalQuantityInCage(cage.Id);
                cageRepository.UpdateCage(cage);
            }
        }
        public void MoveCage()
        {
            frmLogDetail frmLogDetail = new frmLogDetail();
            var selectedCage = GetCageObject();
            if (selectedCage.Quantity == 0)
            {
                var cage = new Cage
                {
                    Id = int.Parse(txtCageID.Text),
                    Name = txtCageName.Text,
                    Quantity = int.Parse(txtCageQuantity.Text),
                    CageStatus = txtCageStatus.Text,
                    CageType = "Close",
                    AreaId = cageRepository.GetCageById(int.Parse(txtCageID.Text)).AreaId,
                    StaffId = cageRepository.GetCageById(int.Parse(txtCageID.Text)).StaffId,
                };
                UpdateAnimalCage(cage.Id);
                cageRepository.UpdateCage(cage);
                UpdateCageQuantity();
                frmLogDetail = CreateAnimalMoveCageLog();
                frmLogDetail.SaveAnimal();
                MessageBox.Show("Move animal successfully!");
            }
            else if (selectedCage.Quantity != 0)
            {
                var animal = animalRepository.GetAnimalByCageID(selectedCage.Id);
                if (animalInformation.Specie.Equals(animal.First().Specie))
                {
                    var cage = new Cage
                    {
                        Id = int.Parse(txtCageID.Text),
                        Name = txtCageName.Text,
                        Quantity = int.Parse(txtCageQuantity.Text),
                        CageStatus = txtCageStatus.Text,
                        CageType = "Close",
                        AreaId = cageRepository.GetCageById(int.Parse(txtCageID.Text)).AreaId,
                        StaffId = cageRepository.GetCageById(int.Parse(txtCageID.Text)).StaffId,
                    };
                    UpdateAnimalCage(cage.Id);
                    cageRepository.UpdateCage(cage);
                    UpdateCageQuantity();
                    frmLogDetail = CreateAnimalMoveCageLog();
                    frmLogDetail.SaveAnimal();
                    MessageBox.Show("Move animal successfully!");
                }
                else
                {
                    MessageBox.Show("Cannot move this animal because of difference in species");
                }
            }
        }

        private frmLogDetail CreateAnimalMoveCageLog()
        {
            frmLogDetail frmLogDetail = new frmLogDetail()
            {
                Text = "Move cage log",
                animalInformation = animalInformation,
                cageInformation = GetCageObject(),
                currentCage = currentCage,
                CreateOrMove = false,
            };
            return frmLogDetail;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            MoveCage();
        }

        private void frmCageDetailMovingAnimal_Load(object sender, EventArgs e)
        {
            LoadData();

        }
    }
}
