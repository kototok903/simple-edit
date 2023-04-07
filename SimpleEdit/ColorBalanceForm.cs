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
    public partial class ColorBalanceForm : Form
    {
        private MainForm ownerForm;
        private Bitmap originalImage;
        private Bitmap editedImage;
        private const int padding = 10, margin = 20;
        private int percentLabelMaxWidth;

        private Bitmap image;
        private BitmapData imageData;
        private byte[] rgb;

        public ColorBalanceForm(MainForm ownerF)
        {
            InitializeComponent();

            ownerForm = ownerF;
            originalImage = (Bitmap)ownerForm.GetCurrentImage().Clone();
            percentLabelMaxWidth = RedPercentLabel.Width;

            fitElements();
        }


        private void fitElements()
        {
            RedLabel.Left = margin;
            RedLabel.Top = margin;
            RedTrackBar.Left = RedLabel.Left + GreenLabel.Width + padding;
            RedTrackBar.Top = RedLabel.Top;
            RedPercentLabel.Left = RedTrackBar.Left + RedTrackBar.Width + percentLabelMaxWidth - RedPercentLabel.Width;
            RedPercentLabel.Top = RedTrackBar.Top;

            GreenLabel.Left = margin;
            GreenLabel.Top = RedTrackBar.Top + RedTrackBar.Height;
            GreenTrackBar.Left = GreenLabel.Left + GreenLabel.Width + padding;
            GreenTrackBar.Top = GreenLabel.Top;
            GreenPercentLabel.Left = GreenTrackBar.Left + GreenTrackBar.Width + percentLabelMaxWidth - GreenPercentLabel.Width;
            GreenPercentLabel.Top = GreenTrackBar.Top;

            BlueLabel.Left = margin;
            BlueLabel.Top = GreenTrackBar.Top + GreenTrackBar.Height;
            BlueTrackBar.Left = BlueLabel.Left + GreenLabel.Width + padding;
            BlueTrackBar.Top = BlueLabel.Top;
            BluePercentLabel.Left = BlueTrackBar.Left + BlueTrackBar.Width + percentLabelMaxWidth - BluePercentLabel.Width;
            BluePercentLabel.Top = BlueTrackBar.Top;

            ApplyButton.Left = this.ClientSize.Width - margin - ApplyButton.Width;
            ApplyButton.Top = this.ClientSize.Height - margin - ApplyButton.Height;
        }


        private void ApplyButton_Click(object sender, EventArgs e)
        {
            ownerForm.SetCurrentImage(editedImage);
        }


        private void ColorTrackBar_Scroll(object sender, EventArgs e)
        {
            int rPercent = RedTrackBar.Value;
            int gPercent = GreenTrackBar.Value;
            int bPercent = BlueTrackBar.Value;
            RedPercentLabel.Text = rPercent + "%  ";
            GreenPercentLabel.Text = gPercent + "%  ";
            BluePercentLabel.Text = bPercent + "%  ";

            image = (Bitmap)originalImage.Clone();
            imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            rgb = new byte[imageData.Stride * imageData.Height];

            Marshal.Copy(imageData.Scan0, rgb, 0, rgb.Length);

            float r, g, b;

            for (int k = 0; k < rgb.Length - 3; k += 4)
            {
                r = rgb[k + 2] * rPercent / 100.0f;
                g = rgb[k + 1] * gPercent / 100.0f;
                b = rgb[k] * bPercent / 100.0f;

                r = Math.Max(r, 0);
                g = Math.Max(g, 0);
                b = Math.Max(b, 0);

                rgb[k + 2] = (byte)r;
                rgb[k + 1] = (byte)g;
                rgb[k] = (byte)b;
            }
            
            Marshal.Copy(rgb, 0, imageData.Scan0, rgb.Length);

            image.UnlockBits(imageData);

            editedImage = image;
            ownerForm.SetPictureBoxImage(image);
        }


        private void ColorBalance_FormClosed(object sender, FormClosedEventArgs e)
        {
            ownerForm.SetPictureBoxImage(ownerForm.GetCurrentImage());
        }
    }
}
