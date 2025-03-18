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
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Frm_Categoria : Form
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

        CN_Prod productoNegocio = new CN_Prod();
        public Frm_Categoria()
        {
            InitializeComponent();
            CargarCategorias();
            Cargar();

            pnlAddInfo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlAddInfo.Width, pnlAddInfo.Height, 20, 20));
        }

        private void DGVCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarCategorias()
        {


            try
            {
                DataTable dt = productoNegocio.ObtenerCategorias();

                //foreach (DataColumn column in dt.Columns)
                //{
                //    MessageBox.Show(column.ColumnName);
                //}

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        int index = DGVCategoria.Rows.Add();
                        DGVCategoria.Rows[index].Cells["ID_Categoria"].Value = row["ID_Categoria"];
                        DGVCategoria.Rows[index].Cells["Categoria"].Value = row["Categoria"];
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron categorías activas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Cargar()
        {
            btnAgregar.Enabled = false;
            btnCancelar.Enabled = false;
            txtNombreCategoria.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombreCategoria.Clear();
            txtNombreCategoria.Enabled = false;

            btnAgregar.Enabled = false;
            btnCancelar.Enabled = false;

            btnGuardarEditar.Visible = false;
            btnAgregar.Visible = true;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtNombreCategoria.Clear();
            btnAgregar.Enabled = true;
            btnCancelar.Enabled = true;
            txtNombreCategoria.Enabled = true;
            btnGuardarEditar.Visible = false;
            btnAgregar.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                string nombreCategoria = txtNombreCategoria.Text.Trim();

                if (string.IsNullOrEmpty(nombreCategoria))
                {
                    MessageBox.Show("El nombre de la categoría no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable dt = productoNegocio.InsertarCategoria(nombreCategoria);

                if (dt != null && dt.Rows.Count > 0)
                {
                    MessageBox.Show("Categoría agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DGVCategoria.Rows.Clear();
                    CargarCategorias();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar la categoría. Intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                txtNombreCategoria.Enabled = true;
                btnCancelar.Enabled = true;

                btnAgregar.Visible = false;
                btnGuardarEditar.Visible = true;
                if (DGVCategoria.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = DGVCategoria.SelectedRows[0];

                    txtNombreCategoria.Text = selectedRow.Cells["Categoria"].Value.ToString();


                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una categoría para cambiar el nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            try
            {

                if (DGVCategoria.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = DGVCategoria.SelectedRows[0];
                    int idCategoria = Convert.ToInt32(selectedRow.Cells["ID_Categoria"].Value);
                    string nombreCategoria = selectedRow.Cells["Categoria"].Value.ToString();
                    string nuevoNombreCategoria = txtNombreCategoria.Text.Trim();

                    if (string.IsNullOrWhiteSpace(nuevoNombreCategoria))
                    {
                        MessageBox.Show("El nombre de la categoría no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var confirmacion = MessageBox.Show("¿Estás seguro de que deseas actualizar esta categoría?",
                        "Confirmar Edición", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmacion == DialogResult.Yes)
                    {
                        var resultado = productoNegocio.EditarCategoria(idCategoria, nuevoNombreCategoria);

                        if (resultado != null && resultado.Rows.Count > 0)
                        {
                            selectedRow.Cells["Categoria"].Value = nuevoNombreCategoria;
                            MessageBox.Show("Categoría editada correctamente.", "Edición Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al editar la categoría en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    btnGuardarEditar.Visible = false;
                    btnAgregar.Visible = true;
                    btnAgregar.Enabled = false;
                    txtNombreCategoria.Enabled = false;
                    btnCancelar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una categoría para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVCategoria.SelectedRows.Count > 0)
                {
                    int idCategoria = Convert.ToInt32(DGVCategoria.SelectedRows[0].Cells["ID_Categoria"].Value);

                    var confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar esta categoría?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmacion == DialogResult.Yes)
                    {
                        productoNegocio.EliminarCategoria(idCategoria);

                        DGVCategoria.Rows.Clear();
                        CargarCategorias();

                        MessageBox.Show("Categoría eliminada correctamente.", "Categoría Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una categoría para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
