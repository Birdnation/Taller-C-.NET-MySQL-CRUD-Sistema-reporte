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
    public partial class createParalelo : Form
    {
        public createParalelo()
        {
            InitializeComponent();
            cargarProfesor();
            cargarCurso();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rutProfe = cbxProfesor.SelectedValue.ToString();
            string CodigoCurso = cbxCurso.SelectedValue.ToString();

            try
            {
                string Codigo = textCodigoParalelo.Text;
                int bono = int.Parse(textBono.Text);

                
                if (Codigo != "" && bono > 0)
                {

                    string sql = "INSERT INTO paralelo (codigo_paralelo, Cursocodigo, Profesorrut, bono_responsabilidad) VALUES ('" + Codigo + "', '" + CodigoCurso + "','" + rutProfe + "','" + bono + "')";

                    MySqlConnection conexionBD = Conexion.conexion();
                    conexionBD.Open();

                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Registro guardado");
                        limpiar();
                        this.Close();
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
            catch (FormatException fex)
            {
                MessageBox.Show("Datos incorrectos: " + fex.Message);
            }

        }

        private void limpiar()
        {
            textBono.Text = "";
            textCodigoParalelo.Text = "";
        }

        private void cargarProfesor()
        {
            cbxProfesor.DataSource = null;
            cbxProfesor.Items.Clear();
            string query = "SELECT rut, nombre FROM profesor order by nombre ASC;";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(query, conexionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                data.Fill(dt);

                cbxProfesor.ValueMember = "rut";
                cbxProfesor.DisplayMember = "nombre";
                cbxProfesor.DataSource = dt;
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Error al cargar profesor " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void cargarCurso()
        {
            cbxCurso.DataSource = null;
            cbxCurso.Items.Clear();
            string query = "SELECT codigo, nombre FROM curso order by nombre ASC;";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(query, conexionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                data.Fill(dt);

                cbxCurso.ValueMember = "codigo";
                cbxCurso.DisplayMember = "nombre";
                cbxCurso.DataSource = dt;
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
