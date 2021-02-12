using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2_Base_de_datos.view.Alumnos
{
    class Alumnos
    {
        private string rut;
        private string nombre;
        private string fechaIngreso;
        private string fechaNacimiento;

        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    }
}
