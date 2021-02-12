using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller2_Base_de_datos.view.Profesores;

namespace Taller2_Base_de_datos.controller
{
    class ParaleloProfesorController : Conexion
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            sql = "SELECT p.codigo_paralelo, c.nombre, pr.rut FROM paralelo p, curso c, profesor pr WHERE pr.rut = p.Profesorrut and p.Cursocodigo = c.codigo and pr.rut = '"+ dato +"';";
            try
            {
                MySqlConnection conexionBD = conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    ParalelosProfesor _paralelos = new ParalelosProfesor();
                    _paralelos.CodigoParalelo = reader.GetString(0);
                    _paralelos.NombreCurso = reader.GetString(1);
                    lista.Add(_paralelos);
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
