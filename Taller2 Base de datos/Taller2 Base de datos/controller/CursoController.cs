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
    class CursoController : Conexion
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;
            sql = "SELECT c.codigo, c.nombre, c.creditos FROM curso c";

            try
            {
                MySqlConnection conexionBD = conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Curso _curso = new Curso();
                    _curso.Codigo = reader.GetString(0);
                    _curso.Nombre = reader.GetString(1);
                    _curso.Creditos = int.Parse(reader.GetString(2));

                    lista.Add(_curso);
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
