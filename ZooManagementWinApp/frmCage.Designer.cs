namespace ZooManagementWinApp
{
    partial class frmCage
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
            dgvCageManagement = new System.Windows.Forms.DataGridView();
            groupBox2 = new System.Windows.Forms.GroupBox();
            txtCageStatus = new System.Windows.Forms.TextBox();
            txtCageQuantity = new System.Windows.Forms.TextBox();
            txtCageName = new System.Windows.Forms.TextBox();
            txtCagePrimaryID = new System.Windows.Forms.TextBox();
            lbCageStatus = new System.Windows.Forms.Label();
            lbCageQuantity = new System.Windows.Forms.Label();
            lbCageName = new System.Windows.Forms.Label();
            lbCageId = new System.Windows.Forms.Label();
            btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvCageManagement).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCageManagement
            // 
            dgvCageManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCageManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCageManagement.Location = new System.Drawing.Point(12, 116);
            dgvCageManagement.Name = "dgvCageManagement";
            dgvCageManagement.ReadOnly = true;
            dgvCageManagement.RowHeadersWidth = 51;
            dgvCageManagement.RowTemplate.Height = 29;
            dgvCageManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCageManagement.Size = new System.Drawing.Size(467, 168);
            dgvCageManagement.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCageStatus);
            groupBox2.Controls.Add(txtCageQuantity);
            groupBox2.Controls.Add(txtCageName);
            groupBox2.Controls.Add(txtCagePrimaryID);
            groupBox2.Controls.Add(lbCageStatus);
            groupBox2.Controls.Add(lbCageQuantity);
            groupBox2.Controls.Add(lbCageName);
            groupBox2.Controls.Add(lbCageId);
            groupBox2.Location = new System.Drawing.Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(467, 110);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Null Cage ";
            // 
            // txtCageStatus
            // 
            txtCageStatus.Location = new System.Drawing.Point(325, 24);
            txtCageStatus.Name = "txtCageStatus";
            txtCageStatus.ReadOnly = true;
            txtCageStatus.Size = new System.Drawing.Size(125, 23);
            txtCageStatus.TabIndex = 10;
            // 
            // txtCageQuantity
            // 
            txtCageQuantity.Location = new System.Drawing.Point(325, 63);
            txtCageQuantity.Name = "txtCageQuantity";
            txtCageQuantity.ReadOnly = true;
            txtCageQuantity.Size = new System.Drawing.Size(125, 23);
            txtCageQuantity.TabIndex = 9;
            // 
            // txtCageName
            // 
            txtCageName.Location = new System.Drawing.Point(97, 63);
            txtCageName.Name = "txtCageName";
            txtCageName.ReadOnly = true;
            txtCageName.Size = new System.Drawing.Size(125, 23);
            txtCageName.TabIndex = 8;
            // 
            // txtCagePrimaryID
            // 
            txtCagePrimaryID.Location = new System.Drawing.Point(97, 24);
            txtCagePrimaryID.Name = "txtCagePrimaryID";
            txtCagePrimaryID.ReadOnly = true;
            txtCagePrimaryID.Size = new System.Drawing.Size(125, 23);
            txtCagePrimaryID.TabIndex = 7;
            // 
            // lbCageStatus
            // 
            lbCageStatus.AutoSize = true;
            lbCageStatus.Location = new System.Drawing.Point(236, 32);
            lbCageStatus.Name = "lbCageStatus";
            lbCageStatus.Size = new System.Drawing.Size(69, 15);
            lbCageStatus.TabIndex = 3;
            lbCageStatus.Text = "Cage Status";
            // 
            // lbCageQuantity
            // 
            lbCageQuantity.AutoSize = true;
            lbCageQuantity.Location = new System.Drawing.Point(236, 71);
            lbCageQuantity.Name = "lbCageQuantity";
            lbCageQuantity.Size = new System.Drawing.Size(83, 15);
            lbCageQuantity.TabIndex = 2;
            lbCageQuantity.Text = "Cage Quantity";
            // 
            // lbCageName
            // 
            lbCageName.AutoSize = true;
            lbCageName.Location = new System.Drawing.Point(8, 71);
            lbCageName.Name = "lbCageName";
            lbCageName.Size = new System.Drawing.Size(69, 15);
            lbCageName.TabIndex = 1;
            lbCageName.Text = "Cage Name";
            // 
            // lbCageId
            // 
            lbCageId.AutoSize = true;
            lbCageId.Location = new System.Drawing.Point(8, 32);
            lbCageId.Name = "lbCageId";
            lbCageId.Size = new System.Drawing.Size(48, 15);
            lbCageId.TabIndex = 0;
            lbCageId.Text = "Cage ID";
            // 
            // btnSelect
            // 
            btnSelect.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSelect.Location = new System.Drawing.Point(208, 299);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new System.Drawing.Size(75, 23);
            btnSelect.TabIndex = 6;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // frmCage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(492, 330);
            Controls.Add(btnSelect);
            Controls.Add(dgvCageManagement);
            Controls.Add(groupBox2);
            Name = "frmCage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmCage";
            Load += frmCage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCageManagement).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCageManagement;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCageStatus;
        private System.Windows.Forms.TextBox txtCageQuantity;
        private System.Windows.Forms.TextBox txtCageName;
        private System.Windows.Forms.TextBox txtCagePrimaryID;
        private System.Windows.Forms.Label lbCageStatus;
        private System.Windows.Forms.Label lbCageQuantity;
        private System.Windows.Forms.Label lbCageName;
        private System.Windows.Forms.Label lbCageId;
        private System.Windows.Forms.Button btnSelect;
    }
}