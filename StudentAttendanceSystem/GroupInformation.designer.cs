
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
            this.AddStudent_Btn = new System.Windows.Forms.Button();
            this.Report_Btn = new System.Windows.Forms.Button();
            this.EditStudent_Btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Enrollment_Btn = new System.Windows.Forms.Button();
            this.Attended = new System.Windows.Forms.Button();
            this.p1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView.Location = new System.Drawing.Point(191, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(746, 645);
            this.dataGridView.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.panel1.Size = new System.Drawing.Size(188, 645);
            this.panel1.TabIndex = 8;
            // 
            // AddStudent_Btn
            // 
            this.AddStudent_Btn.BackColor = System.Drawing.Color.White;
            this.AddStudent_Btn.FlatAppearance.BorderSize = 0;
            this.AddStudent_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudent_Btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudent_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddStudent_Btn.Location = new System.Drawing.Point(0, 250);
            this.AddStudent_Btn.Name = "AddStudent_Btn";
            this.AddStudent_Btn.Size = new System.Drawing.Size(193, 62);
            this.AddStudent_Btn.TabIndex = 8;
            this.AddStudent_Btn.Text = "Add Student";
            this.AddStudent_Btn.UseVisualStyleBackColor = false;
            this.AddStudent_Btn.Click += new System.EventHandler(this.AddStudent_Btn_Click_1);
            // 
            // Report_Btn
            // 
            this.Report_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Report_Btn.FlatAppearance.BorderSize = 0;
            this.Report_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Report_Btn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Report_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Report_Btn.Location = new System.Drawing.Point(3, 458);
            this.Report_Btn.Name = "Report_Btn";
            this.Report_Btn.Size = new System.Drawing.Size(190, 65);
            this.Report_Btn.TabIndex = 7;
            this.Report_Btn.Text = "Report";
            this.Report_Btn.UseVisualStyleBackColor = false;
            this.Report_Btn.Click += new System.EventHandler(this.Report_Btn_Click);
            // 
            // EditStudent_Btn
            // 
            this.EditStudent_Btn.BackColor = System.Drawing.Color.White;
            this.EditStudent_Btn.FlatAppearance.BorderSize = 0;
            this.EditStudent_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditStudent_Btn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditStudent_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EditStudent_Btn.Location = new System.Drawing.Point(3, 318);
            this.EditStudent_Btn.Name = "EditStudent_Btn";
            this.EditStudent_Btn.Size = new System.Drawing.Size(190, 64);
            this.EditStudent_Btn.TabIndex = 6;
            this.EditStudent_Btn.Text = "Edit Students";
            this.EditStudent_Btn.UseVisualStyleBackColor = false;
            this.EditStudent_Btn.Click += new System.EventHandler(this.EditStudent_Btn_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-16, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 173);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Enrollment_Btn
            // 
            this.Enrollment_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Enrollment_Btn.FlatAppearance.BorderSize = 0;
            this.Enrollment_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enrollment_Btn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enrollment_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Enrollment_Btn.Location = new System.Drawing.Point(3, 388);
            this.Enrollment_Btn.Name = "Enrollment_Btn";
            this.Enrollment_Btn.Size = new System.Drawing.Size(190, 64);
            this.Enrollment_Btn.TabIndex = 2;
            this.Enrollment_Btn.Text = "Enrollment";
            this.Enrollment_Btn.UseVisualStyleBackColor = false;
            this.Enrollment_Btn.Click += new System.EventHandler(this.Enrollment_Btn_Click);
            // 
            // Attended
            // 
            this.Attended.BackColor = System.Drawing.Color.Snow;
            this.Attended.FlatAppearance.BorderSize = 0;
            this.Attended.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Attended.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attended.ForeColor = System.Drawing.Color.Black;
            this.Attended.Location = new System.Drawing.Point(3, 179);
            this.Attended.Name = "Attended";
            this.Attended.Size = new System.Drawing.Size(190, 65);
            this.Attended.TabIndex = 0;
            this.Attended.Text = "Attendance";
            this.Attended.UseVisualStyleBackColor = false;
            this.Attended.Click += new System.EventHandler(this.Attended_Click);
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.p1.Location = new System.Drawing.Point(3, 179);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(10, 65);
            this.p1.TabIndex = 4;
            // 
            // GroupInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.Name = "GroupInformation";
            this.Text = "GroupInformation";
            this.Load += new System.EventHandler(this.GroupInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Enrollment_Btn;
        private System.Windows.Forms.Button Attended;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button EditStudent_Btn;
        private System.Windows.Forms.Button Report_Btn;
        private System.Windows.Forms.Button AddStudent_Btn;
        private System.Windows.Forms.Panel p1;
    }
}