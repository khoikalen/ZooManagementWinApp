﻿namespace ZooManagementWinApp
{
    partial class frmCageDetail
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
            lbCageID = new System.Windows.Forms.Label();
            lbCageName = new System.Windows.Forms.Label();
            lbCageQuantity = new System.Windows.Forms.Label();
            lbCageStatus = new System.Windows.Forms.Label();
            lbCageType = new System.Windows.Forms.Label();
            lbAreaId = new System.Windows.Forms.Label();
            lbStaffId = new System.Windows.Forms.Label();
            txtCageID = new System.Windows.Forms.TextBox();
            txtCageName = new System.Windows.Forms.TextBox();
            txtCageQuantity = new System.Windows.Forms.TextBox();
            cboAreaId = new System.Windows.Forms.ComboBox();
            cboStaffId = new System.Windows.Forms.ComboBox();
            cboCageStatus = new System.Windows.Forms.ComboBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lbCageID
            // 
            lbCageID.AutoSize = true;
            lbCageID.Location = new System.Drawing.Point(25, 86);
            lbCageID.Name = "lbCageID";
            lbCageID.Size = new System.Drawing.Size(62, 20);
            lbCageID.TabIndex = 0;
            lbCageID.Text = "Cage ID";
            // 
            // lbCageName
            // 
            lbCageName.AutoSize = true;
            lbCageName.Location = new System.Drawing.Point(25, 144);
            lbCageName.Name = "lbCageName";
            lbCageName.Size = new System.Drawing.Size(87, 20);
            lbCageName.TabIndex = 1;
            lbCageName.Text = "Cage Name";
            // 
            // lbCageQuantity
            // 
            lbCageQuantity.AutoSize = true;
            lbCageQuantity.Location = new System.Drawing.Point(25, 208);
            lbCageQuantity.Name = "lbCageQuantity";
            lbCageQuantity.Size = new System.Drawing.Size(103, 20);
            lbCageQuantity.TabIndex = 2;
            lbCageQuantity.Text = "Cage Quantity";
            // 
            // lbCageStatus
            // 
            lbCageStatus.AutoSize = true;
            lbCageStatus.Location = new System.Drawing.Point(362, 86);
            lbCageStatus.Name = "lbCageStatus";
            lbCageStatus.Size = new System.Drawing.Size(87, 20);
            lbCageStatus.TabIndex = 3;
            lbCageStatus.Text = "Cage Status";
            // 
            // lbCageType
            // 
            lbCageType.AutoSize = true;
            lbCageType.Location = new System.Drawing.Point(362, 86);
            lbCageType.Name = "lbCageType";
            lbCageType.Size = new System.Drawing.Size(0, 20);
            lbCageType.TabIndex = 4;
            // 
            // lbAreaId
            // 
            lbAreaId.AutoSize = true;
            lbAreaId.Location = new System.Drawing.Point(362, 144);
            lbAreaId.Name = "lbAreaId";
            lbAreaId.Size = new System.Drawing.Size(40, 20);
            lbAreaId.TabIndex = 5;
            lbAreaId.Text = "Area";
            // 
            // lbStaffId
            // 
            lbStaffId.AutoSize = true;
            lbStaffId.Location = new System.Drawing.Point(362, 208);
            lbStaffId.Name = "lbStaffId";
            lbStaffId.Size = new System.Drawing.Size(40, 20);
            lbStaffId.TabIndex = 6;
            lbStaffId.Text = "Staff";
            // 
            // txtCageID
            // 
            txtCageID.Location = new System.Drawing.Point(142, 83);
            txtCageID.Name = "txtCageID";
            txtCageID.Size = new System.Drawing.Size(175, 27);
            txtCageID.TabIndex = 7;
            // 
            // txtCageName
            // 
            txtCageName.Location = new System.Drawing.Point(142, 142);
            txtCageName.Name = "txtCageName";
            txtCageName.Size = new System.Drawing.Size(175, 27);
            txtCageName.TabIndex = 8;
            // 
            // txtCageQuantity
            // 
            txtCageQuantity.Location = new System.Drawing.Point(142, 206);
            txtCageQuantity.Name = "txtCageQuantity";
            txtCageQuantity.Size = new System.Drawing.Size(175, 27);
            txtCageQuantity.TabIndex = 9;
            // 
            // cboAreaId
            // 
            cboAreaId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboAreaId.FormattingEnabled = true;
            cboAreaId.Location = new System.Drawing.Point(473, 142);
            cboAreaId.Name = "cboAreaId";
            cboAreaId.Size = new System.Drawing.Size(207, 28);
            cboAreaId.TabIndex = 12;
            // 
            // cboStaffId
            // 
            cboStaffId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboStaffId.FormattingEnabled = true;
            cboStaffId.Location = new System.Drawing.Point(473, 206);
            cboStaffId.Name = "cboStaffId";
            cboStaffId.Size = new System.Drawing.Size(207, 28);
            cboStaffId.TabIndex = 13;
            // 
            // cboCageStatus
            // 
            cboCageStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboCageStatus.FormattingEnabled = true;
            cboCageStatus.Items.AddRange(new object[] { "Owned", "Empty" });
            cboCageStatus.Location = new System.Drawing.Point(473, 83);
            cboCageStatus.Name = "cboCageStatus";
            cboCageStatus.Size = new System.Drawing.Size(207, 28);
            cboCageStatus.TabIndex = 14;
            cboCageStatus.SelectedIndexChanged += cboCageStatus_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(243, 268);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 29);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(377, 268);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(262, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(177, 37);
            label1.TabIndex = 17;
            label1.Text = "Cage Details";
            // 
            // frmCageDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(715, 313);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cboCageStatus);
            Controls.Add(cboStaffId);
            Controls.Add(cboAreaId);
            Controls.Add(txtCageQuantity);
            Controls.Add(txtCageName);
            Controls.Add(txtCageID);
            Controls.Add(lbStaffId);
            Controls.Add(lbAreaId);
            Controls.Add(lbCageType);
            Controls.Add(lbCageStatus);
            Controls.Add(lbCageQuantity);
            Controls.Add(lbCageName);
            Controls.Add(lbCageID);
            Name = "frmCageDetail";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form Cage Details";
            Load += frmCageDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbCageID;
        private System.Windows.Forms.Label lbCageName;
        private System.Windows.Forms.Label lbCageQuantity;
        private System.Windows.Forms.Label lbCageStatus;
        private System.Windows.Forms.Label lbCageType;
        private System.Windows.Forms.Label lbAreaId;
        private System.Windows.Forms.Label lbStaffId;
        private System.Windows.Forms.TextBox txtCageID;
        private System.Windows.Forms.TextBox txtCageName;
        private System.Windows.Forms.TextBox txtCageQuantity;
        private System.Windows.Forms.ComboBox cboAreaId;
        private System.Windows.Forms.ComboBox cboStaffId;
        private System.Windows.Forms.ComboBox cboCageStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
    }
}