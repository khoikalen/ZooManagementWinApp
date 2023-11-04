namespace ZooManagementWinApp
{
    partial class frmTradeArea
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
            dgvArea = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cboAreaName = new System.Windows.Forms.ComboBox();
            cboExpert = new System.Windows.Forms.ComboBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvArea).BeginInit();
            SuspendLayout();
            // 
            // dgvArea
            // 
            dgvArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArea.Location = new System.Drawing.Point(2, 273);
            dgvArea.Name = "dgvArea";
            dgvArea.ReadOnly = true;
            dgvArea.RowHeadersWidth = 51;
            dgvArea.RowTemplate.Height = 29;
            dgvArea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvArea.Size = new System.Drawing.Size(708, 177);
            dgvArea.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(179, 93);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(84, 20);
            label1.TabIndex = 1;
            label1.Text = "Area Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(179, 155);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 20);
            label2.TabIndex = 2;
            label2.Text = "Expert";
            // 
            // cboAreaName
            // 
            cboAreaName.FormattingEnabled = true;
            cboAreaName.Location = new System.Drawing.Point(299, 90);
            cboAreaName.Name = "cboAreaName";
            cboAreaName.Size = new System.Drawing.Size(217, 28);
            cboAreaName.TabIndex = 3;
            // 
            // cboExpert
            // 
            cboExpert.FormattingEnabled = true;
            cboExpert.Location = new System.Drawing.Point(299, 152);
            cboExpert.Name = "cboExpert";
            cboExpert.Size = new System.Drawing.Size(217, 28);
            cboExpert.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(236, 219);
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
            btnCancel.Location = new System.Drawing.Point(369, 219);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(269, 18);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(168, 37);
            label3.TabIndex = 7;
            label3.Text = "Assgin Area";
            // 
            // frmTradeArea
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(710, 450);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cboExpert);
            Controls.Add(cboAreaName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvArea);
            Name = "frmTradeArea";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form Assign Area";
            Load += frmTradeArea_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArea).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboAreaName;
        private System.Windows.Forms.ComboBox cboExpert;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
    }
}