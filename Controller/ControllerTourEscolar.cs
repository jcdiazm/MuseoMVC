using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class ControllerTourEscolar
    {
        private static List<TourEscolar> toursEscolares = new List<TourEscolar>();
        public static List<TourEscolar> ObtenerToursEscolares()
        {
            return toursEscolares;
        }

        public static bool CrearTourEscolar()
        {
            //Try Catch
            int id = toursEscolares.Count + 1;
            List<Guia> guias = new List<Guia>();
            toursEscolares.Add(new TourEscolar(id, guias, "solicitado."));
            return true;
        }

        public static bool AgregarGuias(int idBuscado, List<Guia> guias)
        {
            //try catch
            //Buscar Tour
            foreach (TourEscolar tour in toursEscolares)
            {
                if (idBuscado == tour.Id)
                {
                    tour.GuiaAsignados = guias;
                    return true;
                 }
            }return false;
        }




    }
}
