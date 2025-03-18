using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace CapaPresentacion.Views
{
    public partial class Frm_ReporteFactura : Form
    {

        private int idFactura;

        public Frm_ReporteFactura(int idFactura, TextBox txt)
        {
            InitializeComponent();
            this.idFactura = idFactura;

            decimal TotalFactura = decimal.Parse(txt.Text);

            // ReportParameter totalParametro = new ReportParameter("TotalFactura", TotalFactura.ToString("C2"));

            // reportViewer1.LocalReport.SetParameters(new ReportParameter[] { totalParametro });

            reportViewer1.RefreshReport();
        }

        private void Frm_ReporteFactura_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Server=CRAROX;Database=GestionVentas;Integrated Security=True;TrustServerCertificate=True"))
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_GenerarFactura", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@id_factura", idFactura);

                DataTable dt = new DataTable();
                da.Fill(dt);

                ReportDataSource rds = new ReportDataSource("DataSetFactura", dt);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
        }
    }
}