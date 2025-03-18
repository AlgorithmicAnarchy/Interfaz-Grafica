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

namespace CapaPresentacion
{
    public partial class Presentacion : Form
    {


        CapaDeNegocio N = new CapaDeNegocio();
        public Presentacion()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


        }

        private void dgv_VerDrogas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Inputs(true);
            btn_Guardar.Visible = false;
            btn_Nuevo.Visible = false;
            btn_Actualizar.Visible = true;
            btn_Eliminar.Visible = true;
            btn_Cancelar2.Visible = true;
            int a = dgv_VerCulonas.SelectedRows[0].Index;

            // txt_ID.Visible = true;
            // lbl_ID.Visible = true;

            txt_ID.Text = dgv_VerCulonas.Rows[a].Cells[0].Value.ToString();
            txt_Producto.Text = dgv_VerCulonas.Rows[a].Cells[1].Value.ToString();
            txt_Descripcion.Text = dgv_VerCulonas.Rows[a].Cells[2].Value.ToString();
            txt_Stock.Text = dgv_VerCulonas.Rows[a].Cells[3].Value.ToString();
            txt_Precio.Text = dgv_VerCulonas.Rows[a].Cells[4].Value.ToString();
            cbx_Categoria.Text = dgv_VerCulonas.Rows[a].Cells[5].Value.ToString();
            dtp_FechaVencimiento.Value = DateTime.Parse(dgv_VerCulonas.Rows[a].Cells[6].Value.ToString());
            cbx_Proveedor.Text = dgv_VerCulonas.Rows[a].Cells[7].Value.ToString();
        }

        private void Presentacion_Load(object sender, EventArgs e)
        {
            Sources();
            DataGridFormat();
            Inputs(false);

            dgv_VerCulonas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 50, 50);
            dgv_VerCulonas.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv_VerCulonas.Columns[0].Visible = false;

        }

        private void Sources()
        {
            dgv_VerCulonas.DataSource = N.ListarProductos();

            
            cbx_Categoria.DataSource = N.VerCategorias();
            cbx_Categoria.DisplayMember = "Categoria";
            cbx_Categoria.ValueMember = "ID_Categoria";

            cbx_Proveedor.DataSource = N.VerProveedores();
            cbx_Proveedor.DisplayMember = "Nombre_Proveedores";
            cbx_Proveedor.ValueMember = "ID_Proveedores";
        }

        private void DataGridFormat()
        {
            dgv_VerCulonas.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_VerCulonas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_VerCulonas.RowHeadersWidth = 120;
            dgv_VerCulonas.Columns[0].Width = 50;

            dgv_VerCulonas.Columns[0].HeaderText = "ID";
            dgv_VerCulonas.Columns[1].HeaderText = "Producto";
            dgv_VerCulonas.Columns[2].HeaderText = "Descripción";
            dgv_VerCulonas.Columns[3].HeaderText = "Stock";
            dgv_VerCulonas.Columns[4].HeaderText = "Precio";
            dgv_VerCulonas.Columns[5].HeaderText = "Categoría";
            dgv_VerCulonas.Columns[6].HeaderText = "Fecha Vencimiento";
            dgv_VerCulonas.Columns[7].HeaderText = "Proveedor";
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Buscar.Text))
            {
                dgv_VerCulonas.DataSource = N.ListarProductos();
            }
            else
            {
                dgv_VerCulonas.DataSource = N.BuscarProductos(txt_Buscar.Text.ToString());
            }
        }

        private void Inputs(bool inp)
        {
            txt_Descripcion.Enabled = inp;
            txt_Producto.Enabled = inp;
            txt_Stock.Enabled = inp;
            txt_Precio.Enabled = inp;
            cbx_Categoria.Enabled = inp;
            cbx_Proveedor.Enabled = inp;
            dtp_FechaVencimiento.Enabled = inp;


            btn_Guardar.Visible = inp;

            txt_ID.Visible = false;
            lbl_ID.Visible = false;
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            Inputs(true);
            txt_Producto.Focus();
            btn_Nuevo.Visible = false;
            btn_Cancelar.Visible = true;
            btn_Cancelar2.Visible = false;
            btn_Actualizar.Visible = false;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_ID.Visible = false;
            lbl_ID.Visible = false;

            Inputs(false);
            btn_Nuevo.Visible = true;
            btn_Cancelar.Visible = false;
            VaciarInputs();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_Producto.Text) ||
                    string.IsNullOrWhiteSpace(txt_Descripcion.Text) ||
                    string.IsNullOrWhiteSpace(txt_Precio.Text) ||
                    string.IsNullOrWhiteSpace(txt_Stock.Text) ||
                    !int.TryParse(txt_Stock.Text, out int a) ||
                    !decimal.TryParse(txt_Precio.Text, out decimal n) ||
                    cbx_Categoria.SelectedIndex < 0 ||
                    cbx_Proveedor.SelectedIndex < 0)
                {
                    MessageBox.Show("Rellene los campos correctamente para continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    N.GuardarProductos(0, txt_Producto.Text, txt_Descripcion.Text, int.Parse(cbx_Categoria.SelectedValue.ToString()), int.Parse(txt_Stock.Text), decimal.Parse(txt_Precio.Text), dtp_FechaVencimiento.Value.Date, int.Parse(cbx_Proveedor.SelectedValue.ToString()));
                    MessageBox.Show("Registro ingresado con éxito!", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VaciarInputs();
                    Sources();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_ID.Text))
                {
                    MessageBox.Show("Seleccione un registro antes de eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmacion == DialogResult.Yes)
                {
                    N.Eliminar(int.Parse(txt_ID.Text));
                    MessageBox.Show("Registro eliminado correctamente.", "Eliminar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbl_ID.Visible = false;
                    txt_ID.Visible = false;
                    VaciarInputs();
                    Sources();
                    Inputs(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_Producto.Text))
                {
                    MessageBox.Show("El nombre del producto no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_Descripcion.Text))
                {
                    MessageBox.Show("La descripcion del producto no puede estar vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_Stock.Text))
                {
                    MessageBox.Show("El stock del producto no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_Precio.Text))
                {
                    MessageBox.Show("El stock del producto no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirmacion = MessageBox.Show("¿Estás seguro de que deseas actualizar este registro?", "Confirmar Actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmacion == DialogResult.Yes)
                {
                    N.ActualizarProductos(int.Parse(txt_ID.Text), txt_Producto.Text, txt_Descripcion.Text, int.Parse(cbx_Categoria.SelectedValue.ToString()), int.Parse(txt_Stock.Text), decimal.Parse(txt_Precio.Text), dtp_FechaVencimiento.Value.Date, int.Parse(cbx_Proveedor.SelectedValue.ToString()));
                    MessageBox.Show("Registro actualizado correctamente.", "Actualizar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Sources();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancelar2_Click(object sender, EventArgs e)
        { 
            btn_Actualizar.Visible = false;
            btn_Cancelar2.Visible = false;
            btn_Eliminar.Visible = false;
            btn_Nuevo.Visible = true;

            lbl_ID.Visible = false;
            txt_ID.Visible = false;

            Inputs(false);
            VaciarInputs();
        }
        
        private void VaciarInputs()
        {
            txt_ID.Text = "";
            txt_Producto.Text = "";
            txt_Descripcion.Text = "";
            txt_Precio.Text = "";
            txt_Stock.Text = "";
            cbx_Categoria.SelectedIndex = -1;
            cbx_Proveedor.SelectedIndex = -1;
            dtp_FechaVencimiento.Value = DateTime.Today;
        }

        private void dgv_VerDrogas_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgv_VerCulonas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 179, 186);
            }
        }

        private void dgv_VerDrogas_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgv_VerCulonas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }


        private void pnl_Fondo1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Titulo2_Click(object sender, EventArgs e)
        {

        }

        private void btnVerReporte_Click(object sender, EventArgs e)
        {
            Reporte_de_Inventario reporte = new Reporte_de_Inventario();
            reporte.Show();
        }

        private void lbl_Visualizacion_Click(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

        }

        private void dgv_VerCulonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Reporte_de_Inv repote = new Reporte_de_Inv();
            repote.Show();
        }
    }
}
