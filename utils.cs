using SkiaSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neodynamic.SDK.BarcodeCore;

namespace QRCode
{
    public static class Utils
    {   
        /// <summary>
        /// Codifica una stringa e la converte in un file immagine sul disco
        /// </summary>
        /// <param name="code">codice da tradurre in qrcode</param>
        /// <param name="fileImage">percorso completo del file qr da salvare</param>
        public static void CreateImage(string code, string fileImage)
        {
            //Create an instance of BarcodeProfessional class
            using (BarcodeProfessional bc = new BarcodeProfessional())
            {
                //Set the desired barcode type or symbology
                bc.Symbology = Symbology.QRCode;
                //Set value to encode
                bc.Code = code;
                //Generate barcode image and get buffer
                byte[] barcodeBuffer = bc.GetBarcodeImage(SKEncodedImageFormat.Png);

                bc.Save(fileImage, SKEncodedImageFormat.Png);

            }
        }
    }
}
