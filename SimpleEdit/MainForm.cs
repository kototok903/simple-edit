using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;


namespace SimpleEdit
{
    public partial class MainForm : Form
    {
        private List<Bitmap> images;
        private int currentImageIndex;
        private string imageFileName;
        private const int padding = 10, margin = 30; // inner indent, outer indent


        public MainForm()
        {
            InitializeComponent();

            fitElements();

            images = new List<Bitmap>();

            ResetButton.Visible = false;
            BackwardButton.Visible = false;
            ForwardButton.Visible = false;
            OriginalButton.Visible = false;

            ModesMenuGroup.Enabled = false;
            TransformMenuGroup.Enabled = false;
            CorrectionMenuGroup.Enabled = false;
            FiltersMenuGroup.Enabled = false;
            SortingMenuGroup.Enabled = false;
            SaveAsMenuButton.Enabled = false;
        }


        public Bitmap GetOriginalImage()
        {
            if (images == null || images.Count == 0)
            {
                return null;
            }
            return images[0];
        }


        public void SetNewImage(Bitmap image)
        {
            images.Clear();
            UpdateImage(image);
            currentImageIndex = 0;
        }


        public Bitmap GetCurrentImage()
        {
            if (images == null || images.Count == 0)
            {
                return null;
            }
            return images[currentImageIndex];
        }


        public void SetCurrentImage(Bitmap image)
        {
            if (currentImageIndex < images.Count - 1)
            {
                images.RemoveRange(currentImageIndex + 1, images.Count - currentImageIndex - 1);
            }
            images.Add(image);
            currentImageIndex++;
        }


        public void SetPictureBoxImage(Bitmap image)
        {
            pictureBox.Image = image;
        }


        public void UpdateImage(Bitmap image)
        {
            SetPictureBoxImage(image);
            SetCurrentImage(image);
        } 

        
        public void goImageBackward()
        {
            currentImageIndex = Math.Max(0, currentImageIndex - 1);
            SetPictureBoxImage(GetCurrentImage());
        }


        public void goImageForward()
        {
            currentImageIndex = Math.Min(images.Count - 1, currentImageIndex + 1);
            SetPictureBoxImage(GetCurrentImage());
        }


        private void fitElements()
        {
            ResetButton.Left = margin;
            ResetButton.Top = menuStrip.Height + padding * 2;

            BackwardButton.Left = ResetButton.Left + ResetButton.Width + padding;
            BackwardButton.Top = ResetButton.Top;
            ForwardButton.Left = BackwardButton.Left + BackwardButton.Width + padding;
            ForwardButton.Top = ResetButton.Top;

            OriginalButton.Left = this.ClientSize.Width - margin - OriginalButton.Width;
            OriginalButton.Top = ResetButton.Top;
            
            pictureBox.Left = margin;
            pictureBox.Top = OriginalButton.Top + OriginalButton.Height + padding;
            pictureBox.Width = this.ClientSize.Width - margin * 2;
            pictureBox.Height = this.ClientSize.Height - pictureBox.Top - padding;
        }

        
        private void fitImage()
        {
            if (GetOriginalImage() == null)
            {
                return;
            }

            if (GetOriginalImage().Width > pictureBox.Width || GetOriginalImage().Height > pictureBox.Height)
            {
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            }

            pictureBox.Invalidate();
        }


        private void MainForm_Resize(object sender, EventArgs e)
        {
            fitElements();
            fitImage();
        }


        private void OpenMenuButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Open Image";
            dialog.Filter = "Image File (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp|All files (*.*)|*.*";
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SetNewImage(new Bitmap(dialog.FileName));

                    imageFileName = dialog.FileName;
                    imageFileName = imageFileName.Substring(0, imageFileName.LastIndexOf("."));

                    fitImage();

                    ResetButton.Visible = true;
                    BackwardButton.Visible = true;
                    ForwardButton.Visible = true;
                    OriginalButton.Visible = true;

                    ModesMenuGroup.Enabled = true;
                    TransformMenuGroup.Enabled = true;
                    CorrectionMenuGroup.Enabled = true;
                    FiltersMenuGroup.Enabled = true;
                    SortingMenuGroup.Enabled = true;
                    SaveAsMenuButton.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Unable to open image", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }


        private Bitmap nonIndexedImage(Image srcImage)
        {
            Bitmap newImage = new Bitmap(srcImage.Width, srcImage.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (Graphics gfx = Graphics.FromImage(newImage))
            {
                gfx.DrawImage(srcImage, 0, 0);
            }

            return newImage;
        }


        private void SaveAsMenuButton_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                SaveFileDialog dialog = new SaveFileDialog();

                dialog.Title = "Save image";
                dialog.Filter = ".png (*.png)|*.png|.jpeg (*.jpeg)|*.jpeg|.bmp (*.bmp)|*.bmp";
                
                dialog.ShowHelp = true;
                dialog.CheckPathExists = true;
                dialog.OverwritePrompt = true;
                dialog.FileName = imageFileName;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        switch(dialog.FilterIndex)
                        {
                            case 1:
                                pictureBox.Image.Save(dialog.FileName, ImageFormat.Png);
                                break;
                            case 2:
                                pictureBox.Image.Save(dialog.FileName, ImageFormat.Jpeg);
                                break;
                            case 3:
                                pictureBox.Image.Save(dialog.FileName, ImageFormat.Bmp);
                                break;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Unable to save image", "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void ResetButton_Click(object sender, EventArgs e)
        {
            UpdateImage(GetOriginalImage());
        }


        private void BackwardButton_Click(object sender, EventArgs e)
        {
            goImageBackward();
        }


        private void ForwardButton_Click(object sender, EventArgs e)
        {
            goImageForward();
        }


        private void OriginalButton_Click(object sender, EventArgs e)
        {
            OriginalImageForm OriginalPicture = new OriginalImageForm(GetOriginalImage());
            OriginalPicture.ShowDialog();
        }


        private void RotateRightMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            byte[] rgb = new byte[imageData.Stride * imageData.Height];
            byte[] rgbRes = new byte[imageData.Height * imageData.Stride];

            Marshal.Copy(imageData.Scan0, rgb, 0, rgb.Length);

            image.UnlockBits(imageData);

            int oldInd, newInd;

            for (int i = 0; i < imageData.Height; i++)
            {
                for (int j = 0; j < imageData.Width; j++)
                {
                    oldInd = i * imageData.Stride + j * 4;
                    newInd = j * imageData.Height * 4 + (imageData.Height - 1 - i) * 4;
                    rgbRes[newInd + 3] = rgb[oldInd + 3];
                    rgbRes[newInd + 2] = rgb[oldInd + 2];
                    rgbRes[newInd + 1] = rgb[oldInd + 1];
                    rgbRes[newInd] = rgb[oldInd];
                }
            }

            Bitmap imageRes = new Bitmap(image.Height, image.Width);

            BitmapData imageResData = imageRes.LockBits(new Rectangle(0, 0, imageRes.Width, imageRes.Height),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(rgbRes, 0, imageResData.Scan0, rgbRes.Length);

            imageRes.UnlockBits(imageResData);

            UpdateImage(imageRes);
        }


        private void RotateLeftMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            byte[] rgb = new byte[imageData.Stride * imageData.Height];
            byte[] rgbRes = new byte[imageData.Height * imageData.Stride];

            Marshal.Copy(imageData.Scan0, rgb, 0, rgb.Length);

            image.UnlockBits(imageData);

            int oldInd, newInd;

            for (int i = 0; i < imageData.Height; i++)
            {
                for (int j = 0; j < imageData.Width; j++)
                {
                    oldInd = i * imageData.Stride + j * 4;
                    newInd = (imageData.Width - 1 - j) * imageData.Height * 4 + i * 4;
                    rgbRes[newInd + 3] = rgb[oldInd + 3];
                    rgbRes[newInd + 2] = rgb[oldInd + 2];
                    rgbRes[newInd + 1] = rgb[oldInd + 1];
                    rgbRes[newInd] = rgb[oldInd];
                }
            }

            Bitmap imageRes = new Bitmap(image.Height, image.Width);

            BitmapData imageResData = imageRes.LockBits(new Rectangle(0, 0, imageRes.Width, imageRes.Height),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(rgbRes, 0, imageResData.Scan0, rgbRes.Length);

            imageRes.UnlockBits(imageResData);

            UpdateImage(imageRes);
        }


        private void FlipHorizantalMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            byte[] rgb = new byte[imageData.Stride * imageData.Height];
            byte[] rgbRes = new byte[imageData.Stride * imageData.Height];

            Marshal.Copy(imageData.Scan0, rgb, 0, rgb.Length);

            image.UnlockBits(imageData);

            int oldInd, newInd;

            for (int i = 0; i < imageData.Height; i++)
            {
                for (int j = 0; j < imageData.Width; j++)
                {
                    oldInd = i * imageData.Stride + j * 4;
                    newInd = i * imageData.Stride + (imageData.Width - 1 - j) * 4;
                    rgbRes[newInd + 3] = rgb[oldInd + 3];
                    rgbRes[newInd + 2] = rgb[oldInd + 2];
                    rgbRes[newInd + 1] = rgb[oldInd + 1];
                    rgbRes[newInd] = rgb[oldInd];
                }
            }

            Bitmap imageRes = new Bitmap(image.Width, image.Height);

            BitmapData imageResData = imageRes.LockBits(new Rectangle(0, 0, imageRes.Width, imageRes.Height),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(rgbRes, 0, imageResData.Scan0, rgbRes.Length);

            imageRes.UnlockBits(imageResData);

            UpdateImage(imageRes);
        }


        private void FlipVerticalMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            byte[] rgb = new byte[imageData.Stride * imageData.Height];
            byte[] rgbRes = new byte[imageData.Stride * imageData.Height];

            Marshal.Copy(imageData.Scan0, rgb, 0, rgb.Length);

            image.UnlockBits(imageData);

            int oldInd, newInd;

            for (int i = 0; i < imageData.Height; i++)
            {
                for (int j = 0; j < imageData.Width; j++)
                {
                    oldInd = i * imageData.Stride + j * 4;
                    newInd = (imageData.Height - 1 - i) * imageData.Stride + j * 4;
                    rgbRes[newInd + 3] = rgb[oldInd + 3];
                    rgbRes[newInd + 2] = rgb[oldInd + 2];
                    rgbRes[newInd + 1] = rgb[oldInd + 1];
                    rgbRes[newInd] = rgb[oldInd];
                }
            }

            Bitmap imageRes = new Bitmap(image.Width, image.Height);

            BitmapData imageResData = imageRes.LockBits(new Rectangle(0, 0, imageRes.Width, imageRes.Height),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(rgbRes, 0, imageResData.Scan0, rgbRes.Length);

            imageRes.UnlockBits(imageResData);

            UpdateImage(imageRes);
        }


        private void ResizeMenuButton_Click(object sender, EventArgs e)
        {

        }


        private void GrayscaleMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), 
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            byte[] rgb = new byte[imageData.Stride * image.Height];

            Marshal.Copy(imageData.Scan0, rgb, 0, rgb.Length);

            double I;

            for (int i = 0; i < rgb.Length - 3; i += 4)
            {
                I = 0.2989 * rgb[i + 2] + 0.5870 * rgb[i + 1] + 0.1140 * rgb[i];

                rgb[i + 2] = (byte)I;
                rgb[i + 1] = (byte)I;
                rgb[i] = (byte)I;
            }

            Marshal.Copy(rgb, 0, imageData.Scan0, rgb.Length);

            image.UnlockBits(imageData);

            UpdateImage(image);
        }


        private void NegativeMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            byte[] rgb = new byte[imageData.Stride * image.Height];

            Marshal.Copy(imageData.Scan0, rgb, 0, rgb.Length);

            for (int i = 0; i < rgb.Length - 3; i += 4)
            {
                rgb[i + 2] = (byte)(255 - rgb[i + 2]);
                rgb[i + 1] = (byte)(255 - rgb[i + 1]);
                rgb[i] = (byte)(255 - rgb[i]);

                rgb[i + 2] = Math.Max(rgb[i + 2], (byte)0);
                rgb[i + 1] = Math.Max(rgb[i + 1], (byte)0);
                rgb[i] = Math.Max(rgb[i], (byte)0);
            }

            Marshal.Copy(rgb, 0, imageData.Scan0, rgb.Length);

            image.UnlockBits(imageData);

            UpdateImage(image);
        }


        private void SepiaMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), 
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            byte[] rgb = new byte[imageData.Stride * image.Height];

            Marshal.Copy(imageData.Scan0, rgb, 0, rgb.Length);

            double rI, gI, bI;

            for (int i = 0; i < rgb.Length - 3; i += 4)
            {
                rI = 0.393 * rgb[i + 2] + 0.769 * rgb[i + 1] + 0.189 * rgb[i];
                gI = 0.349 * rgb[i + 2] + 0.686 * rgb[i + 1] + 0.168 * rgb[i];
                bI = 0.272 * rgb[i + 2] + 0.534 * rgb[i + 1] + 0.131 * rgb[i];

                rI = Math.Min(rI, 255);
                gI = Math.Min(gI, 255);
                bI = Math.Min(bI, 255);

                rgb[i + 2] = (byte)rI;
                rgb[i + 1] = (byte)gI;
                rgb[i] = (byte)bI;
            }

            Marshal.Copy(rgb, 0, imageData.Scan0, rgb.Length);

            image.UnlockBits(imageData);

            UpdateImage(image);
        }


        private void BinaryModeManualMenuButton_Click(object sender, EventArgs e)
        {
            BinaryModeForm binaryMode = new BinaryModeForm(this);

            binaryMode.ShowDialog();
        }

        private void BinaryModeAutomaticMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            byte[] rgb = new byte[imageData.Stride * image.Height];

            Marshal.Copy(imageData.Scan0, rgb, 0, rgb.Length);

            double IAvg = 0, I;

            for (int i = 0; i < rgb.Length - 3; i += 4)
            {
                IAvg += 0.2989 * rgb[i + 2] + 0.5870 * rgb[i + 1] + 0.1140 * rgb[i];
            }

            IAvg /= (rgb.Length / 4);

            for (int i = 0; i < rgb.Length - 3; i += 4)
            {
                I = 0.2989 * rgb[i + 2] + 0.5870 * rgb[i + 1] + 0.1140 * rgb[i];

                if (I > IAvg)
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

            UpdateImage(image);
        }


        private void FloydSteinbergDitheringMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            byte[] rgb = new byte[imageData.Stride * image.Height];
            byte[] Is = new byte[imageData.Width * image.Height];

            Marshal.Copy(imageData.Scan0, rgb, 0, rgb.Length);

            double I;
            int rgbInd, oldV, newV, err;

            for (int i = 0; i < rgb.Length - 3; i += 4)
            {
                //I = rgb[i + 2] * 0.2126 + rgb[i + 1] * 0.7152 + rgb[i] * 0.0722;
                I = 0.2989 * rgb[i + 2] + 0.5870 * rgb[i + 1] + 0.1140 * rgb[i];
                I = Math.Min(Math.Max(I, 0), 255);
                Is[i / 4] = (byte)I;
            }

            for (int i = 0; i < imageData.Height; i++) // row
            {
                for (int j = 0; j < imageData.Width; j++) // col
                {
                    oldV = Is[i * imageData.Width + j];
                    newV = (oldV > 128 ? 255 : 0);

                    rgbInd = i * imageData.Stride + j * 4;
                    rgb[rgbInd + 2] = (byte)newV;
                    rgb[rgbInd + 1] = (byte)newV;
                    rgb[rgbInd] = (byte)newV;

                    err = oldV - newV;
                    if (j < imageData.Width - 1)
                        Is[i * imageData.Width + j + 1] += (byte)(err * 7.0 / 16.0);
                    if (i < imageData.Height - 1 && j > 0)
                        Is[(i + 1) * imageData.Width + j - 1] += (byte)(err * 3.0 / 16.0);
                    if (i < imageData.Height - 1)
                        Is[(i + 1) * imageData.Width + j] += (byte)(err * 5.0 / 16.0);
                    if (i < imageData.Height - 1 && j < imageData.Width - 1)
                        Is[(i + 1) * imageData.Width + j + 1] += (byte)(err * 1.0 / 16.0);
                }
            }

            Marshal.Copy(rgb, 0, imageData.Scan0, rgb.Length);

            image.UnlockBits(imageData);

            UpdateImage(image);
        }


        private void ColorShiftModeMenuButton_Click(object sender, EventArgs e)
        {
            ColorShiftModeForm colorShiftMode = new ColorShiftModeForm(this);

            colorShiftMode.ShowDialog();
        }


        private void BrightnessContrastMenuButton_Click(object sender, EventArgs e)
        {
            BrightnessContrastForm brightnessContrast = new BrightnessContrastForm(this);

            brightnessContrast.ShowDialog();
        }


        private void ColorBalanceMenuButton_Click(object sender, EventArgs e)
        {
            ColorBalanceForm colorBalance = new ColorBalanceForm(this);

            colorBalance.ShowDialog();
        }


        private void AutotoneMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), 
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            byte[] rgb = new byte[imageData.Stride * imageData.Height];

            Marshal.Copy(imageData.Scan0, rgb, 0, rgb.Length);
            
            double rAvg = 0, gAvg = 0, bAvg = 0;

            for (int i = 0; i < rgb.Length - 3; i += 4)
            {
                rAvg += rgb[i + 2];
                gAvg += rgb[i + 1];
                bAvg += rgb[i];
            }

            rAvg /= rgb.Length;
            gAvg /= rgb.Length;
            bAvg /= rgb.Length;
            double avg = (rAvg + gAvg + bAvg) / 3.0;
            double val;

            for (int i = 0; i < rgb.Length - 3; i += 4)
            {
                // red
                val = rgb[i + 2] * avg / rAvg;
                val = Math.Max(0, Math.Min(255, val));
                rgb[i + 2] = (byte)val;

                // green
                val = rgb[i + 1] * avg / gAvg;
                val = Math.Max(0, Math.Min(255, val));
                rgb[i + 1] = (byte)val;

                // blue
                val = rgb[i] * avg / bAvg;
                val = Math.Max(0, Math.Min(255, val));
                rgb[i] = (byte)val;
            }

            Marshal.Copy(rgb, 0, imageData.Scan0, rgb.Length);

            image.UnlockBits(imageData);

            UpdateImage(image);
        }


        private void AutocontrastMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), 
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            int imageByteSize = imageData.Stride * image.Height;
            byte[] rgb = new byte[imageByteSize];

            Marshal.Copy(imageData.Scan0, rgb, 0, imageByteSize);

            int rMax = rgb[2], gMax = rgb[1], bMax = rgb[0];

            for (int i = 0; i < rgb.Length - 3; i += 4)
            {
                rMax = Math.Max(rMax, rgb[i + 2]);
                gMax = Math.Max(gMax, rgb[i + 1]);
                bMax = Math.Max(bMax, rgb[i]);
            }

            int val;

            for (int i = 0; i < rgb.Length - 3; i += 4)
            {
                // red
                val = rgb[i + 2] * 255 / rMax;
                val = Math.Max(0, Math.Min(255, val));
                rgb[i + 2] = (byte)val;

                // green
                val = rgb[i + 1] * 255 / gMax;
                val = Math.Max(0, Math.Min(255, val));
                rgb[i + 1] = (byte)val;

                // blue
                val = rgb[i] * 255 / bMax;
                val = Math.Max(0, Math.Min(255, val));
                rgb[i] = (byte)val;
            }

            Marshal.Copy(rgb, 0, imageData.Scan0, imageByteSize);

            image.UnlockBits(imageData);

            UpdateImage(image);
        }


        private void ColorCorrectionMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), 
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            int imageByteSize = imageData.Stride * image.Height;
            byte[] rgb = new byte[imageByteSize];

            Marshal.Copy(imageData.Scan0, rgb, 0, rgb.Length);

            int rMax = 0, gMax = 0, bMax = 0;
            int rMin = 255, gMin = 255, bMin = 255;

            for (int i = 0; i < rgb.Length - 3; i += 4)
            {
                rMax = Math.Max(rMax, rgb[i + 2]);
                gMax = Math.Max(gMax, rgb[i + 1]);
                bMax = Math.Max(bMax, rgb[i]);

                rMin = Math.Min(rMin, rgb[i + 2]);
                gMin = Math.Min(gMin, rgb[i + 1]);
                bMin = Math.Min(bMin, rgb[i]);
            }

            double val;

            for (int i = 0; i < rgb.Length - 3; i += 4)
            {
                // red
                val = (rgb[i + 2] - rMin) * 255 / (rMax - rMin);
                val = Math.Max(0, Math.Min(255, val));
                rgb[i + 2] = (byte)val;

                // green
                val = (rgb[i + 1] - gMin) * 255 / (gMax - gMin);
                val = Math.Max(0, Math.Min(255, val));
                rgb[i + 1] = (byte)val;

                // blue
                val = (rgb[i] - bMin) * 255 / (bMax - bMin);
                val = Math.Max(0, Math.Min(255, val));
                rgb[i] = (byte)val;
            }

            Marshal.Copy(rgb, 0, imageData.Scan0, imageByteSize);

            image.UnlockBits(imageData);

            UpdateImage(image);
        }


        private void SharpenMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            double[,] matrix = { {-0.1, -0.1, -0.1 },
                                 {-0.1, 1.8, -0.1 },
                                 {-0.1, -0.1, -0.1 } };

            UpdateImage(Processing.OneMatrixFilter(image, matrix, 1, false));
        }


        private void GaussianBlurMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            double[,] matrix = { {1, 2, 1 },
                                 {2, 4, 2 },
                                 {1, 2, 1 } };
            double coeff = 1.0 / 16.0;

            UpdateImage(Processing.OneMatrixFilter(image, matrix, coeff, false));
        }


        private void Laplacian3x3ColorMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            double[,] matrix = { {1, 1, 1 },
                                 {1, -8, 1 },
                                 {1, 1, 1 } };

            UpdateImage(Processing.OneMatrixFilter(image, matrix, 1, false));
        }


        private void Laplacian3x3BWMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            double[,] matrix = { {1, 1, 1 },
                                 {1, -8, 1 },
                                 {1, 1, 1 } };

            UpdateImage(Processing.OneMatrixFilter(image, matrix, 1, true));
        }


        private void Laplacian5x5ColorMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            double[,] matrix = { {-1, -1, -1, -1, -1 },
                                 {-1, -1, -1, -1, -1 },
                                 {-1, -1, 24, -1, -1 },
                                 {-1, -1, -1, -1, -1 },
                                 {-1, -1, -1, -1, -1 }, };

            UpdateImage(Processing.OneMatrixFilter(image, matrix, 1, false));
        }


        private void Laplacian5x5BWMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            double[,] matrix = { {-1, -1, -1, -1, -1 },
                                 {-1, -1, -1, -1, -1 },
                                 {-1, -1, 24, -1, -1 },
                                 {-1, -1, -1, -1, -1 },
                                 {-1, -1, -1, -1, -1 }, };

            UpdateImage(Processing.OneMatrixFilter(image, matrix, 1, true));
        }


        private void PrewittColorMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            double[,] matrixX = { {-1, 0, 1 },
                                  {-1, 0, 1 },
                                  {-1, 0, 1 } };
            double[,] matrixY = { {-1, -1, -1 },
                                  {0, 0, 0 },
                                  {1, 1, 1 } };

            UpdateImage(Processing.TwoMatrixFilter(image, matrixX, matrixY, false));
        }


        private void PrewittBWMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            double[,] matrixX = { {-1, 0, 1 },
                                  {-1, 0, 1 },
                                  {-1, 0, 1 } };
            double[,] matrixY = { {-1, -1, -1 },
                                  {0, 0, 0 },
                                  {1, 1, 1 } };

            UpdateImage(Processing.TwoMatrixFilter(image, matrixX, matrixY, true));
        }


        private void SobelColorMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            double[,] matrixX = { {-1, 0, 1 },
                                  {-2, 0, 2 },
                                  {-1, 0, 1 } };
            double[,] matrixY = { {-1, -2, -1 },
                                  {0, 0, 0 },
                                  {1, 2, 1 } };

            UpdateImage(Processing.TwoMatrixFilter(image, matrixX, matrixY, false));
        }


        private void SobelBWMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            double[,] matrixX = { {-1, 0, 1 },
                                  {-2, 0, 2 },
                                  {-1, 0, 1 } };
            double[,] matrixY = { {-1, -2, -1 },
                                  {0, 0, 0 },
                                  {1, 2, 1 } };

            UpdateImage(Processing.TwoMatrixFilter(image, matrixX, matrixY, true));
        }


        private void ArithmeticMeanFilterMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            double[,] matrix = { {1, 1, 1 },
                                 {1, 1, 1 },
                                 {1, 1, 1 }, };
            double coeff = 1.0 / 9.0;

            UpdateImage(Processing.OneMatrixFilter(image, matrix, coeff, false));
        }


        private void GeometricMeanFilterMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            double[,] rs = new double[image.Width, image.Height];
            double[,] gs = new double[image.Width, image.Height];
            double[,] bs = new double[image.Width, image.Height];
            Color c;

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    c = image.GetPixel(i, j);
                    rs[i, j] = c.R;
                    gs[i, j] = c.G;
                    bs[i, j] = c.B;
                }
            }

            for (int i = 0; i < image.Width - 3; i++)
            {
                for (int j = 0; j < image.Height - 3; j++)
                {
                    double rMult = 1, gMult = 1, bMult = 1;

                    for (int xShift = 0; xShift < 3; xShift++)
                    {
                        for (int yShift = 0; yShift < 3; yShift++)
                        {
                            rMult *= rs[i + xShift, j + yShift];
                            gMult *= gs[i + xShift, j + yShift];
                            bMult *= bs[i + xShift, j + yShift];
                        }
                    }

                    int rAvg = (int)Math.Pow(rMult, 0.111111);
                    int gAvg = (int)Math.Pow(gMult, 0.111111);
                    int bAvg = (int)Math.Pow(bMult, 0.111111);
                    image.SetPixel(i, j, Color.FromArgb(rAvg, gAvg, bAvg));
                }
            }

            UpdateImage(image);
        }


        private void MedianFilterMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), 
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            byte[] rgb = new byte[imageData.Stride * imageData.Height];
            byte[] rgbRes = new byte[imageData.Stride * imageData.Height];

            Marshal.Copy(imageData.Scan0, rgb, 0, rgb.Length);

            image.UnlockBits(imageData);

            int mOffset = (3 - 1) / 2, cOffset, bOffset;
            List<int> nearPix = new List<int> ();
            byte[] midPix;

            for (int offsetY = mOffset; offsetY < image.Height - mOffset; offsetY++)
            {
                for (int offsetX = mOffset; offsetX < image.Width - mOffset; offsetX++)
                {
                    bOffset = offsetY * imageData.Stride + offsetX * 4;
                    nearPix.Clear();

                    for (int filterY = -mOffset; filterY <= mOffset; filterY++)
                    {
                        for (int filterX = -mOffset; filterX <= mOffset; filterX++)
                        {
                            cOffset = bOffset + (filterX * 4) + (filterY * imageData.Stride);

                            nearPix.Add(BitConverter.ToInt32(rgb, cOffset));
                        }
                    }

                    nearPix.Sort();
                    midPix = BitConverter.GetBytes(nearPix[mOffset]);

                    rgbRes[bOffset] = midPix[0];
                    rgbRes[bOffset + 1] = midPix[1];
                    rgbRes[bOffset + 2] = midPix[2];
                    rgbRes[bOffset + 3] = midPix[3];
                }
            }

            Bitmap imageRes = new Bitmap(image.Width, image.Height);
            BitmapData imageResData = imageRes.LockBits(new Rectangle(0, 0, imageRes.Width, imageRes.Height), 
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(rgbRes, 0, imageResData.Scan0, rgbRes.Length);

            imageRes.UnlockBits(imageResData);

            UpdateImage(image);
        }


        private void WhiteNoiseMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            int imageByteSize = imageData.Stride * image.Height;
            byte[] rgb = new byte[imageByteSize];

            Marshal.Copy(imageData.Scan0, rgb, 0, rgb.Length);

            int rMin, gMin, bMin, rgbInd;

            for (int i = 0; i < imageData.Height - 2; i++)
            {
                for (int j = 0; j < imageData.Width - 2; j++)
                {
                    rMin = 255;
                    gMin = 255;
                    bMin = 255;

                    for (int xShift = 0; xShift < 3; xShift++)
                    {
                        for (int yShift = 0; yShift < 3; yShift++)
                        {
                            rgbInd = (j + xShift) * 4 + (i + yShift) * imageData.Stride;
                            rMin = Math.Min(rMin, rgb[rgbInd + 2]);
                            gMin = Math.Min(gMin, rgb[rgbInd + 1]);
                            bMin = Math.Min(bMin, rgb[rgbInd]);
                        }
                    }

                    rgbInd = j * 4 + i * imageData.Stride;
                    rgb[rgbInd + 2] = (byte)rMin;
                    rgb[rgbInd + 1] = (byte)gMin;
                    rgb[rgbInd] = (byte)bMin;
                }
            }

            Marshal.Copy(rgb, 0, imageData.Scan0, imageByteSize);

            image.UnlockBits(imageData);

            UpdateImage(image);
        }


        private void BlackNoiseMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            int imageByteSize = imageData.Stride * image.Height;
            byte[] rgb = new byte[imageByteSize];

            Marshal.Copy(imageData.Scan0, rgb, 0, rgb.Length);

            int rMax, gMax, bMax, rgbInd;

            for (int i = 0; i < imageData.Height - 2; i++)
            {
                for (int j = 0; j < imageData.Width - 2; j++)
                {
                    rMax = 0;
                    gMax = 0;
                    bMax = 0;

                    for (int xShift = 0; xShift < 3; xShift++)
                    {
                        for (int yShift = 0; yShift < 3; yShift++)
                        {
                            rgbInd = (j + xShift) * 4 + (i + yShift) * imageData.Stride;
                            rMax = Math.Max(rMax, rgb[rgbInd + 2]);
                            gMax = Math.Max(gMax, rgb[rgbInd + 1]);
                            bMax = Math.Max(bMax, rgb[rgbInd]);
                        }
                    }

                    rgbInd = j * 4 + i * imageData.Stride;
                    rgb[rgbInd + 2] = (byte)rMax;
                    rgb[rgbInd + 1] = (byte)gMax;
                    rgb[rgbInd] = (byte)bMax;
                }
            }

            Marshal.Copy(rgb, 0, imageData.Scan0, imageByteSize);

            image.UnlockBits(imageData);

            UpdateImage(image);
        }


        private void ChebyshevFilterMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            int imageByteSize = imageData.Stride * image.Height;
            byte[] rgb = new byte[imageByteSize];

            Marshal.Copy(imageData.Scan0, rgb, 0, rgb.Length);

            int rMin, gMin, bMin;
            int rMax, gMax, bMax;
            int rgbInd;

            for (int i = 0; i < imageData.Height - 2; i++)
            {
                for (int j = 0; j < imageData.Width - 2; j++)
                {
                    rMin = 255;
                    gMin = 255;
                    bMin = 255;

                    rMax = 0;
                    gMax = 0;
                    bMax = 0;

                    for (int xShift = 0; xShift < 3; xShift++)
                    {
                        for (int yShift = 0; yShift < 3; yShift++)
                        {
                            rgbInd = (j + xShift) * 4 + (i + yShift) * imageData.Stride;

                            rMin = Math.Min(rMin, rgb[rgbInd + 2]);
                            gMin = Math.Min(gMin, rgb[rgbInd + 1]);
                            bMin = Math.Min(bMin, rgb[rgbInd]);

                            rMax = Math.Max(rMax, rgb[rgbInd + 2]);
                            gMax = Math.Max(gMax, rgb[rgbInd + 1]);
                            bMax = Math.Max(bMax, rgb[rgbInd]);
                        }
                    }

                    rgbInd = j * 4 + i * imageData.Stride;
                    rgb[rgbInd + 2] = (byte)((rMin + rMax) / 2);
                    rgb[rgbInd + 1] = (byte)((gMin + gMax) / 2);
                    rgb[rgbInd] = (byte)((bMin + bMax) / 2);
                }
            }

            Marshal.Copy(rgb, 0, imageData.Scan0, imageByteSize);

            image.UnlockBits(imageData);

            UpdateImage(image);
        }


        private void VerticalIncreasingSortingMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            byte[] rgb = new byte[imageData.Stride * image.Height];
            byte[] Is = new byte[imageData.Width * image.Height];

            Marshal.Copy(imageData.Scan0, rgb, 0, rgb.Length);

            double I, IMax = 0, IMin = 255;

            for (int i = 0; i < rgb.Length - 3; i += 4)
            {
                I = 0.2989 * rgb[i + 2] + 0.5870 * rgb[i + 1] + 0.1140 * rgb[i];
                IMax = Math.Max(IMax, I);
                IMin = Math.Min(IMin, I);
                Is[i / 4] = (byte)I;
            }

            double leftILim = IMin + (IMax - IMin) / 3.0;
            double rightILim = IMin + (IMax - IMin) / 3.0 * 2.0;
            int rgbInd, startRgbInd = -1;
            bool isInSeq = false;
            int seqi;
            List<(byte I, (byte r, byte g, byte b) rgb)> seq = new List<(byte I, (byte r, byte g, byte b) rgb)>();

            for (int i = 0; i < imageData.Width; i++) // col
            {
                for (int j = 0; j < imageData.Height; j++) // row
                {
                    I = Is[j * imageData.Width + i];
                    rgbInd = j * imageData.Stride + i * 4;

                    if (I > leftILim && I < rightILim)
                    {
                        if (!isInSeq)
                        {
                            startRgbInd = rgbInd;
                            isInSeq = true;
                        }

                        seq.Add(((byte)I, (rgb[rgbInd + 2], rgb[rgbInd + 1], rgb[rgbInd])));
                    }
                    else
                    {
                        if (isInSeq)
                        {
                            seq = seq.OrderBy(i => i.I).ToList();
                            seqi = 0;

                            for (int k = startRgbInd; k < rgbInd; k += imageData.Stride)
                            {
                                rgb[k + 2] = seq[seqi].rgb.r;
                                rgb[k + 1] = seq[seqi].rgb.g;
                                rgb[k] = seq[seqi].rgb.b;
                                seqi++;
                            }

                            isInSeq = false;
                            seq.Clear();
                        }
                    }
                }
            }

            Marshal.Copy(rgb, 0, imageData.Scan0, rgb.Length);

            image.UnlockBits(imageData);

            UpdateImage(image);
        }


        private void VerticalDecreasingSortingMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            byte[] rgb = new byte[imageData.Stride * image.Height];
            byte[] Is = new byte[(imageData.Stride * image.Height) / 4];

            Marshal.Copy(imageData.Scan0, rgb, 0, rgb.Length);

            double I, IMax = 0, IMin = 255;

            for (int i = 0; i < rgb.Length - 3; i += 4)
            {
                I = 0.2989 * rgb[i + 2] + 0.5870 * rgb[i + 1] + 0.1140 * rgb[i];
                IMax = Math.Max(IMax, I);
                IMin = Math.Min(IMin, I);
                Is[i / 4] = (byte)I;
            }

            double leftILim = IMin + (IMax - IMin) / 3.0;
            double rightILim = IMin + (IMax - IMin) / 3.0 * 2.0;
            int rgbInd, startRgbInd = -1;
            bool isInSeq = false;
            int seqi;
            List<(byte I, (byte r, byte g, byte b) rgb)> seq = new List<(byte I, (byte r, byte g, byte b) rgb)>();

            for (int i = 0; i < imageData.Width; i++) // col
            {
                for (int j = 0; j < imageData.Height; j++) // row
                {
                    I = Is[j * imageData.Width + i];
                    rgbInd = j * imageData.Stride + i * 4;

                    if (I > leftILim && I < rightILim)
                    {
                        if (!isInSeq)
                        {
                            startRgbInd = rgbInd;
                            isInSeq = true;
                        }

                        seq.Add(((byte)I, (rgb[rgbInd + 2], rgb[rgbInd + 1], rgb[rgbInd])));
                    }
                    else
                    {
                        if (isInSeq)
                        {
                            seq = seq.OrderBy(i => -i.I).ToList();
                            seqi = 0;

                            for (int k = startRgbInd; k < rgbInd; k += imageData.Stride)
                            {
                                rgb[k + 2] = seq[seqi].rgb.r;
                                rgb[k + 1] = seq[seqi].rgb.g;
                                rgb[k] = seq[seqi].rgb.b;
                                seqi++;
                            }

                            isInSeq = false;
                            seq.Clear();
                        }
                    }
                }
            }

            Marshal.Copy(rgb, 0, imageData.Scan0, rgb.Length);

            image.UnlockBits(imageData);

            UpdateImage(image);
        }


        private void HorizontalIncreasingSortingMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            byte[] rgb = new byte[imageData.Stride * image.Height];
            byte[] Is = new byte[imageData.Width * image.Height];

            Marshal.Copy(imageData.Scan0, rgb, 0, rgb.Length);

            double I, IMax = 0, IMin = 255;

            for (int i = 0; i < rgb.Length - 3; i += 4)
            {
                I = 0.2989 * rgb[i + 2] + 0.5870 * rgb[i + 1] + 0.1140 * rgb[i];
                IMax = Math.Max(IMax, I);
                IMin = Math.Min(IMin, I);
                Is[i / 4] = (byte)I;
            }

            double leftILim = IMin + (IMax - IMin) / 3.0;
            double rightILim = IMin + (IMax - IMin) / 3.0 * 2.0;
            int rgbInd, startRgbInd = -1;
            bool isInSeq = false;
            int seqi;
            List<(byte I, (byte r, byte g, byte b) rgb)> seq = new List<(byte I, (byte r, byte g, byte b) rgb)>();

            for (int i = 0; i < imageData.Height; i++) // row
            {
                for (int j = 0; j < imageData.Width; j++) // col
                {
                    I = Is[i * imageData.Width + j];
                    rgbInd = i * imageData.Stride + j * 4;

                    if (I > leftILim && I < rightILim)
                    {
                        if (!isInSeq)
                        {
                            startRgbInd = rgbInd;
                            isInSeq = true;
                        }

                        seq.Add(((byte)I, (rgb[rgbInd + 2], rgb[rgbInd + 1], rgb[rgbInd])));
                    }
                    else
                    {
                        if (isInSeq)
                        {
                            seq = seq.OrderBy(i => i.I).ToList();
                            seqi = 0;

                            for (int k = startRgbInd; k < rgbInd; k += 4)
                            {
                                rgb[k + 2] = seq[seqi].rgb.r;
                                rgb[k + 1] = seq[seqi].rgb.g;
                                rgb[k] = seq[seqi].rgb.b;
                                seqi++;
                            }

                            isInSeq = false;
                            seq.Clear();
                        }
                    }
                }
            }

            Marshal.Copy(rgb, 0, imageData.Scan0, rgb.Length);

            image.UnlockBits(imageData);

            UpdateImage(image);
        }


        private void HorizontalDecreasingSortingMenuButton_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)GetCurrentImage().Clone();
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            byte[] rgb = new byte[imageData.Stride * image.Height];
            byte[] Is = new byte[imageData.Width * image.Height];

            Marshal.Copy(imageData.Scan0, rgb, 0, rgb.Length);

            double I, IMax = 0, IMin = 255;

            for (int i = 0; i < rgb.Length - 3; i += 4)
            {
                I = 0.2989 * rgb[i + 2] + 0.5870 * rgb[i + 1] + 0.1140 * rgb[i];
                IMax = Math.Max(IMax, I);
                IMin = Math.Min(IMin, I);
                Is[i / 4] = (byte)I;
            }

            double leftILim = IMin + (IMax - IMin) / 3.0;
            double rightILim = IMin + (IMax - IMin) / 3.0 * 2.0;
            int rgbInd, startRgbInd = -1;
            bool isInSeq = false;
            int seqi;
            List<(byte I, (byte r, byte g, byte b) rgb)> seq = new List<(byte I, (byte r, byte g, byte b) rgb)>();

            for (int i = 0; i < imageData.Height; i++) // row
            {
                for (int j = 0; j < imageData.Width; j++) // col
                {
                    I = Is[i * imageData.Width + j];
                    rgbInd = i * imageData.Stride + j * 4;

                    if (I > leftILim && I < rightILim)
                    {
                        if (!isInSeq)
                        {
                            startRgbInd = rgbInd;
                            isInSeq = true;
                        }

                        seq.Add(((byte)I, (rgb[rgbInd + 2], rgb[rgbInd + 1], rgb[rgbInd])));
                    }
                    else
                    {
                        if (isInSeq)
                        {
                            seq = seq.OrderBy(i => -i.I).ToList();
                            seqi = 0;

                            for (int k = startRgbInd; k < rgbInd; k += 4)
                            {
                                rgb[k + 2] = seq[seqi].rgb.r;
                                rgb[k + 1] = seq[seqi].rgb.g;
                                rgb[k] = seq[seqi].rgb.b;
                                seqi++;
                            }

                            isInSeq = false;
                            seq.Clear();
                        }
                    }
                }
            }

            Marshal.Copy(rgb, 0, imageData.Scan0, rgb.Length);

            image.UnlockBits(imageData);

            UpdateImage(image);
        }
    }
}
