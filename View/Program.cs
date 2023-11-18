using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using Model;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicializar todo
            ControllerGuia.InicializarGuias();
            ControllerJefeMuseo.InicializarJefes();
            ControllerRelacionadorPublico.InicializarRelacionadorPublico();
            ControllerObraArte.InicializarObras();
            ControllerExposicion.InicializarExposiciones();
            ControllerGaleria.InicializarGaleria();
            //ControllerGaleria.ObtenerGalerias();
            ControllerCurso.InicializarCurso();
            ControllerInsumo.InicializarInsumos();
            //ControllerTourEscolar.

            //Login y todo como antes

            //Retornará "Jefe", "Guia", "Relacionador" o "Incorrecto"
            String tipoUsuario = LoginUsuario();
            if (tipoUsuario == "jefe")
            {
                int opcion = MenuJefes();
                do
                {
                    switch (opcion)
                    {
                        case 1:
                            VerListadoGuias(ControllerGuia.ObtenerGuias());
                            break;
                        case 2:
                            VerListadoObrasArtes(ControllerObraArte.ObtenerObras());
                            break;
                        case 3:
                            VerListadoExposiciones(ControllerExposicion.ObtenerExposiciones());
                            break;
                        case 4:
                            VerListadoGalerias(ControllerGaleria.ObtenerGalerias());
                            break;
                        case 5:
                            Console.WriteLine("[5] Agregar Galerias");
                            //Pedir Datos
                            Console.WriteLine("Ingrese ID: ");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese Nombre: ");
                            string nombre = Console.ReadLine();
                            Console.WriteLine("Seleccionar exposiscion a agregar");
                            VerListadoExposiciones(ControllerExposicion.ObtenerExposiciones());
                            //Deberia ser un ciclo para agregar + de 1 galeria al listado
                            Console.WriteLine("Ingresa id de exposicion: ");
                            int exp = int.Parse(Console.ReadLine());
                            List<Exposicion> listaExpoAgregar = new List<Exposicion>();
                            //buscar expo a agregar por id y guardar el obj en listado
                            foreach (Exposicion exposicion in listaExpoAgregar)
                            {
                                if (exposicion.Id == exp)
                                {
                                    listaExpoAgregar.Add(exposicion);
                                }
                            }
                            Galeria gal = new Galeria(id, nombre, listaExpoAgregar);
                            ControllerGaleria.ObtenerGalerias().Add(gal);
                            Console.WriteLine("¡GALERIA AGREGADA!");
                            break;
                        case 6:
                            //    Console.WriteLine("[6] --- Editar Galeria ---");
                            //    //agregar exp
                            //    //1- mostrar id y nombre de galeria para seleccionar
                            //    //2- mostrar id y nombre de exp de galeria actual y las disponibles
                            //    //3- seleccionar expo y agregar a galeria
                            //    foreach (var gale in listadoGalerias)
                            //    {
                            //        Console.WriteLine($"ID: {gale.Id} | {gale.Nombre}");
                            //    }
                            //    Console.WriteLine("Seleccionar Galeria: ");
                            //    int galeria_seleccionada = int.Parse(Console.ReadLine());
                            //    //Recorrer listado de galerias hasta encontrar galeria por ID
                            //    foreach (var gale in listadoGalerias)
                            //    {
                            //        if (gale.Id == galeria_seleccionada)
                            //        {
                            //            //mostrar expo actuales
                            //            Console.WriteLine("EXPOSICIONES ACTUALES EN GALERIA: ");
                            //            foreach (var expo in gale.ListadoExposiciones)
                            //            {
                            //                Console.WriteLine($"ID: {expo.Id} | {expo.Nombre}");
                            //            }
                            //            //mostrar todas las exposiciones
                            //            Console.WriteLine("Todas las exposiciones!");
                            //            foreach (var expo in listadoExposiciones)
                            //            {
                            //                Console.WriteLine($"ID: {expo.Id} | {expo.Nombre}");
                            //            }
                            //            Console.WriteLine("Seleccionar exposicion a agregar: ");
                            //            int expo_IdSeleccionada = int.Parse(Console.ReadLine());
                            //            //buscar el obj
                            //            Exposicion expoBuscada = BuscaExposicion(expo_IdSeleccionada, listadoExposiciones);
                            //            if (expoBuscada != null)
                            //            {
                            //                bool existeExpo = false;
                            //                //Verificar si exposicion existe en galeria
                            //                foreach (var expo in gale.ListadoExposiciones)
                            //                {
                            //                    if (expo.Id == expoBuscada.Id)
                            //                    {
                            //                        Console.WriteLine("Ya existe la exposicion en esta galeria");
                            //                        existeExpo = true;
                            //                        break;
                            //                    }
                            //                }
                            //                //si no se encuentra la exposicion, agregar a la galeria
                            //                if (existeExpo)
                            //                {
                            //                    gale.ListadoExposiciones.Add(expoBuscada);
                            //                    Console.WriteLine("Exposicion Agregada");
                            //                }
                            //            }

                            //        }

                            //    }
                            break;
                        case 7:
                            AsignarGuia();
                        break;
                        case 8:
                            VerListadoToursE(ControllerTourEscolar.ObtenerToursEscolares());    
                        break;
                        case 0:
                            Console.WriteLine("[0] Salir de la APP");
                            Console.ReadLine();
                            Environment.Exit(0);
                        break;
                    }
                    opcion = MenuJefes();
                } while (opcion >= 0 && opcion <= 8);
                Console.ReadLine();
            }
            else if (tipoUsuario == "guia")
            {
                int opcion = MenuGuia();
                do
                {
                    switch (opcion)
                    {
                        case 1:
                            VerListadoGalerias(ControllerGaleria.ObtenerGalerias());
                            break;
                        case 2:
                            VerListadoInsumos(ControllerInsumo.ObtenerInsumos());
                            break;
                        case 0:
                            Console.WriteLine("Saliendo de la aplicación...");
                            Console.ReadLine();
                            Environment.Exit(0);
                            break;
                    }
                    opcion = MenuGuia();
                } while (opcion >= 0 && opcion <= 3);
                Console.ReadLine();
            }
            else if (tipoUsuario == "relacionador")
            {
                int opcion = MenuRelacionadorPublico();
                do
                {
                    switch (opcion)
                    {
                        case 1:
                            VerListadoExposiciones(ControllerExposicion.ObtenerExposiciones());
                            break;
                        case 2:
                            Console.WriteLine("Verificar Documentos");
                            break;
                        case 3:
                            Console.WriteLine("Registrar Establecimiento Visitante");
                            break;
                        case 0:
                            Console.WriteLine("Saliendo de la aplicación...");
                            Console.ReadLine();
                            Environment.Exit(0);
                            break;
                    }
                    opcion = MenuGuia();
                } while (opcion >= 0 && opcion <= 3);
                Console.ReadLine();
            }
            else { Console.WriteLine("Usuario o Clave incorrectos"); }

        }
        static void VerListadoGuias(List<Guia> listadoGuias)
        {
            Console.WriteLine("---Listado de Guias---");
            foreach (var guia in listadoGuias)
            {
                Console.WriteLine($"ID: {guia.Id}|Usuario: {guia.Usuario}");
                Console.WriteLine($"Nombre: { guia.Nombre} { guia.Apellido}");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static String LoginUsuario()
        {
            Console.WriteLine("Ingrese usuario: ");
            String usuario = Console.ReadLine();
            Console.WriteLine("Ingrese contraseña");
            String password = Console.ReadLine();
            //Verificar si es admin
            foreach (JefeMuseo jefe in ControllerJefeMuseo.ObtenerJefeMuseo())
            {
                if (jefe.Usuario == usuario && jefe.Password == password)
                {
                    return "jefe";
                }
            }
            //Verificar si es guia
            foreach (Guia guia in ControllerGuia.ObtenerGuias())
            {
                if (guia.Usuario == usuario && guia.Password == password)
                {
                    return "guia";
                }
            }
            //Verificar si es Relacionador
            foreach (RelacionadorPublico relacionador in ControllerRelacionadorPublico.ObtenerRelacionadorPublico())
            {
                if (relacionador.Usuario == usuario && relacionador.Password == password)
                {
                    return "relacionador";
                }
            }
            return "Incorrecto";
        }
        static int MenuJefes()
        {
            Console.WriteLine("--Menu Jefe de Museo--");
            Console.WriteLine("[1] Ver listado de Guias");
            Console.WriteLine("[2] Ver listado de Obras de Arte");
            Console.WriteLine("[3] Ver listado de Exposiciones");
            Console.WriteLine("[4] Ver listado de Galerias");
            Console.WriteLine("[5] Agregar Galeria");
            Console.WriteLine("[6] Editar Galeria (Agregar Exposicion, verificar primero que no )");
            Console.WriteLine("[7] Asignar Guia");
            Console.WriteLine("[8] Ver Tours");
            Console.WriteLine("[0] Salir");
            Console.WriteLine("Selecciona una opcion: ");
            int opcion = int.Parse(Console.ReadLine());
            return opcion;
        }
        static int MenuGuia()
        {
            Console.WriteLine("--Menu Guia--");
            Console.WriteLine("[1] Ver listado de Galerias");
            Console.WriteLine("[2] Ver listado de Insumos");
            Console.WriteLine("[0] Salir");
            Console.WriteLine("Selecciona una opcion: ");
            int opcion = int.Parse(Console.ReadLine());
            return 0;
        }
        static int MenuRelacionadorPublico()
        {
            Console.WriteLine("--Menu Relacionador Publico--");
            Console.WriteLine("[1] Ver listado de Exposiciones");
            Console.WriteLine("[2] Verificar Documentos");
            Console.WriteLine("[3] Registrar Establecimiento Visitante");
            Console.WriteLine("[0] Salir");
            Console.WriteLine("Selecciona una opcion: ");
            int opcion = int.Parse(Console.ReadLine());
            return 0;
        }
        static void VerListadoObrasArtes(List<ObraArte> VerListadoObrasArtes)
        {
            foreach (var item in VerListadoObrasArtes)
            {
                Console.WriteLine($"ID: {item.Id} - | Nombre: {item.Nombre} ");
                Console.WriteLine($"Autor:  - {item.Autor} - | Fecha: {item.Fecha}");
                Console.WriteLine($"Descripcion { item.Descripcion}");
                Console.WriteLine("------------------------------------------");
            }
        }
        static void VerListadoExposiciones(List<Exposicion> VerListadoExposiciones)
        {
            foreach (Exposicion expo in VerListadoExposiciones)
            {
                Console.WriteLine($"---------Exposicion N°: {expo.Id} -------");
                Console.WriteLine($"{expo.Nombre}");
                Console.WriteLine($"Fecha: {expo.FechaInicio} - {expo.FechaTermino}");
                //IMPRIMIR LISTADO DE OBRAS DE LA EXPOSICION
                Console.WriteLine("-------------Obras de exposicion actual:   ");
                VerListadoObrasArtes(expo.ListadoObras);
                Console.WriteLine("Fin de Exposicion");
                Console.WriteLine();
            }

        }
        static void VerListadoGalerias(List<Galeria> listadoGalerias)
        {
            foreach (Galeria gal in listadoGalerias)
            {
                Console.WriteLine($"--------GALERIA N° {gal.Id}--------");
                Console.WriteLine(gal.Nombre);
                VerListadoExposiciones(gal.ListadoExposiciones);
                Console.WriteLine("----Fin Galeria------");
                Console.WriteLine();
            }
        }
        static void VerListadoToursE(List<TourEscolar> listadoToursE)
        {
            Console.WriteLine("------Tours Escolares-----");
            foreach (TourEscolar tour in ControllerTourEscolar.ObtenerToursEscolares())
            {
                Console.WriteLine($"ID: {tour.Id}");
                VerListadoGuias(tour.GuiaAsignados);
                Console.WriteLine($"Estado: {tour.Estado}");
                Console.WriteLine("------------------------");
            }
        }
        static void VerListadoInsumos(List<Insumo> VerListadoInsumos)
        {
            foreach (var item in VerListadoInsumos)
            {
                Console.WriteLine($"ID: {item.Id} - | Nombre: {item.Nombre} ");
                Console.WriteLine($"Descripcion { item.Descripcion}");
                Console.WriteLine("------------------------------------------");
            }
        }
        static void AsignarGuia()
        {
            ControllerTourEscolar.CrearTourEscolar();
            VerListadoToursE(ControllerTourEscolar.ObtenerToursEscolares());
            int idTour = 1; //se pide a usuario ingresar id
            VerListadoGuias(ControllerGuia.ObtenerGuias());
            Console.WriteLine("Ingrese ID de Guia");
            //Falta try y catch
            int idBuscado = Convert.ToInt32(Console.ReadLine());
            //Ej con 1 guia en listado
            List<Guia> guias = new List<Guia>();
            Guia guiaEncontrado = ControllerGuia.ObtenerGuias().Find(guia => guia.Id == idBuscado);
            if (guiaEncontrado == null)
            {
                Console.WriteLine("No se encontro Guia");
            }
            else
            {
                guias.Add(guiaEncontrado);
                Console.WriteLine("Guias a agregar");
                VerListadoGuias(guias);
                bool creado = ControllerTourEscolar.AgregarGuias(idTour, guias);
            }
            VerListadoToursE(ControllerTourEscolar.ObtenerToursEscolares());
        }
    }   
}
