﻿namespace ZooManagementWinApp
{
    partial class frmAnimal
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
            label8 = new System.Windows.Forms.Label();
            txtAnimalID = new System.Windows.Forms.TextBox();
            txtAnimalName = new System.Windows.Forms.TextBox();
            txtAnimalGender = new System.Windows.Forms.TextBox();
            txtAnimalSpecie = new System.Windows.Forms.TextBox();
            txtAnimalStatus = new System.Windows.Forms.TextBox();
            cboAnimalCage = new System.Windows.Forms.ComboBox();
            txtAnimalDOB = new System.Windows.Forms.DateTimePicker();
            txtAnimalDEZ = new System.Windows.Forms.DateTimePicker();
            dgvAnimalList = new System.Windows.Forms.DataGridView();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnAdd = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnMoveCage = new System.Windows.Forms.Button();
            btnViewMeal = new System.Windows.Forms.Button();
            btnCreateLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvAnimalList).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(27, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(27, 70);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(27, 114);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "Date of birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(27, 158);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(83, 15);
            label4.TabIndex = 3;
            label4.Text = "Date enter zoo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(414, 33);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(45, 15);
            label5.TabIndex = 4;
            label5.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(414, 70);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(41, 15);
            label6.TabIndex = 5;
            label6.Text = "Specie";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(414, 114);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(39, 15);
            label7.TabIndex = 6;
            label7.Text = "Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(414, 161);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(34, 15);
            label8.TabIndex = 7;
            label8.Text = "Cage";
            // 
            // txtAnimalID
            // 
            txtAnimalID.Location = new System.Drawing.Point(120, 22);
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.ReadOnly = true;
            txtAnimalID.Size = new System.Drawing.Size(200, 23);
            txtAnimalID.TabIndex = 8;
            // 
            // txtAnimalName
            // 
            txtAnimalName.Location = new System.Drawing.Point(120, 62);
            txtAnimalName.Name = "txtAnimalName";
            txtAnimalName.ReadOnly = true;
            txtAnimalName.Size = new System.Drawing.Size(200, 23);
            txtAnimalName.TabIndex = 9;
            // 
            // txtAnimalGender
            // 
            txtAnimalGender.Location = new System.Drawing.Point(480, 25);
            txtAnimalGender.Name = "txtAnimalGender";
            txtAnimalGender.ReadOnly = true;
            txtAnimalGender.Size = new System.Drawing.Size(208, 23);
            txtAnimalGender.TabIndex = 10;
            // 
            // txtAnimalSpecie
            // 
            txtAnimalSpecie.Location = new System.Drawing.Point(480, 62);
            txtAnimalSpecie.Name = "txtAnimalSpecie";
            txtAnimalSpecie.ReadOnly = true;
            txtAnimalSpecie.Size = new System.Drawing.Size(208, 23);
            txtAnimalSpecie.TabIndex = 11;
            // 
            // txtAnimalStatus
            // 
            txtAnimalStatus.Location = new System.Drawing.Point(480, 106);
            txtAnimalStatus.Name = "txtAnimalStatus";
            txtAnimalStatus.ReadOnly = true;
            txtAnimalStatus.Size = new System.Drawing.Size(208, 23);
            txtAnimalStatus.TabIndex = 12;
            // 
            // cboAnimalCage
            // 
            cboAnimalCage.Enabled = false;
            cboAnimalCage.FormattingEnabled = true;
            cboAnimalCage.Location = new System.Drawing.Point(480, 153);
            cboAnimalCage.Name = "cboAnimalCage";
            cboAnimalCage.Size = new System.Drawing.Size(208, 23);
            cboAnimalCage.TabIndex = 13;
            // 
            // txtAnimalDOB
            // 
            txtAnimalDOB.Enabled = false;
            txtAnimalDOB.Location = new System.Drawing.Point(120, 106);
            txtAnimalDOB.Name = "txtAnimalDOB";
            txtAnimalDOB.Size = new System.Drawing.Size(200, 23);
            txtAnimalDOB.TabIndex = 14;
            // 
            // txtAnimalDEZ
            // 
            txtAnimalDEZ.Enabled = false;
            txtAnimalDEZ.Location = new System.Drawing.Point(120, 150);
            txtAnimalDEZ.Name = "txtAnimalDEZ";
            txtAnimalDEZ.Size = new System.Drawing.Size(200, 23);
            txtAnimalDEZ.TabIndex = 15;
            // 
            // dgvAnimalList
            // 
            dgvAnimalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimalList.Location = new System.Drawing.Point(11, 293);
            dgvAnimalList.Name = "dgvAnimalList";
            dgvAnimalList.ReadOnly = true;
            dgvAnimalList.RowHeadersWidth = 62;
            dgvAnimalList.RowTemplate.Height = 25;
            dgvAnimalList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAnimalList.Size = new System.Drawing.Size(841, 196);
            dgvAnimalList.TabIndex = 16;
            dgvAnimalList.CellDoubleClick += dgvAnimalList_CellDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAnimalDEZ);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cboAnimalCage);
            groupBox1.Controls.Add(txtAnimalStatus);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtAnimalSpecie);
            groupBox1.Controls.Add(txtAnimalDOB);
            groupBox1.Controls.Add(txtAnimalGender);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtAnimalID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtAnimalName);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new System.Drawing.Point(39, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(761, 210);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Animal Information";
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(219, 252);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(75, 23);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(381, 253);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(75, 23);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnMoveCage
            // 
            btnMoveCage.Location = new System.Drawing.Point(554, 255);
            btnMoveCage.Name = "btnMoveCage";
            btnMoveCage.Size = new System.Drawing.Size(75, 23);
            btnMoveCage.TabIndex = 20;
            btnMoveCage.Text = "Move animal";
            btnMoveCage.UseVisualStyleBackColor = true;
            btnMoveCage.Click += btnMoveCage_Click;
            // 
            // btnViewMeal
            // 
            btnViewMeal.Location = new System.Drawing.Point(61, 253);
            btnViewMeal.Margin = new System.Windows.Forms.Padding(2);
            btnViewMeal.Name = "btnViewMeal";
            btnViewMeal.Size = new System.Drawing.Size(78, 20);
            btnViewMeal.TabIndex = 21;
            btnViewMeal.Text = "View Meal";
            btnViewMeal.UseVisualStyleBackColor = true;
            btnViewMeal.Click += btnViewMeal_Click;
            // 
            // btnCreateLog
            // 
            btnCreateLog.Location = new System.Drawing.Point(715, 255);
            btnCreateLog.Name = "btnCreateLog";
            btnCreateLog.Size = new System.Drawing.Size(75, 23);
            btnCreateLog.TabIndex = 22;
            btnCreateLog.Text = "Create log";
            btnCreateLog.UseVisualStyleBackColor = true;
            btnCreateLog.Click += btnCreateLog_Click;
            // 
            // frmAnimal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(864, 501);
            Controls.Add(btnCreateLog);
            Controls.Add(btnViewMeal);
            Controls.Add(btnMoveCage);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(groupBox1);
            Controls.Add(dgvAnimalList);
            Name = "frmAnimal";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Animal";
            Load += frmAnimal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnimalList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAnimalID;
        private System.Windows.Forms.TextBox txtAnimalName;
        private System.Windows.Forms.TextBox txtAnimalGender;
        private System.Windows.Forms.TextBox txtAnimalSpecie;
        private System.Windows.Forms.TextBox txtAnimalStatus;
        private System.Windows.Forms.ComboBox cboAnimalCage;
        private System.Windows.Forms.DateTimePicker txtAnimalDOB;
        private System.Windows.Forms.DateTimePicker txtAnimalDEZ;
        private System.Windows.Forms.DataGridView dgvAnimalList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMoveCage;
        private System.Windows.Forms.Button btnViewMeal;
        private System.Windows.Forms.Button btnCreateLog;
    }
}