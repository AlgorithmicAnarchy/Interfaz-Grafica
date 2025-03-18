namespace CapaPresentacion
{
    partial class Presentacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Presentacion));
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.txt_Producto = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.txt_Stock = new System.Windows.Forms.TextBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.cbx_Categoria = new System.Windows.Forms.ComboBox();
            this.dtp_FechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.cbx_Proveedor = new System.Windows.Forms.ComboBox();
            this.lbl_NombreProducto = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.lbl_Vencimiento = new System.Windows.Forms.Label();
            this.lbl_Proveedor = new System.Windows.Forms.Label();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.btn_Cancelar2 = new System.Windows.Forms.Button();
            this.btnVerReporte = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_VerCulonas = new System.Windows.Forms.DataGridView();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Titulo1 = new System.Windows.Forms.Label();
            this.pnl_Fondo1 = new System.Windows.Forms.Panel();
            this.pbx_Logo = new System.Windows.Forms.PictureBox();
            this.btnInventario = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VerCulonas)).BeginInit();
            this.pnl_Fondo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Location = new System.Drawing.Point(-43, 158);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(96, 35);
            this.btn_Guardar.TabIndex = 3;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Visible = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // txt_Producto
            // 
            this.txt_Producto.BackColor = System.Drawing.Color.Lavender;
            this.txt_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Producto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Producto.Location = new System.Drawing.Point(147, 71);
            this.txt_Producto.Name = "txt_Producto";
            this.txt_Producto.Size = new System.Drawing.Size(188, 22);
            this.txt_Producto.TabIndex = 3;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.BackColor = System.Drawing.Color.Lavender;
            this.txt_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descripcion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Descripcion.Location = new System.Drawing.Point(147, 99);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(188, 22);
            this.txt_Descripcion.TabIndex = 3;
            // 
            // txt_Stock
            // 
            this.txt_Stock.BackColor = System.Drawing.Color.Lavender;
            this.txt_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Stock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Stock.Location = new System.Drawing.Point(147, 127);
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.Size = new System.Drawing.Size(188, 22);
            this.txt_Stock.TabIndex = 3;
            // 
            // txt_Precio
            // 
            this.txt_Precio.BackColor = System.Drawing.Color.Lavender;
            this.txt_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Precio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Precio.Location = new System.Drawing.Point(147, 155);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(188, 22);
            this.txt_Precio.TabIndex = 3;
            // 
            // cbx_Categoria
            // 
            this.cbx_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Categoria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbx_Categoria.FormattingEnabled = true;
            this.cbx_Categoria.Location = new System.Drawing.Point(147, 184);
            this.cbx_Categoria.Name = "cbx_Categoria";
            this.cbx_Categoria.Size = new System.Drawing.Size(188, 21);
            this.cbx_Categoria.TabIndex = 5;
            // 
            // dtp_FechaVencimiento
            // 
            this.dtp_FechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaVencimiento.Location = new System.Drawing.Point(147, 212);
            this.dtp_FechaVencimiento.MinDate = new System.DateTime(2025, 2, 11, 0, 0, 0, 0);
            this.dtp_FechaVencimiento.Name = "dtp_FechaVencimiento";
            this.dtp_FechaVencimiento.Size = new System.Drawing.Size(188, 20);
            this.dtp_FechaVencimiento.TabIndex = 6;
            // 
            // cbx_Proveedor
            // 
            this.cbx_Proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Proveedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbx_Proveedor.FormattingEnabled = true;
            this.cbx_Proveedor.Location = new System.Drawing.Point(147, 238);
            this.cbx_Proveedor.Name = "cbx_Proveedor";
            this.cbx_Proveedor.Size = new System.Drawing.Size(188, 21);
            this.cbx_Proveedor.TabIndex = 5;
            // 
            // lbl_NombreProducto
            // 
            this.lbl_NombreProducto.AutoSize = true;
            this.lbl_NombreProducto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreProducto.ForeColor = System.Drawing.Color.Black;
            this.lbl_NombreProducto.Location = new System.Drawing.Point(28, 71);
            this.lbl_NombreProducto.Name = "lbl_NombreProducto";
            this.lbl_NombreProducto.Size = new System.Drawing.Size(69, 18);
            this.lbl_NombreProducto.TabIndex = 4;
            this.lbl_NombreProducto.Text = "Producto";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripcion.ForeColor = System.Drawing.Color.Black;
            this.lbl_Descripcion.Location = new System.Drawing.Point(28, 99);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(87, 18);
            this.lbl_Descripcion.TabIndex = 4;
            this.lbl_Descripcion.Text = "Descripción";
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.AutoSize = true;
            this.lbl_Stock.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stock.ForeColor = System.Drawing.Color.Black;
            this.lbl_Stock.Location = new System.Drawing.Point(28, 127);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(47, 18);
            this.lbl_Stock.TabIndex = 4;
            this.lbl_Stock.Text = "Stock";
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Precio.ForeColor = System.Drawing.Color.Black;
            this.lbl_Precio.Location = new System.Drawing.Point(28, 155);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(51, 18);
            this.lbl_Precio.TabIndex = 4;
            this.lbl_Precio.Text = "Precio";
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Categoria.ForeColor = System.Drawing.Color.Black;
            this.lbl_Categoria.Location = new System.Drawing.Point(28, 184);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(72, 18);
            this.lbl_Categoria.TabIndex = 4;
            this.lbl_Categoria.Text = "Categoría";
            // 
            // lbl_Vencimiento
            // 
            this.lbl_Vencimiento.AutoSize = true;
            this.lbl_Vencimiento.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Vencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vencimiento.ForeColor = System.Drawing.Color.Black;
            this.lbl_Vencimiento.Location = new System.Drawing.Point(28, 212);
            this.lbl_Vencimiento.Name = "lbl_Vencimiento";
            this.lbl_Vencimiento.Size = new System.Drawing.Size(89, 18);
            this.lbl_Vencimiento.TabIndex = 4;
            this.lbl_Vencimiento.Text = "Vencimiento";
            // 
            // lbl_Proveedor
            // 
            this.lbl_Proveedor.AutoSize = true;
            this.lbl_Proveedor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Proveedor.ForeColor = System.Drawing.Color.Black;
            this.lbl_Proveedor.Location = new System.Drawing.Point(28, 238);
            this.lbl_Proveedor.Name = "lbl_Proveedor";
            this.lbl_Proveedor.Size = new System.Drawing.Size(77, 18);
            this.lbl_Proveedor.TabIndex = 4;
            this.lbl_Proveedor.Text = "Proveedor";
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Actualizar.Location = new System.Drawing.Point(88, 301);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(96, 35);
            this.btn_Actualizar.TabIndex = 3;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Visible = false;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.Color.Brown;
            this.btn_Eliminar.Location = new System.Drawing.Point(-184, 98);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(96, 35);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Visible = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Nuevo.Location = new System.Drawing.Point(138, 301);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(96, 35);
            this.btn_Nuevo.TabIndex = 3;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.Color.Lavender;
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_ID.Location = new System.Drawing.Point(837, 504);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(41, 22);
            this.txt_ID.TabIndex = 3;
            this.txt_ID.Visible = false;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ID.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_ID.Location = new System.Drawing.Point(809, 504);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(28, 22);
            this.lbl_ID.TabIndex = 4;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.Visible = false;
            // 
            // btn_Cancelar2
            // 
            this.btn_Cancelar2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar2.Location = new System.Drawing.Point(189, 301);
            this.btn_Cancelar2.Name = "btn_Cancelar2";
            this.btn_Cancelar2.Size = new System.Drawing.Size(96, 35);
            this.btn_Cancelar2.TabIndex = 3;
            this.btn_Cancelar2.Text = "Cancelar";
            this.btn_Cancelar2.UseVisualStyleBackColor = true;
            this.btn_Cancelar2.Visible = false;
            this.btn_Cancelar2.Click += new System.EventHandler(this.btn_Cancelar2_Click);
            // 
            // btnVerReporte
            // 
            this.btnVerReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(248)))));
            this.btnVerReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerReporte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerReporte.Location = new System.Drawing.Point(241, 309);
            this.btnVerReporte.Name = "btnVerReporte";
            this.btnVerReporte.Size = new System.Drawing.Size(190, 34);
            this.btnVerReporte.TabIndex = 7;
            this.btnVerReporte.Text = "Reporte de Productos";
            this.btnVerReporte.UseVisualStyleBackColor = false;
            this.btnVerReporte.Click += new System.EventHandler(this.btnVerReporte_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lbl_Categoria);
            this.panel1.Controls.Add(this.txt_Producto);
            this.panel1.Controls.Add(this.txt_Descripcion);
            this.panel1.Controls.Add(this.dtp_FechaVencimiento);
            this.panel1.Controls.Add(this.txt_Stock);
            this.panel1.Controls.Add(this.cbx_Proveedor);
            this.panel1.Controls.Add(this.txt_Precio);
            this.panel1.Controls.Add(this.btn_Cancelar2);
            this.panel1.Controls.Add(this.cbx_Categoria);
            this.panel1.Controls.Add(this.btn_Nuevo);
            this.panel1.Controls.Add(this.lbl_Proveedor);
            this.panel1.Controls.Add(this.btn_Actualizar);
            this.panel1.Controls.Add(this.lbl_Vencimiento);
            this.panel1.Controls.Add(this.lbl_NombreProducto);
            this.panel1.Controls.Add(this.lbl_Descripcion);
            this.panel1.Controls.Add(this.lbl_Precio);
            this.panel1.Controls.Add(this.lbl_Stock);
            this.panel1.Location = new System.Drawing.Point(-420, -189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 440);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            // 
            // dgv_VerCulonas
            // 
            this.dgv_VerCulonas.AllowUserToAddRows = false;
            this.dgv_VerCulonas.AllowUserToDeleteRows = false;
            this.dgv_VerCulonas.AllowUserToResizeColumns = false;
            this.dgv_VerCulonas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_VerCulonas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_VerCulonas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_VerCulonas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_VerCulonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_VerCulonas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_VerCulonas.Location = new System.Drawing.Point(41, 3);
            this.dgv_VerCulonas.Name = "dgv_VerCulonas";
            this.dgv_VerCulonas.RowHeadersVisible = false;
            this.dgv_VerCulonas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_VerCulonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_VerCulonas.Size = new System.Drawing.Size(25, 201);
            this.dgv_VerCulonas.TabIndex = 0;
            this.dgv_VerCulonas.Visible = false;
            this.dgv_VerCulonas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_VerDrogas_CellContentClick);
            this.dgv_VerCulonas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_VerCulonas_CellContentClick);
            this.dgv_VerCulonas.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_VerDrogas_CellMouseEnter);
            this.dgv_VerCulonas.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_VerDrogas_CellMouseLeave);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(31, 22);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(96, 35);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Visible = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.BackColor = System.Drawing.Color.Silver;
            this.txt_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_Buscar.Location = new System.Drawing.Point(16, 27);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(188, 22);
            this.txt_Buscar.TabIndex = 3;
            this.txt_Buscar.Visible = false;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(210, 25);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 26);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "BUSCAR";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Visible = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_Titulo1
            // 
            this.lbl_Titulo1.AutoSize = true;
            this.lbl_Titulo1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo1.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Titulo1.Location = new System.Drawing.Point(-343, 48);
            this.lbl_Titulo1.Name = "lbl_Titulo1";
            this.lbl_Titulo1.Size = new System.Drawing.Size(416, 57);
            this.lbl_Titulo1.TabIndex = 0;
            this.lbl_Titulo1.Text = "Gestión de Inventario";
            this.lbl_Titulo1.Visible = false;
            // 
            // pnl_Fondo1
            // 
            this.pnl_Fondo1.BackColor = System.Drawing.Color.DarkRed;
            this.pnl_Fondo1.Controls.Add(this.lbl_Titulo1);
            this.pnl_Fondo1.Controls.Add(this.pbx_Logo);
            this.pnl_Fondo1.Controls.Add(this.btn_Search);
            this.pnl_Fondo1.Controls.Add(this.txt_Buscar);
            this.pnl_Fondo1.Controls.Add(this.btn_Cancelar);
            this.pnl_Fondo1.Controls.Add(this.dgv_VerCulonas);
            this.pnl_Fondo1.Location = new System.Drawing.Point(1, 1);
            this.pnl_Fondo1.Name = "pnl_Fondo1";
            this.pnl_Fondo1.Size = new System.Drawing.Size(906, 100);
            this.pnl_Fondo1.TabIndex = 1;
            this.pnl_Fondo1.Visible = false;
            this.pnl_Fondo1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Fondo1_Paint);
            // 
            // pbx_Logo
            // 
            this.pbx_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pbx_Logo.Image = global::CapaPresentacion.Properties.Resources._4320337;
            this.pbx_Logo.InitialImage = global::CapaPresentacion.Properties.Resources.image;
            this.pbx_Logo.Location = new System.Drawing.Point(810, 3);
            this.pbx_Logo.Name = "pbx_Logo";
            this.pbx_Logo.Size = new System.Drawing.Size(78, 82);
            this.pbx_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Logo.TabIndex = 7;
            this.pbx_Logo.TabStop = false;
            this.pbx_Logo.Visible = false;
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(248)))));
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInventario.Location = new System.Drawing.Point(467, 309);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(190, 34);
            this.btnInventario.TabIndex = 9;
            this.btnInventario.Text = "Reporte de Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // Presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 535);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVerReporte);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.pnl_Fondo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Presentacion";
            this.Text = "Sistema de Gestión de Inventario";
            this.Load += new System.EventHandler(this.Presentacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_VerCulonas)).EndInit();
            this.pnl_Fondo1.ResumeLayout(false);
            this.pnl_Fondo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TextBox txt_Producto;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.TextBox txt_Stock;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.ComboBox cbx_Categoria;
        private System.Windows.Forms.DateTimePicker dtp_FechaVencimiento;
        private System.Windows.Forms.ComboBox cbx_Proveedor;
        private System.Windows.Forms.Label lbl_NombreProducto;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_Stock;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.Label lbl_Vencimiento;
        private System.Windows.Forms.Label lbl_Proveedor;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Button btn_Cancelar2;
        private System.Windows.Forms.Button btnVerReporte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_VerCulonas;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.PictureBox pbx_Logo;
        private System.Windows.Forms.Label lbl_Titulo1;
        private System.Windows.Forms.Panel pnl_Fondo1;
        private System.Windows.Forms.Button btnInventario;
    }
}