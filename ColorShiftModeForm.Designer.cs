
namespace SimpleEdit
{
    partial class ColorShiftModeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorShiftModeForm));
            this.BlueShiftLabel = new System.Windows.Forms.Label();
            this.GreenShiftLabel = new System.Windows.Forms.Label();
            this.RedShiftLabel = new System.Windows.Forms.Label();
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
            // BlueShiftLabel
            // 
            this.BlueShiftLabel.AutoSize = true;
            this.BlueShiftLabel.Location = new System.Drawing.Point(593, 148);
            this.BlueShiftLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BlueShiftLabel.Name = "BlueShiftLabel";
            this.BlueShiftLabel.Size = new System.Drawing.Size(22, 25);
            this.BlueShiftLabel.TabIndex = 47;
            this.BlueShiftLabel.Text = "0";
            // 
            // GreenShiftLabel
            // 
            this.GreenShiftLabel.AutoSize = true;
            this.GreenShiftLabel.Location = new System.Drawing.Point(593, 79);
            this.GreenShiftLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GreenShiftLabel.Name = "GreenShiftLabel";
            this.GreenShiftLabel.Size = new System.Drawing.Size(22, 25);
            this.GreenShiftLabel.TabIndex = 46;
            this.GreenShiftLabel.Text = "0";
            // 
            // RedShiftLabel
            // 
            this.RedShiftLabel.AutoSize = true;
            this.RedShiftLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RedShiftLabel.Location = new System.Drawing.Point(593, 17);
            this.RedShiftLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RedShiftLabel.Name = "RedShiftLabel";
            this.RedShiftLabel.Size = new System.Drawing.Size(22, 25);
            this.RedShiftLabel.TabIndex = 45;
            this.RedShiftLabel.Text = "0";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(473, 207);
            this.ApplyButton.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(164, 52);
            this.ApplyButton.TabIndex = 44;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // BlueLabel
            // 
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BlueLabel.Location = new System.Drawing.Point(5, 148);
            this.BlueLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(61, 32);
            this.BlueLabel.TabIndex = 43;
            this.BlueLabel.Text = "Blue";
            // 
            // GreenLabel
            // 
            this.GreenLabel.AutoSize = true;
            this.GreenLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GreenLabel.Location = new System.Drawing.Point(5, 81);
            this.GreenLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.GreenLabel.Name = "GreenLabel";
            this.GreenLabel.Size = new System.Drawing.Size(78, 32);
            this.GreenLabel.TabIndex = 42;
            this.GreenLabel.Text = "Green";
            // 
            // RedLabel
            // 
            this.RedLabel.AutoSize = true;
            this.RedLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RedLabel.Location = new System.Drawing.Point(15, 12);
            this.RedLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(54, 32);
            this.RedLabel.TabIndex = 40;
            this.RedLabel.Text = "Red";
            // 
            // BlueTrackBar
            // 
            this.BlueTrackBar.Location = new System.Drawing.Point(92, 146);
            this.BlueTrackBar.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.BlueTrackBar.Maximum = 255;
            this.BlueTrackBar.Minimum = -255;
            this.BlueTrackBar.Name = "BlueTrackBar";
            this.BlueTrackBar.Size = new System.Drawing.Size(500, 69);
            this.BlueTrackBar.TabIndex = 39;
            this.BlueTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BlueTrackBar.Scroll += new System.EventHandler(this.ColorTrackBar_Scroll);
            // 
            // GreenTrackBar
            // 
            this.GreenTrackBar.Location = new System.Drawing.Point(92, 79);
            this.GreenTrackBar.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.GreenTrackBar.Maximum = 255;
            this.GreenTrackBar.Minimum = -255;
            this.GreenTrackBar.Name = "GreenTrackBar";
            this.GreenTrackBar.Size = new System.Drawing.Size(500, 69);
            this.GreenTrackBar.TabIndex = 38;
            this.GreenTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.GreenTrackBar.Scroll += new System.EventHandler(this.ColorTrackBar_Scroll);
            // 
            // RedTrackBar
            // 
            this.RedTrackBar.Location = new System.Drawing.Point(92, 17);
            this.RedTrackBar.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.RedTrackBar.Maximum = 255;
            this.RedTrackBar.Minimum = -255;
            this.RedTrackBar.Name = "RedTrackBar";
            this.RedTrackBar.Size = new System.Drawing.Size(500, 69);
            this.RedTrackBar.TabIndex = 41;
            this.RedTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.RedTrackBar.Scroll += new System.EventHandler(this.ColorTrackBar_Scroll);
            // 
            // ColorShiftModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(162)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(676, 291);
            this.Controls.Add(this.BlueShiftLabel);
            this.Controls.Add(this.GreenShiftLabel);
            this.Controls.Add(this.RedShiftLabel);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.BlueLabel);
            this.Controls.Add(this.GreenLabel);
            this.Controls.Add(this.RedLabel);
            this.Controls.Add(this.BlueTrackBar);
            this.Controls.Add(this.GreenTrackBar);
            this.Controls.Add(this.RedTrackBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ColorShiftModeForm";
            this.Text = "Color shift mode";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ColorShiftMode_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BlueShiftLabel;
        private System.Windows.Forms.Label GreenShiftLabel;
        private System.Windows.Forms.Label RedShiftLabel;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label BlueLabel;
        private System.Windows.Forms.Label GreenLabel;
        private System.Windows.Forms.Label RedLabel;
        private System.Windows.Forms.TrackBar BlueTrackBar;
        private System.Windows.Forms.TrackBar GreenTrackBar;
        private System.Windows.Forms.TrackBar RedTrackBar;
    }
}