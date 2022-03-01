using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace MachineEyes.Reports
{
    public partial class Store_PurchaseRegister : DevExpress.XtraReports.UI.XtraReport
    {
        int indexno = 0;
        public Store_PurchaseRegister()
        {
            InitializeComponent();
        }

        private void PRIndexNumber_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            indexno++;
            XRLabel xr = (XRLabel)sender;
            xr.Text = indexno.ToString();
        }

        private void GroupFooter1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
        

    }
}
