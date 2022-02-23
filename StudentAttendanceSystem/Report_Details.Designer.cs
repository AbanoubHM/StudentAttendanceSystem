
namespace StudentAttendanceSystem
{
    partial class Report_Details
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
            this.Attendance_Btn = new System.Windows.Forms.Button();
            this.Student_Data_Btn = new System.Windows.Forms.Button();
            this.Advice_LBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Attendance_Btn
            // 
            this.Attendance_Btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Attendance_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attendance_Btn.Location = new System.Drawing.Point(34, 100);
            this.Attendance_Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Attendance_Btn.Name = "Attendance_Btn";
            this.Attendance_Btn.Size = new System.Drawing.Size(246, 34);
            this.Attendance_Btn.TabIndex = 1;
            this.Attendance_Btn.Text = "Attendance For Students";
            this.Attendance_Btn.UseVisualStyleBackColor = false;
            this.Attendance_Btn.Click += new System.EventHandler(this.Attendance_Btn_Click);
            // 
            // Student_Data_Btn
            // 
            this.Student_Data_Btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Student_Data_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Data_Btn.Location = new System.Drawing.Point(336, 100);
            this.Student_Data_Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Student_Data_Btn.Name = "Student_Data_Btn";
            this.Student_Data_Btn.Size = new System.Drawing.Size(246, 34);
            this.Student_Data_Btn.TabIndex = 2;
            this.Student_Data_Btn.Text = "Student Data";
            this.Student_Data_Btn.UseVisualStyleBackColor = false;
            this.Student_Data_Btn.Click += new System.EventHandler(this.Student_Data_Btn_Click);
            // 
            // Advice_LBL
            // 
            this.Advice_LBL.AutoSize = true;
            this.Advice_LBL.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Advice_LBL.Location = new System.Drawing.Point(253, 10);
            this.Advice_LBL.Name = "Advice_LBL";
            this.Advice_LBL.Size = new System.Drawing.Size(111, 36);
            this.Advice_LBL.TabIndex = 3;
            this.Advice_LBL.Text = "Report";
            // 
            // Report_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 146);
            this.Controls.Add(this.Advice_LBL);
            this.Controls.Add(this.Student_Data_Btn);
            this.Controls.Add(this.Attendance_Btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Report_Details";
            this.Text = "Report_Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Attendance_Btn;
        private System.Windows.Forms.Button Student_Data_Btn;
        private System.Windows.Forms.Label Advice_LBL;
    }
}