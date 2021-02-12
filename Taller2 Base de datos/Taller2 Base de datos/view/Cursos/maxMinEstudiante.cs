using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2_Base_de_datos.view.Cursos
{
    class maxMinEstudiante : Conexion
    {
        private string codigo;
        private string nombre;
        private int cuenta;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Cuenta { get => cuenta; set => cuenta = value; }
    }
}
