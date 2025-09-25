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
            groupBox3 = new GroupBox();
            txtResultado = new TextBox();
            label7 = new Label();
            btnSumaTotal = new Button();
            comboCategoria2 = new ComboBox();
            label6 = new Label();
            groupBox4 = new GroupBox();
            btnBorrarFiltros = new Button();
            btnBuscar = new Button();
            label11 = new Label();
            btnDescendente = new Button();
            btnAscendente = new Button();
            txtBusqueda = new TextBox();
            label10 = new Label();
            label9 = new Label();
            dataGridProductos = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(347, 27);
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
            groupBox1.Size = new Size(1274, 293);
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
            btnRegistrar.Font = new Font("Segoe UI", 10F);
            btnRegistrar.Location = new Point(631, 216);
            btnRegistrar.Margin = new Padding(6);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(591, 50);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(147, 216);
            txtCantidad.Margin = new Padding(6);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(457, 50);
            txtCantidad.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(13, 223);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(125, 37);
            label5.TabIndex = 6;
            label5.Text = "Cantidad";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(765, 142);
            txtPrecio.Margin = new Padding(6);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(457, 50);
            txtPrecio.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(631, 148);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 37);
            label4.TabIndex = 4;
            label4.Text = "Precio";
            // 
            // comboCategoria1
            // 
            comboCategoria1.FormattingEnabled = true;
            comboCategoria1.Location = new Point(147, 142);
            comboCategoria1.Margin = new Padding(6);
            comboCategoria1.Name = "comboCategoria1";
            comboCategoria1.Size = new Size(457, 53);
            comboCategoria1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(13, 148);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(133, 37);
            label3.TabIndex = 2;
            label3.Text = "Categoría";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(765, 66);
            txtNombre.Margin = new Padding(6);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(457, 50);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(631, 72);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 37);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtResultado);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(btnSumaTotal);
            groupBox3.Controls.Add(comboCategoria2);
            groupBox3.Controls.Add(label6);
            groupBox3.Font = new Font("Segoe UI", 12F);
            groupBox3.Location = new Point(35, 974);
            groupBox3.Margin = new Padding(6);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(6);
            groupBox3.Size = new Size(1261, 143);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Stock total";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(1022, 60);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(239, 50);
            txtResultado.TabIndex = 8;
            txtResultado.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(873, 68);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(134, 37);
            label7.TabIndex = 7;
            label7.Text = "Resultado";
            // 
            // btnSumaTotal
            // 
            btnSumaTotal.Font = new Font("Segoe UI", 10F);
            btnSumaTotal.Location = new Point(538, 60);
            btnSumaTotal.Margin = new Padding(6);
            btnSumaTotal.Name = "btnSumaTotal";
            btnSumaTotal.Size = new Size(175, 53);
            btnSumaTotal.TabIndex = 6;
            btnSumaTotal.Text = "Calcular";
            btnSumaTotal.UseVisualStyleBackColor = true;
            btnSumaTotal.Click += btnSumaTotal_Click;
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
            label6.Location = new Point(12, 66);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(133, 37);
            label6.TabIndex = 4;
            label6.Text = "Categoría";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnBorrarFiltros);
            groupBox4.Controls.Add(btnBuscar);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(btnDescendente);
            groupBox4.Controls.Add(btnAscendente);
            groupBox4.Controls.Add(txtBusqueda);
            groupBox4.Controls.Add(label10);
            groupBox4.Font = new Font("Segoe UI", 12F);
            groupBox4.Location = new Point(22, 410);
            groupBox4.Margin = new Padding(6);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(6);
            groupBox4.Size = new Size(1274, 132);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Filtrar productos";
            // 
            // btnBorrarFiltros
            // 
            btnBorrarFiltros.Font = new Font("Segoe UI", 10F);
            btnBorrarFiltros.Location = new Point(1030, 62);
            btnBorrarFiltros.Margin = new Padding(6);
            btnBorrarFiltros.Name = "btnBorrarFiltros";
            btnBorrarFiltros.Size = new Size(192, 50);
            btnBorrarFiltros.TabIndex = 15;
            btnBorrarFiltros.Text = "Borrar filtros";
            btnBorrarFiltros.UseVisualStyleBackColor = true;
            btnBorrarFiltros.Click += button4_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 10F);
            btnBuscar.Location = new Point(608, 60);
            btnBuscar.Margin = new Padding(6);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(141, 50);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.Location = new Point(758, 67);
            label11.Name = "label11";
            label11.Size = new Size(114, 37);
            label11.TabIndex = 13;
            label11.Text = "Ordenar";
            // 
            // btnDescendente
            // 
            btnDescendente.Font = new Font("Segoe UI", 10F);
            btnDescendente.Location = new Point(955, 62);
            btnDescendente.Margin = new Padding(6);
            btnDescendente.Name = "btnDescendente";
            btnDescendente.Size = new Size(62, 50);
            btnDescendente.TabIndex = 12;
            btnDescendente.Text = "⬇️";
            btnDescendente.UseVisualStyleBackColor = true;
            btnDescendente.Click += btnDescendente_Click;
            // 
            // btnAscendente
            // 
            btnAscendente.Font = new Font("Segoe UI", 10F);
            btnAscendente.Location = new Point(881, 62);
            btnAscendente.Margin = new Padding(6);
            btnAscendente.Name = "btnAscendente";
            btnAscendente.Size = new Size(62, 50);
            btnAscendente.TabIndex = 8;
            btnAscendente.Text = "⬆️";
            btnAscendente.UseVisualStyleBackColor = true;
            btnAscendente.Click += btnAscendente_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(209, 60);
            txtBusqueda.Margin = new Padding(6);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(385, 50);
            txtBusqueda.TabIndex = 11;
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
            label9.Location = new Point(35, 584);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(283, 45);
            label9.TabIndex = 6;
            label9.Text = "Lista de productos";
            // 
            // dataGridProductos
            // 
            dataGridProductos.AllowUserToAddRows = false;
            dataGridProductos.AllowUserToDeleteRows = false;
            dataGridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProductos.Location = new Point(35, 644);
            dataGridProductos.Name = "dataGridProductos";
            dataGridProductos.ReadOnly = true;
            dataGridProductos.RowHeadersWidth = 82;
            dataGridProductos.Size = new Size(1261, 305);
            dataGridProductos.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 1131);
            Controls.Add(dataGridProductos);
            Controls.Add(label9);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "INVENTARIOS";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProductos).EndInit();
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
        private GroupBox groupBox3;
        private ComboBox comboCategoria2;
        private Label label6;
        private Label label7;
        private Button btnSumaTotal;
        private TextBox txtCodigo;
        private Label label8;
        private GroupBox groupBox4;
        private Label label9;
        private Label label10;
        private DataGridView dataGridProductos;
        private TextBox txtBusqueda;
        private Button btnDescendente;
        private Button btnAscendente;
        private Label label11;
        private TextBox txtResultado;
        private Button btnBorrarFiltros;
        private Button btnBuscar;
    }
}
