namespace MachineEyes.Reports
{
    partial class Accounts_ContraLedger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xr_Particulars = new DevExpress.XtraReports.UI.XRLabel();
            this.xr_RunningBalance = new DevExpress.XtraReports.UI.XRLabel();
            this.xr_Credit = new DevExpress.XtraReports.UI.XRLabel();
            this.xr_DocNumber = new DevExpress.XtraReports.UI.XRLabel();
            this.xr_Index = new DevExpress.XtraReports.UI.XRLabel();
            this.xr_Debit = new DevExpress.XtraReports.UI.XRLabel();
            this.xr_Date = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.RepH_DocumentName = new DevExpress.XtraReports.UI.XRLabel();
            this.RepH_Company = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xr_AccountofName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xr_Balance = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbCustomer = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xr_Accountof = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xr_ToDate = new DevExpress.XtraReports.UI.XRLabel();
            this.xr_FromDate = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.tables_Accounts1 = new MachineEyes.DataTables.Tables_Accounts();
            this.accounts_VouchersTableAdapter = new MachineEyes.DataTables.Tables_AccountsTableAdapters.Accounts_VouchersTableAdapter();
            this.accounts_VouchersL5TableAdapter = new MachineEyes.DataTables.Tables_AccountsTableAdapters.Accounts_Vouchers_L5TableAdapter();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xr_TotalDebit = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xr_TotalBalance = new DevExpress.XtraReports.UI.XRLabel();
            this.xr_TotalCredit = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.FinancialYear = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.VTypeHint = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tables_Accounts1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.VTypeHint,
            this.xr_Particulars,
            this.xr_RunningBalance,
            this.xr_Credit,
            this.xr_DocNumber,
            this.xr_Index,
            this.xr_Debit,
            this.xr_Date,
            this.xrLabel7});
            this.Detail.HeightF = 38F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xr_Particulars
            // 
            this.xr_Particulars.BorderColor = System.Drawing.Color.Silver;
            this.xr_Particulars.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xr_Particulars.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Accounts_Vouchers.Accounts_Vouchers_Accounts_Vouchers_L5.AccountName_V")});
            this.xr_Particulars.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xr_Particulars.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xr_Particulars.LocationFloat = new DevExpress.Utils.PointFloat(255.451F, 0F);
            this.xr_Particulars.Multiline = true;
            this.xr_Particulars.Name = "xr_Particulars";
            this.xr_Particulars.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xr_Particulars.SizeF = new System.Drawing.SizeF(285.1521F, 17F);
            this.xr_Particulars.StylePriority.UseBorderColor = false;
            this.xr_Particulars.StylePriority.UseBorders = false;
            this.xr_Particulars.StylePriority.UseFont = false;
            this.xr_Particulars.StylePriority.UseForeColor = false;
            this.xr_Particulars.StylePriority.UseTextAlignment = false;
            this.xr_Particulars.Text = "xr_Particulars";
            this.xr_Particulars.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xr_RunningBalance
            // 
            this.xr_RunningBalance.BorderColor = System.Drawing.Color.Silver;
            this.xr_RunningBalance.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xr_RunningBalance.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xr_RunningBalance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xr_RunningBalance.LocationFloat = new DevExpress.Utils.PointFloat(679.5066F, 0F);
            this.xr_RunningBalance.Name = "xr_RunningBalance";
            this.xr_RunningBalance.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xr_RunningBalance.SizeF = new System.Drawing.SizeF(78.49341F, 17F);
            this.xr_RunningBalance.StylePriority.UseBorderColor = false;
            this.xr_RunningBalance.StylePriority.UseBorders = false;
            this.xr_RunningBalance.StylePriority.UseFont = false;
            this.xr_RunningBalance.StylePriority.UseForeColor = false;
            this.xr_RunningBalance.StylePriority.UsePadding = false;
            this.xr_RunningBalance.StylePriority.UseTextAlignment = false;
            this.xr_RunningBalance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xr_RunningBalance.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xr_RunningBalance_BeforePrint);
            // 
            // xr_Credit
            // 
            this.xr_Credit.BorderColor = System.Drawing.Color.Silver;
            this.xr_Credit.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xr_Credit.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Accounts_Vouchers.VDebitAmount", "{0:#,#}"),
            new DevExpress.XtraReports.UI.XRBinding("Tag", null, "Accounts_Vouchers.VDebitAmount")});
            this.xr_Credit.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xr_Credit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xr_Credit.LocationFloat = new DevExpress.Utils.PointFloat(610.5549F, 0F);
            this.xr_Credit.Name = "xr_Credit";
            this.xr_Credit.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xr_Credit.SizeF = new System.Drawing.SizeF(65.95172F, 17F);
            this.xr_Credit.StylePriority.UseBorderColor = false;
            this.xr_Credit.StylePriority.UseBorders = false;
            this.xr_Credit.StylePriority.UseFont = false;
            this.xr_Credit.StylePriority.UseForeColor = false;
            this.xr_Credit.StylePriority.UsePadding = false;
            this.xr_Credit.StylePriority.UseTextAlignment = false;
            this.xr_Credit.Text = "xr_Credit";
            this.xr_Credit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xr_DocNumber
            // 
            this.xr_DocNumber.BorderColor = System.Drawing.Color.Silver;
            this.xr_DocNumber.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xr_DocNumber.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Accounts_Vouchers.VNumber")});
            this.xr_DocNumber.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xr_DocNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xr_DocNumber.LocationFloat = new DevExpress.Utils.PointFloat(70.2418F, 0F);
            this.xr_DocNumber.Name = "xr_DocNumber";
            this.xr_DocNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xr_DocNumber.SizeF = new System.Drawing.SizeF(91.99249F, 17F);
            this.xr_DocNumber.StylePriority.UseBorderColor = false;
            this.xr_DocNumber.StylePriority.UseBorders = false;
            this.xr_DocNumber.StylePriority.UseFont = false;
            this.xr_DocNumber.StylePriority.UseForeColor = false;
            this.xr_DocNumber.StylePriority.UseTextAlignment = false;
            this.xr_DocNumber.Text = "xr_DocNumber";
            this.xr_DocNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xr_Index
            // 
            this.xr_Index.BorderColor = System.Drawing.Color.Silver;
            this.xr_Index.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xr_Index.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "QP_YarnStock_YarnStockDetail.GRNGIN")});
            this.xr_Index.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xr_Index.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xr_Index.LocationFloat = new DevExpress.Utils.PointFloat(3.000132F, 0F);
            this.xr_Index.Name = "xr_Index";
            this.xr_Index.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xr_Index.SizeF = new System.Drawing.SizeF(31.19961F, 17F);
            this.xr_Index.StylePriority.UseBorderColor = false;
            this.xr_Index.StylePriority.UseBorders = false;
            this.xr_Index.StylePriority.UseFont = false;
            this.xr_Index.StylePriority.UseForeColor = false;
            this.xr_Index.StylePriority.UseTextAlignment = false;
            this.xr_Index.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xr_Index.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xr_Index_BeforePrint);
            // 
            // xr_Debit
            // 
            this.xr_Debit.BorderColor = System.Drawing.Color.Silver;
            this.xr_Debit.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xr_Debit.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Accounts_Vouchers.VCreditAmount", "{0:#,#}"),
            new DevExpress.XtraReports.UI.XRBinding("Tag", null, "Accounts_Vouchers.VCreditAmount")});
            this.xr_Debit.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xr_Debit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xr_Debit.LocationFloat = new DevExpress.Utils.PointFloat(542.6031F, 0F);
            this.xr_Debit.Name = "xr_Debit";
            this.xr_Debit.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xr_Debit.SizeF = new System.Drawing.SizeF(65.95178F, 17F);
            this.xr_Debit.StylePriority.UseBorderColor = false;
            this.xr_Debit.StylePriority.UseBorders = false;
            this.xr_Debit.StylePriority.UseFont = false;
            this.xr_Debit.StylePriority.UseForeColor = false;
            this.xr_Debit.StylePriority.UsePadding = false;
            this.xr_Debit.StylePriority.UseTextAlignment = false;
            this.xr_Debit.Text = "xr_Debit";
            this.xr_Debit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xr_Date
            // 
            this.xr_Date.BorderColor = System.Drawing.Color.Silver;
            this.xr_Date.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xr_Date.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Accounts_Vouchers.VDate", "{0:dd/MM/yyyy}")});
            this.xr_Date.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xr_Date.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xr_Date.LocationFloat = new DevExpress.Utils.PointFloat(164.2342F, 0F);
            this.xr_Date.Name = "xr_Date";
            this.xr_Date.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xr_Date.SizeF = new System.Drawing.SizeF(89.21677F, 17F);
            this.xr_Date.StylePriority.UseBorderColor = false;
            this.xr_Date.StylePriority.UseBorders = false;
            this.xr_Date.StylePriority.UseFont = false;
            this.xr_Date.StylePriority.UseForeColor = false;
            this.xr_Date.StylePriority.UseTextAlignment = false;
            this.xr_Date.Text = "xr_Date";
            this.xr_Date.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel7
            // 
            this.xrLabel7.BorderColor = System.Drawing.Color.Silver;
            this.xrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Accounts_Vouchers.VParticulars")});
            this.xrLabel7.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(255.451F, 17.00001F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(285.1521F, 17F);
            this.xrLabel7.StylePriority.UseBorderColor = false;
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseForeColor = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "xr_Particulars";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 56F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.RepH_DocumentName,
            this.RepH_Company});
            this.ReportHeader.HeightF = 24F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // RepH_DocumentName
            // 
            this.RepH_DocumentName.BorderColor = System.Drawing.Color.SteelBlue;
            this.RepH_DocumentName.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.RepH_DocumentName.BorderWidth = 1;
            this.RepH_DocumentName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepH_DocumentName.LocationFloat = new DevExpress.Utils.PointFloat(543.9376F, 0F);
            this.RepH_DocumentName.Name = "RepH_DocumentName";
            this.RepH_DocumentName.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100F);
            this.RepH_DocumentName.SizeF = new System.Drawing.SizeF(175.1456F, 19.16666F);
            this.RepH_DocumentName.StylePriority.UseBorderColor = false;
            this.RepH_DocumentName.StylePriority.UseBorders = false;
            this.RepH_DocumentName.StylePriority.UseBorderWidth = false;
            this.RepH_DocumentName.StylePriority.UseFont = false;
            this.RepH_DocumentName.StylePriority.UsePadding = false;
            this.RepH_DocumentName.StylePriority.UseTextAlignment = false;
            this.RepH_DocumentName.Text = "General Ledger (AI)";
            this.RepH_DocumentName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // RepH_Company
            // 
            this.RepH_Company.BorderColor = System.Drawing.Color.SteelBlue;
            this.RepH_Company.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.RepH_Company.BorderWidth = 1;
            this.RepH_Company.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepH_Company.ForeColor = System.Drawing.Color.Black;
            this.RepH_Company.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.RepH_Company.Name = "RepH_Company";
            this.RepH_Company.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100F);
            this.RepH_Company.SizeF = new System.Drawing.SizeF(436.0677F, 19.16666F);
            this.RepH_Company.StylePriority.UseBorderColor = false;
            this.RepH_Company.StylePriority.UseBorders = false;
            this.RepH_Company.StylePriority.UseBorderWidth = false;
            this.RepH_Company.StylePriority.UseFont = false;
            this.RepH_Company.StylePriority.UseForeColor = false;
            this.RepH_Company.StylePriority.UsePadding = false;
            this.RepH_Company.StylePriority.UseTextAlignment = false;
            this.RepH_Company.Text = "Ranyal Textiles";
            this.RepH_Company.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel9,
            this.xr_AccountofName,
            this.xrLabel6,
            this.xrLabel19,
            this.xrLabel10,
            this.xr_Balance,
            this.xrLabel22,
            this.xrLabel8,
            this.xrLabel14,
            this.lbCustomer,
            this.xrLabel32,
            this.xrLabel21,
            this.xrLabel23,
            this.xr_Accountof,
            this.xrLabel12,
            this.xr_ToDate,
            this.xr_FromDate,
            this.xrLabel20});
            this.PageHeader.HeightF = 82F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xr_AccountofName
            // 
            this.xr_AccountofName.BorderColor = System.Drawing.Color.SteelBlue;
            this.xr_AccountofName.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xr_AccountofName.BorderWidth = 1;
            this.xr_AccountofName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xr_AccountofName.ForeColor = System.Drawing.Color.Black;
            this.xr_AccountofName.LocationFloat = new DevExpress.Utils.PointFloat(94.20085F, 25F);
            this.xr_AccountofName.Name = "xr_AccountofName";
            this.xr_AccountofName.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100F);
            this.xr_AccountofName.SizeF = new System.Drawing.SizeF(308.8276F, 21.99999F);
            this.xr_AccountofName.StylePriority.UseBorderColor = false;
            this.xr_AccountofName.StylePriority.UseBorders = false;
            this.xr_AccountofName.StylePriority.UseBorderWidth = false;
            this.xr_AccountofName.StylePriority.UseFont = false;
            this.xr_AccountofName.StylePriority.UseForeColor = false;
            this.xr_AccountofName.StylePriority.UsePadding = false;
            this.xr_AccountofName.StylePriority.UseTextAlignment = false;
            this.xr_AccountofName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel6
            // 
            this.xrLabel6.BorderColor = System.Drawing.Color.SteelBlue;
            this.xrLabel6.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel6.BorderWidth = 1;
            this.xrLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel6.ForeColor = System.Drawing.Color.Black;
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(2.083333F, 0F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(92.1175F, 21.99999F);
            this.xrLabel6.StylePriority.UseBorderColor = false;
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseBorderWidth = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseForeColor = false;
            this.xrLabel6.StylePriority.UsePadding = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Account ID";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel19
            // 
            this.xrLabel19.BackColor = System.Drawing.Color.SteelBlue;
            this.xrLabel19.BorderColor = System.Drawing.SystemColors.ControlText;
            this.xrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel19.ForeColor = System.Drawing.Color.White;
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(70.2418F, 59.29165F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(91.99249F, 17F);
            this.xrLabel19.StylePriority.UseBackColor = false;
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseForeColor = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "Doc #";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel10
            // 
            this.xrLabel10.BorderColor = System.Drawing.Color.SteelBlue;
            this.xrLabel10.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel10.BorderWidth = 1;
            this.xrLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel10.ForeColor = System.Drawing.Color.Black;
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(451.8202F, 0F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(92.11749F, 21.99999F);
            this.xrLabel10.StylePriority.UseBorderColor = false;
            this.xrLabel10.StylePriority.UseBorders = false;
            this.xrLabel10.StylePriority.UseBorderWidth = false;
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseForeColor = false;
            this.xrLabel10.StylePriority.UsePadding = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "Period From";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xr_Balance
            // 
            this.xr_Balance.BorderColor = System.Drawing.Color.SteelBlue;
            this.xr_Balance.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xr_Balance.BorderWidth = 1;
            this.xr_Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xr_Balance.ForeColor = System.Drawing.Color.Black;
            this.xr_Balance.LocationFloat = new DevExpress.Utils.PointFloat(295.6933F, 0F);
            this.xr_Balance.Name = "xr_Balance";
            this.xr_Balance.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100F);
            this.xr_Balance.SizeF = new System.Drawing.SizeF(107.3352F, 21.99999F);
            this.xr_Balance.StylePriority.UseBorderColor = false;
            this.xr_Balance.StylePriority.UseBorders = false;
            this.xr_Balance.StylePriority.UseBorderWidth = false;
            this.xr_Balance.StylePriority.UseFont = false;
            this.xr_Balance.StylePriority.UseForeColor = false;
            this.xr_Balance.StylePriority.UsePadding = false;
            this.xr_Balance.StylePriority.UseTextAlignment = false;
            this.xr_Balance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel22
            // 
            this.xrLabel22.BackColor = System.Drawing.Color.SteelBlue;
            this.xrLabel22.BorderColor = System.Drawing.SystemColors.ControlText;
            this.xrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel22.ForeColor = System.Drawing.Color.White;
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(2.083333F, 59.29158F);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(32.1164F, 17F);
            this.xrLabel22.StylePriority.UseBackColor = false;
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UseForeColor = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.Text = "#";
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel8
            // 
            this.xrLabel8.BorderColor = System.Drawing.Color.SteelBlue;
            this.xrLabel8.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel8.BorderWidth = 1;
            this.xrLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel8.ForeColor = System.Drawing.Color.Black;
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(2.083333F, 25F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(92.11749F, 21.99999F);
            this.xrLabel8.StylePriority.UseBorderColor = false;
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseBorderWidth = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseForeColor = false;
            this.xrLabel8.StylePriority.UsePadding = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Account Name";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel14
            // 
            this.xrLabel14.BorderColor = System.Drawing.Color.SteelBlue;
            this.xrLabel14.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel14.BorderWidth = 1;
            this.xrLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel14.ForeColor = System.Drawing.Color.Black;
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(224.4091F, 0F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(71.28419F, 21.99999F);
            this.xrLabel14.StylePriority.UseBorderColor = false;
            this.xrLabel14.StylePriority.UseBorders = false;
            this.xrLabel14.StylePriority.UseBorderWidth = false;
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseForeColor = false;
            this.xrLabel14.StylePriority.UsePadding = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "Balance B/F";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbCustomer
            // 
            this.lbCustomer.BackColor = System.Drawing.Color.SteelBlue;
            this.lbCustomer.BorderColor = System.Drawing.SystemColors.ControlText;
            this.lbCustomer.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomer.ForeColor = System.Drawing.Color.White;
            this.lbCustomer.LocationFloat = new DevExpress.Utils.PointFloat(255.451F, 59.29158F);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbCustomer.SizeF = new System.Drawing.SizeF(285.0688F, 17F);
            this.lbCustomer.StylePriority.UseBackColor = false;
            this.lbCustomer.StylePriority.UseFont = false;
            this.lbCustomer.StylePriority.UseForeColor = false;
            this.lbCustomer.StylePriority.UseTextAlignment = false;
            this.lbCustomer.Text = "Particulars";
            this.lbCustomer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel32
            // 
            this.xrLabel32.BackColor = System.Drawing.Color.SteelBlue;
            this.xrLabel32.BorderColor = System.Drawing.SystemColors.ControlText;
            this.xrLabel32.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel32.ForeColor = System.Drawing.Color.White;
            this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(164.2342F, 59.29165F);
            this.xrLabel32.Name = "xrLabel32";
            this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel32.SizeF = new System.Drawing.SizeF(89.21677F, 17F);
            this.xrLabel32.StylePriority.UseBackColor = false;
            this.xrLabel32.StylePriority.UseFont = false;
            this.xrLabel32.StylePriority.UseForeColor = false;
            this.xrLabel32.StylePriority.UseTextAlignment = false;
            this.xrLabel32.Text = "Date";
            this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel21
            // 
            this.xrLabel21.BackColor = System.Drawing.Color.SteelBlue;
            this.xrLabel21.BorderColor = System.Drawing.SystemColors.ControlText;
            this.xrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel21.ForeColor = System.Drawing.Color.White;
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(610.5548F, 59.29158F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(65.95178F, 17F);
            this.xrLabel21.StylePriority.UseBackColor = false;
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseForeColor = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.Text = "Credit";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel23
            // 
            this.xrLabel23.BackColor = System.Drawing.Color.SteelBlue;
            this.xrLabel23.BorderColor = System.Drawing.SystemColors.ControlText;
            this.xrLabel23.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel23.ForeColor = System.Drawing.Color.White;
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(679.5066F, 59.29165F);
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(78.49341F, 17F);
            this.xrLabel23.StylePriority.UseBackColor = false;
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.StylePriority.UseForeColor = false;
            this.xrLabel23.StylePriority.UseTextAlignment = false;
            this.xrLabel23.Text = "Balance";
            this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xr_Accountof
            // 
            this.xr_Accountof.BorderColor = System.Drawing.Color.SteelBlue;
            this.xr_Accountof.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xr_Accountof.BorderWidth = 1;
            this.xr_Accountof.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xr_Accountof.ForeColor = System.Drawing.Color.Black;
            this.xr_Accountof.LocationFloat = new DevExpress.Utils.PointFloat(94.20085F, 0F);
            this.xr_Accountof.Name = "xr_Accountof";
            this.xr_Accountof.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100F);
            this.xr_Accountof.SizeF = new System.Drawing.SizeF(129.2082F, 21.99999F);
            this.xr_Accountof.StylePriority.UseBorderColor = false;
            this.xr_Accountof.StylePriority.UseBorders = false;
            this.xr_Accountof.StylePriority.UseBorderWidth = false;
            this.xr_Accountof.StylePriority.UseFont = false;
            this.xr_Accountof.StylePriority.UseForeColor = false;
            this.xr_Accountof.StylePriority.UsePadding = false;
            this.xr_Accountof.StylePriority.UseTextAlignment = false;
            this.xr_Accountof.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel12
            // 
            this.xrLabel12.BorderColor = System.Drawing.Color.SteelBlue;
            this.xrLabel12.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel12.BorderWidth = 1;
            this.xrLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel12.ForeColor = System.Drawing.Color.Black;
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(451.8202F, 25F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(92.11737F, 21.99999F);
            this.xrLabel12.StylePriority.UseBorderColor = false;
            this.xrLabel12.StylePriority.UseBorders = false;
            this.xrLabel12.StylePriority.UseBorderWidth = false;
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseForeColor = false;
            this.xrLabel12.StylePriority.UsePadding = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "Period Upto";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xr_ToDate
            // 
            this.xr_ToDate.BorderColor = System.Drawing.Color.SteelBlue;
            this.xr_ToDate.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xr_ToDate.BorderWidth = 1;
            this.xr_ToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xr_ToDate.ForeColor = System.Drawing.Color.Black;
            this.xr_ToDate.LocationFloat = new DevExpress.Utils.PointFloat(543.9376F, 25F);
            this.xr_ToDate.Name = "xr_ToDate";
            this.xr_ToDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100F);
            this.xr_ToDate.SizeF = new System.Drawing.SizeF(175.1458F, 21.99999F);
            this.xr_ToDate.StylePriority.UseBorderColor = false;
            this.xr_ToDate.StylePriority.UseBorders = false;
            this.xr_ToDate.StylePriority.UseBorderWidth = false;
            this.xr_ToDate.StylePriority.UseFont = false;
            this.xr_ToDate.StylePriority.UseForeColor = false;
            this.xr_ToDate.StylePriority.UsePadding = false;
            this.xr_ToDate.StylePriority.UseTextAlignment = false;
            this.xr_ToDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xr_FromDate
            // 
            this.xr_FromDate.BorderColor = System.Drawing.Color.SteelBlue;
            this.xr_FromDate.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xr_FromDate.BorderWidth = 1;
            this.xr_FromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xr_FromDate.ForeColor = System.Drawing.Color.Black;
            this.xr_FromDate.LocationFloat = new DevExpress.Utils.PointFloat(543.9376F, 0F);
            this.xr_FromDate.Name = "xr_FromDate";
            this.xr_FromDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100F);
            this.xr_FromDate.SizeF = new System.Drawing.SizeF(175.1458F, 21.99999F);
            this.xr_FromDate.StylePriority.UseBorderColor = false;
            this.xr_FromDate.StylePriority.UseBorders = false;
            this.xr_FromDate.StylePriority.UseBorderWidth = false;
            this.xr_FromDate.StylePriority.UseFont = false;
            this.xr_FromDate.StylePriority.UseForeColor = false;
            this.xr_FromDate.StylePriority.UsePadding = false;
            this.xr_FromDate.StylePriority.UseTextAlignment = false;
            this.xr_FromDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel20
            // 
            this.xrLabel20.BackColor = System.Drawing.Color.SteelBlue;
            this.xrLabel20.BorderColor = System.Drawing.SystemColors.ControlText;
            this.xrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel20.ForeColor = System.Drawing.Color.White;
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(542.603F, 59.29165F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(65.95178F, 17F);
            this.xrLabel20.StylePriority.UseBackColor = false;
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseForeColor = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "Debit";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // tables_Accounts1
            // 
            this.tables_Accounts1.DataSetName = "Tables_Accounts";
            this.tables_Accounts1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accounts_VouchersTableAdapter
            // 
            this.accounts_VouchersTableAdapter.ClearBeforeFill = true;
            // 
            // accounts_VouchersL5TableAdapter
            // 
            this.accounts_VouchersL5TableAdapter.ClearBeforeFill = true;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xr_TotalDebit,
            this.xrLabel5,
            this.xr_TotalBalance,
            this.xr_TotalCredit});
            this.ReportFooter.HeightF = 21F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xr_TotalDebit
            // 
            this.xr_TotalDebit.BorderColor = System.Drawing.SystemColors.ControlText;
            this.xr_TotalDebit.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xr_TotalDebit.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Accounts_Vouchers.VCreditAmount")});
            this.xr_TotalDebit.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xr_TotalDebit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xr_TotalDebit.LocationFloat = new DevExpress.Utils.PointFloat(542.603F, 0F);
            this.xr_TotalDebit.Name = "xr_TotalDebit";
            this.xr_TotalDebit.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xr_TotalDebit.SizeF = new System.Drawing.SizeF(65.95178F, 19F);
            this.xr_TotalDebit.StylePriority.UseBorders = false;
            this.xr_TotalDebit.StylePriority.UseFont = false;
            this.xr_TotalDebit.StylePriority.UseForeColor = false;
            this.xr_TotalDebit.StylePriority.UsePadding = false;
            this.xr_TotalDebit.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:#,#}";
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xr_TotalDebit.Summary = xrSummary1;
            this.xr_TotalDebit.Text = "xr_TotalDebit";
            this.xr_TotalDebit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel5
            // 
            this.xrLabel5.BorderColor = System.Drawing.SystemColors.ControlText;
            this.xrLabel5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel5.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(474.568F, 0F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(65.95178F, 19F);
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseForeColor = false;
            this.xrLabel5.StylePriority.UsePadding = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            xrSummary2.FormatString = "{0:#,#}";
            this.xrLabel5.Summary = xrSummary2;
            this.xrLabel5.Text = "Total";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xr_TotalBalance
            // 
            this.xr_TotalBalance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.xr_TotalBalance.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xr_TotalBalance.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xr_TotalBalance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xr_TotalBalance.LocationFloat = new DevExpress.Utils.PointFloat(679.5065F, 0F);
            this.xr_TotalBalance.Name = "xr_TotalBalance";
            this.xr_TotalBalance.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xr_TotalBalance.SizeF = new System.Drawing.SizeF(78.49347F, 19F);
            this.xr_TotalBalance.StylePriority.UseBorders = false;
            this.xr_TotalBalance.StylePriority.UseFont = false;
            this.xr_TotalBalance.StylePriority.UseForeColor = false;
            this.xr_TotalBalance.StylePriority.UsePadding = false;
            this.xr_TotalBalance.StylePriority.UseTextAlignment = false;
            this.xr_TotalBalance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xr_TotalBalance.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xr_TotalBalance_BeforePrint);
            // 
            // xr_TotalCredit
            // 
            this.xr_TotalCredit.BorderColor = System.Drawing.SystemColors.ControlText;
            this.xr_TotalCredit.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xr_TotalCredit.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Accounts_Vouchers.VDebitAmount")});
            this.xr_TotalCredit.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xr_TotalCredit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xr_TotalCredit.LocationFloat = new DevExpress.Utils.PointFloat(610.5549F, 0F);
            this.xr_TotalCredit.Name = "xr_TotalCredit";
            this.xr_TotalCredit.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xr_TotalCredit.SizeF = new System.Drawing.SizeF(65.95172F, 19F);
            this.xr_TotalCredit.StylePriority.UseBorders = false;
            this.xr_TotalCredit.StylePriority.UseFont = false;
            this.xr_TotalCredit.StylePriority.UseForeColor = false;
            this.xr_TotalCredit.StylePriority.UsePadding = false;
            this.xr_TotalCredit.StylePriority.UseTextAlignment = false;
            xrSummary3.FormatString = "{0:#,#}";
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xr_TotalCredit.Summary = xrSummary3;
            this.xr_TotalCredit.Text = "xr_TotalCredit";
            this.xr_TotalCredit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrPageInfo1,
            this.xrPageInfo2,
            this.xrLabel3,
            this.xrLabel27,
            this.FinancialYear});
            this.PageFooter.HeightF = 27F;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrLabel1
            // 
            this.xrLabel1.BorderColor = System.Drawing.Color.SteelBlue;
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.BorderWidth = 1;
            this.xrLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.ForeColor = System.Drawing.Color.Black;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(1.500003F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(53.13837F, 15.66666F);
            this.xrLabel1.StylePriority.UseBorderColor = false;
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseBorderWidth = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.StylePriority.UsePadding = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Page";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(54.63842F, 0F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(50.68726F, 15.66666F);
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.Format = "{0:dddd, dd MMMM, yyyy h:mm tt}";
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(244.0833F, 0F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(229.2029F, 15.66666F);
            this.xrPageInfo2.StylePriority.UseTextAlignment = false;
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.BorderColor = System.Drawing.Color.SteelBlue;
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel3.BorderWidth = 1;
            this.xrLabel3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.ForeColor = System.Drawing.Color.Black;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(117.5702F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(126.5131F, 15.66666F);
            this.xrLabel3.StylePriority.UseBorderColor = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseBorderWidth = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.StylePriority.UsePadding = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Printing Date & Time";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel27
            // 
            this.xrLabel27.BackColor = System.Drawing.Color.Black;
            this.xrLabel27.BorderColor = System.Drawing.Color.Black;
            this.xrLabel27.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel27.BorderWidth = 1;
            this.xrLabel27.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel27.ForeColor = System.Drawing.Color.White;
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(598.6177F, 0F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(95.31609F, 20.95832F);
            this.xrLabel27.StylePriority.UseBackColor = false;
            this.xrLabel27.StylePriority.UseBorderColor = false;
            this.xrLabel27.StylePriority.UseBorders = false;
            this.xrLabel27.StylePriority.UseBorderWidth = false;
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.StylePriority.UseForeColor = false;
            this.xrLabel27.StylePriority.UsePadding = false;
            this.xrLabel27.StylePriority.UseTextAlignment = false;
            this.xrLabel27.Text = "Financial Year";
            this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // FinancialYear
            // 
            this.FinancialYear.BackColor = System.Drawing.Color.Black;
            this.FinancialYear.BorderColor = System.Drawing.Color.Black;
            this.FinancialYear.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.FinancialYear.BorderWidth = 1;
            this.FinancialYear.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinancialYear.ForeColor = System.Drawing.Color.White;
            this.FinancialYear.LocationFloat = new DevExpress.Utils.PointFloat(693.9338F, 0F);
            this.FinancialYear.Name = "FinancialYear";
            this.FinancialYear.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.FinancialYear.SizeF = new System.Drawing.SizeF(64.06609F, 20.95832F);
            this.FinancialYear.StylePriority.UseBackColor = false;
            this.FinancialYear.StylePriority.UseBorderColor = false;
            this.FinancialYear.StylePriority.UseBorders = false;
            this.FinancialYear.StylePriority.UseBorderWidth = false;
            this.FinancialYear.StylePriority.UseFont = false;
            this.FinancialYear.StylePriority.UseForeColor = false;
            this.FinancialYear.StylePriority.UsePadding = false;
            this.FinancialYear.StylePriority.UseTextAlignment = false;
            this.FinancialYear.Text = "2014-2015";
            this.FinancialYear.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.FinancialYear.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.FinancialYear_BeforePrint);
            // 
            // xrLabel9
            // 
            this.xrLabel9.BackColor = System.Drawing.Color.SteelBlue;
            this.xrLabel9.BorderColor = System.Drawing.SystemColors.ControlText;
            this.xrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel9.ForeColor = System.Drawing.Color.White;
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(36.19973F, 59.29165F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(32.1164F, 17F);
            this.xrLabel9.StylePriority.UseBackColor = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseForeColor = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "VT";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // VTypeHint
            // 
            this.VTypeHint.BorderColor = System.Drawing.Color.Silver;
            this.VTypeHint.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.VTypeHint.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "VTypeHint")});
            this.VTypeHint.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VTypeHint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.VTypeHint.LocationFloat = new DevExpress.Utils.PointFloat(36.19973F, 0F);
            this.VTypeHint.Name = "VTypeHint";
            this.VTypeHint.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.VTypeHint.SizeF = new System.Drawing.SizeF(32.11639F, 17F);
            this.VTypeHint.StylePriority.UseBorderColor = false;
            this.VTypeHint.StylePriority.UseBorders = false;
            this.VTypeHint.StylePriority.UseFont = false;
            this.VTypeHint.StylePriority.UseForeColor = false;
            this.VTypeHint.StylePriority.UseTextAlignment = false;
            this.VTypeHint.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // Accounts_ContraLedger
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader,
            this.ReportFooter,
            this.PageFooter});
            this.DataAdapter = this.accounts_VouchersTableAdapter;
            this.DataMember = "Accounts_Vouchers";
            this.DataSource = this.tables_Accounts1;
            this.Margins = new System.Drawing.Printing.Margins(64, 28, 100, 56);
            this.SnapToGrid = false;
            this.Version = "10.1";
            ((System.ComponentModel.ISupportInitialize)(this.tables_Accounts1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        public DevExpress.XtraReports.UI.XRLabel RepH_DocumentName;
        public DevExpress.XtraReports.UI.XRLabel RepH_Company;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        public DevExpress.XtraReports.UI.XRLabel xr_AccountofName;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        public DevExpress.XtraReports.UI.XRLabel xr_Balance;
        private DevExpress.XtraReports.UI.XRLabel xrLabel22;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel lbCustomer;
        private DevExpress.XtraReports.UI.XRLabel xrLabel32;
        private DevExpress.XtraReports.UI.XRLabel xrLabel21;
        private DevExpress.XtraReports.UI.XRLabel xrLabel23;
        public DevExpress.XtraReports.UI.XRLabel xr_Accountof;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        public DevExpress.XtraReports.UI.XRLabel xr_ToDate;
        public DevExpress.XtraReports.UI.XRLabel xr_FromDate;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DataTables.Tables_Accounts tables_Accounts1;
        private DataTables.Tables_AccountsTableAdapters.Accounts_VouchersTableAdapter accounts_VouchersTableAdapter;
        public DataTables.Tables_AccountsTableAdapters.Accounts_Vouchers_L5TableAdapter accounts_VouchersL5TableAdapter;
        private DevExpress.XtraReports.UI.XRLabel xr_Credit;
        private DevExpress.XtraReports.UI.XRLabel xr_DocNumber;
        private DevExpress.XtraReports.UI.XRLabel xr_Index;
        private DevExpress.XtraReports.UI.XRLabel xr_Debit;
        private DevExpress.XtraReports.UI.XRLabel xr_RunningBalance;
        private DevExpress.XtraReports.UI.XRLabel xr_Date;
        private DevExpress.XtraReports.UI.XRLabel xr_Particulars;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel xr_TotalDebit;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xr_TotalBalance;
        private DevExpress.XtraReports.UI.XRLabel xr_TotalCredit;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel27;
        private DevExpress.XtraReports.UI.XRLabel FinancialYear;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel VTypeHint;
    }
}
