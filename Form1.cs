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
using Neodynamic.SDK.BarcodeCore;
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
            this.pictureBox1.Image = Image.FromFile(fileImage);
        }

    }
}
