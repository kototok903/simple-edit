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
    public partial class ColorShiftModeForm : Form
    {
        private MainForm ownerForm;
        private Bitmap originalImage;
        private Bitmap editedImage;
        private const int padding = 10, margin = 20;
        private int percentLabelMaxWidth;

        private Bitmap image;
        private BitmapData imageData;
        private byte[] rgb;

        public ColorShiftModeForm(MainForm ownerF)
        {
            InitializeComponent();

            ownerForm = ownerF;
            originalImage = (Bitmap)ownerForm.GetCurrentImage().Clone();
            percentLabelMaxWidth = RedShiftLabel.Width;

            fitElements();
        }


        private void fitElements()
        {
            RedLabel.Left = margin;
            RedLabel.Top = margin;
            RedTrackBar.Left = RedLabel.Left + GreenLabel.Width + padding;
            RedTrackBar.Top = RedLabel.Top;
            RedShiftLabel.Left = RedTrackBar.Left + RedTrackBar.Width + percentLabelMaxWidth - RedShiftLabel.Width;
            RedShiftLabel.Top = RedTrackBar.Top;

            GreenLabel.Left = margin;
            GreenLabel.Top = RedTrackBar.Top + RedTrackBar.Height;
            GreenTrackBar.Left = GreenLabel.Left + GreenLabel.Width + padding;
            GreenTrackBar.Top = GreenLabel.Top;
            GreenShiftLabel.Left = GreenTrackBar.Left + GreenTrackBar.Width + percentLabelMaxWidth - GreenShiftLabel.Width;
            GreenShiftLabel.Top = GreenTrackBar.Top;

            BlueLabel.Left = margin;
            BlueLabel.Top = GreenTrackBar.Top + GreenTrackBar.Height;
            BlueTrackBar.Left = BlueLabel.Left + GreenLabel.Width + padding;
            BlueTrackBar.Top = BlueLabel.Top;
            BlueShiftLabel.Left = BlueTrackBar.Left + BlueTrackBar.Width + percentLabelMaxWidth - BlueShiftLabel.Width;
            BlueShiftLabel.Top = BlueTrackBar.Top;

            ApplyButton.Left = this.ClientSize.Width - margin - ApplyButton.Width;
            ApplyButton.Top = this.ClientSize.Height - margin - ApplyButton.Height;
        }


        private void ApplyButton_Click(object sender, EventArgs e)
        {
            ownerForm.SetCurrentImage(editedImage);
        }


        private void ColorTrackBar_Scroll(object sender, EventArgs e)
        {
            int rShift = RedTrackBar.Value;
            int gShift = GreenTrackBar.Value;
            int bShift = BlueTrackBar.Value;
            RedShiftLabel.Text = rShift + "  ";
            GreenShiftLabel.Text = gShift + "  ";
            BlueShiftLabel.Text = bShift + "  ";

            image = (Bitmap)originalImage.Clone();
            imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            rgb = new byte[imageData.Stride * imageData.Height];

            Marshal.Copy(imageData.Scan0, rgb, 0, rgb.Length);

            float r, g, b;

            for (int k = 0; k < rgb.Length - 3; k += 4)
            {
                rgb[k + 2] = (byte)(Math.Abs(rgb[k + 2] + rShift) % 256);
                rgb[k + 1] = (byte)(Math.Abs(rgb[k + 1] + gShift) % 256);
                rgb[k] = (byte)(Math.Abs(rgb[k] + bShift) % 256);
            }

            Marshal.Copy(rgb, 0, imageData.Scan0, rgb.Length);

            image.UnlockBits(imageData);

            editedImage = image;
            ownerForm.SetPictureBoxImage(image);
        }

        private void ColorShiftMode_FormClosed(object sender, FormClosedEventArgs e)
        {
            ownerForm.SetPictureBoxImage(ownerForm.GetCurrentImage());
        }
    }
}
