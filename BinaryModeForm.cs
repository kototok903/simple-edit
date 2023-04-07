using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;


namespace SimpleEdit
{
    public partial class BinaryModeForm : Form
    {
        private MainForm ownerForm;
        private Bitmap originalImage;
        private Bitmap editedImage;
        private const int padding = 10, margin = 20;

        private Bitmap image;
        private BitmapData imageData;
        private byte[] rgb;


        public BinaryModeForm(MainForm ownerF)
        {
            InitializeComponent();

            ownerForm = ownerF;
            originalImage = (Bitmap)ownerForm.GetCurrentImage().Clone();

            fitElements();

            ThresholdTrackBar_Scroll(this, null);
        }


        private void fitElements()
        {
            ThresholdLabel.Left = margin;
            ThresholdLabel.Top = margin;

            ThresholdTrackBar.Left = margin;
            ThresholdTrackBar.Top = ThresholdLabel.Top + ThresholdLabel.Height + padding;

            ThresholdValueLabel.Left = ThresholdTrackBar.Left + ThresholdTrackBar.Width;
            ThresholdValueLabel.Top = ThresholdTrackBar.Top;

            ApplyButton.Left = this.ClientSize.Width - margin - ApplyButton.Width;
            ApplyButton.Top = this.ClientSize.Height - margin - ApplyButton.Height;
        }


        private void ThresholdTrackBar_Scroll(object sender, EventArgs e)
        {
            ThresholdValueLabel.Text = ThresholdTrackBar.Value + "  ";
            int thresholdX3 = ThresholdTrackBar.Value * 3;

            image = (Bitmap)originalImage.Clone();
            imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), 
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            rgb = new byte[imageData.Stride * image.Height];

            Marshal.Copy(imageData.Scan0, rgb, 0, rgb.Length);

            for (int i = 0; i < rgb.Length - 3; i += 4)
            {
                if (rgb[i + 2] + rgb[i + 1] + rgb[i] > thresholdX3)
                {
                    rgb[i + 2] = 255;
                    rgb[i + 1] = 255;
                    rgb[i] = 255;
                }
                else
                {
                    rgb[i + 2] = 0;
                    rgb[i + 1] = 0;
                    rgb[i] = 0;
                }
            }

            Marshal.Copy(rgb, 0, imageData.Scan0, rgb.Length);

            image.UnlockBits(imageData);

            editedImage = image;
            ownerForm.SetPictureBoxImage(image);
        }


        private void ApplyButton_Click(object sender, EventArgs e)
        {
            ownerForm.SetCurrentImage(editedImage);
        }


        private void BiMod_FormClosed(object sender, FormClosedEventArgs e)
        {
            ownerForm.SetPictureBoxImage(ownerForm.GetCurrentImage());
        }
    }
}
