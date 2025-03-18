namespace CapaPresentacion
{
    partial class Frm_Gestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Gestion));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            TLPnlTop = new TableLayoutPanel();
            btnMensaje = new Button();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            pnlSearch = new Panel();
            txtSearch = new TextBox();
            picSearch = new PictureBox();
            pnlGrid = new Panel();
            DGVGestion = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Vencimiento = new DataGridViewTextBoxColumn();
            Proveedor = new DataGridViewTextBoxColumn();
            TLPnlTop.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSearch).BeginInit();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVGestion).BeginInit();
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
            TLPnlTop.Controls.Add(btnMensaje, 4, 0);
            TLPnlTop.Controls.Add(btnRefresh, 3, 0);
            TLPnlTop.Controls.Add(btnDelete, 2, 0);
            TLPnlTop.Controls.Add(btnEdit, 1, 0);
            TLPnlTop.Controls.Add(btnAdd, 0, 0);
            TLPnlTop.Controls.Add(pnlSearch, 5, 0);
            TLPnlTop.Dock = DockStyle.Top;
            TLPnlTop.Location = new Point(2, 2);
            TLPnlTop.Name = "TLPnlTop";
            TLPnlTop.Padding = new Padding(2);
            TLPnlTop.RowCount = 1;
            TLPnlTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLPnlTop.Size = new Size(1096, 60);
            TLPnlTop.TabIndex = 0;
            // 
            // btnMensaje
            // 
            btnMensaje.BackColor = Color.FromArgb(17, 113, 248);
            btnMensaje.Dock = DockStyle.Fill;
            btnMensaje.FlatAppearance.BorderSize = 0;
            btnMensaje.FlatStyle = FlatStyle.Flat;
            btnMensaje.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMensaje.ForeColor = Color.White;
            btnMensaje.Image = (Image)resources.GetObject("btnMensaje.Image");
            btnMensaje.Location = new Point(365, 5);
            btnMensaje.Name = "btnMensaje";
            btnMensaje.Size = new Size(84, 50);
            btnMensaje.TabIndex = 4;
            btnMensaje.Text = "Mensaje";
            btnMensaje.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMensaje.UseVisualStyleBackColor = false;
            btnMensaje.Click += btnMensaje_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(17, 153, 248);
            btnRefresh.Dock = DockStyle.Fill;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(275, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(84, 50);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(17, 153, 248);
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(185, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(84, 50);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
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
            btnEdit.Location = new Point(95, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(84, 50);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(17, 153, 248);
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(5, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(84, 50);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // pnlSearch
            // 
            pnlSearch.Anchor = AnchorStyles.Left;
            pnlSearch.BackColor = Color.FromArgb(99, 180, 255);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(picSearch);
            pnlSearch.Location = new Point(502, 12);
            pnlSearch.Margin = new Padding(50, 0, 0, 0);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(350, 35);
            pnlSearch.TabIndex = 5;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(99, 180, 255);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(3, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(307, 19);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // picSearch
            // 
            picSearch.Dock = DockStyle.Right;
            picSearch.Image = (Image)resources.GetObject("picSearch.Image");
            picSearch.Location = new Point(314, 0);
            picSearch.Name = "picSearch";
            picSearch.Size = new Size(36, 35);
            picSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            picSearch.TabIndex = 0;
            picSearch.TabStop = false;
            // 
            // pnlGrid
            // 
            pnlGrid.Controls.Add(DGVGestion);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlGrid.Location = new Point(2, 62);
            pnlGrid.Margin = new Padding(0);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(3);
            pnlGrid.Size = new Size(1096, 536);
            pnlGrid.TabIndex = 1;
            // 
            // DGVGestion
            // 
            DGVGestion.AllowUserToAddRows = false;
            DGVGestion.AllowUserToDeleteRows = false;
            DGVGestion.AllowUserToResizeColumns = false;
            DGVGestion.AllowUserToResizeRows = false;
            DGVGestion.BackgroundColor = Color.White;
            DGVGestion.BorderStyle = BorderStyle.None;
            DGVGestion.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGVGestion.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(17, 153, 248);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 153, 248);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVGestion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVGestion.ColumnHeadersHeight = 50;
            DGVGestion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGVGestion.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Descripcion, Stock, Precio, Categoria, Vencimiento, Proveedor });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(212, 234, 255);
            dataGridViewCellStyle2.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(17, 153, 248);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(17, 153, 248);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVGestion.DefaultCellStyle = dataGridViewCellStyle2;
            DGVGestion.Dock = DockStyle.Fill;
            DGVGestion.EnableHeadersVisualStyles = false;
            DGVGestion.GridColor = Color.White;
            DGVGestion.Location = new Point(3, 3);
            DGVGestion.MultiSelect = false;
            DGVGestion.Name = "DGVGestion";
            DGVGestion.ReadOnly = true;
            DGVGestion.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DGVGestion.RowHeadersVisible = false;
            DGVGestion.RowHeadersWidth = 40;
            DGVGestion.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DGVGestion.RowTemplate.DividerHeight = 2;
            DGVGestion.RowTemplate.Height = 40;
            DGVGestion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVGestion.Size = new Size(1090, 530);
            DGVGestion.TabIndex = 0;
            DGVGestion.CellContentClick += DGVGestion_CellContentClick;
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
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 175;
            // 
            // Descripcion
            // 
            Descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descripcion.HeaderText = "Descripción";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
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
            // Categoria
            // 
            Categoria.HeaderText = "Categoría";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Width = 140;
            // 
            // Vencimiento
            // 
            Vencimiento.HeaderText = "Vencimiento";
            Vencimiento.Name = "Vencimiento";
            Vencimiento.ReadOnly = true;
            Vencimiento.Width = 130;
            // 
            // Proveedor
            // 
            Proveedor.HeaderText = "Proveedor";
            Proveedor.Name = "Proveedor";
            Proveedor.ReadOnly = true;
            Proveedor.Width = 145;
            // 
            // Frm_Gestion
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1100, 600);
            Controls.Add(pnlGrid);
            Controls.Add(TLPnlTop);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Gestion";
            Padding = new Padding(2);
            StartPosition = FormStartPosition.CenterScreen;
            TLPnlTop.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSearch).EndInit();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVGestion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TLPnlTop;
        private Button btnAdd;
        private Button btnMensaje;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnEdit;
        private Panel pnlSearch;
        private PictureBox picSearch;
        private TextBox txtSearch;
        private Panel pnlGrid;
        private DataGridView DGVGestion;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Vencimiento;
        private DataGridViewTextBoxColumn Proveedor;
    }
}