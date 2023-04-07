
namespace SimpleEdit
{
    partial class ColorBalanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorBalanceForm));
            this.BluePercentLabel = new System.Windows.Forms.Label();
            this.GreenPercentLabel = new System.Windows.Forms.Label();
            this.RedPercentLabel = new System.Windows.Forms.Label();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.BlueLabel = new System.Windows.Forms.Label();
            this.GreenLabel = new System.Windows.Forms.Label();
            this.RedLabel = new System.Windows.Forms.Label();
            this.BlueTrackBar = new System.Windows.Forms.TrackBar();
            this.GreenTrackBar = new System.Windows.Forms.TrackBar();
            this.RedTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // BluePercentLabel
            // 
            this.BluePercentLabel.AutoSize = true;
            this.BluePercentLabel.Location = new System.Drawing.Point(605, 169);
            this.BluePercentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BluePercentLabel.Name = "BluePercentLabel";
            this.BluePercentLabel.Size = new System.Drawing.Size(57, 25);
            this.BluePercentLabel.TabIndex = 37;
            this.BluePercentLabel.Text = "100%";
            // 
            // GreenPercentLabel
            // 
            this.GreenPercentLabel.AutoSize = true;
            this.GreenPercentLabel.Location = new System.Drawing.Point(605, 100);
            this.GreenPercentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GreenPercentLabel.Name = "GreenPercentLabel";
            this.GreenPercentLabel.Size = new System.Drawing.Size(57, 25);
            this.GreenPercentLabel.TabIndex = 36;
            this.GreenPercentLabel.Text = "100%";
            // 
            // RedPercentLabel
            // 
            this.RedPercentLabel.AutoSize = true;
            this.RedPercentLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RedPercentLabel.Location = new System.Drawing.Point(605, 38);
            this.RedPercentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RedPercentLabel.Name = "RedPercentLabel";
            this.RedPercentLabel.Size = new System.Drawing.Size(57, 25);
            this.RedPercentLabel.TabIndex = 35;
            this.RedPercentLabel.Text = "100%";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(485, 228);
            this.ApplyButton.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(164, 52);
            this.ApplyButton.TabIndex = 34;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // BlueLabel
            // 
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BlueLabel.Location = new System.Drawing.Point(17, 169);
            this.BlueLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(61, 32);
            this.BlueLabel.TabIndex = 33;
            this.BlueLabel.Text = "Blue";
            // 
            // GreenLabel
            // 
            this.GreenLabel.AutoSize = true;
            this.GreenLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GreenLabel.Location = new System.Drawing.Point(17, 102);
            this.GreenLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.GreenLabel.Name = "GreenLabel";
            this.GreenLabel.Size = new System.Drawing.Size(78, 32);
            this.GreenLabel.TabIndex = 32;
            this.GreenLabel.Text = "Green";
            // 
            // RedLabel
            // 
            this.RedLabel.AutoSize = true;
            this.RedLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RedLabel.Location = new System.Drawing.Point(27, 33);
            this.RedLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(54, 32);
            this.RedLabel.TabIndex = 30;
            this.RedLabel.Text = "Red";
            // 
            // BlueTrackBar
            // 
            this.BlueTrackBar.Location = new System.Drawing.Point(104, 167);
            this.BlueTrackBar.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.BlueTrackBar.Maximum = 100;
            this.BlueTrackBar.Name = "BlueTrackBar";
            this.BlueTrackBar.Size = new System.Drawing.Size(500, 69);
            this.BlueTrackBar.TabIndex = 29;
            this.BlueTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BlueTrackBar.Value = 100;
            this.BlueTrackBar.Scroll += new System.EventHandler(this.ColorTrackBar_Scroll);
            // 
            // GreenTrackBar
            // 
            this.GreenTrackBar.Location = new System.Drawing.Point(104, 100);
            this.GreenTrackBar.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.GreenTrackBar.Maximum = 100;
            this.GreenTrackBar.Name = "GreenTrackBar";
            this.GreenTrackBar.Size = new System.Drawing.Size(500, 69);
            this.GreenTrackBar.TabIndex = 28;
            this.GreenTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.GreenTrackBar.Value = 100;
            this.GreenTrackBar.Scroll += new System.EventHandler(this.ColorTrackBar_Scroll);
            // 
            // RedTrackBar
            // 
            this.RedTrackBar.Location = new System.Drawing.Point(104, 38);
            this.RedTrackBar.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.RedTrackBar.Maximum = 100;
            this.RedTrackBar.Name = "RedTrackBar";
            this.RedTrackBar.Size = new System.Drawing.Size(500, 69);
            this.RedTrackBar.TabIndex = 31;
            this.RedTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.RedTrackBar.Value = 100;
            this.RedTrackBar.Scroll += new System.EventHandler(this.ColorTrackBar_Scroll);
            // 
            // ColorBalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(162)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(676, 291);
            this.Controls.Add(this.BluePercentLabel);
            this.Controls.Add(this.GreenPercentLabel);
            this.Controls.Add(this.RedPercentLabel);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.BlueLabel);
            this.Controls.Add(this.GreenLabel);
            this.Controls.Add(this.RedLabel);
            this.Controls.Add(this.BlueTrackBar);
            this.Controls.Add(this.GreenTrackBar);
            this.Controls.Add(this.RedTrackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorBalanceForm";
            this.Text = "Color balance";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ColorBalance_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BluePercentLabel;
        private System.Windows.Forms.Label GreenPercentLabel;
        private System.Windows.Forms.Label RedPercentLabel;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label BlueLabel;
        private System.Windows.Forms.Label GreenLabel;
        private System.Windows.Forms.Label RedLabel;
        private System.Windows.Forms.TrackBar BlueTrackBar;
        private System.Windows.Forms.TrackBar GreenTrackBar;
        private System.Windows.Forms.TrackBar RedTrackBar;
    }
}