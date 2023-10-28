namespace ZooManagementWinApp
{
    partial class frmStaff
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            txtStaffID = new System.Windows.Forms.TextBox();
            txtStaffFirstname = new System.Windows.Forms.TextBox();
            txtStaffEmail = new System.Windows.Forms.TextBox();
            txtStaffPhonenumber = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            cboStaffGender = new System.Windows.Forms.ComboBox();
            dgvCageList = new System.Windows.Forms.DataGridView();
            groupBox2 = new System.Windows.Forms.GroupBox();
            cboCageStatus = new System.Windows.Forms.ComboBox();
            txtCageStaffID = new System.Windows.Forms.TextBox();
            txtCageAreaID = new System.Windows.Forms.TextBox();
            txtCageID = new System.Windows.Forms.TextBox();
            txtCageName = new System.Windows.Forms.TextBox();
            txtCageQuantity = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCageList).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Staff ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 67);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 106);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(217, 30);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(36, 15);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(217, 67);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(86, 15);
            label7.TabIndex = 6;
            label7.Text = "Phone number";
            // 
            // txtStaffID
            // 
            txtStaffID.Location = new System.Drawing.Point(317, 22);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.ReadOnly = true;
            txtStaffID.Size = new System.Drawing.Size(96, 23);
            txtStaffID.TabIndex = 7;
            // 
            // txtStaffFirstname
            // 
            txtStaffFirstname.Location = new System.Drawing.Point(57, 59);
            txtStaffFirstname.Name = "txtStaffFirstname";
            txtStaffFirstname.ReadOnly = true;
            txtStaffFirstname.Size = new System.Drawing.Size(96, 23);
            txtStaffFirstname.TabIndex = 8;
            // 
            // txtStaffEmail
            // 
            txtStaffEmail.Location = new System.Drawing.Point(57, 22);
            txtStaffEmail.Name = "txtStaffEmail";
            txtStaffEmail.ReadOnly = true;
            txtStaffEmail.Size = new System.Drawing.Size(96, 23);
            txtStaffEmail.TabIndex = 11;
            // 
            // txtStaffPhonenumber
            // 
            txtStaffPhonenumber.Location = new System.Drawing.Point(317, 59);
            txtStaffPhonenumber.Name = "txtStaffPhonenumber";
            txtStaffPhonenumber.ReadOnly = true;
            txtStaffPhonenumber.Size = new System.Drawing.Size(96, 23);
            txtStaffPhonenumber.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboStaffGender);
            groupBox1.Controls.Add(txtStaffID);
            groupBox1.Controls.Add(txtStaffPhonenumber);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtStaffEmail);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtStaffFirstname);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(439, 142);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Staff information";
            // 
            // cboStaffGender
            // 
            cboStaffGender.Enabled = false;
            cboStaffGender.FormattingEnabled = true;
            cboStaffGender.Items.AddRange(new object[] { "Male", "Female" });
            cboStaffGender.Location = new System.Drawing.Point(57, 98);
            cboStaffGender.Name = "cboStaffGender";
            cboStaffGender.Size = new System.Drawing.Size(96, 23);
            cboStaffGender.TabIndex = 13;
            // 
            // dgvCageList
            // 
            dgvCageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCageList.Location = new System.Drawing.Point(12, 352);
            dgvCageList.Name = "dgvCageList";
            dgvCageList.ReadOnly = true;
            dgvCageList.RowTemplate.Height = 25;
            dgvCageList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCageList.Size = new System.Drawing.Size(645, 161);
            dgvCageList.TabIndex = 15;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboCageStatus);
            groupBox2.Controls.Add(txtCageStaffID);
            groupBox2.Controls.Add(txtCageAreaID);
            groupBox2.Controls.Add(txtCageID);
            groupBox2.Controls.Add(txtCageName);
            groupBox2.Controls.Add(txtCageQuantity);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new System.Drawing.Point(12, 193);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(439, 139);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cage Information";
            // 
            // cboCageStatus
            // 
            cboCageStatus.Enabled = false;
            cboCageStatus.FormattingEnabled = true;
            cboCageStatus.Location = new System.Drawing.Point(313, 22);
            cboCageStatus.Name = "cboCageStatus";
            cboCageStatus.Size = new System.Drawing.Size(100, 23);
            cboCageStatus.TabIndex = 12;
            // 
            // txtCageStaffID
            // 
            txtCageStaffID.Location = new System.Drawing.Point(313, 87);
            txtCageStaffID.Name = "txtCageStaffID";
            txtCageStaffID.ReadOnly = true;
            txtCageStaffID.Size = new System.Drawing.Size(100, 23);
            txtCageStaffID.TabIndex = 11;
            // 
            // txtCageAreaID
            // 
            txtCageAreaID.Location = new System.Drawing.Point(313, 54);
            txtCageAreaID.Name = "txtCageAreaID";
            txtCageAreaID.ReadOnly = true;
            txtCageAreaID.Size = new System.Drawing.Size(100, 23);
            txtCageAreaID.TabIndex = 10;
            // 
            // txtCageID
            // 
            txtCageID.Location = new System.Drawing.Point(98, 21);
            txtCageID.Name = "txtCageID";
            txtCageID.ReadOnly = true;
            txtCageID.Size = new System.Drawing.Size(122, 23);
            txtCageID.TabIndex = 9;
            // 
            // txtCageName
            // 
            txtCageName.Location = new System.Drawing.Point(98, 54);
            txtCageName.Name = "txtCageName";
            txtCageName.ReadOnly = true;
            txtCageName.Size = new System.Drawing.Size(122, 23);
            txtCageName.TabIndex = 8;
            // 
            // txtCageQuantity
            // 
            txtCageQuantity.Location = new System.Drawing.Point(98, 87);
            txtCageQuantity.Name = "txtCageQuantity";
            txtCageQuantity.ReadOnly = true;
            txtCageQuantity.Size = new System.Drawing.Size(122, 23);
            txtCageQuantity.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(262, 95);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(45, 15);
            label12.TabIndex = 6;
            label12.Text = "Staff ID";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(262, 62);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(45, 15);
            label11.TabIndex = 5;
            label11.Text = "Area ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(262, 29);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(39, 15);
            label9.TabIndex = 3;
            label9.Text = "Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(13, 95);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(71, 15);
            label8.TabIndex = 2;
            label8.Text = "Total animal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(13, 62);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(39, 15);
            label5.TabIndex = 1;
            label5.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(13, 29);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(48, 15);
            label3.TabIndex = 0;
            label3.Text = "Cage ID";
            // 
            // frmStaff
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(669, 525);
            Controls.Add(groupBox2);
            Controls.Add(dgvCageList);
            Controls.Add(groupBox1);
            Name = "frmStaff";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmStaff";
            Load += frmStaff_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCageList).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtStaffFirstname;
        private System.Windows.Forms.TextBox txtCageAreaID;
        private System.Windows.Forms.TextBox txtStaffEmail;
        private System.Windows.Forms.TextBox txtStaffPhonenumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCageList;
        private System.Windows.Forms.ComboBox cboStaffGender;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCageQuantity;
        private System.Windows.Forms.ComboBox cboCageStatus;
        private System.Windows.Forms.TextBox txtCageStaffID;
        private System.Windows.Forms.TextBox txtCageID;
        private System.Windows.Forms.TextBox txtCageName;
    }
}