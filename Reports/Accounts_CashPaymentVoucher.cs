using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace MachineEyes.Reports
{
    public partial class Accounts_CashPaymentVoucher : DevExpress.XtraReports.UI.XtraReport
    {
       
        public Accounts_CashPaymentVoucher()
        {
            InitializeComponent();
        }

        private void xrUser_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRLabel l = (XRLabel)sender;
            l.Text =MachineEyes.Classes.Security.User.SCodes.UserID;
            
        }

        private void xrUserName_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRLabel l = (XRLabel)sender;
            l.Text =MachineEyes.Classes.Security.User.SCodes.UserName;
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
