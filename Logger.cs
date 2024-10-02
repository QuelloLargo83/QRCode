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
 
        public void PrintLog(string content)
        {
            SecondaryForm Log = new SecondaryForm();
            Log.LoggerAddItem(content);
            Log.ShowDialog();
        }

    }

}
