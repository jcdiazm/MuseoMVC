using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Curso
    {
        public int Id { get; set; }
        public String Establecimiento { get; set; }
        public String NombreCurso { get; set; }
        public String ProfesorCargo { get; set; }
        public String AdultoAcomp { get; set; }
        public int CantAlumnos { get; set; }
        public Curso(int id, String establecimiento, String nombreCurso, String profesorCargo, String adultoAcomp, int cantAlumnos)
        {
            Id = id;
            Establecimiento = establecimiento;
            NombreCurso = nombreCurso;
            ProfesorCargo = profesorCargo;
            AdultoAcomp = adultoAcomp;
            CantAlumnos = cantAlumnos;
        }
    }

}

