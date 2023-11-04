namespace ZooManagementWinApp
{
    partial class frmTradeCage
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
            dgvCage = new System.Windows.Forms.DataGridView();
            cboCage = new System.Windows.Forms.ComboBox();
            lbCage = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            cboStaff = new System.Windows.Forms.ComboBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvCage).BeginInit();
            SuspendLayout();
            // 
            // dgvCage
            // 
            dgvCage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCage.Location = new System.Drawing.Point(1, 237);
            dgvCage.Name = "dgvCage";
            dgvCage.ReadOnly = true;
            dgvCage.RowHeadersWidth = 51;
            dgvCage.RowTemplate.Height = 29;
            dgvCage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCage.Size = new System.Drawing.Size(666, 201);
            dgvCage.TabIndex = 0;
            // 
            // cboCage
            // 
            cboCage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboCage.FormattingEnabled = true;
            cboCage.Location = new System.Drawing.Point(275, 68);
            cboCage.Name = "cboCage";
            cboCage.Size = new System.Drawing.Size(212, 28);
            cboCage.TabIndex = 1;
            // 
            // lbCage
            // 
            lbCage.AutoSize = true;
            lbCage.Location = new System.Drawing.Point(141, 71);
            lbCage.Name = "lbCage";
            lbCage.Size = new System.Drawing.Size(43, 20);
            lbCage.TabIndex = 2;
            lbCage.Text = "Cage";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(141, 137);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(108, 20);
            label1.TabIndex = 3;
            label1.Text = "Assign for staff";
            // 
            // cboStaff
            // 
            cboStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboStaff.FormattingEnabled = true;
            cboStaff.Location = new System.Drawing.Point(275, 129);
            cboStaff.Name = "cboStaff";
            cboStaff.Size = new System.Drawing.Size(212, 28);
            cboStaff.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(215, 187);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 29);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(363, 187);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(237, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(172, 37);
            label2.TabIndex = 7;
            label2.Text = "Assign Cage";
            // 
            // frmTradeCage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(670, 451);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cboStaff);
            Controls.Add(label1);
            Controls.Add(lbCage);
            Controls.Add(cboCage);
            Controls.Add(dgvCage);
            Name = "frmTradeCage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form Assign Cage";
            Load += frmTradeCage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCage;
        private System.Windows.Forms.ComboBox cboCage;
        private System.Windows.Forms.Label lbCage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStaff;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
    }
}