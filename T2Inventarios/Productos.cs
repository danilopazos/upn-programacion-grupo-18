using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2Inventarios
{
    public class Producto
    {
        public string G18_Codigo { get; set; }
        public string G18_Nombre { get; set; }
        public Categoria G18_Categoria { get; set; }
        public decimal G18_Precio { get; set; }
        public int G18_Cantidad { get; set; }

        public Producto(string G18_codigo, string G18_nombre, Categoria G18_categoria, decimal G18_precio, int G18_cantidad)
        {
            G18_Codigo = G18_codigo;
            G18_Nombre = G18_nombre;
            G18_Categoria = G18_categoria;
            G18_Precio = G18_precio;
            G18_Cantidad = G18_cantidad;
        }

        public override string ToString()
        {
            return $"{G18_Codigo} - {G18_Nombre} - {G18_Categoria.G18_Nombre} - ${G18_Precio} - x{G18_Cantidad}und";
        }
    }
}
