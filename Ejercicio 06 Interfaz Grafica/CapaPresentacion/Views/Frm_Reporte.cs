using System;
using System.Data;
using System.Windows.Forms;
using CapaNegocios;

namespace CapaPresentacion.Views
{
    public partial class Frm_Reporte : Form
    {
        CN_Reporte objReporte = new CN_Reporte();
        private Form1 formularioPrincipal;
        private int idFactura = 0;

        public Frm_Reporte(Form1 principal)
        {
            this.formularioPrincipal = principal;
            InitializeComponent();
            CargarFactura();
        }

        void CargarFactura()
        {
            try
            {
                DataTable dtFacturas = objReporte.ObtenerFacturasConCliente();

                dgvFacturas.Rows.Clear();

                foreach (DataRow row in dtFacturas.Rows)
                {
                    dgvFacturas.Rows.Add(
                        row["id"].ToString(),
                        row["id_cliente"].ToString(),
                        row["nombre_cliente"].ToString(),
                        Convert.ToDateTime(row["fecha"]).ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las facturas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void botonCircular6_Click(object sender, EventArgs e)
        {
            this.Close();
            formularioPrincipal.BringToFront();
            formularioPrincipal.Show();
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {

            TextBox txtTotal = new TextBox();
            txtTotal.Text = "1000";

            idFactura = Convert.ToInt32(dgvFacturas.SelectedRows[0].Cells[0].Value);

            if (idFactura > 0)
            {
                Frm_ReporteFactura frmReporte = new Frm_ReporteFactura(idFactura, txtTotal);
                frmReporte.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay factura generada aún.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearch(object sender, EventArgs e)
        {
            //string filtro = txtBuscar.Text.Trim();

            //if (!string.IsNullOrEmpty(filtro))
            //{
            //    // Si es un número, asumimos que es un id_factura
            //    if (int.TryParse(filtro, out int idFactura))
            //    {
            //        CargarFacturas("id_factura", filtro);
            //    }
            //    else
            //    {
            //        CargarFacturas("nombre", filtro);
            //    }
            //}
            //else
            //{
            //    CargarFacturas("nombre", filtro);  // Se puede dejar vacío para mostrar todas las facturas
            //}
        }

        private void pnlSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlSearch_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();

            if (!string.IsNullOrEmpty(filtro))
            {
                if (int.TryParse(filtro, out int idFactura))
                {
                    CargarFacturas("id_factura", filtro);
                }
                else
                {
                    CargarFacturas("nombre", filtro);
                }
            }
            else
            {
                CargarFacturas("nombre", filtro);
            }
        }

        private void CargarFacturas(string campo, string filtro)
        {
            try
            {

                DataTable dtFacturas = objReporte.BuscarFacturasConCliente(campo, filtro);

                dgvFacturas.Rows.Clear();

                foreach (DataRow row in dtFacturas.Rows)
                {
                    dgvFacturas.Rows.Add(
                        row["id_factura"].ToString(),
                        row["id_cliente"].ToString(),
                        row["nombre_cliente"].ToString(),
                        Convert.ToDateTime(row["fecha"]).ToString("dd/MM/yyyy")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las facturas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
