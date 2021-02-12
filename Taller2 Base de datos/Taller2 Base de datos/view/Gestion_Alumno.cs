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
using Taller2_Base_de_datos.view.Alumnos;


namespace Taller2_Base_de_datos.view
{
    public partial class Gestion_Alumno : Form
    {
        public Gestion_Alumno()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string add = "agregarAlumno";
            Pass contraseña = new Pass(add);
            contraseña.Show();
            
        }

        public void cargarTabla(string dato)
        {
            List<Alumnos.Alumnos> lista = new List<Alumnos.Alumnos>();
            AlumnoController _alumnoController = new AlumnoController();
            dataGridView1.DataSource = _alumnoController.consulta(dato);
        }

        public void cargarTabla2(string dato)
        {
            List<CursosAlumno> lista2 = new List<CursosAlumno>();
            CursosAlumnoController _cursosAlumnoController = new CursosAlumnoController();
            dataGridView2.DataSource = _cursosAlumnoController.consulta(dato);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dato = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cargarTabla2(dato);
            txtTotalCursos.Text = dataGridView2.RowCount.ToString();
        }

        private void btnEstudiante18_Click(object sender, EventArgs e)
        {
            string mayor = "mayor";
            cargarTabla(mayor);
            
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cargarTabla(null);
            cargarTabla2(null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string menor2017 = "menor2017";
            cargarTabla(menor2017);
        }

        private void Gestion_Alumno_Activated(object sender, EventArgs e)
        {
            cargarTabla(null);
            cargarTabla2(null);
        }
    }
}
