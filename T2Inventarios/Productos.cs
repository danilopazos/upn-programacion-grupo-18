using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2Inventarios
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public Categoria Categoria { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        public Producto(string codigo, string nombre, Categoria categoria, decimal precio, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
            Cantidad = cantidad;
        }

        public override string ToString()
        {
            return $"{Codigo} - {Nombre} - {Categoria.Nombre} - ${Precio} - x{Cantidad}und";
        }
    }
}
