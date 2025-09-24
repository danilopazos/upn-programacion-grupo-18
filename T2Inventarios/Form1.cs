using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace T2Inventarios
{
    public partial class Form1 : Form
    {
        private List<Producto> productos = new List<Producto>();

        private List<Categoria> categorias = new List<Categoria>();
        public Form1()
        {
            InitializeComponent();
            InicializarCategorias();
        }

        private void InicializarCategorias()
        {
            categorias.Add(new Categoria("Seleccione - -"));
            categorias.Add(new Categoria("Hatchback"));
            categorias.Add(new Categoria("Sedan"));
            categorias.Add(new Categoria("SUV"));
            categorias.Add(new Categoria("Comercial"));

            comboCategoria1.DataSource = categorias;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            decimal precio;
            int cantidad;

            // Validando que no esté vacío
            if (string.IsNullOrWhiteSpace(codigo) ||
                string.IsNullOrWhiteSpace(nombre) ||
                !decimal.TryParse(txtPrecio.Text, out precio) ||
                !int.TryParse(txtCantidad.Text, out cantidad) ||
                comboCategoria1.SelectedItem == null)
            {
                MessageBox.Show("Completa todos los campos por favor.");
                return;
            }

            Categoria categoria = (Categoria)comboCategoria1.SelectedItem;
            Producto nuevoProducto = new Producto(codigo, nombre, categoria, precio, cantidad);

            productos.Add(nuevoProducto);
            listProductos.Items.Add(nuevoProducto.ToString());

            MessageBox.Show("Producto registrado:\n" + nuevoProducto.ToString());

            // Limpiando campos luego de guardar
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            comboCategoria1.SelectedIndex = 0;
        }
    }
}
