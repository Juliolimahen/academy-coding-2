
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HOURWORKEDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.academycoding2DataSet2 = new CalledManagement.academycoding2DataSet2();
            this.HOURWORKEDTableAdapter = new CalledManagement.academycoding2DataSet2TableAdapters.HOURWORKEDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HOURWORKEDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academycoding2DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.HOURWORKEDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CalledManagement.ReportHours .rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // HOURWORKEDBindingSource
            // 
            this.HOURWORKEDBindingSource.DataMember = "HOURWORKED";
            this.HOURWORKEDBindingSource.DataSource = this.academycoding2DataSet2;
            // 
            // academycoding2DataSet2
            // 
            this.academycoding2DataSet2.DataSetName = "academycoding2DataSet2";
            this.academycoding2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HOURWORKEDTableAdapter
            // 
            this.HOURWORKEDTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRepHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRepHours";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HOURWORKEDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academycoding2DataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HOURWORKEDBindingSource;
        private academycoding2DataSet2 academycoding2DataSet2;
        private academycoding2DataSet2TableAdapters.HOURWORKEDTableAdapter HOURWORKEDTableAdapter;
    }
}