using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2_Base_de_datos.view.Profesores
{
    class Profesores
    {
        private string rut;
        private string nombre;
        private string fecha_Contrato;

        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Fecha_Contrato { get => fecha_Contrato; set => fecha_Contrato = value; }
    }
}
