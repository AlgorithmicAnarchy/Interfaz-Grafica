namespace CapaPresentacion
{
    partial class Frm_Categoria
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Categoria));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            TLPnlTop = new TableLayoutPanel();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            pnlGridCategoria = new Panel();
            pnlAddInfo = new Panel();
            btnGuardarEditar = new Button();
            btnAgregar = new Button();
            btnCancelar = new Button();
            txtNombreCategoria = new TextBox();
            label1 = new Label();
            DGVCategoria = new DataGridView();
            ID_Categoria = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            TLPnlTop.SuspendLayout();
            pnlGridCategoria.SuspendLayout();
            pnlAddInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVCategoria).BeginInit();
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
            TLPnlTop.Controls.Add(btnDelete, 2, 0);
            TLPnlTop.Controls.Add(btnEdit, 1, 0);
            TLPnlTop.Controls.Add(btnAdd, 0, 0);
            TLPnlTop.Dock = DockStyle.Top;
            TLPnlTop.Location = new Point(10, 0);
            TLPnlTop.Name = "TLPnlTop";
            TLPnlTop.Padding = new Padding(2);
            TLPnlTop.RowCount = 1;
            TLPnlTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLPnlTop.Size = new Size(1070, 60);
            TLPnlTop.TabIndex = 1;
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
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // pnlGridCategoria
            // 
            pnlGridCategoria.Controls.Add(pnlAddInfo);
            pnlGridCategoria.Controls.Add(DGVCategoria);
            pnlGridCategoria.Dock = DockStyle.Fill;
            pnlGridCategoria.Location = new Point(10, 60);
            pnlGridCategoria.Name = "pnlGridCategoria";
            pnlGridCategoria.Size = new Size(1070, 520);
            pnlGridCategoria.TabIndex = 2;
            // 
            // pnlAddInfo
            // 
            pnlAddInfo.BackColor = Color.FromArgb(17, 135, 248);
            pnlAddInfo.Controls.Add(btnGuardarEditar);
            pnlAddInfo.Controls.Add(btnAgregar);
            pnlAddInfo.Controls.Add(btnCancelar);
            pnlAddInfo.Controls.Add(txtNombreCategoria);
            pnlAddInfo.Controls.Add(label1);
            pnlAddInfo.Dock = DockStyle.Right;
            pnlAddInfo.Location = new Point(566, 0);
            pnlAddInfo.Name = "pnlAddInfo";
            pnlAddInfo.Size = new Size(504, 520);
            pnlAddInfo.TabIndex = 2;
            // 
            // btnGuardarEditar
            // 
            btnGuardarEditar.Location = new Point(261, 174);
            btnGuardarEditar.Name = "btnGuardarEditar";
            btnGuardarEditar.Size = new Size(131, 42);
            btnGuardarEditar.TabIndex = 17;
            btnGuardarEditar.Text = "Editar";
            btnGuardarEditar.UseVisualStyleBackColor = true;
            btnGuardarEditar.Visible = false;
            btnGuardarEditar.Click += btnGuardarEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(261, 174);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(131, 42);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(99, 174);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(131, 42);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(261, 78);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(224, 30);
            txtNombreCategoria.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 81);
            label1.Name = "label1";
            label1.Size = new Size(196, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombre de la Categoría";
            // 
            // DGVCategoria
            // 
            DGVCategoria.AllowUserToAddRows = false;
            DGVCategoria.AllowUserToDeleteRows = false;
            DGVCategoria.AllowUserToResizeColumns = false;
            DGVCategoria.AllowUserToResizeRows = false;
            DGVCategoria.BackgroundColor = Color.White;
            DGVCategoria.BorderStyle = BorderStyle.None;
            DGVCategoria.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGVCategoria.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(17, 153, 248);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 153, 248);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVCategoria.ColumnHeadersHeight = 50;
            DGVCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGVCategoria.Columns.AddRange(new DataGridViewColumn[] { ID_Categoria, Categoria });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(212, 234, 255);
            dataGridViewCellStyle2.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(17, 153, 248);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(17, 153, 248);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVCategoria.DefaultCellStyle = dataGridViewCellStyle2;
            DGVCategoria.EnableHeadersVisualStyles = false;
            DGVCategoria.GridColor = Color.White;
            DGVCategoria.Location = new Point(0, 0);
            DGVCategoria.MultiSelect = false;
            DGVCategoria.Name = "DGVCategoria";
            DGVCategoria.ReadOnly = true;
            DGVCategoria.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DGVCategoria.RowHeadersVisible = false;
            DGVCategoria.RowHeadersWidth = 40;
            DGVCategoria.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DGVCategoria.RowTemplate.DividerHeight = 2;
            DGVCategoria.RowTemplate.Height = 40;
            DGVCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVCategoria.Size = new Size(582, 520);
            DGVCategoria.TabIndex = 1;
            DGVCategoria.CellContentClick += DGVCategoria_CellContentClick;
            // 
            // ID_Categoria
            // 
            ID_Categoria.HeaderText = "Id";
            ID_Categoria.Name = "ID_Categoria";
            ID_Categoria.ReadOnly = true;
            ID_Categoria.Width = 50;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Nombre";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Width = 400;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Frm_Categoria
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1100, 600);
            Controls.Add(pnlGridCategoria);
            Controls.Add(TLPnlTop);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Categoria";
            Padding = new Padding(10, 0, 20, 20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Categoria";
            TLPnlTop.ResumeLayout(false);
            pnlGridCategoria.ResumeLayout(false);
            pnlAddInfo.ResumeLayout(false);
            pnlAddInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVCategoria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TLPnlTop;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Panel pnlGridCategoria;
        private DataGridView DGVCategoria;
        private DataGridViewTextBoxColumn ID_Categoria;
        private DataGridViewTextBoxColumn Categoria;
        private Panel pnlAddInfo;
        private TextBox txtNombreCategoria;
        private Label label1;
        private Button btnAgregar;
        private Button btnCancelar;
        private Button btnGuardarEditar;
        private ContextMenuStrip contextMenuStrip1;
    }
}