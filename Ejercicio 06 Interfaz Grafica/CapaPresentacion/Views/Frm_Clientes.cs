using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaNegocios;


namespace CapaPresentacion.Views
{
    public partial class Frm_Clientes : Form
    {
        private int clienteSeleccionado = 0;

        private CN_Main objNegocios = new CN_Main();

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

        private Form1 formularioPrincipal;


        public Frm_Clientes(Form1 principal)
        {
            InitializeComponent();
            this.formularioPrincipal = principal;

            panel4.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 15, 15));
            pnlSearch.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlSearch.Width, pnlSearch.Height, 15, 15));
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            MostrarClientes();
            dataGridView1.ClearSelection();
        }




        #region lokera

        private void MostrarClientes()
        {
            DataTable dt = objNegocios.ObtenerClientes();
            dataGridView1.AutoGenerateColumns = false;

            

            dataGridView1.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(
                    row["id_cliente"].ToString(),
                    row["nombre"].ToString(),
                    row["direccion"].ToString(),
                    row["telefono"].ToString(),
                    row["correo"].ToString()
                );
            }
        }


        #endregion

        private void Frm_Clientes_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonCircular6_Click(object sender, EventArgs e)
        {
            this.Close();

            formularioPrincipal.BringToFront();
            formularioPrincipal.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text.Trim();
                string direccion = txtDireccion.Text.Trim();
                string telefono = txtTelefono.Text.Trim();
                string correo = txtCorreo.Text.Trim();

                if (string.IsNullOrWhiteSpace(nombre) ||
                    string.IsNullOrWhiteSpace(direccion) ||
                    string.IsNullOrWhiteSpace(telefono) ||
                    string.IsNullOrWhiteSpace(correo))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!EsCorreoValido(correo))
                {
                    MessageBox.Show("El correo electrónico no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string resultado = "";

                if (clienteSeleccionado == 0)
                {
                    resultado = CN_Main.Insertar(nombre, direccion, telefono, correo);
                }
                else
                {
                    resultado = CN_Main.Actualizar(clienteSeleccionado, nombre, direccion, telefono, correo);
                }

                if (resultado == "OK")
                {
                    MessageBox.Show(clienteSeleccionado == 0 ? "Cliente guardado correctamente" : "Cliente actualizado correctamente",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarCampos();
                    MostrarClientes();
                }
                else
                {
                    MessageBox.Show("Error: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EsCorreoValido(string correo)
        {
            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(correo, patronCorreo);
        }



        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtNombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idCliente = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                DialogResult confirmacion = MessageBox.Show("¿Está seguro de desactivar este cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    string resultado = CN_Main.Desactivar(idCliente);

                    if (resultado == "OK")
                    {
                        MessageBox.Show("Cliente desactivado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarClientes();
                        dataGridView1.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("Error al desactivar: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridView1.SelectedRows[0];

                clienteSeleccionado = Convert.ToInt32(fila.Cells["id"].Value);

                txtNombre.Text = fila.Cells["nombre"].Value.ToString();
                txtDireccion.Text = fila.Cells["direccion"].Value.ToString();
                txtTelefono.Text = fila.Cells["telefono"].Value.ToString();
                txtCorreo.Text = fila.Cells["correo"].Value.ToString();

                txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltro(txtSearch.Text.Trim());
            dataGridView1.ClearSelection();
        }



        private void AplicarFiltro(string texto)
        {
            string campo = "nombre";
            string filtro = texto;

            if (texto.StartsWith("d."))
            {
                campo = "direccion";
                filtro = texto.Substring(2);
            }
            else if (texto.StartsWith("t."))
            {
                campo = "telefono";
                filtro = texto.Substring(2);
            }
            else if (texto.StartsWith("c."))
            {
                campo = "correo";
                filtro = texto.Substring(2);
            }

            CargarClientes(campo, filtro);
        }

        private void CargarClientes(string campo = "nombre", string filtro = "")
        {
            DataTable dt = CN_Main.BuscarClientes(campo, filtro);
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(
                    row["id_cliente"].ToString(),
                    row["nombre"].ToString(),
                    row["direccion"].ToString(),
                    row["telefono"].ToString(),
                    row["correo"].ToString()
                );
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }

}