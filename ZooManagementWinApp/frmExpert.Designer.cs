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
            tabControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(730, 544);
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
            tabViewLog.Location = new System.Drawing.Point(4, 29);
            tabViewLog.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            tabViewLog.Name = "tabViewLog";
            tabViewLog.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            tabViewLog.Size = new System.Drawing.Size(722, 511);
            tabViewLog.TabIndex = 0;
            tabViewLog.Text = "View Log";
            tabViewLog.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new System.Drawing.Point(383, 222);
            btnNext.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnNext.Name = "btnNext";
            btnNext.Size = new System.Drawing.Size(89, 27);
            btnNext.TabIndex = 15;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new System.Drawing.Point(263, 222);
            btnPrevious.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new System.Drawing.Size(89, 27);
            btnPrevious.TabIndex = 14;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // txtLogAnimalSpecies
            // 
            txtLogAnimalSpecies.Location = new System.Drawing.Point(487, 174);
            txtLogAnimalSpecies.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtLogAnimalSpecies.Name = "txtLogAnimalSpecies";
            txtLogAnimalSpecies.Size = new System.Drawing.Size(109, 27);
            txtLogAnimalSpecies.TabIndex = 13;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(604, 175);
            btnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(75, 27);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dtpDatetime
            // 
            dtpDatetime.Enabled = false;
            dtpDatetime.Location = new System.Drawing.Point(442, 117);
            dtpDatetime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            dtpDatetime.Name = "dtpDatetime";
            dtpDatetime.Size = new System.Drawing.Size(237, 27);
            dtpDatetime.TabIndex = 11;
            // 
            // lbDatetime
            // 
            lbDatetime.AutoSize = true;
            lbDatetime.Location = new System.Drawing.Point(326, 121);
            lbDatetime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbDatetime.Name = "lbDatetime";
            lbDatetime.Size = new System.Drawing.Size(71, 20);
            lbDatetime.TabIndex = 10;
            lbDatetime.Text = "Datetime";
            // 
            // txtShortDescription
            // 
            txtShortDescription.Location = new System.Drawing.Point(163, 175);
            txtShortDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtShortDescription.Name = "txtShortDescription";
            txtShortDescription.ReadOnly = true;
            txtShortDescription.Size = new System.Drawing.Size(238, 27);
            txtShortDescription.TabIndex = 9;
            // 
            // txtAnimalName
            // 
            txtAnimalName.Location = new System.Drawing.Point(442, 64);
            txtAnimalName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtAnimalName.Name = "txtAnimalName";
            txtAnimalName.ReadOnly = true;
            txtAnimalName.Size = new System.Drawing.Size(121, 27);
            txtAnimalName.TabIndex = 8;
            // 
            // lbShortDescription
            // 
            lbShortDescription.AutoSize = true;
            lbShortDescription.Location = new System.Drawing.Point(21, 177);
            lbShortDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbShortDescription.Name = "lbShortDescription";
            lbShortDescription.Size = new System.Drawing.Size(124, 20);
            lbShortDescription.TabIndex = 7;
            lbShortDescription.Text = "Short Description";
            // 
            // lbAnimalName
            // 
            lbAnimalName.AutoSize = true;
            lbAnimalName.Location = new System.Drawing.Point(326, 67);
            lbAnimalName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbAnimalName.Name = "lbAnimalName";
            lbAnimalName.Size = new System.Drawing.Size(100, 20);
            lbAnimalName.TabIndex = 6;
            lbAnimalName.Text = "Animal Name";
            // 
            // txtType
            // 
            txtType.Location = new System.Drawing.Point(163, 116);
            txtType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtType.Name = "txtType";
            txtType.ReadOnly = true;
            txtType.Size = new System.Drawing.Size(121, 27);
            txtType.TabIndex = 5;
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Location = new System.Drawing.Point(21, 121);
            lbType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbType.Name = "lbType";
            lbType.Size = new System.Drawing.Size(40, 20);
            lbType.TabIndex = 4;
            lbType.Text = "Type";
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new System.Drawing.Point(163, 64);
            txtSpecies.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.ReadOnly = true;
            txtSpecies.Size = new System.Drawing.Size(121, 27);
            txtSpecies.TabIndex = 3;
            // 
            // lbSpecies
            // 
            lbSpecies.AutoSize = true;
            lbSpecies.Location = new System.Drawing.Point(21, 67);
            lbSpecies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbSpecies.Name = "lbSpecies";
            lbSpecies.Size = new System.Drawing.Size(59, 20);
            lbSpecies.TabIndex = 2;
            lbSpecies.Text = "Species";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new System.Drawing.Point(277, 12);
            lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(121, 20);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "View Log Animal";
            // 
            // dgvViewLog
            // 
            dgvViewLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvViewLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewLog.Location = new System.Drawing.Point(0, 255);
            dgvViewLog.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            dgvViewLog.Name = "dgvViewLog";
            dgvViewLog.ReadOnly = true;
            dgvViewLog.RowHeadersWidth = 62;
            dgvViewLog.RowTemplate.Height = 33;
            dgvViewLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvViewLog.Size = new System.Drawing.Size(721, 257);
            dgvViewLog.TabIndex = 0;
            // 
            // tabCreateMeal
            // 
            tabCreateMeal.Controls.Add(groupBox1);
            tabCreateMeal.Controls.Add(btnCreateMeal);
            tabCreateMeal.Controls.Add(dgvAnimals);
            tabCreateMeal.Location = new System.Drawing.Point(4, 29);
            tabCreateMeal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            tabCreateMeal.Name = "tabCreateMeal";
            tabCreateMeal.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            tabCreateMeal.Size = new System.Drawing.Size(722, 511);
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
            groupBox1.Location = new System.Drawing.Point(15, 25);
            groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            groupBox1.Size = new System.Drawing.Size(699, 253);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Food and Medicine";
            // 
            // dtpDEZ
            // 
            dtpDEZ.Enabled = false;
            dtpDEZ.Location = new System.Drawing.Point(440, 117);
            dtpDEZ.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            dtpDEZ.Name = "dtpDEZ";
            dtpDEZ.Size = new System.Drawing.Size(241, 27);
            dtpDEZ.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(321, 121);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(108, 20);
            label7.TabIndex = 12;
            label7.Text = "Date enter zoo";
            // 
            // dtpDOB
            // 
            dtpDOB.Enabled = false;
            dtpDOB.Location = new System.Drawing.Point(440, 52);
            dtpDOB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new System.Drawing.Size(241, 27);
            dtpDOB.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(321, 56);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(94, 20);
            label6.TabIndex = 10;
            label6.Text = "Date of birth";
            // 
            // txtAnimalStatus
            // 
            txtAnimalStatus.Location = new System.Drawing.Point(440, 177);
            txtAnimalStatus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtAnimalStatus.Name = "txtAnimalStatus";
            txtAnimalStatus.ReadOnly = true;
            txtAnimalStatus.Size = new System.Drawing.Size(121, 27);
            txtAnimalStatus.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(321, 179);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(49, 20);
            label5.TabIndex = 8;
            label5.Text = "Status";
            // 
            // txtAnimalSpecies
            // 
            txtAnimalSpecies.Location = new System.Drawing.Point(119, 201);
            txtAnimalSpecies.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtAnimalSpecies.Name = "txtAnimalSpecies";
            txtAnimalSpecies.ReadOnly = true;
            txtAnimalSpecies.Size = new System.Drawing.Size(121, 27);
            txtAnimalSpecies.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(18, 205);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(59, 20);
            label4.TabIndex = 6;
            label4.Text = "Species";
            // 
            // txtAnimalGender
            // 
            txtAnimalGender.Location = new System.Drawing.Point(119, 145);
            txtAnimalGender.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtAnimalGender.Name = "txtAnimalGender";
            txtAnimalGender.ReadOnly = true;
            txtAnimalGender.Size = new System.Drawing.Size(121, 27);
            txtAnimalGender.TabIndex = 5;
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new System.Drawing.Point(18, 151);
            lbQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new System.Drawing.Size(57, 20);
            lbQuantity.TabIndex = 4;
            lbQuantity.Text = "Gender";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(119, 93);
            txtName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new System.Drawing.Size(121, 27);
            txtName.TabIndex = 3;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new System.Drawing.Point(18, 99);
            lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbName.Name = "lbName";
            lbName.Size = new System.Drawing.Size(100, 20);
            lbName.TabIndex = 2;
            lbName.Text = "Animal Name";
            // 
            // txtAnimalD
            // 
            txtAnimalD.Location = new System.Drawing.Point(119, 49);
            txtAnimalD.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtAnimalD.Name = "txtAnimalD";
            txtAnimalD.ReadOnly = true;
            txtAnimalD.Size = new System.Drawing.Size(121, 27);
            txtAnimalD.TabIndex = 1;
            // 
            // lbAnimalID
            // 
            lbAnimalID.AutoSize = true;
            lbAnimalID.Location = new System.Drawing.Point(18, 49);
            lbAnimalID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbAnimalID.Name = "lbAnimalID";
            lbAnimalID.Size = new System.Drawing.Size(75, 20);
            lbAnimalID.TabIndex = 0;
            lbAnimalID.Text = "Animal ID";
            // 
            // btnCreateMeal
            // 
            btnCreateMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCreateMeal.Location = new System.Drawing.Point(608, 288);
            btnCreateMeal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnCreateMeal.Name = "btnCreateMeal";
            btnCreateMeal.Size = new System.Drawing.Size(112, 33);
            btnCreateMeal.TabIndex = 5;
            btnCreateMeal.Text = "Create Meal";
            btnCreateMeal.UseVisualStyleBackColor = true;
            btnCreateMeal.Click += btnCreateMeal_Click;
            // 
            // dgvAnimals
            // 
            dgvAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new System.Drawing.Point(-5, 323);
            dgvAnimals.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.RowHeadersWidth = 62;
            dgvAnimals.RowTemplate.Height = 33;
            dgvAnimals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.Size = new System.Drawing.Size(727, 191);
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
            tabFoodStorage.Location = new System.Drawing.Point(4, 29);
            tabFoodStorage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            tabFoodStorage.Name = "tabFoodStorage";
            tabFoodStorage.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            tabFoodStorage.Size = new System.Drawing.Size(722, 511);
            tabFoodStorage.TabIndex = 2;
            tabFoodStorage.Text = "Food Storage";
            tabFoodStorage.UseVisualStyleBackColor = true;
            // 
            // txtFoodID
            // 
            txtFoodID.Location = new System.Drawing.Point(163, 100);
            txtFoodID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtFoodID.Name = "txtFoodID";
            txtFoodID.ReadOnly = true;
            txtFoodID.Size = new System.Drawing.Size(121, 27);
            txtFoodID.TabIndex = 12;
            // 
            // lbFoodID
            // 
            lbFoodID.AutoSize = true;
            lbFoodID.Location = new System.Drawing.Point(69, 105);
            lbFoodID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbFoodID.Name = "lbFoodID";
            lbFoodID.Size = new System.Drawing.Size(28, 20);
            lbFoodID.TabIndex = 11;
            lbFoodID.Text = " ID";
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(143, 231);
            btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(89, 27);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(33, 231);
            btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(89, 27);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtFoodAvailable
            // 
            txtFoodAvailable.Location = new System.Drawing.Point(534, 97);
            txtFoodAvailable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtFoodAvailable.Name = "txtFoodAvailable";
            txtFoodAvailable.ReadOnly = true;
            txtFoodAvailable.Size = new System.Drawing.Size(121, 27);
            txtFoodAvailable.TabIndex = 8;
            // 
            // txtFoodType
            // 
            txtFoodType.Location = new System.Drawing.Point(534, 151);
            txtFoodType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtFoodType.Name = "txtFoodType";
            txtFoodType.ReadOnly = true;
            txtFoodType.Size = new System.Drawing.Size(121, 27);
            txtFoodType.TabIndex = 7;
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new System.Drawing.Point(163, 151);
            txtFoodName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.ReadOnly = true;
            txtFoodName.Size = new System.Drawing.Size(121, 27);
            txtFoodName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(400, 100);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(71, 20);
            label3.TabIndex = 5;
            label3.Text = "Available";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(400, 153);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(40, 20);
            label2.TabIndex = 4;
            label2.Text = "Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(69, 156);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 20);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // cbFilterFood
            // 
            cbFilterFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbFilterFood.FormattingEnabled = true;
            cbFilterFood.Items.AddRange(new object[] { "meat", "plant", "medicine" });
            cbFilterFood.Location = new System.Drawing.Point(523, 232);
            cbFilterFood.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cbFilterFood.Name = "cbFilterFood";
            cbFilterFood.Size = new System.Drawing.Size(193, 28);
            cbFilterFood.TabIndex = 2;
            cbFilterFood.SelectedIndexChanged += cbFilterFood_SelectedIndexChanged;
            // 
            // dgvViewFoodStorage
            // 
            dgvViewFoodStorage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvViewFoodStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewFoodStorage.Location = new System.Drawing.Point(0, 263);
            dgvViewFoodStorage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            dgvViewFoodStorage.Name = "dgvViewFoodStorage";
            dgvViewFoodStorage.ReadOnly = true;
            dgvViewFoodStorage.RowHeadersWidth = 62;
            dgvViewFoodStorage.RowTemplate.Height = 33;
            dgvViewFoodStorage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvViewFoodStorage.Size = new System.Drawing.Size(725, 248);
            dgvViewFoodStorage.TabIndex = 1;
            dgvViewFoodStorage.CellDoubleClick += dgvViewFoodStorage_CellDoubleClick;
            // 
            // lbFoodStorage
            // 
            lbFoodStorage.AutoSize = true;
            lbFoodStorage.Location = new System.Drawing.Point(261, 32);
            lbFoodStorage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbFoodStorage.Name = "lbFoodStorage";
            lbFoodStorage.Size = new System.Drawing.Size(193, 20);
            lbFoodStorage.TabIndex = 0;
            lbFoodStorage.Text = "Food and Medicine Storage";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnLogout);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Location = new System.Drawing.Point(4, 29);
            tabPage1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            tabPage1.Size = new System.Drawing.Size(722, 511);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Information";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new System.Drawing.Point(553, 413);
            btnLogout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(89, 27);
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
            groupBox2.Location = new System.Drawing.Point(59, 83);
            groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Size = new System.Drawing.Size(591, 253);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Expert information";
            // 
            // btnUpdatePersonalInformation
            // 
            btnUpdatePersonalInformation.Location = new System.Drawing.Point(209, 191);
            btnUpdatePersonalInformation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnUpdatePersonalInformation.Name = "btnUpdatePersonalInformation";
            btnUpdatePersonalInformation.Size = new System.Drawing.Size(229, 36);
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
            cboExpertGender.Location = new System.Drawing.Point(65, 141);
            cboExpertGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cboExpertGender.Name = "cboExpertGender";
            cboExpertGender.Size = new System.Drawing.Size(109, 28);
            cboExpertGender.TabIndex = 13;
            // 
            // txtExpertID
            // 
            txtExpertID.Location = new System.Drawing.Point(65, 39);
            txtExpertID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtExpertID.Name = "txtExpertID";
            txtExpertID.ReadOnly = true;
            txtExpertID.Size = new System.Drawing.Size(109, 27);
            txtExpertID.TabIndex = 7;
            // 
            // txtExpertPhonenumber
            // 
            txtExpertPhonenumber.Location = new System.Drawing.Point(362, 91);
            txtExpertPhonenumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtExpertPhonenumber.Name = "txtExpertPhonenumber";
            txtExpertPhonenumber.ReadOnly = true;
            txtExpertPhonenumber.Size = new System.Drawing.Size(202, 27);
            txtExpertPhonenumber.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(249, 91);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(105, 20);
            label8.TabIndex = 6;
            label8.Text = "Phone number";
            // 
            // txtExpertEmail
            // 
            txtExpertEmail.Location = new System.Drawing.Point(362, 40);
            txtExpertEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtExpertEmail.Name = "txtExpertEmail";
            txtExpertEmail.ReadOnly = true;
            txtExpertEmail.Size = new System.Drawing.Size(202, 27);
            txtExpertEmail.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(8, 41);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(59, 20);
            label9.TabIndex = 0;
            label9.Text = "Staff ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(249, 41);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(46, 20);
            label10.TabIndex = 5;
            label10.Text = "Email";
            // 
            // txtExpertName
            // 
            txtExpertName.Location = new System.Drawing.Point(65, 87);
            txtExpertName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtExpertName.Name = "txtExpertName";
            txtExpertName.ReadOnly = true;
            txtExpertName.Size = new System.Drawing.Size(109, 27);
            txtExpertName.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(8, 91);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(49, 20);
            label11.TabIndex = 1;
            label11.Text = "Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(8, 143);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(57, 20);
            label12.TabIndex = 3;
            label12.Text = "Gender";
            // 
            // frmExpert
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(728, 540);
            Controls.Add(tabControl1);
            Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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