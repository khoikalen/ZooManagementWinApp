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
            tabPage2 = new System.Windows.Forms.TabPage();
            tabControl1.SuspendLayout();
            tabViewLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViewLog).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabViewLog);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1045, 680);
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
            tabViewLog.Size = new System.Drawing.Size(1037, 642);
            tabViewLog.TabIndex = 0;
            tabViewLog.Text = "View Log";
            tabViewLog.UseVisualStyleBackColor = true;
            // 
            // dtpDatetime
            // 
            dtpDatetime.Enabled = false;
            dtpDatetime.Location = new System.Drawing.Point(636, 142);
            dtpDatetime.Name = "dtpDatetime";
            dtpDatetime.Size = new System.Drawing.Size(300, 31);
            dtpDatetime.TabIndex = 11;
            // 
            // lbDatetime
            // 
            lbDatetime.AutoSize = true;
            lbDatetime.Location = new System.Drawing.Point(494, 148);
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
            txtShortDescription.Size = new System.Drawing.Size(517, 31);
            txtShortDescription.TabIndex = 9;
            // 
            // txtAnimalName
            // 
            txtAnimalName.Location = new System.Drawing.Point(636, 80);
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
            lbAnimalName.Location = new System.Drawing.Point(494, 83);
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
            lbTitle.Location = new System.Drawing.Point(407, 20);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(44, 25);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Title";
            // 
            // dgvViewLog
            // 
            dgvViewLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewLog.Location = new System.Drawing.Point(0, 266);
            dgvViewLog.Name = "dgvViewLog";
            dgvViewLog.ReadOnly = true;
            dgvViewLog.RowHeadersWidth = 62;
            dgvViewLog.RowTemplate.Height = 33;
            dgvViewLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvViewLog.Size = new System.Drawing.Size(1037, 380);
            dgvViewLog.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new System.Drawing.Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(1037, 642);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmExpert
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1040, 675);
            Controls.Add(tabControl1);
            Name = "frmExpert";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmExpert";
            Load += frmExpert_Load;
            tabControl1.ResumeLayout(false);
            tabViewLog.ResumeLayout(false);
            tabViewLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViewLog).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabViewLog;
        private System.Windows.Forms.TabPage tabPage2;
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
    }
}