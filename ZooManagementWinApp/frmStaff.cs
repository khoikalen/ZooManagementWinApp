﻿using BusinessObjects.Models;
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
            frmAnimal frmAnimal = new frmAnimal()
            {
                cageInformation = cageRepository.GetCageById(int.Parse(txtCageID.Text)),
                staffInformation = staffRepository.GetStaffByEmail(staffEmail),
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

        }
    }
}
