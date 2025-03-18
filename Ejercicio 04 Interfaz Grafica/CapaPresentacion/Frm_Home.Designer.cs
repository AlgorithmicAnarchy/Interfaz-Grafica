namespace CapaPresentacion
{
    partial class Frm_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Home));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lblParrafo1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(698, 318);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(366, 246);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(17, 134, 248);
            label1.Location = new Point(73, 41);
            label1.Name = "label1";
            label1.Size = new Size(277, 51);
            label1.TabIndex = 1;
            label1.Text = "Bienvenidos! :)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(283, 41);
            label2.Name = "label2";
            label2.Size = new Size(77, 51);
            label2.TabIndex = 2;
            label2.Text = "! :)";
            // 
            // lblParrafo1
            // 
            lblParrafo1.Font = new Font("Comic Sans MS", 10F);
            lblParrafo1.ForeColor = Color.FromArgb(17, 149, 248);
            lblParrafo1.Location = new Point(73, 117);
            lblParrafo1.Name = "lblParrafo1";
            lblParrafo1.Size = new Size(558, 143);
            lblParrafo1.TabIndex = 3;
            lblParrafo1.Text = resources.GetString("lblParrafo1.Text");
            // 
            // label3
            // 
            label3.Font = new Font("Comic Sans MS", 10F);
            label3.ForeColor = Color.FromArgb(17, 149, 248);
            label3.Location = new Point(73, 284);
            label3.Name = "label3";
            label3.Size = new Size(558, 83);
            label3.TabIndex = 4;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            label4.Font = new Font("Comic Sans MS", 10F);
            label4.ForeColor = Color.FromArgb(17, 149, 248);
            label4.Location = new Point(73, 399);
            label4.Name = "label4";
            label4.Size = new Size(558, 85);
            label4.TabIndex = 5;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label5
            // 
            label5.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(17, 119, 248);
            label5.Location = new Point(73, 494);
            label5.Name = "label5";
            label5.Size = new Size(130, 33);
            label5.TabIndex = 6;
            label5.Text = "Desarrollado por: ";
            // 
            // label6
            // 
            label6.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(17, 179, 248);
            label6.Location = new Point(193, 494);
            label6.Name = "label6";
            label6.Size = new Size(188, 33);
            label6.TabIndex = 7;
            label6.Text = "Francisco Ramos Peguero";
            // 
            // label7
            // 
            label7.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(193, 527);
            label7.Name = "label7";
            label7.Size = new Size(216, 33);
            label7.TabIndex = 9;
            label7.Text = "Michael Brito, Jose Mercedes";
            label7.Visible = false;
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(17, 119, 248);
            label8.Location = new Point(73, 527);
            label8.Name = "label8";
            label8.Size = new Size(130, 33);
            label8.TabIndex = 8;
            label8.Text = "Colaboradores: ";
            label8.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(716, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(348, 234);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // Frm_Home
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1100, 600);
            Controls.Add(pictureBox2);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblParrafo1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Comic Sans MS", 9F);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Home";
            Load += Frm_Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label lblParrafo1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox2;
    }
}