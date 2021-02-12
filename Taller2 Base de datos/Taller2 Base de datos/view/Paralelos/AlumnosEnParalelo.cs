using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2_Base_de_datos.view.Paralelos
{
    class AlumnosEnParalelo
    {
        private string rut;
        private string nombreAlumno;
        private string fecha_registro;

        public string Rut { get => rut; set => rut = value; }
        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public string Fecha_registro { get => fecha_registro; set => fecha_registro = value; }
    }
}
