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
            btnAssign = new System.Windows.Forms.Button();
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
            btnLogout = new System.Windows.Forms.Button();
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
            tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1286, 701);
            tabControl1.TabIndex = 0;
            // 
            // tabStaffMangement
            // 
            tabStaffMangement.Controls.Add(btnLogout);
            tabStaffMangement.Controls.Add(btnDeleteStaff);
            tabStaffMangement.Controls.Add(btnAddStaff);
            tabStaffMangement.Controls.Add(groupBox1);
            tabStaffMangement.Controls.Add(dgvStaff);
            tabStaffMangement.Location = new System.Drawing.Point(4, 34);
            tabStaffMangement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            tabStaffMangement.Name = "tabStaffMangement";
            tabStaffMangement.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            tabStaffMangement.Size = new System.Drawing.Size(1278, 663);
            tabStaffMangement.TabIndex = 0;
            tabStaffMangement.Text = "Staff Management";
            tabStaffMangement.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStaff
            // 
            btnDeleteStaff.Location = new System.Drawing.Point(281, 332);
            btnDeleteStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnDeleteStaff.Name = "btnDeleteStaff";
            btnDeleteStaff.Size = new System.Drawing.Size(118, 36);
            btnDeleteStaff.TabIndex = 3;
            btnDeleteStaff.Text = "Delete";
            btnDeleteStaff.UseVisualStyleBackColor = true;
            btnDeleteStaff.Click += btnDeleteStaff_Click;
            // 
            // btnAddStaff
            // 
            btnAddStaff.Location = new System.Drawing.Point(101, 332);
            btnAddStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnAddStaff.Name = "btnAddStaff";
            btnAddStaff.Size = new System.Drawing.Size(118, 36);
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
            groupBox1.Location = new System.Drawing.Point(58, 56);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupBox1.Size = new System.Drawing.Size(1134, 251);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Staff Information";
            // 
            // txtStaffPhoneNumber
            // 
            txtStaffPhoneNumber.Location = new System.Drawing.Point(860, 56);
            txtStaffPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtStaffPhoneNumber.Name = "txtStaffPhoneNumber";
            txtStaffPhoneNumber.ReadOnly = true;
            txtStaffPhoneNumber.Size = new System.Drawing.Size(155, 31);
            txtStaffPhoneNumber.TabIndex = 13;
            // 
            // dtpStatDay
            // 
            dtpStatDay.Enabled = false;
            dtpStatDay.Location = new System.Drawing.Point(452, 178);
            dtpStatDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            dtpStatDay.Name = "dtpStatDay";
            dtpStatDay.Size = new System.Drawing.Size(312, 31);
            dtpStatDay.TabIndex = 12;
            // 
            // txtStaffEmail
            // 
            txtStaffEmail.Location = new System.Drawing.Point(860, 120);
            txtStaffEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtStaffEmail.Name = "txtStaffEmail";
            txtStaffEmail.ReadOnly = true;
            txtStaffEmail.Size = new System.Drawing.Size(155, 31);
            txtStaffEmail.TabIndex = 11;
            // 
            // txtGender
            // 
            txtGender.Location = new System.Drawing.Point(466, 64);
            txtGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtGender.Name = "txtGender";
            txtGender.ReadOnly = true;
            txtGender.Size = new System.Drawing.Size(155, 31);
            txtGender.TabIndex = 10;
            // 
            // txtStaffLastName
            // 
            txtStaffLastName.Location = new System.Drawing.Point(466, 120);
            txtStaffLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtStaffLastName.Name = "txtStaffLastName";
            txtStaffLastName.ReadOnly = true;
            txtStaffLastName.Size = new System.Drawing.Size(155, 31);
            txtStaffLastName.TabIndex = 9;
            // 
            // txtStaffFirstName
            // 
            txtStaffFirstName.Location = new System.Drawing.Point(166, 119);
            txtStaffFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtStaffFirstName.Name = "txtStaffFirstName";
            txtStaffFirstName.ReadOnly = true;
            txtStaffFirstName.Size = new System.Drawing.Size(155, 31);
            txtStaffFirstName.TabIndex = 8;
            // 
            // txtStaffID
            // 
            txtStaffID.Location = new System.Drawing.Point(166, 64);
            txtStaffID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.ReadOnly = true;
            txtStaffID.Size = new System.Drawing.Size(155, 31);
            txtStaffID.TabIndex = 7;
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Location = new System.Drawing.Point(688, 66);
            lbPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new System.Drawing.Size(129, 25);
            lbPhoneNumber.TabIndex = 6;
            lbPhoneNumber.Text = "Phone number";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(688, 124);
            lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(54, 25);
            lbEmail.TabIndex = 5;
            lbEmail.Text = "Email";
            // 
            // lbStartDay
            // 
            lbStartDay.AutoSize = true;
            lbStartDay.Location = new System.Drawing.Point(340, 182);
            lbStartDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbStartDay.Name = "lbStartDay";
            lbStartDay.Size = new System.Drawing.Size(82, 25);
            lbStartDay.TabIndex = 4;
            lbStartDay.Text = "Start day";
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Location = new System.Drawing.Point(354, 66);
            lbGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbGender.Name = "lbGender";
            lbGender.Size = new System.Drawing.Size(69, 25);
            lbGender.TabIndex = 3;
            lbGender.Text = "Gender";
            // 
            // lbStaffLastName
            // 
            lbStaffLastName.AutoSize = true;
            lbStaffLastName.Location = new System.Drawing.Point(354, 124);
            lbStaffLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbStaffLastName.Name = "lbStaffLastName";
            lbStaffLastName.Size = new System.Drawing.Size(92, 25);
            lbStaffLastName.TabIndex = 2;
            lbStaffLastName.Text = "Last name";
            // 
            // lbStaffFirstName
            // 
            lbStaffFirstName.AutoSize = true;
            lbStaffFirstName.Location = new System.Drawing.Point(44, 124);
            lbStaffFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbStaffFirstName.Name = "lbStaffFirstName";
            lbStaffFirstName.Size = new System.Drawing.Size(94, 25);
            lbStaffFirstName.TabIndex = 1;
            lbStaffFirstName.Text = "First name";
            // 
            // lbStaffID
            // 
            lbStaffID.AutoSize = true;
            lbStaffID.Location = new System.Drawing.Point(44, 66);
            lbStaffID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbStaffID.Name = "lbStaffID";
            lbStaffID.Size = new System.Drawing.Size(71, 25);
            lbStaffID.TabIndex = 0;
            lbStaffID.Text = "Staff ID";
            // 
            // dgvStaff
            // 
            dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaff.Location = new System.Drawing.Point(0, 399);
            dgvStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            dgvStaff.Name = "dgvStaff";
            dgvStaff.ReadOnly = true;
            dgvStaff.RowHeadersWidth = 51;
            dgvStaff.RowTemplate.Height = 29;
            dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvStaff.Size = new System.Drawing.Size(1281, 271);
            dgvStaff.TabIndex = 0;
            dgvStaff.CellDoubleClick += dgvStaff_CellDoubleClick;
            // 
            // tabExpertManagement
            // 
            tabExpertManagement.Controls.Add(btnDeleteExpert);
            tabExpertManagement.Controls.Add(btnAddExpert);
            tabExpertManagement.Controls.Add(dgvExpertManagement);
            tabExpertManagement.Controls.Add(groupBox3);
            tabExpertManagement.Location = new System.Drawing.Point(4, 34);
            tabExpertManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabExpertManagement.Name = "tabExpertManagement";
            tabExpertManagement.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabExpertManagement.Size = new System.Drawing.Size(1278, 663);
            tabExpertManagement.TabIndex = 1;
            tabExpertManagement.Text = "Expert Management";
            tabExpertManagement.UseVisualStyleBackColor = true;
            // 
            // btnDeleteExpert
            // 
            btnDeleteExpert.Location = new System.Drawing.Point(300, 304);
            btnDeleteExpert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnDeleteExpert.Name = "btnDeleteExpert";
            btnDeleteExpert.Size = new System.Drawing.Size(118, 36);
            btnDeleteExpert.TabIndex = 5;
            btnDeleteExpert.Text = "Delete";
            btnDeleteExpert.UseVisualStyleBackColor = true;
            btnDeleteExpert.Click += btnDeleteExpert_Click;
            // 
            // btnAddExpert
            // 
            btnAddExpert.Location = new System.Drawing.Point(120, 304);
            btnAddExpert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnAddExpert.Name = "btnAddExpert";
            btnAddExpert.Size = new System.Drawing.Size(118, 36);
            btnAddExpert.TabIndex = 4;
            btnAddExpert.Text = "Add";
            btnAddExpert.UseVisualStyleBackColor = true;
            btnAddExpert.Click += btnAddExpert_Click;
            // 
            // dgvExpertManagement
            // 
            dgvExpertManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpertManagement.Location = new System.Drawing.Point(0, 362);
            dgvExpertManagement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            dgvExpertManagement.Name = "dgvExpertManagement";
            dgvExpertManagement.ReadOnly = true;
            dgvExpertManagement.RowHeadersWidth = 51;
            dgvExpertManagement.RowTemplate.Height = 29;
            dgvExpertManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvExpertManagement.Size = new System.Drawing.Size(1276, 294);
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
            groupBox3.Location = new System.Drawing.Point(76, 32);
            groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupBox3.Size = new System.Drawing.Size(1134, 251);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Expert Information";
            // 
            // txtExpertAreaID
            // 
            txtExpertAreaID.Location = new System.Drawing.Point(785, 185);
            txtExpertAreaID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtExpertAreaID.Name = "txtExpertAreaID";
            txtExpertAreaID.ReadOnly = true;
            txtExpertAreaID.Size = new System.Drawing.Size(155, 31);
            txtExpertAreaID.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(622, 190);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(117, 25);
            label8.TabIndex = 16;
            label8.Text = "Area Manage";
            // 
            // txtExpertPhoneNumber
            // 
            txtExpertPhoneNumber.Location = new System.Drawing.Point(860, 56);
            txtExpertPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtExpertPhoneNumber.Name = "txtExpertPhoneNumber";
            txtExpertPhoneNumber.ReadOnly = true;
            txtExpertPhoneNumber.Size = new System.Drawing.Size(155, 31);
            txtExpertPhoneNumber.TabIndex = 13;
            // 
            // dtpExpertStartDay
            // 
            dtpExpertStartDay.Enabled = false;
            dtpExpertStartDay.Location = new System.Drawing.Point(230, 185);
            dtpExpertStartDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            dtpExpertStartDay.Name = "dtpExpertStartDay";
            dtpExpertStartDay.Size = new System.Drawing.Size(312, 31);
            dtpExpertStartDay.TabIndex = 12;
            // 
            // txtExpertEmail
            // 
            txtExpertEmail.Location = new System.Drawing.Point(860, 120);
            txtExpertEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtExpertEmail.Name = "txtExpertEmail";
            txtExpertEmail.ReadOnly = true;
            txtExpertEmail.Size = new System.Drawing.Size(155, 31);
            txtExpertEmail.TabIndex = 11;
            // 
            // txtGenderExpert
            // 
            txtGenderExpert.Location = new System.Drawing.Point(466, 64);
            txtGenderExpert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtGenderExpert.Name = "txtGenderExpert";
            txtGenderExpert.ReadOnly = true;
            txtGenderExpert.Size = new System.Drawing.Size(155, 31);
            txtGenderExpert.TabIndex = 10;
            // 
            // txtExpertLastName
            // 
            txtExpertLastName.Location = new System.Drawing.Point(466, 120);
            txtExpertLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtExpertLastName.Name = "txtExpertLastName";
            txtExpertLastName.ReadOnly = true;
            txtExpertLastName.Size = new System.Drawing.Size(155, 31);
            txtExpertLastName.TabIndex = 9;
            // 
            // txtExpertFirstName
            // 
            txtExpertFirstName.Location = new System.Drawing.Point(166, 119);
            txtExpertFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtExpertFirstName.Name = "txtExpertFirstName";
            txtExpertFirstName.ReadOnly = true;
            txtExpertFirstName.Size = new System.Drawing.Size(155, 31);
            txtExpertFirstName.TabIndex = 8;
            // 
            // txtExpertID
            // 
            txtExpertID.Location = new System.Drawing.Point(166, 64);
            txtExpertID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtExpertID.Name = "txtExpertID";
            txtExpertID.ReadOnly = true;
            txtExpertID.Size = new System.Drawing.Size(155, 31);
            txtExpertID.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(688, 66);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(129, 25);
            label1.TabIndex = 6;
            label1.Text = "Phone number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(688, 124);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 25);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(118, 190);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(82, 25);
            label3.TabIndex = 4;
            label3.Text = "Start day";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(354, 66);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 25);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(354, 124);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(92, 25);
            label5.TabIndex = 2;
            label5.Text = "Last name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(44, 124);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(94, 25);
            label6.TabIndex = 1;
            label6.Text = "First name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(44, 66);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(84, 25);
            label7.TabIndex = 0;
            label7.Text = "Expert ID";
            // 
            // tabCageManagement
            // 
            tabCageManagement.Controls.Add(btnAssign);
            tabCageManagement.Controls.Add(btnDeleteCage);
            tabCageManagement.Controls.Add(btnAddCage);
            tabCageManagement.Controls.Add(dgvCageManagement);
            tabCageManagement.Controls.Add(groupBox2);
            tabCageManagement.Location = new System.Drawing.Point(4, 34);
            tabCageManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabCageManagement.Name = "tabCageManagement";
            tabCageManagement.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabCageManagement.Size = new System.Drawing.Size(1278, 663);
            tabCageManagement.TabIndex = 2;
            tabCageManagement.Text = "Cage Management";
            tabCageManagement.UseVisualStyleBackColor = true;
            // 
            // btnAssign
            // 
            btnAssign.Location = new System.Drawing.Point(419, 312);
            btnAssign.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new System.Drawing.Size(208, 36);
            btnAssign.TabIndex = 4;
            btnAssign.Text = "Assign Cage for Staff";
            btnAssign.UseVisualStyleBackColor = true;
            btnAssign.Click += btnAssign_Click;
            // 
            // btnDeleteCage
            // 
            btnDeleteCage.Location = new System.Drawing.Point(255, 312);
            btnDeleteCage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnDeleteCage.Name = "btnDeleteCage";
            btnDeleteCage.Size = new System.Drawing.Size(118, 36);
            btnDeleteCage.TabIndex = 3;
            btnDeleteCage.Text = "Delete";
            btnDeleteCage.UseVisualStyleBackColor = true;
            btnDeleteCage.Click += btnDeleteCage_Click;
            // 
            // btnAddCage
            // 
            btnAddCage.Location = new System.Drawing.Point(71, 312);
            btnAddCage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnAddCage.Name = "btnAddCage";
            btnAddCage.Size = new System.Drawing.Size(118, 36);
            btnAddCage.TabIndex = 2;
            btnAddCage.Text = "Add";
            btnAddCage.UseVisualStyleBackColor = true;
            btnAddCage.Click += btnAddCage_Click;
            // 
            // dgvCageManagement
            // 
            dgvCageManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCageManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCageManagement.Location = new System.Drawing.Point(0, 385);
            dgvCageManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dgvCageManagement.Name = "dgvCageManagement";
            dgvCageManagement.ReadOnly = true;
            dgvCageManagement.RowHeadersWidth = 51;
            dgvCageManagement.RowTemplate.Height = 29;
            dgvCageManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCageManagement.Size = new System.Drawing.Size(1288, 280);
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
            groupBox2.Location = new System.Drawing.Point(39, 35);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox2.Size = new System.Drawing.Size(1186, 249);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cage Management";
            // 
            // txtStaffForeignID
            // 
            txtStaffForeignID.Location = new System.Drawing.Point(950, 71);
            txtStaffForeignID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtStaffForeignID.Name = "txtStaffForeignID";
            txtStaffForeignID.ReadOnly = true;
            txtStaffForeignID.Size = new System.Drawing.Size(176, 31);
            txtStaffForeignID.TabIndex = 13;
            // 
            // txtAreaForeignID
            // 
            txtAreaForeignID.Location = new System.Drawing.Point(950, 136);
            txtAreaForeignID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtAreaForeignID.Name = "txtAreaForeignID";
            txtAreaForeignID.ReadOnly = true;
            txtAreaForeignID.Size = new System.Drawing.Size(176, 31);
            txtAreaForeignID.TabIndex = 12;
            // 
            // txtCageStatus
            // 
            txtCageStatus.Location = new System.Drawing.Point(595, 71);
            txtCageStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtCageStatus.Name = "txtCageStatus";
            txtCageStatus.ReadOnly = true;
            txtCageStatus.Size = new System.Drawing.Size(176, 31);
            txtCageStatus.TabIndex = 10;
            // 
            // txtCageQuantity
            // 
            txtCageQuantity.Location = new System.Drawing.Point(595, 136);
            txtCageQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtCageQuantity.Name = "txtCageQuantity";
            txtCageQuantity.ReadOnly = true;
            txtCageQuantity.Size = new System.Drawing.Size(176, 31);
            txtCageQuantity.TabIndex = 9;
            // 
            // txtCageName
            // 
            txtCageName.Location = new System.Drawing.Point(216, 136);
            txtCageName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtCageName.Name = "txtCageName";
            txtCageName.ReadOnly = true;
            txtCageName.Size = new System.Drawing.Size(176, 31);
            txtCageName.TabIndex = 8;
            // 
            // txtCagePrimaryID
            // 
            txtCagePrimaryID.Location = new System.Drawing.Point(216, 71);
            txtCagePrimaryID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtCagePrimaryID.Name = "txtCagePrimaryID";
            txtCagePrimaryID.ReadOnly = true;
            txtCagePrimaryID.Size = new System.Drawing.Size(176, 31);
            txtCagePrimaryID.TabIndex = 7;
            // 
            // lbStaffForeignID
            // 
            lbStaffForeignID.AutoSize = true;
            lbStaffForeignID.Location = new System.Drawing.Point(844, 75);
            lbStaffForeignID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbStaffForeignID.Name = "lbStaffForeignID";
            lbStaffForeignID.Size = new System.Drawing.Size(66, 25);
            lbStaffForeignID.TabIndex = 6;
            lbStaffForeignID.Text = "StaffID";
            // 
            // lbAreaForeignID
            // 
            lbAreaForeignID.AutoSize = true;
            lbAreaForeignID.Location = new System.Drawing.Point(844, 140);
            lbAreaForeignID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbAreaForeignID.Name = "lbAreaForeignID";
            lbAreaForeignID.Size = new System.Drawing.Size(71, 25);
            lbAreaForeignID.TabIndex = 5;
            lbAreaForeignID.Text = "Area ID";
            // 
            // lbCageStatus
            // 
            lbCageStatus.AutoSize = true;
            lbCageStatus.Location = new System.Drawing.Point(436, 75);
            lbCageStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbCageStatus.Name = "lbCageStatus";
            lbCageStatus.Size = new System.Drawing.Size(105, 25);
            lbCageStatus.TabIndex = 3;
            lbCageStatus.Text = "Cage Status";
            // 
            // lbCageQuantity
            // 
            lbCageQuantity.AutoSize = true;
            lbCageQuantity.Location = new System.Drawing.Point(436, 140);
            lbCageQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbCageQuantity.Name = "lbCageQuantity";
            lbCageQuantity.Size = new System.Drawing.Size(125, 25);
            lbCageQuantity.TabIndex = 2;
            lbCageQuantity.Text = "Cage Quantity";
            // 
            // lbCageName
            // 
            lbCageName.AutoSize = true;
            lbCageName.Location = new System.Drawing.Point(41, 140);
            lbCageName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbCageName.Name = "lbCageName";
            lbCageName.Size = new System.Drawing.Size(104, 25);
            lbCageName.TabIndex = 1;
            lbCageName.Text = "Cage Name";
            // 
            // lbCageId
            // 
            lbCageId.AutoSize = true;
            lbCageId.Location = new System.Drawing.Point(41, 75);
            lbCageId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbCageId.Name = "lbCageId";
            lbCageId.Size = new System.Drawing.Size(75, 25);
            lbCageId.TabIndex = 0;
            lbCageId.Text = "Cage ID";
            // 
            // btnLogout
            // 
            btnLogout.Location = new System.Drawing.Point(889, 334);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(112, 34);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1286, 704);
            Controls.Add(tabControl1);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnLogout;
    }
}
