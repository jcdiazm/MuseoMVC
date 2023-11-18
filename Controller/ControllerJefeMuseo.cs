using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class ControllerJefeMuseo
    {
        //Lista Privada
        private static List<JefeMuseo> listadoJefes = new List<JefeMuseo>();

        //Inicializador
        public static void InicializarJefes()
        {
            listadoJefes.Add(new JefeMuseo(1, "jcdiaz", "Juan Carlos", "Diaz", "123"));
            listadoJefes.Add(new JefeMuseo(2, "jmedina", "Jocelyn", "Medina", "124"));
        }

        //Obtener Listado
        public static List<JefeMuseo> ObtenerJefeMuseo()
        {
            return listadoJefes;
        }
    }
}
