using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Reporte_de_Inventario : Form
    {
        public Reporte_de_Inventario()
        {
            InitializeComponent();
        }

        private void Reporte_de_Inventario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'farmaciaDBDataSet.Listar_Productos' table. You can move, or remove it, as needed.
            this.listar_ProductosTableAdapter.Fill(this.farmaciaDBDataSet.Listar_Productos);
            // TODO: This line of code loads data into the 'farmaciaDBDataSet.Listar_Productos' table. You can move, or remove it, as needed.
            this.listar_ProductosTableAdapter.Fill(this.farmaciaDBDataSet.Listar_Productos);

            this.reportViewer1.RefreshReport();
        }
    }
}
