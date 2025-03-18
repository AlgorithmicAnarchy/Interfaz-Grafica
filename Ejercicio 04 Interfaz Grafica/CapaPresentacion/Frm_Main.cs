using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Frm_Main : Form
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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        public Frm_Main()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            pnlPage.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlPage.Width, pnlPage.Height, 15, 15));
            pnlFrase.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlFrase.Width, pnlFrase.Height, 15, 15));

            Frm_Home frm = new Frm_Home();

            AddOwnedForm(frm);
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlPage.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        
        void addForm(Form frm, Button btn)
        {
            btn.BackColor = Color.FromArgb(17, 147, 255);

            switch (btn.Name)
            {
                case "btnHome": btn.ImageIndex = 1; break;
                case "btnGestion": btn.ImageIndex = 3; break;
                case "btnCategorias": btn.ImageIndex = 5; break;
                case "btnProveedor": btn.ImageIndex = 7; break;
                case "btnInventario": btn.ImageIndex = 9; break;
                case "btnReportes": btn.ImageIndex = 11; break;
                default: break;
            }

            pnlNav.Top = btn.Top;
            pnlNav.Height = btn.Height - 30;
            pnlNav.Location = new Point(btn.Location.X, btn.Location.Y + 65);
            pnlPage.Controls.Clear();
            AddOwnedForm(frm);
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlPage.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        void selectBtn(Button btn)
        {
            switch (btn.Name)
            {
                case "btnHome": btn.ImageIndex = 1; break;
                case "btnGestion": btn.ImageIndex = 3; break;
                case "btnCategorias": btn.ImageIndex = 5; break;
                case "btnProveedor": btn.ImageIndex = 7; break;
                case "btnInventario": btn.ImageIndex = 9; break;
                case "btnReportes": btn.ImageIndex = 11; break;
                default: break;
            }

            btn.BackColor = Color.FromArgb(17, 147, 255);

            pnlNav.Top = btn.Top;
            pnlNav.Height = btn.Height - 30;
            pnlNav.Location = new Point(btn.Location.X, btn.Location.Y + 65);

        }
        void resetBtn()
        {
            foreach (var btn in TLPnlMenu.Controls.OfType<Button>())
                btn.BackColor = Color.FromArgb(17, 153, 248);

            btnHome.ImageIndex = 0;
            btnGestion.ImageIndex = 2;
            btnCategorias.ImageIndex = 4;
            btnProveedor.ImageIndex = 6;
            btnInventario.ImageIndex = 8;
            btnReportes.ImageIndex = 10;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximized_Click(object sender, EventArgs e)
        {
            //if (WindowState == FormWindowState.Maximized)
            //    WindowState = FormWindowState.Normal;
            //else 
            //    WindowState = FormWindowState.Maximized;
        }
        private void btnMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            resetBtn();
            addForm(new Frm_Home(), btnHome);
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            resetBtn(); 
            addForm(new Frm_Gestion(), btnGestion);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            resetBtn();
            addForm(new Frm_Categoria(), btnCategorias);
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            resetBtn();
            addForm(new Frm_Proveedor(), btnProveedor);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            resetBtn();
            addForm(new Frm_Inventario(), btnInventario);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            resetBtn();
        }
    }
}
