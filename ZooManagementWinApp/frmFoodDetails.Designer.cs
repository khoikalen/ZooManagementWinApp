﻿namespace ZooManagementWinApp
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
            btnCancle.Location = new System.Drawing.Point(104, 316);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new System.Drawing.Size(112, 34);
            btnCancle.TabIndex = 0;
            btnCancle.Text = "Cancle";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancle_Click;
            // 
            // btnAdd
            // 
            btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnAdd.Location = new System.Drawing.Point(283, 316);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(112, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Save";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 112);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 25);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 158);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 25);
            label2.TabIndex = 4;
            label2.Text = "Quantity";
            // 
            // cbFoodName
            // 
            cbFoodName.FormattingEnabled = true;
            cbFoodName.Location = new System.Drawing.Point(157, 104);
            cbFoodName.Name = "cbFoodName";
            cbFoodName.Size = new System.Drawing.Size(150, 33);
            cbFoodName.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new System.Drawing.Point(157, 152);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new System.Drawing.Size(150, 31);
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
            gbTitle.Location = new System.Drawing.Point(12, 22);
            gbTitle.Name = "gbTitle";
            gbTitle.Size = new System.Drawing.Size(456, 267);
            gbTitle.TabIndex = 7;
            gbTitle.TabStop = false;
            gbTitle.Text = "Title";
            // 
            // txtFoodID
            // 
            txtFoodID.Location = new System.Drawing.Point(157, 48);
            txtFoodID.Name = "txtFoodID";
            txtFoodID.Size = new System.Drawing.Size(47, 31);
            txtFoodID.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(14, 54);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(30, 25);
            label3.TabIndex = 7;
            label3.Text = "ID";
            // 
            // frmFoodDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(480, 377);
            Controls.Add(gbTitle);
            Controls.Add(btnCancle);
            Controls.Add(btnAdd);
            Name = "frmFoodDetails";
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