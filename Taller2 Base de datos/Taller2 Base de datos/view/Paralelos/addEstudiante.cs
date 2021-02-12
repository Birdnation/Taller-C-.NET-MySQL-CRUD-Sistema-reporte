using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller2_Base_de_datos.view.Paralelos
{
    public partial class addEstudiante : Form
    {
        public addEstudiante()
        {
            InitializeComponent();
            cargarAlumno();
            cargarParalelo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string rutAlumno = "";
                string CodigoParalelo = "";
                if (cbxEstudiante.SelectedValue != null && cbxParalelo.SelectedValue != null)
                {
                    rutAlumno = cbxEstudiante.SelectedValue.ToString();
                    CodigoParalelo = cbxParalelo.SelectedValue.ToString();
                }

                string hoy = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                string sql = "INSERT INTO estudiante_paralelo (Estudianterut, Paraleloid, fecha_registro) VALUES ('" + rutAlumno + "', '" + CodigoParalelo + "','" + hoy + "')";

                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();
                if (rutAlumno != "" && CodigoParalelo != "")
                {
                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Registro guardado");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al guardar: " + ex.Message);
                    }
                    finally
                    {
                        conexionBD.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Datos incorrectos: ");
            }
        }

        private void cargarAlumno()
        {
            cbxEstudiante.DataSource = null;
            cbxEstudiante.Items.Clear();
            string query = "SELECT rut FROM estudiante";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(query, conexionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                data.Fill(dt);

                cbxEstudiante.ValueMember = "rut";
                cbxEstudiante.DisplayMember = "rut";
                cbxEstudiante.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar estudiante " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void cargarParalelo()
        {
            cbxParalelo.DataSource = null;
            cbxParalelo.Items.Clear();
            string query = "SELECT codigo_paralelo FROM paralelo";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(query, conexionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                data.Fill(dt);

                cbxParalelo.ValueMember = "codigo_paralelo";
                cbxParalelo.DisplayMember = "codigo_paralelo";
                cbxParalelo.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar profesor " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
