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
            lbTitle.Location = new System.Drawing.Point(130, 22);
            lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(29, 15);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Title";
            // 
            // lbFoodName
            // 
            lbFoodName.AutoSize = true;
            lbFoodName.Location = new System.Drawing.Point(50, 100);
            lbFoodName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbFoodName.Name = "lbFoodName";
            lbFoodName.Size = new System.Drawing.Size(69, 15);
            lbFoodName.TabIndex = 1;
            lbFoodName.Text = "Food Name";
            // 
            // lbFoodID
            // 
            lbFoodID.AutoSize = true;
            lbFoodID.Location = new System.Drawing.Point(50, 56);
            lbFoodID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbFoodID.Name = "lbFoodID";
            lbFoodID.Size = new System.Drawing.Size(48, 15);
            lbFoodID.TabIndex = 2;
            lbFoodID.Text = "Food ID";
            // 
            // txtFoodID
            // 
            txtFoodID.Location = new System.Drawing.Point(155, 55);
            txtFoodID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtFoodID.Name = "txtFoodID";
            txtFoodID.Size = new System.Drawing.Size(106, 23);
            txtFoodID.TabIndex = 3;
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new System.Drawing.Point(155, 98);
            txtFoodName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new System.Drawing.Size(106, 23);
            txtFoodName.TabIndex = 4;
            // 
            // lbFoodAvailable
            // 
            lbFoodAvailable.AutoSize = true;
            lbFoodAvailable.Location = new System.Drawing.Point(50, 141);
            lbFoodAvailable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbFoodAvailable.Name = "lbFoodAvailable";
            lbFoodAvailable.Size = new System.Drawing.Size(85, 15);
            lbFoodAvailable.TabIndex = 5;
            lbFoodAvailable.Text = "Food Available";
            // 
            // txtFoodAvailable
            // 
            txtFoodAvailable.Location = new System.Drawing.Point(155, 137);
            txtFoodAvailable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtFoodAvailable.Name = "txtFoodAvailable";
            txtFoodAvailable.Size = new System.Drawing.Size(106, 23);
            txtFoodAvailable.TabIndex = 6;
            // 
            // lbFoodType
            // 
            lbFoodType.AutoSize = true;
            lbFoodType.Location = new System.Drawing.Point(50, 179);
            lbFoodType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbFoodType.Name = "lbFoodType";
            lbFoodType.Size = new System.Drawing.Size(61, 15);
            lbFoodType.TabIndex = 7;
            lbFoodType.Text = "Food Type";
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(181, 233);
            btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(78, 20);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancle
            // 
            btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancle.Location = new System.Drawing.Point(69, 233);
            btnCancle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new System.Drawing.Size(78, 20);
            btnCancle.TabIndex = 10;
            btnCancle.Text = "Cancle";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancle_Click;
            // 
            // cbFoodType
            // 
            cbFoodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbFoodType.FormattingEnabled = true;
            cbFoodType.Items.AddRange(new object[] { "Meat", "Plant", "Medicine" });
            cbFoodType.Location = new System.Drawing.Point(148, 178);
            cbFoodType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            cbFoodType.Name = "cbFoodType";
            cbFoodType.Size = new System.Drawing.Size(112, 23);
            cbFoodType.TabIndex = 11;
            // 
            // frmFoodStorageDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(316, 270);
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
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "frmFoodStorageDetails";
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