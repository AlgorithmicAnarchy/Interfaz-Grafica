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
    public partial class Reporte_de_Inv : Form
    {
        public Reporte_de_Inv()
        {
            InitializeComponent();
        }

        private void Reporte_de_Inv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mostrarInventarioDataSet.sp_MostrarInventario' table. You can move, or remove it, as needed.
            this.sp_MostrarInventarioTableAdapter.Fill(this.mostrarInventarioDataSet.sp_MostrarInventario);

            this.reportViewer1.RefreshReport();
        }
    }
}
