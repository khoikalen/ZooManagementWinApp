namespace ZooManagementWinApp
{
    partial class frmAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new System.Windows.Forms.TabControl();
            tabStaffMangement = new System.Windows.Forms.TabPage();
            btnDeleteStaff = new System.Windows.Forms.Button();
            btnAddStaff = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            txtStaffPhoneNumber = new System.Windows.Forms.TextBox();
            dtpStatDay = new System.Windows.Forms.DateTimePicker();
            txtStaffEmail = new System.Windows.Forms.TextBox();
            txtGender = new System.Windows.Forms.TextBox();
            txtStaffLastName = new System.Windows.Forms.TextBox();
            txtStaffFirstName = new System.Windows.Forms.TextBox();
            txtStaffID = new System.Windows.Forms.TextBox();
            lbPhoneNumber = new System.Windows.Forms.Label();
            lbEmail = new System.Windows.Forms.Label();
            lbStartDay = new System.Windows.Forms.Label();
            lbGender = new System.Windows.Forms.Label();
            lbStaffLastName = new System.Windows.Forms.Label();
            lbStaffFirstName = new System.Windows.Forms.Label();
            lbStaffID = new System.Windows.Forms.Label();
            dgvStaff = new System.Windows.Forms.DataGridView();
            tabExpertManagement = new System.Windows.Forms.TabPage();
            btnDeleteExpert = new System.Windows.Forms.Button();
            btnAddExpert = new System.Windows.Forms.Button();
            dgvExpertManagement = new System.Windows.Forms.DataGridView();
            groupBox3 = new System.Windows.Forms.GroupBox();
            txtExpertAreaID = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            txtExpertPhoneNumber = new System.Windows.Forms.TextBox();
            dtpExpertStartDay = new System.Windows.Forms.DateTimePicker();
            txtExpertEmail = new System.Windows.Forms.TextBox();
            txtGenderExpert = new System.Windows.Forms.TextBox();
            txtExpertLastName = new System.Windows.Forms.TextBox();
            txtExpertFirstName = new System.Windows.Forms.TextBox();
            txtExpertID = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            tabCageManagement = new System.Windows.Forms.TabPage();
            btnDeleteCage = new System.Windows.Forms.Button();
            btnAddCage = new System.Windows.Forms.Button();
            dgvCageManagement = new System.Windows.Forms.DataGridView();
            groupBox2 = new System.Windows.Forms.GroupBox();
            txtStaffForeignID = new System.Windows.Forms.TextBox();
            txtAreaForeignID = new System.Windows.Forms.TextBox();
            txtCageStatus = new System.Windows.Forms.TextBox();
            txtCageQuantity = new System.Windows.Forms.TextBox();
            txtCageName = new System.Windows.Forms.TextBox();
            txtCagePrimaryID = new System.Windows.Forms.TextBox();
            lbStaffForeignID = new System.Windows.Forms.Label();
            lbAreaForeignID = new System.Windows.Forms.Label();
            lbCageStatus = new System.Windows.Forms.Label();
            lbCageQuantity = new System.Windows.Forms.Label();
            lbCageName = new System.Windows.Forms.Label();
            lbCageId = new System.Windows.Forms.Label();
            tabControl1.SuspendLayout();
            tabStaffMangement.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
            tabExpertManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpertManagement).BeginInit();
            groupBox3.SuspendLayout();
            tabCageManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCageManagement).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabStaffMangement);
            tabControl1.Controls.Add(tabExpertManagement);
            tabControl1.Controls.Add(tabCageManagement);
            tabControl1.Location = new System.Drawing.Point(0, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1029, 561);
            tabControl1.TabIndex = 0;
            // 
            // tabStaffMangement
            // 
            tabStaffMangement.Controls.Add(btnDeleteStaff);
            tabStaffMangement.Controls.Add(btnAddStaff);
            tabStaffMangement.Controls.Add(groupBox1);
            tabStaffMangement.Controls.Add(dgvStaff);
            tabStaffMangement.Location = new System.Drawing.Point(4, 29);
            tabStaffMangement.Name = "tabStaffMangement";
            tabStaffMangement.Padding = new System.Windows.Forms.Padding(3);
            tabStaffMangement.Size = new System.Drawing.Size(1021, 528);
            tabStaffMangement.TabIndex = 0;
            tabStaffMangement.Text = "Staff Management";
            tabStaffMangement.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStaff
            // 
            btnDeleteStaff.Location = new System.Drawing.Point(225, 266);
            btnDeleteStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDeleteStaff.Name = "btnDeleteStaff";
            btnDeleteStaff.Size = new System.Drawing.Size(94, 29);
            btnDeleteStaff.TabIndex = 3;
            btnDeleteStaff.Text = "Delete";
            btnDeleteStaff.UseVisualStyleBackColor = true;
            btnDeleteStaff.Click += btnDeleteStaff_Click;
            // 
            // btnAddStaff
            // 
            btnAddStaff.Location = new System.Drawing.Point(81, 266);
            btnAddStaff.Name = "btnAddStaff";
            btnAddStaff.Size = new System.Drawing.Size(94, 29);
            btnAddStaff.TabIndex = 2;
            btnAddStaff.Text = "Add";
            btnAddStaff.UseVisualStyleBackColor = true;
            btnAddStaff.Click += btnAddStaff_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtStaffPhoneNumber);
            groupBox1.Controls.Add(dtpStatDay);
            groupBox1.Controls.Add(txtStaffEmail);
            groupBox1.Controls.Add(txtGender);
            groupBox1.Controls.Add(txtStaffLastName);
            groupBox1.Controls.Add(txtStaffFirstName);
            groupBox1.Controls.Add(txtStaffID);
            groupBox1.Controls.Add(lbPhoneNumber);
            groupBox1.Controls.Add(lbEmail);
            groupBox1.Controls.Add(lbStartDay);
            groupBox1.Controls.Add(lbGender);
            groupBox1.Controls.Add(lbStaffLastName);
            groupBox1.Controls.Add(lbStaffFirstName);
            groupBox1.Controls.Add(lbStaffID);
            groupBox1.Location = new System.Drawing.Point(46, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(907, 201);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Staff Information";
            // 
            // txtStaffPhoneNumber
            // 
            txtStaffPhoneNumber.Location = new System.Drawing.Point(688, 45);
            txtStaffPhoneNumber.Name = "txtStaffPhoneNumber";
            txtStaffPhoneNumber.ReadOnly = true;
            txtStaffPhoneNumber.Size = new System.Drawing.Size(125, 27);
            txtStaffPhoneNumber.TabIndex = 13;
            // 
            // dtpStatDay
            // 
            dtpStatDay.Enabled = false;
            dtpStatDay.Location = new System.Drawing.Point(362, 142);
            dtpStatDay.Name = "dtpStatDay";
            dtpStatDay.Size = new System.Drawing.Size(250, 27);
            dtpStatDay.TabIndex = 12;
            // 
            // txtStaffEmail
            // 
            txtStaffEmail.Location = new System.Drawing.Point(688, 96);
            txtStaffEmail.Name = "txtStaffEmail";
            txtStaffEmail.ReadOnly = true;
            txtStaffEmail.Size = new System.Drawing.Size(125, 27);
            txtStaffEmail.TabIndex = 11;
            // 
            // txtGender
            // 
            txtGender.Location = new System.Drawing.Point(373, 51);
            txtGender.Name = "txtGender";
            txtGender.ReadOnly = true;
            txtGender.Size = new System.Drawing.Size(125, 27);
            txtGender.TabIndex = 10;
            // 
            // txtStaffLastName
            // 
            txtStaffLastName.Location = new System.Drawing.Point(373, 96);
            txtStaffLastName.Name = "txtStaffLastName";
            txtStaffLastName.ReadOnly = true;
            txtStaffLastName.Size = new System.Drawing.Size(125, 27);
            txtStaffLastName.TabIndex = 9;
            // 
            // txtStaffFirstName
            // 
            txtStaffFirstName.Location = new System.Drawing.Point(133, 95);
            txtStaffFirstName.Name = "txtStaffFirstName";
            txtStaffFirstName.ReadOnly = true;
            txtStaffFirstName.Size = new System.Drawing.Size(125, 27);
            txtStaffFirstName.TabIndex = 8;
            // 
            // txtStaffID
            // 
            txtStaffID.Location = new System.Drawing.Point(133, 51);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.ReadOnly = true;
            txtStaffID.Size = new System.Drawing.Size(125, 27);
            txtStaffID.TabIndex = 7;
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Location = new System.Drawing.Point(550, 53);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new System.Drawing.Size(105, 20);
            lbPhoneNumber.TabIndex = 6;
            lbPhoneNumber.Text = "Phone number";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(550, 99);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(46, 20);
            lbEmail.TabIndex = 5;
            lbEmail.Text = "Email";
            // 
            // lbStartDay
            // 
            lbStartDay.AutoSize = true;
            lbStartDay.Location = new System.Drawing.Point(272, 146);
            lbStartDay.Name = "lbStartDay";
            lbStartDay.Size = new System.Drawing.Size(68, 20);
            lbStartDay.TabIndex = 4;
            lbStartDay.Text = "Start day";
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Location = new System.Drawing.Point(283, 53);
            lbGender.Name = "lbGender";
            lbGender.Size = new System.Drawing.Size(57, 20);
            lbGender.TabIndex = 3;
            lbGender.Text = "Gender";
            // 
            // lbStaffLastName
            // 
            lbStaffLastName.AutoSize = true;
            lbStaffLastName.Location = new System.Drawing.Point(283, 99);
            lbStaffLastName.Name = "lbStaffLastName";
            lbStaffLastName.Size = new System.Drawing.Size(76, 20);
            lbStaffLastName.TabIndex = 2;
            lbStaffLastName.Text = "Last name";
            // 
            // lbStaffFirstName
            // 
            lbStaffFirstName.AutoSize = true;
            lbStaffFirstName.Location = new System.Drawing.Point(35, 99);
            lbStaffFirstName.Name = "lbStaffFirstName";
            lbStaffFirstName.Size = new System.Drawing.Size(77, 20);
            lbStaffFirstName.TabIndex = 1;
            lbStaffFirstName.Text = "First name";
            // 
            // lbStaffID
            // 
            lbStaffID.AutoSize = true;
            lbStaffID.Location = new System.Drawing.Point(35, 53);
            lbStaffID.Name = "lbStaffID";
            lbStaffID.Size = new System.Drawing.Size(59, 20);
            lbStaffID.TabIndex = 0;
            lbStaffID.Text = "Staff ID";
            // 
            // dgvStaff
            // 
            dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaff.Location = new System.Drawing.Point(0, 319);
            dgvStaff.Name = "dgvStaff";
            dgvStaff.ReadOnly = true;
            dgvStaff.RowHeadersWidth = 51;
            dgvStaff.RowTemplate.Height = 29;
            dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvStaff.Size = new System.Drawing.Size(1025, 217);
            dgvStaff.TabIndex = 0;
            dgvStaff.CellDoubleClick += dgvStaff_CellDoubleClick;
            // 
            // tabExpertManagement
            // 
            tabExpertManagement.Controls.Add(btnDeleteExpert);
            tabExpertManagement.Controls.Add(btnAddExpert);
            tabExpertManagement.Controls.Add(dgvExpertManagement);
            tabExpertManagement.Controls.Add(groupBox3);
            tabExpertManagement.Location = new System.Drawing.Point(4, 29);
            tabExpertManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabExpertManagement.Name = "tabExpertManagement";
            tabExpertManagement.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabExpertManagement.Size = new System.Drawing.Size(1021, 528);
            tabExpertManagement.TabIndex = 1;
            tabExpertManagement.Text = "Expert Management";
            tabExpertManagement.UseVisualStyleBackColor = true;
            // 
            // btnDeleteExpert
            // 
            btnDeleteExpert.Location = new System.Drawing.Point(240, 243);
            btnDeleteExpert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDeleteExpert.Name = "btnDeleteExpert";
            btnDeleteExpert.Size = new System.Drawing.Size(94, 29);
            btnDeleteExpert.TabIndex = 5;
            btnDeleteExpert.Text = "Delete";
            btnDeleteExpert.UseVisualStyleBackColor = true;
            btnDeleteExpert.Click += btnDeleteExpert_Click;
            // 
            // btnAddExpert
            // 
            btnAddExpert.Location = new System.Drawing.Point(96, 243);
            btnAddExpert.Name = "btnAddExpert";
            btnAddExpert.Size = new System.Drawing.Size(94, 29);
            btnAddExpert.TabIndex = 4;
            btnAddExpert.Text = "Add";
            btnAddExpert.UseVisualStyleBackColor = true;
            btnAddExpert.Click += btnAddExpert_Click;
            // 
            // dgvExpertManagement
            // 
            dgvExpertManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpertManagement.Location = new System.Drawing.Point(0, 290);
            dgvExpertManagement.Name = "dgvExpertManagement";
            dgvExpertManagement.ReadOnly = true;
            dgvExpertManagement.RowHeadersWidth = 51;
            dgvExpertManagement.RowTemplate.Height = 29;
            dgvExpertManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvExpertManagement.Size = new System.Drawing.Size(1021, 235);
            dgvExpertManagement.TabIndex = 3;
            dgvExpertManagement.CellDoubleClick += dgvExpertManagement_CellDoubleClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtExpertAreaID);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtExpertPhoneNumber);
            groupBox3.Controls.Add(dtpExpertStartDay);
            groupBox3.Controls.Add(txtExpertEmail);
            groupBox3.Controls.Add(txtGenderExpert);
            groupBox3.Controls.Add(txtExpertLastName);
            groupBox3.Controls.Add(txtExpertFirstName);
            groupBox3.Controls.Add(txtExpertID);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new System.Drawing.Point(61, 26);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(907, 201);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Expert Information";
            // 
            // txtExpertAreaID
            // 
            txtExpertAreaID.Location = new System.Drawing.Point(628, 148);
            txtExpertAreaID.Name = "txtExpertAreaID";
            txtExpertAreaID.ReadOnly = true;
            txtExpertAreaID.Size = new System.Drawing.Size(125, 27);
            txtExpertAreaID.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(498, 152);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(98, 20);
            label8.TabIndex = 16;
            label8.Text = "Area Manage";
            // 
            // txtExpertPhoneNumber
            // 
            txtExpertPhoneNumber.Location = new System.Drawing.Point(688, 45);
            txtExpertPhoneNumber.Name = "txtExpertPhoneNumber";
            txtExpertPhoneNumber.ReadOnly = true;
            txtExpertPhoneNumber.Size = new System.Drawing.Size(125, 27);
            txtExpertPhoneNumber.TabIndex = 13;
            // 
            // dtpExpertStartDay
            // 
            dtpExpertStartDay.Enabled = false;
            dtpExpertStartDay.Location = new System.Drawing.Point(184, 148);
            dtpExpertStartDay.Name = "dtpExpertStartDay";
            dtpExpertStartDay.Size = new System.Drawing.Size(250, 27);
            dtpExpertStartDay.TabIndex = 12;
            // 
            // txtExpertEmail
            // 
            txtExpertEmail.Location = new System.Drawing.Point(688, 96);
            txtExpertEmail.Name = "txtExpertEmail";
            txtExpertEmail.ReadOnly = true;
            txtExpertEmail.Size = new System.Drawing.Size(125, 27);
            txtExpertEmail.TabIndex = 11;
            // 
            // txtGenderExpert
            // 
            txtGenderExpert.Location = new System.Drawing.Point(373, 51);
            txtGenderExpert.Name = "txtGenderExpert";
            txtGenderExpert.ReadOnly = true;
            txtGenderExpert.Size = new System.Drawing.Size(125, 27);
            txtGenderExpert.TabIndex = 10;
            // 
            // txtExpertLastName
            // 
            txtExpertLastName.Location = new System.Drawing.Point(373, 96);
            txtExpertLastName.Name = "txtExpertLastName";
            txtExpertLastName.ReadOnly = true;
            txtExpertLastName.Size = new System.Drawing.Size(125, 27);
            txtExpertLastName.TabIndex = 9;
            // 
            // txtExpertFirstName
            // 
            txtExpertFirstName.Location = new System.Drawing.Point(133, 95);
            txtExpertFirstName.Name = "txtExpertFirstName";
            txtExpertFirstName.ReadOnly = true;
            txtExpertFirstName.Size = new System.Drawing.Size(125, 27);
            txtExpertFirstName.TabIndex = 8;
            // 
            // txtExpertID
            // 
            txtExpertID.Location = new System.Drawing.Point(133, 51);
            txtExpertID.Name = "txtExpertID";
            txtExpertID.ReadOnly = true;
            txtExpertID.Size = new System.Drawing.Size(125, 27);
            txtExpertID.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(550, 53);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(105, 20);
            label1.TabIndex = 6;
            label1.Text = "Phone number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(550, 99);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(46, 20);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(94, 152);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(68, 20);
            label3.TabIndex = 4;
            label3.Text = "Start day";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(283, 53);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(283, 99);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(76, 20);
            label5.TabIndex = 2;
            label5.Text = "Last name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(35, 99);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(77, 20);
            label6.TabIndex = 1;
            label6.Text = "First name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(35, 53);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(70, 20);
            label7.TabIndex = 0;
            label7.Text = "Expert ID";
            // 
            // tabCageManagement
            // 
            tabCageManagement.Controls.Add(btnDeleteCage);
            tabCageManagement.Controls.Add(btnAddCage);
            tabCageManagement.Controls.Add(dgvCageManagement);
            tabCageManagement.Controls.Add(groupBox2);
            tabCageManagement.Location = new System.Drawing.Point(4, 29);
            tabCageManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabCageManagement.Name = "tabCageManagement";
            tabCageManagement.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabCageManagement.Size = new System.Drawing.Size(1021, 528);
            tabCageManagement.TabIndex = 2;
            tabCageManagement.Text = "Cage Management";
            tabCageManagement.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCage
            // 
            btnDeleteCage.Location = new System.Drawing.Point(204, 250);
            btnDeleteCage.Name = "btnDeleteCage";
            btnDeleteCage.Size = new System.Drawing.Size(94, 29);
            btnDeleteCage.TabIndex = 3;
            btnDeleteCage.Text = "Delete";
            btnDeleteCage.UseVisualStyleBackColor = true;
            btnDeleteCage.Click += btnDeleteCage_Click;
            // 
            // btnAddCage
            // 
            btnAddCage.Location = new System.Drawing.Point(57, 250);
            btnAddCage.Name = "btnAddCage";
            btnAddCage.Size = new System.Drawing.Size(94, 29);
            btnAddCage.TabIndex = 2;
            btnAddCage.Text = "Add";
            btnAddCage.UseVisualStyleBackColor = true;
            btnAddCage.Click += btnAddCage_Click;
            // 
            // dgvCageManagement
            // 
            dgvCageManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCageManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCageManagement.Location = new System.Drawing.Point(0, 308);
            dgvCageManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvCageManagement.Name = "dgvCageManagement";
            dgvCageManagement.ReadOnly = true;
            dgvCageManagement.RowHeadersWidth = 51;
            dgvCageManagement.RowTemplate.Height = 29;
            dgvCageManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCageManagement.Size = new System.Drawing.Size(1030, 224);
            dgvCageManagement.TabIndex = 1;
            dgvCageManagement.CellDoubleClick += dgvCageManagement_CellDoubleClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtStaffForeignID);
            groupBox2.Controls.Add(txtAreaForeignID);
            groupBox2.Controls.Add(txtCageStatus);
            groupBox2.Controls.Add(txtCageQuantity);
            groupBox2.Controls.Add(txtCageName);
            groupBox2.Controls.Add(txtCagePrimaryID);
            groupBox2.Controls.Add(lbStaffForeignID);
            groupBox2.Controls.Add(lbAreaForeignID);
            groupBox2.Controls.Add(lbCageStatus);
            groupBox2.Controls.Add(lbCageQuantity);
            groupBox2.Controls.Add(lbCageName);
            groupBox2.Controls.Add(lbCageId);
            groupBox2.Location = new System.Drawing.Point(31, 28);
            groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Size = new System.Drawing.Size(949, 199);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cage Management";
            // 
            // txtStaffForeignID
            // 
            txtStaffForeignID.Location = new System.Drawing.Point(760, 57);
            txtStaffForeignID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtStaffForeignID.Name = "txtStaffForeignID";
            txtStaffForeignID.ReadOnly = true;
            txtStaffForeignID.Size = new System.Drawing.Size(142, 27);
            txtStaffForeignID.TabIndex = 13;
            // 
            // txtAreaForeignID
            // 
            txtAreaForeignID.Location = new System.Drawing.Point(760, 109);
            txtAreaForeignID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtAreaForeignID.Name = "txtAreaForeignID";
            txtAreaForeignID.ReadOnly = true;
            txtAreaForeignID.Size = new System.Drawing.Size(142, 27);
            txtAreaForeignID.TabIndex = 12;
            // 
            // txtCageStatus
            // 
            txtCageStatus.Location = new System.Drawing.Point(476, 57);
            txtCageStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCageStatus.Name = "txtCageStatus";
            txtCageStatus.ReadOnly = true;
            txtCageStatus.Size = new System.Drawing.Size(142, 27);
            txtCageStatus.TabIndex = 10;
            // 
            // txtCageQuantity
            // 
            txtCageQuantity.Location = new System.Drawing.Point(476, 109);
            txtCageQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCageQuantity.Name = "txtCageQuantity";
            txtCageQuantity.ReadOnly = true;
            txtCageQuantity.Size = new System.Drawing.Size(142, 27);
            txtCageQuantity.TabIndex = 9;
            // 
            // txtCageName
            // 
            txtCageName.Location = new System.Drawing.Point(173, 109);
            txtCageName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCageName.Name = "txtCageName";
            txtCageName.ReadOnly = true;
            txtCageName.Size = new System.Drawing.Size(142, 27);
            txtCageName.TabIndex = 8;
            // 
            // txtCagePrimaryID
            // 
            txtCagePrimaryID.Location = new System.Drawing.Point(173, 57);
            txtCagePrimaryID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCagePrimaryID.Name = "txtCagePrimaryID";
            txtCagePrimaryID.ReadOnly = true;
            txtCagePrimaryID.Size = new System.Drawing.Size(142, 27);
            txtCagePrimaryID.TabIndex = 7;
            // 
            // lbStaffForeignID
            // 
            lbStaffForeignID.AutoSize = true;
            lbStaffForeignID.Location = new System.Drawing.Point(675, 60);
            lbStaffForeignID.Name = "lbStaffForeignID";
            lbStaffForeignID.Size = new System.Drawing.Size(55, 20);
            lbStaffForeignID.TabIndex = 6;
            lbStaffForeignID.Text = "StaffID";
            // 
            // lbAreaForeignID
            // 
            lbAreaForeignID.AutoSize = true;
            lbAreaForeignID.Location = new System.Drawing.Point(675, 112);
            lbAreaForeignID.Name = "lbAreaForeignID";
            lbAreaForeignID.Size = new System.Drawing.Size(59, 20);
            lbAreaForeignID.TabIndex = 5;
            lbAreaForeignID.Text = "Area ID";
            // 
            // lbCageStatus
            // 
            lbCageStatus.AutoSize = true;
            lbCageStatus.Location = new System.Drawing.Point(349, 60);
            lbCageStatus.Name = "lbCageStatus";
            lbCageStatus.Size = new System.Drawing.Size(87, 20);
            lbCageStatus.TabIndex = 3;
            lbCageStatus.Text = "Cage Status";
            // 
            // lbCageQuantity
            // 
            lbCageQuantity.AutoSize = true;
            lbCageQuantity.Location = new System.Drawing.Point(349, 112);
            lbCageQuantity.Name = "lbCageQuantity";
            lbCageQuantity.Size = new System.Drawing.Size(103, 20);
            lbCageQuantity.TabIndex = 2;
            lbCageQuantity.Text = "Cage Quantity";
            // 
            // lbCageName
            // 
            lbCageName.AutoSize = true;
            lbCageName.Location = new System.Drawing.Point(33, 112);
            lbCageName.Name = "lbCageName";
            lbCageName.Size = new System.Drawing.Size(87, 20);
            lbCageName.TabIndex = 1;
            lbCageName.Text = "Cage Name";
            // 
            // lbCageId
            // 
            lbCageId.AutoSize = true;
            lbCageId.Location = new System.Drawing.Point(33, 60);
            lbCageId.Name = "lbCageId";
            lbCageId.Size = new System.Drawing.Size(62, 20);
            lbCageId.TabIndex = 0;
            lbCageId.Text = "Cage ID";
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1029, 563);
            Controls.Add(tabControl1);
            Name = "frmAdmin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmAdmin";
            Load += frmAdmin_Load;
            tabControl1.ResumeLayout(false);
            tabStaffMangement.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
            tabExpertManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExpertManagement).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabCageManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCageManagement).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStaffMangement;
        private System.Windows.Forms.TabPage tabExpertManagement;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbStaffID;
        private System.Windows.Forms.Label lbStaffFirstName;
        private System.Windows.Forms.Label lbStaffLastName;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbStartDay;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtStaffPhoneNumber;
        private System.Windows.Forms.DateTimePicker dtpStatDay;
        private System.Windows.Forms.TextBox txtStaffEmail;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtStaffLastName;
        private System.Windows.Forms.TextBox txtStaffFirstName;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.TabPage tabCageManagement;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbCageId;
        private System.Windows.Forms.Label lbCageStatus;
        private System.Windows.Forms.Label lbCageQuantity;
        private System.Windows.Forms.Label lbCageName;
        private System.Windows.Forms.Label lbStaffForeignID;
        private System.Windows.Forms.Label lbAreaForeignID;
        private System.Windows.Forms.TextBox txtStaffForeignID;
        private System.Windows.Forms.TextBox txtAreaForeignID;
        private System.Windows.Forms.TextBox txtCageStatus;
        private System.Windows.Forms.TextBox txtCageQuantity;
        private System.Windows.Forms.TextBox txtCageName;
        private System.Windows.Forms.TextBox txtCagePrimaryID;
        private System.Windows.Forms.DataGridView dgvCageManagement;
        private System.Windows.Forms.Button btnAddCage;
        private System.Windows.Forms.Button btnDeleteCage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtExpertPhoneNumber;
        private System.Windows.Forms.DateTimePicker dtpExpertStartDay;
        private System.Windows.Forms.TextBox txtExpertEmail;
        private System.Windows.Forms.TextBox txtGenderExpert;
        private System.Windows.Forms.TextBox txtExpertLastName;
        private System.Windows.Forms.TextBox txtExpertFirstName;
        private System.Windows.Forms.TextBox txtExpertID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtExpertAreaID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvExpertManagement;
        private System.Windows.Forms.Button btnDeleteExpert;
        private System.Windows.Forms.Button btnAddExpert;
    }
}
