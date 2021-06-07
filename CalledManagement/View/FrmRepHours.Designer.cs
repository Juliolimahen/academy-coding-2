
namespace CalledManagement
{
    partial class FrmRepHours
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRepHours));
            this.Query_Hours_ReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.academycoding2DataSet = new CalledManagement.academycoding2DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Query_Hours_ReportTableAdapter = new CalledManagement.academycoding2DataSetTableAdapters.Query_Hours_ReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Query_Hours_ReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academycoding2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Query_Hours_ReportBindingSource
            // 
            this.Query_Hours_ReportBindingSource.DataMember = "Query_Hours_Report";
            this.Query_Hours_ReportBindingSource.DataSource = this.academycoding2DataSet;
            // 
            // academycoding2DataSet
            // 
            this.academycoding2DataSet.DataSetName = "academycoding2DataSet";
            this.academycoding2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Query_Hours_ReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CalledManagement.ReportHours .rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Query_Hours_ReportTableAdapter
            // 
            this.Query_Hours_ReportTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRepHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRepHours";
            this.Text = "Relatório Horas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Query_Hours_ReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academycoding2DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Query_Hours_ReportBindingSource;
        private academycoding2DataSet academycoding2DataSet;
        private academycoding2DataSetTableAdapters.Query_Hours_ReportTableAdapter Query_Hours_ReportTableAdapter;
    }
}