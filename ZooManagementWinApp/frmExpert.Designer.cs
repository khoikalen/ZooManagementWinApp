namespace ZooManagementWinApp
{
    partial class frmExpert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new System.Windows.Forms.TabControl();
            tabViewLog = new System.Windows.Forms.TabPage();
            btnNext = new System.Windows.Forms.Button();
            btnPrevious = new System.Windows.Forms.Button();
            txtLogAnimalSpecies = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            dtpDatetime = new System.Windows.Forms.DateTimePicker();
            lbDatetime = new System.Windows.Forms.Label();
            txtShortDescription = new System.Windows.Forms.TextBox();
            txtAnimalName = new System.Windows.Forms.TextBox();
            lbShortDescription = new System.Windows.Forms.Label();
            lbAnimalName = new System.Windows.Forms.Label();
            txtType = new System.Windows.Forms.TextBox();
            lbType = new System.Windows.Forms.Label();
            txtSpecies = new System.Windows.Forms.TextBox();
            lbSpecies = new System.Windows.Forms.Label();
            lbTitle = new System.Windows.Forms.Label();
            dgvViewLog = new System.Windows.Forms.DataGridView();
            tabCreateMeal = new System.Windows.Forms.TabPage();
            groupBox1 = new System.Windows.Forms.GroupBox();
            dtpDEZ = new System.Windows.Forms.DateTimePicker();
            label7 = new System.Windows.Forms.Label();
            dtpDOB = new System.Windows.Forms.DateTimePicker();
            label6 = new System.Windows.Forms.Label();
            txtAnimalStatus = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtAnimalSpecies = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtAnimalGender = new System.Windows.Forms.TextBox();
            lbQuantity = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            lbName = new System.Windows.Forms.Label();
            txtAnimalD = new System.Windows.Forms.TextBox();
            lbAnimalID = new System.Windows.Forms.Label();
            btnCreateMeal = new System.Windows.Forms.Button();
            dgvAnimals = new System.Windows.Forms.DataGridView();
            tabFoodStorage = new System.Windows.Forms.TabPage();
            txtFoodID = new System.Windows.Forms.TextBox();
            lbFoodID = new System.Windows.Forms.Label();
            btnDelete = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            txtFoodAvailable = new System.Windows.Forms.TextBox();
            txtFoodType = new System.Windows.Forms.TextBox();
            txtFoodName = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            cbFilterFood = new System.Windows.Forms.ComboBox();
            dgvViewFoodStorage = new System.Windows.Forms.DataGridView();
            lbFoodStorage = new System.Windows.Forms.Label();
            tabPage1 = new System.Windows.Forms.TabPage();
            btnLogout = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            btnUpdatePersonalInformation = new System.Windows.Forms.Button();
            cboExpertGender = new System.Windows.Forms.ComboBox();
            txtExpertID = new System.Windows.Forms.TextBox();
            txtExpertPhonenumber = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            txtExpertEmail = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            txtExpertName = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            tabControl1.SuspendLayout();
            tabViewLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViewLog).BeginInit();
            tabCreateMeal.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            tabFoodStorage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViewFoodStorage).BeginInit();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabViewLog);
            tabControl1.Controls.Add(tabCreateMeal);
            tabControl1.Controls.Add(tabFoodStorage);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Margin = new System.Windows.Forms.Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(639, 408);
            tabControl1.TabIndex = 0;
            // 
            // tabViewLog
            // 
            tabViewLog.Controls.Add(btnNext);
            tabViewLog.Controls.Add(btnPrevious);
            tabViewLog.Controls.Add(txtLogAnimalSpecies);
            tabViewLog.Controls.Add(btnSearch);
            tabViewLog.Controls.Add(dtpDatetime);
            tabViewLog.Controls.Add(lbDatetime);
            tabViewLog.Controls.Add(txtShortDescription);
            tabViewLog.Controls.Add(txtAnimalName);
            tabViewLog.Controls.Add(lbShortDescription);
            tabViewLog.Controls.Add(lbAnimalName);
            tabViewLog.Controls.Add(txtType);
            tabViewLog.Controls.Add(lbType);
            tabViewLog.Controls.Add(txtSpecies);
            tabViewLog.Controls.Add(lbSpecies);
            tabViewLog.Controls.Add(lbTitle);
            tabViewLog.Controls.Add(dgvViewLog);
            tabViewLog.Location = new System.Drawing.Point(4, 24);
            tabViewLog.Margin = new System.Windows.Forms.Padding(2);
            tabViewLog.Name = "tabViewLog";
            tabViewLog.Padding = new System.Windows.Forms.Padding(2);
            tabViewLog.Size = new System.Drawing.Size(631, 380);
            tabViewLog.TabIndex = 0;
            tabViewLog.Text = "View Log";
            tabViewLog.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new System.Drawing.Point(352, 170);
            btnNext.Margin = new System.Windows.Forms.Padding(2);
            btnNext.Name = "btnNext";
            btnNext.Size = new System.Drawing.Size(78, 20);
            btnNext.TabIndex = 15;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new System.Drawing.Point(235, 170);
            btnPrevious.Margin = new System.Windows.Forms.Padding(2);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new System.Drawing.Size(78, 20);
            btnPrevious.TabIndex = 14;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // txtLogAnimalSpecies
            // 
            txtLogAnimalSpecies.Location = new System.Drawing.Point(468, 134);
            txtLogAnimalSpecies.Margin = new System.Windows.Forms.Padding(2);
            txtLogAnimalSpecies.Name = "txtLogAnimalSpecies";
            txtLogAnimalSpecies.Size = new System.Drawing.Size(96, 23);
            txtLogAnimalSpecies.TabIndex = 13;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(568, 133);
            btnSearch.Margin = new System.Windows.Forms.Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(52, 20);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dtpDatetime
            // 
            dtpDatetime.Enabled = false;
            dtpDatetime.Location = new System.Drawing.Point(387, 88);
            dtpDatetime.Margin = new System.Windows.Forms.Padding(2);
            dtpDatetime.Name = "dtpDatetime";
            dtpDatetime.Size = new System.Drawing.Size(208, 23);
            dtpDatetime.TabIndex = 11;
            // 
            // lbDatetime
            // 
            lbDatetime.AutoSize = true;
            lbDatetime.Location = new System.Drawing.Point(285, 91);
            lbDatetime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbDatetime.Name = "lbDatetime";
            lbDatetime.Size = new System.Drawing.Size(55, 15);
            lbDatetime.TabIndex = 10;
            lbDatetime.Text = "Datetime";
            // 
            // txtShortDescription
            // 
            txtShortDescription.Location = new System.Drawing.Point(143, 131);
            txtShortDescription.Margin = new System.Windows.Forms.Padding(2);
            txtShortDescription.Name = "txtShortDescription";
            txtShortDescription.ReadOnly = true;
            txtShortDescription.Size = new System.Drawing.Size(209, 23);
            txtShortDescription.TabIndex = 9;
            // 
            // txtAnimalName
            // 
            txtAnimalName.Location = new System.Drawing.Point(387, 48);
            txtAnimalName.Margin = new System.Windows.Forms.Padding(2);
            txtAnimalName.Name = "txtAnimalName";
            txtAnimalName.ReadOnly = true;
            txtAnimalName.Size = new System.Drawing.Size(106, 23);
            txtAnimalName.TabIndex = 8;
            // 
            // lbShortDescription
            // 
            lbShortDescription.AutoSize = true;
            lbShortDescription.Location = new System.Drawing.Point(18, 133);
            lbShortDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbShortDescription.Name = "lbShortDescription";
            lbShortDescription.Size = new System.Drawing.Size(98, 15);
            lbShortDescription.TabIndex = 7;
            lbShortDescription.Text = "Short Description";
            // 
            // lbAnimalName
            // 
            lbAnimalName.AutoSize = true;
            lbAnimalName.Location = new System.Drawing.Point(285, 50);
            lbAnimalName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbAnimalName.Name = "lbAnimalName";
            lbAnimalName.Size = new System.Drawing.Size(80, 15);
            lbAnimalName.TabIndex = 6;
            lbAnimalName.Text = "Animal Name";
            // 
            // txtType
            // 
            txtType.Location = new System.Drawing.Point(143, 87);
            txtType.Margin = new System.Windows.Forms.Padding(2);
            txtType.Name = "txtType";
            txtType.ReadOnly = true;
            txtType.Size = new System.Drawing.Size(106, 23);
            txtType.TabIndex = 5;
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Location = new System.Drawing.Point(18, 91);
            lbType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbType.Name = "lbType";
            lbType.Size = new System.Drawing.Size(31, 15);
            lbType.TabIndex = 4;
            lbType.Text = "Type";
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new System.Drawing.Point(143, 48);
            txtSpecies.Margin = new System.Windows.Forms.Padding(2);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.ReadOnly = true;
            txtSpecies.Size = new System.Drawing.Size(106, 23);
            txtSpecies.TabIndex = 3;
            // 
            // lbSpecies
            // 
            lbSpecies.AutoSize = true;
            lbSpecies.Location = new System.Drawing.Point(18, 50);
            lbSpecies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbSpecies.Name = "lbSpecies";
            lbSpecies.Size = new System.Drawing.Size(46, 15);
            lbSpecies.TabIndex = 2;
            lbSpecies.Text = "Species";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new System.Drawing.Point(242, 9);
            lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(96, 15);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "View Log Animal";
            // 
            // dgvViewLog
            // 
            dgvViewLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvViewLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewLog.Location = new System.Drawing.Point(0, 191);
            dgvViewLog.Margin = new System.Windows.Forms.Padding(2);
            dgvViewLog.Name = "dgvViewLog";
            dgvViewLog.ReadOnly = true;
            dgvViewLog.RowHeadersWidth = 62;
            dgvViewLog.RowTemplate.Height = 33;
            dgvViewLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvViewLog.Size = new System.Drawing.Size(631, 193);
            dgvViewLog.TabIndex = 0;
            // 
            // tabCreateMeal
            // 
            tabCreateMeal.Controls.Add(groupBox1);
            tabCreateMeal.Controls.Add(btnCreateMeal);
            tabCreateMeal.Controls.Add(dgvAnimals);
            tabCreateMeal.Location = new System.Drawing.Point(4, 24);
            tabCreateMeal.Margin = new System.Windows.Forms.Padding(2);
            tabCreateMeal.Name = "tabCreateMeal";
            tabCreateMeal.Padding = new System.Windows.Forms.Padding(2);
            tabCreateMeal.Size = new System.Drawing.Size(631, 380);
            tabCreateMeal.TabIndex = 1;
            tabCreateMeal.Text = "Create Meal";
            tabCreateMeal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpDEZ);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dtpDOB);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtAnimalStatus);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtAnimalSpecies);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtAnimalGender);
            groupBox1.Controls.Add(lbQuantity);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(lbName);
            groupBox1.Controls.Add(txtAnimalD);
            groupBox1.Controls.Add(lbAnimalID);
            groupBox1.Location = new System.Drawing.Point(13, 19);
            groupBox1.Margin = new System.Windows.Forms.Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2);
            groupBox1.Size = new System.Drawing.Size(612, 190);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Food and Medicine";
            // 
            // dtpDEZ
            // 
            dtpDEZ.Enabled = false;
            dtpDEZ.Location = new System.Drawing.Point(385, 88);
            dtpDEZ.Margin = new System.Windows.Forms.Padding(2);
            dtpDEZ.Name = "dtpDEZ";
            dtpDEZ.Size = new System.Drawing.Size(211, 23);
            dtpDEZ.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(281, 91);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(83, 15);
            label7.TabIndex = 12;
            label7.Text = "Date enter zoo";
            // 
            // dtpDOB
            // 
            dtpDOB.Enabled = false;
            dtpDOB.Location = new System.Drawing.Point(385, 39);
            dtpDOB.Margin = new System.Windows.Forms.Padding(2);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new System.Drawing.Size(211, 23);
            dtpDOB.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(281, 42);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(73, 15);
            label6.TabIndex = 10;
            label6.Text = "Date of birth";
            // 
            // txtAnimalStatus
            // 
            txtAnimalStatus.Location = new System.Drawing.Point(385, 133);
            txtAnimalStatus.Margin = new System.Windows.Forms.Padding(2);
            txtAnimalStatus.Name = "txtAnimalStatus";
            txtAnimalStatus.ReadOnly = true;
            txtAnimalStatus.Size = new System.Drawing.Size(106, 23);
            txtAnimalStatus.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(281, 134);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(39, 15);
            label5.TabIndex = 8;
            label5.Text = "Status";
            // 
            // txtAnimalSpecies
            // 
            txtAnimalSpecies.Location = new System.Drawing.Point(104, 151);
            txtAnimalSpecies.Margin = new System.Windows.Forms.Padding(2);
            txtAnimalSpecies.Name = "txtAnimalSpecies";
            txtAnimalSpecies.ReadOnly = true;
            txtAnimalSpecies.Size = new System.Drawing.Size(106, 23);
            txtAnimalSpecies.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(16, 154);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(46, 15);
            label4.TabIndex = 6;
            label4.Text = "Species";
            // 
            // txtAnimalGender
            // 
            txtAnimalGender.Location = new System.Drawing.Point(104, 109);
            txtAnimalGender.Margin = new System.Windows.Forms.Padding(2);
            txtAnimalGender.Name = "txtAnimalGender";
            txtAnimalGender.ReadOnly = true;
            txtAnimalGender.Size = new System.Drawing.Size(106, 23);
            txtAnimalGender.TabIndex = 5;
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new System.Drawing.Point(16, 113);
            lbQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new System.Drawing.Size(45, 15);
            lbQuantity.TabIndex = 4;
            lbQuantity.Text = "Gender";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(104, 70);
            txtName.Margin = new System.Windows.Forms.Padding(2);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new System.Drawing.Size(106, 23);
            txtName.TabIndex = 3;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new System.Drawing.Point(16, 74);
            lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbName.Name = "lbName";
            lbName.Size = new System.Drawing.Size(80, 15);
            lbName.TabIndex = 2;
            lbName.Text = "Animal Name";
            // 
            // txtAnimalD
            // 
            txtAnimalD.Location = new System.Drawing.Point(104, 37);
            txtAnimalD.Margin = new System.Windows.Forms.Padding(2);
            txtAnimalD.Name = "txtAnimalD";
            txtAnimalD.ReadOnly = true;
            txtAnimalD.Size = new System.Drawing.Size(106, 23);
            txtAnimalD.TabIndex = 1;
            // 
            // lbAnimalID
            // 
            lbAnimalID.AutoSize = true;
            lbAnimalID.Location = new System.Drawing.Point(16, 37);
            lbAnimalID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbAnimalID.Name = "lbAnimalID";
            lbAnimalID.Size = new System.Drawing.Size(59, 15);
            lbAnimalID.TabIndex = 0;
            lbAnimalID.Text = "Animal ID";
            // 
            // btnCreateMeal
            // 
            btnCreateMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCreateMeal.Location = new System.Drawing.Point(532, 216);
            btnCreateMeal.Margin = new System.Windows.Forms.Padding(2);
            btnCreateMeal.Name = "btnCreateMeal";
            btnCreateMeal.Size = new System.Drawing.Size(98, 25);
            btnCreateMeal.TabIndex = 5;
            btnCreateMeal.Text = "Create Meal";
            btnCreateMeal.UseVisualStyleBackColor = true;
            btnCreateMeal.Click += btnCreateMeal_Click;
            // 
            // dgvAnimals
            // 
            dgvAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new System.Drawing.Point(-4, 242);
            dgvAnimals.Margin = new System.Windows.Forms.Padding(2);
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.RowHeadersWidth = 62;
            dgvAnimals.RowTemplate.Height = 33;
            dgvAnimals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.Size = new System.Drawing.Size(636, 143);
            dgvAnimals.TabIndex = 0;
            dgvAnimals.CellDoubleClick += dgvAnimals_CellDoubleClick;
            // 
            // tabFoodStorage
            // 
            tabFoodStorage.Controls.Add(txtFoodID);
            tabFoodStorage.Controls.Add(lbFoodID);
            tabFoodStorage.Controls.Add(btnDelete);
            tabFoodStorage.Controls.Add(btnAdd);
            tabFoodStorage.Controls.Add(txtFoodAvailable);
            tabFoodStorage.Controls.Add(txtFoodType);
            tabFoodStorage.Controls.Add(txtFoodName);
            tabFoodStorage.Controls.Add(label3);
            tabFoodStorage.Controls.Add(label2);
            tabFoodStorage.Controls.Add(label1);
            tabFoodStorage.Controls.Add(cbFilterFood);
            tabFoodStorage.Controls.Add(dgvViewFoodStorage);
            tabFoodStorage.Controls.Add(lbFoodStorage);
            tabFoodStorage.Location = new System.Drawing.Point(4, 24);
            tabFoodStorage.Margin = new System.Windows.Forms.Padding(2);
            tabFoodStorage.Name = "tabFoodStorage";
            tabFoodStorage.Padding = new System.Windows.Forms.Padding(2);
            tabFoodStorage.Size = new System.Drawing.Size(631, 380);
            tabFoodStorage.TabIndex = 2;
            tabFoodStorage.Text = "Food Storage";
            tabFoodStorage.UseVisualStyleBackColor = true;
            // 
            // txtFoodID
            // 
            txtFoodID.Location = new System.Drawing.Point(143, 75);
            txtFoodID.Margin = new System.Windows.Forms.Padding(2);
            txtFoodID.Name = "txtFoodID";
            txtFoodID.ReadOnly = true;
            txtFoodID.Size = new System.Drawing.Size(106, 23);
            txtFoodID.TabIndex = 12;
            // 
            // lbFoodID
            // 
            lbFoodID.AutoSize = true;
            lbFoodID.Location = new System.Drawing.Point(60, 79);
            lbFoodID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbFoodID.Name = "lbFoodID";
            lbFoodID.Size = new System.Drawing.Size(21, 15);
            lbFoodID.TabIndex = 11;
            lbFoodID.Text = " ID";
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(125, 173);
            btnDelete.Margin = new System.Windows.Forms.Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(78, 20);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(29, 173);
            btnAdd.Margin = new System.Windows.Forms.Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(78, 20);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtFoodAvailable
            // 
            txtFoodAvailable.Location = new System.Drawing.Point(467, 73);
            txtFoodAvailable.Margin = new System.Windows.Forms.Padding(2);
            txtFoodAvailable.Name = "txtFoodAvailable";
            txtFoodAvailable.ReadOnly = true;
            txtFoodAvailable.Size = new System.Drawing.Size(106, 23);
            txtFoodAvailable.TabIndex = 8;
            // 
            // txtFoodType
            // 
            txtFoodType.Location = new System.Drawing.Point(467, 113);
            txtFoodType.Margin = new System.Windows.Forms.Padding(2);
            txtFoodType.Name = "txtFoodType";
            txtFoodType.ReadOnly = true;
            txtFoodType.Size = new System.Drawing.Size(106, 23);
            txtFoodType.TabIndex = 7;
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new System.Drawing.Point(143, 113);
            txtFoodName.Margin = new System.Windows.Forms.Padding(2);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.ReadOnly = true;
            txtFoodName.Size = new System.Drawing.Size(106, 23);
            txtFoodName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(350, 75);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 15);
            label3.TabIndex = 5;
            label3.Text = "Available";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(350, 115);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(60, 117);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // cbFilterFood
            // 
            cbFilterFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbFilterFood.FormattingEnabled = true;
            cbFilterFood.Items.AddRange(new object[] { "meat", "plant", "medicine" });
            cbFilterFood.Location = new System.Drawing.Point(458, 174);
            cbFilterFood.Margin = new System.Windows.Forms.Padding(2);
            cbFilterFood.Name = "cbFilterFood";
            cbFilterFood.Size = new System.Drawing.Size(169, 23);
            cbFilterFood.TabIndex = 2;
            cbFilterFood.SelectedIndexChanged += cbFilterFood_SelectedIndexChanged;
            // 
            // dgvViewFoodStorage
            // 
            dgvViewFoodStorage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvViewFoodStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewFoodStorage.Location = new System.Drawing.Point(0, 197);
            dgvViewFoodStorage.Margin = new System.Windows.Forms.Padding(2);
            dgvViewFoodStorage.Name = "dgvViewFoodStorage";
            dgvViewFoodStorage.ReadOnly = true;
            dgvViewFoodStorage.RowHeadersWidth = 62;
            dgvViewFoodStorage.RowTemplate.Height = 33;
            dgvViewFoodStorage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvViewFoodStorage.Size = new System.Drawing.Size(634, 186);
            dgvViewFoodStorage.TabIndex = 1;
            dgvViewFoodStorage.CellDoubleClick += dgvViewFoodStorage_CellDoubleClick;
            // 
            // lbFoodStorage
            // 
            lbFoodStorage.AutoSize = true;
            lbFoodStorage.Location = new System.Drawing.Point(228, 24);
            lbFoodStorage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbFoodStorage.Name = "lbFoodStorage";
            lbFoodStorage.Size = new System.Drawing.Size(152, 15);
            lbFoodStorage.TabIndex = 0;
            lbFoodStorage.Text = "Food and Medicine Storage";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnLogout);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Margin = new System.Windows.Forms.Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(2);
            tabPage1.Size = new System.Drawing.Size(631, 380);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Information";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new System.Drawing.Point(484, 310);
            btnLogout.Margin = new System.Windows.Forms.Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(78, 20);
            btnLogout.TabIndex = 16;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnUpdatePersonalInformation);
            groupBox2.Controls.Add(cboExpertGender);
            groupBox2.Controls.Add(txtExpertID);
            groupBox2.Controls.Add(txtExpertPhonenumber);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtExpertEmail);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtExpertName);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Location = new System.Drawing.Point(52, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(517, 190);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Expert information";
            // 
            // btnUpdatePersonalInformation
            // 
            btnUpdatePersonalInformation.Location = new System.Drawing.Point(183, 143);
            btnUpdatePersonalInformation.Name = "btnUpdatePersonalInformation";
            btnUpdatePersonalInformation.Size = new System.Drawing.Size(200, 27);
            btnUpdatePersonalInformation.TabIndex = 17;
            btnUpdatePersonalInformation.Text = "Update personal information";
            btnUpdatePersonalInformation.UseVisualStyleBackColor = true;
            btnUpdatePersonalInformation.Click += btnUpdatePersonalInformation_Click;
            // 
            // cboExpertGender
            // 
            cboExpertGender.Enabled = false;
            cboExpertGender.FormattingEnabled = true;
            cboExpertGender.Items.AddRange(new object[] { "Male", "Female" });
            cboExpertGender.Location = new System.Drawing.Point(57, 106);
            cboExpertGender.Name = "cboExpertGender";
            cboExpertGender.Size = new System.Drawing.Size(96, 23);
            cboExpertGender.TabIndex = 13;
            // 
            // txtExpertID
            // 
            txtExpertID.Location = new System.Drawing.Point(57, 29);
            txtExpertID.Name = "txtExpertID";
            txtExpertID.ReadOnly = true;
            txtExpertID.Size = new System.Drawing.Size(96, 23);
            txtExpertID.TabIndex = 7;
            // 
            // txtExpertPhonenumber
            // 
            txtExpertPhonenumber.Location = new System.Drawing.Point(317, 68);
            txtExpertPhonenumber.Name = "txtExpertPhonenumber";
            txtExpertPhonenumber.ReadOnly = true;
            txtExpertPhonenumber.Size = new System.Drawing.Size(177, 23);
            txtExpertPhonenumber.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(218, 68);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(86, 15);
            label8.TabIndex = 6;
            label8.Text = "Phone number";
            // 
            // txtExpertEmail
            // 
            txtExpertEmail.Location = new System.Drawing.Point(317, 30);
            txtExpertEmail.Name = "txtExpertEmail";
            txtExpertEmail.ReadOnly = true;
            txtExpertEmail.Size = new System.Drawing.Size(177, 23);
            txtExpertEmail.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(7, 31);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(45, 15);
            label9.TabIndex = 0;
            label9.Text = "Staff ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(218, 31);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(36, 15);
            label10.TabIndex = 5;
            label10.Text = "Email";
            // 
            // txtExpertName
            // 
            txtExpertName.Location = new System.Drawing.Point(57, 65);
            txtExpertName.Name = "txtExpertName";
            txtExpertName.ReadOnly = true;
            txtExpertName.Size = new System.Drawing.Size(96, 23);
            txtExpertName.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(7, 68);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(39, 15);
            label11.TabIndex = 1;
            label11.Text = "Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(7, 107);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(45, 15);
            label12.TabIndex = 3;
            label12.Text = "Gender";
            // 
            // frmExpert
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(637, 405);
            Controls.Add(tabControl1);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "frmExpert";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Expert";
            Load += frmExpert_Load;
            tabControl1.ResumeLayout(false);
            tabViewLog.ResumeLayout(false);
            tabViewLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViewLog).EndInit();
            tabCreateMeal.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            tabFoodStorage.ResumeLayout(false);
            tabFoodStorage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViewFoodStorage).EndInit();
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabViewLog;
        private System.Windows.Forms.TabPage tabCreateMeal;
        private System.Windows.Forms.Label lbSpecies;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView dgvViewLog;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.TextBox txtShortDescription;
        private System.Windows.Forms.TextBox txtAnimalName;
        private System.Windows.Forms.Label lbShortDescription;
        private System.Windows.Forms.Label lbAnimalName;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbDatetime;
        private System.Windows.Forms.DateTimePicker dtpDatetime;
        private System.Windows.Forms.TabPage tabFoodStorage;
        private System.Windows.Forms.Label lbFoodStorage;
        private System.Windows.Forms.DataGridView dgvViewFoodStorage;
        private System.Windows.Forms.ComboBox cbFilterFood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFoodAvailable;
        private System.Windows.Forms.TextBox txtFoodType;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.Label lbFoodID;
        private System.Windows.Forms.DataGridView dgvAnimals;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAnimalGender;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtAnimalD;
        private System.Windows.Forms.Label lbAnimalID;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCreateMeal;
        private System.Windows.Forms.TextBox txtAnimalSpecies;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDEZ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAnimalStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdatePersonalInformation;
        private System.Windows.Forms.ComboBox cboExpertGender;
        private System.Windows.Forms.TextBox txtExpertID;
        private System.Windows.Forms.TextBox txtExpertPhonenumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtExpertEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtExpertName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtLogAnimalSpecies;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
    }
}