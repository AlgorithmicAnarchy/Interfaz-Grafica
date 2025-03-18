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
using CapaPresentacion.Views;

namespace CapaPresentacion
{
    public partial class Form1 : Form
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


        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void botonCircular2_MouseHover(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void botonCircular2_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void botonCircular5_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void botonCircular5_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void botonCircular3_MouseHover(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void botonCircular3_MouseLeave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void botonCircular4_MouseHover(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void botonCircular4_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void botonCircular1_MouseHover(object sender, EventArgs e)
        {
            label5.Visible = true;
        }

        private void botonCircular1_MouseLeave(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void botonCircular5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonCircular2_Click(object sender, EventArgs e)
        {

            Frm_Clientes frmC = new Frm_Clientes(this);
            this.Hide();

            
            frmC.BringToFront();
            frmC.Show();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonCircular3_Click(object sender, EventArgs e)
        {
            Frm_Articulos frmC = new Frm_Articulos(this);
            this.Hide();


            frmC.BringToFront();
            frmC.Show();
        }

        private void botonCircular4_Click(object sender, EventArgs e)
        {
            Frm_Facturacion frmC = new Frm_Facturacion(this);

            this.Hide();


            frmC.BringToFront();
            frmC.Show();
        }

        private void botonCircular1_Click(object sender, EventArgs e)
        {
            Frm_Reporte frmC = new Frm_Reporte(this);

            this.Hide();

            frmC.BringToFront();
            frmC.Show();
        }
    }
}
