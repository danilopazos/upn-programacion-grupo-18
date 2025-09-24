namespace T2Inventarios
{
    partial class Form1
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            comboCategoria1 = new ComboBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            label5 = new Label();
            btnRegistrar = new Button();
            listProductos = new ListBox();
            groupBox2 = new GroupBox();
            btnAscendente = new Button();
            btnDescendente = new Button();
            groupBox3 = new GroupBox();
            comboCategoria2 = new ComboBox();
            label6 = new Label();
            btnSumaTotal = new Button();
            label7 = new Label();
            lblResultado = new Label();
            txtCodigo = new TextBox();
            label8 = new Label();
            groupBox4 = new GroupBox();
            label9 = new Label();
            label10 = new Label();
            txtBusqueda = new TextBox();
            label11 = new Label();
            label12 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(208, 9);
            label1.Name = "label1";
            label1.Size = new Size(357, 37);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA DE INVENTARIOS";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboCategoria1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(12, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(344, 257);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registrar Productos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(7, 153);
            label4.Name = "label4";
            label4.Size = new Size(49, 19);
            label4.TabIndex = 4;
            label4.Text = "Precio:";
            // 
            // comboCategoria1
            // 
            comboCategoria1.FormattingEnabled = true;
            comboCategoria1.Location = new Point(79, 108);
            comboCategoria1.Name = "comboCategoria1";
            comboCategoria1.Size = new Size(248, 29);
            comboCategoria1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(7, 114);
            label3.Name = "label3";
            label3.Size = new Size(71, 19);
            label3.TabIndex = 2;
            label3.Text = "Categoría:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(79, 68);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(248, 29);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(7, 77);
            label2.Name = "label2";
            label2.Size = new Size(66, 19);
            label2.TabIndex = 0;
            label2.Text = "Nombre: ";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(79, 143);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(248, 29);
            txtPrecio.TabIndex = 5;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(79, 178);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(248, 29);
            txtCantidad.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(7, 188);
            label5.Name = "label5";
            label5.Size = new Size(67, 19);
            label5.TabIndex = 6;
            label5.Text = "Cantidad:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(115, 214);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(116, 37);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // listProductos
            // 
            listProductos.FormattingEnabled = true;
            listProductos.ItemHeight = 15;
            listProductos.Location = new Point(19, 353);
            listProductos.Name = "listProductos";
            listProductos.Size = new Size(680, 94);
            listProductos.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDescendente);
            groupBox2.Controls.Add(btnAscendente);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(18, 453);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(680, 78);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ordenamiento";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btnAscendente
            // 
            btnAscendente.Location = new Point(78, 28);
            btnAscendente.Name = "btnAscendente";
            btnAscendente.Size = new Size(198, 34);
            btnAscendente.TabIndex = 0;
            btnAscendente.Text = " ⬆️ Orden Ascendente ⬆️";
            btnAscendente.UseVisualStyleBackColor = true;
            btnAscendente.Click += button1_Click;
            // 
            // btnDescendente
            // 
            btnDescendente.Location = new Point(410, 28);
            btnDescendente.Name = "btnDescendente";
            btnDescendente.Size = new Size(198, 34);
            btnDescendente.TabIndex = 1;
            btnDescendente.Text = "⬇️ Orden Descendente ⬇️";
            btnDescendente.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblResultado);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(btnSumaTotal);
            groupBox3.Controls.Add(comboCategoria2);
            groupBox3.Controls.Add(label6);
            groupBox3.Font = new Font("Segoe UI", 12F);
            groupBox3.Location = new Point(146, 537);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(480, 110);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Total de stock";
            // 
            // comboCategoria2
            // 
            comboCategoria2.FormattingEnabled = true;
            comboCategoria2.Location = new Point(83, 28);
            comboCategoria2.Name = "comboCategoria2";
            comboCategoria2.Size = new Size(202, 29);
            comboCategoria2.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(11, 34);
            label6.Name = "label6";
            label6.Size = new Size(71, 19);
            label6.TabIndex = 4;
            label6.Text = "Categoría:";
            // 
            // btnSumaTotal
            // 
            btnSumaTotal.Location = new Point(325, 22);
            btnSumaTotal.Name = "btnSumaTotal";
            btnSumaTotal.Size = new Size(94, 38);
            btnSumaTotal.TabIndex = 6;
            btnSumaTotal.Text = "Suma Total";
            btnSumaTotal.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(121, 76);
            label7.Name = "label7";
            label7.Size = new Size(72, 19);
            label7.TabIndex = 7;
            label7.Text = "Resultado:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 10F);
            lblResultado.Location = new Point(216, 76);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(69, 19);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "__________";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(79, 33);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(248, 29);
            txtCodigo.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(7, 42);
            label8.Name = "label8";
            label8.Size = new Size(60, 19);
            label8.TabIndex = 9;
            label8.Text = "Codigo: ";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(txtBusqueda);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label10);
            groupBox4.Font = new Font("Segoe UI", 12F);
            groupBox4.Location = new Point(383, 117);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(315, 97);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Busqueda";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(294, 329);
            label9.Name = "label9";
            label9.Size = new Size(137, 21);
            label9.TabIndex = 6;
            label9.Text = "Lista de productos";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.Location = new Point(6, 33);
            label10.Name = "label10";
            label10.Size = new Size(106, 19);
            label10.TabIndex = 11;
            label10.Text = "Buscar Nombre:";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(118, 28);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(176, 29);
            txtBusqueda.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.Location = new Point(146, 68);
            label11.Name = "label11";
            label11.Size = new Size(111, 19);
            label11.TabIndex = 10;
            label11.Text = "_________________";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F);
            label12.Location = new Point(40, 68);
            label12.Name = "label12";
            label12.Size = new Size(72, 19);
            label12.TabIndex = 9;
            label12.Text = "Resultado:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 659);
            Controls.Add(label9);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(listProductos);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "INVENTARIOS";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private ComboBox comboCategoria1;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtPrecio;
        private Button btnRegistrar;
        private TextBox txtCantidad;
        private Label label5;
        private ListBox listProductos;
        private GroupBox groupBox2;
        private Button btnDescendente;
        private Button btnAscendente;
        private GroupBox groupBox3;
        private ComboBox comboCategoria2;
        private Label label6;
        private Label lblResultado;
        private Label label7;
        private Button btnSumaTotal;
        private TextBox txtCodigo;
        private Label label8;
        private GroupBox groupBox4;
        private Label label9;
        private Label label11;
        private TextBox txtBusqueda;
        private Label label12;
        private Label label10;
    }
}
