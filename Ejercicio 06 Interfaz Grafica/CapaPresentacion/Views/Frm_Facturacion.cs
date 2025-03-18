using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDato;
using CapaNegocios;
using System.Drawing.Drawing2D;

namespace CapaPresentacion.Views
{
    public partial class Frm_Facturacion : Form
    {
        #region DLL Bordes Redondos
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        #endregion

        #region Main Variables
        private Form1 formularioPrincipal;
        private CN_Factura objNegocios = new CN_Factura();
        private CN_Factura facturacionNegocio = new CN_Factura();
        private int idFactura = 0;  // Variable para almacenar el id de la factura
        #endregion

        #region Constructor Principal
        public Frm_Facturacion(Form1 principal)
        {
            InitializeComponent();
            this.formularioPrincipal = principal;

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            pnlBotones.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlBotones.Width, pnlBotones.Height, 20, 20));
            pnlClientes.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlClientes.Width, pnlClientes.Height, 20, 20));
            pnlDGV.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlDGV.Width, pnlDGV.Height, 20, 20));
            pnlProductos.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlProductos.Width, pnlProductos.Height, 20, 20));
            pnlTotales.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlTotales.Width, pnlTotales.Height, 20, 20));
        }
        #endregion

        #region Form Load
        private void Frm_Facturacion_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarArticulos();

            txtDireccion.ReadOnly = true;
            txtCorreo.ReadOnly = true;
            txtTelefono.ReadOnly = true;
            txtDescuento.ReadOnly = true;
            txtTotal.ReadOnly = true;
            txtBruto.ReadOnly = true;
            txtPrecio.ReadOnly = true;

            btnGenerarReporte.Visible = false;
            btnGuardarFactura.Visible = false;

            PintarFondo(pnlClientes);
            PintarFondo(pnlBotones);
            PintarFondo(pnlProductos);
            PintarFondo(pnlTotales);
            PintarPaneles(pnlFondo);
        }
        #endregion

        #region Cerrar Programa
        private void botonCircular6_Click(object sender, EventArgs e)
        {
            this.Close();

            formularioPrincipal.BringToFront();
            formularioPrincipal.Show();
        }
        #endregion

        #region Mostrar detalle Factura
        private void MostrarDetalleFactura(int idFactura)
        {
            try
            {
                DataTable dt = objNegocios.MostrarDetalleFactura(idFactura);
                dgvDetalleFactura.AutoGenerateColumns = false;

                dgvDetalleFactura.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    dgvDetalleFactura.Rows.Add(
                        row["id_detalle"].ToString(),
                        row["id_articulo"].ToString(),
                        row["nombre"].ToString(),
                        row["cantidad"].ToString(),
                        row["precio"].ToString(),
                        row["subtotal"].ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar detalle: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region no se, deberia borrarlo
        //public void CargarFactura(int idFactura)
        //{
        //    idFacturaActual = idFactura;
        //}
        #endregion

        #region Boton Nueva Facturar
        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idCliente = Convert.ToInt32(cmbCliente.SelectedValue);

            idFactura = facturacionNegocio.NuevaFactura(idCliente);

            if (idFactura == 0)
            {
                MessageBox.Show("Hubo un problema al crear la factura. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvDetalleFactura.Rows.Clear();
            txtTotal.Text = "0.00";

            btnGuardarProducto.Enabled = true;
            btnGuardarFactura.Enabled = true;
            cmbArticulos.Enabled = true;
            txtCantidad.Enabled = true;
            txtPrecio.Enabled = true;

            MessageBox.Show("Nueva factura creada. Ahora puede agregar productos.", "Nueva Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnGuardarFactura.Visible = true;
            btnNuevaFactura.Visible = false;
            btnGenerarReporte.Visible = false;
        }
        #endregion

        #region Activar y Desactivar Controles
        void ActivarControles()
        {

        }
        void DesactivarControles()
        {

        }
        #endregion

        #region Calcular Total DGV
        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvDetalleFactura.Rows)
            {
                total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
            }
            txtTotal.Text = total.ToString("0.00");
        }
        #endregion

        #region Boton Guardar Producto
        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            if (idFactura == 0)
            {
                MessageBox.Show("Primero debe crear la factura seleccionando un cliente y presionando 'Nueva Factura'.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbArticulos.SelectedItem == null || string.IsNullOrWhiteSpace(txtCantidad.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Complete la información del producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id_articulo = Convert.ToInt32(cmbArticulos.SelectedValue);
            string nombreArticulo = cmbArticulos.Text;

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser un número entero mayor a cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un número decimal mayor a cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CN_Factura negocioArticulo = new CN_Factura();
            try
            {
                if (!negocioArticulo.ValidarYDescontarStock(id_articulo, cantidad))
                {
                    MessageBox.Show("No hay suficiente stock para este artículo.", "Error de stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal subtotal = cantidad * precio;

                bool exito = facturacionNegocio.InsertarDetalleFactura(idFactura, id_articulo, cantidad, precio);

                if (exito)
                {
                    dgvDetalleFactura.Rows.Insert(0,
                        id_articulo,
                        nombreArticulo,
                        cantidad,
                        precio.ToString("0.00"),
                        subtotal.ToString("0.00")
                    );

                    dgvDetalleFactura.Refresh();

                    MostrarDetalleFactura(idFactura);
                    CalcularTotal();
                    ActualizarTotales();
                }
                else
                {
                    MessageBox.Show("Hubo un error al agregar el producto. Verifique la conexión con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        #region Boton Guardar Factura
        private void btnGuardarFactura_Click(object sender, EventArgs e)
        {
            if (dgvDetalleFactura.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal total = Convert.ToDecimal(txtTotal.Text);

            if (idFactura == 0)
            {
                MessageBox.Show("La factura no ha sido creada correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool resultado = facturacionNegocio.ActualizarTotalFactura(idFactura, total);
            // bool stockActualizado = facturacionNegocio.DescontarStockFactura(idFactura);

            if (resultado) // && stockActualizado
            {
                MessageBox.Show("Factura guardada y stock actualizado correctamente correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGenerarReporte.Visible = true;
                btnGuardarFactura.Visible = false;
                btnNuevaFactura.Visible = false;
            }
            else
            {
                MessageBox.Show("Hubo un error al guardar la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Cargar Clientes al CMB
        private void CargarClientes(string filtro = "")
        {
            try
            {
                DataTable dtClientes = objNegocios.ObtenerClientesCMB(filtro);

                cmbCliente.Items.Clear();

                DataRow row = dtClientes.NewRow();
                row["nombre"] = "Seleccione un cliente";
                row["id_cliente"] = DBNull.Value;
                dtClientes.Rows.InsertAt(row, 0);

                cmbCliente.DataSource = dtClientes;

                cmbCliente.DisplayMember = "nombre";
                cmbCliente.ValueMember = "id_cliente";

                cmbCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbCliente.AutoCompleteSource = AutoCompleteSource.ListItems;

                cmbCliente.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
        }
        #endregion

        #region Cargar Articulos al CMB
        private void CargarArticulos(string filtro = "")
        {
            try
            {
                CN_Factura negocioFactura = new CN_Factura();
                DataTable dt = negocioFactura.ObtenerArticulosCMB(filtro);

                cmbArticulos.DataSource = null;

                DataRow row = dt.NewRow();
                row["nombre"] = "Seleccione un artículo";
                row["id_articulo"] = DBNull.Value;
                dt.Rows.InsertAt(row, 0);

                cmbArticulos.DataSource = dt;
                cmbArticulos.DisplayMember = "nombre";
                cmbArticulos.ValueMember = "id_articulo";

                cmbArticulos.SelectedIndex = 0;

                cmbArticulos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbArticulos.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar artículos: " + ex.Message);
            }
        }

        #endregion

        #region Rellenar datos Clientes
        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex > 0)
            {
                int idCliente = Convert.ToInt32(cmbCliente.SelectedValue);

                CargarDatosCliente(idCliente);
            }
            else
            {
                LimpiarCamposCliente();
            }
        }

        private void CargarDatosCliente(int idCliente)
        {
            try
            {
                DataTable dtCliente = objNegocios.ObtenerClientePorId(idCliente);

                if (dtCliente.Rows.Count > 0)
                {
                    DataRow row = dtCliente.Rows[0];

                    txtDireccion.Text = row["direccion"].ToString();
                    txtTelefono.Text = row["telefono"].ToString();
                    txtCorreo.Text = row["correo"].ToString();
                }
                else
                {
                    LimpiarCamposCliente();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del cliente: " + ex.Message);
            }
        }
        private void LimpiarCamposCliente()
        {
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }
        #endregion

        #region Actualizacion de Totales
        private void ActualizarTotales()
        {
            decimal subtotal = 0;
            decimal descuento = 0;
            decimal itbis = 0;
            decimal total = 0;

            foreach (DataGridViewRow row in dgvDetalleFactura.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                {
                    if (decimal.TryParse(row.Cells["Subtotal"].Value.ToString(), out decimal valorSubtotal))
                    {
                        subtotal += valorSubtotal;
                    }
                }
            }

            txtBruto.Text = subtotal.ToString("F2");

            descuento = subtotal * 0.05m;

            itbis = (subtotal - descuento) * 0.18m;

            total = (subtotal - descuento) + itbis;

            txtDescuento.Text = descuento.ToString("F2");
            txtTotal.Text = total.ToString("F2");
        }
        #endregion

        #region Detalle Factura ValueChanged
        private void dgvDetalleFactura_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ActualizarTotales();
        }





        #endregion

        #region Boton Generar Reporte
        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
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
        #endregion

        #region Rellenar datos Articulos
        private void cmbArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArticulos.SelectedIndex > 0)
            {
                int idArticulo = Convert.ToInt32(cmbArticulos.SelectedValue);

                CargarDatosArticulos(idArticulo);
            }
            else
            {
                LimpiarCamposArticulos();
            }
        }

        private void CargarDatosArticulos(int idArticulo)
        {
            try
            {
                DataTable dtArticulos = objNegocios.ObtenerArticuloPorId(idArticulo);

                if (dtArticulos.Rows.Count > 0)
                {
                    DataRow row = dtArticulos.Rows[0];

                    txtPrecio.Text = row["precio"].ToString();
                }
                else
                {
                    LimpiarCamposArticulos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del Articuo: " + ex.Message);
            }
        }
        private void LimpiarCamposArticulos()
        {
            txtPrecio.Clear();
        }
        #endregion

        #region Pintar paneles
        void PintarPaneles(Panel panel)
        {
            panel.Paint += (sender, e) =>
            {
                // Crear el gradiente lineal suave de arriba a abajo
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    panel.ClientRectangle,          // Área del panel
                    Color.FromArgb(0, 0, 40),      // Azul marino oscuro
                    Color.FromArgb(0, 0, 100),     // Azul marino más claro
                    90f))                           // Dirección de arriba hacia abajo (90 grados)
                {
                    e.Graphics.FillRectangle(brush, panel.ClientRectangle); // Aplicar gradiente
                }
            };
        }

        void PintarFondo(Panel panel)
        {
            panel.Paint += (sender, e) =>
            {
                // Crear el gradiente lineal suave de arriba a abajo
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    panel.ClientRectangle,          // Área del panel
                    Color.FromArgb(190, 220, 240), // Azul suave claro
                    Color.FromArgb(220, 220, 220), // Gris muy suave
                    90f))                           // Dirección de arriba hacia abajo (90 grados)
                {
                    e.Graphics.FillRectangle(brush, panel.ClientRectangle); // Aplicar gradiente
                }
            };
        }
        #endregion


        #region Boton Cancelar
        private void botonCircular1_Click(object sender, EventArgs e)
        {
            ResetFormulario();
        }
        #endregion


        #region Reset Formulario
        private void ResetFormulario()
        {
            txtDireccion.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtDescuento.Clear();
            txtTotal.Clear();
            txtBruto.Clear();
            txtPrecio.Clear();

            cmbCliente.SelectedIndex = 0;
            cmbArticulos.SelectedIndex = 0;

            dgvDetalleFactura.Rows.Clear();

            btnGenerarReporte.Visible = false;
            btnGuardarFactura.Visible = false;
            btnNuevaFactura.Visible = true;
            btnGuardarProducto.Enabled = false;

            idFactura = 0;

            txtDireccion.ReadOnly = true;
            txtCorreo.ReadOnly = true;
            txtTelefono.ReadOnly = true;
            txtDescuento.ReadOnly = true;
            txtTotal.ReadOnly = true;
            txtBruto.ReadOnly = true;
            txtPrecio.ReadOnly = true;
        }
        #endregion

        private void pnlFondo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlProductos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlClientes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTotales_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBotones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvDetalleFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
