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
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class CapaPresentacion : Form
    {

        private string connectionString = "Server=CRAROX;Database=Ventas;Integrated Security=true";
        N_Productos objetoCN = new N_Productos();
        private N_Medidas objetoCNM = new N_Medidas();
        private N_Categorias objetoCNC = new N_Categorias();
        private string idProducto = null;
        private bool Editar = false;

        public CapaPresentacion()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CapaPresentacion_Load(object sender, EventArgs e)
        {
            MostrarProductos();
            LlenarComboBox();
        }

        private void MostrarProductos()
        {
            DataTable productos = objetoCN.MostrarProd();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productos;

            dataGridView1.Refresh();
        }



        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    string nombreProducto = txtProducto.Text;
                    int idMedida = Convert.ToInt32(cmbMedida.SelectedValue);
                    int idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
                    decimal precio = Convert.ToDecimal(txtPrecio.Text);
                    int stock = Convert.ToInt32(txtStock.Text);

                    N_Guardar guardarN = new N_Guardar();

                    guardarN.GuardarProducto(nombreProducto, idMedida, idCategoria, precio, stock);

                    MessageBox.Show("Producto guardado correctamente.");

                    MostrarProductos();
                    LimpiarForm();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            if (Editar == true)
            {
                try
                {
                    objetoCN.EditarProd(idProducto, txtProducto.Text, Convert.ToInt32(cmbMedida.SelectedValue),
                        Convert.ToInt32(cmbCategoria.SelectedValue), Convert.ToDecimal(txtPrecio.Text), txtStock.Text);

                    MessageBox.Show("Producto editado correctamente.");

                    Editar = false;

                    MostrarProductos();
                    LimpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LlenarComboBox()
        {
            cmbMedida.DataSource = objetoCNM.ObtenerMedidas();
            cmbMedida.DisplayMember = "Nombre_Medida";
            cmbMedida.ValueMember = "ID_Medida";

            cmbCategoria.DataSource = objetoCNC.ObtenerCategorias();
            cmbCategoria.DisplayMember = "Nombre_Categoria";
            cmbCategoria.ValueMember = "ID_Categoria";
        }

     

        private void btnActu_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtProducto.Text = dataGridView1.CurrentRow.Cells["Nombre_Producto"].Value.ToString();
                cmbMedida.SelectedItem = dataGridView1.CurrentRow.Cells["ID_Medidas"].Value.ToString();
                cmbCategoria.SelectedItem = dataGridView1.CurrentRow.Cells["ID_Categoria"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
                idProducto = dataGridView1.CurrentRow.Cells["ID_Producto"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila, por favor");
            }
        }

        private void LimpiarForm()
        {
            txtProducto.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idProducto = dataGridView1.CurrentRow.Cells["ID_Producto"].Value.ToString();
                objetoCN.EliminarProd(idProducto);
                MessageBox.Show("Eliminado correctamente");
                MostrarProductos();
            }
            else
            {
                MessageBox.Show("Seleccione una fila, por favor");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToLower();

            FiltrarProductos(filtro);
        }

        public void FiltrarProductos(string filtro)
        {
            DataTable productos = new DataTable();

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_BuscarProductos", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@filtro", filtro);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(productos);
            }

            dataGridView1.DataSource = productos;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

    }
}
