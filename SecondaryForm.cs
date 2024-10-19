using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCode
{
    public partial class SecondaryForm : Form
    {
        DataTable dt = new DataTable();


        public SecondaryForm()
        {
            InitializeComponent();

            // Formattazione tabella logger
            dt.Columns.Add("Date");
            dt.Columns.Add("Content");
        }

        /// <summary>
        /// aggiunge una string alla tabella del log
        /// </summary>
        /// <param name="Logstring"></param>
        public void LoggerAddItem(string Logstring)
        {
            string now = DateTime.Now.ToString("M/d/yyyy HH:mm:ss");
            dt.Rows.Add( new object[] { now , Logstring });

            LOGGERdataGridView.DataSource = dt;

        }

    }
}
