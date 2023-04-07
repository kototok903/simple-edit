using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;


namespace SimpleEdit
{
    public partial class BrightnessContrastForm : Form
    {
        private MainForm ownerForm;
        private Bitmap originalImage;
        private Bitmap editedImage;
        private const int padding = 10, margin = 20;

        private Bitmap image;
        private BitmapData imageData;
        private byte[] rgb;


        public BrightnessContrastForm(MainForm ownerF)
        {
            InitializeComponent();

            ownerForm = ownerF;
            originalImage = (Bitmap)ownerForm.GetCurrentImage().Clone();

            fitElements();
        }


        private void fitElements()
        {
            BrightnessLabel.Left = margin;
            BrightnessLabel.Top = margin;
            BrightnessTrackBar.Left = margin;
            BrightnessTrackBar.Top = BrightnessLabel.Top + BrightnessLabel.Height + padding;
            BrightnessValueLabel.Left = BrightnessTrackBar.Left + BrightnessTrackBar.Width;
            BrightnessValueLabel.Top = BrightnessTrackBar.Top;

            ContrastLabel.Left = margin;
            ContrastLabel.Top = BrightnessTrackBar.Top + BrightnessTrackBar.Height;
            ContrastTrackBar.Left = margin;
            ContrastTrackBar.Top = ContrastLabel.Top + ContrastLabel.Height + padding;
            ContrastValueLabel.Left = ContrastTrackBar.Left + ContrastTrackBar.Width;
            ContrastValueLabel.Top = ContrastTrackBar.Top;

            ApplyButton.Left = this.ClientSize.Width - margin - ApplyButton.Width;
            ApplyButton.Top = this.ClientSize.Height - margin - ApplyButton.Height;
        }


        private void BrightnessTrackBar_Scroll(object sender, EventArgs e)
        {
            BrightnessValueLabel.Text = BrightnessTrackBar.Value + "  ";

            image = (Bitmap)originalImage.Clone();
            imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            rgb = new byte[imageData.Stride * image.Height];

            Marshal.Copy(imageData.Scan0, rgb, 0, rgb.Length);

            double rMax = 0, gMax = 0, bMax = 0;

            for (int i = 0; i < rgb.Length - 3; i += 4)
            {
                if (rgb[i + 2] > rMax && rgb[i + 1] > gMax && rgb[i] > bMax)
                {
                    rMax = rgb[i + 2];
                    gMax = rgb[i + 1];
                    bMax = rgb[i];
                }

            }

            double brightness = BrightnessTrackBar.Value / 100.0 + 1;
            brightness = 1.0 / brightness;
            double val;

            for (int i = 0; i < rgb.Length - 3; i += 4)
            {
                // red
                val = Math.Pow(rgb[i + 2] / rMax, brightness) * rMax;
                val = Math.Min(255, Math.Max(0, val));
                rgb[i + 2] = (byte)val;

                // green
                val = Math.Pow(rgb[i + 1] / gMax, brightness) * gMax;
                val = Math.Min(255, Math.Max(0, val));
                rgb[i + 1] = (byte)val;

                // blue
                val = Math.Pow(rgb[i] / bMax, brightness) * bMax;
                val = Math.Min(255, Math.Max(0, val));
                rgb[i] = (byte)val;
            }

            Marshal.Copy(rgb, 0, imageData.Scan0, rgb.Length);

            image.UnlockBits(imageData);

            editedImage = image;
            ownerForm.SetPictureBoxImage(image);
        }


        private void ContrastTrackBar_Scroll(object sender, EventArgs e)
        {
            ContrastValueLabel.Text = ContrastTrackBar.Value + "  ";

            image = (Bitmap)originalImage.Clone();
            imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            rgb = new byte[imageData.Stride * image.Height];

            Marshal.Copy(imageData.Scan0, rgb, 0, rgb.Length);

            double contrast = (ContrastTrackBar.Value + 100.0) / 100.0;
            contrast = contrast * contrast;
            double val;

            for (int i = 0; i < rgb.Length - 3; i += 4)
            {
                // red
                val = rgb[i + 2] / 255.0;
                val = (val - 0.5) * contrast + 0.5;
                val *= 255.0;
                val = Math.Min(255, Math.Max(0, val));
                rgb[i + 2] = (byte)val;

                // green
                val = rgb[i + 1] / 255.0;
                val = (val - 0.5) * contrast + 0.5;
                val *= 255.0;
                val = Math.Min(255, Math.Max(0, val));
                rgb[i + 1] = (byte)val;

                // blue
                val = rgb[i] / 255.0;
                val = (val - 0.5) * contrast + 0.5;
                val *= 255.0;
                val = Math.Min(255, Math.Max(0, val));
                rgb[i] = (byte)val;
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


        private void BrightnessContrast_FormClosed(object sender, FormClosedEventArgs e)
        {
            ownerForm.SetPictureBoxImage(ownerForm.GetCurrentImage());
        }
    }
}
