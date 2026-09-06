using System;
using System.Drawing;
using System.Windows.Forms;

namespace targil8
{
    public partial class Form1 : Form
    {
        string imagePath = @"C:\Users\lolex\Downloads\logo.png";

        public Form1()
        {
            InitializeComponent();

            this.BackgroundImage = Image.FromFile(imagePath);
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnFlip_Click(object sender, EventArgs e)
        {
            this.BackgroundImage.RotateFlip(
                RotateFlipType.RotateNoneFlipX
            );

            this.Invalidate();
        }
    }
}