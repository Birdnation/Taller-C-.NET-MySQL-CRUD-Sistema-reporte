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
    class AlumnosEnParaleloController : Conexion
    {
        public List<Object> consulta(string dato, string dato2)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;
            if (dato2 == "horarioOficina")
            {
                sql = "SELECT e.rut, e.nombre, ep.fecha_registro FROM estudiante_paralelo ep, estudiante e where ((time(ep.fecha_registro) between '"+ "8:00:00" +"' and '"+ "12:30:00" +"') OR (time(ep.fecha_registro) between '"+ "14:30:00" +"' and '"+ "18:30:00" +"')) AND (ep.Paraleloid = '"+ dato +"' and ep.Estudianterut = e.rut)";
            }
            else
            {
                sql = "SELECT e.rut, e.nombre, ep.fecha_registro from estudiante e, estudiante_paralelo ep where ep.Paraleloid ='" + dato + "' and ep.Estudianterut = e.rut;";
            }

            try
            {
                MySqlConnection conexionBD = conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    AlumnosEnParalelo _alumnos = new AlumnosEnParalelo();
                    _alumnos.Rut = reader.GetString(0);
                    _alumnos.NombreAlumno = reader.GetString(1);
                    _alumnos.Fecha_registro = reader.GetString(2);

                    lista.Add(_alumnos);
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
