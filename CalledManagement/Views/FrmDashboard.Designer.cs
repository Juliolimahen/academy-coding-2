
namespace CalledManagement.Views
{
    partial class FrmDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstbxUserCalled = new System.Windows.Forms.ListBox();
            this.academycoding2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.academycoding2DataSet = new CalledManagement.academycoding2DataSet();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.academycoding2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academycoding2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstbxUserCalled);
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Location = new System.Drawing.Point(40, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 409);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lstbxUserCalled
            // 
            this.lstbxUserCalled.DataSource = this.academycoding2DataSetBindingSource;
            this.lstbxUserCalled.FormattingEnabled = true;
            this.lstbxUserCalled.Location = new System.Drawing.Point(26, 34);
            this.lstbxUserCalled.Name = "lstbxUserCalled";
            this.lstbxUserCalled.Size = new System.Drawing.Size(353, 147);
            this.lstbxUserCalled.TabIndex = 5;
            // 
            // academycoding2DataSetBindingSource
            // 
            this.academycoding2DataSetBindingSource.DataSource = this.academycoding2DataSet;
            this.academycoding2DataSetBindingSource.Position = 0;
            // 
            // academycoding2DataSet
            // 
            this.academycoding2DataSet.DataSetName = "academycoding2DataSet";
            this.academycoding2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(42, 202);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(337, 185);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(728, 55);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 681);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.monthCalendar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDashboard";
            this.Text = "Dashboard";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.academycoding2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academycoding2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstbxUserCalled;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.BindingSource academycoding2DataSetBindingSource;
        private academycoding2DataSet academycoding2DataSet;
    }
}