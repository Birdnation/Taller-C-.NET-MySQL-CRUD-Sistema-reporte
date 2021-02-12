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
using Taller2_Base_de_datos.view;
using Taller2_Base_de_datos.view.Alumnos;
using Taller2_Base_de_datos.view.Paralelos;

namespace Taller2_Base_de_datos
{
    public partial class Pass : Form
    {
        public string Dato { get; }
        public int Bono { get; }
        public string Codparalelo { get; }
        public string Id { get; }
        public string Rut { get; }

        public Pass(string dato)
        {
            InitializeComponent();
            Dato = dato;
        }

        public Pass(string id, string rut, string dato)
        {
            InitializeComponent();
            Id = id;
            Rut = rut;
            Dato = dato;
        }

        public Pass(string id, string rut, int bono, string dato)
        {
            InitializeComponent();
            Id = id;
            Rut = rut;
            Dato = dato;
            Bono = bono;
        }

        public Pass(string id, string rut, string dato, string codparalelo)
        {
            InitializeComponent();
            Id = id;
            Rut = rut;
            Dato = dato;
            Codparalelo = codparalelo;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.Dato == "agregarAlumno" && txtPass.Text == "contraseña")
            {
                createAlumno nuevo = new createAlumno();
                nuevo.Show();
                this.Close();
            }else if (this.Dato == "eliminarAlumnoParalelo" && txtPass.Text == "contraseña")
            {
                EliminarAlumnoParalelo(this.Id, this.Rut);
                this.Close();
            }else if (this.Dato== "agregarAlumnnoParalelo" && txtPass.Text == "contraseña")
            {
                addEstudiante nuevo = new addEstudiante();
                nuevo.Show();
                this.Close();
            }else if(this.Dato == "cambiarParalelo" && txtPass.Text == "contraseña")
            {
                CambiarParaleloEstudiante(this.Id, this.Rut, this.Codparalelo);
                this.Close();
            }else if(this.Dato == "eliminarParalelo" && txtPass.Text == "contraseña")
            {
                EliminarParalelo(this.Id);
                this.Close();
            }else if(this.Dato == "actualizarProfesor" && txtPass.Text == "contraseña")
            {
                EditarProfesor(this.Id, this.Rut, this.Bono);
                this.Close();
            }else if(this.Dato == "agregarEstudianteEncargado" && txtPass.Text == "contraseña")
            {
                addEstudianteEncargado nuevo = new addEstudianteEncargado();
                nuevo.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EliminarAlumnoParalelo(string id, string rut)
        {
            string sql = "DELETE FROM estudiante_paralelo e WHERE( e.Estudianterut = '" + rut + "') AND (Paraleloid = '" + id + "');";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Estudiante Eliminado");
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

        private void CambiarParaleloEstudiante (string id, string rut, string codParalelo)
        {
            string sql = "UPDATE estudiante_paralelo SET Paraleloid = '" + codParalelo + "' WHERE (Estudianterut = '" + rut + "') and (Paraleloid = '" + id + "');";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Estudiante editado");

/*                cargarTabla2(paraleloID, null);
                cboxParalelos.DataSource = null;
                cboxParalelos.Items.Clear();
                txtRutAlumnoEditarParalelo.Text = "";*/
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void EliminarParalelo(string id)
        {
            string sql = "DELETE FROM paralelo WHERE ( codigo_paralelo = '" + id + "');";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Paralelo Eliminado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void EditarProfesor(string id, string rut, int bono)
        {

            string update = "UPDATE paralelo SET Profesorrut = '" + rut + "', bono_responsabilidad = '" + bono + "' WHERE (codigo_paralelo = '" + id + "');";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(update, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Profesor Editado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

    }
}
