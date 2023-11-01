namespace ZooManagementWinApp
{
    partial class frmCageDetailMovingAnimal
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
            txtCageID = new System.Windows.Forms.TextBox();
            txtCageName = new System.Windows.Forms.TextBox();
            txtCageQuantity = new System.Windows.Forms.TextBox();
            txtCageStaff = new System.Windows.Forms.TextBox();
            txtCageStatus = new System.Windows.Forms.TextBox();
            txtCageArea = new System.Windows.Forms.TextBox();
            btnCancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Cage ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(13, 76);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Cage name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(13, 139);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(81, 15);
            label3.TabIndex = 2;
            label3.Text = "Cage quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(261, 18);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(68, 15);
            label4.TabIndex = 3;
            label4.Text = "Cage status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(261, 76);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(31, 15);
            label5.TabIndex = 4;
            label5.Text = "Area";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(261, 139);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(31, 15);
            label6.TabIndex = 5;
            label6.Text = "Staff";
            // 
            // txtCageID
            // 
            txtCageID.Location = new System.Drawing.Point(100, 10);
            txtCageID.Name = "txtCageID";
            txtCageID.ReadOnly = true;
            txtCageID.Size = new System.Drawing.Size(135, 23);
            txtCageID.TabIndex = 6;
            // 
            // txtCageName
            // 
            txtCageName.Location = new System.Drawing.Point(100, 68);
            txtCageName.Name = "txtCageName";
            txtCageName.Size = new System.Drawing.Size(135, 23);
            txtCageName.TabIndex = 7;
            // 
            // txtCageQuantity
            // 
            txtCageQuantity.Location = new System.Drawing.Point(100, 131);
            txtCageQuantity.Name = "txtCageQuantity";
            txtCageQuantity.ReadOnly = true;
            txtCageQuantity.Size = new System.Drawing.Size(135, 23);
            txtCageQuantity.TabIndex = 8;
            // 
            // txtCageStaff
            // 
            txtCageStaff.Location = new System.Drawing.Point(335, 131);
            txtCageStaff.Name = "txtCageStaff";
            txtCageStaff.ReadOnly = true;
            txtCageStaff.Size = new System.Drawing.Size(135, 23);
            txtCageStaff.TabIndex = 9;
            // 
            // txtCageStatus
            // 
            txtCageStatus.Location = new System.Drawing.Point(335, 10);
            txtCageStatus.Name = "txtCageStatus";
            txtCageStatus.ReadOnly = true;
            txtCageStatus.Size = new System.Drawing.Size(135, 23);
            txtCageStatus.TabIndex = 9;
            // 
            // txtCageArea
            // 
            txtCageArea.Location = new System.Drawing.Point(335, 68);
            txtCageArea.Name = "txtCageArea";
            txtCageArea.ReadOnly = true;
            txtCageArea.Size = new System.Drawing.Size(135, 23);
            txtCageArea.TabIndex = 10;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(274, 175);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 23);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(130, 175);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(75, 23);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmCageDetailMovingAnimal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(487, 210);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtCageArea);
            Controls.Add(txtCageStatus);
            Controls.Add(txtCageStaff);
            Controls.Add(txtCageQuantity);
            Controls.Add(txtCageName);
            Controls.Add(txtCageID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCageDetailMovingAnimal";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmCageDetailMovingAnimal";
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
        private System.Windows.Forms.TextBox txtCageID;
        private System.Windows.Forms.TextBox txtCageName;
        private System.Windows.Forms.TextBox txtCageQuantity;
        private System.Windows.Forms.TextBox txtCageStaff;
        private System.Windows.Forms.TextBox txtCageStatus;
        private System.Windows.Forms.TextBox txtCageArea;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}