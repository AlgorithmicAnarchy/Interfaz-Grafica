namespace CapaPresentacion
{
    partial class Frm_Inventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Inventario));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            TLPnlTop = new TableLayoutPanel();
            pnlSearch = new Panel();
            textBox4 = new TextBox();
            pictureBox4 = new PictureBox();
            btnEdit = new Button();
            pnlFill = new Panel();
            panel1 = new Panel();
            btnAgregar = new Button();
            btnCancelar = new Button();
            txtProductName = new TextBox();
            lblProductName = new Label();
            txtRemoveStock = new TextBox();
            lblStockRemoved = new Label();
            txtAddStock = new TextBox();
            lblStockAdd = new Label();
            DGVInventario = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Proveedor = new DataGridViewTextBoxColumn();
            FechaVencimiento = new DataGridViewTextBoxColumn();
            TLPnlTop.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlFill.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVInventario).BeginInit();
            SuspendLayout();
            // 
            // TLPnlTop
            // 
            TLPnlTop.ColumnCount = 6;
            TLPnlTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            TLPnlTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            TLPnlTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            TLPnlTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            TLPnlTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            TLPnlTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            TLPnlTop.Controls.Add(pnlSearch, 5, 0);
            TLPnlTop.Controls.Add(btnEdit, 0, 0);
            TLPnlTop.Dock = DockStyle.Top;
            TLPnlTop.Location = new Point(10, 0);
            TLPnlTop.Margin = new Padding(20, 0, 0, 0);
            TLPnlTop.Name = "TLPnlTop";
            TLPnlTop.Padding = new Padding(10, 2, 2, 2);
            TLPnlTop.RowCount = 1;
            TLPnlTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLPnlTop.Size = new Size(1054, 60);
            TLPnlTop.TabIndex = 3;
            // 
            // pnlSearch
            // 
            pnlSearch.Anchor = AnchorStyles.Left;
            pnlSearch.BackColor = Color.FromArgb(99, 180, 255);
            pnlSearch.Controls.Add(textBox4);
            pnlSearch.Controls.Add(pictureBox4);
            pnlSearch.Location = new Point(510, 12);
            pnlSearch.Margin = new Padding(50, 0, 0, 0);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(350, 35);
            pnlSearch.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(99, 180, 255);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(3, 8);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(307, 19);
            textBox4.TabIndex = 1;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Right;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(314, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(17, 153, 248);
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.Location = new Point(13, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(84, 50);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Edit";
            btnEdit.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // pnlFill
            // 
            pnlFill.Controls.Add(panel1);
            pnlFill.Controls.Add(DGVInventario);
            pnlFill.Dock = DockStyle.Fill;
            pnlFill.Location = new Point(10, 60);
            pnlFill.Name = "pnlFill";
            pnlFill.Size = new Size(1054, 481);
            pnlFill.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 153, 248);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(txtProductName);
            panel1.Controls.Add(lblProductName);
            panel1.Controls.Add(txtRemoveStock);
            panel1.Controls.Add(lblStockRemoved);
            panel1.Controls.Add(txtAddStock);
            panel1.Controls.Add(lblStockAdd);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(785, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 481);
            panel1.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.FromArgb(17, 153, 248);
            btnAgregar.Location = new Point(138, 361);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(106, 42);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(17, 153, 248);
            btnCancelar.Location = new Point(26, 361);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(106, 42);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(26, 52);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(211, 23);
            txtProductName.TabIndex = 7;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            lblProductName.ForeColor = Color.White;
            lblProductName.Location = new Point(26, 26);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(118, 23);
            lblProductName.TabIndex = 6;
            lblProductName.Text = "Product Name";
            // 
            // txtRemoveStock
            // 
            txtRemoveStock.Location = new Point(26, 266);
            txtRemoveStock.Name = "txtRemoveStock";
            txtRemoveStock.Size = new Size(106, 23);
            txtRemoveStock.TabIndex = 5;
            // 
            // lblStockRemoved
            // 
            lblStockRemoved.AutoSize = true;
            lblStockRemoved.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            lblStockRemoved.ForeColor = Color.White;
            lblStockRemoved.Location = new Point(26, 236);
            lblStockRemoved.Name = "lblStockRemoved";
            lblStockRemoved.Size = new Size(173, 23);
            lblStockRemoved.TabIndex = 4;
            lblStockRemoved.Text = "Stock to be removed";
            // 
            // txtAddStock
            // 
            txtAddStock.Location = new Point(26, 169);
            txtAddStock.Name = "txtAddStock";
            txtAddStock.Size = new Size(106, 23);
            txtAddStock.TabIndex = 3;
            // 
            // lblStockAdd
            // 
            lblStockAdd.AutoSize = true;
            lblStockAdd.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            lblStockAdd.ForeColor = Color.White;
            lblStockAdd.Location = new Point(26, 139);
            lblStockAdd.Name = "lblStockAdd";
            lblStockAdd.Size = new Size(155, 23);
            lblStockAdd.TabIndex = 2;
            lblStockAdd.Text = "Stock to be added";
            // 
            // DGVInventario
            // 
            DGVInventario.AllowUserToAddRows = false;
            DGVInventario.AllowUserToDeleteRows = false;
            DGVInventario.AllowUserToResizeColumns = false;
            DGVInventario.AllowUserToResizeRows = false;
            DGVInventario.BackgroundColor = Color.White;
            DGVInventario.BorderStyle = BorderStyle.None;
            DGVInventario.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGVInventario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(17, 153, 248);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 153, 248);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVInventario.ColumnHeadersHeight = 50;
            DGVInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGVInventario.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Stock, Precio, Proveedor, FechaVencimiento });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(212, 234, 255);
            dataGridViewCellStyle2.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(17, 153, 248);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(17, 153, 248);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVInventario.DefaultCellStyle = dataGridViewCellStyle2;
            DGVInventario.EnableHeadersVisualStyles = false;
            DGVInventario.GridColor = Color.White;
            DGVInventario.Location = new Point(0, 0);
            DGVInventario.Margin = new Padding(10, 3, 3, 3);
            DGVInventario.MultiSelect = false;
            DGVInventario.Name = "DGVInventario";
            DGVInventario.ReadOnly = true;
            DGVInventario.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DGVInventario.RowHeadersVisible = false;
            DGVInventario.RowHeadersWidth = 40;
            DGVInventario.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DGVInventario.RowTemplate.DividerHeight = 2;
            DGVInventario.RowTemplate.Height = 40;
            DGVInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVInventario.Size = new Size(779, 481);
            DGVInventario.TabIndex = 1;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 50;
            // 
            // Nombre
            // 
            Nombre.FillWeight = 150F;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 175;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Proveedor
            // 
            Proveedor.HeaderText = "Proveedor";
            Proveedor.Name = "Proveedor";
            Proveedor.ReadOnly = true;
            Proveedor.Width = 200;
            // 
            // FechaVencimiento
            // 
            FechaVencimiento.HeaderText = "Vencimiento";
            FechaVencimiento.Name = "FechaVencimiento";
            FechaVencimiento.ReadOnly = true;
            FechaVencimiento.Width = 130;
            // 
            // Frm_Inventario
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1084, 561);
            Controls.Add(pnlFill);
            Controls.Add(TLPnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Inventario";
            Padding = new Padding(10, 0, 20, 20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Inventario";
            Load += Frm_Inventario_Load;
            TLPnlTop.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnlFill.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVInventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TLPnlTop;
        private Button btnEdit;
        private Panel pnlFill;
        private DataGridView DGVInventario;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Proveedor;
        private DataGridViewTextBoxColumn FechaVencimiento;
        private Panel panel1;
        private TextBox txtAddStock;
        private Label lblStockAdd;
        private TextBox txtRemoveStock;
        private Label lblStockRemoved;
        private TextBox txtProductName;
        private Label lblProductName;
        private Button btnAgregar;
        private Button btnCancelar;
        private Panel pnlSearch;
        private TextBox textBox4;
        private PictureBox pictureBox4;
    }
}