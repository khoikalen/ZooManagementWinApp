using BusinessObjects.Models;
using Microsoft.VisualBasic.Logging;
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
    public partial class frmLogDetail : Form
    {
        ILogRepository logRepository = new LogRepository();
        public Animal animalInformation { get; set; }
        public Boolean CreateOrMove { get; set; }
        public Cage cageInformation { get; set; }
        public Cage currentCage { get; set; }
        public frmLogDetail()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            if (CreateOrMove)
            {
                cboLogType.SelectedIndex = 0;
            }
            else
            {
                cboLogType.SelectedIndex = 1;
                txtDescription.Text = "Move animal '" + animalInformation.Name + "'  from cage  '" +
                    currentCage.Name + "'  to cage  '" + cageInformation.Name + "'";
            }
            txtAnimal.Text = animalInformation.Name;
            txtCreateDate.Text = DateTime.Now.ToString();
        }

        private void frmLogDetail_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        public void SaveAnimal()
        {
            LoadData();
            if (CreateOrMove)
            {
                var animalLog = new AnimalLog()
                {
                    AnimalId = animalInformation.Id,
                    DateTime = DateTime.Parse(txtCreateDate.Text),
                    ShortDescription = txtDescription.Text,
                    Type = cboLogType.Text,
                };
                logRepository.CreateLog(animalLog);

            }
            else
            {
                var animalLog = new AnimalLog()
                {
                    AnimalId = animalInformation.Id,
                    DateTime = DateTime.Now,
                    ShortDescription = txtDescription.Text,
                    Type = cboLogType.Text,
                };
                logRepository.CreateLog(animalLog);
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SaveAnimal();
        }
    }
}
