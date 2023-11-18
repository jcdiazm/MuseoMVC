using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class ControllerInsumo
    {
        //Lista privada
        private static List<Insumo> listadoInsumos = new List<Insumo>();

        //Inicializador
        public static void InicializarInsumos()
        {
            //Listado con algunos insumos
            List<Insumo> listadoInsumos = new List<Insumo>();
            listadoInsumos.Add(new Insumo(1,"Credenciales","Documento para identificar visitantes"));
            listadoInsumos.Add(new Insumo(1, "Mascarillas", "Proteccion Facial"));
            listadoInsumos.Add(new Insumo(1, "Desayuno", "Colaciones para visitantes"));
        }

        //Obtener Listado
        public static List<Insumo> ObtenerInsumos()
        {
            return listadoInsumos;
        }

    }
}
