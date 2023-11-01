namespace ZooManagementWinApp
{
    partial class frmFoodInMeal
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnDelete = new System.Windows.Forms.Button();
            txtFoodWeight = new System.Windows.Forms.TextBox();
            btnAddFood = new System.Windows.Forms.Button();
            lbQuantity = new System.Windows.Forms.Label();
            txtFoodName = new System.Windows.Forms.TextBox();
            lbName = new System.Windows.Forms.Label();
            txtFoodID = new System.Windows.Forms.TextBox();
            lbAnimalID = new System.Windows.Forms.Label();
            dgvFood = new System.Windows.Forms.DataGridView();
            btnClose = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFood).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(txtFoodWeight);
            groupBox1.Controls.Add(btnAddFood);
            groupBox1.Controls.Add(lbQuantity);
            groupBox1.Controls.Add(txtFoodName);
            groupBox1.Controls.Add(lbName);
            groupBox1.Controls.Add(txtFoodID);
            groupBox1.Controls.Add(lbAnimalID);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(509, 317);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Food and Medicine";
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(209, 255);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(112, 34);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtFoodWeight
            // 
            txtFoodWeight.Location = new System.Drawing.Point(148, 182);
            txtFoodWeight.Name = "txtFoodWeight";
            txtFoodWeight.ReadOnly = true;
            txtFoodWeight.Size = new System.Drawing.Size(150, 31);
            txtFoodWeight.TabIndex = 5;
            // 
            // btnAddFood
            // 
            btnAddFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddFood.Location = new System.Drawing.Point(358, 255);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new System.Drawing.Size(125, 34);
            btnAddFood.TabIndex = 8;
            btnAddFood.Text = "Add Food";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new System.Drawing.Point(23, 188);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new System.Drawing.Size(80, 25);
            lbQuantity.TabIndex = 4;
            lbQuantity.Text = "Quantity";
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new System.Drawing.Point(148, 117);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.ReadOnly = true;
            txtFoodName.Size = new System.Drawing.Size(150, 31);
            txtFoodName.TabIndex = 3;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new System.Drawing.Point(23, 123);
            lbName.Name = "lbName";
            lbName.Size = new System.Drawing.Size(59, 25);
            lbName.TabIndex = 2;
            lbName.Text = "Name";
            // 
            // txtFoodID
            // 
            txtFoodID.Location = new System.Drawing.Point(148, 62);
            txtFoodID.Name = "txtFoodID";
            txtFoodID.ReadOnly = true;
            txtFoodID.Size = new System.Drawing.Size(150, 31);
            txtFoodID.TabIndex = 1;
            // 
            // lbAnimalID
            // 
            lbAnimalID.AutoSize = true;
            lbAnimalID.Location = new System.Drawing.Point(23, 62);
            lbAnimalID.Name = "lbAnimalID";
            lbAnimalID.Size = new System.Drawing.Size(30, 25);
            lbAnimalID.TabIndex = 0;
            lbAnimalID.Text = "ID";
            // 
            // dgvFood
            // 
            dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFood.Location = new System.Drawing.Point(1, 403);
            dgvFood.Name = "dgvFood";
            dgvFood.RowHeadersWidth = 62;
            dgvFood.RowTemplate.Height = 33;
            dgvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvFood.Size = new System.Drawing.Size(520, 238);
            dgvFood.TabIndex = 6;
            dgvFood.CellDoubleClick += dgvFood_CellDoubleClick;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(354, 354);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(112, 34);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmFoodInMeal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(522, 642);
            Controls.Add(btnClose);
            Controls.Add(groupBox1);
            Controls.Add(dgvFood);
            Name = "frmFoodInMeal";
            Text = "frmFoodInMeal";
            Load += frmFoodInMeal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFood).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFoodWeight;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.Label lbAnimalID;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
    }
}