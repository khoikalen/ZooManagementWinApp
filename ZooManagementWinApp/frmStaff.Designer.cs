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
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            txtStaffID = new System.Windows.Forms.TextBox();
            txtStaffFirstname = new System.Windows.Forms.TextBox();
            txtStaffLastName = new System.Windows.Forms.TextBox();
            txtStaffEmail = new System.Windows.Forms.TextBox();
            txtStaffPhonenumber = new System.Windows.Forms.TextBox();
            txtStaffStartDay = new System.Windows.Forms.DateTimePicker();
            groupBox1 = new System.Windows.Forms.GroupBox();
            dgvStaffList = new System.Windows.Forms.DataGridView();
            txtStaffGender = new System.Windows.Forms.TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaffList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(26, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(26, 68);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Firstname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(26, 106);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Lastname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(26, 149);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(358, 30);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(50, 15);
            label5.TabIndex = 4;
            label5.Text = "Startday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(358, 68);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(36, 15);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(358, 106);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(86, 15);
            label7.TabIndex = 6;
            label7.Text = "Phone number";
            // 
            // txtStaffID
            // 
            txtStaffID.Location = new System.Drawing.Point(89, 22);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new System.Drawing.Size(197, 23);
            txtStaffID.TabIndex = 7;
            // 
            // txtStaffFirstname
            // 
            txtStaffFirstname.Location = new System.Drawing.Point(89, 60);
            txtStaffFirstname.Name = "txtStaffFirstname";
            txtStaffFirstname.Size = new System.Drawing.Size(197, 23);
            txtStaffFirstname.TabIndex = 8;
            // 
            // txtStaffLastName
            // 
            txtStaffLastName.Location = new System.Drawing.Point(89, 98);
            txtStaffLastName.Name = "txtStaffLastName";
            txtStaffLastName.Size = new System.Drawing.Size(197, 23);
            txtStaffLastName.TabIndex = 9;
            // 
            // txtStaffEmail
            // 
            txtStaffEmail.Location = new System.Drawing.Point(458, 60);
            txtStaffEmail.Name = "txtStaffEmail";
            txtStaffEmail.Size = new System.Drawing.Size(200, 23);
            txtStaffEmail.TabIndex = 11;
            // 
            // txtStaffPhonenumber
            // 
            txtStaffPhonenumber.Location = new System.Drawing.Point(458, 98);
            txtStaffPhonenumber.Name = "txtStaffPhonenumber";
            txtStaffPhonenumber.Size = new System.Drawing.Size(200, 23);
            txtStaffPhonenumber.TabIndex = 12;
            // 
            // txtStaffStartDay
            // 
            txtStaffStartDay.Location = new System.Drawing.Point(458, 24);
            txtStaffStartDay.Name = "txtStaffStartDay";
            txtStaffStartDay.Size = new System.Drawing.Size(200, 23);
            txtStaffStartDay.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtStaffID);
            groupBox1.Controls.Add(txtStaffPhonenumber);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtStaffStartDay);
            groupBox1.Controls.Add(txtStaffEmail);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtStaffFirstname);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtStaffGender);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtStaffLastName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new System.Drawing.Point(46, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(720, 178);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Staff information";
            // 
            // dgvStaffList
            // 
            dgvStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaffList.Location = new System.Drawing.Point(12, 277);
            dgvStaffList.Name = "dgvStaffList";
            dgvStaffList.ReadOnly = true;
            dgvStaffList.RowTemplate.Height = 25;
            dgvStaffList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvStaffList.Size = new System.Drawing.Size(776, 161);
            dgvStaffList.TabIndex = 15;
            // 
            // txtStaffGender
            // 
            txtStaffGender.Location = new System.Drawing.Point(89, 141);
            txtStaffGender.Name = "txtStaffGender";
            txtStaffGender.Size = new System.Drawing.Size(197, 23);
            txtStaffGender.TabIndex = 10;
            // 
            // frmStaff
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dgvStaffList);
            Controls.Add(groupBox1);
            Name = "frmStaff";
            Text = "frmStaff";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaffList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtStaffFirstname;
        private System.Windows.Forms.TextBox txtStaffLastName;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtStaffEmail;
        private System.Windows.Forms.TextBox txtStaffPhonenumber;
        private System.Windows.Forms.DateTimePicker txtStaffStartDay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvStaffList;
        private System.Windows.Forms.TextBox txtStaffGender;
    }
}