using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Insumo
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public Insumo(int id, string nombre, string descripcion)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
