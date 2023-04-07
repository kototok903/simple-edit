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
    public static class Processing
    {
        public static Bitmap OneMatrixFilter(Bitmap image, double[,] matrix, double coeff, bool isGrayscale)
        {
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), 
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            byte[] rgb = new byte[imageData.Stride * imageData.Height];
            byte[] rgbRes = new byte[imageData.Stride * imageData.Height];

            Marshal.Copy(imageData.Scan0, rgb, 0, rgb.Length);

            image.UnlockBits(imageData);

            if (isGrayscale)
            {
                double I;

                for (int i = 0; i < rgb.Length - 3; i += 4)
                {
                    I = 0.2989 * rgb[i + 2] + 0.5870 * rgb[i + 1] + 0.1140 * rgb[i];

                    rgb[i + 2] = (byte)I;
                    rgb[i + 1] = (byte)I;
                    rgb[i] = (byte)I;
                }
            }

            double r, g, b;

            //int matrixHeight = matrix.GetLength(0);
            //int matrixWidth = matrix.GetLength(1);

            int matrixOffset = (matrix.GetLength(1) - 1) / 2;
            int rgbInd;

            for (int i = matrixOffset; i < image.Height - matrixOffset; i++)
            {
                for (int j = matrixOffset; j < image.Width - matrixOffset; j++)
                {
                    r = 0; 
                    g = 0;
                    b = 0;

                    for (int yShift = -matrixOffset; yShift <= matrixOffset; yShift++)
                    {
                        for (int xShift = -matrixOffset; xShift <= matrixOffset; xShift++)
                        {
                            rgbInd = (j + xShift) * 4 + (i + yShift) * imageData.Stride;

                            r += rgb[rgbInd + 2] * matrix[yShift + matrixOffset, xShift + matrixOffset];
                            g += rgb[rgbInd + 1] * matrix[yShift + matrixOffset, xShift + matrixOffset];
                            b += rgb[rgbInd] * matrix[yShift + matrixOffset, xShift + matrixOffset];
                        }
                    }

                    r *= coeff;
                    g *= coeff;
                    b *= coeff;

                    r = Math.Min(Math.Max(r, 0), 255);
                    g = Math.Min(Math.Max(g, 0), 255);
                    b = Math.Min(Math.Max(b, 0), 255);

                    rgbInd = i * imageData.Stride + j * 4;

                    rgbRes[rgbInd + 3] = rgb[rgbInd + 3];
                    rgbRes[rgbInd + 2] = (byte)r;
                    rgbRes[rgbInd + 1] = (byte)g;
                    rgbRes[rgbInd] = (byte)b;
                }
            }

            Bitmap imageRes = new Bitmap(image.Width, image.Height);

            BitmapData imageResData = imageRes.LockBits(new Rectangle(0, 0, imageRes.Width, imageRes.Height), 
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(rgbRes, 0, imageResData.Scan0, rgbRes.Length);

            imageRes.UnlockBits(imageResData);

            return imageRes;
        }


        public static Bitmap TwoMatrixFilter(Bitmap image, double[,] matrixX, double[,] matrixY, bool isGrayscale)
        {
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), 
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            byte[] rgb = new byte[imageData.Stride * imageData.Height];
            byte[] rgbRes = new byte[imageData.Stride * imageData.Height];

            Marshal.Copy(imageData.Scan0, rgb, 0, rgb.Length);

            image.UnlockBits(imageData);

            if (isGrayscale)
            {
                double I;

                for (int i = 0; i < rgb.Length - 3; i += 4)
                {
                    I = 0.2989 * rgb[i + 2] + 0.5870 * rgb[i + 1] + 0.1140 * rgb[i];

                    rgb[i + 2] = (byte)I;
                    rgb[i + 1] = (byte)I;
                    rgb[i] = (byte)I;
                }
            }

            double rX, gX, bX;
            double rY, gY, bY;
            double r, g, b;

            int matrixOffset = (matrixX.GetLength(1) - 1) / 2;
            int rgbInd;

            for (int i = matrixOffset; i < image.Height - matrixOffset; i++)
            {
                for (int j = matrixOffset; j < image.Width - matrixOffset; j++)
                {
                    bX = gX = rX = 0;
                    bY = gY = rY = 0;

                    for (int yShift = -matrixOffset; yShift <= matrixOffset; yShift++)
                    {
                        for (int xShift = -matrixOffset; xShift <= matrixOffset; xShift++)
                        {
                            rgbInd = (j + xShift) * 4 + (i + yShift) * imageData.Stride;

                            rX += rgb[rgbInd + 2] * matrixX[yShift + matrixOffset, xShift + matrixOffset];
                            gX += rgb[rgbInd + 1] * matrixX[yShift + matrixOffset, xShift + matrixOffset];
                            bX += rgb[rgbInd] * matrixX[yShift + matrixOffset, xShift + matrixOffset];

                            rY += rgb[rgbInd + 2] * matrixY[yShift + matrixOffset, xShift + matrixOffset];
                            gY += rgb[rgbInd + 1] * matrixY[yShift + matrixOffset, xShift + matrixOffset];
                            bY += rgb[rgbInd] * matrixY[yShift + matrixOffset, xShift + matrixOffset];
                        }
                    }

                    r = Math.Sqrt(rX * rX + rY * rY);
                    g = Math.Sqrt(gX * gX + gY * gY);
                    b = Math.Sqrt(bX * bX + bY * bY);

                    r = Math.Min(Math.Max(r, 0), 255);
                    g = Math.Min(Math.Max(g, 0), 255);
                    b = Math.Min(Math.Max(b, 0), 255);

                    rgbInd = i * imageData.Stride + j * 4;

                    rgbRes[rgbInd + 3] = rgb[rgbInd + 3];
                    rgbRes[rgbInd + 2] = (byte)r;
                    rgbRes[rgbInd + 1] = (byte)g;
                    rgbRes[rgbInd] = (byte)b;
                }
            }

            Bitmap imageRes = new Bitmap(image.Width, image.Height);
            BitmapData imageResData = imageRes.LockBits(new Rectangle(0, 0, imageRes.Width, imageRes.Height), 
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(rgbRes, 0, imageResData.Scan0, rgbRes.Length);

            imageRes.UnlockBits(imageResData);

            return imageRes;
        }
    }
}
