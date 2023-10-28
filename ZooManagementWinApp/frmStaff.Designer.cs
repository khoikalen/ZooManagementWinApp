namespace ZooManagementWinApp
{
    partial class frmStaff
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
            label7 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            textBox5 = new System.Windows.Forms.TextBox();
            textBox6 = new System.Windows.Forms.TextBox();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            groupBox1 = new System.Windows.Forms.GroupBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(26, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(26, 68);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Firstname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(26, 106);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Lastname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(26, 149);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(358, 30);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(50, 15);
            label5.TabIndex = 4;
            label5.Text = "Startday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(358, 68);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(36, 15);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(358, 106);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(86, 15);
            label7.TabIndex = 6;
            label7.Text = "Phone number";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(89, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(197, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(89, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(197, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(89, 98);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(197, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(89, 141);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(197, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(458, 60);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(200, 23);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(458, 98);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(200, 23);
            textBox6.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(458, 24);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new System.Drawing.Point(46, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(720, 178);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Staff information";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(12, 277);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(776, 161);
            dataGridView1.TabIndex = 15;
            // 
            // frmStaff
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "frmStaff";
            Text = "frmStaff";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}