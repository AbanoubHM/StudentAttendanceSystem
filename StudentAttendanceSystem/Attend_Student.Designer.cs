
namespace StudentAttendanceSystem
{
    partial class Attend_Student
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Track = new System.Windows.Forms.Label();
            this.ITI_Quarter = new System.Windows.Forms.Label();
            this.quarterLbl = new System.Windows.Forms.Label();
            this.trackLbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Track
            // 
            this.Track.AutoSize = true;
            this.Track.BackColor = System.Drawing.Color.Transparent;
            this.Track.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Track.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Track.Location = new System.Drawing.Point(12, 81);
            this.Track.Name = "Track";
            this.Track.Size = new System.Drawing.Size(112, 33);
            this.Track.TabIndex = 7;
            this.Track.Text = "Track :";
            this.Track.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ITI_Quarter
            // 
            this.ITI_Quarter.AutoSize = true;
            this.ITI_Quarter.BackColor = System.Drawing.Color.Transparent;
            this.ITI_Quarter.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITI_Quarter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ITI_Quarter.Location = new System.Drawing.Point(12, 19);
            this.ITI_Quarter.Name = "ITI_Quarter";
            this.ITI_Quarter.Size = new System.Drawing.Size(139, 33);
            this.ITI_Quarter.TabIndex = 6;
            this.ITI_Quarter.Text = "Quarter :";
            this.ITI_Quarter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // quarterLbl
            // 
            this.quarterLbl.AutoSize = true;
            this.quarterLbl.BackColor = System.Drawing.Color.Transparent;
            this.quarterLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quarterLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quarterLbl.Location = new System.Drawing.Point(174, 19);
            this.quarterLbl.Name = "quarterLbl";
            this.quarterLbl.Size = new System.Drawing.Size(56, 33);
            this.quarterLbl.TabIndex = 9;
            this.quarterLbl.Text = "Q2";
            this.quarterLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackLbl
            // 
            this.trackLbl.AutoSize = true;
            this.trackLbl.BackColor = System.Drawing.Color.Transparent;
            this.trackLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trackLbl.Location = new System.Drawing.Point(174, 81);
            this.trackLbl.Name = "trackLbl";
            this.trackLbl.Size = new System.Drawing.Size(94, 33);
            this.trackLbl.TabIndex = 10;
            this.trackLbl.Text = "Track";
            this.trackLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(539, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(281, 24);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(399, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 33);
            this.label4.TabIndex = 27;
            this.label4.Text = "Date :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.GridColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView1.Location = new System.Drawing.Point(18, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 246);
            this.dataGridView1.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 52);
            this.button1.TabIndex = 29;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 52);
            this.button2.TabIndex = 30;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Attend_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 524);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.trackLbl);
            this.Controls.Add(this.quarterLbl);
            this.Controls.Add(this.Track);
            this.Controls.Add(this.ITI_Quarter);
            this.Name = "Attend_Student";
            this.Text = "Attend_Student";
            this.Load += new System.EventHandler(this.Attend_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Track;
        private System.Windows.Forms.Label ITI_Quarter;
        private System.Windows.Forms.Label quarterLbl;
        private System.Windows.Forms.Label trackLbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}