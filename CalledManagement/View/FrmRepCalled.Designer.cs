
namespace CalledManagement
{
    partial class FrmRepCalled
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRepCalled));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.academycoding2DataSet = new CalledManagement.academycoding2DataSet();
            this.Query_Called_ReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Query_Called_ReportTableAdapter = new CalledManagement.academycoding2DataSetTableAdapters.Query_Called_ReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.academycoding2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Query_Called_ReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Query_Called_ReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CalledManagement.ReportCalled.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(821, 519);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // academycoding2DataSet
            // 
            this.academycoding2DataSet.DataSetName = "academycoding2DataSet";
            this.academycoding2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Query_Called_ReportBindingSource
            // 
            this.Query_Called_ReportBindingSource.DataMember = "Query_Called_Report";
            this.Query_Called_ReportBindingSource.DataSource = this.academycoding2DataSet;
            // 
            // Query_Called_ReportTableAdapter
            // 
            this.Query_Called_ReportTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRepCalled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 519);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRepCalled";
            this.Text = "Relatório  Chamados";
            this.Load += new System.EventHandler(this.FrmRepCalled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.academycoding2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Query_Called_ReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private academycoding2DataSetTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.BindingSource Query_Called_ReportBindingSource;
        private academycoding2DataSet academycoding2DataSet;
        private academycoding2DataSetTableAdapters.Query_Called_ReportTableAdapter Query_Called_ReportTableAdapter;
    }
}