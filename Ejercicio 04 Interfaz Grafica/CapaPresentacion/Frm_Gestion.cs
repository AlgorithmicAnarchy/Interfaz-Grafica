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

    public partial class Frm_Gestion : Form
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
        private Frm_Add formAdd = null;
        CN_Prod productoNegocio = new CN_Prod();

        public Frm_Gestion()
        {
            InitializeComponent();
            pnlSearch.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlSearch.Width, pnlSearch.Height, 15, 15));
            pnlGrid.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlGrid.Width, pnlGrid.Height, 15, 15));
            CargarProductos();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int idProducto = Convert.ToInt32(DGVGestion.SelectedRows[0].Cells[0].Value);

            try
            {
                if (string.IsNullOrWhiteSpace(idProducto.ToString()))
                {
                    MessageBox.Show("Seleccione un registro antes de eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmacion == DialogResult.Yes)
                {
                    productoNegocio.Eliminar(idProducto);
                    MessageBox.Show("Registro eliminado correctamente.", "Eliminar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProductos()
        {
            try
            {
                // Obtener los productos de la base de datos
                DataTable dt = productoNegocio.ObtenerProductos();

                DGVGestion.AutoGenerateColumns = false;
                DGVGestion.Rows.Clear();

                // Cargar los productos en el DataGridView
                foreach (DataRow row in dt.Rows)
                {
                    int index = DGVGestion.Rows.Add();
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        DGVGestion.Rows[index].Cells[i].Value = row[i];
                    }
                }

                int lastIndex = DGVGestion.Rows.Add();
                DGVGestion.Rows[lastIndex].Cells[0].Value = "Test Producto";
                DGVGestion.Rows[lastIndex].Cells[1].Value = "Descripción de prueba";
                DGVGestion.Rows[lastIndex].Cells[2].Value = 0;
                DGVGestion.Rows[lastIndex].Cells[3].Value = 0;
                DGVGestion.Rows[lastIndex].Cells[4].Value = 0.00;
                DGVGestion.Rows[lastIndex].Cells[5].Value = "2025-12-31";
                DGVGestion.Rows[lastIndex].Cells[6].Value = 0;

                DGVGestion.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }





        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CargarProductos();
        }

        public event Action RefreshDataGridView;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (formAdd == null || formAdd.IsDisposed)
            {
                formAdd = new Frm_Add();
                formAdd.Show();

                formAdd.FormClosed += (s, args) => RefreshDataGridView?.Invoke();
            }
            else
            {
                formAdd.BringToFront();
            }
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (DGVGestion.SelectedRows.Count > 0)
            {
                int idProducto = Convert.ToInt32(DGVGestion.SelectedRows[0].Cells[0].Value);

                string nombreProducto = DGVGestion.SelectedRows[0].Cells[1].Value.ToString();
                string descripcion = DGVGestion.SelectedRows[0].Cells[2].Value.ToString();
                string stock = DGVGestion.SelectedRows[0].Cells[3].Value.ToString();
                string precio = DGVGestion.SelectedRows[0].Cells[4].Value.ToString();


                Frm_Add formProducto = new Frm_Add(idProducto, true, nombreProducto, descripcion, stock, precio);

                formProducto.ShowDialog();


            }
            else
            {
                MessageBox.Show("Seleccione un producto para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DGVGestion.Rows.Clear();

                DataTable dt;
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    dt = productoNegocio.ObtenerProductos();
                }
                else
                {
                    dt = productoNegocio.BuscarProductos(txtSearch.Text);
                }

                foreach (DataRow row in dt.Rows)
                {
                    int index = DGVGestion.Rows.Add();
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        DGVGestion.Rows[index].Cells[i].Value = row[i];
                    }
                }

                if (dt.Rows.Count == 0)
                {
                    int lastIndex = DGVGestion.Rows.Add();
                    DGVGestion.Rows[lastIndex].Cells[1].Value = "No se encontraron productos.";
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        if (i != 1)
                        {
                            DGVGestion.Rows[lastIndex].Cells[i].Value = "";
                        }
                    }
                }

                DGVGestion.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnMensaje_Click(object sender, EventArgs e)
        {
            MessageBox.Show(":)");
        }

        private void DGVGestion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
