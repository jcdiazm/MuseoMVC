using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class ControllerObraArte
    {
        //Lista Privada
        private static List<ObraArte> listadoObras = new List<ObraArte>();

        //Inicializador
        public static void InicializarObras()
        {
            listadoObras.Add(new ObraArte(1, "La Mona Lisa", "Leonardo Da Vinci", "1503 - 1506", "descripcion"));
            listadoObras.Add(new ObraArte(2, "La Noche Estrellada", "Vincent Van Gogh", "1889", "descripcion"));
            listadoObras.Add(new ObraArte(3, "La persistencia de la memoria", "Salvador Dali", "1405 - 1506", "descripcion"));
            listadoObras.Add(new ObraArte(4, "La Creacion de Ada", "Miguel Angel", "1512", "descripcion"));
        }

        //Obtener Listado
        public static List<ObraArte> ObtenerObras()
        {
            return listadoObras;
        }
    }
}
