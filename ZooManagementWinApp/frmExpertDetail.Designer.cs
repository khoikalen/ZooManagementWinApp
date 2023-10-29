namespace ZooManagementWinApp
{
    partial class frmExpertDetail
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
            cboGender = new System.Windows.Forms.ComboBox();
            btnCancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            txtPassword = new System.Windows.Forms.TextBox();
            txtPhoneNumber = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtLastName = new System.Windows.Forms.TextBox();
            txtFirstName = new System.Windows.Forms.TextBox();
            txtExpertID = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            dtpStartDay = new System.Windows.Forms.DateTimePicker();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            cboAreaID = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // cboGender
            // 
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cboGender.Location = new System.Drawing.Point(157, 267);
            cboGender.Name = "cboGender";
            cboGender.Size = new System.Drawing.Size(183, 28);
            cboGender.TabIndex = 36;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(388, 369);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 35;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(246, 369);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 29);
            btnSave.TabIndex = 34;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(502, 195);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(220, 27);
            txtPassword.TabIndex = 33;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new System.Drawing.Point(502, 140);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new System.Drawing.Size(220, 27);
            txtPhoneNumber.TabIndex = 32;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(502, 73);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(220, 27);
            txtEmail.TabIndex = 31;
            // 
            // txtLastName
            // 
            txtLastName.Location = new System.Drawing.Point(157, 206);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new System.Drawing.Size(183, 27);
            txtLastName.TabIndex = 30;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new System.Drawing.Point(157, 139);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new System.Drawing.Size(183, 27);
            txtFirstName.TabIndex = 29;
            // 
            // txtExpertID
            // 
            txtExpertID.Location = new System.Drawing.Point(157, 73);
            txtExpertID.Name = "txtExpertID";
            txtExpertID.Size = new System.Drawing.Size(183, 27);
            txtExpertID.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(388, 202);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(70, 20);
            label8.TabIndex = 27;
            label8.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(388, 143);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(108, 20);
            label7.TabIndex = 26;
            label7.Text = "Phone Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(388, 76);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(46, 20);
            label6.TabIndex = 25;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(201, 320);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(70, 20);
            label5.TabIndex = 24;
            label5.Text = "Start Day";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(48, 270);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(57, 20);
            label4.TabIndex = 23;
            label4.Text = "Gender";
            // 
            // dtpStartDay
            // 
            dtpStartDay.Location = new System.Drawing.Point(315, 315);
            dtpStartDay.Name = "dtpStartDay";
            dtpStartDay.Size = new System.Drawing.Size(250, 27);
            dtpStartDay.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(48, 213);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 20);
            label3.TabIndex = 21;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(48, 146);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 20);
            label2.TabIndex = 20;
            label2.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(48, 76);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(70, 20);
            label1.TabIndex = 19;
            label1.Text = "Expert ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(388, 270);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(59, 20);
            label9.TabIndex = 37;
            label9.Text = "Area ID";
            // 
            // cboAreaID
            // 
            cboAreaID.FormattingEnabled = true;
            cboAreaID.Location = new System.Drawing.Point(502, 267);
            cboAreaID.Name = "cboAreaID";
            cboAreaID.Size = new System.Drawing.Size(220, 28);
            cboAreaID.TabIndex = 38;
            // 
            // frmExpertDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(cboAreaID);
            Controls.Add(label9);
            Controls.Add(cboGender);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPassword);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtExpertID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpStartDay);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmExpertDetail";
            Text = "frmExpertDetail";
            Load += frmExpertDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtExpertID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpStartDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboAreaID;
    }
}