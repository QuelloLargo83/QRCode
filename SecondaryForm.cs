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
        public SecondaryForm()
        {
            InitializeComponent();
        }

        public void LoggerAddItem(string Logstring)
        {   
            
            DataTable dt = new DataTable();
            dt.Columns.Add("Data");
            dt.Rows.Add( new object[] {  Logstring });

            LOGGERdataGridView.DataSource = dt;

        }

    }
}
