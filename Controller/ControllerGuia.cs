using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class ControllerGuia
    {
        //Lista Privada
        private static List<Guia> listadoGuias = new List<Guia>();

        //Inicializador
        public static void InicializarGuias()
        {
            listadoGuias.Add(new Guia(1, "mgonzalez", "Marcela", "Gonzalkez", "12347"));
            listadoGuias.Add(new Guia(2, "opereira", "Osvaldo", "Pereira", "12348"));
        } 

        //Obtener Listado
        public static List<Guia> ObtenerGuias()
        {
            return listadoGuias;
        }
    }
}
