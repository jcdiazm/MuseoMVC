using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TourEscolar
    {
        public int Id { get; set; }

        public List<Guia> GuiaAsignados { get; set; } 


        public String Estado { get; set; }
        public TourEscolar (int id, List<Guia> listadoGuias, String estado)
        {
            Id = id;
            GuiaAsignados = listadoGuias;
            Estado = estado;
        }
    }
}
