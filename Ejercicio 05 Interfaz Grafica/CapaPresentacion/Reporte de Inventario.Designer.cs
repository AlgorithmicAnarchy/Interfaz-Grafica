namespace CapaPresentacion
{
    partial class Reporte_de_Inventario
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.farmaciaDBDataSet = new CapaPresentacion.FarmaciaDBDataSet();
            this.Listar_ProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmaciaDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listarProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listar_ProductosTableAdapter = new CapaPresentacion.FarmaciaDBDataSetTableAdapters.Listar_ProductosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Listar_ProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarProductosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "FarmaciaDT";
            reportDataSource1.Value = this.listarProductosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(951, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // farmaciaDBDataSet
            // 
            this.farmaciaDBDataSet.DataSetName = "FarmaciaDBDataSet";
            this.farmaciaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Listar_ProductosBindingSource
            // 
            this.Listar_ProductosBindingSource.DataMember = "Listar_Productos";
            this.Listar_ProductosBindingSource.DataSource = this.farmaciaDBDataSet;
            // 
            // farmaciaDBDataSetBindingSource
            // 
            this.farmaciaDBDataSetBindingSource.DataSource = this.farmaciaDBDataSet;
            this.farmaciaDBDataSetBindingSource.Position = 0;
            // 
            // listarProductosBindingSource
            // 
            this.listarProductosBindingSource.DataMember = "Listar_Productos";
            this.listarProductosBindingSource.DataSource = this.farmaciaDBDataSetBindingSource;
            // 
            // listar_ProductosTableAdapter
            // 
            this.listar_ProductosTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_de_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "Reporte_de_Inventario";
            this.Text = "Reporte_de_Inventario";
            this.Load += new System.EventHandler(this.Reporte_de_Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Listar_ProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarProductosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FarmaciaDBDataSet farmaciaDBDataSet;
        private System.Windows.Forms.BindingSource Listar_ProductosBindingSource;
        private System.Windows.Forms.BindingSource farmaciaDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource listarProductosBindingSource;
        private FarmaciaDBDataSetTableAdapters.Listar_ProductosTableAdapter listar_ProductosTableAdapter;
    }
}