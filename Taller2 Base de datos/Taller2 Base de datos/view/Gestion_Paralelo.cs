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
using Taller2_Base_de_datos.controller;
using Taller2_Base_de_datos.view.Paralelos;
using Microsoft.VisualBasic;

namespace Taller2_Base_de_datos.view
{
    
    public partial class Gestion_Paralelo : Form
    {
        public Gestion_Paralelo()
        {
            InitializeComponent();
            cargarTabla(null);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createParalelo p1 = new createParalelo();
            p1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string add = "agregarAlumnnoParalelo";
            Pass contraseña = new Pass(add);
            contraseña.Show();
        }
        public void cargarTabla(string dato)
        {
            List<Paralelos.Paralelo> lista = new List<Paralelos.Paralelo>();
            ParaleloController _paraleloController = new ParaleloController();
            dataParalelo.DataSource = _paraleloController.consulta(dato);
        }

        public void cargarTabla2 (string dato, string dato2)
        {
            List<AlumnosEnParalelo> lista = new List<AlumnosEnParalelo>();
            AlumnosEnParaleloController _alumnosEnParaleloController = new AlumnosEnParaleloController();
            dataAlumnosEn.DataSource = _alumnosEnParaleloController.consulta(dato, dato2);

        }

        private void btnVerAlumnos_Click(object sender, EventArgs e)
        {
            string dato = dataParalelo.CurrentRow.Cells[0].Value.ToString();
            cargarTabla2(dato, null);
            txtTotalAlumnos.Text = dataAlumnosEn.RowCount.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataParalelo.CurrentRow != null && dataAlumnosEn.CurrentRow != null)
            {
                string paraleloID = dataParalelo.CurrentRow.Cells[0].Value.ToString();
                string rutAlumno = dataAlumnosEn.CurrentRow.Cells[0].Value.ToString();

                Pass pass = new Pass(paraleloID, rutAlumno, "eliminarAlumnoParalelo");
                pass.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un alumno inscrito en el paralelo.");
            }
            

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataAlumnosEn.CurrentRow != null)
            {
                string rutAlumno = dataAlumnosEn.CurrentRow.Cells[0].Value.ToString();
                txtRutAlumnoEditarParalelo.Text = rutAlumno;
                cargarParalelo();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un alumno inscrito en el paralelo.");
            }
            
        }

        private void cargarParalelo()
        {
            string paraleloID = dataParalelo.CurrentRow.Cells[0].Value.ToString();
            cboxParalelos.DataSource = null;
            cboxParalelos.Items.Clear();
            string query = "select p.codigo_paralelo, c.codigo from paralelo p, (select c.codigo from paralelo p, curso c where c.codigo = p.Cursocodigo and p.codigo_paralelo = '"+ paraleloID +"') c where p.Cursocodigo = c.codigo";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(query, conexionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                data.Fill(dt);

                cboxParalelos.ValueMember = "codigo_paralelo";
                cboxParalelos.DisplayMember = "codigo_paralelo";
                cboxParalelos.DataSource = dt;
                cboxParalelos.SelectedValue = paraleloID;
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

        private void button8_Click(object sender, EventArgs e)
        {
        if (dataAlumnosEn.CurrentRow != null && dataParalelo.CurrentRow != null && cboxParalelos.SelectedValue != null)
        {
            string rutAlumno = dataAlumnosEn.CurrentRow.Cells[0].Value.ToString();
            string paraleloID = dataParalelo.CurrentRow.Cells[0].Value.ToString();
            string CodigoParalelo = cboxParalelos.SelectedValue.ToString();
            string dato = "cambiarParalelo";
            Pass contraseña = new Pass(paraleloID, rutAlumno, dato, CodigoParalelo);
            contraseña.Show();
        }
        else
        {
            MessageBox.Show("No existe un alumno seleccionado.");
        }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string paraleloID = dataParalelo.CurrentRow.Cells[0].Value.ToString();
            string dato = "eliminarParalelo";
            Pass contraseña = new Pass(paraleloID, null, dato);
            contraseña.Show();
            
        }

        private void cargarProfesor()
        {
            string paraleloID = dataParalelo.CurrentRow.Cells[0].Value.ToString();
            string rutProfesor = dataParalelo.CurrentRow.Cells[5].Value.ToString();
            cbxProfesor.DataSource = null;
            cbxProfesor.Items.Clear();
            string query = "SELECT rut, nombre FROM profesor";

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
                cbxProfesor.SelectedValue = rutProfesor;
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

        private void button9_Click(object sender, EventArgs e)
        {
            txtParaleloId.Text = dataParalelo.CurrentRow.Cells[0].Value.ToString();
            txtNewBono.Text = dataParalelo.CurrentRow.Cells[3].Value.ToString();
            cargarProfesor();
        }

        private void btnActualizarProfesor_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataParalelo.CurrentRow != null && int.Parse(txtNewBono.Text) > 0 && cbxProfesor.SelectedValue != null)
                {
                    string paraleloID = dataParalelo.CurrentRow.Cells[0].Value.ToString();
                    string rutProfesor = cbxProfesor.SelectedValue.ToString();
                    int nuevoBono = int.Parse(txtNewBono.Text);
                    string dato = "actualizarProfesor";
                    Pass contraseña = new Pass(paraleloID, rutProfesor, nuevoBono, dato);
                    contraseña.Show();
                }
                else
                {
                    MessageBox.Show("debe llenar todos los campos.");
                }
            }
            catch
            {
                MessageBox.Show("Antes de editar debe seleccionar el curso y hacer clic en editar profesor.");
            }
            
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string dato = "agregarEstudianteEncargado";
            Pass contraseña = new Pass(dato);
            contraseña.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string paraleloID = dataParalelo.CurrentRow.Cells[0].Value.ToString();
            string oficina = "horarioOficina";
            cargarTabla2(paraleloID,oficina);
            txtTotalOficina.Text = dataAlumnosEn.RowCount.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cargarTabla(null);
            cargarTabla2(null, null);
            txtTotalAlumnos.Text = "";
            txtTotalOficina.Text = "";
            txtRutAlumnoEditarParalelo.Text = "";
            txtParaleloId.Text = "";
            cboxParalelos.DataSource = null;
            cboxParalelos.Items.Clear();
            cbxProfesor.DataSource = null;
            cbxProfesor.Items.Clear();
            txtNewBono.Text = "";

        }

        private void Gestion_Paralelo_Activated(object sender, EventArgs e)
        {
            cargarTabla(null);
            cargarTabla2(null, null);
            cboxParalelos.DataSource = null;
            cboxParalelos.Items.Clear();
            txtRutAlumnoEditarParalelo.Text = "";
        }
    }
}
