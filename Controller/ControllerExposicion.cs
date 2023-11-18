using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class ControllerExposicion
    {
        //lista privada 
        private static List<Exposicion> listadoExposiciones = new List<Exposicion>();
        
        //Inicializador
        public static void InicializarExposiciones()
        {
            List<ObraArte> obrasExposicion1 = new List<ObraArte>();
            obrasExposicion1.Add(ControllerObraArte.ObtenerObras()[0]);
            obrasExposicion1.Add(ControllerObraArte.ObtenerObras()[1]);
            obrasExposicion1.Add(ControllerObraArte.ObtenerObras()[2]);

            Exposicion exposicion1 = new Exposicion(1, "Exposicion de Obras Famosas", "2023-11-01", "2023-12-10", obrasExposicion1);
            listadoExposiciones.Add(exposicion1);

            List<ObraArte> obrasExposicion2 = new List<ObraArte>();
            obrasExposicion2.Add(ControllerObraArte.ObtenerObras()[3]);
            obrasExposicion2.Add(ControllerObraArte.ObtenerObras()[2]);

            Exposicion exposicion2 = new Exposicion(1, "Exposicion de Arte Renacentista", "2023-12-15", "2024-01-15", obrasExposicion2);
            listadoExposiciones.Add(exposicion2);
        }

        //Obtener Listado
        public static List<Exposicion> ObtenerExposiciones()
        {
            return listadoExposiciones;
        }

        public static Exposicion BuscaExposicion(int idBuscar)
        {
            foreach (var expo in listadoExposiciones)
            {
                if (expo.Id == idBuscar)
                {
                    return expo;
                }
            }
            return null;
        }
    }
}
