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


    public partial class Frm_Proveedor : Form
    {
        CN_Prod productoNegocio = new CN_Prod();

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

        public Frm_Proveedor()
        {
            InitializeComponent();
            pnlAddInfo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlAddInfo.Width, pnlAddInfo.Height, 20, 20));
            CargarProveedores();
            Default();
        }


        void Default()
        {
            btnAgregar.Enabled = false;
            btnGuardarEditar.Enabled = false;
            btnCancelar.Enabled = false;
            txtContactoProveedor.Enabled = false;
            txtNombreProveedor.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnAgregar.Visible = true;


            btnGuardarEditar.Visible = false;
            btnCancelar.Enabled = true;
            txtContactoProveedor.Enabled = true;
            txtNombreProveedor.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAgregar.Visible = false;
            btnGuardarEditar.Visible = true;
            btnGuardarEditar.Enabled = true;
            btnCancelar.Enabled = true;
            txtContactoProveedor.Enabled = true;
            txtNombreProveedor.Enabled = true;

            DataGridViewRow selectedRow = DGVProveedores.SelectedRows[0];
            txtNombreProveedor.Text = selectedRow.Cells["Nombre_Proveedores"].Value.ToString();
            txtContactoProveedor.Text = selectedRow.Cells["Contacto"].Value.ToString();
        }


        private void CargarProveedores()
        {
            try
            {
                DataTable dt = productoNegocio.ObtenerProveedores();

                if (dt.Rows.Count > 0)
                {
                    DGVProveedores.Rows.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        int index = DGVProveedores.Rows.Add();
                        DGVProveedores.Rows[index].Cells["ID_Proveedores"].Value = row["ID_Proveedores"];
                        DGVProveedores.Rows[index].Cells["Nombre_Proveedores"].Value = row["Nombre_Proveedores"];
                        DGVProveedores.Rows[index].Cells["Contacto"].Value = row["Contacto"];
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron proveedores activos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proveedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreProveedor.Text) ||
                    string.IsNullOrWhiteSpace(txtContactoProveedor.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int nuevoProveedorId = productoNegocio.InsertarProveedor(txtNombreProveedor.Text, txtContactoProveedor.Text);

                MessageBox.Show("Proveedor añadido correctamente. ID: " + nuevoProveedorId, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombreProveedor.Clear();
                txtContactoProveedor.Clear();

                DGVProveedores.Rows.Clear();
                CargarProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreProveedor.Text) || string.IsNullOrWhiteSpace(txtContactoProveedor.Text))
                {
                    MessageBox.Show("Por favor, ingrese todos los campos requeridos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idProveedor = Convert.ToInt32(DGVProveedores.CurrentRow.Cells["ID_Proveedores"].Value);

                productoNegocio.ActualizarProveedor(idProveedor, txtNombreProveedor.Text, txtContactoProveedor.Text);

                MessageBox.Show("Proveedor actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVProveedores.SelectedRows.Count > 0)
                {
                    int idProveedor = Convert.ToInt32(DGVProveedores.SelectedRows[0].Cells["ID_Proveedores"].Value);
                    var confirmacion = MessageBox.Show("¿Estás seguro de que deseas desactivar este proveedor?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmacion == DialogResult.Yes)
                    {
                        if (productoNegocio.EliminarProveedor(idProveedor))
                        {
                            MessageBox.Show("Proveedor desactivado correctamente.", "Proveedor desactivado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarProveedores();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un proveedor para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtContactoProveedor.Clear();
            txtNombreProveedor.Clear();
            txtContactoProveedor.Enabled = false;
            txtNombreProveedor.Enabled = false;

            btnAgregar.Enabled = false;
            btnCancelar.Enabled = false;

            btnGuardarEditar.Visible = false;
            btnAgregar.Visible = true;
        }
    }
}
