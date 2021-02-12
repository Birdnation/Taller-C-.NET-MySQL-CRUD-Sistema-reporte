using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2_Base_de_datos.view.Paralelos
{
    class Paralelo
    {
        private string codParalelo;
        private string nombreCurso;
        private string nombreProfesor;
        private int bonoResposabilidad;
        private string nombreEstudianteEncargado;
        private string rutProfesor;
        private string rutEstudianteEncargado;


        public string CodParalelo { get => codParalelo; set => codParalelo = value; }
        public string NombreCurso { get => nombreCurso; set => nombreCurso = value; }
        public string NombreProfesor { get => nombreProfesor; set => nombreProfesor = value; }
        public int BonoResposabilidad { get => bonoResposabilidad; set => bonoResposabilidad = value; }
        public string NombreEstudianteEncargado { get => nombreEstudianteEncargado; set => nombreEstudianteEncargado = value; }
        public string RutProfesor { get => rutProfesor; set => rutProfesor = value; }
        public string RutEstudianteEncargado { get => rutEstudianteEncargado; set => rutEstudianteEncargado = value; }
    }
}
