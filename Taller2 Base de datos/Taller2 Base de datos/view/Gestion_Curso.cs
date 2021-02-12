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
using Taller2_Base_de_datos.view.Cursos;

namespace Taller2_Base_de_datos.view
{
    public partial class Gestion_Curso : Form
    {
        public Gestion_Curso()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createCurso c1 = new createCurso();
            c1.Show();
        }

        public void cargarTabla(string dato)
        {
            List<Curso> lista = new List<Curso>();
            CursoController _cursoController = new CursoController();
            dataCurso.DataSource = _cursoController.consulta(dato);
        }

        public void cargarTabla2(string dato)
        {
            List<maxMinEstudiante> lista2 = new List<maxMinEstudiante>();
            MaxMinCuentaController _cuenta = new MaxMinCuentaController();
            dataGridView1.DataSource = _cuenta.maxmin(dato);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string max = "maximo";
            cargarTabla2(max);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string min = "minimo";
            cargarTabla2(min);
        }
    }
}
