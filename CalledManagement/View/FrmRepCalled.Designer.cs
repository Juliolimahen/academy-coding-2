
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
            this.CALLEDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.academycoding2DataSet1 = new CalledManagement.academycoding2DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CALLEDTableAdapter = new CalledManagement.academycoding2DataSet1TableAdapters.CALLEDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CALLEDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academycoding2DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // CALLEDBindingSource
            // 
            this.CALLEDBindingSource.DataMember = "CALLED";
            this.CALLEDBindingSource.DataSource = this.academycoding2DataSet1;
            // 
            // academycoding2DataSet1
            // 
            this.academycoding2DataSet1.DataSetName = "academycoding2DataSet1";
            this.academycoding2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CALLEDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CalledManagement.ReportCalled.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(821, 519);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // CALLEDTableAdapter
            // 
            this.CALLEDTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.CALLEDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academycoding2DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CALLEDBindingSource;
        private academycoding2DataSet1 academycoding2DataSet1;
        private academycoding2DataSet1TableAdapters.CALLEDTableAdapter CALLEDTableAdapter;
    }
}