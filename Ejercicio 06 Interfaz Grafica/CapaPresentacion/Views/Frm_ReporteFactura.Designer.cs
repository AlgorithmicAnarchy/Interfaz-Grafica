namespace CapaPresentacion.Views
{
    partial class Frm_ReporteFactura
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
            this.spGenerarFacturaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CapaPresentacion.Reports.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spGenerarFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_GenerarFacturaTableAdapter = new CapaPresentacion.Reports.DataSet1TableAdapters.sp_GenerarFacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spGenerarFacturaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGenerarFacturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spGenerarFacturaBindingSource1
            // 
            this.spGenerarFacturaBindingSource1.DataMember = "sp_GenerarFactura";
            this.spGenerarFacturaBindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetFactura";
            reportDataSource1.Value = this.spGenerarFacturaBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reports.ReporteFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1150, 700);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // spGenerarFacturaBindingSource
            // 
            this.spGenerarFacturaBindingSource.DataMember = "sp_GenerarFactura";
            this.spGenerarFacturaBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // sp_GenerarFacturaTableAdapter
            // 
            this.sp_GenerarFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_ReporteFactura
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1150, 700);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ReporteFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ReporteFactura";
            this.Load += new System.EventHandler(this.Frm_ReporteFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spGenerarFacturaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGenerarFacturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spGenerarFacturaBindingSource1;
        private Reports.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource spGenerarFacturaBindingSource;
        private Reports.DataSet1TableAdapters.sp_GenerarFacturaTableAdapter sp_GenerarFacturaTableAdapter;
    }
}