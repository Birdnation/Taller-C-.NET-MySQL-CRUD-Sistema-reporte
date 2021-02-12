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
using Taller2_Base_de_datos.view.Profesores;

namespace Taller2_Base_de_datos.view
{
    public partial class Gestion_profesor : Form
    {
        public Gestion_profesor()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            createProfesor p1 = new createProfesor();
            p1.Show();
        }

        public void cargarTabla(string dato)
        {
            List<Profesores.Profesores> lista = new List<Profesores.Profesores>();
            ProfesorController _profesorController = new ProfesorController();
            dataProfesor.DataSource = _profesorController.consulta(dato);
        }

        public void cargarTabla2(string dato)
        {
            List<ParalelosProfesor> lista2 = new List<ParalelosProfesor>();
            ParaleloProfesorController _paraleloProfesorController = new ParaleloProfesorController();
            dataGridView2.DataSource = _paraleloProfesorController.consulta(dato);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dato = dataProfesor.CurrentRow.Cells[0].Value.ToString();
            cargarTabla2(dato);
            txtTotalParalelos.Text = dataGridView2.RowCount.ToString();
            if (int.Parse(dataGridView2.RowCount.ToString()) > 0)
            {
                txtTotalBono.Text = cargaBono(dato);
            }
            else
            {
                txtTotalBono.Text = "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string viejo = "viejo";
            cargarTabla(viejo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nuevo = "nuevo";
            cargarTabla(nuevo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cargarTabla(null);
        }

        public string cargaBono(string dato)
        {
            ProfesorController bono = new ProfesorController();
            return bono.bono(dato);

        }

    }
}
