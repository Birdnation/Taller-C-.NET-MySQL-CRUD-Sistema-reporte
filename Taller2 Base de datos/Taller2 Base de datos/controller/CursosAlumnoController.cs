using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller2_Base_de_datos.view.Alumnos;

namespace Taller2_Base_de_datos.controller
{
    class CursosAlumnoController : Conexion
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            sql = "SELECT p.codigo_paralelo, c.nombre from estudiante e, estudiante_paralelo ep, paralelo p, curso c where e.rut = ep.Estudianterut and ep.Paraleloid = p.codigo_paralelo and p.Cursocodigo = c.codigo and e.rut = '"+ dato +"';";
            try
            {
                MySqlConnection conexionBD = conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    CursosAlumno _alumno = new CursosAlumno();
                    _alumno.CodigoParalelo = reader.GetString(0);
                    _alumno.NombreCurso = reader.GetString(1);
                    lista.Add(_alumno);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Datos incorrectos: " + ex.Message);
            }
            return lista;
        }
    }
}
