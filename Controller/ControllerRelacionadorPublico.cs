using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

public class ControllerRelacionadorPublico
{
    //Lista Privada
    private static List<RelacionadorPublico> listaRelacionadorPublico = new List<RelacionadorPublico>();

    //Inicializador
    public static void InicializarRelacionadorPublico()
    {
        listaRelacionadorPublico.Add(new RelacionadorPublico(1, "mgonzalez", "Miguel", "Gonzalkez", "12347"));
        listaRelacionadorPublico.Add(new RelacionadorPublico(2, "opereira", "Orlando", "Pereira", "12348"));
    }

    //Obtener Listado
    public static List<RelacionadorPublico> ObtenerRelacionadorPublico()
    {
        return listaRelacionadorPublico;
    }
}
