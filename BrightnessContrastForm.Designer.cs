
namespace SimpleEdit
{
    partial class BrightnessContrastForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrightnessContrastForm));
            this.ApplyButton = new System.Windows.Forms.Button();
            this.ContrastLabel = new System.Windows.Forms.Label();
            this.BrightnessLabel = new System.Windows.Forms.Label();
            this.ContrastTrackBar = new System.Windows.Forms.TrackBar();
            this.BrightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.BrightnessValueLabel = new System.Windows.Forms.Label();
            this.ContrastValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(518, 237);
            this.ApplyButton.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(164, 52);
            this.ApplyButton.TabIndex = 18;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // ContrastLabel
            // 
            this.ContrastLabel.AutoSize = true;
            this.ContrastLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContrastLabel.Location = new System.Drawing.Point(16, 147);
            this.ContrastLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ContrastLabel.Name = "ContrastLabel";
            this.ContrastLabel.Size = new System.Drawing.Size(103, 32);
            this.ContrastLabel.TabIndex = 16;
            this.ContrastLabel.Text = "Contrast";
            // 
            // BrightnessLabel
            // 
            this.BrightnessLabel.AutoSize = true;
            this.BrightnessLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BrightnessLabel.Location = new System.Drawing.Point(21, 26);
            this.BrightnessLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.BrightnessLabel.Name = "BrightnessLabel";
            this.BrightnessLabel.Size = new System.Drawing.Size(125, 32);
            this.BrightnessLabel.TabIndex = 15;
            this.BrightnessLabel.Text = "Brightness";
            // 
            // ContrastTrackBar
            // 
            this.ContrastTrackBar.LargeChange = 1;
            this.ContrastTrackBar.Location = new System.Drawing.Point(21, 187);
            this.ContrastTrackBar.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.ContrastTrackBar.Maximum = 100;
            this.ContrastTrackBar.Minimum = -100;
            this.ContrastTrackBar.Name = "ContrastTrackBar";
            this.ContrastTrackBar.Size = new System.Drawing.Size(596, 69);
            this.ContrastTrackBar.TabIndex = 14;
            this.ContrastTrackBar.TickFrequency = 10;
            this.ContrastTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ContrastTrackBar.Scroll += new System.EventHandler(this.ContrastTrackBar_Scroll);
            // 
            // BrightnessTrackBar
            // 
            this.BrightnessTrackBar.LargeChange = 1;
            this.BrightnessTrackBar.Location = new System.Drawing.Point(18, 65);
            this.BrightnessTrackBar.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.BrightnessTrackBar.Maximum = 100;
            this.BrightnessTrackBar.Minimum = -100;
            this.BrightnessTrackBar.Name = "BrightnessTrackBar";
            this.BrightnessTrackBar.Size = new System.Drawing.Size(599, 69);
            this.BrightnessTrackBar.TabIndex = 13;
            this.BrightnessTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BrightnessTrackBar.Scroll += new System.EventHandler(this.BrightnessTrackBar_Scroll);
            // 
            // BrightnessValueLabel
            // 
            this.BrightnessValueLabel.AutoSize = true;
            this.BrightnessValueLabel.Location = new System.Drawing.Point(625, 65);
            this.BrightnessValueLabel.Name = "BrightnessValueLabel";
            this.BrightnessValueLabel.Size = new System.Drawing.Size(22, 25);
            this.BrightnessValueLabel.TabIndex = 19;
            this.BrightnessValueLabel.Text = "0";
            // 
            // ContrastValueLabel
            // 
            this.ContrastValueLabel.AutoSize = true;
            this.ContrastValueLabel.Location = new System.Drawing.Point(625, 187);
            this.ContrastValueLabel.Name = "ContrastValueLabel";
            this.ContrastValueLabel.Size = new System.Drawing.Size(22, 25);
            this.ContrastValueLabel.TabIndex = 20;
            this.ContrastValueLabel.Text = "0";
            // 
            // BrightnessContrastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(162)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(698, 306);
            this.Controls.Add(this.ContrastValueLabel);
            this.Controls.Add(this.BrightnessValueLabel);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.ContrastLabel);
            this.Controls.Add(this.BrightnessLabel);
            this.Controls.Add(this.ContrastTrackBar);
            this.Controls.Add(this.BrightnessTrackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BrightnessContrastForm";
            this.Text = "Brightness/Contrast";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BrightnessContrast_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ContrastTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label ContrastLabel;
        private System.Windows.Forms.Label BrightnessLabel;
        private System.Windows.Forms.TrackBar ContrastTrackBar;
        private System.Windows.Forms.TrackBar BrightnessTrackBar;
        private System.Windows.Forms.Label BrightnessValueLabel;
        private System.Windows.Forms.Label ContrastValueLabel;
    }
}