using SkiaSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRCode
{
    public static class Utils
    {   
        /// <summary>
        /// Codifica una stringa e la converte in un file immagine sul disco
        /// </summary>
        /// <param name="code"></param>
        /// <param name="fileImage"></param>
        public static void CreateImage(string code, string fileImage)
        {
            //Create an instance of BarcodeProfessional class
            using (Neodynamic.SDK.BarcodeCore.BarcodeProfessional bc = new Neodynamic.SDK.BarcodeCore.BarcodeProfessional())
            {
                //Set the desired barcode type or symbology
                bc.Symbology = Neodynamic.SDK.BarcodeCore.Symbology.QRCode;
                //Set value to encode
                bc.Code = code;
                //Generate barcode image and get buffer
                byte[] barcodeBuffer = bc.GetBarcodeImage(SkiaSharp.SKEncodedImageFormat.Png);

                bc.Save(fileImage, SKEncodedImageFormat.Png);

            }
        }
    }
}
