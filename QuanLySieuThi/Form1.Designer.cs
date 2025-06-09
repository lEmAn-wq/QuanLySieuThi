namespace QuanLySieuThi
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            stiReport1 = new Stimulsoft.Report.StiReport();
            SuspendLayout();
            // 
            // stiReport1
            // 
            stiReport1.CookieContainer = null;
            stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            stiReport1.HttpHeadersContainer = null;
            stiReport1.Key = "d3df7b3bd0ba40d1be2b5ab8c62cd1b0";
            stiReport1.ReferencedAssemblies = new string[]
    {
    "System.Dll",
    "System.Drawing.Dll",
    "System.Windows.Forms.Dll",
    "System.Data.Dll",
    "System.Xml.Dll",
    "Stimulsoft.Controls.Dll",
    "Stimulsoft.Base.Dll",
    "Stimulsoft.Report.Dll"
    };
            stiReport1.ReportAlias = "Report";
            stiReport1.ReportGuid = "c1503146466741cfa637a2acf8c85ee3";
            stiReport1.ReportName = "Report";
            stiReport1.ReportSource = null;
            stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            stiReport1.UseProgressInThread = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Stimulsoft.Report.StiReport stiReport1;
    }
}