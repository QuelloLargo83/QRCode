using SkiaSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neodynamic.SDK.BarcodeCore;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace QRCode
{
    public static class Utils
    {   
        /// <summary>
        /// Codifica una stringa e la converte in un file immagine sul disco
        /// </summary>
        /// <param name="code">codice da tradurre in qrcode</param>
        /// <param name="fileImage">percorso completo del file qr da salvare</param>
        public static Image CreateImage(string code, string fileImage = @"C\TEMP\qrcode.png", bool savetodisk = false)
        {
            //Create an instance of BarcodeProfessional class
            using (BarcodeProfessional bc = new BarcodeProfessional())
            {
                //Set the desired barcode type or symbology
                bc.Symbology = Symbology.QRCode;
                //Set value to encode
                bc.Code = code;
                //Generate barcode image and get buffer
                byte[] barcodeBuffer = bc.GetBarcodeImage(SKEncodedImageFormat.Png,800);

                if (savetodisk)
                {   //salvo sul disco
                    bc.Save(fileImage, SKEncodedImageFormat.Png);
                }


                using (var ms = new MemoryStream(barcodeBuffer))
                {
                    return Image.FromStream(ms);
                }

            }
        }


        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }


    }
}
