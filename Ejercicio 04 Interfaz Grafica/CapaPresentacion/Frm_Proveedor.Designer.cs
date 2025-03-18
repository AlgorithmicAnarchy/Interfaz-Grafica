namespace CapaPresentacion
{
    partial class Frm_Proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Proveedor));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            TLPnlTop = new TableLayoutPanel();
            btnDelete = new Button();
            btnEdit = new Button();
            pnlFill = new Panel();
            pnlAddInfo = new Panel();
            txtContactoProveedor = new TextBox();
            label2 = new Label();
            btnGuardarEditar = new Button();
            btnAgregar = new Button();
            btnCancelar = new Button();
            txtNombreProveedor = new TextBox();
            label1 = new Label();
            DGVProveedores = new DataGridView();
            ID_Proveedores = new DataGridViewTextBoxColumn();
            Nombre_Proveedores = new DataGridViewTextBoxColumn();
            Contacto = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            TLPnlTop.SuspendLayout();
            pnlFill.SuspendLayout();
            pnlAddInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVProveedores).BeginInit();
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
            TLPnlTop.Location = new Point(0, 0);
            TLPnlTop.Margin = new Padding(20, 0, 0, 0);
            TLPnlTop.Name = "TLPnlTop";
            TLPnlTop.Padding = new Padding(10, 2, 2, 2);
            TLPnlTop.RowCount = 1;
            TLPnlTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLPnlTop.Size = new Size(1100, 60);
            TLPnlTop.TabIndex = 2;
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
            btnDelete.Location = new Point(193, 5);
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
            btnEdit.Location = new Point(103, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(84, 50);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // pnlFill
            // 
            pnlFill.Controls.Add(pnlAddInfo);
            pnlFill.Controls.Add(DGVProveedores);
            pnlFill.Dock = DockStyle.Fill;
            pnlFill.ForeColor = Color.FromArgb(17, 153, 248);
            pnlFill.Location = new Point(0, 60);
            pnlFill.Margin = new Padding(10, 0, 20, 20);
            pnlFill.Name = "pnlFill";
            pnlFill.Padding = new Padding(10, 0, 20, 20);
            pnlFill.Size = new Size(1100, 540);
            pnlFill.TabIndex = 3;
            // 
            // pnlAddInfo
            // 
            pnlAddInfo.BackColor = Color.FromArgb(17, 135, 248);
            pnlAddInfo.Controls.Add(txtContactoProveedor);
            pnlAddInfo.Controls.Add(label2);
            pnlAddInfo.Controls.Add(btnGuardarEditar);
            pnlAddInfo.Controls.Add(btnAgregar);
            pnlAddInfo.Controls.Add(btnCancelar);
            pnlAddInfo.Controls.Add(txtNombreProveedor);
            pnlAddInfo.Controls.Add(label1);
            pnlAddInfo.Dock = DockStyle.Right;
            pnlAddInfo.Location = new Point(576, 0);
            pnlAddInfo.Name = "pnlAddInfo";
            pnlAddInfo.Size = new Size(504, 520);
            pnlAddInfo.TabIndex = 6;
            // 
            // txtContactoProveedor
            // 
            txtContactoProveedor.Location = new Point(261, 145);
            txtContactoProveedor.Name = "txtContactoProveedor";
            txtContactoProveedor.Size = new Size(224, 30);
            txtContactoProveedor.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 148);
            label2.Name = "label2";
            label2.Size = new Size(189, 23);
            label2.TabIndex = 18;
            label2.Text = "Contacto del Proveedor";
            // 
            // btnGuardarEditar
            // 
            btnGuardarEditar.ForeColor = Color.Black;
            btnGuardarEditar.Location = new Point(261, 260);
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
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(261, 260);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(131, 42);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(99, 260);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(131, 42);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.Location = new Point(261, 78);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(224, 30);
            txtNombreProveedor.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 81);
            label1.Name = "label1";
            label1.Size = new Size(182, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Proveedor";
            // 
            // DGVProveedores
            // 
            DGVProveedores.AllowUserToAddRows = false;
            DGVProveedores.AllowUserToDeleteRows = false;
            DGVProveedores.AllowUserToResizeColumns = false;
            DGVProveedores.AllowUserToResizeRows = false;
            DGVProveedores.BackgroundColor = Color.White;
            DGVProveedores.BorderStyle = BorderStyle.None;
            DGVProveedores.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGVProveedores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(17, 153, 248);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 153, 248);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVProveedores.ColumnHeadersHeight = 50;
            DGVProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGVProveedores.Columns.AddRange(new DataGridViewColumn[] { ID_Proveedores, Nombre_Proveedores, Contacto });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(212, 234, 255);
            dataGridViewCellStyle2.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(17, 153, 248);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(17, 153, 248);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVProveedores.DefaultCellStyle = dataGridViewCellStyle2;
            DGVProveedores.EnableHeadersVisualStyles = false;
            DGVProveedores.GridColor = Color.White;
            DGVProveedores.Location = new Point(10, 0);
            DGVProveedores.Margin = new Padding(10, 0, 0, 0);
            DGVProveedores.MultiSelect = false;
            DGVProveedores.Name = "DGVProveedores";
            DGVProveedores.ReadOnly = true;
            DGVProveedores.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DGVProveedores.RowHeadersVisible = false;
            DGVProveedores.RowHeadersWidth = 40;
            DGVProveedores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DGVProveedores.RowTemplate.DividerHeight = 2;
            DGVProveedores.RowTemplate.Height = 40;
            DGVProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVProveedores.Size = new Size(582, 520);
            DGVProveedores.TabIndex = 5;
            // 
            // ID_Proveedores
            // 
            ID_Proveedores.HeaderText = "Id";
            ID_Proveedores.Name = "ID_Proveedores";
            ID_Proveedores.ReadOnly = true;
            ID_Proveedores.Width = 50;
            // 
            // Nombre_Proveedores
            // 
            Nombre_Proveedores.HeaderText = "Nombre";
            Nombre_Proveedores.Name = "Nombre_Proveedores";
            Nombre_Proveedores.ReadOnly = true;
            Nombre_Proveedores.Width = 150;
            // 
            // Contacto
            // 
            Contacto.HeaderText = "Contacto";
            Contacto.Name = "Contacto";
            Contacto.ReadOnly = true;
            Contacto.Width = 300;
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
            btnAdd.Location = new Point(13, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(84, 50);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // Frm_Proveedor
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1100, 600);
            Controls.Add(pnlFill);
            Controls.Add(TLPnlTop);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Proveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Proveedor";
            TLPnlTop.ResumeLayout(false);
            pnlFill.ResumeLayout(false);
            pnlAddInfo.ResumeLayout(false);
            pnlAddInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVProveedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TLPnlTop;
        private Button btnDelete;
        private Button btnEdit;
        private Panel pnlFill;
        private Panel pnlAddInfo;
        private Button btnGuardarEditar;
        private Button btnAgregar;
        private Button btnCancelar;
        private TextBox txtNombreProveedor;
        private Label label1;
        private DataGridView DGVProveedores;
        private TextBox txtContactoProveedor;
        private Label label2;
        private DataGridViewTextBoxColumn ID_Proveedores;
        private DataGridViewTextBoxColumn Nombre_Proveedores;
        private DataGridViewTextBoxColumn Contacto;
        private Button btnAdd;
    }
}