using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaNegocios;

namespace CapaPresentacion.Views
{
    public partial class Frm_Articulos : Form
    {

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

        private CN_Main objNegocios = new CN_Main();
        private Form1 formularioPrincipal;
        private int articuloSeleccionado = 0;
        public Frm_Articulos(Form1 principal)
        {
            InitializeComponent();
            this.formularioPrincipal = principal;

            panel5.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 15, 15));
            pnlSearch.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlSearch.Width, pnlSearch.Height, 15, 15));
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            MostrarArticulos();
            dataGridView2.ClearSelection();
        }

        private void MostrarArticulos()
        {
            DataTable dt = objNegocios.ObtenerArticulos();
            dataGridView2.AutoGenerateColumns = false;



            dataGridView2.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                dataGridView2.Rows.Add(
                    row["ID_Articulo"].ToString(),
                    row["nombre"].ToString(),
                    row["precio"].ToString(),
                    row["stock"].ToString()
                );
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            // Defino variables sin convertir directamente
            decimal precio = 0;
            int stock = 0;

            // Validar campos antes de continuar
            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Intento convertir precio
            if (!decimal.TryParse(txtPrecio.Text.Trim(), out precio))
            {
                MessageBox.Show("El precio debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Intento convertir stock
            if (!int.TryParse(txtStock.Text.Trim(), out stock))
            {
                MessageBox.Show("El stock debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string resultado = "";

            if (articuloSeleccionado == 0)
            {
                resultado = CN_Main.InsertarArticulos(nombre, precio, stock);
            }
            else
            {
                resultado = CN_Main.ActualizarArticulo(articuloSeleccionado, nombre, precio, stock);
            }

            if (resultado == "OK")
            {
                MessageBox.Show(articuloSeleccionado == 0 ? "Artículo guardado correctamente" : "Artículo actualizado correctamente",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                MostrarArticulos();
            }
            else
            {
                MessageBox.Show("Error: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtStock.Clear();
            txtPrecio.Clear();
            txtNombre.Focus();
        }

        private void botonCircular6_Click(object sender, EventArgs e)
        {
            this.Close();

            formularioPrincipal.BringToFront();
            formularioPrincipal.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int idArticulo = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["ID_articulo"].Value);

                DialogResult confirmacion = MessageBox.Show("¿Está seguro de desactivar este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    string resultado = CN_Main.DesactivarArticulo(idArticulo);

                    if (resultado == "OK")
                    {
                        MessageBox.Show("Cliente desactivado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarArticulos();
                        dataGridView2.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("Error al desactivar: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un articulo de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridView2.SelectedRows[0];

                articuloSeleccionado = Convert.ToInt32(fila.Cells["id_articulo"].Value);

                txtNombre.Text = fila.Cells["NombreArticulo"].Value.ToString();
                txtPrecio.Text = fila.Cells["precio"].Value.ToString();
                txtStock.Text = fila.Cells["stock"].Value.ToString();

                txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("Seleccione un articulo para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BuscarArticulos(string filtro)
        {
            try
            {
                DataTable dt = objNegocios.BuscarArticulos(filtro);
                dataGridView2.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    dataGridView2.Rows.Add(
                        row["ID_Articulo"].ToString(),
                        row["nombre"].ToString(),
                        row["precio"].ToString(),
                        row["stock"].ToString()
                    );
                }

                dataGridView2.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar artículos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BuscarArticulos(txtSearch.Text.Trim());
        }

        private void Frm_Articulos_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
