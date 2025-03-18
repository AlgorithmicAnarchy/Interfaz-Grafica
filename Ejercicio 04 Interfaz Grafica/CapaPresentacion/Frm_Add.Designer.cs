namespace CapaPresentacion
{
    partial class Frm_Add
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
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            txtStock = new TextBox();
            label4 = new Label();
            txtPrecio = new TextBox();
            label5 = new Label();
            cmbCategoria = new ComboBox();
            cmbProveedor = new ComboBox();
            label6 = new Label();
            btnCancelar = new Button();
            btnAdd = new Button();
            label7 = new Label();
            dtpVencimiento = new DateTimePicker();
            txt_ID = new TextBox();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(244, 67);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(234, 30);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 70);
            label1.Name = "label1";
            label1.Size = new Size(172, 23);
            label1.TabIndex = 1;
            label1.Text = "Nombre del Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(40, 128);
            label2.Name = "label2";
            label2.Size = new Size(198, 23);
            label2.TabIndex = 3;
            label2.Text = "Descripcion del Producto";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(244, 125);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(234, 30);
            txtDescripcion.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(40, 184);
            label3.Name = "label3";
            label3.Size = new Size(107, 23);
            label3.TabIndex = 5;
            label3.Text = "Stock actual";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(244, 181);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(234, 30);
            txtStock.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(40, 240);
            label4.Name = "label4";
            label4.Size = new Size(158, 23);
            label4.TabIndex = 7;
            label4.Text = "Precio del Producto";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(244, 237);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(234, 30);
            txtPrecio.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(40, 295);
            label5.Name = "label5";
            label5.Size = new Size(186, 23);
            label5.TabIndex = 9;
            label5.Text = "Categoría del Producto";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(244, 292);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(234, 31);
            cmbCategoria.TabIndex = 10;
            // 
            // cmbProveedor
            // 
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(244, 353);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(234, 31);
            cmbProveedor.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(40, 356);
            label6.Name = "label6";
            label6.Size = new Size(188, 23);
            label6.TabIndex = 11;
            label6.Text = "Proveedor del Producto";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(109, 493);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(131, 42);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(271, 493);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(131, 42);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(40, 414);
            label7.Name = "label7";
            label7.Size = new Size(201, 23);
            label7.TabIndex = 15;
            label7.Text = "Vencimiento del Producto";
            // 
            // dtpVencimiento
            // 
            dtpVencimiento.Location = new Point(244, 412);
            dtpVencimiento.Name = "dtpVencimiento";
            dtpVencimiento.Size = new Size(234, 30);
            dtpVencimiento.TabIndex = 17;
            // 
            // txt_ID
            // 
            txt_ID.BackColor = Color.FromArgb(17, 153, 248);
            txt_ID.BorderStyle = BorderStyle.None;
            txt_ID.Location = new Point(477, 539);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(27, 23);
            txt_ID.TabIndex = 18;
            // 
            // Frm_Add
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(17, 153, 248);
            ClientSize = new Size(516, 581);
            Controls.Add(txt_ID);
            Controls.Add(dtpVencimiento);
            Controls.Add(label7);
            Controls.Add(btnAdd);
            Controls.Add(btnCancelar);
            Controls.Add(cmbProveedor);
            Controls.Add(label6);
            Controls.Add(cmbCategoria);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPrecio);
            Controls.Add(label3);
            Controls.Add(txtStock);
            Controls.Add(label2);
            Controls.Add(txtDescripcion);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Add";
            Load += Frm_Add_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private TextBox txtDescripcion;
        private Label label3;
        private TextBox txtStock;
        private Label label4;
        private TextBox txtPrecio;
        private Label label5;
        private ComboBox cmbCategoria;
        private ComboBox cmbProveedor;
        private Label label6;
        private Button btnCancelar;
        private Button btnAdd;
        private Label label7;
        private DateTimePicker dtpVencimiento;
        private TextBox txt_ID;
    }
}