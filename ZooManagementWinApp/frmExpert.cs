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


    public partial class frmExpert : Form
    {

        ILogRepository logRepository = new LogRepository();
        BindingSource source;
        public frmExpert()
        {
            InitializeComponent();
        }

        private void frmExpert_Load(object sender, EventArgs e)
        {
            loadHealLog();
        }

        private void loadHealLog()
        {
            var log = logRepository.GetLog("expert1@gmail.com");
            try
            {
                source = new BindingSource();
                source.DataSource = log;    

                txtType.DataBindings.Clear();
                txtShortDescription.DataBindings.Clear();
                txtAnimalName.DataBindings.Clear();
                txtSpecies.DataBindings.Clear();
                dtpDatetime.DataBindings.Clear();
                dgvViewLog.DataBindings.Clear();

                txtSpecies.DataBindings.Add("Text",source, "Species");
                txtAnimalName.DataBindings.Add("Text",source, "AnimalName");
                txtShortDescription.DataBindings.Add("Text",source, "ShortDescription");
                txtType.DataBindings.Add("Text",source, "Type");
                dtpDatetime.DataBindings.Add("Text",source, "DateTime");

                dgvViewLog.DataSource = null;
                dgvViewLog.DataSource= source;
                

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }



    }
}
