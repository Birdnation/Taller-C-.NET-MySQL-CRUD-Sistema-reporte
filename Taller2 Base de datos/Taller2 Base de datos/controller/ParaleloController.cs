using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller2_Base_de_datos.view.Paralelos;

namespace Taller2_Base_de_datos.controller
{
    class ParaleloController : Conexion
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            sql = "SELECT p.codigo_paralelo, curso.nombre, profesor.nombre, p.bono_responsabilidad, e.nombre, profesor.rut, e.rut FROM profesor, curso JOIN paralelo p ON p.Cursocodigo = curso.codigo LEFT JOIN estudiante e ON p.EstudianteEncargado = e.rut WHERE p.Cursocodigo = curso.codigo and p.Profesorrut = profesor.rut; ";
            try
            {
                MySqlConnection conexionBD = conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Paralelo _paralelo = new Paralelo();
                    _paralelo.CodParalelo = reader.GetString(0);
                    _paralelo.NombreCurso = reader.GetString(1);
                    _paralelo.NombreProfesor = reader.GetString(2);
                    _paralelo.BonoResposabilidad = int.Parse(reader.GetString(3));
                    if (reader.IsDBNull(4))
                    {
                        _paralelo.NombreEstudianteEncargado = "NULL";
                        _paralelo.RutEstudianteEncargado = "NULL";
                    }
                    else
                    {
                        _paralelo.NombreEstudianteEncargado = reader.GetString(4);
                        _paralelo.RutEstudianteEncargado = reader.GetString(6);

                    }
                    _paralelo.RutProfesor = reader.GetString(5);
                    
                    lista.Add(_paralelo);
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
