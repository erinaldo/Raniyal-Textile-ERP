using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace MachineEyes.Reports
{
    public partial class Accounts_GeneralVoucher : DevExpress.XtraReports.UI.XtraReport
    {
        public Accounts_GeneralVoucher()
        {
            InitializeComponent();
        }

        private void xrUserID_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRLabel l = (XRLabel)sender;
            l.Text =MachineEyes.Classes.Security.User.SCodes.UserID;
        }

       
        private void xr_TotalAmount_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            try
            {
                
                double amounttotal = 0;
               
                amounttotal = Convert.ToDouble(e.Value);
                xr_TotalAmountWords.Text = MachineEyes.Classes.Accounting.ReturnAmountInWords(amounttotal);
            }
            catch
            {
            }
        }

        private void FinancialYear_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            int findex = MachineEyes.Classes.Accounting.Return_FinancialYear(MachineEyes.Classes.Accounting.RegAccounts.FinancialYear);
            if (findex != -1)
                FinancialYear.Text = MachineEyes.Classes.Accounting.FinancialYears[findex].YearFormat;
            else
                FinancialYear.Text = "Invalid";
        }

    }
}
