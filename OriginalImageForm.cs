using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;


namespace SimpleEdit
{
    public partial class OriginalImageForm : Form
    {
        private const int indent = 10;

        public OriginalImageForm(Bitmap originalImage)
        {
            InitializeComponent();

            pictureBox.Image = originalImage;

            fitElements();
            fitImage();
        }

        private void OriginalImageForm_Resize(object sender, EventArgs e)
        {
            fitElements();
            fitImage();
        }

        private void fitElements()
        {
            pictureBox.Left = indent;
            pictureBox.Top = indent;
            pictureBox.Width = this.ClientSize.Width - indent * 2;
            pictureBox.Height = this.ClientSize.Height - indent * 2;
        }

        private void fitImage()
        {
            if (pictureBox.Image == null)
            {
                return;
            }

            if (pictureBox.Image.Width > pictureBox.Width || pictureBox.Image.Height > pictureBox.Height)
            {
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            }

            pictureBox.Invalidate();
        }
    }
}
