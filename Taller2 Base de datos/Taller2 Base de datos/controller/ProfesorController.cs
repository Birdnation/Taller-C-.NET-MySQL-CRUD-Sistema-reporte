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
    class ProfesorController : Conexion
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            if (dato == "viejo")
            {
                sql = "SELECT p.rut, p.nombre, p.fecha_contrato FROM profesor p WHERE p.fecha_contrato = (SELECT MIN(p.fecha_contrato) FROM profesor p);";
            }else if (dato == "nuevo")
            {
                sql = "SELECT p.rut, p.nombre, p.fecha_contrato FROM profesor p WHERE p.fecha_contrato = (SELECT MAX(p.fecha_contrato) FROM profesor p);";
            }
            else
            {
                sql = "SELECT * FROM profesor ORDER BY nombre ASC";
            }

            try
            {
                MySqlConnection conexionBD = conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Profesores _profesor = new Profesores();
                    _profesor.Rut = reader.GetString(0);
                    _profesor.Nombre = reader.GetString(1);
                    _profesor.Fecha_Contrato = reader.GetString(2).Split(' ')[0];
                    lista.Add(_profesor);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Datos incorrectos: " + ex.Message);
            }
            return lista;
        }

        public string bono (string dato)
        {
            MySqlDataReader reader;
            string bono= "";
            string sql;

            sql = "SELECT SUM(pa.bono_responsabilidad) FROM profesor p, paralelo pa where pa.Profesorrut = p.rut and p.rut = '" + dato + "';";
            
            try
            {
                MySqlConnection conexionBD = conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    bono = reader.GetString(0);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Datos incorrectos: " + ex.Message);
            }
            return bono;


        }
    }
}
