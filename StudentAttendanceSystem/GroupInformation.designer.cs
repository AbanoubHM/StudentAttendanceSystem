
using System;

namespace StudentAttendanceSystem {
   public partial class GroupInformation {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupInformation));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Report_Btn = new System.Windows.Forms.Button();
            this.EditStudent_Btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.p1 = new System.Windows.Forms.Panel();
            this.Enrollment_Btn = new System.Windows.Forms.Button();
            this.Attended = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddStudent_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(873, 645);
            this.dataGridView.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.AddStudent_Btn);
            this.panel1.Controls.Add(this.Report_Btn);
            this.panel1.Controls.Add(this.EditStudent_Btn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.p1);
            this.panel1.Controls.Add(this.Enrollment_Btn);
            this.panel1.Controls.Add(this.Attended);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 645);
            this.panel1.TabIndex = 8;
            // 
            // Report_Btn
            // 
            this.Report_Btn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Report_Btn.FlatAppearance.BorderSize = 0;
            this.Report_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Report_Btn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Report_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Report_Btn.Location = new System.Drawing.Point(3, 458);
            this.Report_Btn.Name = "Report_Btn";
            this.Report_Btn.Size = new System.Drawing.Size(214, 65);
            this.Report_Btn.TabIndex = 7;
            this.Report_Btn.Text = "Report";
            this.Report_Btn.UseVisualStyleBackColor = false;
            this.Report_Btn.Click += new System.EventHandler(this.Report_Btn_Click);
            // 
            // EditStudent_Btn
            // 
            this.EditStudent_Btn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.EditStudent_Btn.FlatAppearance.BorderSize = 0;
            this.EditStudent_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditStudent_Btn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditStudent_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EditStudent_Btn.Location = new System.Drawing.Point(3, 318);
            this.EditStudent_Btn.Name = "EditStudent_Btn";
            this.EditStudent_Btn.Size = new System.Drawing.Size(214, 64);
            this.EditStudent_Btn.TabIndex = 6;
            this.EditStudent_Btn.Text = "Edit Students";
            this.EditStudent_Btn.UseVisualStyleBackColor = false;
            this.EditStudent_Btn.Click += new System.EventHandler(this.EditStudent_Btn_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 170);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.p1.Location = new System.Drawing.Point(3, 179);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(17, 65);
            this.p1.TabIndex = 4;
            // 
            // Enrollment_Btn
            // 
            this.Enrollment_Btn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Enrollment_Btn.FlatAppearance.BorderSize = 0;
            this.Enrollment_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enrollment_Btn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enrollment_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Enrollment_Btn.Location = new System.Drawing.Point(3, 388);
            this.Enrollment_Btn.Name = "Enrollment_Btn";
            this.Enrollment_Btn.Size = new System.Drawing.Size(214, 64);
            this.Enrollment_Btn.TabIndex = 2;
            this.Enrollment_Btn.Text = "Enrollment";
            this.Enrollment_Btn.UseVisualStyleBackColor = false;
            this.Enrollment_Btn.Click += new System.EventHandler(this.Enrollment_Btn_Click);
            // 
            // Attended
            // 
            this.Attended.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Attended.FlatAppearance.BorderSize = 0;
            this.Attended.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Attended.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attended.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Attended.Location = new System.Drawing.Point(3, 179);
            this.Attended.Name = "Attended";
            this.Attended.Size = new System.Drawing.Size(214, 65);
            this.Attended.TabIndex = 0;
            this.Attended.Text = "Attendance";
            this.Attended.UseVisualStyleBackColor = false;
            this.Attended.Click += new System.EventHandler(this.Attended_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(220, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(653, 34);
            this.panel2.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(570, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(609, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddStudent_Btn
            // 
            this.AddStudent_Btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudent_Btn.Location = new System.Drawing.Point(3, 250);
            this.AddStudent_Btn.Name = "AddStudent_Btn";
            this.AddStudent_Btn.Size = new System.Drawing.Size(214, 62);
            this.AddStudent_Btn.TabIndex = 8;
            this.AddStudent_Btn.Text = "Add Student";
            this.AddStudent_Btn.UseVisualStyleBackColor = true;
            this.AddStudent_Btn.Click += new System.EventHandler(this.AddStudent_Btn_Click_1);
            // 
            // GroupInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 645);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "GroupInformation";
            this.Text = "GroupInformation";
            this.Load += new System.EventHandler(this.GroupInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

       

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Enrollment_Btn;
        private System.Windows.Forms.Button Attended;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button EditStudent_Btn;
        private System.Windows.Forms.Button Report_Btn;
        private System.Windows.Forms.Button AddStudent_Btn;
    }
}