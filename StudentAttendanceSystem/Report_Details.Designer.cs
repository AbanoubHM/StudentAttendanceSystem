
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
            this.Attendance_Btn.Location = new System.Drawing.Point(79, 149);
            this.Attendance_Btn.Name = "Attendance_Btn";
            this.Attendance_Btn.Size = new System.Drawing.Size(211, 90);
            this.Attendance_Btn.TabIndex = 1;
            this.Attendance_Btn.Text = "Attendance For Students";
            this.Attendance_Btn.UseVisualStyleBackColor = true;
            // 
            // Student_Data_Btn
            // 
            this.Student_Data_Btn.Location = new System.Drawing.Point(466, 149);
            this.Student_Data_Btn.Name = "Student_Data_Btn";
            this.Student_Data_Btn.Size = new System.Drawing.Size(211, 90);
            this.Student_Data_Btn.TabIndex = 2;
            this.Student_Data_Btn.Text = "Student Data";
            this.Student_Data_Btn.UseVisualStyleBackColor = true;
            // 
            // Advice_LBL
            // 
            this.Advice_LBL.AutoSize = true;
            this.Advice_LBL.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Advice_LBL.Location = new System.Drawing.Point(138, 67);
            this.Advice_LBL.Name = "Advice_LBL";
            this.Advice_LBL.Size = new System.Drawing.Size(451, 31);
            this.Advice_LBL.TabIndex = 3;
            this.Advice_LBL.Text = "Do You Want To Save For Excel Sheet !";
            // 
            // Report_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Advice_LBL);
            this.Controls.Add(this.Student_Data_Btn);
            this.Controls.Add(this.Attendance_Btn);
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