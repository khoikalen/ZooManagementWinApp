namespace ZooManagementWinApp
{
    partial class frmAnimalDetail
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
            txtAnimalName = new System.Windows.Forms.TextBox();
            txtAnimalGender = new System.Windows.Forms.TextBox();
            txtAnimalSpecie = new System.Windows.Forms.TextBox();
            txtAnimalStatus = new System.Windows.Forms.TextBox();
            cboAnimalCage = new System.Windows.Forms.ComboBox();
            txtAnimalDOB = new System.Windows.Forms.DateTimePicker();
            txtAnimalDEZ = new System.Windows.Forms.DateTimePicker();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(37, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(37, 79);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "Date of birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(37, 139);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(83, 15);
            label3.TabIndex = 2;
            label3.Text = "Date enter zoo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(37, 197);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(389, 23);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(41, 15);
            label5.TabIndex = 4;
            label5.Text = "Specie";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(389, 79);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(39, 15);
            label6.TabIndex = 5;
            label6.Text = "Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(389, 139);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(34, 15);
            label7.TabIndex = 6;
            label7.Text = "Cage";
            // 
            // txtAnimalName
            // 
            txtAnimalName.Location = new System.Drawing.Point(137, 15);
            txtAnimalName.Name = "txtAnimalName";
            txtAnimalName.Size = new System.Drawing.Size(200, 23);
            txtAnimalName.TabIndex = 7;
            // 
            // txtAnimalGender
            // 
            txtAnimalGender.Location = new System.Drawing.Point(137, 189);
            txtAnimalGender.Name = "txtAnimalGender";
            txtAnimalGender.Size = new System.Drawing.Size(200, 23);
            txtAnimalGender.TabIndex = 8;
            // 
            // txtAnimalSpecie
            // 
            txtAnimalSpecie.Location = new System.Drawing.Point(474, 20);
            txtAnimalSpecie.Name = "txtAnimalSpecie";
            txtAnimalSpecie.Size = new System.Drawing.Size(185, 23);
            txtAnimalSpecie.TabIndex = 9;
            // 
            // txtAnimalStatus
            // 
            txtAnimalStatus.Location = new System.Drawing.Point(474, 76);
            txtAnimalStatus.Name = "txtAnimalStatus";
            txtAnimalStatus.Size = new System.Drawing.Size(185, 23);
            txtAnimalStatus.TabIndex = 10;
            // 
            // cboAnimalCage
            // 
            cboAnimalCage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboAnimalCage.FormattingEnabled = true;
            cboAnimalCage.Location = new System.Drawing.Point(474, 131);
            cboAnimalCage.Name = "cboAnimalCage";
            cboAnimalCage.Size = new System.Drawing.Size(185, 23);
            cboAnimalCage.TabIndex = 11;
            // 
            // txtAnimalDOB
            // 
            txtAnimalDOB.Location = new System.Drawing.Point(137, 71);
            txtAnimalDOB.Name = "txtAnimalDOB";
            txtAnimalDOB.Size = new System.Drawing.Size(200, 23);
            txtAnimalDOB.TabIndex = 12;
            // 
            // txtAnimalDEZ
            // 
            txtAnimalDEZ.Location = new System.Drawing.Point(137, 133);
            txtAnimalDEZ.Name = "txtAnimalDEZ";
            txtAnimalDEZ.Size = new System.Drawing.Size(200, 23);
            txtAnimalDEZ.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(238, 238);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(75, 23);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(389, 238);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 23);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAnimalDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(703, 273);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtAnimalDEZ);
            Controls.Add(txtAnimalDOB);
            Controls.Add(cboAnimalCage);
            Controls.Add(txtAnimalStatus);
            Controls.Add(txtAnimalSpecie);
            Controls.Add(txtAnimalGender);
            Controls.Add(txtAnimalName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAnimalDetail";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmAnimalDetail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAnimalName;
        private System.Windows.Forms.TextBox txtAnimalGender;
        private System.Windows.Forms.TextBox txtAnimalSpecie;
        private System.Windows.Forms.TextBox txtAnimalStatus;
        private System.Windows.Forms.ComboBox cboAnimalCage;
        private System.Windows.Forms.DateTimePicker txtAnimalDOB;
        private System.Windows.Forms.DateTimePicker txtAnimalDEZ;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}