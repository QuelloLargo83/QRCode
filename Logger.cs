using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRCode
{
    public interface Logger
    {
        void PrintLog(string message);
    }
        
    public class LoggerGraphic : Logger
    {
        
        /// <summary>
        /// Stampa il logger sul form del 
        /// </summary>
        /// <param name="content"></param>
        public void PrintLog(string content)
        {
            Global.LoggerFrm.LoggerAddItem(content);
        }

    }

}
