using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SkiaSharp;

namespace QRCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateQRBTN_Click(object sender, EventArgs e)
        {
            var fileImage = @"C:\TEMP\qrcode.png";
            Utils.CreateImage(this.textBox1.Text, fileImage);
          
            // carico immagine senza bloccare il file
            using (var fs = new System.IO.FileStream(fileImage, System.IO.FileMode.Open))
            {
                var bmp = new Bitmap(fs);
                this.pictureBox1.Image = (Bitmap)bmp.Clone();
            }

        }

    }
}
