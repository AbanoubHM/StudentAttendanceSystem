
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
            this.TrackGroup = new System.Windows.Forms.Label();
            this.TrackGroupCombo = new System.Windows.Forms.ComboBox();
            this.Open_btn = new System.Windows.Forms.Button();
            this.Close_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ITI_Quarter
            // 
            this.ITI_Quarter.AutoSize = true;
            this.ITI_Quarter.BackColor = System.Drawing.Color.Transparent;
            this.ITI_Quarter.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITI_Quarter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ITI_Quarter.Location = new System.Drawing.Point(12, 32);
            this.ITI_Quarter.Name = "ITI_Quarter";
            this.ITI_Quarter.Size = new System.Drawing.Size(157, 36);
            this.ITI_Quarter.TabIndex = 1;
            this.ITI_Quarter.Text = "ITI_Quarter";
            this.ITI_Quarter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ITIQuarter_Combo
            // 
            this.ITIQuarter_Combo.FormattingEnabled = true;
            this.ITIQuarter_Combo.Location = new System.Drawing.Point(169, 46);
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
            this.Track.Location = new System.Drawing.Point(12, 102);
            this.Track.Name = "Track";
            this.Track.Size = new System.Drawing.Size(79, 36);
            this.Track.TabIndex = 3;
            this.Track.Text = "Track";
            this.Track.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Track_Combo
            // 
            this.Track_Combo.FormattingEnabled = true;
            this.Track_Combo.Location = new System.Drawing.Point(169, 117);
            this.Track_Combo.Name = "Track_Combo";
            this.Track_Combo.Size = new System.Drawing.Size(352, 21);
            this.Track_Combo.TabIndex = 4;
            this.Track_Combo.SelectedIndexChanged += new System.EventHandler(this.Track_Combo_SelectedIndexChanged);
            // 
            // TrackGroup
            // 
            this.TrackGroup.AutoSize = true;
            this.TrackGroup.BackColor = System.Drawing.Color.Transparent;
            this.TrackGroup.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackGroup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TrackGroup.Location = new System.Drawing.Point(12, 167);
            this.TrackGroup.Name = "TrackGroup";
            this.TrackGroup.Size = new System.Drawing.Size(149, 36);
            this.TrackGroup.TabIndex = 5;
            this.TrackGroup.Text = "TrackGroup";
            this.TrackGroup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TrackGroupCombo
            // 
            this.TrackGroupCombo.FormattingEnabled = true;
            this.TrackGroupCombo.Location = new System.Drawing.Point(169, 181);
            this.TrackGroupCombo.Name = "TrackGroupCombo";
            this.TrackGroupCombo.Size = new System.Drawing.Size(352, 21);
            this.TrackGroupCombo.TabIndex = 6;
            this.TrackGroupCombo.SelectedIndexChanged += new System.EventHandler(this.TrackQuarterCombo_SelectedIndexChanged);
            // 
            // Open_btn
            // 
            this.Open_btn.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open_btn.Location = new System.Drawing.Point(115, 221);
            this.Open_btn.Name = "Open_btn";
            this.Open_btn.Size = new System.Drawing.Size(186, 42);
            this.Open_btn.TabIndex = 7;
            this.Open_btn.Text = "Open";
            this.Open_btn.UseVisualStyleBackColor = true;
            this.Open_btn.Click += new System.EventHandler(this.Open_btn_Click);
            // 
            // Close_btn
            // 
            this.Close_btn.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_btn.ForeColor = System.Drawing.Color.Red;
            this.Close_btn.Location = new System.Drawing.Point(413, 225);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(120, 42);
            this.Close_btn.TabIndex = 8;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = global::StudentAttendanceSystem.Properties.Resources.hand_painted_watercolor_background_with_sky_clouds_shape;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(536, 275);
            this.ControlBox = false;
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.Open_btn);
            this.Controls.Add(this.TrackGroupCombo);
            this.Controls.Add(this.TrackGroup);
            this.Controls.Add(this.Track_Combo);
            this.Controls.Add(this.Track);
            this.Controls.Add(this.ITIQuarter_Combo);
            this.Controls.Add(this.ITI_Quarter);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ITI_Quarter;
        private System.Windows.Forms.ComboBox ITIQuarter_Combo;
        private System.Windows.Forms.Label Track;
        private System.Windows.Forms.ComboBox Track_Combo;
        private System.Windows.Forms.Label TrackGroup;
        private System.Windows.Forms.ComboBox TrackGroupCombo;
        private System.Windows.Forms.Button Open_btn;
        private System.Windows.Forms.Button Close_btn;
    }
}