namespace ZooManagementWinApp
{
    partial class frmExpert
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
            tabControl1 = new System.Windows.Forms.TabControl();
            tabViewLog = new System.Windows.Forms.TabPage();
            dtpDatetime = new System.Windows.Forms.DateTimePicker();
            lbDatetime = new System.Windows.Forms.Label();
            txtShortDescription = new System.Windows.Forms.TextBox();
            txtAnimalName = new System.Windows.Forms.TextBox();
            lbShortDescription = new System.Windows.Forms.Label();
            lbAnimalName = new System.Windows.Forms.Label();
            txtType = new System.Windows.Forms.TextBox();
            lbType = new System.Windows.Forms.Label();
            txtSpecies = new System.Windows.Forms.TextBox();
            lbSpecies = new System.Windows.Forms.Label();
            lbTitle = new System.Windows.Forms.Label();
            dgvViewLog = new System.Windows.Forms.DataGridView();
            tabCreateMeal = new System.Windows.Forms.TabPage();
            tabFoodStorage = new System.Windows.Forms.TabPage();
            txtFoodID = new System.Windows.Forms.TextBox();
            lbFoodID = new System.Windows.Forms.Label();
            btnDelete = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            txtFoodAvailable = new System.Windows.Forms.TextBox();
            txtFoodType = new System.Windows.Forms.TextBox();
            txtFoodName = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            cbFilterFood = new System.Windows.Forms.ComboBox();
            dgvViewFoodStorage = new System.Windows.Forms.DataGridView();
            lbFoodStorage = new System.Windows.Forms.Label();
            tabControl1.SuspendLayout();
            tabViewLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViewLog).BeginInit();
            tabFoodStorage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViewFoodStorage).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabViewLog);
            tabControl1.Controls.Add(tabCreateMeal);
            tabControl1.Controls.Add(tabFoodStorage);
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(858, 680);
            tabControl1.TabIndex = 0;
            // 
            // tabViewLog
            // 
            tabViewLog.Controls.Add(dtpDatetime);
            tabViewLog.Controls.Add(lbDatetime);
            tabViewLog.Controls.Add(txtShortDescription);
            tabViewLog.Controls.Add(txtAnimalName);
            tabViewLog.Controls.Add(lbShortDescription);
            tabViewLog.Controls.Add(lbAnimalName);
            tabViewLog.Controls.Add(txtType);
            tabViewLog.Controls.Add(lbType);
            tabViewLog.Controls.Add(txtSpecies);
            tabViewLog.Controls.Add(lbSpecies);
            tabViewLog.Controls.Add(lbTitle);
            tabViewLog.Controls.Add(dgvViewLog);
            tabViewLog.Location = new System.Drawing.Point(4, 34);
            tabViewLog.Name = "tabViewLog";
            tabViewLog.Padding = new System.Windows.Forms.Padding(3);
            tabViewLog.Size = new System.Drawing.Size(850, 642);
            tabViewLog.TabIndex = 0;
            tabViewLog.Text = "View Log";
            tabViewLog.UseVisualStyleBackColor = true;
            // 
            // dtpDatetime
            // 
            dtpDatetime.Enabled = false;
            dtpDatetime.Location = new System.Drawing.Point(553, 146);
            dtpDatetime.Name = "dtpDatetime";
            dtpDatetime.Size = new System.Drawing.Size(296, 31);
            dtpDatetime.TabIndex = 11;
            // 
            // lbDatetime
            // 
            lbDatetime.AutoSize = true;
            lbDatetime.Location = new System.Drawing.Point(407, 151);
            lbDatetime.Name = "lbDatetime";
            lbDatetime.Size = new System.Drawing.Size(84, 25);
            lbDatetime.TabIndex = 10;
            lbDatetime.Text = "Datetime";
            // 
            // txtShortDescription
            // 
            txtShortDescription.Location = new System.Drawing.Point(204, 218);
            txtShortDescription.Name = "txtShortDescription";
            txtShortDescription.ReadOnly = true;
            txtShortDescription.Size = new System.Drawing.Size(358, 31);
            txtShortDescription.TabIndex = 9;
            // 
            // txtAnimalName
            // 
            txtAnimalName.Location = new System.Drawing.Point(553, 80);
            txtAnimalName.Name = "txtAnimalName";
            txtAnimalName.ReadOnly = true;
            txtAnimalName.Size = new System.Drawing.Size(150, 31);
            txtAnimalName.TabIndex = 8;
            // 
            // lbShortDescription
            // 
            lbShortDescription.AutoSize = true;
            lbShortDescription.Location = new System.Drawing.Point(26, 221);
            lbShortDescription.Name = "lbShortDescription";
            lbShortDescription.Size = new System.Drawing.Size(150, 25);
            lbShortDescription.TabIndex = 7;
            lbShortDescription.Text = "Short Description";
            // 
            // lbAnimalName
            // 
            lbAnimalName.AutoSize = true;
            lbAnimalName.Location = new System.Drawing.Point(407, 83);
            lbAnimalName.Name = "lbAnimalName";
            lbAnimalName.Size = new System.Drawing.Size(119, 25);
            lbAnimalName.TabIndex = 6;
            lbAnimalName.Text = "Animal Name";
            // 
            // txtType
            // 
            txtType.Location = new System.Drawing.Point(204, 145);
            txtType.Name = "txtType";
            txtType.ReadOnly = true;
            txtType.Size = new System.Drawing.Size(150, 31);
            txtType.TabIndex = 5;
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Location = new System.Drawing.Point(26, 151);
            lbType.Name = "lbType";
            lbType.Size = new System.Drawing.Size(49, 25);
            lbType.TabIndex = 4;
            lbType.Text = "Type";
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new System.Drawing.Point(204, 80);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.ReadOnly = true;
            txtSpecies.Size = new System.Drawing.Size(150, 31);
            txtSpecies.TabIndex = 3;
            // 
            // lbSpecies
            // 
            lbSpecies.AutoSize = true;
            lbSpecies.Location = new System.Drawing.Point(26, 83);
            lbSpecies.Name = "lbSpecies";
            lbSpecies.Size = new System.Drawing.Size(71, 25);
            lbSpecies.TabIndex = 2;
            lbSpecies.Text = "Species";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new System.Drawing.Point(346, 15);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(44, 25);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Title";
            // 
            // dgvViewLog
            // 
            dgvViewLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvViewLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewLog.Location = new System.Drawing.Point(0, 266);
            dgvViewLog.Name = "dgvViewLog";
            dgvViewLog.ReadOnly = true;
            dgvViewLog.RowHeadersWidth = 62;
            dgvViewLog.RowTemplate.Height = 33;
            dgvViewLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvViewLog.Size = new System.Drawing.Size(849, 380);
            dgvViewLog.TabIndex = 0;
            // 
            // tabCreateMeal
            // 
            tabCreateMeal.Location = new System.Drawing.Point(4, 34);
            tabCreateMeal.Name = "tabCreateMeal";
            tabCreateMeal.Padding = new System.Windows.Forms.Padding(3);
            tabCreateMeal.Size = new System.Drawing.Size(850, 642);
            tabCreateMeal.TabIndex = 1;
            tabCreateMeal.Text = "Create Meal";
            tabCreateMeal.UseVisualStyleBackColor = true;
            // 
            // tabFoodStorage
            // 
            tabFoodStorage.Controls.Add(txtFoodID);
            tabFoodStorage.Controls.Add(lbFoodID);
            tabFoodStorage.Controls.Add(btnDelete);
            tabFoodStorage.Controls.Add(btnAdd);
            tabFoodStorage.Controls.Add(txtFoodAvailable);
            tabFoodStorage.Controls.Add(txtFoodType);
            tabFoodStorage.Controls.Add(txtFoodName);
            tabFoodStorage.Controls.Add(label3);
            tabFoodStorage.Controls.Add(label2);
            tabFoodStorage.Controls.Add(label1);
            tabFoodStorage.Controls.Add(cbFilterFood);
            tabFoodStorage.Controls.Add(dgvViewFoodStorage);
            tabFoodStorage.Controls.Add(lbFoodStorage);
            tabFoodStorage.Location = new System.Drawing.Point(4, 34);
            tabFoodStorage.Name = "tabFoodStorage";
            tabFoodStorage.Padding = new System.Windows.Forms.Padding(3);
            tabFoodStorage.Size = new System.Drawing.Size(850, 642);
            tabFoodStorage.TabIndex = 2;
            tabFoodStorage.Text = "Food Storage";
            tabFoodStorage.UseVisualStyleBackColor = true;
            // 
            // txtFoodID
            // 
            txtFoodID.Location = new System.Drawing.Point(167, 112);
            txtFoodID.Name = "txtFoodID";
            txtFoodID.Size = new System.Drawing.Size(150, 31);
            txtFoodID.TabIndex = 12;
            // 
            // lbFoodID
            // 
            lbFoodID.AutoSize = true;
            lbFoodID.Location = new System.Drawing.Point(48, 122);
            lbFoodID.Name = "lbFoodID";
            lbFoodID.Size = new System.Drawing.Size(77, 25);
            lbFoodID.TabIndex = 11;
            lbFoodID.Text = "Food ID";
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(205, 255);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(112, 34);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(48, 255);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(112, 34);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtFoodAvailable
            // 
            txtFoodAvailable.Location = new System.Drawing.Point(568, 116);
            txtFoodAvailable.Name = "txtFoodAvailable";
            txtFoodAvailable.ReadOnly = true;
            txtFoodAvailable.Size = new System.Drawing.Size(150, 31);
            txtFoodAvailable.TabIndex = 8;
            // 
            // txtFoodType
            // 
            txtFoodType.Location = new System.Drawing.Point(568, 182);
            txtFoodType.Name = "txtFoodType";
            txtFoodType.ReadOnly = true;
            txtFoodType.Size = new System.Drawing.Size(150, 31);
            txtFoodType.TabIndex = 7;
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new System.Drawing.Point(167, 176);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.ReadOnly = true;
            txtFoodName.Size = new System.Drawing.Size(150, 31);
            txtFoodName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(401, 119);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(130, 25);
            label3.TabIndex = 5;
            label3.Text = "Food Available";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(401, 185);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(96, 25);
            label2.TabIndex = 4;
            label2.Text = "Food Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(48, 182);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(106, 25);
            label1.TabIndex = 3;
            label1.Text = "Food Name";
            // 
            // cbFilterFood
            // 
            cbFilterFood.FormattingEnabled = true;
            cbFilterFood.Items.AddRange(new object[] { "meat", "plant", "medicine" });
            cbFilterFood.Location = new System.Drawing.Point(578, 245);
            cbFilterFood.Name = "cbFilterFood";
            cbFilterFood.Size = new System.Drawing.Size(240, 33);
            cbFilterFood.TabIndex = 2;
            cbFilterFood.Text = "--Choose type of food--";
            cbFilterFood.SelectedIndexChanged += cbFilterFood_SelectedIndexChanged;
            // 
            // dgvViewFoodStorage
            // 
            dgvViewFoodStorage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvViewFoodStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewFoodStorage.Location = new System.Drawing.Point(0, 302);
            dgvViewFoodStorage.Name = "dgvViewFoodStorage";
            dgvViewFoodStorage.ReadOnly = true;
            dgvViewFoodStorage.RowHeadersWidth = 62;
            dgvViewFoodStorage.RowTemplate.Height = 33;
            dgvViewFoodStorage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvViewFoodStorage.Size = new System.Drawing.Size(847, 337);
            dgvViewFoodStorage.TabIndex = 1;
            dgvViewFoodStorage.CellDoubleClick += dgvViewFoodStorage_CellDoubleClick;
            // 
            // lbFoodStorage
            // 
            lbFoodStorage.AutoSize = true;
            lbFoodStorage.Location = new System.Drawing.Point(317, 37);
            lbFoodStorage.Name = "lbFoodStorage";
            lbFoodStorage.Size = new System.Drawing.Size(120, 25);
            lbFoodStorage.TabIndex = 0;
            lbFoodStorage.Text = "Food Storage";
            // 
            // frmExpert
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(856, 675);
            Controls.Add(tabControl1);
            Name = "frmExpert";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmExpert";
            Load += frmExpert_Load;
            tabControl1.ResumeLayout(false);
            tabViewLog.ResumeLayout(false);
            tabViewLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViewLog).EndInit();
            tabFoodStorage.ResumeLayout(false);
            tabFoodStorage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViewFoodStorage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabViewLog;
        private System.Windows.Forms.TabPage tabCreateMeal;
        private System.Windows.Forms.Label lbSpecies;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView dgvViewLog;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.TextBox txtShortDescription;
        private System.Windows.Forms.TextBox txtAnimalName;
        private System.Windows.Forms.Label lbShortDescription;
        private System.Windows.Forms.Label lbAnimalName;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbDatetime;
        private System.Windows.Forms.DateTimePicker dtpDatetime;
        private System.Windows.Forms.TabPage tabFoodStorage;
        private System.Windows.Forms.Label lbFoodStorage;
        private System.Windows.Forms.DataGridView dgvViewFoodStorage;
        private System.Windows.Forms.ComboBox cbFilterFood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFoodAvailable;
        private System.Windows.Forms.TextBox txtFoodType;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.Label lbFoodID;
    }
}