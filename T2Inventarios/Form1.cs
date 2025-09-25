using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace T2Inventarios
{
    public partial class Form1 : Form
    {
        BindingList<Producto> G18_productos = new BindingList<Producto>();

        private List<Categoria> G18_categorias = new List<Categoria>();
        public Form1()
        {
            InitializeComponent();
            InicializarCategorias();
        }

        private void InicializarCategorias()
        {
            // Cargando opciones al combo
            List<Categoria> categoriasBase = new List<Categoria>{
                new Categoria("Seleccione --"),
                new Categoria("Hatchback"),
                new Categoria("Sedan"),
                new Categoria("SUV"),
                new Categoria("Comercial")
            };
            comboCategoria1.DataSource = new List<Categoria>(categoriasBase);
            comboCategoria2.DataSource = new List<Categoria>(categoriasBase);
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
            string G18_codigo = txtCodigo.Text;
            string G18_nombre = txtNombre.Text;
            decimal G18_precio;
            int G18_cantidad;

            // Validando que no esté vacío
            if (string.IsNullOrWhiteSpace(G18_codigo) || G18_codigo.Length > 4)
            {
                MessageBox.Show("El código es obligatorio y no debe exceder 4 caracteres.");
                return;
            }

            if (string.IsNullOrWhiteSpace(G18_nombre) || G18_nombre.Length > 50)
            {
                MessageBox.Show("El nombre es obligatorio y no debe exceder 50 caracteres.");
                return;
            }

            // Validar precio (decimal con 2 decimales como máximo)
            if (!decimal.TryParse(txtPrecio.Text, out G18_precio))
            {
                MessageBox.Show("El precio debe ser un valor numérico válido.");
                return;
            }
            else
            {
                // Limitar a 2 decimales
                if (decimal.Round(G18_precio, 2) != G18_precio)
                {
                    MessageBox.Show("El precio solo puede tener hasta 2 decimales.");
                    return;
                }
            }

            // Validar cantidad (entero, máximo 4 dígitos)
            if (!int.TryParse(txtCantidad.Text, out G18_cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero válido.");
                return;
            }
            else
            {
                if (G18_cantidad.ToString().Length > 4)
                {
                    MessageBox.Show("La cantidad no debe exceder 4 dígitos.");
                    return;
                }
            }

            // Validar categoría
            if (comboCategoria1.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una categoría.");
                return;
            }

            // Validando si el código ya existe
            if (G18_productos.Any(p => p.G18_Codigo == G18_codigo))
            {
                MessageBox.Show("El código ya existe, no se puede registrar.");
                return;
            }

            Categoria G18_categoria = (Categoria)comboCategoria1.SelectedItem;
            Producto G18_nuevoProducto = new Producto(G18_codigo, G18_nombre, G18_categoria, G18_precio, G18_cantidad);

            G18_productos.Add(G18_nuevoProducto);

            // Cargando datos al combo
            dataGridProductos.DataSource = G18_productos;

            // Cargando cabeceras al datagridview
            dataGridProductos.Columns["G18_Codigo"].HeaderText = "Código";
            dataGridProductos.Columns["G18_Nombre"].HeaderText = "Nombre";
            dataGridProductos.Columns["G18_Categoria"].HeaderText = "Categoría";
            dataGridProductos.Columns["G18_Precio"].HeaderText = "Precio ($)";
            dataGridProductos.Columns["G18_Cantidad"].HeaderText = "Cantidad";

            MessageBox.Show("¡Producto registrado!");

            // Limpiando campos luego de guardar
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            comboCategoria1.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string G18_busqueda = txtBusqueda.Text;

            // Validando que no este vacio
            if (string.IsNullOrWhiteSpace(G18_busqueda)){
                MessageBox.Show("Ingrese un texto para buscar.");
                return;
            }

            // Busqueda desde cualquier punto, todas las coincidencias
            var resultados = G18_productos
                .Where(p => p.G18_Nombre.Contains(G18_busqueda, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (resultados.Count == 0){
                dataGridProductos.DataSource = new BindingList<Producto>(new List<Producto>());
                MessageBox.Show("No se encontraron productos.");
                return;
            }

            dataGridProductos.DataSource = new BindingList<Producto>(resultados);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Mostrando datos iniciales
            dataGridProductos.DataSource = G18_productos;
            txtBusqueda.Text = "";
        }

        private void btnAscendente_Click(object sender, EventArgs e)
        {
            // Ordena
            var G18_orden_asc = G18_productos
                .OrderBy(p => p.G18_Precio)
                .ToList();

            dataGridProductos.DataSource = new BindingList<Producto>(G18_orden_asc);
        }

        private void btnDescendente_Click(object sender, EventArgs e)
        {
            // Ordena
            var G18_orden_desc = G18_productos
                .OrderByDescending(p => p.G18_Precio)
                .ToList();

            dataGridProductos.DataSource = new BindingList<Producto>(G18_orden_desc);
        }

        private void btnSumaTotal_Click(object sender, EventArgs e)
        {
            if (comboCategoria2.SelectedItem == null){
                MessageBox.Show("Seleccione una categoría.");
                return;
            }

            string G18_categoriaSeleccionada = comboCategoria2.SelectedItem.ToString();

            List<Producto> G18_lista = G18_productos.ToList();

            // Llama a funcion recursiva
            int G18_total = CalcularStockRecursivo(G18_lista, G18_categoriaSeleccionada, 0);

            txtResultado.Text = G18_total.ToString();
        }

        private int CalcularStockRecursivo(List<Producto> G18_productos, string G18_categoria, int G18_index)
        {
            if (G18_index >= G18_productos.Count)
                return 0;

            // Sumatoria por cantidad
            int cantidadActual = (G18_productos[G18_index].G18_Categoria.ToString() == G18_categoria)
                ? G18_productos[G18_index].G18_Cantidad
                : 0;

            return cantidadActual + CalcularStockRecursivo(G18_productos, G18_categoria, G18_index + 1);
        }
    }
}
