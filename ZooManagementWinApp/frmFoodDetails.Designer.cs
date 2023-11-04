namespace ZooManagementWinApp
{
    partial class frmFoodDetails
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
            btnCancle = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cbFoodName = new System.Windows.Forms.ComboBox();
            txtQuantity = new System.Windows.Forms.TextBox();
            gbTitle = new System.Windows.Forms.GroupBox();
            txtFoodID = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            gbTitle.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancle
            // 
            btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancle.Location = new System.Drawing.Point(73, 190);
            btnCancle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new System.Drawing.Size(78, 20);
            btnCancle.TabIndex = 0;
            btnCancle.Text = "Cancel";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancle_Click;
            // 
            // btnAdd
            // 
            btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnAdd.Location = new System.Drawing.Point(198, 190);
            btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(78, 20);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Save";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 67);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(10, 95);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 15);
            label2.TabIndex = 4;
            label2.Text = "Quantity";
            // 
            // cbFoodName
            // 
            cbFoodName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbFoodName.FormattingEnabled = true;
            cbFoodName.Location = new System.Drawing.Point(110, 62);
            cbFoodName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            cbFoodName.Name = "cbFoodName";
            cbFoodName.Size = new System.Drawing.Size(106, 23);
            cbFoodName.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new System.Drawing.Point(110, 91);
            txtQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new System.Drawing.Size(106, 23);
            txtQuantity.TabIndex = 6;
            // 
            // gbTitle
            // 
            gbTitle.Controls.Add(txtFoodID);
            gbTitle.Controls.Add(label3);
            gbTitle.Controls.Add(cbFoodName);
            gbTitle.Controls.Add(txtQuantity);
            gbTitle.Controls.Add(label1);
            gbTitle.Controls.Add(label2);
            gbTitle.Location = new System.Drawing.Point(8, 13);
            gbTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            gbTitle.Name = "gbTitle";
            gbTitle.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            gbTitle.Size = new System.Drawing.Size(319, 160);
            gbTitle.TabIndex = 7;
            gbTitle.TabStop = false;
            gbTitle.Text = "Title";
            // 
            // txtFoodID
            // 
            txtFoodID.Location = new System.Drawing.Point(110, 29);
            txtFoodID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtFoodID.Name = "txtFoodID";
            txtFoodID.Size = new System.Drawing.Size(34, 23);
            txtFoodID.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(10, 32);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(18, 15);
            label3.TabIndex = 7;
            label3.Text = "ID";
            // 
            // frmFoodDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(336, 226);
            Controls.Add(gbTitle);
            Controls.Add(btnCancle);
            Controls.Add(btnAdd);
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "frmFoodDetails";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FoodDetails";
            Load += FoodDetails_Load;
            gbTitle.ResumeLayout(false);
            gbTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFoodName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.GroupBox gbTitle;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.Label label3;
    }
}