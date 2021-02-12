using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2_Base_de_datos.view.Profesores
{
    class ParalelosProfesor
    {
        private string codigoParalelo;
        private string nombreCurso;

        public string CodigoParalelo { get => codigoParalelo; set => codigoParalelo = value; }
        public string NombreCurso { get => nombreCurso; set => nombreCurso = value; }
    }
}
