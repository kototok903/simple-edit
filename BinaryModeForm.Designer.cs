
namespace SimpleEdit
{
    partial class BinaryModeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BinaryModeForm));
            this.ApplyButton = new System.Windows.Forms.Button();
            this.ThresholdLabel = new System.Windows.Forms.Label();
            this.ThresholdValueLabel = new System.Windows.Forms.Label();
            this.ThresholdTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(429, 127);
            this.ApplyButton.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(164, 52);
            this.ApplyButton.TabIndex = 17;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // ThresholdLabel
            // 
            this.ThresholdLabel.AutoSize = true;
            this.ThresholdLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThresholdLabel.Location = new System.Drawing.Point(20, 12);
            this.ThresholdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ThresholdLabel.Name = "ThresholdLabel";
            this.ThresholdLabel.Size = new System.Drawing.Size(120, 32);
            this.ThresholdLabel.TabIndex = 16;
            this.ThresholdLabel.Text = "Threshold";
            // 
            // ThresholdValueLabel
            // 
            this.ThresholdValueLabel.AutoSize = true;
            this.ThresholdValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThresholdValueLabel.Location = new System.Drawing.Point(553, 60);
            this.ThresholdValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ThresholdValueLabel.Name = "ThresholdValueLabel";
            this.ThresholdValueLabel.Size = new System.Drawing.Size(42, 25);
            this.ThresholdValueLabel.TabIndex = 15;
            this.ThresholdValueLabel.Text = "126";
            // 
            // ThresholdTrackBar
            // 
            this.ThresholdTrackBar.LargeChange = 1;
            this.ThresholdTrackBar.Location = new System.Drawing.Point(20, 60);
            this.ThresholdTrackBar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ThresholdTrackBar.Maximum = 256;
            this.ThresholdTrackBar.Name = "ThresholdTrackBar";
            this.ThresholdTrackBar.Size = new System.Drawing.Size(525, 69);
            this.ThresholdTrackBar.TabIndex = 14;
            this.ThresholdTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ThresholdTrackBar.Value = 126;
            this.ThresholdTrackBar.Scroll += new System.EventHandler(this.ThresholdTrackBar_Scroll);
            // 
            // BinaryModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(162)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(627, 194);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.ThresholdLabel);
            this.Controls.Add(this.ThresholdValueLabel);
            this.Controls.Add(this.ThresholdTrackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BinaryModeForm";
            this.Text = "Binary mode";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BiMod_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label ThresholdLabel;
        private System.Windows.Forms.Label ThresholdValueLabel;
        private System.Windows.Forms.TrackBar ThresholdTrackBar;
    }
}