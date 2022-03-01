namespace MachineEyes.Reports
{
    partial class Efficiency_Weekly_GoodArticles_SubReport
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
            DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary5 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ArticleNumber = new DevExpress.XtraReports.UI.XRLabel();
            this.TotalLooms = new DevExpress.XtraReports.UI.XRLabel();
            this.RPM = new DevExpress.XtraReports.UI.XRLabel();
            this.Indexno = new DevExpress.XtraReports.UI.XRLabel();
            this.Eff_T = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.ArticleNumber,
            this.TotalLooms,
            this.RPM,
            this.Indexno,
            this.Eff_T});
            this.Detail.HeightF = 18F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ArticleNumber
            // 
            this.ArticleNumber.BorderColor = System.Drawing.Color.Silver;
            this.ArticleNumber.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.ArticleNumber.BorderWidth = 1;
            this.ArticleNumber.CanGrow = false;
            this.ArticleNumber.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ArticleNumber")});
            this.ArticleNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArticleNumber.ForeColor = System.Drawing.Color.Black;
            this.ArticleNumber.LocationFloat = new DevExpress.Utils.PointFloat(23.81369F, 0F);
            this.ArticleNumber.Name = "ArticleNumber";
            this.ArticleNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100F);
            this.ArticleNumber.SizeF = new System.Drawing.SizeF(129.8616F, 14.58333F);
            this.ArticleNumber.StylePriority.UseBorderColor = false;
            this.ArticleNumber.StylePriority.UseBorders = false;
            this.ArticleNumber.StylePriority.UseBorderWidth = false;
            this.ArticleNumber.StylePriority.UseFont = false;
            this.ArticleNumber.StylePriority.UseForeColor = false;
            this.ArticleNumber.StylePriority.UsePadding = false;
            this.ArticleNumber.StylePriority.UseTextAlignment = false;
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
            this.ArticleNumber.Summary = xrSummary1;
            this.ArticleNumber.Text = "xr_ArticleNumber";
            this.ArticleNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // TotalLooms
            // 
            this.TotalLooms.BorderColor = System.Drawing.Color.Silver;
            this.TotalLooms.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.TotalLooms.BorderWidth = 1;
            this.TotalLooms.CanGrow = false;
            this.TotalLooms.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "TotalLooms")});
            this.TotalLooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLooms.ForeColor = System.Drawing.Color.Black;
            this.TotalLooms.LocationFloat = new DevExpress.Utils.PointFloat(155.6753F, 0F);
            this.TotalLooms.Name = "TotalLooms";
            this.TotalLooms.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100F);
            this.TotalLooms.SizeF = new System.Drawing.SizeF(30.50003F, 14.58333F);
            this.TotalLooms.StylePriority.UseBorderColor = false;
            this.TotalLooms.StylePriority.UseBorders = false;
            this.TotalLooms.StylePriority.UseBorderWidth = false;
            this.TotalLooms.StylePriority.UseFont = false;
            this.TotalLooms.StylePriority.UseForeColor = false;
            this.TotalLooms.StylePriority.UsePadding = false;
            this.TotalLooms.StylePriority.UseTextAlignment = false;
            xrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
            this.TotalLooms.Summary = xrSummary2;
            this.TotalLooms.Text = "xr_ArticleNumber";
            this.TotalLooms.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // RPM
            // 
            this.RPM.BorderColor = System.Drawing.Color.Silver;
            this.RPM.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.RPM.BorderWidth = 1;
            this.RPM.CanGrow = false;
            this.RPM.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "T_RPM", "{0:#,#}")});
            this.RPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPM.ForeColor = System.Drawing.Color.Black;
            this.RPM.LocationFloat = new DevExpress.Utils.PointFloat(188.1753F, 0F);
            this.RPM.Name = "RPM";
            this.RPM.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100F);
            this.RPM.SizeF = new System.Drawing.SizeF(31.02838F, 14.58333F);
            this.RPM.StylePriority.UseBorderColor = false;
            this.RPM.StylePriority.UseBorders = false;
            this.RPM.StylePriority.UseBorderWidth = false;
            this.RPM.StylePriority.UseFont = false;
            this.RPM.StylePriority.UseForeColor = false;
            this.RPM.StylePriority.UsePadding = false;
            this.RPM.StylePriority.UseTextAlignment = false;
            xrSummary3.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
            this.RPM.Summary = xrSummary3;
            this.RPM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // Indexno
            // 
            this.Indexno.BorderColor = System.Drawing.Color.Silver;
            this.Indexno.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.Indexno.BorderWidth = 1;
            this.Indexno.CanGrow = false;
            this.Indexno.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Indexno.ForeColor = System.Drawing.Color.Black;
            this.Indexno.LocationFloat = new DevExpress.Utils.PointFloat(6.357829E-06F, 0F);
            this.Indexno.Name = "Indexno";
            this.Indexno.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100F);
            this.Indexno.SizeF = new System.Drawing.SizeF(21.8137F, 14.58333F);
            this.Indexno.StylePriority.UseBorderColor = false;
            this.Indexno.StylePriority.UseBorders = false;
            this.Indexno.StylePriority.UseBorderWidth = false;
            this.Indexno.StylePriority.UseFont = false;
            this.Indexno.StylePriority.UseForeColor = false;
            this.Indexno.StylePriority.UsePadding = false;
            this.Indexno.StylePriority.UseTextAlignment = false;
            xrSummary4.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
            this.Indexno.Summary = xrSummary4;
            this.Indexno.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.Indexno.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Indexno_BeforePrint);
            // 
            // Eff_T
            // 
            this.Eff_T.BackColor = System.Drawing.Color.Transparent;
            this.Eff_T.BorderColor = System.Drawing.Color.Silver;
            this.Eff_T.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.Eff_T.BorderWidth = 1;
            this.Eff_T.CanGrow = false;
            this.Eff_T.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "T_Eff", "{0:n1}")});
            this.Eff_T.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eff_T.ForeColor = System.Drawing.Color.Black;
            this.Eff_T.LocationFloat = new DevExpress.Utils.PointFloat(220.7136F, 0F);
            this.Eff_T.Name = "Eff_T";
            this.Eff_T.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100F);
            this.Eff_T.SizeF = new System.Drawing.SizeF(26.61975F, 14.58333F);
            this.Eff_T.StylePriority.UseBackColor = false;
            this.Eff_T.StylePriority.UseBorderColor = false;
            this.Eff_T.StylePriority.UseBorders = false;
            this.Eff_T.StylePriority.UseBorderWidth = false;
            this.Eff_T.StylePriority.UseFont = false;
            this.Eff_T.StylePriority.UseForeColor = false;
            this.Eff_T.StylePriority.UsePadding = false;
            this.Eff_T.StylePriority.UseTextAlignment = false;
            xrSummary5.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
            this.Eff_T.Summary = xrSummary5;
            this.Eff_T.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 8F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.BackColor = System.Drawing.Color.White;
            this.xrLabel2.BorderColor = System.Drawing.SystemColors.ControlText;
            this.xrLabel2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.ForeColor = System.Drawing.Color.Black;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(155.6753F, 31.33324F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(30.50003F, 19.4999F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "NL";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BackColor = System.Drawing.Color.White;
            this.xrLabel1.BorderColor = System.Drawing.SystemColors.ControlText;
            this.xrLabel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.ForeColor = System.Drawing.Color.Green;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(6.357829E-06F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(247.3333F, 30.33323F);
            this.xrLabel1.StylePriority.UseBackColor = false;
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Better Performing Articles of the week";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel6
            // 
            this.xrLabel6.BackColor = System.Drawing.Color.White;
            this.xrLabel6.BorderColor = System.Drawing.SystemColors.ControlText;
            this.xrLabel6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel6.ForeColor = System.Drawing.Color.Black;
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(220.7136F, 31.33324F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(26.61975F, 19.4999F);
            this.xrLabel6.StylePriority.UseBackColor = false;
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseForeColor = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Eff.";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel40
            // 
            this.xrLabel40.BackColor = System.Drawing.Color.White;
            this.xrLabel40.BorderColor = System.Drawing.SystemColors.ControlText;
            this.xrLabel40.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel40.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel40.ForeColor = System.Drawing.Color.Black;
            this.xrLabel40.LocationFloat = new DevExpress.Utils.PointFloat(0F, 31.33324F);
            this.xrLabel40.Name = "xrLabel40";
            this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel40.SizeF = new System.Drawing.SizeF(21.81369F, 19.4999F);
            this.xrLabel40.StylePriority.UseBackColor = false;
            this.xrLabel40.StylePriority.UseBorders = false;
            this.xrLabel40.StylePriority.UseFont = false;
            this.xrLabel40.StylePriority.UseForeColor = false;
            this.xrLabel40.StylePriority.UseTextAlignment = false;
            this.xrLabel40.Text = "#";
            this.xrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel27
            // 
            this.xrLabel27.BackColor = System.Drawing.Color.White;
            this.xrLabel27.BorderColor = System.Drawing.SystemColors.ControlText;
            this.xrLabel27.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel27.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel27.ForeColor = System.Drawing.Color.Black;
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(188.1754F, 31.33324F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(31.02835F, 19.4999F);
            this.xrLabel27.StylePriority.UseBackColor = false;
            this.xrLabel27.StylePriority.UseBorders = false;
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.StylePriority.UseForeColor = false;
            this.xrLabel27.StylePriority.UseTextAlignment = false;
            this.xrLabel27.Text = "RPM";
            this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLabel1,
            this.xrLabel40,
            this.xrLabel6,
            this.xrLabel27,
            this.xrLabel2});
            this.PageHeader.HeightF = 54F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrLabel3
            // 
            this.xrLabel3.BackColor = System.Drawing.Color.White;
            this.xrLabel3.BorderColor = System.Drawing.SystemColors.ControlText;
            this.xrLabel3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.ForeColor = System.Drawing.Color.Black;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(23.81369F, 31.33324F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(129.8616F, 19.4999F);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Article #";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // Efficiency_Weekly_GoodArticles_SubReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader});
            this.Margins = new System.Drawing.Printing.Margins(0, 595, 8, 0);
            this.SnapToGrid = false;
            this.Version = "10.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel40;
        private DevExpress.XtraReports.UI.XRLabel xrLabel27;
        private DevExpress.XtraReports.UI.XRLabel RPM;
        private DevExpress.XtraReports.UI.XRLabel Indexno;
        private DevExpress.XtraReports.UI.XRLabel Eff_T;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel ArticleNumber;
        private DevExpress.XtraReports.UI.XRLabel TotalLooms;
    }
}
