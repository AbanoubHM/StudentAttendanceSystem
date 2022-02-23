
namespace StudentAttendanceSystem
{
    partial class Main
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
            this.ITI_Quarter = new System.Windows.Forms.Label();
            this.ITIQuarter_Combo = new System.Windows.Forms.ComboBox();
            this.Track = new System.Windows.Forms.Label();
            this.Track_Combo = new System.Windows.Forms.ComboBox();
            this.Open_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ITI_Quarter
            // 
            this.ITI_Quarter.AutoSize = true;
            this.ITI_Quarter.BackColor = System.Drawing.Color.Transparent;
            this.ITI_Quarter.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITI_Quarter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ITI_Quarter.Location = new System.Drawing.Point(3, 87);
            this.ITI_Quarter.Name = "ITI_Quarter";
            this.ITI_Quarter.Size = new System.Drawing.Size(157, 36);
            this.ITI_Quarter.TabIndex = 1;
            this.ITI_Quarter.Text = "ITI_Quarter";
            this.ITI_Quarter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ITIQuarter_Combo
            // 
            this.ITIQuarter_Combo.FormattingEnabled = true;
            this.ITIQuarter_Combo.Location = new System.Drawing.Point(160, 100);
            this.ITIQuarter_Combo.Name = "ITIQuarter_Combo";
            this.ITIQuarter_Combo.Size = new System.Drawing.Size(352, 21);
            this.ITIQuarter_Combo.TabIndex = 2;
            this.ITIQuarter_Combo.SelectedIndexChanged += new System.EventHandler(this.ITIQuarter_Combo_SelectedIndexChanged);
            // 
            // Track
            // 
            this.Track.AutoSize = true;
            this.Track.BackColor = System.Drawing.Color.Transparent;
            this.Track.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Track.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Track.Location = new System.Drawing.Point(3, 142);
            this.Track.Name = "Track";
            this.Track.Size = new System.Drawing.Size(79, 36);
            this.Track.TabIndex = 3;
            this.Track.Text = "Track";
            this.Track.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Track_Combo
            // 
            this.Track_Combo.FormattingEnabled = true;
            this.Track_Combo.Location = new System.Drawing.Point(160, 157);
            this.Track_Combo.Name = "Track_Combo";
            this.Track_Combo.Size = new System.Drawing.Size(352, 21);
            this.Track_Combo.TabIndex = 4;
            // 
            // Open_btn
            // 
            this.Open_btn.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open_btn.Location = new System.Drawing.Point(65, 194);
            this.Open_btn.Name = "Open_btn";
            this.Open_btn.Size = new System.Drawing.Size(379, 41);
            this.Open_btn.TabIndex = 7;
            this.Open_btn.Text = "Open";
            this.Open_btn.UseVisualStyleBackColor = true;
            this.Open_btn.Click += new System.EventHandler(this.Open_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(448, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 59);
            this.button1.TabIndex = 9;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = global::StudentAttendanceSystem.Properties.Resources._0ae66dfa_27e5_4a95_84df_473cb94e787a;
            this.pictureBox3.Location = new System.Drawing.Point(9, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(141, 72);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = global::StudentAttendanceSystem.Properties.Resources.hand_painted_watercolor_background_with_sky_clouds_shape;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(521, 247);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Open_btn);
            this.Controls.Add(this.Track_Combo);
            this.Controls.Add(this.Track);
            this.Controls.Add(this.ITIQuarter_Combo);
            this.Controls.Add(this.ITI_Quarter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ITI_Quarter;
        private System.Windows.Forms.ComboBox ITIQuarter_Combo;
        private System.Windows.Forms.Label Track;
        private System.Windows.Forms.ComboBox Track_Combo;
        private System.Windows.Forms.Button Open_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}