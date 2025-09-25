using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2Inventarios
{
    public class Categoria
    {
        public string G18_Nombre { get; set; }

        public Categoria(string G18_nombre)
        {
            G18_Nombre = G18_nombre;
        }

        public override string ToString()
        {
            return G18_Nombre;
        }
    }
}
