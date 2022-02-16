
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
            this.TrackQuarter = new System.Windows.Forms.Label();
            this.TrackQuarterCombo = new System.Windows.Forms.ComboBox();
            this.Open_btn = new System.Windows.Forms.Button();
            this.Close_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ITI_Quarter
            // 
            this.ITI_Quarter.AutoSize = true;
            this.ITI_Quarter.BackColor = System.Drawing.Color.Transparent;
            this.ITI_Quarter.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITI_Quarter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ITI_Quarter.Location = new System.Drawing.Point(23, 69);
            this.ITI_Quarter.Name = "ITI_Quarter";
            this.ITI_Quarter.Size = new System.Drawing.Size(175, 33);
            this.ITI_Quarter.TabIndex = 1;
            this.ITI_Quarter.Text = "ITI_Quarter";
            this.ITI_Quarter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ITIQuarter_Combo
            // 
            this.ITIQuarter_Combo.FormattingEnabled = true;
            this.ITIQuarter_Combo.Items.AddRange(new object[] {
            "Quarter1",
            "Quarter2",
            "Quarter3",
            "Quarter4"});
            this.ITIQuarter_Combo.Location = new System.Drawing.Point(269, 81);
            this.ITIQuarter_Combo.Name = "ITIQuarter_Combo";
            this.ITIQuarter_Combo.Size = new System.Drawing.Size(352, 21);
            this.ITIQuarter_Combo.TabIndex = 2;
            // 
            // Track
            // 
            this.Track.AutoSize = true;
            this.Track.BackColor = System.Drawing.Color.Transparent;
            this.Track.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Track.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Track.Location = new System.Drawing.Point(23, 139);
            this.Track.Name = "Track";
            this.Track.Size = new System.Drawing.Size(94, 33);
            this.Track.TabIndex = 3;
            this.Track.Text = "Track";
            this.Track.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Track_Combo
            // 
            this.Track_Combo.FormattingEnabled = true;
            this.Track_Combo.Items.AddRange(new object[] {
            "FullStack.Net",
            "CyperSecurity",
            "FendoumentalSoftWare",
            "FullStackUsing|Paython"});
            this.Track_Combo.Location = new System.Drawing.Point(269, 152);
            this.Track_Combo.Name = "Track_Combo";
            this.Track_Combo.Size = new System.Drawing.Size(352, 21);
            this.Track_Combo.TabIndex = 4;
            // 
            // TrackQuarter
            // 
            this.TrackQuarter.AutoSize = true;
            this.TrackQuarter.BackColor = System.Drawing.Color.Transparent;
            this.TrackQuarter.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackQuarter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TrackQuarter.Location = new System.Drawing.Point(23, 204);
            this.TrackQuarter.Name = "TrackQuarter";
            this.TrackQuarter.Size = new System.Drawing.Size(200, 33);
            this.TrackQuarter.TabIndex = 5;
            this.TrackQuarter.Text = "TrackQuarter";
            this.TrackQuarter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TrackQuarterCombo
            // 
            this.TrackQuarterCombo.FormattingEnabled = true;
            this.TrackQuarterCombo.Items.AddRange(new object[] {
            "Quarter1",
            "Quarter2"});
            this.TrackQuarterCombo.Location = new System.Drawing.Point(269, 216);
            this.TrackQuarterCombo.Name = "TrackQuarterCombo";
            this.TrackQuarterCombo.Size = new System.Drawing.Size(352, 21);
            this.TrackQuarterCombo.TabIndex = 6;
            this.TrackQuarterCombo.SelectedIndexChanged += new System.EventHandler(this.TrackQuarterCombo_SelectedIndexChanged);
            // 
            // Open_btn
            // 
            this.Open_btn.Location = new System.Drawing.Point(125, 301);
            this.Open_btn.Name = "Open_btn";
            this.Open_btn.Size = new System.Drawing.Size(186, 42);
            this.Open_btn.TabIndex = 7;
            this.Open_btn.Text = "Open";
            this.Open_btn.UseVisualStyleBackColor = true;
            this.Open_btn.Click += new System.EventHandler(this.Open_btn_Click);
            // 
            // Close_btn
            // 
            this.Close_btn.Location = new System.Drawing.Point(457, 301);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(198, 42);
            this.Close_btn.TabIndex = 8;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.Open_btn);
            this.Controls.Add(this.TrackQuarterCombo);
            this.Controls.Add(this.TrackQuarter);
            this.Controls.Add(this.Track_Combo);
            this.Controls.Add(this.Track);
            this.Controls.Add(this.ITIQuarter_Combo);
            this.Controls.Add(this.ITI_Quarter);
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
        private System.Windows.Forms.Label TrackQuarter;
        private System.Windows.Forms.ComboBox TrackQuarterCombo;
        private System.Windows.Forms.Button Open_btn;
        private System.Windows.Forms.Button Close_btn;
    }
}