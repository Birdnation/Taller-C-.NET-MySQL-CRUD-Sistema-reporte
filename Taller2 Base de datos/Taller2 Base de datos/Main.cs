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

namespace Taller2_Base_de_datos
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            view.Gestion_Alumno g1 = new Gestion_Alumno();
            g1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            view.Gestion_Curso g2 = new Gestion_Curso();
            g2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            view.Gestion_profesor g3 = new Gestion_profesor();
            g3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            view.Gestion_Paralelo g4 = new Gestion_Paralelo();
            g4.Show();
        }
    }
}
