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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZooManagementWinApp
{
    public partial class frmCageDetail : Form
    {
        public ICageRepository CageRepository { get; set; }
        public IAreaRepository areaRepository = new AreaRepostitory();
        public IStaffRepository staffRepository = new StaffRepository();
        public IAnimalRepository animalRepository = new AnimalRepository();
        public bool InsertOrUpdate { get; set; }
        public Animal animalInformation { get; set; }
        public bool IsMoveCage { get; set; }
        public Cage CageInfo { get; set; }
        public frmCageDetail()
        {
            InitializeComponent();
        }

        private void LoadCageDetailWhenMovingAnimal()
        {
            try
            {
                txtCageID.Enabled = false;
                cboAreaId.Enabled = false;
                cboCageStatus.Enabled = false;
                cboStaffId.Enabled = false;
                txtCageQuantity.Enabled = false;

                txtCageID.Text = CageInfo.Id.ToString();
                txtCageName.Text = CageInfo.Name;
                cboAreaId.Text = areaRepository.GetAreaByID(CageInfo.AreaId).Name;
                txtCageQuantity.Text = CageInfo.Quantity.ToString();
                cboCageStatus.Text = "Owned";
                cboStaffId.Text = staffRepository.GetStaffById(CageInfo.StaffId).Email;

            }
            catch (Exception)
            {

                throw;
            }

        }
        private void frmCageDetail_Load(object sender, EventArgs e)
        {
            if (IsMoveCage)
            {
                LoadCageDetailWhenMovingAnimal();
            }
            else
            {
                LoadAreasList();
                LoadStaffsList();
                cboStaffId.SelectedIndex = 0;
                cboAreaId.SelectedIndex = 0;
                cboCageStatus.SelectedIndex = 0;
                txtCageQuantity.Text = "0";
                txtCageQuantity.Enabled = false;

                txtCageID.Enabled = false;
                if (InsertOrUpdate == true)
                {
                    txtCageID.Text = CageInfo.Id.ToString();
                    txtCageName.Text = CageInfo.Name;
                    txtCageQuantity.Text = CageInfo.Quantity.ToString();
                    cboCageStatus.Text = CageInfo.CageStatus;
                    cboAreaId.SelectedIndex = CageInfo.AreaId - 1;
                    cboStaffId.SelectedIndex = CageInfo.StaffId - 2;
                }

            }
        }
        private Cage GetCageObject()
        {
            CageRepository = new CageRepository();
            return CageRepository.GetCageById(int.Parse(txtCageID.Text));
        }
        private void UpdateAnimalCage(int cageID)
        {
            var animal = animalInformation;
            animal.CageId = cageID;
            animalRepository.UpdateAnimalInformation(animal);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var cage = new Cage();
            CageRepository = new CageRepository();
            try
            {
                if (IsMoveCage)
                {
                    var selectedCage = GetCageObject();
                    if (selectedCage.Quantity == 0)
                    {
                        cage = new Cage
                        {
                            Id = int.Parse(txtCageID.Text),
                            Name = txtCageName.Text,
                            Quantity = int.Parse(txtCageQuantity.Text),
                            CageStatus = cboCageStatus.Text,
                            CageType = "Close",
                            AreaId = CageRepository.GetCageById(int.Parse(txtCageID.Text)).AreaId,
                            StaffId = CageRepository.GetCageById(int.Parse(txtCageID.Text)).StaffId,
                        };
                        UpdateAnimalCage(cage.Id);
                        cage.Quantity = animalRepository.AnimalQuantityInCage(cage.Id);
                        CageRepository.UpdateCage(cage);
                    } else if(selectedCage.Quantity != 0) {
                        var animal = animalRepository.GetAnimalByCageID(selectedCage.Id);
                        if(animalInformation.Specie.Equals(animal.First().Specie)){
                            cage = new Cage
                            {
                                Id = int.Parse(txtCageID.Text),
                                Name = txtCageName.Text,
                                Quantity = int.Parse(txtCageQuantity.Text),
                                CageStatus = cboCageStatus.Text,
                                CageType = "Close",
                                AreaId = CageRepository.GetCageById(int.Parse(txtCageID.Text)).AreaId,
                                StaffId = CageRepository.GetCageById(int.Parse(txtCageID.Text)).StaffId,
                            };
                            UpdateAnimalCage(cage.Id);
                            cage.Quantity = animalRepository.AnimalQuantityInCage(cage.Id);
                            CageRepository.UpdateCage(cage);
                        }
                    }
                }
                else if (InsertOrUpdate == false)
                {
                    cage = new Cage
                    {
                        Name = txtCageName.Text,
                        Quantity = int.Parse(txtCageQuantity.Text),
                        CageStatus = cboCageStatus.Text,
                        CageType = "Close",
                        AreaId = int.Parse(cboAreaId.SelectedValue.ToString()),
                        StaffId = int.Parse(cboStaffId.SelectedValue.ToString()),
                    };
                    ValidationContext context = new ValidationContext(cage);
                    List<ValidationResult> results = new List<ValidationResult>();
                    if (!Validator.TryValidateObject(cage, context, results))
                    {
                        foreach (ValidationResult result in results)
                        {
                            MessageBox.Show(result.ErrorMessage, "Message");
                            return;
                        }
                    }
                    CageRepository.InsertCage(cage);
                }
                else
                {
                    cage = new Cage
                    {
                        Id = int.Parse(txtCageID.Text),
                        Name = txtCageName.Text,
                        Quantity = int.Parse(txtCageQuantity.Text),
                        CageStatus = cboCageStatus.Text,
                        CageType = "Close",
                        AreaId = int.Parse(cboAreaId.SelectedValue.ToString()),
                        StaffId = int.Parse(cboStaffId.SelectedValue.ToString()),
                    };
                    ValidationContext context = new ValidationContext(cage);
                    List<ValidationResult> results = new List<ValidationResult>();
                    if (!Validator.TryValidateObject(cage, context, results))
                    {
                        foreach (ValidationResult result in results)
                        {
                            MessageBox.Show(result.ErrorMessage, "Message");
                            return;
                        }
                    }
                    if (cage.CageStatus == "Empty")
                    {
                        
                        if (cage.Quantity > 0)
                        {
                            MessageBox.Show("There are still animal in cage, can not change to empty cage");
                        } else
                        {
                            CageRepository.UpdateCage(cage);
                        }
                    }   else
                    {
                        CageRepository.UpdateCage(cage);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save cage");
            }
        }

        private void LoadAreasList()
        {
            try
            {
                var areaList = areaRepository.GetAreas();
                cboAreaId.DataSource = areaList;
                cboAreaId.ValueMember = "Id";
                cboAreaId.DisplayMember = "Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Areas List");
            }
        }

        private void LoadStaffsList()
        {
            try
            {
                var staffList = staffRepository.GetStaffs();
                List<staff> staffView = new List<staff>();
                foreach (staff staff in staffList)
                {
                    if (staff.Id != 1)
                    {
                        staffView.Add(staff);
                    }
                }
                cboStaffId.DataSource = staffView;
                cboStaffId.ValueMember = "Id";
                cboStaffId.DisplayMember = "Email";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Staffs List");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void cboCageStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCageStatus.SelectedIndex == 1)
            {
                txtCageName.Text = "Empty Cage";
                txtCageName.Enabled = false;
            }
            else
            {
                txtCageName.Clear();
                txtCageName.Enabled = true;
            }
        }
    }
}
