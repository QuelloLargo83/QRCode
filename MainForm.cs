﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = "QRCoder"; // titolo finestra
            

        }

        private void CreateQRBTN_Click(object sender, EventArgs e)
        {
            //var fileImage = @"C:\TEMP\qrcode.png";
            var QRcodeImage = Utils.CreateImage(this.textBox1.Text);

            var QRcodeImageResized = Utils.ResizeImage(QRcodeImage,pictureBox1.Width,pictureBox1.Height);

            this.pictureBox1.Image = QRcodeImageResized;

            LoggerGraphic MainLog = new LoggerGraphic();
            MainLog.PrintLog("Creato QR code");


            // carico immagine senza bloccare il file
            //using (var fs = new System.IO.FileStream(fileImage, System.IO.FileMode.Open))
            //{
            //    var bmp = new Bitmap(fs);
            //    this.pictureBox1.Image = (Bitmap)bmp.Clone();
            //}

        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            SecondaryForm LoggerForm = new SecondaryForm();
            LoggerForm.ShowDialog();
        }
    }
}
