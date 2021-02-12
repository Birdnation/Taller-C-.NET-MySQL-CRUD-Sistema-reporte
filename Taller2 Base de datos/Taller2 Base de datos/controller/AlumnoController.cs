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
    class AlumnoController : Conexion
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;
            if (dato == "mayor")
            {
                sql = "SELECT * FROM estudiante e WHERE (YEAR(now()) - YEAR(e.fecha_nacimiento)) < 18 ORDER BY nombre ASC;";
            }
            else if (dato == "menor2017")
            {
                sql = "SELECT * FROM estudiante e where year(fecha_ingreso)<2017;";
            }
            else
            {
                sql = "SELECT * FROM estudiante ORDER BY nombre ASC";
            }
            
            try
            {
                MySqlConnection conexionBD = conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Alumnos _alumno = new Alumnos();
                    _alumno.Rut = reader.GetString(0);
                    _alumno.Nombre = reader.GetString(1);
                    _alumno.FechaIngreso = reader.GetString(2).Split(' ')[0];
                    _alumno.FechaNacimiento = reader.GetString(3).Split(' ')[0];
                    lista.Add(_alumno);
                }
            }catch(MySqlException ex)
            {
                MessageBox.Show("Datos incorrectos: " + ex.Message);
            }
            return lista;
        }
    }
}
