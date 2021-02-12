using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller2_Base_de_datos.view.Cursos;

namespace Taller2_Base_de_datos.controller
{
    class MaxMinCuentaController : Conexion
    {
        public List<Object> maxmin(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql2 = "";

            if (dato == "maximo")
            {
                sql2 = "SELECT count(c.nombre) as '" + "Cuenta" + "', c.nombre, c.codigo FROM estudiante e, curso c, estudiante_paralelo ep, paralelo p WHERE e.rut = ep.Estudianterut AND ep.Paraleloid = p.codigo_paralelo AND p.Cursocodigo = c.codigo GROUP BY c.nombre HAVING cuenta = (SELECT MAX(nuevaCuenta) FROM (SELECT COUNT(c.nombre) AS '" + "nuevaCuenta" + "', c.nombre FROM estudiante e, curso c, estudiante_paralelo ep, paralelo p WHERE e.rut = ep.Estudianterut AND ep.Paraleloid = p.codigo_paralelo AND p.Cursocodigo = c.codigo GROUP BY c.nombre) nuevaCuenta)";

            }
            else if (dato == "minimo")
            {
                sql2 = "SELECT count(c.nombre) as '" + "Cuenta" + "', c.nombre, c.codigo FROM estudiante e, curso c, estudiante_paralelo ep, paralelo p WHERE e.rut = ep.Estudianterut AND ep.Paraleloid = p.codigo_paralelo AND p.Cursocodigo = c.codigo GROUP BY c.nombre HAVING cuenta = (SELECT MIN(nuevaCuenta) FROM (SELECT COUNT(c.nombre) AS '" + "nuevaCuenta" + "', c.nombre FROM estudiante e, curso c, estudiante_paralelo ep, paralelo p WHERE e.rut = ep.Estudianterut AND ep.Paraleloid = p.codigo_paralelo AND p.Cursocodigo = c.codigo GROUP BY c.nombre) nuevaCuenta)";

            }

            try
            {
                MySqlConnection conexionBD = conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql2, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    maxMinEstudiante _maxmin = new maxMinEstudiante();
                    _maxmin.Cuenta = int.Parse(reader.GetString(0));
                    _maxmin.Nombre = reader.GetString(1);
                    _maxmin.Codigo = reader.GetString(2);

                    lista.Add(_maxmin);
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
