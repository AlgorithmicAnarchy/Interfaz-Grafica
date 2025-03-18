using System.Windows.Forms;
using System.Xml.Linq;

namespace CapaPresentacion
{
    partial class Frm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            TLPnlTop = new TableLayoutPanel();
            picLogo = new PictureBox();
            lblLogo = new Label();
            btnMinimized = new Button();
            btnMaximized = new Button();
            btnExit = new Button();
            pnlFrase = new Panel();
            label1 = new Label();
            lblLogo2 = new Label();
            TLPnlMenu = new TableLayoutPanel();
            btnReportes = new Button();
            ImageList = new ImageList(components);
            btnInventario = new Button();
            btnProveedor = new Button();
            btnCategorias = new Button();
            btnGestion = new Button();
            btnHome = new Button();
            pnlNav = new Label();
            pnlFill = new Panel();
            pnlPage = new Panel();
            TLPnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlFrase.SuspendLayout();
            TLPnlMenu.SuspendLayout();
            pnlFill.SuspendLayout();
            SuspendLayout();
            // 
            // TLPnlTop
            // 
            TLPnlTop.ColumnCount = 8;
            TLPnlTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            TLPnlTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            TLPnlTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TLPnlTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            TLPnlTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            TLPnlTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            TLPnlTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            TLPnlTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            TLPnlTop.Controls.Add(picLogo, 0, 0);
            TLPnlTop.Controls.Add(lblLogo, 1, 0);
            TLPnlTop.Controls.Add(btnMinimized, 5, 0);
            TLPnlTop.Controls.Add(btnMaximized, 6, 0);
            TLPnlTop.Controls.Add(btnExit, 7, 0);
            TLPnlTop.Controls.Add(pnlFrase, 3, 0);
            TLPnlTop.Controls.Add(lblLogo2, 2, 0);
            TLPnlTop.Dock = DockStyle.Top;
            TLPnlTop.Location = new Point(0, 0);
            TLPnlTop.Margin = new Padding(0);
            TLPnlTop.Name = "TLPnlTop";
            TLPnlTop.RowCount = 2;
            TLPnlTop.RowStyles.Add(new RowStyle(SizeType.Percent, 65.11628F));
            TLPnlTop.RowStyles.Add(new RowStyle(SizeType.Percent, 34.88372F));
            TLPnlTop.Size = new Size(1200, 50);
            TLPnlTop.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Location = new Point(15, 5);
            picLogo.Margin = new Padding(15, 5, 0, 0);
            picLogo.Name = "picLogo";
            TLPnlTop.SetRowSpan(picLogo, 2);
            picLogo.Size = new Size(40, 40);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 7;
            picLogo.TabStop = false;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(90, 10);
            lblLogo.Margin = new Padding(0, 10, 0, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Padding = new Padding(13, 0, 0, 0);
            TLPnlTop.SetRowSpan(lblLogo, 2);
            lblLogo.Size = new Size(90, 31);
            lblLogo.TabIndex = 6;
            lblLogo.Text = "Goods";
            // 
            // btnMinimized
            // 
            btnMinimized.Dock = DockStyle.Fill;
            btnMinimized.FlatAppearance.BorderSize = 0;
            btnMinimized.FlatStyle = FlatStyle.Flat;
            btnMinimized.Image = (Image)resources.GetObject("btnMinimized.Image");
            btnMinimized.Location = new Point(1050, 0);
            btnMinimized.Margin = new Padding(0);
            btnMinimized.Name = "btnMinimized";
            btnMinimized.Size = new Size(50, 32);
            btnMinimized.TabIndex = 2;
            btnMinimized.UseVisualStyleBackColor = true;
            btnMinimized.Click += btnMinimized_Click;
            // 
            // btnMaximized
            // 
            btnMaximized.Dock = DockStyle.Fill;
            btnMaximized.FlatAppearance.BorderSize = 0;
            btnMaximized.FlatStyle = FlatStyle.Flat;
            btnMaximized.Image = (Image)resources.GetObject("btnMaximized.Image");
            btnMaximized.Location = new Point(1100, 0);
            btnMaximized.Margin = new Padding(0);
            btnMaximized.Name = "btnMaximized";
            btnMaximized.Size = new Size(50, 32);
            btnMaximized.TabIndex = 1;
            btnMaximized.UseVisualStyleBackColor = true;
            btnMaximized.Click += btnMaximized_Click;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Fill;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(196, 43, 28);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(1150, 0);
            btnExit.Margin = new Padding(0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(50, 32);
            btnExit.TabIndex = 0;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pnlFrase
            // 
            pnlFrase.BackColor = Color.FromArgb(99, 180, 255);
            pnlFrase.Controls.Add(label1);
            pnlFrase.Location = new Point(350, 8);
            pnlFrase.Margin = new Padding(10, 8, 0, 0);
            pnlFrase.Name = "pnlFrase";
            TLPnlTop.SetRowSpan(pnlFrase, 2);
            pnlFrase.Size = new Size(580, 35);
            pnlFrase.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(41, 7);
            label1.Name = "label1";
            label1.Size = new Size(494, 46);
            label1.TabIndex = 0;
            label1.Text = "~ \"La creatividad no tiene límites, solo píxeles por organizar.\"\n\n";
            label1.Click += label1_Click;
            // 
            // lblLogo2
            // 
            lblLogo2.AutoSize = true;
            lblLogo2.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            lblLogo2.ForeColor = Color.LightGray;
            lblLogo2.Location = new Point(180, 10);
            lblLogo2.Margin = new Padding(0, 10, 0, 0);
            lblLogo2.Name = "lblLogo2";
            TLPnlTop.SetRowSpan(lblLogo2, 2);
            lblLogo2.Size = new Size(104, 31);
            lblLogo2.TabIndex = 5;
            lblLogo2.Text = "Manager";
            // 
            // TLPnlMenu
            // 
            TLPnlMenu.ColumnCount = 1;
            TLPnlMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TLPnlMenu.Controls.Add(btnReportes, 0, 5);
            TLPnlMenu.Controls.Add(btnInventario, 0, 4);
            TLPnlMenu.Controls.Add(btnProveedor, 0, 3);
            TLPnlMenu.Controls.Add(btnCategorias, 0, 2);
            TLPnlMenu.Controls.Add(btnGestion, 0, 1);
            TLPnlMenu.Controls.Add(btnHome, 0, 0);
            TLPnlMenu.Dock = DockStyle.Left;
            TLPnlMenu.Location = new Point(0, 50);
            TLPnlMenu.Margin = new Padding(0);
            TLPnlMenu.Name = "TLPnlMenu";
            TLPnlMenu.RowCount = 7;
            TLPnlMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            TLPnlMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            TLPnlMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            TLPnlMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            TLPnlMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            TLPnlMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            TLPnlMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            TLPnlMenu.Size = new Size(90, 650);
            TLPnlMenu.TabIndex = 1;
            // 
            // btnReportes
            // 
            btnReportes.Dock = DockStyle.Fill;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Comic Sans MS", 9F);
            btnReportes.ForeColor = Color.White;
            btnReportes.ImageIndex = 10;
            btnReportes.ImageList = ImageList;
            btnReportes.Location = new Point(9, 459);
            btnReportes.Margin = new Padding(9);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(72, 72);
            btnReportes.TabIndex = 8;
            btnReportes.Text = "Report";
            btnReportes.TextImageRelation = TextImageRelation.ImageAboveText;
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // ImageList
            // 
            ImageList.ColorDepth = ColorDepth.Depth32Bit;
            ImageList.ImageStream = (ImageListStreamer)resources.GetObject("ImageList.ImageStream");
            ImageList.TransparentColor = Color.Transparent;
            ImageList.Images.SetKeyName(0, "Home 1.png");
            ImageList.Images.SetKeyName(1, "Home 2.png");
            ImageList.Images.SetKeyName(2, "Gestion 1.png");
            ImageList.Images.SetKeyName(3, "Gestion 2.png");
            ImageList.Images.SetKeyName(4, "Categoria 1.png");
            ImageList.Images.SetKeyName(5, "Categoria 2.png");
            ImageList.Images.SetKeyName(6, "Proveedores 1.png");
            ImageList.Images.SetKeyName(7, "Proveedores 2.png");
            ImageList.Images.SetKeyName(8, "Inventario 1.png");
            ImageList.Images.SetKeyName(9, "Inventario 2.png");
            ImageList.Images.SetKeyName(10, "Reporte 1.png");
            ImageList.Images.SetKeyName(11, "Reporte 2.png");
            // 
            // btnInventario
            // 
            btnInventario.Dock = DockStyle.Fill;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Comic Sans MS", 9F);
            btnInventario.ForeColor = Color.White;
            btnInventario.ImageIndex = 8;
            btnInventario.ImageList = ImageList;
            btnInventario.Location = new Point(9, 369);
            btnInventario.Margin = new Padding(9);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(72, 72);
            btnInventario.TabIndex = 7;
            btnInventario.Text = "Inventory";
            btnInventario.TextImageRelation = TextImageRelation.ImageAboveText;
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnProveedor
            // 
            btnProveedor.Dock = DockStyle.Fill;
            btnProveedor.FlatAppearance.BorderSize = 0;
            btnProveedor.FlatStyle = FlatStyle.Flat;
            btnProveedor.Font = new Font("Comic Sans MS", 9F);
            btnProveedor.ForeColor = Color.White;
            btnProveedor.ImageIndex = 6;
            btnProveedor.ImageList = ImageList;
            btnProveedor.Location = new Point(9, 279);
            btnProveedor.Margin = new Padding(9);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(72, 72);
            btnProveedor.TabIndex = 6;
            btnProveedor.Text = "Supplier";
            btnProveedor.TextImageRelation = TextImageRelation.ImageAboveText;
            btnProveedor.UseVisualStyleBackColor = true;
            btnProveedor.Click += btnProveedor_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.Dock = DockStyle.Fill;
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Comic Sans MS", 9F);
            btnCategorias.ForeColor = Color.White;
            btnCategorias.ImageIndex = 4;
            btnCategorias.ImageList = ImageList;
            btnCategorias.Location = new Point(9, 189);
            btnCategorias.Margin = new Padding(9);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(72, 72);
            btnCategorias.TabIndex = 5;
            btnCategorias.Text = "Category";
            btnCategorias.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnGestion
            // 
            btnGestion.Dock = DockStyle.Fill;
            btnGestion.FlatAppearance.BorderSize = 0;
            btnGestion.FlatStyle = FlatStyle.Flat;
            btnGestion.Font = new Font("Comic Sans MS", 9F);
            btnGestion.ForeColor = Color.White;
            btnGestion.ImageIndex = 2;
            btnGestion.ImageList = ImageList;
            btnGestion.Location = new Point(9, 99);
            btnGestion.Margin = new Padding(9);
            btnGestion.Name = "btnGestion";
            btnGestion.Size = new Size(72, 72);
            btnGestion.TabIndex = 4;
            btnGestion.Text = "Manage";
            btnGestion.TextImageRelation = TextImageRelation.ImageAboveText;
            btnGestion.UseVisualStyleBackColor = true;
            btnGestion.Click += btnGestion_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Fill;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Comic Sans MS", 9F);
            btnHome.ForeColor = Color.White;
            btnHome.ImageIndex = 0;
            btnHome.ImageList = ImageList;
            btnHome.Location = new Point(9, 9);
            btnHome.Margin = new Padding(9);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(72, 72);
            btnHome.TabIndex = 3;
            btnHome.Text = "Home";
            btnHome.TextImageRelation = TextImageRelation.ImageAboveText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.White;
            pnlNav.FlatStyle = FlatStyle.Flat;
            pnlNav.Location = new Point(12, 67);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(5, 50);
            pnlNav.TabIndex = 6;
            // 
            // pnlFill
            // 
            pnlFill.Controls.Add(pnlPage);
            pnlFill.Dock = DockStyle.Fill;
            pnlFill.Location = new Point(90, 50);
            pnlFill.Name = "pnlFill";
            pnlFill.Padding = new Padding(0, 0, 10, 10);
            pnlFill.Size = new Size(1110, 650);
            pnlFill.TabIndex = 7;
            // 
            // pnlPage
            // 
            pnlPage.BackColor = Color.White;
            pnlPage.Dock = DockStyle.Fill;
            pnlPage.Location = new Point(0, 0);
            pnlPage.Name = "pnlPage";
            pnlPage.Size = new Size(1100, 640);
            pnlPage.TabIndex = 0;
            // 
            // Frm_Main
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(17, 153, 248);
            ClientSize = new Size(1200, 700);
            Controls.Add(pnlFill);
            Controls.Add(pnlNav);
            Controls.Add(TLPnlMenu);
            Controls.Add(TLPnlTop);
            Font = new Font("Comic Sans MS", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_Main";
            StartPosition = FormStartPosition.CenterScreen;
            TLPnlTop.ResumeLayout(false);
            TLPnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlFrase.ResumeLayout(false);
            pnlFrase.PerformLayout();
            TLPnlMenu.ResumeLayout(false);
            pnlFill.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TLPnlTop;
        private TableLayoutPanel TLPnlMenu;
        private Button btnExit;
        private ImageList ImageList;
        private Button btnMinimized;
        private Button btnMaximized;
        private Panel pnlFrase;
        private Label label1;
        private Label lblLogo2;
        private Label lblLogo;
        private PictureBox picLogo;
        private Button btnHome;
        private Button btnReportes;
        private Button btnInventario;
        private Button btnProveedor;
        private Button btnCategorias;
        private Button btnGestion;
        private Label pnlNav;
        private Panel pnlFill;
        private Panel pnlPage;
    }
}
