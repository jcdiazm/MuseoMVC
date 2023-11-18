using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class ControllerCurso
    {
        //Lista Privada
        private static List<Curso> listaCurso = new List<Curso>();

        //Inicializador
        public static void InicializarCurso()
        {
            listaCurso.Add(new Curso(1, "Colegio Naciones", "1 - Basico", "Jose Cervantez", "Colomba Muñoz", 34));
            listaCurso.Add(new Curso(2, "Colegio ANTU", "3 - Medio", "Juan Carvajal", "Valentina Toro", 24));
            listaCurso.Add(new Curso(3, "Colegio Brisas", "8 - Basico", "Salvador Castellon", "Leyla Cifuentes", 25));
            listaCurso.Add(new Curso(4, "Don Bosco", "4 - Medio", "Diana Calderon", "Jose Bustos", 21));
        }

        //Obtener Listado
        public static List<Curso> ObtenerCurso()
        {
            return listaCurso;
        }
    }
}

