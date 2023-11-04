namespace ZooManagementWinApp
{
    partial class frmLogDetail
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
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            cboLogType = new System.Windows.Forms.ComboBox();
            txtCreateDate = new System.Windows.Forms.DateTimePicker();
            txtDescription = new System.Windows.Forms.TextBox();
            txtAnimal = new System.Windows.Forms.TextBox();
            btnSubmit = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(23, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Log type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(246, 19);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Create date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(23, 115);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(23, 68);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(45, 15);
            label5.TabIndex = 4;
            label5.Text = "Animal";
            // 
            // cboLogType
            // 
            cboLogType.BackColor = System.Drawing.SystemColors.Window;
            cboLogType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboLogType.Enabled = false;
            cboLogType.FormattingEnabled = true;
            cboLogType.Items.AddRange(new object[] { "Health", "Move cage" });
            cboLogType.Location = new System.Drawing.Point(94, 11);
            cboLogType.Name = "cboLogType";
            cboLogType.Size = new System.Drawing.Size(121, 23);
            cboLogType.TabIndex = 5;
            // 
            // txtCreateDate
            // 
            txtCreateDate.Location = new System.Drawing.Point(335, 13);
            txtCreateDate.Name = "txtCreateDate";
            txtCreateDate.Size = new System.Drawing.Size(195, 23);
            txtCreateDate.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(94, 107);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(436, 23);
            txtDescription.TabIndex = 7;
            // 
            // txtAnimal
            // 
            txtAnimal.Location = new System.Drawing.Point(94, 60);
            txtAnimal.Name = "txtAnimal";
            txtAnimal.ReadOnly = true;
            txtAnimal.Size = new System.Drawing.Size(121, 23);
            txtAnimal.TabIndex = 8;
            // 
            // btnSubmit
            // 
            btnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSubmit.Location = new System.Drawing.Point(169, 152);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(75, 23);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(308, 152);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmLogDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(542, 200);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(txtAnimal);
            Controls.Add(txtDescription);
            Controls.Add(txtCreateDate);
            Controls.Add(cboLogType);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "frmLogDetail";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmLogDetail";
            Load += frmLogDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboLogType;
        private System.Windows.Forms.DateTimePicker txtCreateDate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAnimal;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}