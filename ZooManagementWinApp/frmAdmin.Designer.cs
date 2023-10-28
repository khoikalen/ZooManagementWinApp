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
            tabPage2 = new System.Windows.Forms.TabPage();
            tabControl1.SuspendLayout();
            tabStaffMangement.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabStaffMangement);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new System.Drawing.Point(0, 1);
            tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(900, 421);
            tabControl1.TabIndex = 0;
            // 
            // tabStaffMangement
            // 
            tabStaffMangement.Controls.Add(btnAddStaff);
            tabStaffMangement.Controls.Add(groupBox1);
            tabStaffMangement.Controls.Add(dgvStaff);
            tabStaffMangement.Location = new System.Drawing.Point(4, 24);
            tabStaffMangement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabStaffMangement.Name = "tabStaffMangement";
            tabStaffMangement.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabStaffMangement.Size = new System.Drawing.Size(892, 393);
            tabStaffMangement.TabIndex = 0;
            tabStaffMangement.Text = "Staff Management";
            tabStaffMangement.UseVisualStyleBackColor = true;
            // 
            // btnAddStaff
            // 
            btnAddStaff.Location = new System.Drawing.Point(116, 199);
            btnAddStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnAddStaff.Name = "btnAddStaff";
            btnAddStaff.Size = new System.Drawing.Size(82, 22);
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
            groupBox1.Location = new System.Drawing.Point(40, 34);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox1.Size = new System.Drawing.Size(794, 161);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Staff Information";
            // 
            // txtStaffPhoneNumber
            // 
            txtStaffPhoneNumber.Location = new System.Drawing.Point(602, 34);
            txtStaffPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtStaffPhoneNumber.Name = "txtStaffPhoneNumber";
            txtStaffPhoneNumber.Size = new System.Drawing.Size(110, 23);
            txtStaffPhoneNumber.TabIndex = 13;
            // 
            // dtpStatDay
            // 
            dtpStatDay.Location = new System.Drawing.Point(326, 71);
            dtpStatDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dtpStatDay.Name = "dtpStatDay";
            dtpStatDay.Size = new System.Drawing.Size(219, 23);
            dtpStatDay.TabIndex = 12;
            // 
            // txtStaffEmail
            // 
            txtStaffEmail.Location = new System.Drawing.Point(326, 102);
            txtStaffEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtStaffEmail.Name = "txtStaffEmail";
            txtStaffEmail.Size = new System.Drawing.Size(110, 23);
            txtStaffEmail.TabIndex = 11;
            // 
            // txtGender
            // 
            txtGender.Location = new System.Drawing.Point(326, 38);
            txtGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtGender.Name = "txtGender";
            txtGender.Size = new System.Drawing.Size(110, 23);
            txtGender.TabIndex = 10;
            // 
            // txtStaffLastName
            // 
            txtStaffLastName.Location = new System.Drawing.Point(116, 102);
            txtStaffLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtStaffLastName.Name = "txtStaffLastName";
            txtStaffLastName.Size = new System.Drawing.Size(110, 23);
            txtStaffLastName.TabIndex = 9;
            // 
            // txtStaffFirstName
            // 
            txtStaffFirstName.Location = new System.Drawing.Point(116, 71);
            txtStaffFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtStaffFirstName.Name = "txtStaffFirstName";
            txtStaffFirstName.Size = new System.Drawing.Size(110, 23);
            txtStaffFirstName.TabIndex = 8;
            // 
            // txtStaffID
            // 
            txtStaffID.Location = new System.Drawing.Point(116, 38);
            txtStaffID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new System.Drawing.Size(110, 23);
            txtStaffID.TabIndex = 7;
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Location = new System.Drawing.Point(481, 40);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new System.Drawing.Size(86, 15);
            lbPhoneNumber.TabIndex = 6;
            lbPhoneNumber.Text = "Phone number";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(254, 104);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(36, 15);
            lbEmail.TabIndex = 5;
            lbEmail.Text = "Email";
            // 
            // lbStartDay
            // 
            lbStartDay.AutoSize = true;
            lbStartDay.Location = new System.Drawing.Point(248, 74);
            lbStartDay.Name = "lbStartDay";
            lbStartDay.Size = new System.Drawing.Size(53, 15);
            lbStartDay.TabIndex = 4;
            lbStartDay.Text = "Start day";
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Location = new System.Drawing.Point(248, 40);
            lbGender.Name = "lbGender";
            lbGender.Size = new System.Drawing.Size(45, 15);
            lbGender.TabIndex = 3;
            lbGender.Text = "Gender";
            // 
            // lbStaffLastName
            // 
            lbStaffLastName.AutoSize = true;
            lbStaffLastName.Location = new System.Drawing.Point(31, 104);
            lbStaffLastName.Name = "lbStaffLastName";
            lbStaffLastName.Size = new System.Drawing.Size(61, 15);
            lbStaffLastName.TabIndex = 2;
            lbStaffLastName.Text = "Last name";
            // 
            // lbStaffFirstName
            // 
            lbStaffFirstName.AutoSize = true;
            lbStaffFirstName.Location = new System.Drawing.Point(31, 74);
            lbStaffFirstName.Name = "lbStaffFirstName";
            lbStaffFirstName.Size = new System.Drawing.Size(62, 15);
            lbStaffFirstName.TabIndex = 1;
            lbStaffFirstName.Text = "First name";
            // 
            // lbStaffID
            // 
            lbStaffID.AutoSize = true;
            lbStaffID.Location = new System.Drawing.Point(31, 40);
            lbStaffID.Name = "lbStaffID";
            lbStaffID.Size = new System.Drawing.Size(45, 15);
            lbStaffID.TabIndex = 0;
            lbStaffID.Text = "Staff ID";
            // 
            // dgvStaff
            // 
            dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaff.Location = new System.Drawing.Point(0, 239);
            dgvStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvStaff.Name = "dgvStaff";
            dgvStaff.ReadOnly = true;
            dgvStaff.RowHeadersWidth = 51;
            dgvStaff.RowTemplate.Height = 29;
            dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvStaff.Size = new System.Drawing.Size(897, 163);
            dgvStaff.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabPage2.Size = new System.Drawing.Size(892, 393);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(900, 422);
            Controls.Add(tabControl1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "frmAdmin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmAdmin";
            Load += frmAdmin_Load;
            tabControl1.ResumeLayout(false);
            tabStaffMangement.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStaffMangement;
        private System.Windows.Forms.TabPage tabPage2;
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
    }
}
