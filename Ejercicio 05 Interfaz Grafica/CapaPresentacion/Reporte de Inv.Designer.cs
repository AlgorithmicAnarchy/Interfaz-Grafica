namespace CapaPresentacion
{
    partial class Reporte_de_Inv
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
            this.spMostrarInventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mostrarInventarioDataSet = new CapaPresentacion.MostrarInventarioDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_MostrarInventarioTableAdapter = new CapaPresentacion.MostrarInventarioDataSetTableAdapters.sp_MostrarInventarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spMostrarInventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarInventarioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // spMostrarInventarioBindingSource
            // 
            this.spMostrarInventarioBindingSource.DataMember = "sp_MostrarInventario";
            this.spMostrarInventarioBindingSource.DataSource = this.mostrarInventarioDataSet;
            // 
            // mostrarInventarioDataSet
            // 
            this.mostrarInventarioDataSet.DataSetName = "MostrarInventarioDataSet";
            this.mostrarInventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spMostrarInventarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(933, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_MostrarInventarioTableAdapter
            // 
            this.sp_MostrarInventarioTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_de_Inv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte_de_Inv";
            this.Text = "Reporte_de_Inv";
            this.Load += new System.EventHandler(this.Reporte_de_Inv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spMostrarInventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarInventarioDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MostrarInventarioDataSet mostrarInventarioDataSet;
        private System.Windows.Forms.BindingSource spMostrarInventarioBindingSource;
        private MostrarInventarioDataSetTableAdapters.sp_MostrarInventarioTableAdapter sp_MostrarInventarioTableAdapter;
    }
}