using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class ControllerGaleria
    {
        //Lista privada
        private static List<Galeria> listadoGalerias = new List<Galeria>();

        //Inicializador
        public static void InicializarGaleria()
        {
            //Listado con 1 Galeria (con 1 Exposicion)
            List<Exposicion> listadoExposicionesGaleria = new List<Exposicion>();
            listadoExposicionesGaleria.Add(ControllerExposicion.ObtenerExposiciones()[0]);
            Galeria galeria = new Galeria(1, "Galeria JCD", listadoExposicionesGaleria);
            listadoGalerias.Add(galeria);
        }

        //Obtener Listado
        public static List<Galeria> ObtenerGalerias()
        {
            return listadoGalerias;
        }
    }
}
