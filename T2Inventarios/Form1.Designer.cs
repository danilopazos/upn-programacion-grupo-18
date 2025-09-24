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
            txtCodigo = new TextBox();
            label8 = new Label();
            btnRegistrar = new Button();
            txtCantidad = new TextBox();
            label5 = new Label();
            txtPrecio = new TextBox();
            label4 = new Label();
            comboCategoria1 = new ComboBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            listProductos = new ListBox();
            groupBox2 = new GroupBox();
            btnDescendente = new Button();
            btnAscendente = new Button();
            groupBox3 = new GroupBox();
            lblResultado = new Label();
            label7 = new Label();
            btnSumaTotal = new Button();
            comboCategoria2 = new ComboBox();
            label6 = new Label();
            groupBox4 = new GroupBox();
            label11 = new Label();
            txtBusqueda = new TextBox();
            label12 = new Label();
            label10 = new Label();
            label9 = new Label();
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
            label1.Location = new Point(386, 19);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(714, 72);
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
            groupBox1.Location = new Point(22, 105);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(639, 548);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de productos";
            // 
            // txtCodigo
            // 
            txtCodigo.AccessibleName = "";
            txtCodigo.Location = new Point(147, 70);
            txtCodigo.Margin = new Padding(6);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(457, 50);
            txtCodigo.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(13, 75);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(105, 37);
            label8.TabIndex = 9;
            label8.Text = "Código";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(13, 457);
            btnRegistrar.Margin = new Padding(6);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(591, 79);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(147, 380);
            txtCantidad.Margin = new Padding(6);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(457, 50);
            txtCantidad.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(13, 387);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(125, 37);
            label5.TabIndex = 6;
            label5.Text = "Cantidad";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(147, 305);
            txtPrecio.Margin = new Padding(6);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(457, 50);
            txtPrecio.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(13, 311);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 37);
            label4.TabIndex = 4;
            label4.Text = "Precio";
            // 
            // comboCategoria1
            // 
            comboCategoria1.FormattingEnabled = true;
            comboCategoria1.Location = new Point(147, 230);
            comboCategoria1.Margin = new Padding(6);
            comboCategoria1.Name = "comboCategoria1";
            comboCategoria1.Size = new Size(457, 53);
            comboCategoria1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(13, 236);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(133, 37);
            label3.TabIndex = 2;
            label3.Text = "Categoría";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(147, 145);
            txtNombre.Margin = new Padding(6);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(457, 50);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(13, 151);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 37);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            // 
            // listProductos
            // 
            listProductos.FormattingEnabled = true;
            listProductos.Location = new Point(35, 753);
            listProductos.Margin = new Padding(6);
            listProductos.Name = "listProductos";
            listProductos.Size = new Size(1259, 196);
            listProductos.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDescendente);
            groupBox2.Controls.Add(btnAscendente);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(33, 966);
            groupBox2.Margin = new Padding(6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6);
            groupBox2.Size = new Size(1263, 166);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ordenamiento";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btnDescendente
            // 
            btnDescendente.Location = new Point(761, 60);
            btnDescendente.Margin = new Padding(6);
            btnDescendente.Name = "btnDescendente";
            btnDescendente.Size = new Size(368, 73);
            btnDescendente.TabIndex = 1;
            btnDescendente.Text = "⬇️ Orden Descendente ⬇️";
            btnDescendente.UseVisualStyleBackColor = true;
            // 
            // btnAscendente
            // 
            btnAscendente.Location = new Point(145, 60);
            btnAscendente.Margin = new Padding(6);
            btnAscendente.Name = "btnAscendente";
            btnAscendente.Size = new Size(368, 73);
            btnAscendente.TabIndex = 0;
            btnAscendente.Text = " ⬆️ Orden Ascendente ⬆️";
            btnAscendente.UseVisualStyleBackColor = true;
            btnAscendente.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblResultado);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(btnSumaTotal);
            groupBox3.Controls.Add(comboCategoria2);
            groupBox3.Controls.Add(label6);
            groupBox3.Font = new Font("Segoe UI", 12F);
            groupBox3.Location = new Point(271, 1146);
            groupBox3.Margin = new Padding(6);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(6);
            groupBox3.Size = new Size(891, 235);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Total de stock";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 10F);
            lblResultado.Location = new Point(401, 162);
            lblResultado.Margin = new Padding(6, 0, 6, 0);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(127, 37);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "__________";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(225, 162);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(140, 37);
            label7.TabIndex = 7;
            label7.Text = "Resultado:";
            // 
            // btnSumaTotal
            // 
            btnSumaTotal.Location = new Point(604, 47);
            btnSumaTotal.Margin = new Padding(6);
            btnSumaTotal.Name = "btnSumaTotal";
            btnSumaTotal.Size = new Size(175, 81);
            btnSumaTotal.TabIndex = 6;
            btnSumaTotal.Text = "Suma Total";
            btnSumaTotal.UseVisualStyleBackColor = true;
            // 
            // comboCategoria2
            // 
            comboCategoria2.FormattingEnabled = true;
            comboCategoria2.Location = new Point(154, 60);
            comboCategoria2.Margin = new Padding(6);
            comboCategoria2.Name = "comboCategoria2";
            comboCategoria2.Size = new Size(372, 53);
            comboCategoria2.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(20, 73);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(139, 37);
            label6.TabIndex = 4;
            label6.Text = "Categoría:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(txtBusqueda);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label10);
            groupBox4.Font = new Font("Segoe UI", 12F);
            groupBox4.Location = new Point(711, 250);
            groupBox4.Margin = new Padding(6);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(6);
            groupBox4.Size = new Size(585, 207);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Búsqueda";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.Location = new Point(271, 145);
            label11.Margin = new Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new Size(204, 37);
            label11.TabIndex = 10;
            label11.Text = "_________________";
            label11.Click += label11_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(219, 60);
            txtBusqueda.Margin = new Padding(6);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(323, 50);
            txtBusqueda.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F);
            label12.Location = new Point(74, 145);
            label12.Margin = new Padding(6, 0, 6, 0);
            label12.Name = "label12";
            label12.Size = new Size(140, 37);
            label12.TabIndex = 9;
            label12.Text = "Resultado:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.Location = new Point(11, 65);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(193, 37);
            label10.TabIndex = 11;
            label10.Text = "Buscar nombre";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(546, 702);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(283, 45);
            label9.TabIndex = 6;
            label9.Text = "Lista de productos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 1406);
            Controls.Add(label9);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(listProductos);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(6);
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
