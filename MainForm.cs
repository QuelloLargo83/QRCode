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
            MainLog.PrintLog("Creato QR code : " + this.textBox1.Text);


        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            Global.LoggerFrm.ShowDialog();
        }
    }
}
