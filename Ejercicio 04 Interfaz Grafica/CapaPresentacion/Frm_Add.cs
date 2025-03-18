using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    
    public partial class Frm_Add : Form
    {
        public string DatoRecibido { get; set; }
        public string Descripcion { get; set; }
        public string Stock { get; set; }
        public string Precio { get; set; }

        CN_Prod productoNegocio = new CN_Prod();

        private int productoID;
        private bool isEditMode;

        public Frm_Add(int idProducto, bool editMode, string datoRecibido, string descripcion, string stock, string precio)
        {
            InitializeComponent();
            productoID = idProducto;
            isEditMode = editMode;

            DatoRecibido = datoRecibido;
            Descripcion = descripcion;
            Stock = stock;
            Precio = precio;

            txtNombre.Text = DatoRecibido;
            txtDescripcion.Text = Descripcion;
            txtStock.Text = Stock;
            txtPrecio.Text = Precio;

            Source();
        }

        public Frm_Add()
        {
            InitializeComponent();
            Source();
        }

        private void ComboBoxItemSeleccionado(string datoRecibido, System.Windows.Forms.ComboBox comboBox)
        {
            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                if (comboBox.Items[i].ToString() == datoRecibido)
                {
                    comboBox.SelectedIndex = i;
                    break;
                }
            }
        }



        private void CargarDatosProducto()
        {
            try
            {
                DataTable dt = productoNegocio.ObtenerProductoPorID(productoID);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txt_ID.Text = row["ID_Productos"].ToString();
                    txtNombre.Text = row["Nombre_P"].ToString();
                    txtDescripcion.Text = row["Descripción"].ToString();
                    txtStock.Text = row["Stock"].ToString();
                    txtPrecio.Text = row["Precio"].ToString();
                    dtpVencimiento.Value = Convert.ToDateTime(row["Fecha_Vencimiento"]);
                    cmbCategoria.SelectedValue = row["ID_Categoria"];
                    cmbProveedor.SelectedValue = row["ID_Proveedor"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        

        
        private void Frm_Add_Load(object sender, EventArgs e)
        {

        }

        public void LoadDataForEdit(int id, string nombre, string descripcion, int stock, decimal precio, DateTime fechaVencimiento, int idCategoria, int idProveedor)
        {
            isEditMode = true;
            productoID = id;

            txtNombre.Text = nombre;
            txtDescripcion.Text = descripcion;
            txtStock.Text = stock.ToString();
            txtPrecio.Text = precio.ToString();
            dtpVencimiento.Text = fechaVencimiento.ToString("yyyy-MM-dd");

            cmbCategoria.SelectedValue = idCategoria;
            cmbProveedor.SelectedValue = idProveedor;
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Source()
        {
            cmbCategoria.DataSource = productoNegocio.VerCategorias();
            cmbCategoria.DisplayMember = "Categoria";
            cmbCategoria.ValueMember = "ID_Categoria";

            cmbProveedor.DataSource = productoNegocio.VerProveedores();
            cmbProveedor.DisplayMember = "Nombre_Proveedores";
            cmbProveedor.ValueMember = "ID_Proveedores";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                    string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                    string.IsNullOrWhiteSpace(txtStock.Text) ||
                    !int.TryParse(txtStock.Text, out int stock) ||
                    !decimal.TryParse(txtPrecio.Text, out decimal precio) ||
                    cmbCategoria.SelectedIndex < 0 ||
                    cmbProveedor.SelectedIndex < 0)
                {
                    MessageBox.Show("Rellene los campos correctamente para continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(cmbCategoria.SelectedValue?.ToString(), out int idCategoria))
                {
                    MessageBox.Show("Seleccione una categoría válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(cmbProveedor.SelectedValue?.ToString(), out int idProveedor))
                {
                    MessageBox.Show("Seleccione un proveedor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (isEditMode)
                {
                    try
                    {
                        var confirmacion = MessageBox.Show("¿Estás seguro de que deseas actualizar este registro?",
                            "Confirmar Actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (confirmacion == DialogResult.Yes)
                        {
                            MessageBox.Show("ID a actualizar: " + productoID);
                            MessageBox.Show($"ProductoID: {productoID}\nNombre: {txtNombre.Text}\nDescripción: {txtDescripcion.Text}\nStock: {txtStock.Text}\nPrecio: {txtPrecio.Text}");


                            productoNegocio.ActualizarProductos(productoID, txtNombre.Text, txtDescripcion.Text,
                                idCategoria, stock, precio, dtpVencimiento.Value.Date, idProveedor);

                            MessageBox.Show("Registro actualizado correctamente.", "Actualizar Registro",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else 
                {
                    try
                    {
                        productoNegocio.GuardarProductos(0, txtNombre.Text, txtDescripcion.Text, idCategoria, stock,
                            precio, dtpVencimiento.Value.Date, idProveedor);

                        MessageBox.Show("Registro ingresado con éxito!", "Acción completada", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
