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
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(913, 680);
            tabControl1.TabIndex = 0;
            // 
            // tabViewLog
            // 
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
            tabViewLog.Location = new System.Drawing.Point(4, 34);
            tabViewLog.Name = "tabViewLog";
            tabViewLog.Padding = new System.Windows.Forms.Padding(3);
            tabViewLog.Size = new System.Drawing.Size(905, 642);
            tabViewLog.TabIndex = 0;
            tabViewLog.Text = "View Log";
            tabViewLog.UseVisualStyleBackColor = true;
            // 
            // dtpDatetime
            // 
            dtpDatetime.Enabled = false;
            dtpDatetime.Location = new System.Drawing.Point(553, 146);
            dtpDatetime.Name = "dtpDatetime";
            dtpDatetime.Size = new System.Drawing.Size(296, 31);
            dtpDatetime.TabIndex = 11;
            // 
            // lbDatetime
            // 
            lbDatetime.AutoSize = true;
            lbDatetime.Location = new System.Drawing.Point(407, 151);
            lbDatetime.Name = "lbDatetime";
            lbDatetime.Size = new System.Drawing.Size(84, 25);
            lbDatetime.TabIndex = 10;
            lbDatetime.Text = "Datetime";
            // 
            // txtShortDescription
            // 
            txtShortDescription.Location = new System.Drawing.Point(204, 218);
            txtShortDescription.Name = "txtShortDescription";
            txtShortDescription.ReadOnly = true;
            txtShortDescription.Size = new System.Drawing.Size(358, 31);
            txtShortDescription.TabIndex = 9;
            // 
            // txtAnimalName
            // 
            txtAnimalName.Location = new System.Drawing.Point(553, 80);
            txtAnimalName.Name = "txtAnimalName";
            txtAnimalName.ReadOnly = true;
            txtAnimalName.Size = new System.Drawing.Size(150, 31);
            txtAnimalName.TabIndex = 8;
            // 
            // lbShortDescription
            // 
            lbShortDescription.AutoSize = true;
            lbShortDescription.Location = new System.Drawing.Point(26, 221);
            lbShortDescription.Name = "lbShortDescription";
            lbShortDescription.Size = new System.Drawing.Size(150, 25);
            lbShortDescription.TabIndex = 7;
            lbShortDescription.Text = "Short Description";
            // 
            // lbAnimalName
            // 
            lbAnimalName.AutoSize = true;
            lbAnimalName.Location = new System.Drawing.Point(407, 83);
            lbAnimalName.Name = "lbAnimalName";
            lbAnimalName.Size = new System.Drawing.Size(119, 25);
            lbAnimalName.TabIndex = 6;
            lbAnimalName.Text = "Animal Name";
            // 
            // txtType
            // 
            txtType.Location = new System.Drawing.Point(204, 145);
            txtType.Name = "txtType";
            txtType.ReadOnly = true;
            txtType.Size = new System.Drawing.Size(150, 31);
            txtType.TabIndex = 5;
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Location = new System.Drawing.Point(26, 151);
            lbType.Name = "lbType";
            lbType.Size = new System.Drawing.Size(49, 25);
            lbType.TabIndex = 4;
            lbType.Text = "Type";
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new System.Drawing.Point(204, 80);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.ReadOnly = true;
            txtSpecies.Size = new System.Drawing.Size(150, 31);
            txtSpecies.TabIndex = 3;
            // 
            // lbSpecies
            // 
            lbSpecies.AutoSize = true;
            lbSpecies.Location = new System.Drawing.Point(26, 83);
            lbSpecies.Name = "lbSpecies";
            lbSpecies.Size = new System.Drawing.Size(71, 25);
            lbSpecies.TabIndex = 2;
            lbSpecies.Text = "Species";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new System.Drawing.Point(346, 15);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(144, 25);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "View Log Animal";
            // 
            // dgvViewLog
            // 
            dgvViewLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvViewLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewLog.Location = new System.Drawing.Point(0, 266);
            dgvViewLog.Name = "dgvViewLog";
            dgvViewLog.ReadOnly = true;
            dgvViewLog.RowHeadersWidth = 62;
            dgvViewLog.RowTemplate.Height = 33;
            dgvViewLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvViewLog.Size = new System.Drawing.Size(902, 380);
            dgvViewLog.TabIndex = 0;
            // 
            // tabCreateMeal
            // 
            tabCreateMeal.Controls.Add(groupBox1);
            tabCreateMeal.Controls.Add(btnCreateMeal);
            tabCreateMeal.Controls.Add(dgvAnimals);
            tabCreateMeal.Location = new System.Drawing.Point(4, 34);
            tabCreateMeal.Name = "tabCreateMeal";
            tabCreateMeal.Padding = new System.Windows.Forms.Padding(3);
            tabCreateMeal.Size = new System.Drawing.Size(905, 642);
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
            groupBox1.Location = new System.Drawing.Point(19, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(875, 317);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Food and Medicine";
            // 
            // dtpDEZ
            // 
            dtpDEZ.Enabled = false;
            dtpDEZ.Location = new System.Drawing.Point(550, 146);
            dtpDEZ.Name = "dtpDEZ";
            dtpDEZ.Size = new System.Drawing.Size(300, 31);
            dtpDEZ.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(401, 151);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(129, 25);
            label7.TabIndex = 12;
            label7.Text = "Date enter zoo";
            // 
            // dtpDOB
            // 
            dtpDOB.Enabled = false;
            dtpDOB.Location = new System.Drawing.Point(550, 65);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new System.Drawing.Size(300, 31);
            dtpDOB.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(401, 70);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(113, 25);
            label6.TabIndex = 10;
            label6.Text = "Date of birth";
            // 
            // txtAnimalStatus
            // 
            txtAnimalStatus.Location = new System.Drawing.Point(550, 221);
            txtAnimalStatus.Name = "txtAnimalStatus";
            txtAnimalStatus.ReadOnly = true;
            txtAnimalStatus.Size = new System.Drawing.Size(150, 31);
            txtAnimalStatus.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(401, 224);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 25);
            label5.TabIndex = 8;
            label5.Text = "Status";
            // 
            // txtAnimalSpecies
            // 
            txtAnimalSpecies.Location = new System.Drawing.Point(148, 251);
            txtAnimalSpecies.Name = "txtAnimalSpecies";
            txtAnimalSpecies.ReadOnly = true;
            txtAnimalSpecies.Size = new System.Drawing.Size(150, 31);
            txtAnimalSpecies.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(23, 257);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(71, 25);
            label4.TabIndex = 6;
            label4.Text = "Species";
            // 
            // txtAnimalGender
            // 
            txtAnimalGender.Location = new System.Drawing.Point(148, 182);
            txtAnimalGender.Name = "txtAnimalGender";
            txtAnimalGender.ReadOnly = true;
            txtAnimalGender.Size = new System.Drawing.Size(150, 31);
            txtAnimalGender.TabIndex = 5;
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new System.Drawing.Point(23, 188);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new System.Drawing.Size(69, 25);
            lbQuantity.TabIndex = 4;
            lbQuantity.Text = "Gender";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(148, 117);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new System.Drawing.Size(150, 31);
            txtName.TabIndex = 3;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new System.Drawing.Point(23, 123);
            lbName.Name = "lbName";
            lbName.Size = new System.Drawing.Size(119, 25);
            lbName.TabIndex = 2;
            lbName.Text = "Animal Name";
            // 
            // txtAnimalD
            // 
            txtAnimalD.Location = new System.Drawing.Point(148, 62);
            txtAnimalD.Name = "txtAnimalD";
            txtAnimalD.ReadOnly = true;
            txtAnimalD.Size = new System.Drawing.Size(150, 31);
            txtAnimalD.TabIndex = 1;
            // 
            // lbAnimalID
            // 
            lbAnimalID.AutoSize = true;
            lbAnimalID.Location = new System.Drawing.Point(23, 62);
            lbAnimalID.Name = "lbAnimalID";
            lbAnimalID.Size = new System.Drawing.Size(90, 25);
            lbAnimalID.TabIndex = 0;
            lbAnimalID.Text = "Animal ID";
            // 
            // btnCreateMeal
            // 
            btnCreateMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCreateMeal.Location = new System.Drawing.Point(754, 364);
            btnCreateMeal.Name = "btnCreateMeal";
            btnCreateMeal.Size = new System.Drawing.Size(140, 34);
            btnCreateMeal.TabIndex = 5;
            btnCreateMeal.Text = "Create Meal";
            btnCreateMeal.UseVisualStyleBackColor = true;
            btnCreateMeal.Click += btnCreateMeal_Click;
            // 
            // dgvAnimals
            // 
            dgvAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new System.Drawing.Point(-4, 404);
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.RowHeadersWidth = 62;
            dgvAnimals.RowTemplate.Height = 33;
            dgvAnimals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.Size = new System.Drawing.Size(909, 238);
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
            tabFoodStorage.Location = new System.Drawing.Point(4, 34);
            tabFoodStorage.Name = "tabFoodStorage";
            tabFoodStorage.Padding = new System.Windows.Forms.Padding(3);
            tabFoodStorage.Size = new System.Drawing.Size(905, 642);
            tabFoodStorage.TabIndex = 2;
            tabFoodStorage.Text = "Food Storage";
            tabFoodStorage.UseVisualStyleBackColor = true;
            // 
            // txtFoodID
            // 
            txtFoodID.Location = new System.Drawing.Point(204, 125);
            txtFoodID.Name = "txtFoodID";
            txtFoodID.Size = new System.Drawing.Size(150, 31);
            txtFoodID.TabIndex = 12;
            // 
            // lbFoodID
            // 
            lbFoodID.AutoSize = true;
            lbFoodID.Location = new System.Drawing.Point(85, 131);
            lbFoodID.Name = "lbFoodID";
            lbFoodID.Size = new System.Drawing.Size(35, 25);
            lbFoodID.TabIndex = 11;
            lbFoodID.Text = " ID";
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(178, 288);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(112, 34);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(42, 288);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(112, 34);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtFoodAvailable
            // 
            txtFoodAvailable.Location = new System.Drawing.Point(667, 122);
            txtFoodAvailable.Name = "txtFoodAvailable";
            txtFoodAvailable.ReadOnly = true;
            txtFoodAvailable.Size = new System.Drawing.Size(150, 31);
            txtFoodAvailable.TabIndex = 8;
            // 
            // txtFoodType
            // 
            txtFoodType.Location = new System.Drawing.Point(667, 188);
            txtFoodType.Name = "txtFoodType";
            txtFoodType.ReadOnly = true;
            txtFoodType.Size = new System.Drawing.Size(150, 31);
            txtFoodType.TabIndex = 7;
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new System.Drawing.Point(204, 189);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.ReadOnly = true;
            txtFoodName.Size = new System.Drawing.Size(150, 31);
            txtFoodName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(500, 125);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(83, 25);
            label3.TabIndex = 5;
            label3.Text = "Available";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(500, 191);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 25);
            label2.TabIndex = 4;
            label2.Text = "Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(85, 195);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 25);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // cbFilterFood
            // 
            cbFilterFood.FormattingEnabled = true;
            cbFilterFood.Items.AddRange(new object[] { "meat", "plant", "medicine" });
            cbFilterFood.Location = new System.Drawing.Point(654, 290);
            cbFilterFood.Name = "cbFilterFood";
            cbFilterFood.Size = new System.Drawing.Size(240, 33);
            cbFilterFood.TabIndex = 2;
            cbFilterFood.Text = "--Choose type of food--";
            cbFilterFood.SelectedIndexChanged += cbFilterFood_SelectedIndexChanged;
            // 
            // dgvViewFoodStorage
            // 
            dgvViewFoodStorage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvViewFoodStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewFoodStorage.Location = new System.Drawing.Point(0, 329);
            dgvViewFoodStorage.Name = "dgvViewFoodStorage";
            dgvViewFoodStorage.ReadOnly = true;
            dgvViewFoodStorage.RowHeadersWidth = 62;
            dgvViewFoodStorage.RowTemplate.Height = 33;
            dgvViewFoodStorage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvViewFoodStorage.Size = new System.Drawing.Size(905, 310);
            dgvViewFoodStorage.TabIndex = 1;
            dgvViewFoodStorage.CellDoubleClick += dgvViewFoodStorage_CellDoubleClick;
            // 
            // lbFoodStorage
            // 
            lbFoodStorage.AutoSize = true;
            lbFoodStorage.Location = new System.Drawing.Point(325, 40);
            lbFoodStorage.Name = "lbFoodStorage";
            lbFoodStorage.Size = new System.Drawing.Size(231, 25);
            lbFoodStorage.TabIndex = 0;
            lbFoodStorage.Text = "Food and Medicine Storage";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnLogout);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Location = new System.Drawing.Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(905, 642);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Information";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new System.Drawing.Point(692, 516);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(112, 34);
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
            groupBox2.Location = new System.Drawing.Point(74, 104);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox2.Size = new System.Drawing.Size(739, 316);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Expert information";
            // 
            // btnUpdatePersonalInformation
            // 
            btnUpdatePersonalInformation.Location = new System.Drawing.Point(261, 238);
            btnUpdatePersonalInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnUpdatePersonalInformation.Name = "btnUpdatePersonalInformation";
            btnUpdatePersonalInformation.Size = new System.Drawing.Size(286, 45);
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
            cboExpertGender.Location = new System.Drawing.Point(81, 176);
            cboExpertGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cboExpertGender.Name = "cboExpertGender";
            cboExpertGender.Size = new System.Drawing.Size(135, 33);
            cboExpertGender.TabIndex = 13;
            // 
            // txtExpertID
            // 
            txtExpertID.Location = new System.Drawing.Point(81, 49);
            txtExpertID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtExpertID.Name = "txtExpertID";
            txtExpertID.ReadOnly = true;
            txtExpertID.Size = new System.Drawing.Size(135, 31);
            txtExpertID.TabIndex = 7;
            // 
            // txtExpertPhonenumber
            // 
            txtExpertPhonenumber.Location = new System.Drawing.Point(453, 114);
            txtExpertPhonenumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtExpertPhonenumber.Name = "txtExpertPhonenumber";
            txtExpertPhonenumber.ReadOnly = true;
            txtExpertPhonenumber.Size = new System.Drawing.Size(251, 31);
            txtExpertPhonenumber.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(311, 114);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(129, 25);
            label8.TabIndex = 6;
            label8.Text = "Phone number";
            // 
            // txtExpertEmail
            // 
            txtExpertEmail.Location = new System.Drawing.Point(453, 50);
            txtExpertEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtExpertEmail.Name = "txtExpertEmail";
            txtExpertEmail.ReadOnly = true;
            txtExpertEmail.Size = new System.Drawing.Size(251, 31);
            txtExpertEmail.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(10, 52);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(71, 25);
            label9.TabIndex = 0;
            label9.Text = "Staff ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(311, 52);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(54, 25);
            label10.TabIndex = 5;
            label10.Text = "Email";
            // 
            // txtExpertName
            // 
            txtExpertName.Location = new System.Drawing.Point(81, 108);
            txtExpertName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtExpertName.Name = "txtExpertName";
            txtExpertName.ReadOnly = true;
            txtExpertName.Size = new System.Drawing.Size(135, 31);
            txtExpertName.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(10, 114);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(59, 25);
            label11.TabIndex = 1;
            label11.Text = "Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(10, 179);
            label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(69, 25);
            label12.TabIndex = 3;
            label12.Text = "Gender";
            // 
            // frmExpert
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(910, 675);
            Controls.Add(tabControl1);
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
    }
}