namespace ZooManagementWinApp
{
    partial class frmFoodStorageDetails
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
            lbTitle = new System.Windows.Forms.Label();
            lbFoodName = new System.Windows.Forms.Label();
            lbFoodID = new System.Windows.Forms.Label();
            txtFoodID = new System.Windows.Forms.TextBox();
            txtFoodName = new System.Windows.Forms.TextBox();
            lbFoodAvailable = new System.Windows.Forms.Label();
            txtFoodAvailable = new System.Windows.Forms.TextBox();
            lbFoodType = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            btnCancle = new System.Windows.Forms.Button();
            cbFoodType = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new System.Drawing.Point(133, 29);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(44, 25);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Title";
            // 
            // lbFoodName
            // 
            lbFoodName.AutoSize = true;
            lbFoodName.Location = new System.Drawing.Point(71, 167);
            lbFoodName.Name = "lbFoodName";
            lbFoodName.Size = new System.Drawing.Size(106, 25);
            lbFoodName.TabIndex = 1;
            lbFoodName.Text = "Food Name";
            // 
            // lbFoodID
            // 
            lbFoodID.AutoSize = true;
            lbFoodID.Location = new System.Drawing.Point(71, 93);
            lbFoodID.Name = "lbFoodID";
            lbFoodID.Size = new System.Drawing.Size(77, 25);
            lbFoodID.TabIndex = 2;
            lbFoodID.Text = "Food ID";
            // 
            // txtFoodID
            // 
            txtFoodID.Location = new System.Drawing.Point(221, 92);
            txtFoodID.Name = "txtFoodID";
            txtFoodID.Size = new System.Drawing.Size(150, 31);
            txtFoodID.TabIndex = 3;
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new System.Drawing.Point(221, 163);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new System.Drawing.Size(150, 31);
            txtFoodName.TabIndex = 4;
            // 
            // lbFoodAvailable
            // 
            lbFoodAvailable.AutoSize = true;
            lbFoodAvailable.Location = new System.Drawing.Point(71, 235);
            lbFoodAvailable.Name = "lbFoodAvailable";
            lbFoodAvailable.Size = new System.Drawing.Size(130, 25);
            lbFoodAvailable.TabIndex = 5;
            lbFoodAvailable.Text = "Food Available";
            // 
            // txtFoodAvailable
            // 
            txtFoodAvailable.Location = new System.Drawing.Point(221, 228);
            txtFoodAvailable.Name = "txtFoodAvailable";
            txtFoodAvailable.Size = new System.Drawing.Size(150, 31);
            txtFoodAvailable.TabIndex = 6;
            // 
            // lbFoodType
            // 
            lbFoodType.AutoSize = true;
            lbFoodType.Location = new System.Drawing.Point(71, 298);
            lbFoodType.Name = "lbFoodType";
            lbFoodType.Size = new System.Drawing.Size(96, 25);
            lbFoodType.TabIndex = 7;
            lbFoodType.Text = "Food Type";
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(259, 388);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(111, 33);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancle
            // 
            btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancle.Location = new System.Drawing.Point(99, 388);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new System.Drawing.Size(111, 33);
            btnCancle.TabIndex = 10;
            btnCancle.Text = "Cancel";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancle_Click;
            // 
            // cbFoodType
            // 
            cbFoodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbFoodType.FormattingEnabled = true;
            cbFoodType.Items.AddRange(new object[] { "Meat", "Plant", "Medicine" });
            cbFoodType.Location = new System.Drawing.Point(211, 297);
            cbFoodType.Name = "cbFoodType";
            cbFoodType.Size = new System.Drawing.Size(158, 33);
            cbFoodType.TabIndex = 11;
            // 
            // frmFoodStorageDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(451, 450);
            Controls.Add(cbFoodType);
            Controls.Add(btnCancle);
            Controls.Add(btnSave);
            Controls.Add(lbFoodType);
            Controls.Add(txtFoodAvailable);
            Controls.Add(lbFoodAvailable);
            Controls.Add(txtFoodName);
            Controls.Add(txtFoodID);
            Controls.Add(lbFoodID);
            Controls.Add(lbFoodName);
            Controls.Add(lbTitle);
            Name = "frmFoodStorageDetails";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmFoodStorageDetails";
            Load += frmFoodStorageDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbFoodName;
        private System.Windows.Forms.Label lbFoodID;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label lbFoodAvailable;
        private System.Windows.Forms.TextBox txtFoodAvailable;
        private System.Windows.Forms.Label lbFoodType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.ComboBox cbFoodType;
    }
}