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
using Microsoft.IdentityModel.Tokens;

namespace CapaPresentacion
{
    public partial class Frm_Inventario : Form
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
        public Frm_Inventario()
        {
            InitializeComponent();
            CargarInventario();
            pnlSearch.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlSearch.Width, pnlSearch.Height, 20, 20));

            Default();
        }

        void Default()
        {
            lblStockAdd.Visible = false;
            lblStockRemoved.Visible = false;
            lblProductName.Visible = false;

            txtAddStock.Visible = false;
            txtRemoveStock.Visible = false;
            txtProductName.Visible = false;
            txtProductName.ReadOnly = true;

            btnAgregar.Visible = false;
            btnCancelar.Visible = false;


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lblStockAdd.Visible = true;
            lblStockRemoved.Visible = true;
            lblProductName.Visible = true;

            txtAddStock.Visible = true;
            txtRemoveStock.Visible = true;
            txtProductName.Visible = true;

            btnCancelar.Visible = true;
            btnAgregar.Visible = true;

            txtProductName.Text = DGVInventario.SelectedRows[0].Cells["Nombre"].Value.ToString();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblStockAdd.Visible = false;
            lblStockRemoved.Visible = false;
            lblProductName.Visible = false;

            txtAddStock.Visible = false;
            txtRemoveStock.Visible = false;
            txtProductName.Visible = false;

            btnAgregar.Visible = false;
            btnCancelar.Visible = false;


        }

        private void Frm_Inventario_Load(object sender, EventArgs e)
        {

        }

        private void CargarInventario()
        {
            try
            {
                DataTable dt = productoNegocio.ObtenerInventario();

                DGVInventario.AutoGenerateColumns = false;
                DGVInventario.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    int index = DGVInventario.Rows.Add();
                    DGVInventario.Rows[index].Cells["Id"].Value = row["ID"];
                    DGVInventario.Rows[index].Cells["Nombre"].Value = row["Nombre"];
                    DGVInventario.Rows[index].Cells["Stock"].Value = row["Stock"];
                    DGVInventario.Rows[index].Cells["Precio"].Value = row["Precio"];
                    DGVInventario.Rows[index].Cells["Proveedor"].Value = row["Proveedor"];
                    DGVInventario.Rows[index].Cells["FechaVencimiento"].Value = row["Fecha_Vencimiento"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el inventario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {


                int idProducto = Convert.ToInt32(DGVInventario.CurrentRow.Cells["ID"].Value);

                int stockActual = Convert.ToInt32(DGVInventario.CurrentRow.Cells["Stock"].Value);

                int anadirStock = string.IsNullOrEmpty(txtAddStock.Text) ? 0 : Convert.ToInt32(txtAddStock.Text);
                int removerStock = string.IsNullOrEmpty(txtRemoveStock.Text) ? 0 : Convert.ToInt32(txtRemoveStock.Text);

                if (txtAddStock.Text.IsNullOrEmpty() && txtRemoveStock.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("Debe de rellenar al menos un campo.");
                    return;
                }


                int nuevoStock = stockActual + anadirStock - removerStock;

                productoNegocio.EditarStock(idProducto, nuevoStock);

                DGVInventario.Rows.Clear();
                CargarInventario();

                txtAddStock.Clear();
                txtRemoveStock.Clear();

                MessageBox.Show("Stock actualizado correctamente.");
                Default();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    CargarInventario();
                }
                else
                {
                    DataTable dt = productoNegocio.BuscarInventario(textBox4.Text);

                    DGVInventario.AutoGenerateColumns = false;
                    DGVInventario.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        int index = DGVInventario.Rows.Add();
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            DGVInventario.Rows[index].Cells[i].Value = row[i];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar en el inventario: " + ex.Message);
            }
        }
    }
}
